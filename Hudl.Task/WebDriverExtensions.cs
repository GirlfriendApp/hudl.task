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

using System.Threading;

namespace Hudl.Task
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


       

    }
}
