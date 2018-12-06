using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;


namespace Task.Hudl
{
    /// <summary>
    /// A PageObject for Hudl Login page
    /// </summary>
    public class LoginPage
    {
        private IWebDriver _driver;

        [FindsBy(How = How.CssSelector, Using = "#nav > ul > li:nth-child(6) > a")]
        private IWebElement HomepageLoginBtn { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#email")]
        private IWebElement TxtEmail { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#password")]
        private IWebElement TxtPassword { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#logIn")]
        private IWebElement LoginBtn { get; set; }

       

        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
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
            LoginBtn.Click();
        }

       
       public void SuccessfulLogin(string email, string password)
        {
            HomepageLoginBtn.Click();
            PopulateEmail(email);
            PopulatePassword(password);
            ClickLogin();

        }
    

        public void UnsuccessfulLoginIncorrectEmail(string password)
        {
            HomepageLoginBtn.Click();
            PopulateEmail("incorret@email.com");
            PopulatePassword(password);
            ClickLogin();

        }
        public void UnsuccessfulLoginNoInfo()
        {
            HomepageLoginBtn.Click();
            ClickLogin();

        }
        public void UnsuccessfulLoginIncorrectPassword(string email)
        {
            HomepageLoginBtn.Click();
            PopulateEmail(email);
            PopulatePassword("incorrect");
            ClickLogin();

        }
        public void IncorrectPasswordFiveTimes(string email)
        {
            HomepageLoginBtn.Click();
            PopulateEmail(email);
            PopulatePassword("incorrect");
            ClickLogin();
            PopulatePassword("incorrect2");
            ClickLogin();
            PopulatePassword("incorrect3");
            ClickLogin();
            PopulatePassword("incorrect4");
            ClickLogin();
            PopulatePassword("incorrect5");
            ClickLogin();
        }
    }
}
