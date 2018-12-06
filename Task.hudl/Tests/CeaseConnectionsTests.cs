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


namespace FluidOne.ClientTesting.Dash.Tests.BaseTests
{
    [TestFixture(typeof(Firefox))]
    [TestFixture(typeof(InternetExplorer))]
    [TestFixture(typeof(Chrome))]
    [TestFixture(typeof(Edge))]

    public class CeaseConnectionsPage<T> : BaseTest<T> where T : IWebDriver, new()
    {

        [SetUp]
        public void setup()
        {
            var login = new LoginPage(driver);
            driver.FindElement(By.CssSelector("body > div.cookieSection > div > button")).Click();
            login.Login(accountCode, email, password);
        }

        /*
            1. Go to Admin  -> User Management
            2. Impersonate account ABZ011
            3. Go to Provisioning -> Cease Connection
            4. Click select contact
            5.Verify the contact is selected
         */
        [Test]
        public void ProvisioningCeaseConnectionTest_18()
        {

            var ceaseconnections = new CeaseConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            ceaseconnections.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/CeaseOrder");
           
            ceaseconnections.WholesaleCeaseSelectContactTest("");

            Assert.AreEqual("", driver.FindElement(By.CssSelector("#ContactNameLabel")));

        }

        /*
            1. Go to Admin  -> User Management
            2. Impersonate account ABZ011
            3. Go to Provisioning -> Cease Connection
            4. Click select contact
            5. select another contact
            6. verify the chosen contact has changed

         */
        [Test]
        public void ProvisioningCeaseConnectionTest_19()
        {

            var ceaseconnections = new CeaseConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            ceaseconnections.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/CeaseOrder");

            ceaseconnections.WholesaleCeaseSelectContactTest2("");

            Assert.AreEqual("", driver.FindElement(By.CssSelector("#ContactNameLabel")));

        }
        /*
            1. Go to Admin  -> User Management
            2. Impersonate account ABZ011
            3. Go to Provisioning -> Cease Connection
            7. Click select contact
            8. Click create contact
            9. Add user details 
            10. Click create 
            11. Verify that new contact has been added
            12. Find contact just created and click select contact 
            13. Delete the contact just created
       
         */

        [Test]
        public void ProvisioningCeaseConnectionTest_20()
        {


            var ceaseconnections = new CeaseConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            ceaseconnections.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/CeaseOrder");

            ceaseconnections.WholesaleCeaseSelectContactTest("");

            ceaseconnections.CreateNewContact("");

            Assert.AreEqual("Contact Name: Test User", driver.FindElement(By.CssSelector("#ContactNameLabel")));
            ceaseconnections.WholesaleVerifyNewContactDisplayed("");

            Assert.AreEqual("Test", driver.FindElement(By.CssSelector("#selectContact-grid > tbody > tr:nth-child(4) > td:nth-child(1)")).Text);
            Assert.AreEqual("User", driver.FindElement(By.CssSelector("#selectContact-grid > tbody > tr:nth-child(4) > td:nth-child(2)")).Text);

            Assert.AreEqual("07745612345", driver.FindElement(By.CssSelector("#selectContact-grid > tbody > tr:nth-child(4) > td:nth-child(4)")).Text);

            Assert.AreEqual("test.user@email.com", driver.FindElement(By.CssSelector("#selectContact-grid > tbody > tr:nth-child(4) > td:nth-child(5)")).Text);
            ceaseconnections.DeleteNewContact();
        }

        /*
            1. Go to Admin  -> User Management
            2. Impersonate account ABZ011
            3. Go to Provisioning -> Cease Connection
            7. Click select contact
            8. Click edit on the user just created 
            9. Edit the surname 
            10. Click submit
            11. Verify that the contact surname has been amended
         */

        [Test]
        public void ProvisioningCeaseConnectionTest_21()
        {

            var ceaseconnections = new CeaseConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            ceaseconnections.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/CeaseOrder");

            ceaseconnections.WholesaleEditContactTest("", "", "");

            Assert.AreEqual("", driver.FindElement(By.CssSelector("#ContactNameLabel")));

        }

        // TT MPF FTTC

