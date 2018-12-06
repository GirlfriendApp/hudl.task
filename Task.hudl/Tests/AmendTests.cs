using NUnit.Framework;
using OpenQA.Selenium;
using System.Linq;
using NUnit.Framework.Interfaces;
using FluidOne.ClientTesting.Dash.Tests.BaseTests;
using FluidOne.ClientTesting.Dash.PageObjects;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text;
using FluidOne.ClientTesting.Dash;
using System.Threading;


namespace FluidOne.ClientTesting.Dash.Tests.BaseTests
{
    [TestFixture(typeof(Firefox))]
    [TestFixture(typeof(InternetExplorer))]
    [TestFixture(typeof(Chrome))]
    [TestFixture(typeof(Edge))]

    public class AmendPage<T> : BaseTest<T> where T : IWebDriver, new()
    {

        [SetUp]
        public void setup()
        {
            var login = new LoginPage(driver);
            driver.FindElement(By.CssSelector("body > div.cookieSection > div > button")).Click();
            login.Login(accountCode, email, password);
        }



        [Test]
        public void Provisioning_Amend_Test_24()
        {

            var amend = new AmendPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            amend.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/Amend");
            amend.BTChangedRequiredDateTest("");


            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));

        }

        [Test]
        public void Provisioning_Amend_Test_25()
        {

            var amend = new AmendPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            amend.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/Amend");
            amend.BTNewAptTest("");


            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));

        }

        [Test]
        public void Provisioning_Amend_Test_26()
        {

            var amend = new AmendPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            amend.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/Amend");
            amend.BTAmendL3Test("");


            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));

        }

        [Test]
        public void Provisioning_Amend_Test_27()
        {

            var amend = new AmendPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            amend.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/Amend");
            amend.BTLiveOrderTest("");


            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));

        }

        [Test]
        public void Provisioning_Amend_Test_28()
        {

            var amend = new AmendPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            amend.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/Amend");
            amend.TTChangedRequiredDateTest("");


            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));

        }

        [Test]
        public void Provisioning_Amend_Test_29()
        {

            var amend = new AmendPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            amend.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/Amend");
            amend.TTNewAptTest("");


            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));

        }

        [Test]
        public void Provisioning_Amend_Test_30()
        {

            var amend = new AmendPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            amend.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/Amend");
            amend.TTAmendL3Test("");


            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));

        }

        [Test]
        public void Provisioning_Amend_Test_31()
        {

            var amend = new AmendPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            amend.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/Amend");
            amend.TTLiveOrderTest("");


            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));
        }
    }
}
