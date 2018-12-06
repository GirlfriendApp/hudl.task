using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;
using FluidOne.ClientTesting.Dash.Entities;
using System.Threading;

namespace FluidOne.ClientTesting.Dash.PageObjects

{

    public class OrderStatusPage
    {

        private IWebDriver _driver;

        public OrderStatusPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);

        }

        [FindsBy(How = How.CssSelector, Using = "#Search")]
        private IWebElement SearchField { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#search-btn")]
        private IWebElement SearchBtn { get; set; }

        [FindsBy(How = How.CssSelector, Using = "body > div.wrap.layout > div.body > div.body-outer.col-xs-9.col-sm-9.col-md-9.col-lg-10 > div.body-inner > form > div > div.ordersearch.col-xs-12.col-sm-12.col-md-12.col-lg-12 > div.clearfix.ordersearch-controls > a > input")]
        private IWebElement ExportBtn { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#Type")]
        private IWebElement Type { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#Status")]
        private IWebElement Status { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#Product")]
        private IWebElement Product { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#POReference")]
        private IWebElement PoRef { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#DSL")]
        private IWebElement Dsl { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#Postcode")]
        private IWebElement Postcode { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#CreatedDate")]
        private IWebElement Created { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#CommitedDate")]
        private IWebElement Committed { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#CompletedDate")]
        private IWebElement completed { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#RequestID")]
        private IWebElement OrderId { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#ServiceID")]
        private IWebElement ServiceId { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#popover-attr-64700 > img.def.magnificient")]
        private IWebElement MagnifyingGlass { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#history-59777")]
        public IWebElement PlusIcon { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#search-btn")]
        public IWebElement WholesaleMessage { get; set; }

        public void SearchSettingsDropdown(string option)
        {
            _driver.FindElement(By.CssSelector($"#SearchSetting option[value='{option}']"), 30).Click();
        }

        public void ImpersonateABZ011()
        {

            var usermanagepage = new AdminPage(_driver);
            usermanagepage.PickOptionFromSeachDropdown("1");
            usermanagepage.SearchABZ011("ABZ011");

        }

        public void ImpersonateZAGH901()
        {

            var usermanagepage = new AdminPage(_driver);
            usermanagepage.PickOptionFromSeachDropdown("1");
            usermanagepage.SearchABZ011("ZAGH901");

        }

        public void ImpersonateZAGH902()
        {

            var usermanagepage = new AdminPage(_driver);
            usermanagepage.PickOptionFromSeachDropdown("1");
            usermanagepage.SearchABZ011("ZAGH901");

        }

        public void ImpersonateZAGH903()
        {

            var usermanagepage = new AdminPage(_driver);
            usermanagepage.PickOptionFromSeachDropdown("1");
            usermanagepage.SearchABZ011("ZAGH903");

        }

        public void SearchByOrderId1()
        {
            SearchSettingsDropdown("RequestID");
            SearchField.ClickAndSendKeys("BT204044");
            SearchBtn.Click();
        }

        public void SearchByOrderId2()
        {
            SearchSettingsDropdown("RequestID");
            SearchField.ClickAndSendKeys("BT2040442");
            SearchBtn.Click();
        }

        public void MagnifyingGlassTest()
        {
            MagnifyingGlass.Click();
            _driver.WaitForElementToDisplay(By.CssSelector("#popover154845"), 45);
        }

        public bool IsOrderDetailsDisplayed()
        {
            try
            {
                _driver.FindElement(By.CssSelector("#popover154845"));
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }


    }
}