        [Test]
        public void ProvisioningCeaseConnectionTest_22()
        {

            var ceaseconnections = new CeaseConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            ceaseconnections.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/CeaseOrder");

            ceaseconnections.WholesaleCeaseOrder("", "TT");

            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));

        }

        // TT MPF ADSL

        [Test]
        public void ProvisioningCeaseConnectionTest_23()
        {

            var ceaseconnections = new CeaseConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            ceaseconnections.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/CeaseOrder");

            ceaseconnections.WholesaleCeaseOrder("", "TT");

            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));

        }

        // TT LLU

        [Test]
        public void ProvisioningCeaseConnectionTest_24()
        {

            var ceaseconnections = new CeaseConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            ceaseconnections.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/CeaseOrder");

            ceaseconnections.WholesaleCeaseOrder("", "TT");

            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));

        }

        // TT SMPF FTTC

        [Test]
        public void ProvisioningCeaseConnectionTest_25()
        {

            var ceaseconnections = new CeaseConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            ceaseconnections.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/CeaseOrder");

            ceaseconnections.WholesaleCeaseOrder("", "TT");

            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));

        }

        // BT SMPF FTTC

        [Test]
        public void ProvisioningCeaseConnectionTest_26()
        {

            var ceaseconnections = new CeaseConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            ceaseconnections.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/CeaseOrder");

            ceaseconnections.WholesaleCeaseOrder("", "BT");

            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));

        }

        // BT SMPF ADSL

        [Test]
        public void ProvisioningCeaseConnectionTest_27()
        {

            var ceaseconnections = new CeaseConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            ceaseconnections.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/CeaseOrder");

            ceaseconnections.WholesaleCeaseOrder("", "BT");

            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));

        }


        // TT SMPF ADSL

        [Test]
        public void ProvisioningCeaseConnectionTest_28()
        {

            var ceaseconnections = new CeaseConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            ceaseconnections.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/CeaseOrder");

            ceaseconnections.WholesaleCeaseOrder("", "TT");

            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));

        }

        // BT 20CN

        [Test]
        public void ProvisioningCeaseConnectionTest_29()
        {

            var ceaseconnections = new CeaseConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            ceaseconnections.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/CeaseOrder");

            ceaseconnections.WholesaleCeaseOrder("", "BT");

            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));

        }


        // BT 21CN

        [Test]
        public void ProvisioningCeaseConnectionTest_30()
        {

            var ceaseconnections = new CeaseConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            ceaseconnections.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/CeaseOrder");

            ceaseconnections.WholesaleCeaseOrder("", "BT");

            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));

        }
















        //Direct Cease Tests

        /*
         Direct cease outside min term
         */
        [Test]
        public void Provisioning_CeaseConnection_Test_16()
        {

            var ceaseconnections = new CeaseConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            ceaseconnections.ImpersonateCOS010();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/DirectCease");
            ceaseconnections.DirectEarlyCeaseOrder("", "");

            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));
        }


        /*
          Direct cease inside min term
       */
        [Test]
        public void Provisioning_CeaseConnection_Test_17()
        {

            var ceaseconnections = new CeaseConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            ceaseconnections.ImpersonateCOS010();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/DirectCease");

            ceaseconnections.DirectCeaseOrder("", "");

            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));
        }

        /*
            1. Go to Admin  -> User Management
            2. Impersonate account ABZ011
            3. Go to Provisioning -> Cease Connection
            5. Click select contact
            6.Verify the contact is selected
        */

        [Test]
        public void Provisioning_CeaseConnection_Test_18()
        {

            var ceaseconnections = new CeaseConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            ceaseconnections.ImpersonateCOS010();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/DirectCease");

            ceaseconnections.DirectCeaseSelectContactTest("");

            Assert.AreEqual("", driver.FindElement(By.CssSelector("#ContactNameLabel")));

        }

        /*
            1. Go to Admin  -> User Management
            2. Impersonate account ABZ011
            3. Go to Provisioning -> Cease Connection
            4. Click select contact
            5. select another contact
            6. verify the chosen contact has changed
         
         */

        [Test]
        public void Provisioning_CeaseConnection_Test_19()
        {

            var ceaseconnections = new CeaseConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            ceaseconnections.ImpersonateCOS010();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/DirectCease");

            ceaseconnections.DirectCeaseSelectContactTest2("");

            Assert.AreEqual("", driver.FindElement(By.CssSelector("#ContactNameLabel")));

        }

        /*
            1. Go to Admin  -> User Management
            2. Impersonate account ABZ011
            3. Go to Provisioning -> Cease Connection
            4. Click select contact
            5. Click create contact
            6. Add user details 
            7. Click create 
            8. Verify that new contact has been added
            9. Find contact just created and click select contact 
            10. Delete the contact just created
         
         */
        [Test]
        public void Provisioning_CeaseConnection_Test_20()
        {


            var ceaseconnections = new CeaseConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            ceaseconnections.ImpersonateCOS010();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/DirectCease");

            ceaseconnections.DirectCeaseSelectContactTest("");

            ceaseconnections.DirectCreateNewContact("");

            Assert.AreEqual("Contact Name: Test User", driver.FindElement(By.CssSelector("#ContactNameLabel")));
            ceaseconnections.WholesaleVerifyNewContactDisplayed("");

            Assert.AreEqual("Test", driver.FindElement(By.CssSelector("#selectContact-grid > tbody > tr:nth-child(4) > td:nth-child(1)")).Text);
            Assert.AreEqual("User", driver.FindElement(By.CssSelector("#selectContact-grid > tbody > tr:nth-child(4) > td:nth-child(2)")).Text);

            Assert.AreEqual("07745612345", driver.FindElement(By.CssSelector("#selectContact-grid > tbody > tr:nth-child(4) > td:nth-child(4)")).Text);

            Assert.AreEqual("test.user@email.com", driver.FindElement(By.CssSelector("#selectContact-grid > tbody > tr:nth-child(4) > td:nth-child(5)")).Text);
            ceaseconnections.DeleteNewContact();
        }

        /*
            1. Go to Admin  -> User Management
            2. Impersonate account ABZ011
            3. Go to Provisioning -> Cease Connection
            4. Click select contact
            5. Click edit on the user just created 
            6. Edit the surname 
            7. Click submit
            8. Verify that the contact surname has been amended
         */
        [Test]
        public void Provisioning_CeaseConnection_Test_21()
        {

            var ceaseconnections = new CeaseConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            ceaseconnections.ImpersonateCOS010();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/DirectCease");

            ceaseconnections.DirectEditContactTest("", "", "");

            Assert.AreEqual("", driver.FindElement(By.CssSelector("#ContactNameLabel")));

        
    }
    }
}
