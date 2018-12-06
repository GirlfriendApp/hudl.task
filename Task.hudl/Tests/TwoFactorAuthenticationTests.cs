using NUnit.Framework;
using OpenQA.Selenium;
using System.Linq;
using NUnit.Framework.Interfaces;
using FluidOne.ClientTesting.Dash.Tests.BaseTests;
using FluidOne.ClientTesting.Dash.PageObjects;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text;
using FluidOne.ClientTesting.Dash;
using System.Threading;


namespace FluidOne.ClientTesting.Dash.Tests.TwoFactorBaseTests
{
    [TestFixture(typeof(Firefox))]
    [TestFixture(typeof(InternetExplorer))]
    [TestFixture(typeof(Chrome))]
    [TestFixture(typeof(Edge))]

    public class TwoFactorAuthenticationPages<T> : TwoFactorBaseTest<T> where T : IWebDriver, new()
    {

        [SetUp]
        public void setup()
        {
            var login = new TwoFactorAuthenticationPages(driver);

            driver.Navigate().GoToUrl(baseURL);
            driver.FindElement(By.CssSelector("body > div.cookieSection > div > button")).Click();
        }



        [Test]
        public void Login_Test_1()
        {
            var login = new TwoFactorAuthenticationPages(driver);
            
            
           
        }

