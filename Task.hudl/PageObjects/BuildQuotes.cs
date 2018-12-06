using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;
using FluidOne.ClientTesting.Dash.Entities;

namespace FluidOne.ClientTesting.Dash.PageObjects

{
    /// <summary>
    /// A PageObject for FluidOne Login page
    /// </summary>
    public class BuildQuotes

    {
        private IWebDriver _driver;

        [FindsBy(How = How.Id, Using = "Postcode")]
        private IWebElement Postcode { get; set; }

        [FindsBy(How = How.Id, Using = "btnAddSite")]
        private IWebElement AddSiteBtn { get; set; }

        [FindsBy(How = How.Id, Using = "#sites_table > tbody > tr > td:nth-child(4) > a")]
        private IWebElement RemoveSite { get; set; }

        [FindsBy(How = How.Id, Using = "#nni-area > label")]
        private IWebElement NNI { get; set; }

        [FindsBy(How = How.Id, Using = "#mpls-area > label")]
        private IWebElement PWANMPLS { get; set; }
   
        [FindsBy(How = How.Id, Using = "body > div.wrap.layout > div.body > div.body-outer.col-xs-9.col-sm-9.col-md-9.col-lg-10 > div.body-inner > form > div > div:nth-child(3) > div > div > label")]
        private IWebElement AllProviders { get; set; }

        [FindsBy(How = How.Id, Using = "#provider-area > div.col-xs-6 > div > div:nth-child(1) > div:nth-child(1) > label")]
        private IWebElement SkyBusiness { get; set; }

        [FindsBy(How = How.Id, Using = "#provider-area > div.col-xs-6 > div > div:nth-child(1) > div:nth-child(2) > label")]
        private IWebElement EoD { get; set; }

        [FindsBy(How = How.Id, Using = "#provider-area > div.col-xs-6 > div > div:nth-child(1) > div:nth-child(3) > label")]
        private IWebElement BtWholesale { get; set; }

        [FindsBy(How = How.Id, Using = "#provider-area > div.col-xs-6 > div > div:nth-child(2) > div:nth-child(1) > label")]
        private IWebElement Entanet { get; set; }

        [FindsBy(How = How.Id, Using = "#provider-area > div.col-xs-6 > div > div:nth-child(2) > div:nth-child(2) > label")]
        private IWebElement BtOpenreach { get; set; }

        [FindsBy(How = How.Id, Using = "#provider-area > div.col-xs-6 > div > div:nth-child(2) > div:nth-child(3) > label")]
        private IWebElement TalkTalkEfm { get; set; }

        [FindsBy(How = How.Id, Using = "#provider-area > div.col-xs-6 > div > div:nth-child(3) > div:nth-child(1) > label")]
        private IWebElement TalkTalkInternet { get; set; }

        [FindsBy(How = How.Id, Using = "#provider-area > div.col-xs-6 > div > div:nth-child(3) > div:nth-child(2) > label")]
        private IWebElement SSE { get; set; }

        [FindsBy(How = How.Id, Using = "#provider-area > div.col-xs-6 > div > div:nth-child(3) > div:nth-child(3) > label")]
        private IWebElement Colt { get; set; }

        [FindsBy(How = How.Id, Using = "#provider-area > div.col-xs-6 > div > div:nth-child(4) > div:nth-child(1) > label")]
        private IWebElement Vodafone { get; set; }

        [FindsBy(How = How.Id, Using = "#provider-area > div.col-xs-6 > div > div:nth-child(4) > div:nth-child(2) > label")]
        private IWebElement M24Seven { get; set; }

        [FindsBy(How = How.Id, Using = "#provider-area > div.col-xs-6 > div > div:nth-child(4) > div:nth-child(3) > label")]
        private IWebElement Gigaclear { get; set; }

        [FindsBy(How = How.Id, Using = "#provider-area > div.col-xs-6 > div > div:nth-child(5) > div:nth-child(1) > label")]
        private IWebElement Virgin { get; set; }

        [FindsBy(How = How.Id, Using = "#provider-area > div.col-xs-6 > div > div:nth-child(5) > div:nth-child(2) > label")]
        private IWebElement Virtual1 { get; set; }

        [FindsBy(How = How.Id, Using = "body > div.wrap.layout > div.body > div.body-outer.col-xs-9.col-sm-9.col-md-9.col-lg-10 > div.body-inner > form > div > div:nth-child(5) > div.col-xs-3.col-sm-7.col-md-7.col-lg-9 > label")]
        private IWebElement SubscribeBox { get; set; }

        [FindsBy(How = How.Id, Using = "btnAddSite")]
        private IWebElement GenerateQuoteBtn { get; set; }





















        public void BearerSpeedDropdown(string bearerSpeed)
        {
            _driver.FindElement(By.CssSelector($"#bearerSpeed option[value='{bearerSpeed}']"), 30).Click();
        }

        public void ServiceSpeedDropdown(string serviceSpeed)
        {
            _driver.FindElement(By.CssSelector($"#serviceSpeed option[value='{serviceSpeed}']"), 30).Click();
        }

        public BuildQuotes(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        public void ImpersonateABZ011()
        {

            var usermanagepage = new AdminPage(_driver);
            usermanagepage.PickOptionFromSeachDropdown("1");
            usermanagepage.SearchABZ011("ABZ011");

        }

        public void BuildQuote(string postcode, string bearerSpeed, string serviceSpeed)
        {
            Postcode.ClickAndSendKeys(postcode);
            BearerSpeedDropdown(bearerSpeed);
            ServiceSpeedDropdown(serviceSpeed);
            AddSiteBtn.Click();
            GenerateQuoteBtn.Click();
            _driver.WaitForElementToDisplay(By.CssSelector(""), 95, "");
        }

        public void QuoteforDIA()
        {
            GenerateQuoteBtn.Click();
            _driver.WaitForElementToDisplay(By.CssSelector(""), 95, "");
        }

        public void QuoteforNNI()
        {
            NNI.Click();
            GenerateQuoteBtn.Click();
            _driver.WaitForElementToDisplay(By.CssSelector(""), 95, "");
        }

        public void QuoteforPwanMpls()
        {
            PWANMPLS.Click();
            GenerateQuoteBtn.Click();
            _driver.WaitForElementToDisplay(By.CssSelector(""), 95, "");
        }
    }
}

