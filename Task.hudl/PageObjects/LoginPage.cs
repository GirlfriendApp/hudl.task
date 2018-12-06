using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;
using FluidOne.ClientTesting.Dash.Entities;

namespace FluidOne.ClientTesting.Dash
{
    /// <summary>
    /// A PageObject for FluidOne Login page
    /// </summary>
    public class LoginPage
    {
        private IWebDriver _driver;

        [FindsBy(How = How.Id, Using = "Account")]
        private IWebElement TxtAccount { get; set; }

        [FindsBy(How = How.Id, Using = "Email")]
        private IWebElement TxtEmail { get; set; }

        [FindsBy(How = How.Id, Using = "Password")]
        private IWebElement TxtPassword { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input.btn.button-action-secondary")]
        private IWebElement BtnLogin { get; set; }

        [FindsBy(How = How.Id, Using = "SmsCode")]
        private IWebElement SmsCode { get; set; }

        [FindsBy(How = How.Id, Using = "nextButton")]
        private IWebElement SmsNextButton { get; set; }

        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        public void PopulateAccount(string account)
        {
            TxtAccount.Clear();
            TxtAccount.SendKeys(account);
        }

        public void PopulateEmail(string username)
        {
            TxtEmail.SendKeys(username);
            
        }

        public void PopulatePassword(string password)
        {
            TxtPassword.SendKeys(password);
        }

        public void ClickLogin()
        {
            BtnLogin.Click();            
        }

        public void HandleTwoFactor(string email, string accountCode)
        {
            try
            {
                if (SmsCode.Displayed)
                {
                    using (PortalEntities context = new PortalEntities())
                    {
                        int userId = context.UserAccounts
                            .First(o => o.Email == email && o.Account.AccountCode == accountCode)
                            .UserAccountID;

                        var code = context.SMSCodes.OrderByDescending(x => x.Created).FirstOrDefault(x => x.UserAccountID == userId)?.Code;

                        SmsCode.ClickAndSendKeys(code);
                        SmsNextButton.Click();
                    }
                }
            }
            catch(Exception e)
            {
                var x = "";// didn't have 2Factor
            }
        }

        public void Login(string account, string email, string password)
        {
            PopulateAccount(account);
            PopulateEmail(email);
            PopulatePassword(password);
            ClickLogin();
            HandleTwoFactor(email, account);
        }
    }
}