        [Test]
        public void TwoFactorAuthentication_Test_1()
        {
            var twofactorauthentication = new TwoFactorAuthenticationPages(driver);
            twofactorauthentication.ThreeInvalidPasswords("", "");


            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));

            
        }

        [Test]
        public void TwoFactorAuthentication_Test_2()
        {
            var twofactorauthentication = new TwoFactorAuthenticationPages(driver);
            twofactorauthentication.ThreeInvalidPasswords("", "");


            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));


        }

        [Test]
        public void TwoFactorAuthentication_Test_5()
        {
            var twofactorauthentication = new TwoFactorAuthenticationPages(driver);
            twofactorauthentication.ForgotPassword.Click();
            Assert.AreEqual("Forgot Password", driver.FindElement(By.CssSelector("#forgotPasswordForm > div > h1")));
            twofactorauthentication.AccountField.ClickAndSendKeys("FLU010");
            twofactorauthentication.EmailField.ClickAndSendKeys("Kemiwilloughby@fluidata.com");
            twofactorauthentication.SubmitBtn.Click();
            Assert.AreEqual("User doesn't exist", driver.FindElement(By.CssSelector("#forgotPasswordForm > div > div.validation-summary-errors.text-danger > ul > li")));
        }

        [Test]
        public void TwoFactorAuthentication_Test_6()
        {
            var twofactorauthentication = new TwoFactorAuthenticationPages(driver);
            twofactorauthentication.ForgotPassword.Click();
            Assert.AreEqual("Forgot Password", driver.FindElement(By.CssSelector("#forgotPasswordForm > div > h1")));
            twofactorauthentication.AccountField.ClickAndSendKeys("FLU010");
            twofactorauthentication.EmailField.ClickAndSendKeys("Kemiwilloughby@fluidone.com");
            twofactorauthentication.SubmitBtn.Click();

            Assert.AreEqual("User doesn't exist", driver.FindElement(By.CssSelector("#forgotPasswordForm > div > div.validation-summary-errors.text-danger > ul > li")));
        }

        [Test]
        public void TwoFactorAuthentication_Test_7()
        {
            var twofactorauthentication = new TwoFactorAuthenticationPages(driver);
            twofactorauthentication.ForgotPassword.Click();
            Assert.AreEqual("Forgot Password", driver.FindElement(By.CssSelector("#forgotPasswordForm > div > h1")));
            twofactorauthentication.AccountField.ClickAndSendKeys("FLU010");
            twofactorauthentication.EmailField.ClickAndSendKeys("Kemiwilloughby@fluidone.com");
            twofactorauthentication.SubmitBtn.Click();
            Assert.AreEqual("User doesn't exist", driver.FindElement(By.CssSelector("#forgotPasswordForm > div > div.validation-summary-errors.text-danger > ul > li")));

        }

        /*[Test]
        public void TwoFactorAuthentication_Test_8()
        {
            var twofactorauthentication = new TwoFactorAuthenticationPages(driver);
            twofactorauthentication.ForgotPassword.Click();
            Assert.AreEqual("Forgot Password", driver.FindElement(By.CssSelector("#forgotPasswordForm > div > h1")));
            twofactorauthentication.AccountField.ClickAndSendKeys("FLU010");
            twofactorauthentication.EmailField.ClickAndSendKeys("Kemiwilloughby@fluidone.com");
            twofactorauthentication.SubmitBtn.Click();
            Assert.AreEqual("User doesn't exist", driver.FindElement(By.CssSelector("#forgotPasswordForm > div > div.validation-summary-errors.text-danger > ul > li")));

        }*/

        [Test]
        public void TwoFactorAuthentication_Test_9()
        {
            var twofactorauthentication = new TwoFactorAuthenticationPages(driver);
            twofactorauthentication.ForgotPassword.Click();
            Assert.AreEqual("Forgot Password", driver.FindElement(By.CssSelector("#forgotPasswordForm > div > h1")));
            twofactorauthentication.AccountField.ClickAndSendKeys("FLU010");
            twofactorauthentication.EmailField.ClickAndSendKeys("Kemiwilloughby@fluidone.com");
            twofactorauthentication.SubmitBtn.Click();
            Assert.AreEqual("User doesn't exist", driver.FindElement(By.CssSelector("#forgotPasswordForm > div > div.validation-summary-errors.text-danger > ul > li")));

        }

        [Test]
        public void TwoFactorAuthentication_Test_10()
        {
            var twofactorauthentication = new TwoFactorAuthenticationPages(driver);
            twofactorauthentication.LoginAsAdmin();
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            twofactorauthentication.CreateNewUser("", "", "", "", "", "");
            driver.FindElement(By.CssSelector("body > div.wrap.layout > div.header.clearfix > div.pull-right.header-options-holder.active > div.header-options > ul > li:nth-child(2)")).Click();
        }

        [Test]
        public void TwoFactorAuthentication_Test_11()
        {
            var twofactorauthentication = new TwoFactorAuthenticationPages(driver);
            twofactorauthentication.Login("", "", "");
            twofactorauthentication.ValidSmsVerification("", "");
            Assert.AreEqual("Welcome to your FluidOne Dashboard", driver.FindElement(By.CssSelector("body > div.wrap.layout > div.body > div.body-outer.col-xs-9.col-sm-9.col-md-9.col-lg-10 > div.body-inner > div.home > div:nth-child(1) > div.col-xs-8.col-sm-8.col-md-8.col-lg-8 > h1")));
        }

        [Test]
        public void TwoFactorAuthentication_Test_12()
        {
            var twofactorauthentication = new TwoFactorAuthenticationPages(driver);
            twofactorauthentication.Login("", "", "");
            twofactorauthentication.InvalidSmsVerification();
            Assert.AreEqual("No matching code found", driver.FindElement(By.CssSelector("#verifyForm > div.setupError.col-xs-12.margin-top15.block.text-danger > div:nth-child(1)")));
        }

        [Test]
        public void TwoFactorAuthentication_Test_13()
        {
            var twofactorauthentication = new TwoFactorAuthenticationPages(driver);
            twofactorauthentication.Login("", "", "");
            twofactorauthentication.InvalidSmsVerificationX3();
            Assert.AreEqual("Too many failed attempts, your account is now disabled. Please contact your Administrator to enable your account", driver.FindElement(By.CssSelector("#verifyForm > div.setupError.col-xs-12.margin-top15.block.text-danger > div:nth-child(2)")));
        }


        [Test]
        public void TwoFactorAuthentication_Test_14()
        {
            var twofactorauthentication = new TwoFactorAuthenticationPages(driver);
            twofactorauthentication.Login("", "", "");
            
            Assert.AreEqual("Your account is locked. Contact your administrator", driver.FindElement(By.CssSelector("body > div.flex-middle > div > h2")));
        }

        [Test]
        public void TwoFactorAuthentication_Test_15()
        {
            var twofactorauthentication = new TwoFactorAuthenticationPages(driver);
            twofactorauthentication.Login("", "", "");
            Thread.Sleep(360000);
            twofactorauthentication.ValidSmsVerification("", "");
            Assert.AreEqual("Code has expired", driver.FindElement(By.CssSelector("#verifyForm > div.setupError.col-xs-12.margin-top15.block.text-danger > div")));
        }

        [Test]
        public void TwoFactorAuthentication_Test_16()
        {
            var twofactorauthentication = new TwoFactorAuthenticationPages(driver);
            twofactorauthentication.Login("", "", "");
            Thread.Sleep(360000);
            twofactorauthentication.ResendCode.Click();
            twofactorauthentication.ValidSmsVerification("", "");

        }

        [Test]
        public void TwoFactorAuthentication_Test_17()
        {
            var twofactorauthentication = new TwoFactorAuthenticationPages(driver);
            twofactorauthentication.Login("", "", "");
            driver.Navigate().GoToUrl(baseURL + "/UserSettings");
            twofactorauthentication.RedoSmsSetup("", "");
            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));
        }

       /* [Test]
        public void TwoFactorAuthentication_Test_19()
        {
            var twofactorauthentication = new TwoFactorAuthenticationPages(driver);
            twofactorauthentication.Login("", "", "");
            twofactorauthentication.ValidMobileVerification("", "");
            Assert.AreEqual("Welcome to your FluidOne Dashboard", driver.FindElement(By.CssSelector("body > div.wrap.layout > div.body > div.body-outer.col-xs-9.col-sm-9.col-md-9.col-lg-10 > div.body-inner > div.home > div:nth-child(1) > div.col-xs-8.col-sm-8.col-md-8.col-lg-8 > h1")));
        }*/

        [Test]
        public void TwoFactorAuthentication_Test_20()
        {
            var twofactorauthentication = new TwoFactorAuthenticationPages(driver);
            twofactorauthentication.Login("", "", "");
            twofactorauthentication.InvalidMobileVerification();
            Assert.AreEqual("No matching code found", driver.FindElement(By.CssSelector("#verifyForm > div.setupError.col-xs-12.margin-top15.block.text-danger > div:nth-child(1)")));
        }

        [Test]
        public void TwoFactorAuthentication_Test_21()
        {
            var twofactorauthentication = new TwoFactorAuthenticationPages(driver);
            twofactorauthentication.Login("", "", "");
            twofactorauthentication.InvalidMobileVerificationX3();
            Assert.AreEqual("Too many failed attempts, your account is now disabled. Please contact your Administrator to enable your account", driver.FindElement(By.CssSelector("#verifyForm > div.setupError.col-xs-12.margin-top15.block.text-danger > div:nth-child(2)")));
        }


   

        [Test]
        public void TwoFactorAuthentication_Test_22()
        {
            var twofactorauthentication = new TwoFactorAuthenticationPages(driver);
            twofactorauthentication.Login("", "", "");
            Thread.Sleep(360000);
            twofactorauthentication.ValidMobileVerification("", "");
            Assert.AreEqual("Code has expired", driver.FindElement(By.CssSelector("#verifyForm > div.setupError.col-xs-12.margin-top15.block.text-danger > div")));
        }

        /*
        [Test]
        public void TwoFactorAuthentication_Test_23()
        {
            var twofactorauthentication = new TwoFactorAuthenticationPages(driver);
            twofactorauthentication.Login("", "", "");
            Thread.Sleep(360000);
            twofactorauthentication.ResendCode.Click();
            twofactorauthentication.ValidMobileVerification("", "");

        }

        [Test]
        public void TwoFactorAuthentication_Test_24()
        {
            var twofactorauthentication = new TwoFactorAuthenticationPages(driver);
            twofactorauthentication.Login("", "", "");
            driver.Navigate().GoToUrl(baseURL + "/UserSettings");
            twofactorauthentication.RedoMobileSetup("", "");
            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));
        }*/

        [Test]
        public void TwoFactorAuthentication_Test_26()
        {
            var twofactorauthentication = new TwoFactorAuthenticationPages(driver);
            twofactorauthentication.Login("", "", "");
            twofactorauthentication.ValidEmailVerification("", "");
            Assert.AreEqual("Welcome to your FluidOne Dashboard", driver.FindElement(By.CssSelector("body > div.wrap.layout > div.body > div.body-outer.col-xs-9.col-sm-9.col-md-9.col-lg-10 > div.body-inner > div.home > div:nth-child(1) > div.col-xs-8.col-sm-8.col-md-8.col-lg-8 > h1")));
        }

        [Test]
        public void TwoFactorAuthentication_Test_27()
        {
            var twofactorauthentication = new TwoFactorAuthenticationPages(driver);
            twofactorauthentication.Login("", "", "");
            twofactorauthentication.InvalidEmailVerification();
            Assert.AreEqual("No matching code found", driver.FindElement(By.CssSelector("#verifyForm > div.setupError.col-xs-12.margin-top15.block.text-danger > div:nth-child(1)")));
        }

        [Test]
        public void TwoFactorAuthentication_Test_28()
        {
            var twofactorauthentication = new TwoFactorAuthenticationPages(driver);
            twofactorauthentication.Login("", "", "");
            twofactorauthentication.InvalidEmailVerificationX3();
            Assert.AreEqual("Too many failed attempts, your account is now disabled. Please contact your Administrator to enable your account", driver.FindElement(By.CssSelector("#verifyForm > div.setupError.col-xs-12.margin-top15.block.text-danger > div:nth-child(2)")));
        }




        [Test]
        public void TwoFactorAuthentication_Test_29()
        {
            var twofactorauthentication = new TwoFactorAuthenticationPages(driver);
            twofactorauthentication.Login("", "", "");
            Thread.Sleep(360000);
            twofactorauthentication.ValidEmailVerification("", "");
            Assert.AreEqual("Code has expired", driver.FindElement(By.CssSelector("#verifyForm > div.setupError.col-xs-12.margin-top15.block.text-danger > div")));
        }

        [Test]
        public void TwoFactorAuthentication_Test_30()
        {
            var twofactorauthentication = new TwoFactorAuthenticationPages(driver);
            twofactorauthentication.Login("", "", "");
            Thread.Sleep(360000);
            twofactorauthentication.ResendCode.Click();
            twofactorauthentication.ValidEmailVerification("", "");

        }

        [Test]
        public void TwoFactorAuthentication_Test_31()
        {
            var twofactorauthentication = new TwoFactorAuthenticationPages(driver);
            twofactorauthentication.Login("", "", "");
            driver.Navigate().GoToUrl(baseURL + "/UserSettings");
            twofactorauthentication.RedoEmailSetup("", "");
            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));
        }

        [Test]
        public void TwoFactorAuthentication_Test_32()
        {
            var twofactorauthentication = new TwoFactorAuthenticationPages(driver);
            twofactorauthentication.LoginAsAdmin();
            driver.Navigate().GoToUrl(baseURL + "/UserSettings");
            twofactorauthentication.AdminSmsSetup();
            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));
        }

        [Test]
        public void TwoFactorAuthentication_Test_34()
        {
            var twofactorauthentication = new TwoFactorAuthenticationPages(driver);
            twofactorauthentication.LoginAsAdmin();
            driver.Navigate().GoToUrl(baseURL + "/UserSettings");
            twofactorauthentication.AdminEmailSetup();
            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));
        }

        [Test]
        public void TwoFactorAuthentication_Test_36()
        {
            var twofactorauthentication = new TwoFactorAuthenticationPages(driver);
            twofactorauthentication.Login("", "", "");
            driver.Navigate().GoToUrl(baseURL + "/UserSettings");
            twofactorauthentication.UserSmsEmailSetup();
            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));
        }

        [Test]
        public void TwoFactorAuthentication_Test_43()
        {
            var twofactorauthentication = new TwoFactorAuthenticationPages(driver);
            twofactorauthentication.LoginAsAdmin();
            twofactorauthentication.SwitchAccount();
            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));
        }

        [Test]
        public void TwoFactorAuthentication_Test_44()
        {
            var twofactorauthentication = new TwoFactorAuthenticationPages(driver);
            twofactorauthentication.Login("", "", "");
            driver.Navigate().GoToUrl(baseURL + "/UserSettings");
            twofactorauthentication.ChangePassword();
            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));
        }


        [Test]
        public void TwoFactorAuthentication_Test_()
        {
            var twofactorauthentication = new TwoFactorAuthenticationPages(driver);

            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");

            twofactorauthentication.DateAscending();
            Assert.AreEqual("ascending", driver.FindElement(By.CssSelector("#login-activity-grid > div.k-grid-header > div > table > thead > tr:nth-child(1)")).GetAttribute("aria-sort"));
            twofactorauthentication.DateDescending();
            Assert.AreEqual("descending", driver.FindElement(By.CssSelector("#login-activity-grid > div.k-grid-header > div > table > thead > tr:nth-child(1)")).GetAttribute("aria-sort"));
        }
    }
}
