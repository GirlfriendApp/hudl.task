using System;
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

    public class LiveConnectionsPage<T> : BaseTest<T> where T : IWebDriver, new()
    {

        [SetUp]
        public void setup()
        {
            var login = new LoginPage(driver);
            driver.FindElement(By.CssSelector("body > div.cookieSection > div > button")).Click();
            login.Login(accountCode, email, password);
        }

        [Test]
        public void LiveConnection_Test_46()
        {

            var liveconnections = new LiveConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            liveconnections.ImpersonateCOS010();

            driver.Navigate().GoToUrl(baseURL + "/Support/LiveConnection");
            liveconnections.EditPOref("Test PO Ref");
            Assert.AreEqual("Test PO Ref", driver.FindElement(By.CssSelector("#EditPOReference")).Text);


        }

        [Test]
        public void LiveConnection_Test_47()
        {

            var liveconnections = new LiveConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            liveconnections.ImpersonateBEA010();

            driver.Navigate().GoToUrl(baseURL + "/Support/LiveConnection");

            liveconnections.EditSiteRef("Test Site Ref");
            Assert.AreEqual("Test Site Ref", driver.FindElement(By.CssSelector("#EditSiteReference")).Text);
        }

        [Test]
        public void LiveConnection_Test_48()
        {

            var liveconnections = new LiveConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            liveconnections.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Support/LiveConnection");
            liveconnections.EditSiteRef("Test Circuit Note");
            Assert.AreEqual("Test Circuit Note", driver.FindElement(By.CssSelector("#EditCircuitNote")).Text);
        }

        [Test]
        public void LiveConnection_Test_49()
        {

            var liveconnections = new LiveConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            liveconnections.ImpersonateCOS010();

            driver.Navigate().GoToUrl(baseURL + "/Support/LiveConnection");
            liveconnections.EditSiteRef("Test Site Ref");
            Assert.AreEqual("Test Site Ref", driver.FindElement(By.CssSelector("#EditSiteReference")).Text);
        }

        [Test]
        public void LiveConnection_Test_50()
        {

            var liveconnections = new LiveConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            liveconnections.ImpersonateBEA010();

            driver.Navigate().GoToUrl(baseURL + "/Support/LiveConnection");
            driver.Navigate().GoToUrl(baseURL + "/Support/LiveConnection");
            liveconnections.EditPOref("Test PO Ref");
            Assert.AreEqual("Test PO Ref", driver.FindElement(By.CssSelector("#EditPOReference")).Text);
        }

        [Test]
        public void LiveConnection_Test_51()
        {

            var liveconnections = new LiveConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            liveconnections.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Support/LiveConnection");
          
            liveconnections.EditPOref("Test PO Ref");
            Assert.AreEqual("Test PO Ref", driver.FindElement(By.CssSelector("#EditPOReference")).Text);
        }
        [Test]
        public void LiveConnection_Test_52()
        {

            var liveconnections = new LiveConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            liveconnections.ImpersonateCOS010();

            driver.Navigate().GoToUrl(baseURL + "/Support/LiveConnection");
            liveconnections.EditSiteRef("Test Circuit Note");
            Assert.AreEqual("Test Circuit Note", driver.FindElement(By.CssSelector("#EditCircuitNote")).Text);
        }

        [Test]
        public void LiveConnection_Test_53()
        {

            var liveconnections = new LiveConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            liveconnections.ImpersonateBEA010();

            driver.Navigate().GoToUrl(baseURL + "/Support/LiveConnection");
            liveconnections.EditSiteRef("Test Circuit Note");
            Assert.AreEqual("Test Circuit Note", driver.FindElement(By.CssSelector("#EditCircuitNote")).Text);
        }

        [Test]
        public void LiveConnection_Test_54()
        {

            var liveconnections = new LiveConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            liveconnections.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Support/LiveConnection");
            liveconnections.EditSiteRef("Test Site Ref");
            Assert.AreEqual("Test Site Ref", driver.FindElement(By.CssSelector("#EditSiteReference")).Text);
        }

        [Test]
        public void LiveConnection_Test_55()
        {

            var liveconnections = new LiveConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            liveconnections.ImpersonateCOS010();

            driver.Navigate().GoToUrl(baseURL + "/Support/LiveConnection");
            liveconnections.ClickDetailsBtn();

            Assert.AreEqual("Connection Information", driver.FindElement(By.CssSelector("div.body-inner > h1")));
        }

        [Test]
        public void LiveConnection_Test_56()
        {

            var liveconnections = new LiveConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            liveconnections.ImpersonateBEA010();

            driver.Navigate().GoToUrl(baseURL + "/Support/LiveConnection");
            liveconnections.ClickDetailsBtn();

            Assert.AreEqual("Connection Information", driver.FindElement(By.CssSelector("div.body-inner > h1")));
        }

        [Test]
        public void LiveConnection_Test_57()
        {

            var liveconnections = new LiveConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            liveconnections.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Support/LiveConnection");
            liveconnections.ClickDetailsBtn();

            Assert.AreEqual("Connection Information", driver.FindElement(By.CssSelector("div.body-inner > h1")));

        }
    }
}

