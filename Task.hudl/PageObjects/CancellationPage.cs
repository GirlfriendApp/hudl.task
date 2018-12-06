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

    public class CancellationsPage
    {

        private IWebDriver _driver;

        public CancellationsPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);

        }

        [FindsBy(How = How.CssSelector, Using = "#RequestSearchValue")]
        private IWebElement RequestSearchValue { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#CancellationComment")]
        private IWebElement CommentsField { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#ContactSelection > div.unit.col-xs-12.col-sm-12.col-md-12.col-lg-12 > div.col-xs-2.col-sm-2.col-md-2.col-lg-2 > a")]
        private IWebElement SelectContactBtn { get; set; }

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

        

        [FindsBy(How = How.CssSelector, Using = "#btn-submit")]
        public IWebElement PlaceCancellation { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#SearchValue")]
        private IWebElement SearchValueField { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#cancellationHistorySearch")]
        private IWebElement SearchBtn { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#cancellationHistory > thead > tr > th:nth-child(1) > a")]
        private IWebElement CancelId { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#cancellationHistory > thead > tr > th:nth-child(2) > a")]
        private IWebElement CancelStatus { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#cancellationHistory > thead > tr > th:nth-child(3) > a")]
        private IWebElement RequestId { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#cancellationHistory > thead > tr > th:nth-child(4) > a")]
        private IWebElement DSL { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#cancellationHistory > thead > tr > th:nth-child(5) > a")]
        private IWebElement AddressId { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#cancellationHistory > thead > tr > th:nth-child(6) > a")]
        private IWebElement Postcode { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#cancellationHistory > thead > tr > th:nth-child(7) > a")]
        private IWebElement City { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#cancellationHistory > thead > tr > th:nth-child(8) > a")]
        private IWebElement Product { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#cancellationHistory > thead > tr > th:nth-child(9) > a")]
        private IWebElement PoRef { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#cancellationHistory > thead > tr > th:nth-child(10) > a")]
        private IWebElement Created { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#cancellationHistory > thead > tr > th:nth-child(11) > a")]
        private IWebElement Completed { get; set; }


        [FindsBy(How = How.CssSelector, Using = "#cancellationHistory > thead > tr > th:nth-child(12) > a")]
        private IWebElement Reason { get; set; }


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

        public void TypeDropdown(string option)
        {
            _driver.FindElement(By.CssSelector($"#RequestTypes option[value='{option}']"), 30).Click();
        }
        public void CancellationDropdown(string option)
        {
            _driver.FindElement(By.CssSelector($"#SelectedCancellationReason option[value='{option}']"), 30).Click();
        }

        public void SelectIdentifierDropdown(string option)
        {
            _driver.FindElement(By.CssSelector($"#SelectedSearchCategory option[value='{option}']"), 30).Click();
        }

        public void SelectContact()
        {
            SelectContactBtn.Click();
            _driver.WaitForElementToDisplay(By.CssSelector(""), 45);
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

        public void SearchByDslModify(string dsl, string cancellationReason)
        {
            SearchByDropdown("DSL");
            TypeDropdown("Modify");
            RequestSearchValue.ClickAndSendKeys(dsl);
            _driver.WaitForElementToDisplay(By.CssSelector("#CancellationDetails > div:nth-child(1) > div"), 45);
            CancellationDropdown(cancellationReason);
            CommentsField.ClickAndSendKeys("hdfjdkkjkjvddkdjknjdfnvjj");
            
        }
    }
}
