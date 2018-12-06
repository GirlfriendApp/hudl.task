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

    public class AdminPage<T> : BaseTest<T> where T : IWebDriver, new()
    {

        [SetUp]
        public void setup()
        {
            var login = new LoginPage(driver);
            driver.FindElement(By.CssSelector("body > div.cookieSection > div > button")).Click();
            login.Login(accountCode, email, password);
        }

        /*
         1. Go to Admin >> User Management
         2. Under Search Users choose Account Code option from the drop menu
         3. Leave Search input empty
         4. Click 'Search' button
         5. Check to see that no result is present.
        */
        [Test]
        public void Admin_UserManagement_Test_1()
        {
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            var usermanagepage = new AdminPage(driver);
            usermanagepage.PickOptionFromSeachDropdown("1");
            usermanagepage.SearchButton.Click();

            var tbody = driver.FindElement(By.CssSelector("#users_table > tbody"));
            var rows = tbody.FindElements(By.CssSelector("tr"));

            Assert.IsTrue(tbody.Displayed);
            Assert.IsTrue(rows.Count() == 0);
        }

        /*
         1. Go to Admin >> User Management.
         2. Click 'Create User' button.
         3. Enter valid data in all the inputs.
         4. Choose desired levels of access.
         5. Click 'Create' button.
         6. Check if Confirmation Message appears.
         7. Search user by email or username
         8. Check if matching result is present in search results table
         9. Delete the user
        */
        [Test]
        public void Admin_UserManagement_Test_2()
        {
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            var usermanagepage = new AdminPage(driver);
            usermanagepage.CreateNewUser();

            usermanagepage.SearchUser("3", "Gogu.duru@email.com");

            Assert.AreEqual("Gogu Jiji", driver.FindElement(By.CssSelector("#users_table > tbody > tr > td.user-name-col")).Text);
            Assert.AreEqual("Gogu.duru@email.com", driver.FindElement(By.CssSelector("#users_table > tbody > tr > td.user-email-col")).Text);

            usermanagepage.SearchDeleteUser();
            usermanagepage.SearchButton.Click();

            Assert.AreEqual("No users found for this account.", driver.FindElement(By.CssSelector("div > div.col-xs-12.col-sm-12.col-md-12.col-lg-12 > p")).Text);

        }

        /*
         1. Impersonate ABZ011
         2. Admin > Performance Reports
         3. Verify a report is displayed
        */
        [Test]
        public void Admin_PerformanceReport_Test_1()
        {
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            var performancereport = new AdminPage(driver);
            performancereport.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Admin/LuxReport");
           
            Thread.Sleep(120000);
            performancereport.IsPerformanceReportPresent();

        }

        /*
         1. Impersonate BEA010
         2. Admin > Performance Reports
         3. Verify a report is displayed
        */
        [Test]
        public void Admin_PerformanceReport_Test_2()
        {
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            var performancereport = new AdminPage(driver);
            performancereport.ImpersonateBEA010();

            driver.Navigate().GoToUrl(baseURL + "/Admin/LuxReport");

            Thread.Sleep(120000);
            performancereport.IsPerformanceReportPresent();

        }

        /*
         1. Impersonate COS010
         2. Admin > Performance Reports
         3. Verify a report is displayed
        */
        [Test]
        public void Admin_PerformanceReport_Test_3()
        {
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            var performancereport = new AdminPage(driver);
            performancereport.ImpersonateCOS010();

            driver.Navigate().GoToUrl(baseURL + "/Admin/LuxReport");

            Thread.Sleep(120000);
            performancereport.IsPerformanceReportPresent();

        }

        /*
         1. Impersonate ABZ011
         2. Admin > Performance Reports
         3. Verify a report is displayed
         4. Change the month 
         5. Verify the report for the chosen month is displayed
        */
        [Test]
        public void Admin_PerformanceReport_Test_4()
        {
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            var performancereport = new AdminPage(driver);
            performancereport.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Admin/LuxReport");

            Thread.Sleep(120000);
            performancereport.IsPerformanceReportPresent();
            performancereport.PickMonthFromSeachDropdown("113583");
            performancereport.IsPerformanceReportPresent();
            string actualvalue = driver.FindElement(By.CssSelector("#reportViewer1 > div > div.trv-content-wrapper.k-content > div.trv-content > div.trv-pages-area.k-widget.interactive > div.trv-page-container > div > div > div.sheet.page1 > div ")).Text;
            Assert.IsTrue(actualvalue.Contains("January 2018"));
          
        }

        /*
         1. Impersonate BEA010
         2. Admin > Performance Reports
         3. Verify a report is displayed
         4. Change the month 
         5. Verify the report for the chosen month is displayed
        */
        [Test]
        public void Admin_PerformanceReport_Test_5()
        {
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            var performancereport = new AdminPage(driver);
            performancereport.ImpersonateBEA010();

            driver.Navigate().GoToUrl(baseURL + "/Admin/LuxReport");

            Thread.Sleep(120000);
            performancereport.IsPerformanceReportPresent();
            performancereport.PickMonthFromSeachDropdown("113660");
            performancereport.IsPerformanceReportPresent();
            string actualvalue = driver.FindElement(By.CssSelector("#reportViewer1 > div > div.trv-content-wrapper.k-content > div.trv-content > div.trv-pages-area.k-widget.interactive > div.trv-page-container > div > div > div.sheet.page1 > div ")).Text;
            Assert.IsTrue(actualvalue.Contains("January 2018"));
        }

        /*
         1. Impersonate COS010
         2. Admin > Performance Reports
         3. Verify a report is displayed
         4. Change the month 
         5. Verify the report for the chosen month is displayed
        */
        [Test]
        public void Admin_PerformanceReport_Test_6()
        {
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            var performancereport = new AdminPage(driver);
            performancereport.ImpersonateCOS010();

            driver.Navigate().GoToUrl(baseURL + "/Admin/LuxReport");

            Thread.Sleep(120000);
            performancereport.IsPerformanceReportPresent();
            performancereport.PickMonthFromSeachDropdown("113765");
            performancereport.IsPerformanceReportPresent();
            string actualvalue = driver.FindElement(By.CssSelector("#reportViewer1 > div > div.trv-content-wrapper.k-content > div.trv-content > div.trv-pages-area.k-widget.interactive > div.trv-page-container > div > div > div.sheet.page1 > div ")).Text;
            Assert.IsTrue(actualvalue.Contains("January 2018"));
        }
    }
}
