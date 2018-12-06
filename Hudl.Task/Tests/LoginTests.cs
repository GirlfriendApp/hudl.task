using NUnit.Framework;
using OpenQA.Selenium;
using System.Linq;
using NUnit.Framework.Interfaces;

using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text;
using FluidOne.ClientTesting.Dash;
using System.Threading;
using Task.Hudl;

namespace Hudl.Task.Tests.BaseTests
{
  
    [TestFixture(typeof(InternetExplorer))]
    [TestFixture(typeof(Chrome))]
    [TestFixture(typeof(Edge))]

    public class LoginPage<T> : BaseTest<T> where T : IWebDriver, new()
    {

        [SetUp]
        public void setup()
        {
            var login = new LoginPage(driver);

            driver.Navigate().GoToUrl(baseURL);
            driver.FindElement(By.CssSelector("body > div.cookieSection > div > button")).Click();
        }



        [Test]
        public void Login_Test_1()
        {
            var login = new LoginPage(driver);
            login.SuccessfulLogin("Kemiwilloughby@gmail.com", "oluwakemi1");
            
            Assert.AreEqual("QA Hire Project", driver.FindElement(By.CssSelector("#App > a > div.hui-primaryteamswitcher__display-name > span")));

        }

        [Test]
        public void Login_Test_2()
        {
            var login = new LoginPage(driver);
            login.UnsuccessfulLoginNoInfo();

            Assert.AreEqual("We didn't recognize that email and/or password.", driver.FindElement(By.CssSelector("body > div.super-wrap > form.login-container > div.login-error.fade-in-expand > div > p")));
        }

        [Test]
        public void Login_Test_3()
        {
            var login = new LoginPage(driver);
            login.UnsuccessfulLoginIncorrectEmail("oluwakemi1");

            Assert.AreEqual("We didn't recognize that email and/or password.", driver.FindElement(By.CssSelector("body > div.super-wrap > form.login-container > div.login-error.fade-in-expand > div > p")));
        }

        [Test]
        public void Login_Test_4()
        {
            var login = new LoginPage(driver);
            login.UnsuccessfulLoginIncorrectPassword("kemiwilloughby@gmail.com");

            Assert.AreEqual("We didn't recognize that email and/or password.", driver.FindElement(By.CssSelector("body > div.super-wrap > form.login-container > div.login-error.fade-in-expand > div > p")));

        }
        [Test]
        public void Login_Test_5()
        {
            var login = new LoginPage(driver);
            login.IncorrectPasswordFiveTimes("kemiwilloughby@gmail.com");

            Assert.AreEqual("Can’t remember? Don’t stress.", driver.FindElement(By.CssSelector("body > div.super-wrap > form.login-container > div.login-error.fade-in-expand > div")));

        }
    }

}