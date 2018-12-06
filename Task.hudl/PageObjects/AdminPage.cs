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
   public class AdminPage
    {

        private IWebDriver _driver;

        [FindsBy(How = How.Id, Using = "SearchBy")]
        public IWebElement SearchDropdown { get; set; }

        [FindsBy(How = How.Id, Using = "Search")]
        private IWebElement TxtSearch { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input.btn.button-action-main.form-control")]
        public IWebElement SearchButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#create_user > div > input")]
        private IWebElement CreateUser { get; set; }

        [FindsBy(How = How.CssSelector, Using = "view-access-btn table-button button-image button-option-main-blue")]
        private IWebElement ViewAccessButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#users_table > tbody > tr.expandable-main-row > td:nth-child(8) > a")]
        private IWebElement Impersonate { get; set; }  

        [FindsBy(How = How.CssSelector, Using = "edit-detail-btn button-image button-option-main-blue")]
        private IWebElement EditUser { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#users_table > tbody > tr > td:nth-child(10) > a")]
        private IWebElement DeleteUser { get; set; }

        [FindsBy(How = How.Id, Using = "UserDeletionModal-Button")]
        private IWebElement DeleteUserConfirmation { get; set; }

        [FindsBy(How = How.Id, Using = "UserDeletionModal-CloseBtn")]
        private IWebElement DeleteUserCancellation { get; set; }


        //create a new user/edit user fields


        [FindsBy(How = How.CssSelector, Using = "#FirstName")]
        private IWebElement FirstName { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#LastName")]
        private IWebElement LastName { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#Email")]
        private IWebElement UserEmail { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#CompanyPublicPhone")]
        private IWebElement PhoneNumber { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#user-roles-section > div > div > div:nth-child(4) > div.role-list-main > div.col-sm-10.margin-top15 > div.col-sm-3 > label")]
        private IWebElement Admin { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#user-roles-section > div > div > div:nth-child(4) > div.role-list-main > div:nth-child(4) > div.col-sm-9.margin-top15.no-padding > div.col-sm-10.center")]
        private IWebElement ShowMoreAccessRights { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#user-roles-section > div > div > div:nth-child(4) > div.role-list-main > div.roleList > div:nth-child(3) > div.col-sm-3 > label")]
        private IWebElement API { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#user-roles-section > div > div > div:nth-child(4) > div.role-list-main > div.roleList > div:nth-child(6) > div.col-sm-3 > label")]
        private IWebElement Availability { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#user-roles-section > div > div > div:nth-child(4) > div.role-list-main > div.roleList > div:nth-child(9) > div.col-sm-3 > label")]
        private IWebElement Billing { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#user-roles-section > div > div > div:nth-child(4) > div.role-list-main > div.roleList > div:nth-child(12) > div.col-sm-3 > label")]
        private IWebElement DnsAdmin { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#user-roles-section > div > div > div:nth-child(4) > div.role-list-main > div.roleList > div:nth-child(15) > div.col-sm-3 > label")]
        private IWebElement EndUser { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#user-roles-section > div > div > div:nth-child(4) > div.role-list-main > div.roleList > div:nth-child(18) > div.col-sm-3 > label")]
        private IWebElement EoD_Order { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#user-roles-section > div > div > div:nth-child(4) > div.role-list-main > div.roleList > div:nth-child(21) > div.col-sm-3 > label")]
        private IWebElement EoD_View { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#user-roles-section > div > div > div:nth-child(4) > div.role-list-main > div.roleList > div:nth-child(24) > div.col-sm-3 > label")]
        private IWebElement Impersonation { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#user-roles-section > div > div > div:nth-child(4) > div.role-list-main > div.roleList > div:nth-child(27) > div.col-sm-3 > label")]
        private IWebElement IPMonitor { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#user-roles-section > div > div > div:nth-child(4) > div.role-list-main > div.roleList > div:nth-child(30) > div.col-sm-3 > label")]
        private IWebElement IPMonitor2 { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#user-roles-section > div > div > div:nth-child(4) > div.role-list-main > div.roleList > div:nth-child(33) > div.col-sm-3 > label")]
        private IWebElement MailDropAdmin { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#user-roles-section > div > div > div:nth-child(4) > div.role-list-main > div.roleList > div:nth-child(36) > div.col-sm-3 > label")]
        private IWebElement MailDropRecipient { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#user-roles-section > div > div > div:nth-child(4) > div.role-list-main > div.roleList > div:nth-child(39) > div.col-sm-3 > label")]
        private IWebElement Network { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#user-roles-section > div > div > div:nth-child(4) > div.role-list-main > div.roleList > div:nth-child(42) > div.col-sm-3 > label")]
        private IWebElement Partner { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#user-roles-section > div > div > div:nth-child(4) > div.role-list-main > div.roleList > div:nth-child(45) > div.col-sm-3 > label")]
        private IWebElement Partner_Enterprise { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#user-roles-section > div > div > div:nth-child(4) > div.role-list-main > div.roleList > div:nth-child(48) > div.col-sm-3 > label")]
        private IWebElement Provisioning { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#user-roles-section > div > div > div:nth-child(4) > div.role-list-main > div.roleList > div:nth-child(51) > div.col-sm-3 > label")]
        private IWebElement Provisioning_CDR { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#user-roles-section > div > div > div:nth-child(4) > div.role-list-main > div.roleList > div:nth-child(54) > div.col-sm-3 > label")]
        private IWebElement Provisioning_Cease { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#user-roles-section > div > div > div:nth-child(4) > div.role-list-main > div.roleList > div:nth-child(57) > div.col-sm-3 > label")]
        private IWebElement Provisioning_Modify { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#user-roles-section > div > div > div:nth-child(4) > div.role-list-main > div.roleList > div:nth-child(60) > div.col-sm-3 > label")]
        private IWebElement Provisioning_Order { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#user-roles-section > div > div > div:nth-child(4) > div.role-list-main > div.roleList > div:nth-child(63) > div.col-sm-3 > label")]
        private IWebElement Quote { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#user-roles-section > div > div > div:nth-child(4) > div.role-list-main > div.roleList > div:nth-child(66) > div.col-sm-3 > label")]
        private IWebElement SNS { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#user-roles-section > div > div > div:nth-child(4) > div.role-list-main > div.roleList > div:nth-child(69) > div.col-sm-3 > label")]
        private IWebElement SubAdmin_Billing { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#user-roles-section > div > div > div:nth-child(4) > div.role-list-main > div.roleList > div:nth-child(72) > div.col-sm-3 > label")]
        private IWebElement SubAdmin_Escalation { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#user-roles-section > div > div > div:nth-child(4) > div.role-list-main > div.roleList > div:nth-child(75) > div.col-sm-3 > label")]
        private IWebElement SubAdmin_Finance { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#user-roles-section > div > div > div:nth-child(4) > div.role-list-main > div.roleList > div:nth-child(78) > div.col-sm-3 > label")]
        private IWebElement SubAdmin_Sales { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#user-roles-section > div > div > div:nth-child(4) > div.role-list-main > div.roleList > div:nth-child(81) > div.col-sm-3 > label")]
        private IWebElement SubAdmin_Support { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#user-roles-section > div > div > div:nth-child(4) > div.role-list-main > div.roleList > div:nth-child(84) > div.col-sm-3 > label")]
        private IWebElement SuperUser { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#user-roles-section > div > div > div:nth-child(4) > div.role-list-main > div.roleList > div:nth-child(87) > div.col-sm-3 > label")]
        private IWebElement Support { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#user-roles-section > div > div > div:nth-child(4) > div.role-list-main > div.roleList > div:nth-child(90) > div.col-sm-3 > label")]
        private IWebElement Type_Direct { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#user-roles-section > div > div > div:nth-child(4) > div.role-list-main > div.roleList > div:nth-child(93) > div.col-sm-3 > label")]
        private IWebElement Type_Wholesale { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#user-roles-section > div > div > div:nth-child(4) > div.role-list-main > div.roleList > div:nth-child(96) > div.col-sm-3 > label")]
        private IWebElement Voice { get; set; }

        [FindsBy(How = How.Id, Using = "#user-create-submit-button")]
        private IWebElement ClickCreateUser { get; set; }

        [FindsBy(How = How.Id, Using = "GenericModal-CloseBtn")]
        private IWebElement CancelCreateUser { get; set; }

        public AdminPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);

        }

        public void PickAccountCodeDropdown(string option)
        {
            _driver.FindElement(By.CssSelector($"#AccountCode option[value='{option}']"), 30).Click();
        }
        public void PickSecurityDropdown(string option)
        {
            _driver.FindElement(By.CssSelector($"#securitygroups-select option[value='{option}']"), 30).Click();
        }

        public void PickOptionFromSeachDropdown(string option)
        {
            _driver.FindElement(By.CssSelector($"#SearchBy option[value='{option}']"), 30).Click();
        }

        public void PickMonthFromSeachDropdown(string option)
        {
            
            _driver.FindElement(By.CssSelector($"#CurrentReport option[value='{option}']"), 30).Click();
             Thread.Sleep(12000);
        }


        public void CreateNewUser()
        {
           
            CreateUser.Click();
            _driver.WaitForElementToDisplay(By.Id("createUser"), 45);
            FirstName.ClickAndSendKeys("Gogu");
            LastName.ClickAndSendKeys("Jiji");
            UserEmail.ClickAndSendKeys("Gogu.duru@email.com");
            PhoneNumber.ClickAndSendKeys("07745612345");
            _driver.FindElement(By.CssSelector($"#AccountIDSelected option[value='2']"), 30).Click();
            API.Click();
            Availability.Click();
            Quote.Click();
            ClickCreateUser.Click();
            Thread.Sleep(15000);
        }

        public void SearchUser (string option, string emailAddress)
        {
            _driver.FindElement(By.CssSelector($"#SearchBy option[value='{option}']"), 60).Click();
            TxtSearch.ClickAndSendKeys(emailAddress);
            SearchButton.Click();

        }

        public void SearchUser2(string accountCode)
        {
           
            TxtSearch.ClickAndSendKeys(accountCode);
            SearchButton.Click();
            
            Impersonate.Click();
           

        }
        public void SearchABZ011(string accountCode)
        {

            TxtSearch.ClickAndSendKeys(accountCode);
            SearchButton.Click();

           _driver.FindElement(By.CssSelector("#users_table > tbody > tr:nth-child(17) > td:nth-child(8) > a")).Click();


        }

        public void SearchZAGH901()
        {

            TxtSearch.ClickAndSendKeys("ZAGH901");
            SearchButton.Click();

            _driver.FindElement(By.CssSelector("#users_table > tbody > tr:nth-child(17) > td:nth-child(8) > a")).Click();


        }

        public void SearchZAGH902()
        {

            TxtSearch.ClickAndSendKeys("ZAGH902");
            SearchButton.Click();

            _driver.FindElement(By.CssSelector("#users_table > tbody > tr:nth-child(17) > td:nth-child(8) > a")).Click();


        }

        public void SearchZAGH903()
        {

            TxtSearch.ClickAndSendKeys("ZAGH903");
            SearchButton.Click();

            _driver.FindElement(By.CssSelector("#users_table > tbody > tr:nth-child(17) > td:nth-child(8) > a")).Click();


        }

        public void SearchDeleteUser()
        {
            DeleteUser.Click();
            _driver.WaitForElementToDisplay(By.Id("UserDeletionModal-Body"), 45, "");
            DeleteUserConfirmation.Click();
            Thread.Sleep(40000);
        }


        public void ImpersonateCOS010()
        {

            var usermanagepage = new AdminPage(_driver);
            usermanagepage.PickOptionFromSeachDropdown("1");
            usermanagepage.SearchUser2("COS010");

        }

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
            public bool IsPerformanceReportPresent()
        {
            try
            {
                _driver.FindElement(By.CssSelector("#reportViewer1 > div > div.trv-content-wrapper.k-content > div.trv-content > div.trv-pages-area.k-widget.interactive"));
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

    }
}
