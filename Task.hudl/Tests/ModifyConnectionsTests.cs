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

    public class ModifyConnectionsPage<T> : BaseTest<T> where T : IWebDriver, new()
    {

        [SetUp]
        public void setup()
        {
            var login = new LoginPage(driver);
            driver.FindElement(By.CssSelector("body > div.cookieSection > div > button")).Click();
            login.Login(accountCode, email, password);
        }

        /*
         */ 

        [Test]
        public void Provisioning_Modify_Connection_Test_21()
        {

            var modify = new ModifyConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            modify.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/Cancellation");
            modify.SearchByDslModify("");


            modify.SelectContactTest();

            Assert.AreEqual("", driver.FindElement(By.CssSelector("#ContactNameLabel")));

        }

        [Test]
        public void Provisioning_Modify_Connection_Test_22()
        {

            var modify = new ModifyConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            modify.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/Cancellation");
            modify.SearchByDslModify("");


            modify.SelectContactTest2();

            Assert.AreEqual("", driver.FindElement(By.CssSelector("#ContactNameLabel")));

        }

        [Test]
        public void Provisioning_Modify_Connection_Test_23()
        {

            var modify = new ModifyConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            modify.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/Cancellation");
            modify.SearchByDslModify("");

            modify.CreateNewContact();

            Assert.AreEqual("Contact Name: Test User", driver.FindElement(By.CssSelector("#ContactNameLabel")));
            modify.VerifyNewContactDisplayed();

            Assert.AreEqual("Test", driver.FindElement(By.CssSelector("#selectContact-grid > tbody > tr:nth-child(4) > td:nth-child(1)")).Text);
            Assert.AreEqual("User", driver.FindElement(By.CssSelector("#selectContact-grid > tbody > tr:nth-child(4) > td:nth-child(2)")).Text);

            Assert.AreEqual("07745612345", driver.FindElement(By.CssSelector("#selectContact-grid > tbody > tr:nth-child(4) > td:nth-child(4)")).Text);

            Assert.AreEqual("test.user@email.com", driver.FindElement(By.CssSelector("#selectContact-grid > tbody > tr:nth-child(4) > td:nth-child(5)")).Text);
            modify.DeleteNewContact();
        }
        [Test]
        public void Provisioning_Modify_Connection_Test_24()
        {

            var modify = new ModifyConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            modify.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/Cancellation");
            modify.SearchByDslModify("");

            modify.EditContactTest("", "");

            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));


        }
        //BT- ADSL to ADSL - Change speed

        [Test]
        public void Provisioning_Modify_Connection_Test_25()
        {

            var modify = new ModifyConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            modify.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/Cancellation");
            modify.SearchByDslModify("");

            modify.ChangeSpeed("");

            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));
        }

        //BT- ADSL to ADSL 2+ - Upgrade

        [Test]
        public void Provisioning_Modify_Connection_Test_26()
        {

            var modify = new ModifyConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            modify.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/Cancellation");
            modify.SearchByDslModify("");

            modify.ChangeProduct("");
            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));

        }

        //BT- ADSL to FTTC - Upgrade
        [Test]
        public void Provisioning_Modify_Connection_Test_27()
        {

            var modify = new ModifyConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            modify.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/Cancellation");
            modify.SearchByDslModify("");

            modify.ChangeProduct("");
            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));
        }

        //BT- ADSL to FTTP - Upgrade
        [Test]
        public void Provisioning_Modify_Connection_Test_28()
        {

            var modify = new ModifyConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            modify.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/Cancellation");
            modify.SearchByDslModify("");

            modify.ChangeProduct("");
            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));
        }

        //BT- ADSL to GFAST - Upgrade
        [Test]
        public void Provisioning_Modify_Connection_Test_29()
        {

            var modify = new ModifyConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            modify.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/Cancellation");
            modify.SearchByDslModify("");

            modify.ChangeProduct("");
        }


        //BT- ADSL 2+ to ADSL - Downgrade
        [Test]
        public void Provisioning_Modify_Connection_Test_30()
        {

            var modify = new ModifyConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            modify.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/Cancellation");
            modify.SearchByDslModify("");

            modify.ChangeProduct("");
            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));
        }

        //BT- FTTC to ADSL - Downgrade
        [Test]
        public void Provisioning_Modify_Connection_Test_31()
        {

            var modify = new ModifyConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            modify.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/Cancellation");
            modify.SearchByDslModify("");

            modify.ChangeProduct("");
            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));

        }

        //BT- FTTP to ADSL - Downgrade
        [Test]
        public void Provisioning_Modify_Connection_Test_32()
        {

            var modify = new ModifyConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            modify.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/Cancellation");
            modify.SearchByDslModify("");

            modify.ChangeProduct("");
            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));
        }

        //BT- GFAST to ADSL - Downgrade
        [Test]
        public void Provisioning_Modify_Connection_Test_33()
        {

            var modify = new ModifyConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            modify.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/Cancellation");
            modify.SearchByDslModify("");

            modify.ChangeProduct("");

            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));
        }

        //BT- ADSL 2+ to ADSL 2+ - Change speed
        [Test]
        public void Provisioning_Modify_Connection_Test_34()
        {

            var modify = new ModifyConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            modify.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/Cancellation");
            modify.SearchByDslModify("");

            modify.ChangeSpeed("");

            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));
        }

        //BT- ADSL 2+ to FTTC - Upgrade
        [Test]
        public void Provisioning_Modify_Connection_Test_35()
        {

            var modify = new ModifyConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            modify.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/Cancellation");
            modify.SearchByDslModify("");

            modify.ChangeProduct("");

            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));
        }

        //BT- ADSL 2+ to FTTP - Upgrade
        [Test]
        public void Provisioning_Modify_Connection_Test_36()
        {

            var modify = new ModifyConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            modify.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/Cancellation");
            modify.SearchByDslModify("");

            modify.ChangeProduct("");

            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));
        }

        //BT- ADSL 2+ to GFAST - Upgrade
        [Test]
        public void Provisioning_Modify_Connection_Test_37()
        {

            var modify = new ModifyConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            modify.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/Cancellation");
            modify.SearchByDslModify("");

            modify.ChangeProduct("");

            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));
        }

        //BT- FTTC to ADSL 2+ - Downgrade
        [Test]
        public void Provisioning_Modify_Connection_Test_38()
        {

            var modify = new ModifyConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            modify.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/Cancellation");
            modify.SearchByDslModify("");

            modify.ChangeProduct("");
            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));
        }

        //BT- FTTP to ADSL 2+ - Downgrade
        [Test]
        public void Provisioning_Modify_Connection_Test_39()
        {

            var modify = new ModifyConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            modify.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/Cancellation");
            modify.SearchByDslModify("");

            modify.ChangeProduct("");

            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));
        }

        //BT- GFAST to ADSL 2+ - Downgrade
        [Test]
        public void Provisioning_Modify_Connection_Test_40()
        {

            var modify = new ModifyConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            modify.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/Cancellation");
            modify.SearchByDslModify("");

            modify.ChangeProduct("");

            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));
        }

        //BT- FTTC to FTTP - Upgrade
        [Test]
        public void Provisioning_Modify_Connection_Test_41()
        {

            var modify = new ModifyConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            modify.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/Cancellation");
            modify.SearchByDslModify("");

            modify.ChangeProduct("");

            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));
        }

        //BT- FTTC to GFAST - Upgrade
        [Test]
        public void Provisioning_Modify_Connection_Test_42()
        {

            var modify = new ModifyConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            modify.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/Cancellation");
            modify.SearchByDslModify("");

            modify.ChangeProduct("");

            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));
        }

        //BT- FTTC to FTTC - Change speed
        [Test]
        public void Provisioning_Modify_Connection_Test_43()
        {

            var modify = new ModifyConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            modify.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/Cancellation");
            modify.SearchByDslModify("");

            modify.ChangeSpeed("");

            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));
        }

        //BT- FTTP to FTTC - Downgrade
        [Test]
        public void Provisioning_Modify_Connection_Test_44()
        {

            var modify = new ModifyConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            modify.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/Cancellation");
            modify.SearchByDslModify("");

            modify.ChangeProduct("");

            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));
        }

        //BT- GFAST to FTTC - Downgrade
        [Test]
        public void Provisioning_Modify_Connection_Test_45()
        {

            var modify = new ModifyConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            modify.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/Cancellation");
            modify.SearchByDslModify("");

            modify.ChangeProduct("");
            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));
        }

        //BT- FTTP to FTTP - Change speed
        [Test]
        public void Provisioning_Modify_Connection_Test_46()
        {

            var modify = new ModifyConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            modify.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/Cancellation");
            modify.SearchByDslModify("");

            modify.ChangeSpeed("");
            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));
        }

        //BT- FTTP to GFAST - Upgrade
        [Test]
        public void Provisioning_Modify_Connection_Test_47()
        {

            var modify = new ModifyConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            modify.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/Cancellation");
            modify.SearchByDslModify("");

            modify.ChangeProduct("");
            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));
        }

        //BT- GFAST to FTTP - Downgrade
        [Test]
        public void Provisioning_Modify_Connection_Test_48()
        {

            var modify = new ModifyConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            modify.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/Cancellation");
            modify.SearchByDslModify("");

            modify.ChangeProduct("");

            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));
        }

        //BT- GFAST to GFAST - Change speed
        [Test]
        public void Provisioning_Modify_Connection_Test_49()
        {

            var modify = new ModifyConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            modify.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/Cancellation");
            modify.SearchByDslModify("");

            modify.ChangeSpeed("");

            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));
        }

        //TT- ADSL to ADSL - Change speed
        [Test]
        public void Provisioning_Modify_Connection_Test_50()
        {

            var modify = new ModifyConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            modify.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/Cancellation");
            modify.SearchByDslModify("");

            modify.ChangeSpeed("");

            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));
        }

        //TT-ADSL to ADSL 2+ - Upgrade
        [Test]
        public void Provisioning_Modify_Connection_Test_51()
        {

            var modify = new ModifyConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            modify.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/Cancellation");
            modify.SearchByDslModify("");

            modify.ChangeProduct("");
            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));
        }

        //TT-ADSL to FTTC - Upgrade
        [Test]
        public void Provisioning_Modify_Connection_Test_52()
        {

            var modify = new ModifyConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            modify.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/Cancellation");
            modify.SearchByDslModify("");

            modify.ChangeProduct("");

            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));
        }

        //TT-ADSL to FTTP - Upgrade
        [Test]
        public void Provisioning_Modify_Connection_Test_53()
        {

            var modify = new ModifyConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            modify.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/Cancellation");
            modify.SearchByDslModify("");

            modify.ChangeProduct("");
            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));
        }

        //TT-ADSL 2+ to ADSL - Downgrade
        [Test]
        public void Provisioning_Modify_Connection_Test_54()
        {

            var modify = new ModifyConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            modify.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/Cancellation");
            modify.SearchByDslModify("");

            modify.ChangeProduct("");
            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));
        }

        //TT-FTTC to ADSL - Downgrade
        [Test]
        public void Provisioning_Modify_Connection_Test_55()
        {

            var modify = new ModifyConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            modify.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/Cancellation");
            modify.SearchByDslModify("");

            modify.ChangeProduct("");
            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));
        }

        //TT-FTTP to ADSL - Downgrade
        [Test]
        public void Provisioning_Modify_Connection_Test_56()
        {

            var modify = new ModifyConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            modify.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/Cancellation");
            modify.SearchByDslModify("");

            modify.ChangeProduct("");
            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));
        }

        //TT-LLU-ADSL 2+ to ADSL 2+ - Change product
        [Test]
        public void Provisioning_Modify_Connection_Test_57()
        {

            var modify = new ModifyConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            modify.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/Cancellation");
            modify.SearchByDslModify("");

            modify.ChangeSpeed("");
            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));
        }

        //TT-MPF-ADSL 2+ to ADSL 2+ - Change product
        [Test]
        public void Provisioning_Modify_Connection_Test_58()
        {

            var modify = new ModifyConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            modify.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/Cancellation");
            modify.SearchByDslModify("");

            modify.ChangeSpeed("");
            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));
        }

        //TT-LLU-ADSL 2+ to FTTC - Upgrade - Book apt
        [Test]
        public void Provisioning_Modify_Connection_Test_59()
        {

            var modify = new ModifyConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            modify.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/Cancellation");
            modify.SearchByDslModify("");

            modify.ChangeProduct("");
            modify.BookAppointment();

            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));
        }

        //TT-MPF-ADSL 2+ to FTTC - Upgrade-Book apt
        [Test]
        public void Provisioning_Modify_Connection_Test_60()
        {

            var modify = new ModifyConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            modify.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/Cancellation");
            modify.SearchByDslModify("");

            modify.ChangeProduct("");
            modify.BookAppointment();
            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));
        }


        //TT-LLU-ADSL 2+ to FTTC - Upgrade
        [Test]
        public void Provisioning_Modify_Connection_Test_61()
        {

            var modify = new ModifyConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            modify.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/Cancellation");
            modify.SearchByDslModify("");

            modify.ChangeProduct("");
            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));

        }

        //TT-MPF-ADSL 2+ to FTTC - Upgrade
        [Test]
        public void Provisioning_Modify_Connection_Test_62()
        {

            var modify = new ModifyConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            modify.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/Cancellation");
            modify.SearchByDslModify("");

            modify.ChangeProduct("");
            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));
        }

        //TT-ADSL 2+ to FTTP - Upgrade
        [Test]
        public void Provisioning_Modify_Connection_Test_63()
        {

            var modify = new ModifyConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            modify.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/Cancellation");
            modify.SearchByDslModify("");

            modify.ChangeProduct("");
            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));
        }

        //TT-FTTC to ADSL 2+ - Downgrade
        [Test]
        public void Provisioning_Modify_Connection_Test_64()
        {

            var modify = new ModifyConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            modify.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/Cancellation");
            modify.SearchByDslModify("");

            modify.ChangeProduct("");
            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));
        }

        //TT- FTTP to ADSL 2+ - Downgrade
        [Test]
        public void Provisioning_Modify_Connection_Test_65()
        {

            var modify = new ModifyConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            modify.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/Cancellation");
            modify.SearchByDslModify("");

            modify.ChangeProduct("");
            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));
        }

        //TT- FTTC to FTTP - Upgrade
        [Test]
        public void Provisioning_Modify_Connection_Test_66()
        {

            var modify = new ModifyConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            modify.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/Cancellation");
            modify.SearchByDslModify("");

            modify.ChangeProduct("");
            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));
        }


        //TT- FTTC to FTTC - Change speed
        [Test]
        public void Provisioning_Modify_Connection_Test_67()
        {

            var modify = new ModifyConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            modify.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/Cancellation");
            modify.SearchByDslModify("");

            modify.ChangeSpeed("");
            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));
        }

        //TT- FTTP to FTTC - Downgrade
        [Test]
        public void Provisioning_Modify_Connection_Test_68()
        {

            var modify = new ModifyConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            modify.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/Cancellation");
            modify.SearchByDslModify("");

            modify.ChangeProduct("");
            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));
        }

        //TT- FTTP to FTTP - Change speed
        [Test]
        public void Provisioning_Modify_Connection_Test_69()
        {

            var modify = new ModifyConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            modify.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/Cancellation");
            modify.SearchByDslModify("");

            modify.ChangeSpeed("");
            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));
        }

        //BT layer 3 modify 
        [Test]
        public void Provisioning_Modify_Connection_Test_70()
        {

            var modify = new ModifyConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            modify.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/Cancellation");
            modify.SearchByDslModify("");

            modify.ChangeProduct("");
            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));
        }

        //BT layer 3 modify - Book ap
        [Test]
        public void Provisioning_Modify_Connection_Test_71()
        {

            var modify = new ModifyConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            modify.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/Cancellation");
            modify.SearchByDslModify("");

            modify.ChangeProduct("");
            modify.BookAppointment();
            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));
        }

        //TT layer 3 modify 
        [Test]
        public void Provisioning_Modify_Connection_Test_72()
        {

            var modify = new ModifyConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            modify.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/Cancellation");
            modify.SearchByDslModify("");

            modify.ChangeProduct("");
            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));
        }

        //TT layer 3 modify - Book apt
        [Test]
        public void Provisioning_Modify_Connection_Test_73()
        {

            var modify = new ModifyConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            modify.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/Cancellation");
            modify.SearchByDslModify("");

            modify.ChangeProduct("");
            modify.BookAppointment();
            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));

        }

        //BT layer 2 to layer 3 modify 
        [Test]
        public void Provisioning_Modify_Connection_Test_74()
        {

            var modify = new ModifyConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            modify.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/Cancellation");
            modify.SearchByDslModify("");


            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));
        }

        //TT layer 2 to layer 3 modify 
        [Test]
        public void Provisioning_Modify_Connection_Test_75()
        {

            var modify = new ModifyConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            modify.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/Cancellation");
            modify.SearchByDslModify("");


            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));
        }

        //BT -Modify against an already processing modify request
        [Test]
        public void Provisioning_Modify_Connection_Test_76()
        {

            var modify = new ModifyConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            modify.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/Cancellation");
            modify.SearchByDslModify("");

            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));
        }

        //TT -Modify against an already processing modify request
        [Test]
        public void Provisioning_Modify_Connection_Test_77()
        {

            var modify = new ModifyConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            modify.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/Cancellation");
            modify.SearchByDslModify("");

            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));
        }


        /* TT Profile change
         
          [Test]
         public void Provisioning_Modify_Connection_Test_78()
         {

             var modify = new ModifyConnectionsPage(driver);
             driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
             modify.ImpersonateABZ011();

             driver.Navigate().GoToUrl(baseURL + "/Provisioning/Cancellation");
             modify.SearchByDslModify("");
             modify.DlmProfileChange();

             Assert.AreEqual("", driver.FindElement(By.CssSelector("DLM Profile has been changed to **********. It can take up to few hours for the new profile to be displayed correctly.")));

             Assert.AreEqual("", driver.FindElement(By.CssSelector("There is a pending DLM Profile change request:**********")));
         }*/
    }


}
