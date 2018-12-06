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

    public class BuildQuotes<T> : BaseTest<T> where T : IWebDriver, new()
    {

        [SetUp]
        public void setup()
        {
            var login = new LoginPage(driver);
            driver.FindElement(By.CssSelector("body > div.cookieSection > div > button")).Click();
            login.Login(accountCode, email, password);
        }

        [Test]
        public void Sky_EoD_Test_1()
        {

            var EoD = new BuildQuotes(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            EoD.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Quotes/BuildQuote");
            EoD.BuildQuote("SE145BA", "100", "100");
            Assert.AreEqual("New: Ethernet on Demand uses the SDN capability of our network to allow you to change the service speed of a connection in real time. You can increase up to the full bearer speed, and reduce back to the committed service speed at any time and only pay for the days used. Note you cannot reduce below the service speed requested when ordering the connection during the initial term. For further details please see the EoD datasheet.", driver.FindElement(By.CssSelector("#provider-area > div.col-xs-5")));

        }

        [Test]
        public void Sky_EoD_Test_2()
        {

            var EoD = new BuildQuotes(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            EoD.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Quotes/BuildQuote");
            EoD.BuildQuote("SE145BA", "100", "100");
            Assert.AreEqual("Please note the bandwidth cannot be downgraded during the initial term. For orders where the service speed is the same as the bearer speed a non-EoD product will be more cost-effective.", driver.FindElement(By.CssSelector("#sdnWarning")));

        }

        [Test]
        public void Sky_EoD_Test_4()
        {

            var EoD = new BuildQuotes(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            EoD.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Quotes/BuildQuote");
            EoD.BuildQuote("SE145BA", "10", "100");
            Assert.AreNotEqual("Please note the bandwidth cannot be downgraded during the initial term. For orders where the service speed is the same as the bearer speed a non-EoD product will be more cost-effective.", driver.FindElement(By.CssSelector("#sdnWarning")));

        }

        [Test]
        public void Sky_EoD_Test_5()
        {

            var EoD = new BuildQuotes(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            EoD.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Quotes/BuildQuote");
            EoD.BuildQuote("SE145BA", "1000", "1000");
            Assert.AreNotEqual("Please note the bandwidth cannot be downgraded during the initial term. For orders where the service speed is the same as the bearer speed a non-EoD product will be more cost-effective.", driver.FindElement(By.CssSelector("#sdnWarning")));

        }
    }
}