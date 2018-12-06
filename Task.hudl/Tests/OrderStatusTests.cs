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

    public class OrderStatusPage<T> : BaseTest<T> where T : IWebDriver, new()
    {

        [SetUp]
        public void setup()
        {
            var login = new LoginPage(driver);
            driver.FindElement(By.CssSelector("body > div.cookieSection > div > button")).Click();
            login.Login(accountCode, email, password);
        }



        [Test]
        public void Provisioning_OrderStatus_Test_45()
        {

            var orderstatus = new OrderStatusPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            orderstatus.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/OrderStatus");
            orderstatus.SearchByOrderId1();

            driver.WaitForElementToDisplay(By.CssSelector("#ordertable"), 40);

            var tbody = driver.FindElement(By.CssSelector("#ordertable"));
            var rows = tbody.FindElements(By.CssSelector("tr"));

            Assert.IsTrue(tbody.Displayed);
            Assert.IsTrue(rows.Count() == 1);

            Assert.AreEqual("BT204044", driver.FindElement(By.CssSelector("#grid-orders-main > tbody > tr.header-row > td:nth-child(10)")));

        }

        [Test]
        public void Provisioning_OrderStatus_Test_46()
        {

            var orderstatus = new OrderStatusPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            orderstatus.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/OrderStatus");
            orderstatus.SearchByOrderId2();

            driver.WaitForElementToDisplay(By.CssSelector("#ordertable"), 40);

            var tbody = driver.FindElement(By.CssSelector("#ordertable"));
            var rows = tbody.FindElements(By.CssSelector("tr"));

            Assert.IsTrue(tbody.Displayed);
            Assert.IsTrue(rows.Count() == 0);

            Assert.AreNotEqual("BT2040442", driver.FindElement(By.CssSelector("#grid-orders-main > tbody > tr.header-row > td:nth-child(10)")));

        }

        [Test]
        public void Provisioning_OrderStatus_Test_47()
        {

            var orderstatus = new OrderStatusPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            orderstatus.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/OrderStatus");
            orderstatus.MagnifyingGlassTest();
            orderstatus.IsOrderDetailsDisplayed();
        }

        [Test]
        public void Provisioning_OrderStatus_Test_48()
        {

            var orderstatus = new OrderStatusPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            orderstatus.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/OrderStatus");

            orderstatus.PlusIcon.Click();



            var filterOption = "02380639058";
            var allFilteredOptions = driver.FindElements(By.CssSelector("#grid-orders-main tr > td:nth-child(5)")).Where(o => o.Text.Contains(filterOption)).ToList();

            foreach (var o in allFilteredOptions)
            {
                StringAssert.Contains(filterOption, o.Text);
            }
            var tbody = driver.FindElement(By.CssSelector("#grid-orders-main > tbody"));
            var rows = tbody.FindElements(By.CssSelector("tr"));

            Assert.IsTrue(tbody.Displayed);
            Assert.IsTrue(rows.Count() == 43);
        }
    }
}
