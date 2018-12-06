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

    public class TwoFactorAuthenticationPages
    {

        private IWebDriver _driver;

        public TwoFactorAuthenticationPages(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);

        }

        //Login Page


        [FindsBy(How = How.Id, Using = "Account")]
        private IWebElement AccountCode { get; set; }

        [FindsBy(How = How.Id, Using = "Email")]
        private IWebElement Email { get; set; }

        [FindsBy(How = How.Id, Using = "Password")]
        private IWebElement Password { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#loginForm > div:nth-child(6) > input")]
        private IWebElement LoginBtn { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#loginForm > div:nth-child(6) > a")]
        public IWebElement ForgotPassword { get; set; }


        //Forgot Password Page

        [FindsBy(How = How.CssSelector, Using = "#Account")]
        public IWebElement AccountField { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#Email")]
        public IWebElement EmailField { get; set; }

        [FindsBy(How = How.CssSelector, Using = "body > div > div.body > div > div.container.default-bootstrap > form > div > div:nth-child(7) > input")]
        public IWebElement SubmitBtn { get; set; }

        //Authentication page

        [FindsBy(How = How.CssSelector, Using = "#RequestSearchValue")]
        private IWebElement ValueField { get; set; }

        //create new user
        [FindsBy(How = How.CssSelector, Using = "#create_user")]
        private IWebElement CreateAUser { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#create_user")]
        private IWebElement CreateUser { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#user-create-form > div.row.margin-top15 > div.roleList.col-xs-9 > div > div > div:nth-child(3) > div.col-sm-12.margin-top10.no-padding")]
        private IWebElement ShowMoreAccessRights { get; set; }
        //User Settings page
        //User Details

        public void AccountCodeDropdown(string option)
        {
            _driver.FindElement(By.CssSelector($"#NewIpRange option[value='{option}']"), 30).Click();
        }

        public void SecurityGroupDropdown(string option)
        {
            _driver.FindElement(By.CssSelector($"#NewIpRange option[value='{option}']"), 30).Click();
        }

        [FindsBy(How = How.CssSelector, Using = "#user-details-form > div.col-xs-12.margin-bottom30.row > label")]
        private IWebElement EnabledBtn { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#FirstName")]
        private IWebElement FirstName { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#LastName")]
        private IWebElement LastName { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#Email")]
        private IWebElement UserEmail { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#CompanyPublicPhone")]
        private IWebElement PhoneNumber { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#user-details-reset-authentication-button")]
        private IWebElement ResetAuthentication { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#user-details-submit-button")]
        private IWebElement SubmitChanges { get; set; }
        public void UserSecurityGroupDropdown(string option)
        {
            _driver.FindElement(By.CssSelector($"#changeSecurityGroup option[value='{option}']"), 30).Click();
        }

        [FindsBy(How = How.CssSelector, Using = "#user-details-reset-password-button")]
        private IWebElement ChangeYourPassword { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#OldPassword")]
        private IWebElement CurrentPassword { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#NewPassword")]
        private IWebElement NewPassword { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#ConfirmPasswordConfirm")]
        private IWebElement ConfirmNewPassword { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#resetPasswordModal-Button")]
        private IWebElement SavePassword { get; set; }
        //Access Rights
        [FindsBy(How = How.CssSelector, Using = "#user-roles-section > h2")]
        private IWebElement AccessRightsHeading { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#user-roles-section > div > div > div:nth-child(4) > div.col-sm-2.margin-top15 > label")]
        private IWebElement FLU010 { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#user-roles-section > div > div > div:nth-child(4) > div.role-list-main > div.col-sm-10.margin-top15 > div.col-sm-3 > label")]
        private IWebElement Admin { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#user-roles-section > div > div > div:nth-child(4) > div.role-list-main > div:nth-child(4) > div.col-sm-9.margin-top15.no-padding > div.col-sm-10.center")]
        private IWebElement ShowAccessRights { get; set; }

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

        [FindsBy(How = How.CssSelector, Using = "#user-roles-section > div > div > div:nth-child(6) > div.col-sm-2.margin-top15 > label")]
        private IWebElement ChildAccFLU012 { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#user-roles-section > div > div > div:nth-child(7) > div.col-sm-2.margin-top15 > label")]
        private IWebElement ChildAcc1PT010 { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#user-roles-section > div > div > div:nth-child(8) > div.col-sm-2.margin-top15 > label")]
        private IWebElement ChildAccFLU111 { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#user-roles-section > div > div > div:nth-child(9) > div.col-sm-2.margin-top15 > label")]
        private IWebElement ChildAccEBA010 { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#user-roles-section > div > div > div:nth-child(10) > div.col-sm-2.margin-top15 > label")]
        private IWebElement ChildAccFLU999 { get; set; }

        //Authentication Preference

        [FindsBy(How = How.CssSelector, Using = "#user-authentication-modes")]
        private IWebElement AuthenticationPreference { get; set; }


        [FindsBy(How = How.CssSelector, Using = "#TwoFactor > div.text-center.optionalOptions > div > div > div.auth_button.pointer.active > a > span")]
        private IWebElement SmsAuthentication { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#TwoFactor > div.text-center.optionalOptions > div > div > div.auth_button.pointer.active > a > span")]
        private IWebElement MobileAuthentication { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#TwoFactor > div.text-center.optionalOptions > div > div > div.auth_button.pointer.active > a > span")]
        private IWebElement EmailAuthentication { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#Code")]
        private IWebElement Codefield { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#form0 > input.btn.button-action.button-action-main")]
        private IWebElement SubmitCode { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#form0 > div.form-group.col-xs-12.nopadding > a")]
        public IWebElement ResendCode { get; set; }


        //sms 

        [FindsBy(How = How.CssSelector, Using = "#setupOK1")]
        private IWebElement SmsSetup { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#PhoneNumber")]
        private IWebElement SmsSetupPhoneNumber { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#PhoneNumber")]
        private IWebElement SmsSetupBtn { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#user-authentication-modes > div > div.authMethod.smsAuth > div:nth-child(4) > a")]
        private IWebElement SmsRedoSetup { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#user-authentication-modes > div > div.optionalOptions > div > div:nth-child(1) > div.authDesc.active > a > strong")]
        private IWebElement SmsSetupReadMore { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#user-authentication-modes > div > div.authInfo > i")]
        private IWebElement ReadMoreCloseBtn { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#PhoneNumber")]
        private IWebElement SmsRedoSetupPhoneNumber { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#SetupForm1 > div > label")]
        private IWebElement SmsRedoSetupPhoneIsLandline { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#SetupForm1 > div > label")]
        private IWebElement SmsRedoSetupBtn { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#SetupForm1 > input.resendCodeBtn.btn.button-action-main.simple-control.margin-top10.w-100")]
        private IWebElement SmsRedoResendBtn { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#form4")]
        private IWebElement SmsRedoSetupCode { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#form4 > input.btn.button-action-main.simple-control.margin-top10.w-100")]
        private IWebElement SmsRedoSetupConfirmBtn { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#user-authentication-modes > div > div.authMethod.smsAuth > i")]
        private IWebElement SmsRedoSetupCloseBtn { get; set; }

        //mobile authenticator
        [FindsBy(How = How.CssSelector, Using = "#user-authentication-modes > div > div.optionalOptions > div > div:nth-child(3) > div.auth_button.pointer")]

        private IWebElement MobileSetup { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#user-authentication-modes > div > div.authMethod.totpAuth > div:nth-child(4) > a")]
        private IWebElement MobileRedoSetup { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#user-authentication-modes > div > div.optionalOptions > div > div:nth-child(2) > div.authDesc > a > strong")]
        private IWebElement MobileSetupReadMore { get; set; }


        [FindsBy(How = How.CssSelector, Using = "#user-authentication-modes > div > div.authMethod.totpAuth > div.TOTPHolder > div > div.TOTPsetup.col-sm-3.text-center > input")]
        private IWebElement MobileReloadQrCode { get; set; }


        [FindsBy(How = How.CssSelector, Using = "#Code")]
        private IWebElement MobileRedoSetupCode { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#form0 > input.btn.button-action-main.simple-control.margin-top10.w-100")]
        private IWebElement MobileRedoSetupConfirmBtn { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#user-authentication-modes > div > div.authMethod.totpAuth > i")]
        private IWebElement MobileRedoSetupCloseBtn { get; set; }

        //Email 
        [FindsBy(How = How.CssSelector, Using = "#user-authentication-modes > div > div.optionalOptions > div > div:nth-child(1) > div.auth_button.pointer.active")]
        private IWebElement EmailSetup { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#EmailAddress2FA")]
        private IWebElement SetupEmailAddress { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#SetupForm2 > input.sendCodeBtn.btn.button-action-main.simple-control.margin-top10.w-100")]
        private IWebElement SetupBtn { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#user-authentication-modes > div > div.authMethod.emailAuth > div:nth-child(4) > a")]
        private IWebElement EmailRedoSetup { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#user-authentication-modes > div > div.optionalOptions > div > div:nth-child(3) > div.authDesc.active > a > strong")]
        private IWebElement EmailSetupReadMore { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#EmailAddress2FA")]
        private IWebElement EmailRedoSetupEmailAddress { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#SetupForm2 > input.sendCodeBtn.btn.button-action-main.simple-control.margin-top10.w-100")]
        private IWebElement EmailRedoSetupBtn { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#SetupForm2 > input.resendCodeBtn.btn.button-action-main.simple-control.margin-top10.w-100")]
        private IWebElement EmailRedoResendBtn { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#Code")]
        private IWebElement EmailRedoSetupCode { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#form2 > input.btn.button-action-main.simple-control.margin-top10.w-100")]
        private IWebElement EmailRedoSetupConfirmBtn { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#form2 > input.btn.button-action-main.simple-control.margin-top10.w-100")]
        private IWebElement EmailRedoSetupCloseBtn { get; set; }

        //Login activity
        [FindsBy(How = How.CssSelector, Using = "#login-activity-grid > div.k-grid-header > div > table > thead > tr:nth-child(1)")]
        private IWebElement Date { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#login-activity-grid > div.k-grid-header > div > table > thead > tr:nth-child(2)")]
        private IWebElement Success { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#login-activity-grid > div.k-grid-header > div > table > thead > tr:nth-child(3)")]
        private IWebElement IpAddress { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#login-activity-grid > div.k-grid-header > div > table > thead > tr:nth-child(4)")]
        private IWebElement Message { get; set; }

        //delete

        [FindsBy(How = How.CssSelector, Using = "#user-delete-button")]
        private IWebElement Delete { get; set; }

        //Account Security Settings page

        [FindsBy(How = How.CssSelector, Using = "body > div.wrap.layout > div.body > div.body-outer.col-xs-9.col-sm-9.col-md-9.col-lg-10 > div.body-inner > div:nth-child(7) > a")]
        private IWebElement AddCreateAGroup { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#Name")]
        private IWebElement GroupName { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#form24 > div:nth-child(2) > div > input")]
        private IWebElement ConfirmCreateGroup { get; set; }

        [FindsBy(How = How.CssSelector, Using = "body > div.wrap.layout > div.body > div.body-outer.col-xs-9.col-sm-9.col-md-9.col-lg-10 > div.body-inner > div.security-management.default-bootstrap > div.security-group-item-holder.SecurityGroupId4236Parent.clearfix > div > div.security-group-item > div > div.col-sm-4 > a")]
        private IWebElement ViewUsers { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#user-management > i")]
        private IWebElement ViewUsersCloseBtn { get; set; }

        [FindsBy(How = How.CssSelector, Using = "body > div.wrap.layout > div.body > div.body-outer.col-xs-9.col-sm-9.col-md-9.col-lg-10 > div.body-inner > div.security-management.default-bootstrap > div.security-group-item-holder.SecurityGroupId4236Parent.clearfix > div > div.security-group-item > div > div.col-sm-3.text-right > a:nth-child(1)")]
        private IWebElement EditSecurity { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#setupOK2")]
        private IWebElement MobileEnable { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#setupOK2")]
        private IWebElement SMSEnabled { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#setupOK2")]
        private IWebElement EmailEnabled { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#RequestSearchValue")]
        private IWebElement ConfirmAuthenticationSelection { get; set; }

        [FindsBy(How = How.CssSelector, Using = "body > div.wrap.layout > div.body > div.body-outer.col-xs-9.col-sm-9.col-md-9.col-lg-10 > div.body-inner > div.security-management.default-bootstrap > div.security-group-item-holder.SecurityGroupId4236Parent.clearfix > div > div.security-panel-holder.box-shadow.panels.clearfix.border-box > i")]
        private IWebElement TwoFactorCloseBtn { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#form2 > div > div > label")]
        private IWebElement IPAuthorisationEnabled { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#NewIpAddress")]
        private IWebElement NewIPRange { get; set; }

        public void PickIpRangeDropdown(string option)
        {
            _driver.FindElement(By.CssSelector($"#NewIpRange option[value='{option}']"), 30).Click();
        }

        [FindsBy(How = How.CssSelector, Using = "#form3 > div:nth-child(4) > div > input")]
        private IWebElement SaveIp { get; set; }

        [FindsBy(How = How.CssSelector, Using = "body > div.wrap.layout > div.body > div.body-outer.col-xs-9.col-sm-9.col-md-9.col-lg-10 > div.body-inner > div.security-management.default-bootstrap > div.security-group-item-holder.SecurityGroupId4236Parent.clearfix > div > div.security-panel-holder.box-shadow.panels.clearfix.border-box > div:nth-child(4) > a")]
        private IWebElement ConfirmIPSelection { get; set; }

        [FindsBy(How = How.CssSelector, Using = "body > div.wrap.layout > div.body > div.body-outer.col-xs-9.col-sm-9.col-md-9.col-lg-10 > div.body-inner > div.security-management.default-bootstrap > div.security-group-item-holder.SecurityGroupId4236Parent.clearfix > div > div.security-group-item > div > div.col-sm-3.text-right > a:nth-child(2)")]
        private IWebElement Rename { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#Name")]
        private IWebElement NewGroupName { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#form1 > div.form-group.col-sm-3.simple-control > input")]
        private IWebElement SaveNewGroupName { get; set; }

        [FindsBy(How = How.CssSelector, Using = "body > div.wrap.layout > div.body > div.body-outer.col-xs-9.col-sm-9.col-md-9.col-lg-10 > div.body-inner > div.security-management.default-bootstrap > div.security-group-item-holder.SecurityGroupId4236Parent.clearfix > div > div.security-group-item > div > div.col-sm-3.text-right > a.btn.btn-danger-outline.button-option-main-red")]
        private IWebElement DeleteGroup { get; set; }


        public void SwicthAccountDropdown(string option)
        {
            _driver.FindElement(By.CssSelector($"#header-accounts-dropdown option[value='{option}']"), 30).Click();
        }
        public void LoginAsAdmin()
        {
            AccountCode.ClickAndSendKeys("FLU010");
            Email.ClickAndSendKeys("kemiwilloughby@fluidone.com");
            Password.ClickAndSendKeys("Secure123!");
            LoginBtn.Click();
        }

        public void Login(string accountCode, string email, string password)
        {
            AccountCode.ClickAndSendKeys(accountCode);
            Email.ClickAndSendKeys(email);
            Password.ClickAndSendKeys(password);
            LoginBtn.Click();
        }

        public void ThreeInvalidPasswords(string accountCode, string email)
        {
            AccountCode.ClickAndSendKeys(accountCode);
            Email.ClickAndSendKeys(email);
            Password.ClickAndSendKeys("dhfjvdck");
            LoginBtn.Click();
            Password.ClickAndSendKeys("ijmkn");
            LoginBtn.Click();
            Password.ClickAndSendKeys("grfbf");
            LoginBtn.Click();
        }

        public void CreateNewUser(string accCode, string securityGrp, string firstName, string lastName, string email, string phoneNumber)
        {
            CreateAUser.Click();
            AccountCodeDropdown(accCode);
            SecurityGroupDropdown(securityGrp);
            FirstName.ClickAndSendKeys(firstName);
            LastName.ClickAndSendKeys(lastName);
            Email.ClickAndSendKeys(email);
            PhoneNumber.ClickAndSendKeys(phoneNumber);
            ShowMoreAccessRights.Click();
            Billing.Click();
            EoD_Order.Click();
            Provisioning_Cease.Click();
            Provisioning_Modify.Click();
            Type_Wholesale.Click();
            CreateUser.Click();
     
        }

        public void ValidSmsVerification(string accountCode, string email)
        {
            SmsAuthentication.Click();

            GetVerificationCode(accountCode, email);
        }

        public void InvalidSmsVerification()
        {
            SmsAuthentication.Click();
            Codefield.ClickAndSendKeys("UJKD874F");
            SubmitCode.Click();
        }

        public void InvalidSmsVerificationX3()
        {
            SmsAuthentication.Click();
            Codefield.ClickAndSendKeys("UJKD874F");
            SubmitCode.Click();
            Codefield.Clear();
            Codefield.ClickAndSendKeys("UJKD875E");
            SubmitCode.Click();
            Codefield.Clear();
            SubmitCode.ClickAndSendKeys("UJKD966Q");
            ResendCode.Click();
        }

        public void RedoSmsSetup(string accountCode, string email)
        {
            AuthenticationPreference.Click();
            SmsSetup.Click();
            SmsRedoSetup.Click();
            SmsRedoSetupPhoneNumber.ClickAndSendKeys("07965223651");
            SmsRedoSetupBtn.Click();
            RedoSetupGetVerificationCode(accountCode, email);
        }


        public void ValidMobileVerification(string accountCode, string email)
        {
            MobileAuthentication.Click();

            GetVerificationCode(accountCode, email);
        }

        public void InvalidMobileVerification()
        {
            MobileAuthentication.Click();
            Codefield.ClickAndSendKeys("UJKD874F");
            SubmitCode.Click();
        }

        public void InvalidMobileVerificationX3()
        {
            MobileAuthentication.Click();
            Codefield.ClickAndSendKeys("UJKD874F");
            SubmitCode.Click();
            Codefield.Clear();
            Codefield.ClickAndSendKeys("UJKD875E");
            SubmitCode.Click();
            Codefield.Clear();
            SubmitCode.ClickAndSendKeys("UJKD966Q");
            ResendCode.Click();
        }

        public void RedoMobileSetup(string accountCode, string email)
        {
            AuthenticationPreference.Click();
            MobileSetup.Click();
            MobileRedoSetup.Click();
            
            RedoSetupGetVerificationCode(accountCode, email);
        }

        public void ValidEmailVerification(string accountCode, string email)
        {
            MobileAuthentication.Click();

            GetVerificationCode(accountCode, email);
        }

        public void InvalidEmailVerification()
        {
            EmailAuthentication.Click();
            Codefield.ClickAndSendKeys("UJKD874F");
            SubmitCode.Click();
        }

        public void InvalidEmailVerificationX3()
        {
            EmailAuthentication.Click();
            Codefield.ClickAndSendKeys("UJKD874F");
            SubmitCode.Click();
            Codefield.Clear();
            Codefield.ClickAndSendKeys("UJKD875E");
            SubmitCode.Click();
            Codefield.Clear();
            SubmitCode.ClickAndSendKeys("UJKD966Q");
            ResendCode.Click();
        }

        public void RedoEmailSetup(string accountCode, string email)
        {
            AuthenticationPreference.Click();
            EmailSetup.Click();
            EmailRedoSetup.Click();
            EmailRedoSetupEmailAddress.ClickAndSendKeys("kemiwilloughby@fluidata.com");
            EmailRedoSetupBtn.Click();
            RedoSetupGetVerificationCode(accountCode, email);
        }


        public void AdminEmailSetup ()
        {
            AuthenticationPreference.Click();
            EmailSetup.Click();
            SetupEmailAddress.ClickAndSendKeys("email@2fa-test.com");
            SetupBtn.Click();
            ValidEmailVerification("FLU010", "email@2fa-test.com");
        }

        public void AdminSmsSetup()
        {
            AuthenticationPreference.Click();
            SmsSetup.Click();
            SmsSetupPhoneNumber.ClickAndSendKeys("07447477183");
            SmsSetupBtn.Click();
            ValidSmsVerification("FLU010", "kemiwilloughby@fluidone.com");
        }

        public void UserSmsEmailSetup()
        {
            AuthenticationPreference.Click();
            SmsSetup.Click();
            SmsSetupPhoneNumber.ClickAndSendKeys("07447477183");
            SmsSetupBtn.Click();
            ValidSmsVerification("FLU010", "kemiwilloughby@fluidone.com");
            EmailSetup.Click();
            SetupEmailAddress.ClickAndSendKeys("email@2fa-test.com");
            SetupBtn.Click();
            ValidEmailVerification("FLU010", "email@2fa-test.com");
        }

        public void SwitchAccount()
        {
          
            SwicthAccountDropdown("");
        }

        public void ChangePassword()
        {
            ChangeYourPassword.Click();
            CurrentPassword.ClickAndSendKeys("Test123!");
            NewPassword.ClickAndSendKeys("Test123");
            ConfirmNewPassword.ClickAndSendKeys("Test123");
            SavePassword.Click();

        }
        public void DateAscending()
        {
            Date.Click();
        }
        public void DateDescending()
        {
            Date.Click();
        }

        public void SuccessAscending()
        {
            Success.Click();
        }
        public void SuccessDescending()
        {
            Success.Click();
        }

        public void IPAddressAscending()
        {
            IpAddress.Click();
        }
        public void IPAddressDescending()
        {
            IpAddress.Click();
        }

        public void MessageAscending()
        {
            Message.Click();
        }
        public void MessageDescending()
        {
            Message.Click();
        }


        public void GetVerificationCode(string accountCode, string email)
        {
            using (PortalEntities context = new PortalEntities())

            {

                int userId = context.UserAccounts

                     .First(o => o.Email == email && o.Account.AccountCode == accountCode)
                     .UserAccountID;

                string SMScode = "";
                IQueryable<Entities.SMSCode> smscodes = context.SMSCodes; //A query of type SMSCode to send to the DB
                smscodes = smscodes.Where(x => x.UserAccountID == userId); //Checks in the DB where UserAccountID = 5693
                smscodes = smscodes.OrderByDescending(x => x.Created);
                Entities.SMSCode newCode = smscodes.FirstOrDefault(); // Gets the First or Default item in the SMSCode object
                SMScode = newCode.Code.ToString(); // Get the int in the Column Code and express it as a string

                try
                {
                    _driver.FindElement(By.CssSelector("#Code")).ClickAndSendKeys(SMScode);
                    _driver.FindElement(By.CssSelector("#form0 > input.btn.button-action.button-action-main")).Click();
                }
                catch { }
            }
        }

            public void RedoSetupGetVerificationCode(string accountCode, string email)
            {
                using (PortalEntities context = new PortalEntities())

                {

                    int userId = context.UserAccounts

                         .First(o => o.Email == email && o.Account.AccountCode == accountCode)
                         .UserAccountID;

                    string SMScode = "";
                    IQueryable<Entities.SMSCode> smscodes = context.SMSCodes; //A query of type SMSCode to send to the DB
                    smscodes = smscodes.Where(x => x.UserAccountID == userId); //Checks in the DB where UserAccountID = 5693
                    smscodes = smscodes.OrderByDescending(x => x.Created);
                    Entities.SMSCode newCode = smscodes.FirstOrDefault(); // Gets the First or Default item in the SMSCode object
                    SMScode = newCode.Code.ToString(); // Get the int in the Column Code and express it as a string

                    try
                    {
                        _driver.FindElement(By.CssSelector("#Code")).ClickAndSendKeys(SMScode);
                        _driver.FindElement(By.CssSelector("#form4 > input.btn.button-action-main.simple-control.margin-top10.w-100")).Click();
                    }
                    catch { }
                }
            }

    }
}

