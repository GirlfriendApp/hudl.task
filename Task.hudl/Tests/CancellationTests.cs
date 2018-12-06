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

    public class CancellationsPage<T> : BaseTest<T> where T : IWebDriver, new()
    {

        [SetUp]
        public void setup()
        {
            var login = new LoginPage(driver);
            driver.FindElement(By.CssSelector("body > div.cookieSection > div > button")).Click();
            login.Login(accountCode, email, password);
        }
        [Test]
        public void Provisioning_Cancellations_Test_74()
        {

            var cancellations = new CancellationsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            cancellations.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/Cancellation");
            cancellations.SearchByDslModify("", "");


            cancellations.SelectContactTest();

            Assert.AreEqual("", driver.FindElement(By.CssSelector("#ContactNameLabel")));

        }

        [Test]
        public void Provisioning_Cancellations_Test_75()
        {

            var cancellations = new CancellationsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            cancellations.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/Cancellation");
            cancellations.SearchByDslModify("", "");


            cancellations.SelectContactTest2();

            Assert.AreEqual("", driver.FindElement(By.CssSelector("#ContactNameLabel")));

        }

        [Test]
        public void Provisioning_Cancellations_Test_76()
        {

            var cancellations = new CancellationsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            cancellations.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/Cancellation");
            cancellations.SearchByDslModify("", "");

            cancellations.CreateNewContact();

            Assert.AreEqual("Contact Name: Test User", driver.FindElement(By.CssSelector("#ContactNameLabel")));
            cancellations.VerifyNewContactDisplayed();

            Assert.AreEqual("Test", driver.FindElement(By.CssSelector("#selectContact-grid > tbody > tr:nth-child(4) > td:nth-child(1)")).Text);
            Assert.AreEqual("User", driver.FindElement(By.CssSelector("#selectContact-grid > tbody > tr:nth-child(4) > td:nth-child(2)")).Text);

            Assert.AreEqual("07745612345", driver.FindElement(By.CssSelector("#selectContact-grid > tbody > tr:nth-child(4) > td:nth-child(4)")).Text);

            Assert.AreEqual("test.user@email.com", driver.FindElement(By.CssSelector("#selectContact-grid > tbody > tr:nth-child(4) > td:nth-child(5)")).Text);
            cancellations.DeleteNewContact();
        }
        [Test]
        public void Provisioning_Cancellations_Test_77()
        {

            var cancellations = new CancellationsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            cancellations.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/Cancellation");
            cancellations.SearchByDslModify("", "");
            cancellations.SelectContact();
            cancellations.PlaceCancellation.Click();

            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));
        }

        [Test]
        public void Provisioning_Cancellations_Test_78()
        {

            var cancellations = new CancellationsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            cancellations.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/Cancellation");
            cancellations.SearchByDslModify("", "");
            cancellations.SelectContact();
            cancellations.PlaceCancellation.Click();

            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));
        }

        [Test]
        public void Provisioning_Cancellations_Test_79()
        {

            var cancellations = new CancellationsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            cancellations.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/Cancellation");
            cancellations.SearchByDslModify("", "");
            cancellations.SelectContact();
            cancellations.PlaceCancellation.Click();

            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));
        }

        [Test]
        public void Provisioning_Cancellations_Test_80()
        {

            var cancellations = new CancellationsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            cancellations.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/Cancellation");
            cancellations.SearchByDslModify("", "");
            cancellations.SelectContact();
            cancellations.PlaceCancellation.Click();

            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));
        }

        [Test]
        public void Provisioning_Cancellations_Test_81()
        {

            var cancellations = new CancellationsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            cancellations.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/Cancellation");
            cancellations.SearchByDslModify("", "");
            cancellations.SelectContact();
            cancellations.PlaceCancellation.Click();

            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));
        }

        [Test]
        public void Provisioning_Cancellations_Test_82()
        {

            var cancellations = new CancellationsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            cancellations.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/Cancellation");
            cancellations.SearchByDslModify("", "");
            cancellations.SelectContact();
            cancellations.PlaceCancellation.Click();

            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));
        }

        [Test]
        public void Provisioning_Cancellations_Test_83()
        {

            var cancellations = new CancellationsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            cancellations.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/Cancellation");
            cancellations.SearchByDslModify("", "");


            cancellations.EditContactTest("", "");

            Assert.AreEqual("", driver.FindElement(By.CssSelector("#ContactNameLabel")));

        }
    }

}
