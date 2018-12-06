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

    public class AvaliabilityPage<T> : BaseTest<T> where T : IWebDriver, new()
    {

        [SetUp]
        public void setup()
        {
            var login = new LoginPage(driver);
            driver.FindElement(By.CssSelector("body > div.cookieSection > div > button")).Click();
            login.Login(accountCode, email, password);
        }

        /*
         1. Go to Availability ->  Address Search
         2. From the Provider dropdown select TalkTalk
         3. In the Postcode input field type any postcode ( SE1 2AP)
         4. Click on Get Address
         5. Click Check Avalibilty for any of the addresses displayed
         6. Veify you are taken to the avalibilty check page

         */
        [Test]
        public void Availability_Test_33()
        {
            var avaliability = new AvaliabilityPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            avaliability.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Availability/AddressSearch");

            avaliability.CheckAvaliabilityPageDisplayed();

            Assert.AreEqual("Availability Check Result for A00062746684 CL", driver.FindElement(By.CssSelector("div.body-inner > div > h1")).Text);
        }


        /*
            1. Go to Availability ->  Address Search
            2. From the Provider dropdown select TalkTalk
            3. In the Postcode input field type any postcode ( SE1 2AP)
            4. Click on Get Address
            5. Check if any products are available for ordering
            6. Click Check Avalibilty for any of the addresses displayed
            7. Veify you are taken to the avalibilty check page
            8.Click order on any of the products displayed
            9.Verify the Order conrnction page is displayed
          
         */

        [Test]
        public void Availability_Test_34()
        {
            var avaliability = new AvaliabilityPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            avaliability.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Availability/AddressSearch");
            avaliability.CheckOrderingPageDisplayedFromAvaliability();

            Assert.AreEqual("Order New Connection", driver.FindElement(By.CssSelector("#orderconnection-header > div.col-xs-8.col-sm-8.col-md-8.col-lg-8 > h1")).Text);
        }

        /*
            1. Go to Availability -> Availability Check  menu.
            2. Select SMPF from the dropdown menu
            3.Select the Telephone Radio Button.
            4. Enter a valid dsl "02083115858"
            5. Click "Check" button.
            6. Check if any results are displayed
            7..Click order on any of the products displayed
            8.Verify the Order conrnction page is displayed
          
         */
        [Test]
        public void Availability_Test_35()
        {
            var avaliability = new AvaliabilityPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            avaliability.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Availability");
            avaliability.TelephoneSMPFOrdering();
            Assert.AreEqual("Order New Connection", driver.FindElement(By.CssSelector("#orderconnection-header > div.col-xs-8.col-sm-8.col-md-8.col-lg-8 > h1")).Text);
        }

        /*
            1. Go to Availability -> Availability Check  menu.
            2. Select MPF from the dropdown menu
            3.Select the Telephone Radio Button.
            4. Enter a valid dsl "02083115858"
            5. Click "Check" button.
            6. Check if any results are displayed
            7..Click order on any of the products displayed
            8.Verify the Order conrnction page is displayed
          
         */
        [Test]
        public void Availability_Test_36()
        {
            var avaliability = new AvaliabilityPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            avaliability.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Availability");
            avaliability.TelephoneMPFOrdering();
            Assert.AreEqual("Order New Connection", driver.FindElement(By.CssSelector("#orderconnection-header > div.col-xs-8.col-sm-8.col-md-8.col-lg-8 > h1")).Text);
        }

        /*
            1. Go to Availability -> Availability Check  menu.
            2. Select SMPF from the dropdown menu
            3.Select the Postcode radio button.
            4. Enter a valid Postcode "WF12 9BB"
            5. Click "Check" button.
            6. Check if any results are displayed
            7..Click order on any of the products displayed
            8.Verify the Order conrnction page is displayed 
         
         */
        [Test]
        public void Availability_Test_37()
        {
            var avaliability = new AvaliabilityPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            avaliability.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Availability");
            avaliability.PostcodeSMPFOrdering();
            Assert.AreEqual("Order New Connection", driver.FindElement(By.CssSelector("#orderconnection-header > div.col-xs-8.col-sm-8.col-md-8.col-lg-8 > h1")).Text);
        }

        /*
            1. Go to Availability -> Availability Check  menu.
            2. Select MPF from the dropdown menu
            3.Select the Postcode radio button.
            4. Enter a valid Postcode "WF12 9BB"
            5. Click "Check" button.
            6. Check if any results are displayed
            7..Click order on any of the products displayed
            8.Verify the Order conrnction page is displayed
         
         
         */
        [Test]
        public void Availability_Test_38()
        {
            var avaliability = new AvaliabilityPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            avaliability.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Availability");
            avaliability.PostcodeMPFOrdering();
            Assert.AreEqual("Order New Connection", driver.FindElement(By.CssSelector("#orderconnection-header > div.col-xs-8.col-sm-8.col-md-8.col-lg-8 > h1")).Text);
        }

        /*
            1. Go to Availability -> Availability Check  menu.
            2. Select SMPF from the dropdown menu
            3.Select the Address ID Radio Button.
            4. Enter a valid Address ID "A00026868731"
            5. Leave  District Code field empty
            6. Click "Check" button.
            7. Check if any results are displayed
            8.Click order on any of the products displayed
            9.Verify the Order conrnction page is displayed
          
         */
        [Test]
        public void Availability_Test_39()
        {
            var avaliability = new AvaliabilityPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            avaliability.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Availability");
            avaliability.AddressIdSMPFOrdering();
            Assert.AreEqual("Order New Connection", driver.FindElement(By.CssSelector("#orderconnection-header > div.col-xs-8.col-sm-8.col-md-8.col-lg-8 > h1")).Text);
        }

        /*
            1. Go to Availability -> Availability Check  menu.
            2. Select MPF from the dropdown menu
            3.Select the Address ID Radio Button.
            4. Enter a valid Address ID "A00026868731"
            5. Leave  District Code field empty
            6. Click "Check" button.
            7. Check if any results are displayed
            8.Click order on any of the products displayed
            9.Verify the Order conrnction page is displayed
          
         */
        [Test]
        public void Availability_Test_40()
        {
            var avaliability = new AvaliabilityPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            avaliability.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Availability");
            avaliability.AddressIdMPFOrdering();
            Assert.AreEqual("Order New Connection", driver.FindElement(By.CssSelector("#orderconnection-header > div.col-xs-8.col-sm-8.col-md-8.col-lg-8 > h1")).Text);
        }

        /*
            1. Go to Availability -> Availability Check  menu.
            2. Select SMPF from the dropdown menu
            3.Select the Address ID Radio Button.
            4. Enter a valid Address ID "A00026868731"
            5.Enter a valid District Code "EA"
            6. Click "Check" button.
            7. Check if any results are displayed
            8.Click order on any of the products displayed
            9.Verify the Order conrnction page is displayed
         
         */
        [Test]
        public void Availability_Test_41()
        {
            var avaliability = new AvaliabilityPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            avaliability.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Availability");
            avaliability.AddressIdDistrictCodeSMPFOrdering();
            Assert.AreEqual("Order New Connection", driver.FindElement(By.CssSelector("#orderconnection-header > div.col-xs-8.col-sm-8.col-md-8.col-lg-8 > h1")).Text);
        }

        /*
            1. Go to Availability -> Availability Check  menu.
            2. Select MPF from the dropdown menu
            3.Select the Address ID Radio Button.
            4. Enter a valid Address ID "A00026868731"
            5.Enter a valid District Code "EA"
            6. Click "Check" button.
            7. Check if any results are displayed
            8.Click order on any of the products displayed
            9.Verify the Order conrnction page is displayed
          
         */
        [Test]
        public void Availability_Test_42()
        {
            var avaliability = new AvaliabilityPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            avaliability.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Availability");
            avaliability.AddressIdDistrictCodeMPFOrdering();
            Assert.AreEqual("Order New Connection", driver.FindElement(By.CssSelector("#orderconnection-header > div.col-xs-8.col-sm-8.col-md-8.col-lg-8 > h1")).Text);
        }

        /*
            1. Go to Availability -> Availability Check  menu.
            2. Select the Telephone radio button
            3. Make a Bulk check with the following values:
            SMPF,DSL,01000000002,
            SMPF,DSL,01000000001,
            SMPF,DSL,01000000003,
            SMPF,DSL,01000000004,
            4. Click on "Check"
            5. Once on the result page check all the inputs were processed

       */
        [Test]
        public void Availability_Test_15()
        {
            var avaliability = new AvaliabilityPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            avaliability.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Availability");
            avaliability.BulkCheckTest("SMPF,DSL,01000000002, SMPF,DSL,01000000001, SMPF,DSL,01000000003, SMPF,DSL,01000000004,");

            Assert.AreEqual("Bulk Availability Check Results", driver.FindElement(By.CssSelector("body > div.wrap.layout > div.body > div.body-outer.col-xs-9.col-sm-9.col-md-9.col-lg-10 > div.body-inner > div > h1")).Text);
            StringAssert.Contains("01000000001", driver.FindElement(By.CssSelector("#bulkstatus-grid")).Text);
            StringAssert.Contains("01000000002", driver.FindElement(By.CssSelector("#bulkstatus-grid")).Text);
            StringAssert.Contains("01000000003", driver.FindElement(By.CssSelector("#bulkstatus-grid")).Text);
            StringAssert.Contains("01000000004", driver.FindElement(By.CssSelector("#bulkstatus-grid")).Text);
        }

        /*
            1. Go to Availability -> Availability Check  menu.
            2. Select MPF from the dropdown menu
            3.Select the Address ID Radio Button.
            4. Enter a valid Address Key  "A0094031234"
            5. Leave  District Code field empty
            6. Click "Check" button.
            7. Check if any results are displayed 

      */
        [Test]
        public void Availability_Test_30()
        {
            var avaliability = new AvaliabilityPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            avaliability.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Availability");
            avaliability.MpfInvalidAddressIdEmptyDistrictCode("A0094031234");
            Assert.AreEqual("Invalid District Code.", driver.FindElement(By.CssSelector("#checkAvailability-feedback")).Text);
        }

        /*
            1. Go to Availability -> Availability Check  menu.
            2. Select MPF from the dropdown menu
            3.Select the Address ID Radio Button.
            4. Enter a valid Address Key  "A00940372581"
            5. Leave  District Code field empty
            6. Click "Check" button.
            7. Check if any results are displayed

      */
        [Test]
        public void Availability_Test_31()
        {
            var avaliability = new AvaliabilityPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            avaliability.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Availability");
            avaliability.SmpfAddressIdEmptyDistrictCode("A00940372581");
            Assert.AreEqual("Invalid District Code.", driver.FindElement(By.CssSelector("#checkAvailability-feedback")).Text);
        }
    }
    }
