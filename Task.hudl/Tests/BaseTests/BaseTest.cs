using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluidOne.ClientTesting.Dash.Tests.BaseTests
{
    public class BaseTest<T> where T : IWebDriver, new()
    {
        public IWebDriver driver;
        public int waitPeriod = 30;
        public string accountCode = "FLU010";
        public string email = "kemiwilloughby@fluidone.com";
        public string password = "Secure123";
        public string baseURL = "https://192.168.101.159:444/devldn/Mars";
       // public string baseURL = "http://localhost:8001";

        [SetUp]
        public void SetupTest()
        {
            driver = new T();
            driver.Navigate().GoToUrl(baseURL + "/Login/ExpiredSession");
            if (driver.Title.Contains("This site isn’t secure") || driver.Title == "Certificate error: Navigation blocked") // IE / EDGE
            {
                driver.Navigate().GoToUrl("javascript:document.getElementById('overridelink').click()");
            }
            driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void TearDown()
        {
            try
            {
                if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
                {
                    driver.SaveScreenshot(TestContext.CurrentContext);
                }
            }
            finally
            {
                driver.Quit();
            }
        }
    }
}
