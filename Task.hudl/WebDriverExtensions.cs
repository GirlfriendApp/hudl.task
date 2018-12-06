using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static NUnit.Framework.TestContext;
using FluidOne.ClientTesting.Dash.Entities;
using System.Threading;

namespace FluidOne.ClientTesting.Dash
{
    public static class WebDriverExtensions
    {

        public static IWebElement FindElement(this IWebDriver driver, By by, int timeoutInSeconds)
        {
            if (timeoutInSeconds > 0)
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
                return wait.Until(drv => drv.FindElement(by));
            }
            return driver.FindElement(by);
        }
        public static IWebElement FindElement(this IWebDriver driver, By by, int timeoutInSeconds, Func<IWebElement, bool> requirements)
        {
            if (timeoutInSeconds > 0)
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
                return wait.Until(drv => drv.FindElements(by).First(requirements));
            }
            return driver.FindElements(by).First(requirements);
        }
        public static ReadOnlyCollection<IWebElement> FindElements(this IWebDriver driver, By by, int timeoutInSeconds)
        {
            if (timeoutInSeconds > 0)
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
                return wait.Until(drv => drv.FindElements(by));
            }
            return driver.FindElements(by);
        }


        public static IWebElement WaitForElementToDisplay(this IWebDriver driver, By by, int timeoutInSeconds, string ExceptionText = "Error_Not_Found")
        {
            for (int i = 0; i < timeoutInSeconds; i++)
            {
                try
                {
                    if (timeoutInSeconds > 0)
                    {
                        var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(1));
                        wait.Until(drv => drv.FindElements(by).Any(x => x.Displayed));
                    }
                    var element = driver.FindElement(by);
                    if (element.Displayed)
                    {
                        return element;
                    }
                }
                catch
                { }
            }
            throw new Exception(ExceptionText);
        }

        public static void SaveScreenshot(this IWebDriver driver, TestContext testContext)
        {
            var testName = testContext.Test.MethodName + "_" + string.Join("_", testContext.Test.Arguments);
            driver.SaveScreenshot($"{DateTime.Now.ToString("yyyy-MM-dd-HH.mm.ss")}_{testContext.Result.Outcome.Status}_{testContext.Result.Outcome.Label}_{testName}.png");
        }

        public static void SaveScreenshot(this IWebDriver driver, string filename)
        {
            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            string screenshot = ss.AsBase64EncodedString;
            byte[] screenshotAsByteArray = ss.AsByteArray;

            var name = driver.GetType().Name;
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + $"/Tests/{name}/";
            System.IO.Directory.CreateDirectory(path);
            ss.SaveAsFile(path + filename, ScreenshotImageFormat.Png);
        }

        public static void ClickAndSendKeys(this IWebElement element, string keys)
        {
            element.Click();
            element.SendKeys(keys);
        }


        public static void Login(this IWebDriver driver, string email, string accountCode, string password, string baseUrl)
        {
            using (PortalEntities context = new PortalEntities()) //Makes a new PortalEntities - Link to the data
            {
                int userId = context.UserAccounts
                    .First(o => o.Email == email && o.Account.AccountCode == accountCode)
                    .UserAccountID;

                driver.Navigate().GoToUrl(baseUrl + "/Login/ExpiredSession");
                driver.Manage().Window.Maximize();

                if (driver.Title.Contains("This site isn’t secure") || driver.Title == "Certificate error: Navigation blocked") // IE / EDGE
                {
                    driver.Navigate().GoToUrl("javascript:document.getElementById('overridelink').click()");
                }

                driver.FindElement(By.Id("Account"), 60).Clear();
                driver.FindElement(By.Id("Account")).ClickAndSendKeys(accountCode);
                driver.FindElement(By.Id("Email")).ClickAndSendKeys(email);
                driver.FindElement(By.Id("Password")).ClickAndSendKeys(password);

                driver.FindElement(By.CssSelector("input.btn.button-action-secondary")).Click();

                try
                {
                    var code = context.SMSCodes.OrderByDescending(x => x.Created).FirstOrDefault(x => x.UserAccountID == userId)?.Code;
                    driver.FindElement(By.Id("SmsCode")).ClickAndSendKeys(code);
                    driver.FindElement(By.Id("nextButton")).Click();
                }
                // We didn't have to reauthenticate
                catch (Exception e) { }
            }
        }

        public static void Impersonate(this IWebDriver driver, string accountCode, string baseUrl)
        {
            driver.Navigate().GoToUrl(baseUrl + "/Admin/UserManagement");
            driver.FindElement(By.Id("Search"), 60).ClickAndSendKeys(accountCode);
            driver.FindElement(By.CssSelector("label[for='IncludeRelatedAccounts']")).Click();
            driver.FindElement(By.CssSelector("input[value='Search']")).Click();
            driver.FindElements(By.CssSelector("#users_table td a[title='Impersonate']"), 30).First(x => x.Displayed).Click();
        }

    }
}
