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

    public class ModifyConnectionsPage
    {

        private IWebDriver _driver;

        public ModifyConnectionsPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);

        }

        [FindsBy(How = How.CssSelector, Using = "#Search")]
        private IWebElement SearchField { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#btn-submit")]
        private IWebElement SearchBtn { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#ModifyOrderConnectionSelectContactDIV > div.unit.col-xs-12.col-sm-12.col-md-12.col-lg-12 > div > a")]
        private IWebElement SelectContactBtn { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#RequestReference")]
        private IWebElement ModifyReference { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#CustomerRequiredDate")]
        private IWebElement CustomerRequiredField{ get; set; }

        [FindsBy(How = How.CssSelector, Using = "#trafficweighting-area > label")]
        private IWebElement TrafficWeightingBox { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#annexm-area > label")]
        private IWebElement AnneXBox { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#POReference")]
        private IWebElement PoRef { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#SiteReference")]
        private IWebElement SiteRef { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#CircuitNote")]
        private IWebElement CircuitNote { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#Layer3VM_Layer3_VCORE_LanIPPrefix")]
        private IWebElement LanIP{ get; set; }

        [FindsBy(How = How.CssSelector, Using = "#BookAppointmentButton")]
        private IWebElement BookAptBtn { get; set; }


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

        [FindsBy(How = How.CssSelector, Using = "#btn-modify")]
        private IWebElement ModifyBtn { get; set; }

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
            _driver.FindElement(By.CssSelector($"#SearchBy option[value='{option}']"), 30).Click();
        }

        public void ProductDropdown(string option)
        {
            _driver.FindElement(By.CssSelector($"#SelectedProduct option[value='{option}']"), 30).Click();
        }


        public void SpeedDropdown(string option)
        {
            _driver.FindElement(By.CssSelector($"#SpeedOptionsList option[value='{option}']"), 30).Click();
        }

        public void StabilityOptionDropdown(string option)
        {
            _driver.FindElement(By.CssSelector($"#StabilityOption option[value='{option}']"), 30).Click();
        }

        public void InterleavingDropdown(string option)
        {
            _driver.FindElement(By.CssSelector($"#Interleaving option[value='{option}']"), 30).Click();
        }

        public void CareLevelDropdown(string option)
        {
            _driver.FindElement(By.CssSelector($"#CareLevel option[value='{option}']"), 30).Click();
        }

        public void TransitOptionDropdown(string option)
        {
            _driver.FindElement(By.CssSelector($"#Layer3TransitOption option[value='{option}']"), 30).Click();
        }

        public void CustomerRequiredDate(int months, int days)
        {
            DateTime newdate = DateTime.Today.AddMonths(months).AddDays(days);
            CustomerRequiredField.ClickAndSendKeys(newdate.ToShortDateString());
        }


        public void SearchByDslModify (string dsl)
        {
              SearchField.ClickAndSendKeys(dsl);
              SearchBtn.Click();
             _driver.WaitForElementToDisplay(By.CssSelector("#form-modify-connection > div:nth-child(31) > h2"), 45);
        }

        public void ChangeSpeed (string speed)
        {
            SpeedDropdown(speed);
      
        }

        public void ChangeProduct (string product)
        {
            ProductDropdown(product);
        }


        public void SelectContact()
        {
            SelectContactBtn.Click();
            _driver.WaitForElementToDisplay(By.CssSelector("#contactModal > div > div"), 45);
            _driver.FindElement(By.CssSelector("#selectContact-grid > tbody > tr:nth-child(1) > td:nth-child(7) > div > a")).Click();
        }

        public void SelectContactTest()
        {
            SelectContact();
        }

        public void SelectContactTest2()
        {
            SelectContact();
            SelectContactBtn.Click();
            _driver.WaitForElementToDisplay(By.CssSelector("#contactModal > div > div"), 45);
            _driver.FindElement(By.CssSelector("#selectContact-grid > tbody > tr:nth-child(3) > td:nth-child(7) > div > a")).Click();
        }

        public void EditContactTest(string editContact, string newSurname)
        {
            SelectContact();
            SelectContactBtn.Click();
            _driver.WaitForElementToDisplay(By.CssSelector("#contactModal > div > div"), 45);
            _driver.FindElement(By.CssSelector(editContact)).Click();
            _driver.WaitForElementToDisplay(By.CssSelector("#contactModal > div > div"), 45);
            NewContactLastName.ClickAndSendKeys(newSurname);
            AddContact.Click();

        }
        public void CreateNewContact()
        {
            SelectContact();
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

        public void VerifyNewContactDisplayed()
        {
            SelectContact();
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


        public void BookAppointment()
        {
            DateTime newdate = DateTime.Today.AddMonths(1).AddDays(3);
            BookAptBtn.ClickAndSendKeys(newdate.ToShortDateString());
        }
        public void DlmProfileChange()
        {

        }
    }
}
