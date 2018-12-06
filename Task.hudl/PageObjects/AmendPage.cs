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

    public class AmendPage
    {

        private IWebDriver _driver;

        public AmendPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);

        }

        [FindsBy(How = How.CssSelector, Using = "#RequestSearchValue")]
        private IWebElement ValueField { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#WholesaleContactSelection > div.unit.col-xs-12.col-sm-12.col-md-12.col-lg-12 > div > div:nth-child(1) > a > span")]
        private IWebElement SelectContactBtn { get; set; }


        [FindsBy(How = How.CssSelector, Using = "#AmendAttributes_Note")]
        private IWebElement NotesField { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#btn-submit")]
        private IWebElement SubmitAmend { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#AmendAttributes_CustomerRequiredDate")]
        private IWebElement CustomerRequiredDate { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#BookAppointmentButton")]
        private IWebElement BookAptBtn { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#SearchValue")]
        private IWebElement SearchField { get; set; }


        [FindsBy(How = How.CssSelector, Using = "#EndUserFirstName")]
        private IWebElement FirstName { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#EndUserLastName")]
        private IWebElement LastName { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#EndUserPhone")]
        private IWebElement PrimaryPhoneNumber { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#EndUserPhone2")]
        private IWebElement SecondaryPhoneNumber { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#EndUserEmail")]
        private IWebElement Email { get; set; }

        //need to change
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

        public void SearchByDropdown(string option)
        {
            _driver.FindElement(By.CssSelector($"#LineType option[value='{option}']"), 30).Click();
        }

        public void TypeDropdown(string option)
        {
            _driver.FindElement(By.CssSelector($"#OperationType option[value='{option}']"), 30).Click();
        }


        public void ReasonDropdown(string option)
        {
            _driver.FindElement(By.CssSelector($"#AddressSelect option[value='{option}']"), 30).Click();
        }

        public void SelectIdentifierDropdown(string option)
        {
            _driver.FindElement(By.CssSelector($"#AddressSelect option[value='{option}']"), 30).Click();
        }

        public void SelectContact()
        {
            SelectContactBtn.Click();
            _driver.WaitForElementToDisplay(By.CssSelector(""), 45);
            _driver.FindElement(By.CssSelector("#selectContact-grid > tbody > tr:nth-child(1) > td:nth-child(7) > div > a")).Click();

        }

        public void BookAppointment()
        {
            DateTime newdate = DateTime.Today.AddMonths(1).AddDays(3);
            BookAptBtn.ClickAndSendKeys(newdate.ToShortDateString());
        }



        public void NewCustomerRequiredDate()
        {
            DateTime newdate = DateTime.Today.AddMonths(1).AddDays(3);
            CustomerRequiredDate.ClickAndSendKeys(newdate.ToShortDateString());
        }


        public void BTChangedRequiredDateTest(string dsl)
        {
            SearchByDropdown("DSL");
            TypeDropdown("Order");
            ValueField.ClickAndSendKeys(dsl);
            SelectContact();
            ReasonDropdown("Amend customer required date");
            NewCustomerRequiredDate();
            SubmitAmend.Click();
         
        }

        public void TTChangedRequiredDateTest(string dsl)
        {
            SearchByDropdown("DSL");
            TypeDropdown("Order");
            ValueField.ClickAndSendKeys(dsl);
            SelectContact();
            ReasonDropdown("Amend customer required date");
            NewCustomerRequiredDate();
            SubmitAmend.Click();
        }

        public void BTNewAptTest(string dsl)
        {
            SearchByDropdown("DSL");
            TypeDropdown("Order");
            ValueField.ClickAndSendKeys(dsl);
            SelectContact();
            ReasonDropdown("Amend customer required date");
            NewCustomerRequiredDate();
            BookAppointment();
            SubmitAmend.Click();
        }

        public void TTNewAptTest(string dsl)
        {
            SearchByDropdown("DSL");
            TypeDropdown("Order");
            ValueField.ClickAndSendKeys(dsl);
            SelectContact();
            ReasonDropdown("Amend customer required date");
            NewCustomerRequiredDate();
            BookAppointment();
            SubmitAmend.Click();
        }

        public void BTAmendL3Test(string dsl)
        {
            SearchByDropdown("DSL");
            TypeDropdown("Order");
            ValueField.ClickAndSendKeys(dsl);
            SelectContact();
            ReasonDropdown("Unwilling to supply reason");
            SubmitAmend.Click();
        }

        public void TTAmendL3Test(string dsl)
        {
            SearchByDropdown("DSL");
            TypeDropdown("Order");
            ValueField.ClickAndSendKeys(dsl);
            SelectContact();
            ReasonDropdown("Unwilling to supply reason");
            SubmitAmend.Click();
        }
        public void BTLiveOrderTest(string dsl)
        {
            SearchByDropdown("DSL");
            TypeDropdown("Order");
            ValueField.ClickAndSendKeys(dsl);
            SelectContact();
            ReasonDropdown("Amend customer required date");
            NewCustomerRequiredDate();
            BookAppointment();
            SubmitAmend.Click();
        }

        public void TTLiveOrderTest(string dsl)
        {
            SearchByDropdown("DSL");
            TypeDropdown("Order");
            ValueField.ClickAndSendKeys(dsl);
            SelectContact();
            ReasonDropdown("Amend customer required date");
            NewCustomerRequiredDate();
            BookAppointment();
            SubmitAmend.Click();
        }

    }
}
