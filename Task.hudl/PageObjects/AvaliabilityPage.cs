using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;
using FluidOne.ClientTesting.Dash.Entities;
using FluidOne.ClientTesting.Dash;
using System.Threading;

namespace FluidOne.ClientTesting.Dash.PageObjects
{
    public class AvaliabilityPage
    {
        public AvaliabilityPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);

        }

        private IWebDriver _driver;

        [FindsBy(How = How.CssSelector, Using = "#SingleCheckAvailabilityForm > div > div:nth-child(1) > label:nth-child(2)")]
        private IWebElement Telephone { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#SingleCheckAvailabilityForm > div > div:nth-child(1) > label:nth-child(4)")]
        private IWebElement Postcode { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#SingleCheckAvailabilityForm > div > div:nth-child(1) > label:nth-child(6)")]
        private IWebElement AddressId { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#Dsl")]
        private IWebElement DSL { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#Postcode")]
        private IWebElement PostcodeField { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#AddressId")]
        private IWebElement AddressKey { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#DistrictCode")]
        private IWebElement DistrictCode { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#SingleCheckAvailabilityForm > div > div:nth-child(2) > div.col-xs-2.col-sm-2.col-md-2.col-lg-2 > input")]
        private IWebElement CheckButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#get-address-button")]
        private IWebElement GetAddressButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#BulkTextBox")]
        private IWebElement BulkInformation { get; set; }

        [FindsBy(How = How.CssSelector, Using = "body > div.wrap.layout > div.body > div.body-outer.col-xs-9.col-sm-9.col-md-9.col-lg-10 > div.body-inner > div > div.col-xs-12.col-sm-12.col-md-12.col-lg-12 > form > div > div:nth-child(3) > input")]
        private IWebElement BulkCheck { get; set; }

        public void ImpersonateABZ011()
        {

            var usermanagepage = new AdminPage(_driver);
            usermanagepage.PickOptionFromSeachDropdown("1");
            usermanagepage.SearchABZ011("ABZ011");

        }
        public void ImpersonateBEA010()
        {

            var usermanagepage = new AdminPage(_driver);
            usermanagepage.PickOptionFromSeachDropdown("1");
            usermanagepage.SearchUser2("BEA010");
        }

        public void PickSmpfMpfDropdown(string option)
        {
            _driver.FindElement(By.CssSelector($"#LineType option[value='{option}']"), 30).Click();
        }

        public void PickProviderDropdown(string option)
        {
            _driver.FindElement(By.CssSelector($"#Provider option[value='{option}']"), 30).Click();
        }

        public void CheckAvaliabilityPageDisplayed()
        {
            PickProviderDropdown("TT");
            PostcodeField.ClickAndSendKeys("SE1 2AP");
            GetAddressButton.Click();
            _driver.WaitForElementToDisplay(By.CssSelector("#address-result-area"), 45, "");
            _driver.FindElement(By.CssSelector("#address-search-result-grid > tbody > tr:nth-child(21) > td:nth-child(4) > input")).Click();
            _driver.WaitForElementToDisplay(By.CssSelector("div.body-inner > div > h1"), 45, "");
        }

        public void CheckOrderingPageDisplayedFromAvaliability()
        {
            PickProviderDropdown("TT");
            PostcodeField.ClickAndSendKeys("SE1 2AP");
            GetAddressButton.Click();
            _driver.WaitForElementToDisplay(By.CssSelector("#address-result-area"), 45, "");
            _driver.FindElement(By.CssSelector("#address-search-result-grid > tbody > tr:nth-child(21) > td:nth-child(4) > input")).Click();
            _driver.WaitForElementToDisplay(By.CssSelector("div.body-inner > div > h1"), 45, "");
            _driver.FindElement(By.CssSelector("#TT-AvailabilityGrid > tbody > tr:nth-child(1) > td.webgrid-col-100 > button")).Click();
            _driver.WaitForElementToDisplay(By.CssSelector("#orderconnection-header > div.col-xs-8.col-sm-8.col-md-8.col-lg-8 > h1"), 45, "");
        }

        public void PostcodeSMPFOrdering()
        {
            Postcode.Click();
            PickSmpfMpfDropdown("SMPF");
            PostcodeField.ClickAndSendKeys("WF12 9BB");
            CheckButton.Click();
            _driver.WaitForElementToDisplay(By.CssSelector("div.body-inner > div > h1"), 45, "");
            _driver.FindElement(By.CssSelector("#BT-AvailabilityGrid > tbody > tr:nth-child(1) > td.webgrid-col-100 > button")).Click();
            _driver.WaitForElementToDisplay(By.CssSelector("#orderconnection-header > div.col-xs-8.col-sm-8.col-md-8.col-lg-8 > h1"), 45, "");

        }

        public void PostcodeMPFOrdering()
        {
            
            PickSmpfMpfDropdown("MPF");
            Postcode.Click();
            PostcodeField.ClickAndSendKeys("WF12 9BB");
            CheckButton.Click();
            _driver.WaitForElementToDisplay(By.CssSelector("div.body-inner > div > h1"), 45, "");
            _driver.FindElement(By.CssSelector("#TT-AvailabilityGrid > tbody > tr:nth-child(1) > td.webgrid-col-100 > button")).Click();
            _driver.WaitForElementToDisplay(By.CssSelector("#orderconnection-header > div.col-xs-8.col-sm-8.col-md-8.col-lg-8 > h1"), 45, "");

        }

        public void TelephoneSMPFOrdering()
        {
            Telephone.Click();
            PickSmpfMpfDropdown("SMPF");
            DSL.ClickAndSendKeys("02083115858");
            CheckButton.Click();
            _driver.WaitForElementToDisplay(By.CssSelector("div.body-inner > div > h1"), 45, "");
            _driver.FindElement(By.CssSelector("#BT-AvailabilityGrid > tbody > tr:nth-child(1) > td.webgrid-col-100 > button")).Click();
            _driver.WaitForElementToDisplay(By.CssSelector("#orderconnection-header > div.col-xs-8.col-sm-8.col-md-8.col-lg-8 > h1"), 45, "");
        }

        public void TelephoneMPFOrdering()
        {
           
            PickSmpfMpfDropdown("MPF");
            Telephone.Click();
            DSL.ClickAndSendKeys("02083115858");
            CheckButton.Click();
            _driver.WaitForElementToDisplay(By.CssSelector("div.body-inner > div > h1"), 45, "");
            _driver.FindElement(By.CssSelector("#TT-AvailabilityGrid > tbody > tr:nth-child(1) > td.webgrid-col-100 > button")).Click();
            _driver.WaitForElementToDisplay(By.CssSelector("#orderconnection-header > div.col-xs-8.col-sm-8.col-md-8.col-lg-8 > h1"), 45, "");

        }
        public void AddressIdSMPFOrdering()
        {
            AddressId.Click();
            PickSmpfMpfDropdown("SMPF");
            AddressKey.ClickAndSendKeys("A00026868731");
            CheckButton.Click();
            _driver.WaitForElementToDisplay(By.CssSelector("div.body-inner > div > h1"), 45, "");
            _driver.FindElement(By.CssSelector("#TT-AvailabilityGrid > tbody > tr:nth-child(1) > td.webgrid-col-100 > button")).Click();
            _driver.WaitForElementToDisplay(By.CssSelector("#orderconnection-header > div.col-xs-8.col-sm-8.col-md-8.col-lg-8 > h1"), 45, "");
        }
        public void AddressIdDistrictCodeSMPFOrdering()
        {
            AddressId.Click();
            PickSmpfMpfDropdown("SMPF");
            AddressKey.ClickAndSendKeys("A00026868731");
            DistrictCode.ClickAndSendKeys("EA");
            CheckButton.Click();
            _driver.WaitForElementToDisplay(By.CssSelector("div.body-inner > div > h1"), 45, "");
            _driver.FindElement(By.CssSelector("#TT-AvailabilityGrid > tbody > tr:nth-child(1) > td.webgrid-col-100 > button")).Click();
            _driver.WaitForElementToDisplay(By.CssSelector("#orderconnection-header > div.col-xs-8.col-sm-8.col-md-8.col-lg-8 > h1"), 45, "");
        }

        public void AddressIdMPFOrdering()
        {
            
            PickSmpfMpfDropdown("MPF");
            AddressId.Click();
            AddressKey.ClickAndSendKeys("A00026868731");
            CheckButton.Click();
            _driver.WaitForElementToDisplay(By.CssSelector("div.body-inner > div > h1"), 45, "");
            _driver.FindElement(By.CssSelector("#TT-AvailabilityGrid > tbody > tr:nth-child(1) > td.webgrid-col-100 > button")).Click();
            _driver.WaitForElementToDisplay(By.CssSelector("#orderconnection-header > div.col-xs-8.col-sm-8.col-md-8.col-lg-8 > h1"), 45, "");
        }
        public void AddressIdDistrictCodeMPFOrdering()
        {
           
            PickSmpfMpfDropdown("MPF");
            AddressId.Click();
            AddressKey.ClickAndSendKeys("A00026868731");
            DistrictCode.ClickAndSendKeys("EA");
            CheckButton.Click();
            _driver.WaitForElementToDisplay(By.CssSelector("div.body-inner > div > h1"), 45, "");
            _driver.FindElement(By.CssSelector("#TT-AvailabilityGrid > tbody > tr:nth-child(1) > td.webgrid-col-100 > button")).Click();
            _driver.WaitForElementToDisplay(By.CssSelector("#orderconnection-header > div.col-xs-8.col-sm-8.col-md-8.col-lg-8 > h1"), 45, "");
        }


        public void MpfInvalidAddressIdEmptyDistrictCode(string addressKey)
        {
            
            PickSmpfMpfDropdown("MPF");
            AddressId.Click();
            AddressKey.ClickAndSendKeys(addressKey);
         
            CheckButton.Click();
           
        }

        public void SmpfAddressIdEmptyDistrictCode(string addressKey)
        {

            AddressId.Click();
            PickSmpfMpfDropdown("SMPF");
            AddressKey.ClickAndSendKeys(addressKey);
           
            CheckButton.Click();
            
        }

        public void BulkCheckTest (string bulkInfo)
        {
            BulkInformation.ClickAndSendKeys(bulkInfo);
            BulkCheck.Click();
            _driver.WaitForElementToDisplay(By.CssSelector("body > div.wrap.layout > div.body > div.body-outer.col-xs-9.col-sm-9.col-md-9.col-lg-10 > div.body-inner > div > h1"), 45, "");
        }

    }
}
