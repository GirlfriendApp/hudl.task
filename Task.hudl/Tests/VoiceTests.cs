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

    public class VoicePage<T> : BaseTest<T> where T : IWebDriver, new()
    {

        [SetUp]
        public void setup()
        {
            var login = new LoginPage(driver);
            driver.FindElement(By.CssSelector("body > div.cookieSection > div > button")).Click();
            login.Login(accountCode, email, password);
        }

        /*
            1. Impersonate: OP5316
            2. Go to “Voice” -> “Mobile”
            3. Verify that you are on the Voice Mobile page
                     */
        [Test]
        public void Voice_Mobile_Test_1()
        {
            var voicepage = new VoicePage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            voicepage.ImpersonateCOS010();

            driver.Navigate().GoToUrl(baseURL + "/Mobile/Mobile");

            Assert.AreEqual("Mobile Inventory", driver.FindElement(By.Id("mobile-inventory-title")).Text);


        }

        /*
        1. Impersonate: OP5316
        2. Go to “Voice” -> “Fixed Line”
        3. Verify that you are on the Voice Fixed Line page

        */
        [Test]
        public void Voice_Mobile_Test_2()
        {
            var voicepage = new VoicePage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            voicepage.ImpersonateCOS010();

            driver.Navigate().GoToUrl(baseURL + "/Mobile/FixedLine");

            Assert.AreEqual("Fixed Line Inventory", driver.FindElement(By.Id("mobile-inventory-title")).Text);


        }

        /*
            1. Impersonate: OP5316
            2. Go to “Voice” -> “SIP”
            3. Verify that you are on the Voice SIP page

        */
        [Test]
        public void Voice_Mobile_Test_3()
        {
            var voicepage = new VoicePage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            voicepage.ImpersonateCOS010();

            driver.Navigate().GoToUrl(baseURL + "/Mobile/SIP");

            Assert.AreEqual("SIP Inventory", driver.FindElement(By.Id("mobile-inventory-title")).Text);


        }

        /*
         1. Impersonate: OP5316
        2. Go to “Voice” -> “Mobile”
        3. Verify that you are on the Voice Mobile page
        4. Check that there are 4 action buttons; Toggle Template, Bulk Edit, Export to PDF, Export to Excel
        */
        [Test]
        public void Voice_Mobile_Test_4()
        {
            var voicepage = new VoicePage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            voicepage.ImpersonateCOS010();
            driver.Navigate().GoToUrl(baseURL + "/Mobile/Mobile");
            driver.WaitForElementToDisplay(By.Id("template-toggle"), 60);
            Assert.AreEqual("Toggle Template", driver.FindElement(By.CssSelector("#template-toggle")).GetAttribute("value"));
            Assert.AreEqual("Bulk Edit", driver.FindElement(By.CssSelector("div.col-xs-6.col-sm-3.form-group.pull-left.bulkEditHolder > input")).GetAttribute("value"));
            Assert.AreEqual("EXPORT TO PDF", driver.FindElement(By.CssSelector("#grid > div.k-header.k-grid-toolbar > a.k-button.k-button-icontext.k-grid-pdf")).Text);
            Assert.AreEqual("EXPORT TO EXCEL", driver.FindElement(By.CssSelector("#grid > div.k-header.k-grid-toolbar > a.k-button.k-button-icontext.k-grid-excel")).Text);
        }

        /*
        1. Impersonate: OP5316
        2. Go to “Voice” -> “Fixed Line”
        3. Verify that you are on the Voice Fixed Line page
        4. Check that there are 2 action buttons in the table; Edit & Quick Action

        */
        [Test]
        public void Voice_Mobile_Test_5()
        {
            var voicepage = new VoicePage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            voicepage.ImpersonateCOS010();

            driver.Navigate().GoToUrl(baseURL + "/Mobile/Mobile");
            driver.WaitForElementToDisplay(By.Id("template-toggle"), 60);
            Assert.AreEqual("Edit", driver.FindElement(By.CssSelector("#grid > table > tbody > tr:nth-child(1) > td.actionCol > a")).GetAttribute("title"));
            Assert.AreEqual("Quick Ticket", driver.FindElement(By.CssSelector("#grid > table > tbody > tr:nth-child(1) > td.actionCol > div > a")).GetAttribute("title"));

        }

        /*
        1. Impersonate: OP5316
        2. Go to “Voice” -> “Mobile”
        3. Verify that you are on the Voice Mobile page
        4. Check that there are 7 fields in the table of results; Billing frequency, CLI, Cost centre, Cost Centre 2, Recurring charge, Type, Username
        */
        [Test]
        public void Voice_Mobile_Test_6()
        {
            var voicepage = new VoicePage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            voicepage.ImpersonateCOS010();

            driver.Navigate().GoToUrl(baseURL + "/Mobile/Mobile");
            driver.WaitForElementToDisplay(By.Id("template-toggle"), 60);
            Assert.AreEqual("Billing frequency", driver.FindElement(By.CssSelector("")).GetAttribute(""));
            Assert.AreEqual("CLI", driver.FindElement(By.CssSelector("")).GetAttribute(""));
            Assert.AreEqual("Cost Centre", driver.FindElement(By.CssSelector("")).GetAttribute(""));
            Assert.AreEqual("Cost Centre 2", driver.FindElement(By.CssSelector("")).GetAttribute(""));
            Assert.AreEqual("Recurring Charge", driver.FindElement(By.CssSelector("")).GetAttribute(""));
            Assert.AreEqual("Type", driver.FindElement(By.CssSelector("")).GetAttribute(""));
            Assert.AreEqual("Username", driver.FindElement(By.CssSelector("")).GetAttribute(""));
        }
       
        /*
            1. Impersonate: OP5316
            2. Go to “Voice” -> “Mobile”
            3. Verify that you are on the Voice Mobile page
            4. Verify that there is data displayed in the table

        */
        [Test]
        public void Voice_Mobile_Test_7()
        {
            var voicepage = new VoicePage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            voicepage.ImpersonateCOS010();

            driver.Navigate().GoToUrl(baseURL + "/Mobile/Mobile");
            driver.WaitForElementToDisplay(By.Id("template-toggle"), 60);

            var tbody = driver.FindElement(By.CssSelector("#grid > table > tbody"));
            var rows = tbody.FindElements(By.CssSelector("tr"));

            Assert.IsTrue(tbody.Displayed);
            Assert.IsTrue(rows.Count() == 25);

        }

        /*
            1. Impersonate: OP5316
            2. Go to “Voice” -> “Mobile”
            3. Verify that you are on the Voice Mobile page
            4. Select all the entries, take note of this number
            5. Verify that the total number of entries is displayed
        */
        [Test]
        public void Voice_Mobile_Test_8()
        {
            var voicepage = new VoicePage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            voicepage.ImpersonateCOS010();

            driver.Navigate().GoToUrl(baseURL + "/Mobile/Mobile");
            driver.WaitForElementToDisplay(By.Id("template-toggle"), 60);

            var tbody = driver.FindElement(By.CssSelector("#grid > table > tbody"));
            var rows = tbody.FindElements(By.CssSelector("tr"));

            Assert.IsTrue(tbody.Displayed);
            Assert.IsTrue(rows.Count() == 25);


            voicepage.AllItemsPerPage();
            var tbody2 = driver.FindElement(By.CssSelector("#grid > table"));
            var rows2 = tbody.FindElements(By.CssSelector("tr"));

            Assert.IsTrue(tbody2.Displayed);
            Assert.IsTrue(rows2.Count() == 31);

        }

        /*
                1. Impersonate: OP5316
                2. Go to “Voice” -> “Mobile”
                3. Verify that you are on the Voice Mobile page
                4. Click Template management area
                5. Verify that you are taken to the Template management overview page, with the correct Voice type selected
        */
        [Test]
        public void Voice_Mobile_Test_11()
        {
            var voicepage = new VoicePage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            voicepage.ImpersonateCOS010();

            driver.Navigate().GoToUrl(baseURL + "/Mobile/Mobile");
            driver.WaitForElementToDisplay(By.Id("template-toggle"), 60);
            driver.FindElement(By.CssSelector("#mobile-search-form > div > div > div.col-xs-12.col-sm-6 > span > a > strong")).Click();

            Assert.IsTrue(driver.FindElements(By.CssSelector("div.body-outer.col-xs-9.col-sm-9.col-md-9.col-lg-10 > div.body-inner > div.template > h1")).Count > 0);
        }

        /*
            1. Impersonate: OP5316
            2. Go to “Voice” -> “Mobile”
            3. Verify that you are on the Voice Mobile page
            4. Click Template management area
            5. Verify that you are taken to the Template management overview page, with the correct Voice type selected
            6. Click add template
            7. Type Test2018 as the template name
            8. Click create
            9. Verify that the template has been created
        */
        [Test]
        public void Voice_Mobile_Test_12()
        {
            var voicepage = new VoicePage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            voicepage.ImpersonateCOS010();

            driver.Navigate().GoToUrl(baseURL + "/Mobile/Mobile");
            driver.WaitForElementToDisplay(By.Id("template-toggle"), 60);
            voicepage.CreateNewTemplate("Test 2018");
            Thread.Sleep(5000);
            string actualvalue = driver.FindElement(By.CssSelector("#template-management-table > tbody > tr:nth-child(2) > td:nth-child(1)")).Text;
            Assert.IsTrue(actualvalue.Contains("Test 2018"));

        }

        /*
            1. Impersonate: OP5316
            2. Go to “Voice” -> “Mobile”
            3. Verify that you are on the Voice Mobile page
            4. Click Template management area
            5. Verify that you are taken to the Template management overview page, with the correct Voice type selected
            6. Click the edit icon for one of the templates
            7. Change the template name
            8. Click save changes
            9. Verify that the template name has changed
        */
        [Test]
        public void Voice_Mobile_Test_13()
        {
            var voicepage = new VoicePage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            voicepage.ImpersonateCOS010();

            driver.Navigate().GoToUrl(baseURL + "/Mobile/Mobile");
            driver.WaitForElementToDisplay(By.Id("template-toggle"), 60);
            voicepage.EditExistingTemplate("Test 2019");
            Thread.Sleep(5000);
            string actualvalue = driver.FindElement(By.CssSelector("#template-management-table > tbody > tr:nth-child(2) > td:nth-child(1)")).Text;
            Assert.IsTrue(actualvalue.Contains("Test 2019"));
        }

        /*
            1. Impersonate: OP5316
            2. Go to “Voice” -> “Mobile”
            3. Verify that you are on the Voice Mobile page
            4. Click Template management area
            5. Verify that you are taken to the Template management overview page, with the correct Voice type selected
            6. Click the edit icon for one of the templates
            7. Untick an existing field
            8. Click save changes
            9. Verify that the field is no longer ticked
        */
        [Test]
        public void Voice_Mobile_Test_14()
        {
            var voicepage = new VoicePage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            voicepage.ImpersonateCOS010();

            driver.Navigate().GoToUrl(baseURL + "/Mobile/Mobile");
            driver.WaitForElementToDisplay(By.Id("template-toggle"), 60);
            voicepage.UntickExistingTemplate();
            voicepage.TickandUntick("#TemplateViewModel_1__Columns_1__Value", false);
        }

        /*
            1. Impersonate: OP5316
            2. Go to “Voice” -> “Mobile”
            3. Verify that you are on the Voice Mobile page
            4. Click Template management area
            5. Verify that you are taken to the Template management overview page, with the correct Voice type selected
            6. Click the edit icon for one of the templates
            7. Tick an existing field
            8. Click save changes
            9. Verify that the field is ticked
        */
        [Test]
        public void Voice_Mobile_Test_15()
        {
            var voicepage = new VoicePage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            voicepage.ImpersonateCOS010();

            driver.Navigate().GoToUrl(baseURL + "/Mobile/Mobile");
            driver.WaitForElementToDisplay(By.Id("template-toggle"), 60);
            voicepage.TickExistingTemplate();
            voicepage.TickandUntick("#TemplateViewModel_1__Columns_1__Value", true);

        }


        /*
            1. Impersonate: OP5316
            2. Go to “Voice” -> “Mobile”
            3. Verify that you are on the Voice Mobile page
            4. Click toggle template
            5. Verify that all the templates are listed under template name
        */
        [Test]
        public void Voice_Mobile_Test_16()
        {
            var voicepage = new VoicePage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            voicepage.ImpersonateCOS010();

            driver.Navigate().GoToUrl(baseURL + "/Mobile/Mobile");
            voicepage.ToggleTemplate();
            driver.FindElement(By.Id("SelectedID")).Click();
            string Template1 = driver.FindElement(By.CssSelector("#SelectedID > option:nth-child(1)")).Text;
            Assert.IsTrue(Template1.Contains("No Action"));
            string Template2 = driver.FindElement(By.CssSelector("#SelectedID > option:nth-child(2)")).Text;
            Assert.IsTrue(Template2.Contains("Test 2019"));
        }


        /*
            1. Impersonate: OP5316
            2. Go to “Voice” -> “Mobile”
            3. Verify that you are on the Voice Mobile page
            4. Click toggle template
            6. Verify that all the templates are listed under template name
            7. Change the template being used
            8. Click save changes
            9. Verify that the table reflects the new template used
        */
        [Test]
        public void Voice_Mobile_Test_17()
        {
            var voicepage = new VoicePage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            voicepage.ImpersonateCOS010();

            driver.Navigate().GoToUrl(baseURL + "/Mobile/Mobile");
            voicepage.ToggleTemplate();
            driver.FindElement(By.Id("SelectedID")).Click();
            voicepage.ChangeTemplate();

            Assert.AreEqual("CLI", driver.FindElement(By.CssSelector("#grid > table > thead > tr:nth-child(1) > th:nth-child(2)")).GetAttribute("data-field"));
            Assert.AreEqual("User Name", driver.FindElement(By.CssSelector("#grid > table > thead > tr:nth-child(1) > th:nth-child(3)")).GetAttribute("data-title"));
            Assert.AreEqual("Site Name", driver.FindElement(By.CssSelector("#grid > table > thead > tr:nth-child(1) > th:nth-child(4)")).GetAttribute("data-title"));
            Assert.AreEqual("Cost Centre", driver.FindElement(By.CssSelector("#grid > table > thead > tr:nth-child(1) > th:nth-child(5)")).GetAttribute("data-title"));
            Assert.AreEqual("CostCentre3", driver.FindElement(By.CssSelector("#grid > table > thead > tr:nth-child(1) > th:nth-child(6)")).GetAttribute("data-field"));
            Assert.AreEqual("Service", driver.FindElement(By.CssSelector("#grid > table > thead > tr:nth-child(1) > th:nth-child(7)")).GetAttribute("data-title"));
            Assert.AreEqual("Service Charge*", driver.FindElement(By.CssSelector("#grid > table > thead > tr:nth-child(1) > th:nth-child(8)")).GetAttribute("data-title"));
            Assert.AreEqual("Charge Description", driver.FindElement(By.CssSelector("#grid > table > thead > tr:nth-child(1) > th:nth-child(9)")).GetAttribute("data-title"));


        }


        /*
            1. Impersonate: OP5316
            2. Go to “Voice” -> “Mobile”
            3. Verify that you are on the Voice Mobile page
            4. Click Template management area
            5. Verify that you are taken to the Template management overview page, with the correct Voice type selected
            6. Go to template Test 2019
            7. Click delete
            8. Verify the template is deleted
        */
        [Test]
        public void Voice_Mobile_Test_18()
        {
            var voicepage = new VoicePage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            voicepage.ImpersonateCOS010();

            driver.Navigate().GoToUrl(baseURL + "/Mobile/Mobile");
            driver.WaitForElementToDisplay(By.Id("template-toggle"), 60);
            voicepage.DeleteExistingTemplate();
            Thread.Sleep(5000);
            var tbody = driver.FindElement(By.CssSelector("#template-management-table"));
            var rows = tbody.FindElements(By.CssSelector("tr"));

            Assert.IsTrue(tbody.Displayed);
            Assert.IsTrue(rows.Count() == 2);

        }

        /*
            1. Impersonate: OP5316
            2. Go to “Voice” -> “Mobile”
            3. Verify that you are on the Voice Mobile page
            4. Click the CLI heading
            5. Verify that the field is sorted into ascending order
            6. Click the CLI heading
            7. Verify that the field is sorted into descending order
        */
        [Test]
        public void Voice_Mobile_Test_19()
        {
            var voicepage = new VoicePage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            voicepage.ImpersonateCOS010();

            driver.Navigate().GoToUrl(baseURL + "/Mobile/Mobile");
            driver.WaitForElementToDisplay(By.Id("template-toggle"), 60);
            voicepage.CliAscending();
            Assert.AreEqual("ascending", driver.FindElement(By.CssSelector("#grid > table > thead > tr:nth-child(1) > th:nth-child(2)")).GetAttribute("aria-sort"));
            voicepage.CliDescending();
            Assert.AreEqual("descending", driver.FindElement(By.CssSelector("#grid > table > thead > tr:nth-child(1) > th:nth-child(2)")).GetAttribute("aria-sort"));
        }

        /*
            1. Impersonate: OP5316
            2. Go to “Voice” -> “Mobile”
            3. Verify that you are on the Voice Mobile page
            4. Click the search button next to the CLI heading
            5. Go to the first field and select contains 075
            6. Click filter
            7. Verify the results displayed contains 075

        */
        [Test]
        public void Voice_Mobile_Test_20()
        {
            var voicepage = new VoicePage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            voicepage.ImpersonateCOS010();

            driver.Navigate().GoToUrl(baseURL + "/Mobile/Mobile");
            driver.WaitForElementToDisplay(By.Id("template-toggle"), 60);
            voicepage.CliFilter("body > div.k-animation-container > form > div.k-animation-container > div > div.k-list-scroller > ul > li:nth-child(4)", "075");

            var filterOption = "075";
            var allFilteredOptions = driver.FindElements(By.CssSelector("tbody[role='rowgroup'] tr > td:nth-child(2)")).Where(o => o.Text.Contains(filterOption)).ToList();

            foreach (var o in allFilteredOptions)
            {
                StringAssert.Contains(filterOption, o.Text);
            }

            var tbody = driver.FindElement(By.CssSelector("#grid > table"));
            var rows = tbody.FindElements(By.CssSelector("tr"));

            Assert.IsTrue(tbody.Displayed);
            Assert.IsTrue(rows.Count() == 12);

        }

        /*
            1. Impersonate: OP5316
            2. Go to “Voice” -> “Mobile”
            3. Verify that you are on the Voice Mobile page
            4. Click the search button next to the CLI heading
            5. Go to the first field and select ends with 075
            6. Click filter
            7. Verify the results displayed end with 075
        */
        [Test]
        public void Voice_Mobile_Test_21()
        {
            var voicepage = new VoicePage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            voicepage.ImpersonateCOS010();

            driver.Navigate().GoToUrl(baseURL + "/Mobile/Mobile");
            driver.WaitForElementToDisplay(By.Id("template-toggle"), 60);
            voicepage.CliFilter("body > div.k-animation-container > form > div.k-animation-container > div > div.k-list-scroller > ul > li:nth-child(6)", "075");

            var filterOption = "075";
            var allFilteredOptions = driver.FindElements(By.CssSelector("tbody[role='rowgroup'] tr > td:nth-child(2)")).Where(o => o.Text.Contains(filterOption)).ToList();

            foreach (var o in allFilteredOptions)
            {
                StringAssert.Contains(filterOption, o.Text);
            }
            var tbody = driver.FindElement(By.CssSelector("#grid > table"));
            var rows = tbody.FindElements(By.CssSelector("tr"));

            Assert.IsTrue(tbody.Displayed);
            Assert.IsTrue(rows.Count() == 1);

        }

        /*
            1. Impersonate: OP5316
            2. Go to “Voice” -> “Mobile”
            3. Verify that you are on the Voice Mobile page
            4. Click the search button next to the CLI heading
            5. Click clear
            6. Verify that all records are returned
        */
        [Test]
        public void Voice_Mobile_Test_22()
        {
            var voicepage = new VoicePage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            voicepage.ImpersonateCOS010();

            driver.Navigate().GoToUrl(baseURL + "/Mobile/Mobile");
            driver.WaitForElementToDisplay(By.Id("template-toggle"), 60);
            voicepage.CliFilter("body > div.k-animation-container > form > div.k-animation-container > div > div.k-list-scroller > ul > li:nth-child(6)", "075");

            var filterOption = "075";
            var allFilteredOptions = driver.FindElements(By.CssSelector("tbody[role='rowgroup'] tr > td:nth-child(2)")).Where(o => o.Text.Contains(filterOption)).ToList();

            foreach (var o in allFilteredOptions)
            {
                StringAssert.Contains(filterOption, o.Text);
            }
            var tbody = driver.FindElement(By.CssSelector("#grid > table"));
            var rows = tbody.FindElements(By.CssSelector("tr"));

            Assert.IsTrue(tbody.Displayed);
            Assert.IsTrue(rows.Count() == 1);

            voicepage.ClearCliFilter();

            var tbody3 = driver.FindElement(By.CssSelector("#grid > table > tbody"));
            var rows3 = tbody.FindElements(By.CssSelector("tr"));

            Assert.IsTrue(tbody3.Displayed);
            Assert.IsTrue(rows3.Count() == 26);


            voicepage.AllItemsPerPage();
            var tbody2 = driver.FindElement(By.CssSelector("#grid > table"));
            var rows2 = tbody.FindElements(By.CssSelector("tr"));

            Assert.IsTrue(tbody2.Displayed);
            Assert.IsTrue(rows2.Count() == 32);

        }


        /*
            1. Impersonate: OP5316
            2. Go to “Voice” -> “Mobile”
            3. Verify that you are on the Voice Mobile page
            4. Click the Username heading
            5. Verify that the field is sorted into ascending order
            6. Click the Username heading
            7. Verify that the field is sorted into descending order
        */
        [Test]
        public void Voice_Mobile_Test_23()
        {
            var voicepage = new VoicePage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            voicepage.ImpersonateCOS010();

            driver.Navigate().GoToUrl(baseURL + "/Mobile/Mobile");
            driver.WaitForElementToDisplay(By.Id("template-toggle"), 60);
            voicepage.UsernameAscending();
            Assert.AreEqual("ascending", driver.FindElement(By.CssSelector("#grid > table > thead > tr:nth-child(1) > th:nth-child(3)")).GetAttribute("aria-sort"));
            voicepage.UsernameDescending();
            Assert.AreEqual("descending", driver.FindElement(By.CssSelector("#grid > table > thead > tr:nth-child(1) > th:nth-child(3)")).GetAttribute("aria-sort"));
        }

        /*
            1. Impersonate: OP5316
            2. Go to “Voice” -> “Mobile”
            3. Verify that you are on the Voice Mobile page
            4. Click the search button next to the Username heading
            5. Go to the first field and select contains Ref
            6. Click filter
            7. Verify the results displayed contains Ref
        */
        [Test]
        public void Voice_Mobile_Test_24()
        {
            var voicepage = new VoicePage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            voicepage.ImpersonateCOS010();

            driver.Navigate().GoToUrl(baseURL + "/Mobile/Mobile");
            driver.WaitForElementToDisplay(By.Id("template-toggle"), 60);
            voicepage.UsernameFilter("body > div.k-animation-container > form > div.k-animation-container > div > div.k-list-scroller > ul > li:nth-child(4)", "Ref");

            var filterOption = "Ref";
            var allFilteredOptions = driver.FindElements(By.CssSelector("tbody[role='rowgroup'] tr > td:nth-child(2)")).Where(o => o.Text.Contains(filterOption)).ToList();

            foreach (var o in allFilteredOptions)
            {
                StringAssert.Contains(filterOption, o.Text);
            }
            var tbody = driver.FindElement(By.CssSelector("#grid > table"));
            var rows = tbody.FindElements(By.CssSelector("tr"));

            Assert.IsTrue(tbody.Displayed);
            Assert.IsTrue(rows.Count() == 1);


        }

        /*
            1. Impersonate: OP5316
            2. Go to “Voice” -> “Mobile”
            3. Verify that you are on the Voice Mobile page
            4. Click the search button next to the Username heading
            5. Go to the first field and select ends with d
            6. Click filter
            7. Verify the results displayed end with d

        */
        [Test]
        public void Voice_Mobile_Test_25()
        {
            var voicepage = new VoicePage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            voicepage.ImpersonateCOS010();

            driver.Navigate().GoToUrl(baseURL + "/Mobile/Mobile");
            driver.WaitForElementToDisplay(By.Id("template-toggle"), 60);
            voicepage.UsernameFilter("body > div:nth-child(10) > form > div.k-animation-container > div > div.k-list-scroller > ul > li:nth-child(6)", "d");

            var filterOption = "d";
            var allFilteredOptions = driver.FindElements(By.CssSelector("tbody[role='rowgroup'] tr > td:nth-child(2)")).Where(o => o.Text.Contains(filterOption)).ToList();

            foreach (var o in allFilteredOptions)
            {
                StringAssert.Contains(filterOption, o.Text);
            }
            var tbody = driver.FindElement(By.CssSelector("#grid > table"));
            var rows = tbody.FindElements(By.CssSelector("tr"));

            Assert.IsTrue(tbody.Displayed);
            Assert.IsTrue(rows.Count() == 3);
        }


        /*
            1. Impersonate: OP5316
            2. Go to “Voice” -> “Mobile”
            3. Verify that you are on the Voice Mobile page
            4. Click the search button next to the Username heading
            5. Click clear
            6. Verify that all records are returned
        */
        [Test]
        public void Voice_Mobile_Test_26()
        {
            var voicepage = new VoicePage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            voicepage.ImpersonateCOS010();

            driver.Navigate().GoToUrl(baseURL + "/Mobile/Mobile");
            driver.WaitForElementToDisplay(By.Id("template-toggle"), 60);
            voicepage.UsernameFilter("body > div:nth-child(10) > form > div.k-animation-container > div > div.k-list-scroller > ul > li:nth-child(6)", "d");

            var filterOption = "d";
            var allFilteredOptions = driver.FindElements(By.CssSelector("tbody[role='rowgroup'] tr > td:nth-child(2)")).Where(o => o.Text.Contains(filterOption)).ToList();

            foreach (var o in allFilteredOptions)
            {
                StringAssert.Contains(filterOption, o.Text);
            }
            var tbody = driver.FindElement(By.CssSelector("#grid > table"));
            var rows = tbody.FindElements(By.CssSelector("tr"));

            Assert.IsTrue(tbody.Displayed);
            Assert.IsTrue(rows.Count() == 3);

            voicepage.ClearUsernameFilter();

            var tbody3 = driver.FindElement(By.CssSelector("#grid > table > tbody"));
            var rows3 = tbody.FindElements(By.CssSelector("tr"));

            Assert.IsTrue(tbody3.Displayed);
            Assert.IsTrue(rows3.Count() == 26);


            voicepage.AllItemsPerPage();
            var tbody2 = driver.FindElement(By.CssSelector("#grid > table"));
            var rows2 = tbody.FindElements(By.CssSelector("tr"));

            Assert.IsTrue(tbody2.Displayed);
            Assert.IsTrue(rows2.Count() == 32);


        }

        /*
            1. Impersonate: OP5316
            2. Go to “Voice” -> “Mobile”
            3. Verify that you are on the Voice Mobile page
            4. Click the Site name heading
            5. Verify that the field is sorted into ascending order
            6. Click the Site name heading
            7. 5. Verify that the field is sorted into descending order
        */
        [Test]
        public void Voice_Mobile_Test_27()
        {
            var voicepage = new VoicePage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            voicepage.ImpersonateCOS010();

            driver.Navigate().GoToUrl(baseURL + "/Mobile/Mobile");
            driver.WaitForElementToDisplay(By.Id("template-toggle"), 60);
            voicepage.SiteNameAscending();
            Assert.AreEqual("ascending", driver.FindElement(By.CssSelector("#grid > table > thead > tr:nth-child(1) > th:nth-child(4)")).GetAttribute("aria-sort"));
            voicepage.SiteNameDescending();
            Assert.AreEqual("descending", driver.FindElement(By.CssSelector("#grid > table > thead > tr:nth-child(1) > th:nth-child(4)")).GetAttribute("aria-sort"));
        }

        /*
            1. Impersonate: OP5316
            2. Go to “Voice” -> “Mobile”
            3. Verify that you are on the Voice Mobile page
            4. Click the search button next to the Site name heading
            5. Go to the first field and select has a value
            6. Click filter
            7. Verify the results displayed has a value
        */
        [Test]
        public void Voice_Mobile_Test_28()
        {
            var voicepage = new VoicePage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            voicepage.ImpersonateCOS010();

            driver.Navigate().GoToUrl(baseURL + "/Mobile/Mobile");
            driver.WaitForElementToDisplay(By.Id("template-toggle"), 60);
            voicepage.SiteNameFilter("body > div.k-animation-container > form > div.k-animation-container > div > div.k-list-scroller > ul > li:nth-child(12)", "");
            voicepage.AllItemsPerPage();
            var filterOption = "";
            var allFilteredOptions = driver.FindElements(By.CssSelector("tbody[role='rowgroup'] tr > td:nth-child(2)")).Where(o => o.Text.Contains(filterOption)).ToList();

            foreach (var o in allFilteredOptions)
            {
                StringAssert.Contains(filterOption, o.Text);
            }
            var tbody = driver.FindElement(By.CssSelector("#grid > table"));
            var rows = tbody.FindElements(By.CssSelector("tr"));

            Assert.IsTrue(tbody.Displayed);
            Assert.IsTrue(rows.Count() == 32);
        }


        /*
            1. Impersonate: OP5316
            2. Go to “Voice” -> “Mobile”
            3. Verify that you are on the Voice Mobile page
            4. Click the search button next to the Site name heading
            5. Go to the first field and select is null
            6. Click filter
            7. Verify the results displayed contains no value
        */
        [Test]
        public void Voice_Mobile_Test_29()
        {
            var voicepage = new VoicePage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            voicepage.ImpersonateCOS010();

            driver.Navigate().GoToUrl(baseURL + "/Mobile/Mobile");
            driver.WaitForElementToDisplay(By.Id("template-toggle"), 60);
            voicepage.SiteNameFilter("body > div.k-animation-container > form > div.k-animation-container > div > div.k-list-scroller > ul > li:nth-child(11)", "");

            var filterOption = "";
            var allFilteredOptions = driver.FindElements(By.CssSelector("tbody[role='rowgroup'] tr > td:nth-child(2)")).Where(o => o.Text.Contains(filterOption)).ToList();

            foreach (var o in allFilteredOptions)
            {
                StringAssert.Contains(filterOption, o.Text);
            }
            var tbody = driver.FindElement(By.CssSelector("#grid > table"));
            var rows = tbody.FindElements(By.CssSelector("tr"));

            Assert.IsTrue(tbody.Displayed);
            Assert.IsTrue(rows.Count() == 1);
        }


        /*
            1. Impersonate: OP5316
            2. Go to “Voice” -> “Mobile”
            3. Verify that you are on the Voice Mobile page
            4. Click the search button next to the Site name heading
            5. Click clear
            6. Verify that all records are returned
        */
        [Test]
        public void Voice_Mobile_Test_30()
        {
            var voicepage = new VoicePage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            voicepage.ImpersonateCOS010();

            driver.Navigate().GoToUrl(baseURL + "/Mobile/Mobile");
            driver.WaitForElementToDisplay(By.Id("template-toggle"), 60);
            voicepage.SiteNameFilter("body > div.k-animation-container > form > div.k-animation-container > div > div.k-list-scroller > ul > li:nth-child(11)", "");

            var filterOption = "";
            var allFilteredOptions = driver.FindElements(By.CssSelector("tbody[role='rowgroup'] tr > td:nth-child(2)")).Where(o => o.Text.Contains(filterOption)).ToList();

            foreach (var o in allFilteredOptions)
            {
                StringAssert.Contains(filterOption, o.Text);
            }
            var tbody = driver.FindElement(By.CssSelector("#grid > table"));
            var rows = tbody.FindElements(By.CssSelector("tr"));

            Assert.IsTrue(tbody.Displayed);
            Assert.IsTrue(rows.Count() == 1);

            voicepage.ClearSiteNameFilter();

            var tbody3 = driver.FindElement(By.CssSelector("#grid > table > tbody"));
            var rows3 = tbody.FindElements(By.CssSelector("tr"));

            Assert.IsTrue(tbody3.Displayed);
            Assert.IsTrue(rows3.Count() == 26);


            voicepage.AllItemsPerPage();
            var tbody2 = driver.FindElement(By.CssSelector("#grid > table"));
            var rows2 = tbody.FindElements(By.CssSelector("tr"));

            Assert.IsTrue(tbody2.Displayed);
            Assert.IsTrue(rows2.Count() == 32);

        }

        /*
            1. Impersonate: OP5316
            2. Go to “Voice” -> “Mobile”
            3. Verify that you are on the Voice Mobile page
            4. Click the Cost Centre heading
            5. Verify that the field is sorted into ascending order
            6. Click the Cost Centre heading
            7. 5. Verify that the field is sorted into descending order

        */
        [Test]
        public void Voice_Mobile_Test_31()
        {
            var voicepage = new VoicePage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            voicepage.ImpersonateCOS010();

            driver.Navigate().GoToUrl(baseURL + "/Mobile/Mobile");
            driver.WaitForElementToDisplay(By.Id("template-toggle"), 60);
            voicepage.CostCentreAscending();
            Assert.AreEqual("ascending", driver.FindElement(By.CssSelector("#grid > table > thead > tr:nth-child(1) > th:nth-child(5)")).GetAttribute("aria-sort"));
            voicepage.CostCentreDescending();
            Assert.AreEqual("descending", driver.FindElement(By.CssSelector("#grid > table > thead > tr:nth-child(1) > th:nth-child(5)")).GetAttribute("aria-sort"));
        }


        /*
            1. Impersonate: OP5316
            2. Go to “Voice” -> “Mobile”
            3. Verify that you are on the Voice Mobile page
            4. Click the search button next to the Cost Centre heading
            5. Go to the first field and select has a value
            6. Click filter
            7. Verify the results displayed has a value
        */
        [Test]
        public void Voice_Mobile_Test_32()
        {
            var voicepage = new VoicePage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            voicepage.ImpersonateCOS010();

            driver.Navigate().GoToUrl(baseURL + "/Mobile/Mobile");
            driver.WaitForElementToDisplay(By.Id("template-toggle"), 60);
            voicepage.CostCentreFilter("body > div.k-animation-container > form > div.k-animation-container > div > div.k-list-scroller > ul > li:nth-child(12)", "");

            var filterOption = "";
            var allFilteredOptions = driver.FindElements(By.CssSelector("tbody[role='rowgroup'] tr > td:nth-child(2)")).Where(o => o.Text.Contains(filterOption)).ToList();

            foreach (var o in allFilteredOptions)
            {
                StringAssert.Contains(filterOption, o.Text);
            }
            var tbody = driver.FindElement(By.CssSelector("#grid > table"));
            var rows = tbody.FindElements(By.CssSelector("tr"));

            Assert.IsTrue(tbody.Displayed);
            Assert.IsTrue(rows.Count() == 1);
        }

        /*
            1. Impersonate: OP5316
            2. Go to “Voice” -> “Mobile”
            3. Verify that you are on the Voice Mobile page
            4. Click the search button next to the Cost Centre heading
            5. Go to the first field and select is null
            6. Click filter
            7. Verify the results displayed contains no value
        */
        [Test]
        public void Voice_Mobile_Test_33()
        {
            var voicepage = new VoicePage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            voicepage.ImpersonateCOS010();

            driver.Navigate().GoToUrl(baseURL + "/Mobile/Mobile");
            driver.WaitForElementToDisplay(By.Id("template-toggle"), 60);
            voicepage.CostCentreFilter("body > div.k-animation-container > form > div.k-animation-container > div > div.k-list-scroller > ul > li:nth-child(11)", "");
            voicepage.AllItemsPerPage();
            var filterOption = "";
            var allFilteredOptions = driver.FindElements(By.CssSelector("tbody[role='rowgroup'] tr > td:nth-child(2)")).Where(o => o.Text.Contains(filterOption)).ToList();

            foreach (var o in allFilteredOptions)
            {
                StringAssert.Contains(filterOption, o.Text);
            }
            var tbody = driver.FindElement(By.CssSelector("#grid > table"));
            var rows = tbody.FindElements(By.CssSelector("tr"));

            Assert.IsTrue(tbody.Displayed);
            Assert.IsTrue(rows.Count() == 32);
        }


        /*
            1. Impersonate: OP5316
            2. Go to “Voice” -> “Mobile”
            3. Verify that you are on the Voice Mobile page
            4. Click the search button next to the Cost Centre heading
            5. Click clear
            6. Verify that all records are returned

        */
        [Test]
        public void Voice_Mobile_Test_34()
        {
            var voicepage = new VoicePage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            voicepage.ImpersonateCOS010();

            driver.Navigate().GoToUrl(baseURL + "/Mobile/Mobile");
            driver.WaitForElementToDisplay(By.Id("template-toggle"), 60);
            voicepage.CostCentreFilter("body > div.k-animation-container > form > div.k-animation-container > div > div.k-list-scroller > ul > li:nth-child(12)", "");

            var filterOption = "";
            var allFilteredOptions = driver.FindElements(By.CssSelector("tbody[role='rowgroup'] tr > td:nth-child(2)")).Where(o => o.Text.Contains(filterOption)).ToList();

            foreach (var o in allFilteredOptions)
            {
                StringAssert.Contains(filterOption, o.Text);
            }
            var tbody = driver.FindElement(By.CssSelector("#grid > table"));
            var rows = tbody.FindElements(By.CssSelector("tr"));

            Assert.IsTrue(tbody.Displayed);
            Assert.IsTrue(rows.Count() == 1);

            voicepage.ClearCostCentreFilter();

            var tbody3 = driver.FindElement(By.CssSelector("#grid > table > tbody"));
            var rows3 = tbody.FindElements(By.CssSelector("tr"));

            Assert.IsTrue(tbody3.Displayed);
            Assert.IsTrue(rows3.Count() == 26);


            voicepage.AllItemsPerPage();
            var tbody2 = driver.FindElement(By.CssSelector("#grid > table"));
            var rows2 = tbody.FindElements(By.CssSelector("tr"));

            Assert.IsTrue(tbody2.Displayed);
            Assert.IsTrue(rows2.Count() == 32);

        }

        /*
            1. Impersonate: OP5316
            2. Go to “Voice” -> “Mobile”
            3. Verify that you are on the Voice Mobile page
            4. Click the Cost Centre 2 heading
            5. Verify that the field is sorted into ascending order
            6. Click the Cost Centre 2 heading
            7.Verify that the field is sorted into descending order
        */
        [Test]
        public void Voice_Mobile_Test_35()
        {
            var voicepage = new VoicePage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            voicepage.ImpersonateCOS010();

            driver.Navigate().GoToUrl(baseURL + "/Mobile/Mobile");
            driver.WaitForElementToDisplay(By.Id("template-toggle"), 60);
            voicepage.ExCostCentreAscending();
            Assert.AreEqual("ascending", driver.FindElement(By.CssSelector("#grid > table > thead > tr:nth-child(1) > th:nth-child(6)")).GetAttribute("aria-sort"));
            voicepage.ExCostCentreDescending();
            Assert.AreEqual("descending", driver.FindElement(By.CssSelector("#grid > table > thead > tr:nth-child(1) > th:nth-child(6)")).GetAttribute("aria-sort"));
        }

        /*
            1. Impersonate: OP5316
            2. Go to “Voice” -> “Mobile”
            3. Verify that you are on the Voice Mobile page
            4. Click the search button next to the Cost Centre 2 heading
            5. Go to the first field and select is equal to test
            6. Click filter
            7. Verify the results displayed is equal to test

        */
        [Test]
        public void Voice_Mobile_Test_36()
        {
            var voicepage = new VoicePage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            voicepage.ImpersonateCOS010();

            driver.Navigate().GoToUrl(baseURL + "/Mobile/Mobile");
            driver.WaitForElementToDisplay(By.Id("template-toggle"), 60);
            voicepage.ExCostCentreFilter("body > div.k-animation-container > form > div.k-animation-container > div > div.k-list-scroller > ul > li:nth-child(1)", "test");

            var filterOption = "test";
            var allFilteredOptions = driver.FindElements(By.CssSelector("tbody[role='rowgroup'] tr > td:nth-child(2)")).Where(o => o.Text.Contains(filterOption)).ToList();

            foreach (var o in allFilteredOptions)
            {
                StringAssert.Contains(filterOption, o.Text);
            }
            var tbody = driver.FindElement(By.CssSelector("#grid > table"));
            var rows = tbody.FindElements(By.CssSelector("tr"));

            Assert.IsTrue(tbody.Displayed);
            Assert.IsTrue(rows.Count() == 1);
        }

        /*
            1. Impersonate: OP5316
            2. Go to “Voice” -> “Mobile”
            3. Verify that you are on the Voice Mobile page
            4. Click the search button next to the Cost Centre 2 heading
            5. Go to the first field and select is empty
            6. Click filter
            7. Verify the results displayed are empty 
        */
        [Test]
        public void Voice_Mobile_Test_37()
        {
            var voicepage = new VoicePage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            voicepage.ImpersonateCOS010();

            driver.Navigate().GoToUrl(baseURL + "/Mobile/Mobile");
            driver.WaitForElementToDisplay(By.Id("template-toggle"), 60);
            voicepage.ExCostCentreFilter("body > div.k-animation-container > form > div.k-animation-container > div > div.k-list-scroller > ul > li:nth-child(9)", "");

            var filterOption = "";
            var allFilteredOptions = driver.FindElements(By.CssSelector("tbody[role='rowgroup'] tr > td:nth-child(2)")).Where(o => o.Text.Contains(filterOption)).ToList();

            foreach (var o in allFilteredOptions)
            {
                StringAssert.Contains(filterOption, o.Text);
            }
            var tbody = driver.FindElement(By.CssSelector("#grid > table"));
            var rows = tbody.FindElements(By.CssSelector("tr"));

            Assert.IsTrue(tbody.Displayed);
            Assert.IsTrue(rows.Count() == 1);
        }


        /*
            1. Impersonate: OP5316
            2. Go to “Voice” -> “Mobile”
            3. Verify that you are on the Voice Mobile page
            4. Click the search button next to the Cost Centre 2 heading
            5. Click clear
            6. Verify that all records are returned
        */
        [Test]
        public void Voice_Mobile_Test_38()
        {
            var voicepage = new VoicePage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            voicepage.ImpersonateCOS010();

            driver.Navigate().GoToUrl(baseURL + "/Mobile/Mobile");
            driver.WaitForElementToDisplay(By.Id("template-toggle"), 60);
            voicepage.ExCostCentreFilter("body > div.k-animation-container > form > div.k-animation-container > div > div.k-list-scroller > ul > li:nth-child(1)", "test");

            var filterOption = "";
            var allFilteredOptions = driver.FindElements(By.CssSelector("tbody[role='rowgroup'] tr > td:nth-child(2)")).Where(o => o.Text.Contains(filterOption)).ToList();

            foreach (var o in allFilteredOptions)
            {
                StringAssert.Contains(filterOption, o.Text);
            }
            var tbody = driver.FindElement(By.CssSelector("#grid > table"));
            var rows = tbody.FindElements(By.CssSelector("tr"));

            Assert.IsTrue(tbody.Displayed);
            Assert.IsTrue(rows.Count() == 1);

            voicepage.ClearExCostCentreFilter();

            var tbody3 = driver.FindElement(By.CssSelector("#grid > table > tbody"));
            var rows3 = tbody.FindElements(By.CssSelector("tr"));

            Assert.IsTrue(tbody3.Displayed);
            Assert.IsTrue(rows3.Count() == 26);


            voicepage.AllItemsPerPage();
            var tbody2 = driver.FindElement(By.CssSelector("#grid > table"));
            var rows2 = tbody.FindElements(By.CssSelector("tr"));

            Assert.IsTrue(tbody2.Displayed);
            Assert.IsTrue(rows2.Count() == 32);
        }

        /*
            1. Impersonate: OP5316
            2. Go to “Voice” -> “Mobile”
            3. Verify that you are on the Voice Mobile page
            4. Click the Service heading
            5. Verify that the field is sorted into ascending order
            6. Click the Service heading
            7. Verify that the field is sorted into descending order
        */
        [Test]
        public void Voice_Mobile_Test_39()
        {
            var voicepage = new VoicePage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            voicepage.ImpersonateCOS010();

            driver.Navigate().GoToUrl(baseURL + "/Mobile/Mobile");
            driver.WaitForElementToDisplay(By.Id("template-toggle"), 60);
            voicepage.ServiceAscending();
            Assert.AreEqual("ascending", driver.FindElement(By.CssSelector("#grid > table > thead > tr:nth-child(1) > th:nth-child(7)")).GetAttribute("aria-sort"));
            voicepage.ServiceDescending();
            Assert.AreEqual("descending", driver.FindElement(By.CssSelector("#grid > table > thead > tr:nth-child(1) > th:nth-child(7)")).GetAttribute("aria-sort"));
        }

        /*
            1. Impersonate: OP5316
            2. Go to “Voice” -> “Mobile”
            3. Verify that you are on the Voice Mobile page
            4. Click the search button next to the Service heading
            5. Go to the first field and select contains VPS
            6. Click filter
            7. Verify the results displayed contains VPS
        */
        [Test]
        public void Voice_Mobile_Test_40()
        {
            var voicepage = new VoicePage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            voicepage.ImpersonateCOS010();

            driver.Navigate().GoToUrl(baseURL + "/Mobile/Mobile");
            driver.WaitForElementToDisplay(By.Id("template-toggle"), 60);
            voicepage.ServiceFilter("body > div.k-animation-container > form > div.k-animation-container > div > div.k-list-scroller > ul > li:nth-child(4)", "vodafone");
            voicepage.AllItemsPerPage();
            var filterOption = "vodafone";
            var allFilteredOptions = driver.FindElements(By.CssSelector("tbody[role='rowgroup'] tr > td:nth-child(2)")).Where(o => o.Text.Contains(filterOption)).ToList();

            foreach (var o in allFilteredOptions)
            {
                StringAssert.Contains(filterOption, o.Text);
            }
            var tbody = driver.FindElement(By.CssSelector("#grid > table"));
            var rows = tbody.FindElements(By.CssSelector("tr"));

            Assert.IsTrue(tbody.Displayed);
            Assert.IsTrue(rows.Count() == 32);
        }

        /*
            1. Impersonate: OP5316
            2. Go to “Voice” -> “Mobile”
            3. Verify that you are on the Voice Mobile page
            4. Click the search button next to the Service heading
            5. Go to the first field and select ends with Mobile
            6. Click filter
            7. Verify the results displayed end with Mobile
        */
        [Test]
        public void Voice_Mobile_Test_41()
        {
            var voicepage = new VoicePage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            voicepage.ImpersonateCOS010();

            driver.Navigate().GoToUrl(baseURL + "/Mobile/Mobile");
            driver.WaitForElementToDisplay(By.Id("template-toggle"), 60);
            voicepage.ServiceFilter("body > div.k-animation-container > form > div.k-animation-container > div > div.k-list-scroller > ul > li:nth-child(6)", "mobile");
            voicepage.AllItemsPerPage();
            var filterOption = "mobile";
            var allFilteredOptions = driver.FindElements(By.CssSelector("tbody[role='rowgroup'] tr > td:nth-child(2)")).Where(o => o.Text.Contains(filterOption)).ToList();

            foreach (var o in allFilteredOptions)
            {
                StringAssert.Contains(filterOption, o.Text);
            }
            var tbody = driver.FindElement(By.CssSelector("#grid > table"));
            var rows = tbody.FindElements(By.CssSelector("tr"));

            Assert.IsTrue(tbody.Displayed);
            Assert.IsTrue(rows.Count() == 1);
        }

        /*
            1. Impersonate: OP5316
            2. Go to “Voice” -> “Mobile”
            3. Verify that you are on the Voice Mobile page
            4. Click the search button next to the Service heading
            5. Click clear
            6. Verify that all records are returned
        */
        [Test]
        public void Voice_Mobile_Test_42()
        {
            var voicepage = new VoicePage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            voicepage.ImpersonateCOS010();

            driver.Navigate().GoToUrl(baseURL + "/Mobile/Mobile");
            driver.WaitForElementToDisplay(By.Id("template-toggle"), 60);
            voicepage.ServiceFilter("body > div.k-animation-container > form > div.k-animation-container > div > div.k-list-scroller > ul > li:nth-child(6)", "mobile");

            var filterOption = "mobile";
            var allFilteredOptions = driver.FindElements(By.CssSelector("tbody[role='rowgroup'] tr > td:nth-child(2)")).Where(o => o.Text.Contains(filterOption)).ToList();

            foreach (var o in allFilteredOptions)
            {
                StringAssert.Contains(filterOption, o.Text);
            }
            var tbody = driver.FindElement(By.CssSelector("#grid > table"));
            var rows = tbody.FindElements(By.CssSelector("tr"));

            Assert.IsTrue(tbody.Displayed);
            Assert.IsTrue(rows.Count() == 1);

            voicepage.ClearServiceFilter();

            var tbody3 = driver.FindElement(By.CssSelector("#grid > table > tbody"));
            var rows3 = tbody.FindElements(By.CssSelector("tr"));

            Assert.IsTrue(tbody3.Displayed);
            Assert.IsTrue(rows3.Count() == 26);


            voicepage.AllItemsPerPage();
            var tbody2 = driver.FindElement(By.CssSelector("#grid > table"));
            var rows2 = tbody.FindElements(By.CssSelector("tr"));

            Assert.IsTrue(tbody2.Displayed);
            Assert.IsTrue(rows2.Count() == 32);
        }

        /*
            1. Impersonate: OP5316
            2. Go to “Voice” -> “Mobile”
            3. Verify that you are on the Voice Mobile page
            4. Click the Service charge heading
            5. Verify that the field is sorted into ascending order
            6. Click the Service charge heading
            7. Verify that the field is sorted into descending order
        */
        [Test]
        public void Voice_Mobile_Test_43()
        {
            var voicepage = new VoicePage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            voicepage.ImpersonateCOS010();

            driver.Navigate().GoToUrl(baseURL + "/Mobile/Mobile");
            driver.WaitForElementToDisplay(By.Id("template-toggle"), 60);
            voicepage.ServiceChargeAscending();
            Assert.AreEqual("ascending", driver.FindElement(By.CssSelector("#grid > table > thead > tr:nth-child(1) > th:nth-child(8)")).GetAttribute("aria-sort"));
            voicepage.ServiceChargeDescending();
            Assert.AreEqual("descending", driver.FindElement(By.CssSelector("#grid > table > thead > tr:nth-child(1) > th:nth-child(8)")).GetAttribute("aria-sort"));
        }

        /*
            1. Impersonate: OP5316
            2. Go to “Voice” -> “Mobile”
            3. Verify that you are on the Voice Mobile page
            4. Click the search button next to the Service Charge heading
            5. Go to the first field and select contains 10
            6. Click filter
            7. Verify the results displayed contains 10
        */
        [Test]
        public void Voice_Mobile_Test_44()
        {
            var voicepage = new VoicePage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            voicepage.ImpersonateCOS010();

            driver.Navigate().GoToUrl(baseURL + "/Mobile/Mobile");
            driver.WaitForElementToDisplay(By.Id("template-toggle"), 60);
            voicepage.ServiceChargeFilter("body > div.k-animation-container > form > div.k-animation-container > div > div.k-list-scroller > ul > li:nth-child(6)", 20);

            var filterOption = "20";
            var allFilteredOptions = driver.FindElements(By.CssSelector("tbody[role='rowgroup'] tr > td:nth-child(2)")).Where(o => o.Text.Contains(filterOption)).ToList();

            foreach (var o in allFilteredOptions)
            {
                StringAssert.Contains(filterOption, o.Text);
            }
            var tbody = driver.FindElement(By.CssSelector("#grid > table"));
            var rows = tbody.FindElements(By.CssSelector("tr"));

            Assert.IsTrue(tbody.Displayed);
            Assert.IsTrue(rows.Count() == 1);
        }

        /*
            1. Impersonate: OP5316
            2. Go to “Voice” -> “Mobile”
            3. Verify that you are on the Voice Mobile page
            4. Click the search button next to the Service Charge heading
            5. Go to the first field and select equal to 100
            6. Click filter
            7. Verify the results displayed equal to 100
        */
        [Test]
        public void Voice_Mobile_Test_45()
        {
            var voicepage = new VoicePage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            voicepage.ImpersonateCOS010();

            driver.Navigate().GoToUrl(baseURL + "/Mobile/Mobile");
            driver.WaitForElementToDisplay(By.Id("template-toggle"), 60);
            voicepage.ServiceChargeFilter("body > div.k-animation-container > form > div.k-animation-container > div > div.k-list-scroller > ul > li:nth-child(1)", 100);

            var filterOption = "100";
            var allFilteredOptions = driver.FindElements(By.CssSelector("tbody[role='rowgroup'] tr > td:nth-child(2)")).Where(o => o.Text.Contains(filterOption)).ToList();

            foreach (var o in allFilteredOptions)
            {
                StringAssert.Contains(filterOption, o.Text);
            }
            var tbody = driver.FindElement(By.CssSelector("#grid > table"));
            var rows = tbody.FindElements(By.CssSelector("tr"));

            Assert.IsTrue(tbody.Displayed);
            Assert.IsTrue(rows.Count() == 3);
        }


        /*
            1. Impersonate: OP5316
            2. Go to “Voice” -> “Mobile”
            3. Verify that you are on the Voice Mobile page
            4. Click the search button next to the Service Charge heading
            5. Click clear
            6. Verify that all records are returned
        */
        [Test]
        public void Voice_Mobile_Test_46()
        {
            var voicepage = new VoicePage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            voicepage.ImpersonateCOS010();

            driver.Navigate().GoToUrl(baseURL + "/Mobile/Mobile");
            driver.WaitForElementToDisplay(By.Id("template-toggle"), 60);
            voicepage.ServiceChargeFilter("body > div.k-animation-container > form > div.k-animation-container > div > div.k-list-scroller > ul > li:nth-child(1)", 100);

            var filterOption = "";
            var allFilteredOptions = driver.FindElements(By.CssSelector("tbody[role='rowgroup'] tr > td:nth-child(2)")).Where(o => o.Text.Contains(filterOption)).ToList();

            foreach (var o in allFilteredOptions)
            {
                StringAssert.Contains(filterOption, o.Text);
            }
            var tbody = driver.FindElement(By.CssSelector("#grid > table"));
            var rows = tbody.FindElements(By.CssSelector("tr"));

            Assert.IsTrue(tbody.Displayed);
            Assert.IsTrue(rows.Count() == 3);

            voicepage.ClearServiceChargeFilter();

            var tbody3 = driver.FindElement(By.CssSelector("#grid > table > tbody"));
            var rows3 = tbody.FindElements(By.CssSelector("tr"));

            Assert.IsTrue(tbody3.Displayed);
            Assert.IsTrue(rows3.Count() == 26);


            voicepage.AllItemsPerPage();
            var tbody2 = driver.FindElement(By.CssSelector("#grid > table"));
            var rows2 = tbody.FindElements(By.CssSelector("tr"));

            Assert.IsTrue(tbody2.Displayed);
            Assert.IsTrue(rows2.Count() == 32);
        }

        /*
            1. Impersonate: OP5316
            2. Go to “Voice” -> “Mobile”
            3. Verify that you are on the Voice Mobile page
            4. Click the Charge Description heading
            5. Verify that the field is sorted into ascending order
            6. Click the Charge Description heading
            7. Verify that the field is sorted into descending order
        */
        [Test]
        public void Voice_Mobile_Test_47()
        {
            var voicepage = new VoicePage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            voicepage.ImpersonateCOS010();

            driver.Navigate().GoToUrl(baseURL + "/Mobile/Mobile");
            driver.WaitForElementToDisplay(By.Id("template-toggle"), 60);
            voicepage.ChargeDescriptionAscending();
            Assert.AreEqual("ascending", driver.FindElement(By.CssSelector("#grid > table > thead > tr:nth-child(1) > th:nth-child(9)")).GetAttribute("aria-sort"));
            voicepage.ChargeDescriptionDescending();
            Assert.AreEqual("descending", driver.FindElement(By.CssSelector("#grid > table > thead > tr:nth-child(1) > th:nth-child(9)")).GetAttribute("aria-sort"));
        }

        /*
            1. Impersonate: OP5316
            2. Go to “Voice” -> “Mobile”
            3. Verify that you are on the Voice Mobile page
            4. Click the search button next to the Charge Description heading
            5. Go to the first field and select has a value
            6. Click filter
            7. Verify the results displayed has a value
        */
        [Test]
        public void Voice_Mobile_Test_48()
        {
            var voicepage = new VoicePage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            voicepage.ImpersonateCOS010();

            driver.Navigate().GoToUrl(baseURL + "/Mobile/Mobile");
            driver.WaitForElementToDisplay(By.Id("template-toggle"), 60);
            voicepage.ChargeDescriptionFilter("body > div.k-animation-container > form > div.k-animation-container > div > div.k-list-scroller > ul > li:nth-child(12)", "");
            voicepage.AllItemsPerPage();
            var filterOption = "";
            var allFilteredOptions = driver.FindElements(By.CssSelector("tbody[role='rowgroup'] tr > td:nth-child(2)")).Where(o => o.Text.Contains(filterOption)).ToList();

            foreach (var o in allFilteredOptions)
            {
                StringAssert.Contains(filterOption, o.Text);
            }
            var tbody = driver.FindElement(By.CssSelector("#grid > table"));
            var rows = tbody.FindElements(By.CssSelector("tr"));

            Assert.IsTrue(tbody.Displayed);
            Assert.IsTrue(rows.Count() == 32);
        }


        /*
            1. Impersonate: OP5316
            2. Go to “Voice” -> “Mobile”
            3. Verify that you are on the Voice Mobile page
            4. Click the search button next to the Charge Description heading
            5. Go to the first field and select is null
            6. Click filter
            7. Verify the results displayed contains no value
        */
        [Test]
        public void Voice_Mobile_Test_49()
        {
            var voicepage = new VoicePage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            voicepage.ImpersonateCOS010();

            driver.Navigate().GoToUrl(baseURL + "/Mobile/Mobile");
            driver.WaitForElementToDisplay(By.Id("template-toggle"), 60);
            voicepage.ChargeDescriptionFilter("body > div.k-animation-container > form > div.k-animation-container > div > div.k-list-scroller > ul > li:nth-child(7)", "");
            voicepage.AllItemsPerPage();
            var filterOption = "";
            var allFilteredOptions = driver.FindElements(By.CssSelector("tbody[role='rowgroup'] tr > td:nth-child(2)")).Where(o => o.Text.Contains(filterOption)).ToList();

            foreach (var o in allFilteredOptions)
            {
                StringAssert.Contains(filterOption, o.Text);
            }
            var tbody = driver.FindElement(By.CssSelector("#grid > table"));
            var rows = tbody.FindElements(By.CssSelector("tr"));

            Assert.IsTrue(tbody.Displayed);
            Assert.IsTrue(rows.Count() == 1);
        }

        /*
            1. Impersonate: OP5316
            2. Go to “Voice” -> “Mobile”
            3. Verify that you are on the Voice Mobile page
            4. Click the search button next to the Charge Description heading
            5. Click clear
            6. Verify that all records are returned

        */
        [Test]
        public void Voice_Mobile_Test_50()
        {
            var voicepage = new VoicePage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            voicepage.ImpersonateCOS010();

            driver.Navigate().GoToUrl(baseURL + "/Mobile/Mobile");
            driver.WaitForElementToDisplay(By.Id("template-toggle"), 60);
            voicepage.ChargeDescriptionFilter("body > div.k-animation-container > form > div.k-animation-container > div > div.k-list-scroller > ul > li:nth-child(7)", "");

            var filterOption = "";
            var allFilteredOptions = driver.FindElements(By.CssSelector("tbody[role='rowgroup'] tr > td:nth-child(2)")).Where(o => o.Text.Contains(filterOption)).ToList();

            foreach (var o in allFilteredOptions)
            {
                StringAssert.Contains(filterOption, o.Text);
            }
            var tbody = driver.FindElement(By.CssSelector("#grid > table"));
            var rows = tbody.FindElements(By.CssSelector("tr"));

            Assert.IsTrue(tbody.Displayed);
            Assert.IsTrue(rows.Count() == 1);

            voicepage.ClearChargeDescriptionFilter();

            var tbody3 = driver.FindElement(By.CssSelector("#grid > table > tbody"));
            var rows3 = tbody.FindElements(By.CssSelector("tr"));

            Assert.IsTrue(tbody3.Displayed);
            Assert.IsTrue(rows3.Count() == 26);


            voicepage.AllItemsPerPage();
            var tbody2 = driver.FindElement(By.CssSelector("#grid > table"));
            var rows2 = tbody.FindElements(By.CssSelector("tr"));

            Assert.IsTrue(tbody2.Displayed);
            Assert.IsTrue(rows2.Count() == 32);
        }

        /*
            1. Impersonate: OP5316
            2. Go to “Voice” -> “Mobile”
            3. Verify that you are on the Voice Mobile page
            4. Select the radio buttons in the first column
            5. Verify that the number in the heading corresponds to the number of items selected
        */
        [Test]
        public void Voice_Mobile_Test_56()
        {
            var voicepage = new VoicePage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            voicepage.ImpersonateCOS010();

            driver.Navigate().GoToUrl(baseURL + "/Mobile/Mobile");
            driver.WaitForElementToDisplay(By.Id("template-toggle"), 60);
            voicepage.SelectRecord();
            voicepage.CheckboxVerification(".k-checkbox", true);

        }

        /*
            1. Impersonate: OP5316
            2. Go to “Voice” -> “Mobile”
            3. Verify that you are on the Voice Mobile page
            4. Click Bulk Edit
        */
        [Test]
        public void Voice_Mobile_Test_57()
        {
            var voicepage = new VoicePage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            voicepage.ImpersonateCOS010();

            driver.Navigate().GoToUrl(baseURL + "/Mobile/Mobile");
            driver.WaitForElementToDisplay(By.Id("template-toggle"), 60);
            voicepage.BulkEdit.Click();
            var errorHolder = driver.FindElement(By.CssSelector("#telerik-div > div > div > div.col-xs-6.col-sm-3.form-group.pull-left.bulkEditHolder > div > span"));
            StringAssert.Contains("Please select more than 0 inputs", errorHolder.Text);

        }

        /*
            1. Impersonate: OP5316
            2. Go to “Voice” -> “Mobile”
            3. Verify that you are on the Voice Mobile page
            4. Select a few entries
            5. Click Bulk Edit
            6. Click cancel
        */
        [Test]
        public void Voice_Mobile_Test_62()
        {
            var voicepage = new VoicePage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            voicepage.ImpersonateCOS010();

            driver.Navigate().GoToUrl(baseURL + "/Mobile/Mobile");
            driver.WaitForElementToDisplay(By.Id("template-toggle"), 60);
            voicepage.CliAscending();
            voicepage.BulkEditCancel();

            StringAssert.Contains("Test User", driver.FindElement(By.CssSelector("#grid > table > tbody > tr:nth-child(1) > td:nth-child(3)")).Text);
            StringAssert.Contains("Test User", driver.FindElement(By.CssSelector("#grid > table > tbody > tr:nth-child(2) > td:nth-child(3)")).Text);
            StringAssert.Contains("Test User", driver.FindElement(By.CssSelector("#grid > table > tbody > tr:nth-child(3) > td:nth-child(3)")).Text);
            StringAssert.Contains("Test User", driver.FindElement(By.CssSelector("#grid > table > tbody > tr:nth-child(4) > td:nth-child(3)")).Text);

        }

        /*
            1. Impersonate: OP5316
            2. Go to “Voice” -> “Mobile”
            3. Verify that you are on the Voice Mobile page
            4. Select a few entries
            5. Click Bulk Edit
            6. Verify the username say no change
            7. Click Bulk Update
        */
        [Test]
        public void Voice_Mobile_Test_63()
        {
            var voicepage = new VoicePage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            voicepage.ImpersonateCOS010();

            driver.Navigate().GoToUrl(baseURL + "/Mobile/Mobile");
            driver.WaitForElementToDisplay(By.Id("template-toggle"), 60);
            voicepage.CliAscending();
            voicepage.BulkEditUsername("0");
            voicepage.CliAscending();


            StringAssert.Contains("Test User", driver.FindElement(By.CssSelector("#grid > table > tbody > tr:nth-child(1) > td:nth-child(3)")).Text);
            StringAssert.Contains("Test User", driver.FindElement(By.CssSelector("#grid > table > tbody > tr:nth-child(2) > td:nth-child(3)")).Text);
            StringAssert.Contains("Test User", driver.FindElement(By.CssSelector("#grid > table > tbody > tr:nth-child(3) > td:nth-child(3)")).Text);
            StringAssert.Contains("Test User", driver.FindElement(By.CssSelector("#grid > table > tbody > tr:nth-child(4) > td:nth-child(3)")).Text);

        }

        /*
            1. Impersonate: OP5316
            2. Go to “Voice” -> “Mobile”
            3. Verify that you are on the Voice Mobile page
            4. Select a few entries
            5. Click Bulk Edit
            6. Verify the extra cost centre says no change
            7. Click Bulk Update
        */
        [Test]
        public void Voice_Mobile_Test_64()
        {
            var voicepage = new VoicePage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            voicepage.ImpersonateCOS010();

            driver.Navigate().GoToUrl(baseURL + "/Mobile/Mobile");
            driver.WaitForElementToDisplay(By.Id("template-toggle"), 60);
            voicepage.CliAscending();
            voicepage.BulkEditExCostCentre("0");
            voicepage.CliAscending();
            StringAssert.Contains("Test Cost Centre 2", driver.FindElement(By.CssSelector("#grid > table > tbody > tr:nth-child(5) > td:nth-child(6)")).Text);
            StringAssert.Contains("Test Cost Centre 2", driver.FindElement(By.CssSelector("#grid > table > tbody > tr:nth-child(6) > td:nth-child(6)")).Text);
            StringAssert.Contains("Test Cost Centre 2", driver.FindElement(By.CssSelector("#grid > table > tbody > tr:nth-child(7) > td:nth-child(6)")).Text);
            StringAssert.Contains("Test Cost Centre 2", driver.FindElement(By.CssSelector("#grid > table > tbody > tr:nth-child(8) > td:nth-child(6)")).Text);
        }

        /*
            1. Impersonate: OP5316
            2. Go to “Voice” -> “Mobile”
            3. Verify that you are on the Voice Mobile page
            4. Select a few entries
            5. Click Bulk Edit
            6. Verify the Cost Centre says no change
            7. Click Bulk Update
        */
        [Test]
        public void Voice_Mobile_Test_65()
        {
            var voicepage = new VoicePage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            voicepage.ImpersonateCOS010();

            driver.Navigate().GoToUrl(baseURL + "/Mobile/Mobile");
            driver.WaitForElementToDisplay(By.Id("template-toggle"), 60);
            voicepage.CliAscending();
            voicepage.BulkEditCostCentre("0");
            voicepage.CliAscending();
            StringAssert.Contains("Test Cost Centre", driver.FindElement(By.CssSelector("#grid > table > tbody > tr:nth-child(9) > td:nth-child(5)")).Text);
            StringAssert.Contains("Test Cost Centre", driver.FindElement(By.CssSelector("#grid > table > tbody > tr:nth-child(10) > td:nth-child(5)")).Text);
            StringAssert.Contains("Test Cost Centre", driver.FindElement(By.CssSelector("#grid > table > tbody > tr:nth-child(11) > td:nth-child(5)")).Text);
            StringAssert.Contains("Test Cost Centre", driver.FindElement(By.CssSelector("#grid > table > tbody > tr:nth-child(12) > td:nth-child(5)")).Text);

        }

        /*
            1. Impersonate: OP5316
            2. Go to “Voice” -> “Mobile”
            3. Verify that you are on the Voice Mobile page
            4. Select a few entries
            5. Click Bulk Edit
            6. Change the username 
            7. Click Bulk Update
            8. Verify that the usernames have been updated
        */
        [Test]
        public void Voice_Mobile_Test_66()
        {
            var voicepage = new VoicePage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            voicepage.ImpersonateCOS010();

            driver.Navigate().GoToUrl(baseURL + "/Mobile/Mobile");
            driver.WaitForElementToDisplay(By.Id("template-toggle"), 60);
            voicepage.CliAscending();
            voicepage.BulkEditUsername("20152");
            voicepage.CliAscending();


            StringAssert.Contains("Test User", driver.FindElement(By.CssSelector("#grid > table > tbody > tr:nth-child(1) > td:nth-child(3)")).Text);
            StringAssert.Contains("Test User", driver.FindElement(By.CssSelector("#grid > table > tbody > tr:nth-child(2) > td:nth-child(3)")).Text);
            StringAssert.Contains("Test User", driver.FindElement(By.CssSelector("#grid > table > tbody > tr:nth-child(3) > td:nth-child(3)")).Text);
            StringAssert.Contains("Test User", driver.FindElement(By.CssSelector("#grid > table > tbody > tr:nth-child(4) > td:nth-child(3)")).Text);

        }

        /*
            1. Impersonate: OP5316
            2. Go to “Voice” -> “Mobile”
            3. Verify that you are on the Voice Mobile page
            4. Select a few entries
            5. Click Bulk Edit
            6. Change extra cost centre
            7. Click Bulk Update
            8. Verify that extra cost centre has been updated
        */
        [Test]
        public void Voice_Mobile_Test_67()
        {
            var voicepage = new VoicePage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            voicepage.ImpersonateCOS010();

            driver.Navigate().GoToUrl(baseURL + "/Mobile/Mobile");
            driver.WaitForElementToDisplay(By.Id("template-toggle"), 60);
            voicepage.CliAscending();
            voicepage.BulkEditExCostCentre("280");
            voicepage.CliAscending();
            StringAssert.Contains("Test Cost Centre 2", driver.FindElement(By.CssSelector("#grid > table > tbody > tr:nth-child(5) > td:nth-child(6)")).Text);
            StringAssert.Contains("Test Cost Centre 2", driver.FindElement(By.CssSelector("#grid > table > tbody > tr:nth-child(6) > td:nth-child(6)")).Text);
            StringAssert.Contains("Test Cost Centre 2", driver.FindElement(By.CssSelector("#grid > table > tbody > tr:nth-child(7) > td:nth-child(6)")).Text);
            StringAssert.Contains("Test Cost Centre 2", driver.FindElement(By.CssSelector("#grid > table > tbody > tr:nth-child(8) > td:nth-child(6)")).Text);
        }

        /*
            1. Impersonate: OP5316
            2. Go to “Voice” -> “Mobile”
            3. Verify that you are on the Voice Mobile page
            4. Select a few entries
            5. Click Bulk Edit
            6. Change cost centre
            7. Click Bulk Update
            8. Verify that cost centre has been updated
        */
        [Test]
        public void Voice_Mobile_Test_68()
        {
            var voicepage = new VoicePage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            voicepage.ImpersonateCOS010();

            driver.Navigate().GoToUrl(baseURL + "/Mobile/Mobile");
            driver.WaitForElementToDisplay(By.Id("template-toggle"), 60);
            voicepage.CliAscending();
            voicepage.BulkEditCostCentre("279");
            voicepage.CliAscending();
            StringAssert.Contains("Test Cost Centre", driver.FindElement(By.CssSelector("#grid > table > tbody > tr:nth-child(9) > td:nth-child(5)")).Text);
            StringAssert.Contains("Test Cost Centre", driver.FindElement(By.CssSelector("#grid > table > tbody > tr:nth-child(10) > td:nth-child(5)")).Text);
            StringAssert.Contains("Test Cost Centre", driver.FindElement(By.CssSelector("#grid > table > tbody > tr:nth-child(11) > td:nth-child(5)")).Text);
            StringAssert.Contains("Test Cost Centre", driver.FindElement(By.CssSelector("#grid > table > tbody > tr:nth-child(12) > td:nth-child(5)")).Text);

        }

        /*
            1. Impersonate: OP5316
            2. Go to “Voice” -> “Mobile”
            3. Verify that you are on the Voice Mobile page
            4. Click edit in the action column for any entry
            5. Change the username 
            6. Click save changes
            7. Verify that the username has been updated
        */
        [Test]
        public void Voice_Mobile_Test_69()
        {
            var voicepage = new VoicePage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            voicepage.ImpersonateCOS010();

            driver.Navigate().GoToUrl(baseURL + "/Mobile/Mobile");
            driver.WaitForElementToDisplay(By.Id("template-toggle"), 60);
            voicepage.CliAscending();
            voicepage.EditUsername("16662");
            voicepage.CliAscending();


            StringAssert.Contains("Don Camillo", driver.FindElement(By.CssSelector("#grid > table > tbody > tr:nth-child(1) > td:nth-child(3)")).Text);


        }

        /*
            1. Impersonate: OP5316
            2. Go to “Voice” -> “Mobile”
            3. Verify that you are on the Voice Mobile page
            4. Click edit in the action column for any entry
            5. Change extra cost centre
            6. Click save changes
            7. Verify that extra cost centre has been updated

        */
        [Test]
        public void Voice_Mobile_Test_70()
        {
            var voicepage = new VoicePage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            voicepage.ImpersonateCOS010();

            driver.Navigate().GoToUrl(baseURL + "/Mobile/Mobile");
            driver.WaitForElementToDisplay(By.Id("template-toggle"), 60);
            voicepage.CliAscending();
            voicepage.EditExCostCentre("280");
            voicepage.CliAscending();
            StringAssert.Contains("Test Cost Centre 2", driver.FindElement(By.CssSelector("#grid > table > tbody > tr:nth-child(1) > td:nth-child(6)")).Text);

        }

        /*
            1. Impersonate: OP5316
            2. Go to “Voice” -> “Mobile”
            3. Verify that you are on the Voice Mobile page
            4. Click edit in the action column for any entry
            5. Click cancel
        */
        [Test]
        public void Voice_Mobile_Test_71()
        {
            var voicepage = new VoicePage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            voicepage.ImpersonateCOS010();

            driver.Navigate().GoToUrl(baseURL + "/Mobile/Mobile");
            driver.WaitForElementToDisplay(By.Id("template-toggle"), 60);
            voicepage.CliAscending();
            voicepage.EditCancel();

            StringAssert.Contains("Test User", driver.FindElement(By.CssSelector("#grid > table > tbody > tr:nth-child(16) > td:nth-child(3)")).Text);


        }

        /*
            1. Impersonate: OP5316
            2. Go to “Voice” -> “Mobile”
            3. Verify that you are on the Voice Mobile page
            4. Click edit in the action column for any entry
            5. Click Create user
            6. Type Test User in the Username field
            7. Select a department
            8. Click add user
            9. Verify that the username has changed
        */
        [Test]
        public void Voice_Mobile_Test_76()
        {
            var voicepage = new VoicePage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            voicepage.ImpersonateCOS010();

            driver.Navigate().GoToUrl(baseURL + "/Mobile/Mobile");
            driver.WaitForElementToDisplay(By.Id("template-toggle"), 60);
            voicepage.CliAscending();
            voicepage.EditCreateNewUser("Test User 3");

            voicepage.EditVerifyUsername("20155");


            StringAssert.Contains("Test User 3", driver.FindElement(By.CssSelector("#SelectedUserNameID")).Text);


        }

        /*
            1. Impersonate: OP5316
            2. Go to “Voice” -> “Mobile”
            3. Verify that you are on the Voice Mobile page
            4. Click edit in the action column for any entry
            5. Check in the username drop down that ‘Test User’ is present
        */
        [Test]
        public void Voice_Mobile_Test_77()
        {
            var voicepage = new VoicePage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            voicepage.ImpersonateCOS010();

            driver.Navigate().GoToUrl(baseURL + "/Mobile/Mobile");
            driver.WaitForElementToDisplay(By.Id("template-toggle"), 60);
            voicepage.CliAscending();
            voicepage.EditUsername("20155");
            voicepage.CliAscending();

            StringAssert.Contains("Test User 3", driver.FindElement(By.CssSelector("#grid > table > tbody > tr:nth-child(3) > td:nth-child(3)")).Text);


        }

        /*
            1. Impersonate: OP5316
            2. Go to “Voice” -> “Mobile”
            3. Verify that you are on the Voice Mobile page
            4. Click edit in the action column for any entry
            5. Click Create Cost Centre
            6. Type ‘Fulham’ in the Cost centre name field
            7. Click add Cost centre
            8. Verify that the Cost centre has changed
        */
        [Test]
        public void Voice_Mobile_Test_78()
        {
            var voicepage = new VoicePage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            voicepage.ImpersonateCOS010();

            driver.Navigate().GoToUrl(baseURL + "/Mobile/Mobile");
            driver.WaitForElementToDisplay(By.Id("template-toggle"), 60);
            voicepage.CliAscending();
            voicepage.EditCreateNewCostCentre("Fulham");

            voicepage.EditVerifyCostCentre("281");


            StringAssert.Contains("Fulham", driver.FindElement(By.CssSelector("#SelectedCostCentre3ID")).Text);


        }

        /*
            1. Impersonate: OP5316
            2. Go to “Voice” -> “Mobile”
            3. Verify that you are on the Voice Mobile page
            4. Click edit in the action column for any entry
            5. Check in the extra cost centre drop down that ‘Test User’ is present
        */
        [Test]
        public void Voice_Mobile_Test_79()
        {
            var voicepage = new VoicePage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            voicepage.ImpersonateCOS010();

            driver.Navigate().GoToUrl(baseURL + "/Mobile/Mobile");
            driver.WaitForElementToDisplay(By.Id("template-toggle"), 60);
            voicepage.CliAscending();
            voicepage.EditCostCentre("281");
            voicepage.CliAscending();

            StringAssert.Contains("Fulham", driver.FindElement(By.CssSelector("#grid > table > tbody > tr:nth-child(1) > td:nth-child(5)")).Text);
        }


        /*
            1. Impersonate: OP5316
            2. Go to “Voice” -> “Mobile”
            3. Verify that you are on the Voice Mobile page
            4. Select a few entries
            5. Click Bulk Edit
            6. Verify that the CLI matches the items selected
        */

        [Test]
        public void Voice_Mobile_Test_58()
        {

            var voicepage = new VoicePage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            voicepage.ImpersonateCOS010();

            driver.Navigate().GoToUrl(baseURL + "/Mobile/Mobile");
            driver.WaitForElementToDisplay(By.Id("template-toggle"), 60);
            voicepage.CliAscending();

            var checkBoxes = driver.FindElements(By.CssSelector(".k-checkbox"));
            for (int i = 0; i < 4; i++)
            {
                checkBoxes[i].Click();
            }


            voicepage.BulkEdit.Click();

            var clickedCheckBoxes = driver.FindElements(By.CssSelector(".k-checkbox:checked")).ToList(); //Gets all checkboxes


            var cliMatches = false; //Sets default state of test
            foreach (var btn in clickedCheckBoxes) //Go through each button and run code -- loop
            {
                cliMatches = voicepage.ClickAndCheckCli(btn);// Run function on each button
                if (!cliMatches)
                {
                    break; //If false STOP loop
                }


                if (cliMatches)
                {
                    //Pass
                }
                else
                {
                    //Fail
                }

            }
        }

        /*
            1. Impersonate: OP5316
            2. Go to “Voice” -> “Mobile”
            3. Verify that you are on the Voice Mobile page
            4. Select a few entries
            5. Click Bulk Edit
            6. Verify that the username

         */
        [Test]
        public void Voice_Mobile_Test_59()
        {

            var voicepage = new VoicePage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            voicepage.ImpersonateCOS010();

            driver.Navigate().GoToUrl(baseURL + "/Mobile/Mobile");
            driver.WaitForElementToDisplay(By.Id("template-toggle"), 60);
            voicepage.CliAscending();

            var checkBoxes = driver.FindElements(By.CssSelector(".k-checkbox"));
            for (int i = 0; i < 4; i++)
            {
                checkBoxes[i].Click();

                voicepage.BulkEdit.Click();

                var clickedCostCentres = driver.FindElements(By.CssSelector("#grid > table > tbody > tr.k-state-selected > td:nth-child(5)"));

                var costCentreMatches = false; //Sets default state of test
                foreach (var costCentre in clickedCostCentres) //Go through each button and run code -- loop
                {
                    costCentreMatches = voicepage.ClickAndCheckCostCentre(costCentre);// Run function on each button
                    if (!costCentreMatches)
                    {
                        break; //If false STOP loop
                    }
                }


                if (costCentreMatches)
                {
                    //Pass
                }
                else
                {
                    //Fail
                }
            }
        }


        /*
        1. Impersonate: OP5316
        2. Go to “Voice” -> “Fixed Line”
        3. Verify that you are on the Voice Fixed Line page
        4. Check that there are 3 action buttons; Toggle Template, Bulk Edit, Export to PDF, Export to Excel
        */
        [Test]
        public void Voice_FixedLine_Test_1()
        {
            var voicepage = new VoicePage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            voicepage.ImpersonateCOS010();
            driver.Navigate().GoToUrl(baseURL + "/Mobile/Mobile");
            driver.WaitForElementToDisplay(By.Id("template-toggle"), 60);
            Assert.AreEqual("Toggle Template", driver.FindElement(By.CssSelector("#template-toggle")).GetAttribute("value"));
            Assert.AreEqual("Bulk Edit", driver.FindElement(By.CssSelector("div.col-xs-6.col-sm-3.form-group.pull-left.bulkEditHolder > input")).GetAttribute("value"));
            Assert.AreEqual("EXPORT TO PDF", driver.FindElement(By.CssSelector("#grid > div.k-header.k-grid-toolbar > a.k-button.k-button-icontext.k-grid-pdf")).Text);
            Assert.AreEqual("EXPORT TO EXCEL", driver.FindElement(By.CssSelector("#grid > div.k-header.k-grid-toolbar > a.k-button.k-button-icontext.k-grid-excel")).Text);
        }

        /*
        1. Impersonate: OP5316
        2. Go to “Voice” -> “Fixed Line”
        3. Verify that you are on the Voice Fixed Line page
        4. Check that there are 3 action buttons; Toggle Template, Bulk Edit, Export to PDF, Export to Excel
        */
        [Test]
        public void Voice_FixedLine_Test_2()
        {
           
        }
    }

}


    



        





