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

    public class CeaseConnectionsPage
    {

        private IWebDriver _driver;

        public CeaseConnectionsPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);

        }
        //Cease Order
        [FindsBy(How = How.CssSelector, Using = "#inputValue")]
        private IWebElement CeaseOrderValue { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#requiredDate")]
        private IWebElement CeaseDateBtn { get; set; }

        [FindsBy(How = How.CssSelector, Using = "body > div.wrap.layout > div.body > div.body-outer.col-xs-9.col-sm-9.col-md-9.col-lg-10 > div.body-inner > div:nth-child(1) > div:nth-child(8) > div.unit.col-xs-12.col-sm-12.col-md-12.col-lg-12 > div > a")]
        private IWebElement SelectContactBtn { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#btn-cease-order")]
        public IWebElement WholesaleSubmitCease { get; set; }


        [FindsBy(How = How.CssSelector, Using = "#SearchByValue")]
        private IWebElement SearchByValue { get; set; }


        [FindsBy(How = How.CssSelector, Using = "#SearchInput")]
        private IWebElement CeaseSearchInput { get; set; }

        [FindsBy(How = How.CssSelector, Using = "body > div.wrap.layout > div.body > div.body-outer.col-xs-9.col-sm-9.col-md-9.col-lg-10 > div.body-inner > form > div > div.col-xs-2.col-sm-2.col-md-2.col-lg-2.form-group > input")]
        private IWebElement SearchBtn { get; set; }

       
        [FindsBy(How = How.CssSelector, Using = "#CeaseOrderTable > thead > tr > th:nth-child(1) > a")]
        private IWebElement OrderId { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#CeaseOrderTable > thead > tr > th:nth-child(2) > a")]
        private IWebElement Status { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#CeaseOrderTable > thead > tr > th:nth-child(3) > a")]
        private IWebElement Dsl { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#CeaseOrderTable > thead > tr > th:nth-child(4) > a")]
        private IWebElement AddressId { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#CeaseOrderTable > thead > tr > th:nth-child(5) > a")]
        private IWebElement Postcode { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#CeaseOrderTable > thead > tr > th:nth-child(6) > a")]
        private IWebElement Product { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#CeaseOrderTable > thead > tr > th:nth-child(7) > a")]
        private IWebElement Created { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#CeaseOrderTable > thead > tr > th:nth-child(8) > a")]
        private IWebElement RequestedDate { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#CeaseOrderTable > thead > tr > th:nth-child(9) > a")]
        private IWebElement ContractTerminationDate { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#CeaseOrderTable > thead > tr > th:nth-child(10) > a")]
        private IWebElement Completed { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#CeaseOrderTable > thead > tr > th:nth-child(11) > a")]
        private IWebElement Revoked { get; set; }

        public void ProductProviderDropdown(string option)
        {
            _driver.FindElement(By.CssSelector($"#provider option[value='{option}']"), 30).Click();
        }

    
        public void SearchByDropdown(string option)
        {
            _driver.FindElement(By.CssSelector($"#ceaseByValue option[value='{option}']"), 30).Click();
        }

        //Direct Cease

        [FindsBy(How = How.CssSelector, Using = "#SearchValue")]
        private IWebElement DirectSearchValue { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#circuits > form > div > div.col-xs-2.col-sm-2.col-md-2.col-lg-2 > input")]
        private IWebElement DirectSearchBtn { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#CeaseOrderTable > tbody > tr > td:nth-child(9) > a")]
        private IWebElement DirectCeaseOrderBtn { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#SearchHistoryValue")]
        private IWebElement DirectHistorySearchValue { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#ceases-placed > form > div > div.col-xs-2.col-sm-2.col-md-2.col-lg-2 > input")]
        private IWebElement DirectHistorySearchBtn { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#CeaseOrderHistoryTable > thead > tr > th:nth-child(1) > a")]
        private IWebElement DirectCircuit { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#CeaseOrderHistoryTable > thead > tr > th:nth-child(2)")]
        private IWebElement DirectStatus { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#CeaseOrderHistoryTable > thead > tr > th:nth-child(3) > a")]
        private IWebElement DirectProduct { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#CeaseOrderHistoryTable > thead > tr > th:nth-child(4) > a")]
        private IWebElement DirectRequestedOn { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#CeaseOrderHistoryTable > thead > tr > th:nth-child(5) > a")]
        private IWebElement DirectContact { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#CeaseOrderHistoryTable > thead > tr > th:nth-child(6) > a")]
        private IWebElement DirectCeaseDate { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#CeaseOrderHistoryTable > thead > tr > th:nth-child(7)")]
        private IWebElement DirectRevokedOn { get; set; }


        [FindsBy(How = How.CssSelector, Using = "#CeaseCircuitsDiv > div:nth-child(9) > label")]
        private IWebElement DirectEarlyCeaseCheckBox { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#SelectedCircuitCeaseFeedback")]
        private IWebElement DirectFeedbackBox { get; set; }


        [FindsBy(How = How.CssSelector, Using = "#CeaseCircuitsDiv > div:nth-child(11) > div.unit.col-xs-12.col-sm-12.col-md-12.col-lg-12 > div > a")]
        private IWebElement DirectSelectContactBtn { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#btn-cease-order")]
        private IWebElement DirectSubmitCease { get; set; }

        

        public void DirectSearchByDropdown(string option)
        {
            _driver.FindElement(By.CssSelector($"#SearchBy option[value='{option}']"), 30).Click();
        }

        public void DirectHistorySearchDropdown(string option)
        {
            _driver.FindElement(By.CssSelector($"#SearchHistoryBy option[value='{option}']"), 30).Click();
        }

        public void DirectCeaseReasonDropdown(string option)
        {
            _driver.FindElement(By.CssSelector($"#SelectedCircuitCeaseReason option[value='{option}']"), 30).Click();
        }

        //Create Contact

        [FindsBy(How = How.CssSelector, Using = "#CreateContact")]
        private IWebElement CreateNewContactBtn { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#NewContact_Title")]
        private IWebElement NewContactTitle { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#NewContact_Firstname")]
        private IWebElement NewContactFirstName { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#NewContact_Lastname")]
        private IWebElement NewContactLastName { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#NewContact_Phone1")]
        private IWebElement NewContactPhone { get; set; }



        [FindsBy(How = How.CssSelector, Using = "#NewContact_Email")]
        private IWebElement NewContactEmail { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#AddContactButton")]
        private IWebElement AddContact { get; set; }



        public void ImpersonateABZ011()
        {

            var usermanagepage = new AdminPage(_driver);
            usermanagepage.PickOptionFromSeachDropdown("1");
            usermanagepage.SearchABZ011("ABZ011");

        }

        public void ImpersonateCOS010()
        {

            var usermanagepage = new AdminPage(_driver);
            usermanagepage.PickOptionFromSeachDropdown("1");
            usermanagepage.SearchUser2("COS010");

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

        public void CeaseDate(int months, int days)
        {
            DateTime newdate = DateTime.Today.AddMonths(months).AddDays(days);
            CeaseDateBtn.ClickAndSendKeys(newdate.ToShortDateString());
        }

        public void WholesaleCeaseSelectContact(string contact)
        {
            SelectContactBtn.Click();
            _driver.WaitForElementToDisplay(By.CssSelector("#contactModal > div > div"), 45);
            _driver.FindElement(By.CssSelector(contact)).Click();
        }

        public void WholesaleCeaseSelectContactTest(string contact)
        {
            WholesaleCeaseSelectContact(contact);
        }

        public void WholesaleCeaseSelectContactTest2(string contact)
        {
            WholesaleCeaseSelectContact(contact);
            SelectContactBtn.Click();
            _driver.WaitForElementToDisplay(By.CssSelector("#contactModal > div > div"), 45);
            _driver.FindElement(By.CssSelector("#selectContact-grid > tbody > tr:nth-child(3) > td:nth-child(7) > div > a")).Click();
        }

        public void WholesaleEditContactTest(string contact, string editContact, string newSurname)
        {
            WholesaleCeaseSelectContact(contact);
            SelectContactBtn.Click();
            _driver.WaitForElementToDisplay(By.CssSelector("#contactModal > div > div"), 45);
            _driver.FindElement(By.CssSelector(editContact)).Click();
            _driver.WaitForElementToDisplay(By.CssSelector("#contactModal > div > div"), 45);
            NewContactLastName.ClickAndSendKeys(newSurname);
            AddContact.Click();

        }
        public void CreateNewContact(string contact)
        {
            WholesaleCeaseSelectContact(contact);
            _driver.WaitForElementToDisplay(By.CssSelector("#contactModal > div > div"), 45);
            CreateNewContactBtn.Click();
            _driver.WaitForElementToDisplay(By.CssSelector("#contactModal > div > div"), 45);
            NewContactTitle.ClickAndSendKeys("Miss");
            NewContactFirstName.ClickAndSendKeys("Test");
            NewContactLastName.ClickAndSendKeys("User");
            NewContactEmail.ClickAndSendKeys("test.user@email.com");
            NewContactPhone.ClickAndSendKeys("07745612345");
            AddContact.Click();
        }


        public void WholesaleVerifyNewContactDisplayed(string contact)
        {
            WholesaleCeaseSelectContact(contact);
            _driver.FindElement(By.CssSelector("#selectContact-grid th a[href*='Firstname']")).Click();
            Thread.Sleep(2000);
            _driver.FindElement(By.CssSelector("#selectContact-grid th a[href*='Firstname']")).Click();
            Thread.Sleep(2000);


        }

        public void WholesaleCeaseOrder(string dsl, string provider)
        {
            SearchByDropdown("DSL");
            CeaseOrderValue.ClickAndSendKeys(dsl);
            ProductProviderDropdown(provider);
            CeaseDate(0, 0);
            WholesaleCeaseSelectContact("#selectContact-grid > tbody > tr:nth-child(4) > td:nth-child(7) > div > a");
            WholesaleSubmitCease.Click();
            
        }

        public void DirectCeaseSelectContact(string contact)
        {
            SelectContactBtn.Click();
            _driver.WaitForElementToDisplay(By.CssSelector("#contactModal > div > div"), 45);
            _driver.FindElement(By.CssSelector(contact)).Click();
        }
        public void DirectCeaseSelectContactTest(string contact)
        {
            DirectCeaseSelectContact(contact);
        }

        public void DirectCeaseSelectContactTest2(string contact)
        {
            DirectCeaseSelectContact(contact);
            SelectContactBtn.Click();
            _driver.WaitForElementToDisplay(By.CssSelector("#contactModal > div > div"), 45);
            _driver.FindElement(By.CssSelector("#selectContact-grid > tbody > tr:nth-child(3) > td:nth-child(7) > div > a")).Click();
        }

        public void DirectEditContactTest(string contact, string editContact, string newSurname)
        {
            DirectCeaseSelectContact(contact);
            SelectContactBtn.Click();
            _driver.WaitForElementToDisplay(By.CssSelector("#contactModal > div > div"), 45);
            _driver.FindElement(By.CssSelector(editContact)).Click();
            _driver.WaitForElementToDisplay(By.CssSelector("#contactModal > div > div"), 45);
            NewContactLastName.ClickAndSendKeys(newSurname);
            AddContact.Click();

        }
        public void DirectCreateNewContact(string contact)
        {
            DirectCeaseSelectContact(contact);
            _driver.WaitForElementToDisplay(By.CssSelector("#contactModal > div > div"), 45);
            CreateNewContactBtn.Click();
            _driver.WaitForElementToDisplay(By.CssSelector("#contactModal > div > div"), 45);
            NewContactTitle.ClickAndSendKeys("Miss");
            NewContactFirstName.ClickAndSendKeys("Test");
            NewContactLastName.ClickAndSendKeys("User");
            NewContactEmail.ClickAndSendKeys("test.user@email.com");
            NewContactPhone.ClickAndSendKeys("07745612345");
            AddContact.Click();
        }


        public void DirectVerifyNewContactDisplayed(string contact)
        {
            DirectCeaseSelectContact(contact);
            _driver.FindElement(By.CssSelector("#selectContact-grid th a[href*='Firstname']")).Click();
            Thread.Sleep(2000);
            _driver.FindElement(By.CssSelector("#selectContact-grid th a[href*='Firstname']")).Click();
            Thread.Sleep(2000);


        }

        public void DeleteNewContact()
        {

            _driver.FindElement(By.CssSelector("#selectContact-grid > tbody > tr:nth-child(4) > td:nth-child(9) > div > a")).Click();
            _driver.FindElement(By.CssSelector("#btn-delete-contact")).Click();
        }

        public void CeaseOrder(string searchBy, string value, string provider)
        {
            SearchByDropdown(searchBy);
            CeaseOrderValue.ClickAndSendKeys(value);
            ProductProviderDropdown(provider);

        }

        public void DirectEarlyCeaseOrder(string circuit, string reason)
        {
            DirectSearchByDropdown("1");
            DirectSearchValue.ClickAndSendKeys(circuit);
            DirectSearchBtn.Click();
            Thread.Sleep(3000);
            DirectCeaseOrderBtn.Click();
            DirectCeaseReasonDropdown(reason);
            DirectEarlyCeaseCheckBox.Click();
            DirectFeedbackBox.ClickAndSendKeys("");
            DirectCeaseSelectContact("#selectContact-grid > tbody > tr:nth-child(5) > td:nth-child(7) > div > a");
            DirectSubmitCease.Click();
        }

        public void DirectCeaseOrder(string circuit, string reason)
        {
            DirectSearchByDropdown("1");
            DirectSearchValue.ClickAndSendKeys(circuit);
            DirectSearchBtn.Click();
            Thread.Sleep(3000);
            DirectCeaseOrderBtn.Click();
            DirectCeaseReasonDropdown(reason);
          
            DirectFeedbackBox.ClickAndSendKeys("");
            DirectCeaseSelectContact("#selectContact-grid > tbody > tr:nth-child(5) > td:nth-child(7) > div > a");
            DirectSubmitCease.Click();
        }


    }




}
