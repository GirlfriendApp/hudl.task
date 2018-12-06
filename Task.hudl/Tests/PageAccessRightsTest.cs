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

    public class PageAccessRights<T> : BaseTest<T> where T : IWebDriver, new()
    {

        [SetUp]
        public void setup()
        {
            var login = new LoginPage(driver);
            driver.FindElement(By.CssSelector("body > div.cookieSection > div > button")).Click();
            login.Login(accountCode, email, password);
        }
        [Test]
        public void PageAccessRights_Test_1()
        {
            var pageaccessrights = new PageAccessRights(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            pageaccessrights.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Admin/LuxReport");

            Assert.AreEqual("Performance Reports", driver.FindElement(By.CssSelector("div.body-outer.col-xs-9.col-sm-9.col-md-9.col-lg-10 > div.body-inner > h1")).Text);

        }
        [Test]
        public void PageAccessRights_Test_2()
        {
            var pageaccessrights = new PageAccessRights(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            pageaccessrights.ImpersonateBEA010();

            driver.Navigate().GoToUrl(baseURL + "/Admin/LuxReport");

            Assert.AreEqual("Performance Reports", driver.FindElement(By.CssSelector("div.body-outer.col-xs-9.col-sm-9.col-md-9.col-lg-10 > div.body-inner > h1")).Text);

        }
        [Test]
        public void PageAccessRights_Test_3()
        {
            var pageaccessrights = new PageAccessRights(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            pageaccessrights.ImpersonateCOS010();

            driver.Navigate().GoToUrl(baseURL + "/Admin/LuxReport");

            Assert.AreEqual("Performance Reports", driver.FindElement(By.CssSelector("div.body-outer.col-xs-9.col-sm-9.col-md-9.col-lg-10 > div.body-inner > h1")).Text);

        }
        [Test]
        public void PageAccessRights_Test_4()
        {
            var pageaccessrights = new PageAccessRights(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            pageaccessrights.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Admin/Notifications");

            Assert.AreEqual("Subscribe/Unsubscribe from Email Notifications", driver.FindElement(By.CssSelector("div.body-outer.col-xs-9.col-sm-9.col-md-9.col-lg-10 > div.body-inner > form > h1")).Text);

        }
        [Test]
        public void PageAccessRights_Test_5()
        {
            var pageaccessrights = new PageAccessRights(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            pageaccessrights.ImpersonateBEA010();

            driver.Navigate().GoToUrl(baseURL + "/Admin/Notifications");

            Assert.AreEqual("Subscribe/Unsubscribe from Email Notifications", driver.FindElement(By.CssSelector("div.body-outer.col-xs-9.col-sm-9.col-md-9.col-lg-10 > div.body-inner > form > h1")).Text);

        }
        [Test]
        public void PageAccessRights_Test_6()
        {
            var pageaccessrights = new PageAccessRights(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            pageaccessrights.ImpersonateCOS010();

            driver.Navigate().GoToUrl(baseURL + "/Admin/Notifications");

            Assert.AreEqual("Subscribe/Unsubscribe from Email Notifications", driver.FindElement(By.CssSelector("div.body-outer.col-xs-9.col-sm-9.col-md-9.col-lg-10 > div.body-inner > form > h1")).Text);

        }
        [Test]
        public void PageAccessRights_Test_7()
        {
            var pageaccessrights = new PageAccessRights(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            pageaccessrights.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Admin/FAQForDifferentRoles");

            Assert.AreEqual("FAQ", driver.FindElement(By.CssSelector("div.body-outer.col-xs-9.col-sm-9.col-md-9.col-lg-10 > div.body-inner > h1")).Text);

        }
        [Test]
        public void PageAccessRights_Test_8()
        {
            var pageaccessrights = new PageAccessRights(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            pageaccessrights.ImpersonateBEA010();

            driver.Navigate().GoToUrl(baseURL + "/Admin/FAQForDifferentRoles");

            Assert.AreEqual("FAQ", driver.FindElement(By.CssSelector("div.body-outer.col-xs-9.col-sm-9.col-md-9.col-lg-10 > div.body-inner > h1")).Text);
        }
        [Test]
        public void PageAccessRights_Test_9()
        {
            var pageaccessrights = new PageAccessRights(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            pageaccessrights.ImpersonateCOS010();

            driver.Navigate().GoToUrl(baseURL + "/Admin/FAQForDifferentRoles");

            Assert.AreEqual("FAQ", driver.FindElement(By.CssSelector("div.body-outer.col-xs-9.col-sm-9.col-md-9.col-lg-10 > div.body-inner > h1")).Text);
        }
        [Test]
        public void PageAccessRights_Test_10()
        {
            var pageaccessrights = new PageAccessRights(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            pageaccessrights.ImpersonateABZ011();

            driver.FindElement(By.CssSelector("ul > li:nth-child(2) > ul > li:nth-child(2) > a")).Click();

            Assert.AreEqual("Edit User", driver.FindElement(By.Id("GenericModal-Title")).Text);

        }
        [Test]
        public void PageAccessRights_Test_11()
        {
            var pageaccessrights = new PageAccessRights(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            pageaccessrights.ImpersonateBEA010();

            driver.FindElement(By.CssSelector("ul > li:nth-child(2) > ul > li:nth-child(2) > a")).Click();

            Assert.AreEqual("Edit User", driver.FindElement(By.Id("GenericModal-Title")).Text);

        }
        [Test]
        public void PageAccessRights_Test_12()
        {
            var pageaccessrights = new PageAccessRights(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            pageaccessrights.ImpersonateCOS010();

            driver.FindElement(By.CssSelector("ul > li:nth-child(2) > ul > li:nth-child(2) > a")).Click();

            Assert.AreEqual("Edit User", driver.FindElement(By.Id("GenericModal-Title")).Text);
        }

        [Test]
        public void PageAccessRights_Test_13()
        {
            var pageaccessrights = new PageAccessRights(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            pageaccessrights.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Template/TemplateManager");

            Assert.AreEqual("Template Management Overview", driver.FindElement(By.CssSelector("div.body-inner > div.template > h1")).Text);

        }
        [Test]
        public void PageAccessRights_Test_14()
        {
            var pageaccessrights = new PageAccessRights(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            pageaccessrights.ImpersonateBEA010();

            driver.Navigate().GoToUrl(baseURL + "/Template/TemplateManager");

            Assert.AreEqual("Template Management Overview", driver.FindElement(By.CssSelector("div.body-inner > div.template > h1")).Text);

        }
        [Test]
        public void PageAccessRights_Test_15()
        {
            var pageaccessrights = new PageAccessRights(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            pageaccessrights.ImpersonateCOS010();

            driver.Navigate().GoToUrl(baseURL + "/Template/TemplateManager");

            Assert.AreEqual("Template Management Overview", driver.FindElement(By.CssSelector("div.body-inner > div.template > h1")).Text);

        }
        [Test]
        public void PageAccessRights_Test_16()
        {
            var pageaccessrights = new PageAccessRights(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            pageaccessrights.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Admin/SavedMachineInformation");

            Assert.AreEqual("Authorised Machines", driver.FindElement(By.CssSelector("div.body-inner > form > h1")).Text);

        }
        [Test]
        public void PageAccessRights_Test_17()
        {
            var pageaccessrights = new PageAccessRights(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            pageaccessrights.ImpersonateBEA010();

            driver.Navigate().GoToUrl(baseURL + "/Admin/SavedMachineInformation");

            Assert.AreEqual("Authorised Machines", driver.FindElement(By.CssSelector("div.body-inner > form > h1")).Text);

        }
        [Test]
        public void PageAccessRights_Test_18()
        {
            var pageaccessrights = new PageAccessRights(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            pageaccessrights.ImpersonateCOS010();

            driver.Navigate().GoToUrl(baseURL + "/Admin/SavedMachineInformation");

            Assert.AreEqual("Authorised Machines", driver.FindElement(By.CssSelector("div.body-inner > form > h1")).Text);

        }
        [Test]
        public void PageAccessRights_Test_19()
        {
            var pageaccessrights = new PageAccessRights(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            pageaccessrights.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Admin/SavedMachineInformation");

            Assert.AreEqual("Authorised Machines", driver.FindElement(By.CssSelector("div.body-inner > form > h1")).Text);

        }
        [Test]
        public void PageAccessRights_Test_20()
        {
            var pageaccessrights = new PageAccessRights(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            pageaccessrights.ImpersonateBEA010();

            driver.Navigate().GoToUrl(baseURL + "/Admin/SavedMachineInformation");

            Assert.AreEqual("Authorised Machines", driver.FindElement(By.CssSelector("div.body-inner > form > h1")).Text);

        }
        [Test]
        public void PageAccessRights_Test_21()
        {
            var pageaccessrights = new PageAccessRights(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            pageaccessrights.ImpersonateCOS010();


            driver.Navigate().GoToUrl(baseURL + "/Admin/SavedMachineInformation");

            Assert.AreEqual("Authorised Machines", driver.FindElement(By.CssSelector("div.body-inner > form > h1")).Text);

        }
        [Test]
        public void PageAccessRights_Test_22()
        {
            var pageaccessrights = new PageAccessRights(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            pageaccessrights.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Billing");

            Assert.AreEqual("Invoice & Payment Records", driver.FindElement(By.CssSelector("div.body-inner > div > div.general.clearfix > h1")).Text);

        }
        [Test]
        public void PageAccessRights_Test_23()
        {
            var pageaccessrights = new PageAccessRights(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            pageaccessrights.ImpersonateBEA010();

            driver.Navigate().GoToUrl(baseURL + "/Billing");

            Assert.AreEqual("Invoice & Payment Records", driver.FindElement(By.CssSelector("div.body-inner > div > div.general.clearfix > h1")).Text);
        }
        [Test]
        public void PageAccessRights_Test_24()
        {
            var pageaccessrights = new PageAccessRights(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            pageaccessrights.ImpersonateCOS010();

            driver.Navigate().GoToUrl(baseURL + "/Billing");

            Assert.AreEqual("Invoice & Payment Records", driver.FindElement(By.CssSelector("div.body-inner > div > div.general.clearfix > h1")).Text);
        }

        [Test]
        public void PageAccessRights_Test_25()
        {
            var pageaccessrights = new PageAccessRights(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            pageaccessrights.ImpersonateBEA010();

            driver.Navigate().GoToUrl(baseURL + "/Billing");

            Assert.AreEqual("Manage Commissions", driver.FindElement(By.CssSelector("div.body-inner > h1")).Text);
        }

        [Test]
        public void PageAccessRights_Test_26()
        {
            var pageaccessrights = new PageAccessRights(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            pageaccessrights.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Availability");

            Assert.AreEqual("Single Check", driver.FindElement(By.CssSelector("div.body-inner > div > div > h2")).Text);
            Assert.AreEqual("Bulk Check", driver.FindElement(By.CssSelector("div.col-xs-12.col-sm-12.col-md-12.col-lg-12 > h2")).Text);
        }
        [Test]
        public void PageAccessRights_Test_27()
        {
            var pageaccessrights = new PageAccessRights(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            pageaccessrights.ImpersonateBEA010();

            driver.Navigate().GoToUrl(baseURL + "/Availability");

            Assert.AreEqual("Single Check", driver.FindElement(By.CssSelector("div.body-inner > div > div > h2")).Text);
        }
        [Test]
        public void PageAccessRights_Test_28()
        {
            var pageaccessrights = new PageAccessRights(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            pageaccessrights.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Availability/AddressSearch");

            Assert.AreEqual("Address Search", driver.FindElement(By.CssSelector("div.body-inner > div > h2")).Text);
        }
        [Test]
        public void PageAccessRights_Test_29()
        {
            var pageaccessrights = new PageAccessRights(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            pageaccessrights.ImpersonateBEA010();

            driver.Navigate().GoToUrl(baseURL + "/Availability/AddressSearch");

            Assert.AreEqual("Address Search", driver.FindElement(By.CssSelector("div.body-inner > div > h2")).Text);
        }
        [Test]
        public void PageAccessRights_Test_30()
        {
            var pageaccessrights = new PageAccessRights(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            pageaccessrights.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/OrderNewConnection");

            Assert.AreEqual("Order New Connection", driver.FindElement(By.CssSelector("#orderconnection-header > div.col-xs-8.col-sm-8.col-md-8.col-lg-8 > h1")).Text);
        }
        [Test]
        public void PageAccessRights_Test_31()
        {
            var pageaccessrights = new PageAccessRights(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            pageaccessrights.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/OrderStatus");

            Assert.AreEqual("Order Status", driver.FindElement(By.CssSelector("div.body-inner > form > div > h1")).Text);

        }
        [Test]
        public void PageAccessRights_Test_32()
        {
            var pageaccessrights = new PageAccessRights(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            pageaccessrights.ImpersonateBEA010();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/OrderStatus");

            Assert.AreEqual("Order Status", driver.FindElement(By.CssSelector("div.body-inner > form > div > h1")).Text);

        }
        [Test]
        public void PageAccessRights_Test_33()
        {
            var pageaccessrights = new PageAccessRights(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            pageaccessrights.ImpersonateCOS010();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/OrderStatus");

            Assert.AreEqual("Order Status", driver.FindElement(By.CssSelector("div.body-inner > form > div > h1")).Text);

        }
        [Test]
        public void PageAccessRights_Test_34()
        {
            var pageaccessrights = new PageAccessRights(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            pageaccessrights.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/CeaseOrder");

            Assert.AreEqual("Cease Order", driver.FindElement(By.CssSelector("div:nth-child(1) > h1")).Text);

        }
        [Test]
        public void PageAccessRights_Test_35()
        {
            var pageaccessrights = new PageAccessRights(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            pageaccessrights.ImpersonateBEA010();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/DirectCease");

            Assert.AreEqual("Cease Order", driver.FindElement(By.CssSelector("div.body-inner > h1")).Text);

        }
        [Test]
        public void PageAccessRights_Test_36()
        {
            var pageaccessrights = new PageAccessRights(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            pageaccessrights.ImpersonateCOS010();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/DirectCease");

            Assert.AreEqual("Order Status", driver.FindElement(By.CssSelector("div.body-inner > h1")).Text);

        }
        [Test]
        public void PageAccessRights_Test_37()
        {
            var pageaccessrights = new PageAccessRights(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            pageaccessrights.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/ModifyConnection");

            Assert.AreEqual("Modify Connection", driver.FindElement(By.CssSelector("div.body-inner > div > h1")).Text);

        }
        [Test]
        public void PageAccessRights_Test_38()
        {
            var pageaccessrights = new PageAccessRights(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            pageaccessrights.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/UpgradableConnections");

            Assert.AreEqual("Upgradable Connections", driver.FindElement(By.CssSelector("div.body-inner > div > h1")).Text);

        }
        [Test]
        public void PageAccessRights_Test_39()
        {
            var pageaccessrights = new PageAccessRights(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            pageaccessrights.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/UnsolicitedCease");

            Assert.AreEqual("Unsolicited Ceases", driver.FindElement(By.CssSelector("div.body-inner > h1")).Text);

        }

        [Test]
        public void PageAccessRights_Test_40()
        {
            var pageaccessrights = new PageAccessRights(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            pageaccessrights.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/Cancellation");

            Assert.AreEqual("Cancellation", driver.FindElement(By.CssSelector("div.body-inner > h1")).Text);

        }

        [Test]
        public void PageAccessRights_Test_41()
        {
            var pageaccessrights = new PageAccessRights(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            pageaccessrights.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/Amend");

            Assert.AreEqual("Amend", driver.FindElement(By.CssSelector("div.body-inner > h1")).Text);

        }
        [Test]
        public void PageAccessRights_Test_42()
        {
            var pageaccessrights = new PageAccessRights(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            pageaccessrights.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Support/LiveConnection");

            Assert.AreEqual("Live Connection", driver.FindElement(By.CssSelector("div.liveconnection > h1")).Text);

        }
        [Test]
        public void PageAccessRights_Test_43()
        {
            var pageaccessrights = new PageAccessRights(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            pageaccessrights.ImpersonateBEA010();

            driver.Navigate().GoToUrl(baseURL + "/Support/LiveConnection");

            Assert.AreEqual("Live Connection", driver.FindElement(By.CssSelector("div.liveconnection > h1")).Text);

        }
        [Test]
        public void PageAccessRights_Test_44()
        {
            var pageaccessrights = new PageAccessRights(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            pageaccessrights.ImpersonateCOS010();

            driver.Navigate().GoToUrl(baseURL + "/Support/LiveConnection");

            Assert.AreEqual("Live Connection", driver.FindElement(By.CssSelector("div.liveconnection > h1")).Text);

        }

        [Test]
        public void PageAccessRights_Test_45()
        {
            var pageaccessrights = new PageAccessRights(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            pageaccessrights.ImpersonateBEA010();

            driver.Navigate().GoToUrl(baseURL + "/Support/LiveConnection");

            Assert.AreEqual("Live Connection", driver.FindElement(By.CssSelector("div.liveconnection > h1")).Text);
            driver.FindElement(By.CssSelector("tr:nth-child(X) > td:nth-child(16) > a > img.ove")).Click();
            Assert.AreEqual("Ethernet on Demand", driver.FindElement(By.CssSelector("div:nth-child(1) > div.col-xs-9 > h1")).Text);
        }
        [Test]
        public void PageAccessRights_Test_46()
        {
            var pageaccessrights = new PageAccessRights(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            pageaccessrights.ImpersonateCOS010();

            driver.Navigate().GoToUrl(baseURL + "/Support/LiveConnection");

            Assert.AreEqual("Live Connection", driver.FindElement(By.CssSelector("div.liveconnection > h1")).Text);
            driver.FindElement(By.CssSelector("tr:nth-child(X) > td:nth-child(16) > a > img.ove")).Click();
            Assert.AreEqual("Ethernet on Demand", driver.FindElement(By.CssSelector("div:nth-child(1) > div.col-xs-9 > h1")).Text);
        }
        [Test]
        public void PageAccessRights_Test_47()
        {
            var pageaccessrights = new PageAccessRights(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            pageaccessrights.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Support/Realms");

            Assert.AreEqual("Realms", driver.FindElement(By.CssSelector("div.body-inner > h2")).Text);

        }
        [Test]
        public void PageAccessRights_Test_48()
        {
            var pageaccessrights = new PageAccessRights(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            pageaccessrights.ImpersonateBEA010();

            driver.Navigate().GoToUrl(baseURL + "/Support/DNS");

            Assert.AreEqual("DNS Entries", driver.FindElement(By.CssSelector("div.body-inner > div > h1")).Text);

        }
        [Test]
        public void PageAccessRights_Test_49()
        {
            var pageaccessrights = new PageAccessRights(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            pageaccessrights.ImpersonateCOS010();

            driver.Navigate().GoToUrl(baseURL + "/Support/DNS");

            Assert.AreEqual("DNS Entries", driver.FindElement(By.CssSelector("div.body-inner > div > h1")).Text);

        }
        [Test]
        public void PageAccessRights_Test_50()
        {
            var pageaccessrights = new PageAccessRights(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            pageaccessrights.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Support/RaiseFault");

            Assert.AreEqual("Raise Ticket", driver.FindElement(By.CssSelector("div.body-inner > h1")).Text);

        }
        [Test]
        public void PageAccessRights_Test_51()
        {
            var pageaccessrights = new PageAccessRights(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            pageaccessrights.ImpersonateBEA010();

            driver.Navigate().GoToUrl(baseURL + "/Support/RaiseFault");

            Assert.AreEqual("Raise Ticket", driver.FindElement(By.CssSelector("div.body-inner > h1")).Text);

        }
        [Test]
        public void PageAccessRights_Test_52()
        {
            var pageaccessrights = new PageAccessRights(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            pageaccessrights.ImpersonateCOS010();

            driver.Navigate().GoToUrl(baseURL + "/Support/RaiseFault");

            Assert.AreEqual("Raise Ticket", driver.FindElement(By.CssSelector("div.body-inner > h1")).Text);

        }
        [Test]
        public void PageAccessRights_Test_53()
        {
            var pageaccessrights = new PageAccessRights(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            pageaccessrights.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Support/Tickets");

            Assert.AreEqual("Tickets", driver.FindElement(By.CssSelector("div.body-inner > div > h1")).Text);

        }
        [Test]
        public void PageAccessRights_Test_54()
        {
            var pageaccessrights = new PageAccessRights(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            pageaccessrights.ImpersonateBEA010();

            driver.Navigate().GoToUrl(baseURL + "/Support/Tickets");
            Assert.AreEqual("Tickets", driver.FindElement(By.CssSelector("div.body-inner > div > h1")).Text);

        }
        [Test]
        public void PageAccessRights_Test_55()
        {
            var pageaccessrights = new PageAccessRights(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            pageaccessrights.ImpersonateCOS010();

            driver.Navigate().GoToUrl(baseURL + "/Support/Tickets");

            Assert.AreEqual("Tickets", driver.FindElement(By.CssSelector("div.body-inner > div > h1")).Text);

        }
        [Test]
        public void PageAccessRights_Test_56()
        {
            var pageaccessrights = new PageAccessRights(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            pageaccessrights.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Support/ClosedTickets");

            Assert.AreEqual("Tickets", driver.FindElement(By.CssSelector("div.body-inner > div > h1")).Text);

        }
        [Test]
        public void PageAccessRights_Test_57()
        {
            var pageaccessrights = new PageAccessRights(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            pageaccessrights.ImpersonateBEA010();

            driver.Navigate().GoToUrl(baseURL + "/Support/ClosedTickets");
            Assert.AreEqual("Tickets", driver.FindElement(By.CssSelector("div.body-inner > div > h1")).Text);

        }
        [Test]
        public void PageAccessRights_Test_58()
        {
            var pageaccessrights = new PageAccessRights(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            pageaccessrights.ImpersonateCOS010();

            driver.Navigate().GoToUrl(baseURL + "/Support/ClosedTickets");

            Assert.AreEqual("Tickets", driver.FindElement(By.CssSelector("div.body-inner > div > h1")).Text);

        }
        [Test]
        public void PageAccessRights_Test_59()
        {
            var pageaccessrights = new PageAccessRights(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            pageaccessrights.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Network/WeatherMap");

            Assert.AreEqual("WeatherMap", driver.FindElement(By.CssSelector("div.body-inner > h1")).Text);

        }
        [Test]
        public void PageAccessRights_Test_60()
        {
            var pageaccessrights = new PageAccessRights(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            pageaccessrights.ImpersonateBEA010();

            driver.Navigate().GoToUrl(baseURL + "/Network/WeatherMap");
            Assert.AreEqual("WeatherMap", driver.FindElement(By.CssSelector("div.body-inner > h1")).Text);
        }
        [Test]
        public void PageAccessRights_Test_61()
        {
            var pageaccessrights = new PageAccessRights(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            pageaccessrights.ImpersonateCOS010();

            driver.Navigate().GoToUrl(baseURL + "/Network/WeatherMap");
            Assert.AreEqual("WeatherMap", driver.FindElement(By.CssSelector("div.body-inner > h1")).Text);
        }

        [Test]
        public void PageAccessRights_Test_62()
        {
            var pageaccessrights = new PageAccessRights(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            pageaccessrights.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Support/Documentation");

            Assert.AreEqual("Documentation", driver.FindElement(By.CssSelector("div.body-inner > h1")).Text);

        }
        [Test]
        public void PageAccessRights_Test_63()
        {
            var pageaccessrights = new PageAccessRights(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            pageaccessrights.ImpersonateBEA010();

            driver.Navigate().GoToUrl(baseURL + "/Support/Documentation");
            Assert.AreEqual("Documentation", driver.FindElement(By.CssSelector("div.body-inner > h1")).Text);
        }
        [Test]
        public void PageAccessRights_Test_64()
        {
            var pageaccessrights = new PageAccessRights(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            pageaccessrights.ImpersonateCOS010();

            driver.Navigate().GoToUrl(baseURL + "/Support/Documentation");
            Assert.AreEqual("Documentation", driver.FindElement(By.CssSelector("div.body-inner > h1")).Text);
        }

        [Test]
        public void PageAccessRights_Test_65()
        {
            var pageaccessrights = new PageAccessRights(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            pageaccessrights.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Network/Interconnect");

            Assert.AreEqual("Interconnect Information", driver.FindElement(By.CssSelector("div.body-inner > div > h1")).Text);

        }

        [Test]
        public void PageAccessRights_Test_68()
        {
            var pageaccessrights = new PageAccessRights(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            pageaccessrights.ImpersonateBEA010();

            driver.Navigate().GoToUrl(baseURL + "/Quotes/Build");

            Assert.AreEqual("Build Quotes", driver.FindElement(By.CssSelector("div.body-inner > h1")).Text);
        }
        [Test]
        public void PageAccessRights_Test_69()
        {
            var pageaccessrights = new PageAccessRights(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            pageaccessrights.ImpersonateCOS010();

            driver.Navigate().GoToUrl(baseURL + "/Quotes/Build");

            Assert.AreEqual("Build Quotes", driver.FindElement(By.CssSelector("div.body-inner > h1")).Text);
        }

        [Test]
        public void PageAccessRights_Test_70()
        {
            var pageaccessrights = new PageAccessRights(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            pageaccessrights.ImpersonateBEA010();

            driver.Navigate().GoToUrl(baseURL + "/Quotes");

            Assert.AreEqual("Quotes", driver.FindElement(By.CssSelector("div.body-inner > div > h1")).Text);
        }
        [Test]
        public void PageAccessRights_Test_71()
        {
            var pageaccessrights = new PageAccessRights(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            pageaccessrights.ImpersonateCOS010();

            driver.Navigate().GoToUrl(baseURL + "/Quotes");

            Assert.AreEqual("Quotes", driver.FindElement(By.CssSelector("div.body-inner > div > h1")).Text);
        }

        [Test]
        public void PageAccessRights_Test_72()
        {
            var pageaccessrights = new PageAccessRights(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");


            Assert.AreEqual("Account Users", driver.FindElement(By.CssSelector("div.body-inner > div > h1")).Text);

        }

        [Test]
        public void PageAccessRights_Test_73()
        {
            var pageaccessrights = new PageAccessRights(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            Assert.AreEqual("Account Users", driver.FindElement(By.CssSelector("div.body-inner > div > h1")).Text);

        }
        [Test]
        public void PageAccessRights_Test_74()
        {
            var pageaccessrights = new PageAccessRights(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            Assert.AreEqual("Account Users", driver.FindElement(By.CssSelector("div.body-inner > div > h1")).Text);
        }
        [Test]
        public void PageAccessRights_Test_75()
        {
            var pageaccessrights = new PageAccessRights(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            pageaccessrights.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Support/ApproveIPChanges");

            Assert.AreNotEqual("Sorry, you don't have the necessary access level to view this page. Please go back to your previous page.", driver.FindElement(By.CssSelector("body > div.wrap > div.loginBody.row > div > h2")).Text);

        }

        [Test]
        public void PageAccessRights_Test_76()
        {
            var pageaccessrights = new PageAccessRights(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            pageaccessrights.ImpersonateBEA010();

            driver.Navigate().GoToUrl(baseURL + "/Support/ApproveIPChanges");

            Assert.AreNotEqual("Sorry, you don't have the necessary access level to view this page. Please go back to your previous page.", driver.FindElement(By.CssSelector("body > div.wrap > div.loginBody.row > div > h2")).Text);
        }
        [Test]
        public void PageAccessRights_Test_77()
        {
            var pageaccessrights = new PageAccessRights(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            pageaccessrights.ImpersonateCOS010();

            driver.Navigate().GoToUrl(baseURL + "/Support/ApproveIPChanges");

            Assert.AreNotEqual("Sorry, you don't have the necessary access level to view this page. Please go back to your previous page.", driver.FindElement(By.CssSelector("body > div.wrap > div.loginBody.row > div > h2")).Text);
        }

        [Test]
        public void PageAccessRights_Test_78()
        {
            var pageaccessrights = new PageAccessRights(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            pageaccessrights.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Quotes/SkyCustomQuote");

            Assert.AreNotEqual("Sorry, you don't have the necessary access level to view this page. Please go back to your previous page.", driver.FindElement(By.CssSelector("body > div.wrap > div.loginBody.row > div > h2")).Text);

        }

        [Test]
        public void PageAccessRights_Test_79()
        {
            var pageaccessrights = new PageAccessRights(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            pageaccessrights.ImpersonateBEA010();

            driver.Navigate().GoToUrl(baseURL + "/Quotes/SkyCustomQuote");

            Assert.AreNotEqual("Sorry, you don't have the necessary access level to view this page. Please go back to your previous page.", driver.FindElement(By.CssSelector("body > div.wrap > div.loginBody.row > div > h2")).Text);
        }
        [Test]
        public void PageAccessRights_Test_80()
        {
            var pageaccessrights = new PageAccessRights(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            pageaccessrights.ImpersonateCOS010();

            driver.Navigate().GoToUrl(baseURL + "/Quotes/SkyCustomQuote");

            Assert.AreNotEqual("Sorry, you don't have the necessary access level to view this page. Please go back to your previous page.", driver.FindElement(By.CssSelector("body > div.wrap > div.loginBody.row > div > h2")).Text);
        }
        [Test]
        public void PageAccessRights_Test_81()
        {
            var pageaccessrights = new PageAccessRights(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            pageaccessrights.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Quotes/FDReporting");

            Assert.AreNotEqual("Sorry, you don't have the necessary access level to view this page. Please go back to your previous page.", driver.FindElement(By.CssSelector("body > div.wrap > div.loginBody.row > div > h2")).Text);

        }

        [Test]
        public void PageAccessRights_Test_82()
        {
            var pageaccessrights = new PageAccessRights(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            pageaccessrights.ImpersonateBEA010();

            driver.Navigate().GoToUrl(baseURL + "/Quotes/FDReporting");

            Assert.AreNotEqual("Sorry, you don't have the necessary access level to view this page. Please go back to your previous page.", driver.FindElement(By.CssSelector("body > div.wrap > div.loginBody.row > div > h2")).Text);
        }
        [Test]
        public void PageAccessRights_Test_83()
        {
            var pageaccessrights = new PageAccessRights(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            pageaccessrights.ImpersonateCOS010();

            driver.Navigate().GoToUrl(baseURL + "/Quotes/FDReporting");

            Assert.AreNotEqual("Sorry, you don't have the necessary access level to view this page. Please go back to your previous page.", driver.FindElement(By.CssSelector("body > div.wrap > div.loginBody.row > div > h2")).Text);
        }

        [Test]
        public void PageAccessRights_Test_84()
        {
            var pageaccessrights = new PageAccessRights(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            pageaccessrights.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/MailDrop");

            Assert.AreNotEqual("Sorry, you don't have the necessary access level to view this page. Please go back to your previous page.", driver.FindElement(By.CssSelector("body > div.wrap > div.loginBody.row > div > h2")).Text);

        }

        [Test]
        public void PageAccessRights_Test_85()
        {
            var pageaccessrights = new PageAccessRights(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            pageaccessrights.ImpersonateBEA010();

            driver.Navigate().GoToUrl(baseURL + "/MailDrop");

            Assert.AreNotEqual("Sorry, you don't have the necessary access level to view this page. Please go back to your previous page.", driver.FindElement(By.CssSelector("body > div.wrap > div.loginBody.row > div > h2")).Text);
        }
        [Test]
        public void PageAccessRights_Test_86()
        {
            var pageaccessrights = new PageAccessRights(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            pageaccessrights.ImpersonateCOS010();

            driver.Navigate().GoToUrl(baseURL + "/MailDrop");

            Assert.AreNotEqual("Sorry, you don't have the necessary access level to view this page. Please go back to your previous page.", driver.FindElement(By.CssSelector("body > div.wrap > div.loginBody.row > div > h2")).Text);
        }

        [Test]
        public void PageAccessRights_Test_87()
        {
            var pageaccessrights = new PageAccessRights(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            pageaccessrights.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/News");

            Assert.AreNotEqual("Sorry, you don't have the necessary access level to view this page. Please go back to your previous page.", driver.FindElement(By.CssSelector("body > div.wrap > div.loginBody.row > div > h2")).Text);

        }

        [Test]
        public void PageAccessRights_Test_88()
        {
            var pageaccessrights = new PageAccessRights(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            pageaccessrights.ImpersonateBEA010();

            driver.Navigate().GoToUrl(baseURL + "/News");

            Assert.AreNotEqual("Sorry, you don't have the necessary access level to view this page. Please go back to your previous page.", driver.FindElement(By.CssSelector("body > div.wrap > div.loginBody.row > div > h2")).Text);
        }
        [Test]
        public void PageAccessRights_Test_89()
        {
            var pageaccessrights = new PageAccessRights(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            pageaccessrights.ImpersonateCOS010();

            driver.Navigate().GoToUrl(baseURL + "/News");

            Assert.AreNotEqual("Sorry, you don't have the necessary access level to view this page. Please go back to your previous page.", driver.FindElement(By.CssSelector("body > div.wrap > div.loginBody.row > div > h2")).Text);
        }
        [Test]
        public void PageAccessRights_Test_90()
        {
            var pageaccessrights = new PageAccessRights(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            pageaccessrights.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Admin/FaqAdmin");

            Assert.AreNotEqual("Sorry, you don't have the necessary access level to view this page. Please go back to your previous page.", driver.FindElement(By.CssSelector("body > div.wrap > div.loginBody.row > div > h2")).Text);

        }

        [Test]
        public void PageAccessRights_Test_91()
        {
            var pageaccessrights = new PageAccessRights(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            pageaccessrights.ImpersonateBEA010();

            driver.Navigate().GoToUrl(baseURL + "/Admin/FaqAdmin");

            Assert.AreNotEqual("Sorry, you don't have the necessary access level to view this page. Please go back to your previous page.", driver.FindElement(By.CssSelector("body > div.wrap > div.loginBody.row > div > h2")).Text);
        }
        [Test]
        public void PageAccessRights_Test_92()
        {
            var pageaccessrights = new PageAccessRights(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            pageaccessrights.ImpersonateCOS010();

            driver.Navigate().GoToUrl(baseURL + "/Admin/FaqAdmin");

            Assert.AreNotEqual("Sorry, you don't have the necessary access level to view this page. Please go back to your previous page.", driver.FindElement(By.CssSelector("body > div.wrap > div.loginBody.row > div > h2")).Text);
        }
        [Test]
        public void PageAccessRights_Test_93()
        {
            var pageaccessrights = new PageAccessRights(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            pageaccessrights.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Tier/TierManager");

            Assert.AreNotEqual("Sorry, you don't have the necessary access level to view this page. Please go back to your previous page.", driver.FindElement(By.CssSelector("body > div.wrap > div.loginBody.row > div > h2")).Text);

        }

        [Test]
        public void PageAccessRights_Test_94()
        {
            var pageaccessrights = new PageAccessRights(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            pageaccessrights.ImpersonateBEA010();

            driver.Navigate().GoToUrl(baseURL + "/Tier/TierManager");

            Assert.AreNotEqual("Sorry, you don't have the necessary access level to view this page. Please go back to your previous page.", driver.FindElement(By.CssSelector("body > div.wrap > div.loginBody.row > div > h2")).Text);
        }
        [Test]
        public void PageAccessRights_Test_95()
        {
            var pageaccessrights = new PageAccessRights(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            pageaccessrights.ImpersonateCOS010();

            driver.Navigate().GoToUrl(baseURL + "/Tier/TierManager");

            Assert.AreNotEqual("Sorry, you don't have the necessary access level to view this page. Please go back to your previous page.", driver.FindElement(By.CssSelector("body > div.wrap > div.loginBody.row > div > h2")).Text);

        }
    } 
}




