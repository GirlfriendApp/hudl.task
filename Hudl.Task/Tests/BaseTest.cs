using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hudl.Task
{
    public class BaseTest<T> where T : IWebDriver, new()
    {
        public IWebDriver driver;
        public int waitPeriod = 30;
        //public string email = "kemiwilloughby@gmail.com";
       // public string password = "Oluwakemi1!";
        public string baseURL = "https://www.hudl.com/en_gb/";
     

        [SetUp]
        public void SetupTest()
        {
            driver = new T();
            driver.Navigate().GoToUrl(baseURL);
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
