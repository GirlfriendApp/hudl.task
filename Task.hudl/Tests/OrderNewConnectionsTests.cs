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

    public class OrderNewConnectionsPage<T> : BaseTest<T> where T : IWebDriver, new()
    {

        [SetUp]
        public void setup()
        {
            var login = new LoginPage(driver);
            driver.FindElement(By.CssSelector("body > div.cookieSection > div > button")).Click();
            login.Login(accountCode, email, password);
        }

        //SIMSMPF
        // mpf

        [Test]
        public void OrderNewConnections_Test_59()
        {

            var ordernewconnection = new OrderNewConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            ordernewconnection.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/OrderNewConnection");
            ordernewconnection.PickSmpfMpfDropdown("SMPF");
            ordernewconnection.SMPF("", "");
            ordernewconnection.AddressDropdown("");
            ordernewconnection.CheckAddressAvalibility.Click();
            ordernewconnection.SelectProductViaStockCode("BT-ADSL2+");
            ordernewconnection.SelectLayer2();
            ordernewconnection.OrderFormLayer2();

            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));


        }

        [Test]
        public void OrderNewConnections_Test_60()
        {

            var ordernewconnection = new OrderNewConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            ordernewconnection.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/OrderNewConnection");
            ordernewconnection.PickSmpfMpfDropdown("MPF");
            ordernewconnection.MPFNewProvide("");
            ordernewconnection.AddressDropdown("");
            ordernewconnection.CheckAddressAvalibility.Click();
            ordernewconnection.SelectProductViaStockCode("BT-ADSL2+");
            ordernewconnection.SelectLayer2();
            ordernewconnection.OrderFormLayer2();

            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));


        }

        [Test]
        public void OrderNewConnections_Test_61()
        {

            var ordernewconnection = new OrderNewConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            ordernewconnection.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/OrderNewConnection");
            ordernewconnection.PickSmpfMpfDropdown("MPF");

            ordernewconnection.MPFMigration("", "");
            ordernewconnection.AddressDropdown("");
            ordernewconnection.CheckAddressAvalibility.Click();
            ordernewconnection.SelectProductViaStockCode("BT-ADSL2+");
            ordernewconnection.SelectLayer2();
            ordernewconnection.OrderFormLayer2();

            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));


        }
        [Test]
        public void OrderNewConnections_Test_62()
        {

            var ordernewconnection = new OrderNewConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            ordernewconnection.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/OrderNewConnection");
            ordernewconnection.PickSmpfMpfDropdown("SIMSMPF");
            ordernewconnection.SimProvide("", "");
            ordernewconnection.AddressDropdown("");
            ordernewconnection.CheckAddressAvalibility.Click();
            ordernewconnection.SelectProductViaStockCode("BT-ADSL2+");
            ordernewconnection.SelectLayer2();
            ordernewconnection.OrderFormLayer2();

            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));


        }
        [Test]
        public void OrderNewConnections_Test_63()
        {

            var ordernewconnection = new OrderNewConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            ordernewconnection.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/OrderNewConnection");
            ordernewconnection.PickSmpfMpfDropdown("SMPF");
            ordernewconnection.SMPF("", "");
            ordernewconnection.AddressDropdown("");
            ordernewconnection.CheckAddressAvalibility.Click();
            ordernewconnection.SelectProductViaStockCode("BT-FTTC");
            ordernewconnection.SelectLayer2();
            ordernewconnection.OrderFormLayer2();

            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));


        }

        [Test]
        public void OrderNewConnections_Test_64()
        {

            var ordernewconnection = new OrderNewConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            ordernewconnection.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/OrderNewConnection");
            ordernewconnection.PickSmpfMpfDropdown("MPF");
            ordernewconnection.MPFNewProvide("");
            ordernewconnection.AddressDropdown("");
            ordernewconnection.CheckAddressAvalibility.Click();
            ordernewconnection.SelectProductViaStockCode("BT-FTTC");
            ordernewconnection.SelectLayer2();
            ordernewconnection.OrderFormLayer2();

            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));


        }

        [Test]
        public void OrderNewConnections_Test_65()
        {

            var ordernewconnection = new OrderNewConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            ordernewconnection.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/OrderNewConnection");
            ordernewconnection.PickSmpfMpfDropdown("MPF");

            ordernewconnection.MPFMigration("", "");
            ordernewconnection.AddressDropdown("");
            ordernewconnection.CheckAddressAvalibility.Click();
            ordernewconnection.SelectProductViaStockCode("BT-FTTC");
            ordernewconnection.SelectLayer2();
            ordernewconnection.OrderFormLayer2();

            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));


        }
        [Test]
        public void OrderNewConnections_Test_66()
        {

            var ordernewconnection = new OrderNewConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            ordernewconnection.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/OrderNewConnection");
            ordernewconnection.PickSmpfMpfDropdown("SIMSMPF");
            ordernewconnection.SimProvide("", "");
            ordernewconnection.AddressDropdown("");
            ordernewconnection.CheckAddressAvalibility.Click();
            ordernewconnection.SelectProductViaStockCode("BT-FTTC");
            ordernewconnection.SelectLayer2();
            ordernewconnection.OrderFormLayer2();

            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));


        }
        [Test]
        public void OrderNewConnections_Test_67()
        {

            var ordernewconnection = new OrderNewConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            ordernewconnection.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/OrderNewConnection");
            ordernewconnection.PickSmpfMpfDropdown("SMPF");
            ordernewconnection.SMPF("", "");
            ordernewconnection.AddressDropdown("");
            ordernewconnection.CheckAddressAvalibility.Click();
            ordernewconnection.SelectProductViaStockCode("TTB 24 Mb/s Premium Annex-M");
            ordernewconnection.SelectLayer2();
            ordernewconnection.OrderFormLayer2();

            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));


        }

        [Test]
        public void OrderNewConnections_Test_68()
        {

            var ordernewconnection = new OrderNewConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            ordernewconnection.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/OrderNewConnection");
            ordernewconnection.PickSmpfMpfDropdown("MPF");
            ordernewconnection.MPFNewProvide("");
            ordernewconnection.AddressDropdown("");
            ordernewconnection.CheckAddressAvalibility.Click();
            ordernewconnection.SelectProductViaStockCode("TTB 24 Mb/s Premium Annex-M");
            ordernewconnection.SelectLayer2();
            ordernewconnection.OrderFormLayer2();

            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));


        }

        [Test]
        public void OrderNewConnections_Test_69()
        {

            var ordernewconnection = new OrderNewConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            ordernewconnection.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/OrderNewConnection");
            ordernewconnection.PickSmpfMpfDropdown("MPF");

            ordernewconnection.MPFMigration("", "");
            ordernewconnection.AddressDropdown("");
            ordernewconnection.CheckAddressAvalibility.Click();
            ordernewconnection.SelectProductViaStockCode("TTB 24 Mb/s Premium Annex-M");
            ordernewconnection.SelectLayer2();
            ordernewconnection.OrderFormLayer2();

            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));


        }
        [Test]
        public void OrderNewConnections_Test_70()
        {

            var ordernewconnection = new OrderNewConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            ordernewconnection.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/OrderNewConnection");
            ordernewconnection.PickSmpfMpfDropdown("SIMSMPF");
            ordernewconnection.SimProvide("", "");
            ordernewconnection.AddressDropdown("");
            ordernewconnection.CheckAddressAvalibility.Click();
            ordernewconnection.SelectProductViaStockCode("TTB 24 Mb/s Premium Annex-M");
            ordernewconnection.SelectLayer2();
            ordernewconnection.OrderFormLayer2();

            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));


        }

        [Test]
        public void OrderNewConnections_Test_71()
        {

            var ordernewconnection = new OrderNewConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            ordernewconnection.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/OrderNewConnection");
            ordernewconnection.PickSmpfMpfDropdown("SMPF");
            ordernewconnection.SMPF("", "");
            ordernewconnection.AddressDropdown("");
            ordernewconnection.CheckAddressAvalibility.Click();
            ordernewconnection.SelectProductViaStockCode("TTB SMPF FTTC 80/20 Premium");
            ordernewconnection.SelectLayer2();
            ordernewconnection.OrderFormLayer2();

            Assert.AreEqual("", driver.FindElement(By.CssSelector(" ")));


        }

        [Test]
        public void OrderNewConnections_Test_72()
        {

            var ordernewconnection = new OrderNewConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            ordernewconnection.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/OrderNewConnection");
            ordernewconnection.PickSmpfMpfDropdown("MPF");
            ordernewconnection.MPFNewProvide("");
            ordernewconnection.AddressDropdown("");
            ordernewconnection.CheckAddressAvalibility.Click();
            ordernewconnection.SelectProductViaStockCode("TTB SMPF FTTC 80/20 Premium");
            ordernewconnection.SelectLayer2();
            ordernewconnection.OrderFormLayer2();

            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));


        }

        [Test]
        public void OrderNewConnections_Test_73()
        {

            var ordernewconnection = new OrderNewConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            ordernewconnection.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/OrderNewConnection");
            ordernewconnection.PickSmpfMpfDropdown("MPF");

            ordernewconnection.MPFMigration("", "");
            ordernewconnection.AddressDropdown("");
            ordernewconnection.CheckAddressAvalibility.Click();
            ordernewconnection.SelectProductViaStockCode("TTB SMPF FTTC 80/20 Premium");
            ordernewconnection.SelectLayer2();
            ordernewconnection.OrderFormLayer2();

            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));


        }
        [Test]
        public void OrderNewConnections_Test_74()
        {

            var ordernewconnection = new OrderNewConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            ordernewconnection.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/OrderNewConnection");
            ordernewconnection.PickSmpfMpfDropdown("SIMSMPF");
            ordernewconnection.SimProvide("", "");
            ordernewconnection.AddressDropdown("");
            ordernewconnection.CheckAddressAvalibility.Click();
            ordernewconnection.SelectProductViaStockCode("TTB SMPF FTTC 80/20 Premium");
            ordernewconnection.SelectLayer2();
            ordernewconnection.OrderFormLayer2();

            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));


        }
        [Test]
        public void OrderNewConnections_Test_75()
        {

            var ordernewconnection = new OrderNewConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            ordernewconnection.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/OrderNewConnection");
            ordernewconnection.PickSmpfMpfDropdown("SIMSMPF");
            ordernewconnection.SimProvide("", "");
            ordernewconnection.AddressDropdown("");
            ordernewconnection.CheckAddressAvalibility.Click();
            ordernewconnection.SelectProductViaStockCode("TTB ADSL Premium");
            ordernewconnection.SelectLayer2();
            ordernewconnection.OrderFormLayer2();

            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));


        }

        [Test]
        public void OrderNewConnections_Test_76()
        {

            var ordernewconnection = new OrderNewConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            ordernewconnection.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/OrderNewConnection");
            ordernewconnection.PickSmpfMpfDropdown("SMPF");
            ordernewconnection.SMPF("", "");
            ordernewconnection.AddressDropdown("");
            ordernewconnection.CheckAddressAvalibility.Click();
            ordernewconnection.SelectProductViaStockCode("TTB ADSL Premium");
            ordernewconnection.SelectLayer2();
            ordernewconnection.OrderFormLayer2();

            Assert.AreEqual("", driver.FindElement(By.CssSelector(" ")));


        }

        [Test]
        public void OrderNewConnections_Test_77()
        {

            var ordernewconnection = new OrderNewConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            ordernewconnection.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/OrderNewConnection");
            ordernewconnection.PickSmpfMpfDropdown("MPF");
            ordernewconnection.MPFNewProvide("");
            ordernewconnection.AddressDropdown("");
            ordernewconnection.CheckAddressAvalibility.Click();
            ordernewconnection.SelectProductViaStockCode("TTB ADSL Premium");
            ordernewconnection.SelectLayer2();
            ordernewconnection.OrderFormLayer2();

            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));


        }

        [Test]
        public void OrderNewConnections_Test_78()
        {

            var ordernewconnection = new OrderNewConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            ordernewconnection.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/OrderNewConnection");
            ordernewconnection.PickSmpfMpfDropdown("MPF");

            ordernewconnection.MPFMigration("", "");
            ordernewconnection.AddressDropdown("");
            ordernewconnection.CheckAddressAvalibility.Click();
            ordernewconnection.SelectProductViaStockCode("TTB ADSL Premium");
            ordernewconnection.SelectLayer2();
            ordernewconnection.OrderFormLayer2();

            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));


        }
        [Test]
        public void OrderNewConnections_Test_79()
        {

            var ordernewconnection = new OrderNewConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            ordernewconnection.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/OrderNewConnection");
            ordernewconnection.PickSmpfMpfDropdown("SMPF");
            ordernewconnection.SMPF("", "");
            ordernewconnection.AddressDropdown("");
            ordernewconnection.CheckAddressAvalibility.Click();
            ordernewconnection.SelectProductViaStockCode("BT-FTTC");
            ordernewconnection.SelectLayer3();
            ordernewconnection.OrderFormLayer3NoPoRef();

            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));


        }

        [Test]
        public void OrderNewConnections_Test_80()
        {

            var ordernewconnection = new OrderNewConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            ordernewconnection.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/OrderNewConnection");
            ordernewconnection.PickSmpfMpfDropdown("SMPF");
            ordernewconnection.SMPF("", "");
            ordernewconnection.AddressDropdown("");
            ordernewconnection.CheckAddressAvalibility.Click();
            ordernewconnection.SelectProductViaStockCode("BT-FTTC");
            ordernewconnection.SelectLayer3();
            ordernewconnection.OrderFormLayer3NoContact();

            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));


        }

        [Test]
        public void OrderNewConnections_Test_81()
        {

            var ordernewconnection = new OrderNewConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            ordernewconnection.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/OrderNewConnection");
            ordernewconnection.PickSmpfMpfDropdown("SMPF");
            ordernewconnection.SMPF("", "");
            ordernewconnection.AddressDropdown("");
            ordernewconnection.CheckAddressAvalibility.Click();
            ordernewconnection.SelectProductViaStockCode("BT-FTTC");
            ordernewconnection.SelectLayer3();
            ordernewconnection.OrderFormLayer3NoEndUsers();

            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));


        }
        [Test]
        public void OrderNewConnections_Test_82()
        {

            var ordernewconnection = new OrderNewConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            ordernewconnection.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/OrderNewConnection");
            ordernewconnection.PickSmpfMpfDropdown("SMPF");
            ordernewconnection.SMPF("", "");
            ordernewconnection.AddressDropdown("");
            ordernewconnection.CheckAddressAvalibility.Click();
            ordernewconnection.SelectProductViaStockCode("BT-FTTC");
            ordernewconnection.SelectLayer3();
            ordernewconnection.OrderFormLayer3NoConsent();

            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));


        }

        [Test]
        public void OrderNewConnections_Test_83()
        {

            var ordernewconnection = new OrderNewConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            ordernewconnection.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/OrderNewConnection");
            ordernewconnection.PickSmpfMpfDropdown("SMPF");
            ordernewconnection.SMPF("", "");
            ordernewconnection.AddressDropdown("");
            ordernewconnection.CheckAddressAvalibility.Click();
            ordernewconnection.SelectProductViaStockCode("BT-FTTC");
            ordernewconnection.SelectLayer3();
            ordernewconnection.OrderFormLayer3Dia();

            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));
        }

        [Test]
        public void OrderNewConnections_Test_84()
        {

            var ordernewconnection = new OrderNewConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            ordernewconnection.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/OrderNewConnection");
            ordernewconnection.PickSmpfMpfDropdown("SMPF");
            ordernewconnection.SMPF("", "");
            ordernewconnection.AddressDropdown("");
            ordernewconnection.CheckAddressAvalibility.Click();
            ordernewconnection.SelectProductViaStockCode("BT-FTTC");
            ordernewconnection.SelectLayer3();
            ordernewconnection.OrderFormLayer3PwanMpls();

            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));
        }
        // silver Key orders
        [Test]
        public void OrderNewConnections_Test_85()
        {

            var ordernewconnection = new OrderNewConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            ordernewconnection.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/OrderNewConnection");
            ordernewconnection.PickSmpfMpfDropdown("SMPF");
            ordernewconnection.SMPF("", "");
            ordernewconnection.AddressDropdown("");
            ordernewconnection.CheckAddressAvalibility.Click();
            ordernewconnection.SelectProductViaStockCode("BT-FTTC");
            ordernewconnection.SelectLayer3();
            ordernewconnection.OrderFormLayer3Dia();

            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));
        }


        [Test]
        public void OrderNewConnections_Test_86()
        {

            var ordernewconnection = new OrderNewConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            ordernewconnection.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/OrderNewConnection");
            ordernewconnection.PickSmpfMpfDropdown("SMPF");
            ordernewconnection.SMPF("", "");
            ordernewconnection.AddressDropdown("");
            ordernewconnection.CheckAddressAvalibility.Click();
            ordernewconnection.SelectProductViaStockCode("BT-FTTC");
            ordernewconnection.SelectLayer3();
            ordernewconnection.OrderFormLayer3PwanMpls();

            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));
        }

        [Test]
        public void OrderNewConnections_Test_87()
        {

            var ordernewconnection = new OrderNewConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            ordernewconnection.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/OrderNewConnection");
            ordernewconnection.PickSmpfMpfDropdown("SMPF");
            ordernewconnection.SMPF("", "");
            ordernewconnection.AddressDropdown("");
            ordernewconnection.CheckAddressAvalibility.Click();
            ordernewconnection.SelectProductViaStockCode("BT-FTTC");
            ordernewconnection.SelectLayer3();
            ordernewconnection.OrderFormLayer3NoPoRefASDL2();

            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));


        }

        [Test]
        public void OrderNewConnections_Test_88()
        {

            var ordernewconnection = new OrderNewConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            ordernewconnection.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/OrderNewConnection");
            ordernewconnection.PickSmpfMpfDropdown("SMPF");
            ordernewconnection.SMPF("", "");
            ordernewconnection.AddressDropdown("");
            ordernewconnection.CheckAddressAvalibility.Click();
            ordernewconnection.SelectProductViaStockCode("BT-FTTC");
            ordernewconnection.SelectLayer3();
            ordernewconnection.OrderFormLayer3NoContactADSL2();

            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));


        }


        [Test]
        public void OrderNewConnections_Test_89()
        {

            var ordernewconnection = new OrderNewConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            ordernewconnection.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/OrderNewConnection");
            ordernewconnection.PickSmpfMpfDropdown("SMPF");
            ordernewconnection.SMPF("", "");
            ordernewconnection.AddressDropdown("");
            ordernewconnection.CheckAddressAvalibility.Click();
            ordernewconnection.SelectProductViaStockCode("BT-FTTC");
            ordernewconnection.SelectLayer3();
            ordernewconnection.OrderFormLayer3NoConsentADSL2();

            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));


        }

        [Test]
        public void OrderNewConnections_Test_90()
        {

            var ordernewconnection = new OrderNewConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            ordernewconnection.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/OrderNewConnection");
            ordernewconnection.PickSmpfMpfDropdown("SMPF");
            ordernewconnection.SMPF("", "");
            ordernewconnection.AddressDropdown("");
            ordernewconnection.CheckAddressAvalibility.Click();
            ordernewconnection.SelectProductViaStockCode("BT-ADSL2+");
            ordernewconnection.SelectLayer3();
            ordernewconnection.OrderFormLayer3Dia();

            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));
        }

        [Test]
        public void OrderNewConnections_Test_91()
        {

            var ordernewconnection = new OrderNewConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            ordernewconnection.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/OrderNewConnection");
            ordernewconnection.PickSmpfMpfDropdown("SMPF");
            ordernewconnection.SMPF("", "");
            ordernewconnection.AddressDropdown("");
            ordernewconnection.CheckAddressAvalibility.Click();
            ordernewconnection.SelectProductViaStockCode("BT-ADSL2+");
            ordernewconnection.SelectLayer3();
            ordernewconnection.OrderFormLayer3PwanMpls();

            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));
        }
        // silver Key orders
        [Test]
        public void OrderNewConnections_Test_92()
        {

            var ordernewconnection = new OrderNewConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            ordernewconnection.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/OrderNewConnection");
            ordernewconnection.PickSmpfMpfDropdown("SMPF");
            ordernewconnection.SMPF("", "");
            ordernewconnection.AddressDropdown("");
            ordernewconnection.CheckAddressAvalibility.Click();
            ordernewconnection.SelectProductViaStockCode("BT-ADSL2+");
            ordernewconnection.SelectLayer3();
            ordernewconnection.OrderFormLayer3Dia();

            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));
        }


        [Test]
        public void OrderNewConnections_Test_93()
        {

            var ordernewconnection = new OrderNewConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            ordernewconnection.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/OrderNewConnection");
            ordernewconnection.PickSmpfMpfDropdown("SMPF");
            ordernewconnection.SMPF("", "");
            ordernewconnection.AddressDropdown("");
            ordernewconnection.CheckAddressAvalibility.Click();
            ordernewconnection.SelectProductViaStockCode("BT-ADSL2+");
            ordernewconnection.SelectLayer3();
            ordernewconnection.OrderFormLayer3PwanMpls();

            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));
        }

        [Test]
        public void OrderNewConnections_Test_94()
        {

            var ordernewconnection = new OrderNewConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            ordernewconnection.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/OrderNewConnection");
            ordernewconnection.PickSmpfMpfDropdown("SMPF");
            ordernewconnection.SMPF("", "");
            ordernewconnection.AddressDropdown("");
            ordernewconnection.CheckAddressAvalibility.Click();
            ordernewconnection.SelectProductViaStockCode("TTB 24 Mb/s Premium Annex-M");
            ordernewconnection.SelectLayer3();
            ordernewconnection.OrderFormLayer3NoPoRef();

            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));


        }

        [Test]
        public void OrderNewConnections_Test_95()
        {

            var ordernewconnection = new OrderNewConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            ordernewconnection.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/OrderNewConnection");
            ordernewconnection.PickSmpfMpfDropdown("SMPF");
            ordernewconnection.SMPF("", "");
            ordernewconnection.AddressDropdown("");
            ordernewconnection.CheckAddressAvalibility.Click();
            ordernewconnection.SelectProductViaStockCode("TTB 24 Mb/s Premium Annex-M");
            ordernewconnection.SelectLayer3();
            ordernewconnection.OrderFormLayer3NoContact();

            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));


        }

        [Test]
        public void OrderNewConnections_Test_96()
        {

            var ordernewconnection = new OrderNewConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            ordernewconnection.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/OrderNewConnection");
            ordernewconnection.PickSmpfMpfDropdown("SMPF");
            ordernewconnection.SMPF("", "");
            ordernewconnection.AddressDropdown("");
            ordernewconnection.CheckAddressAvalibility.Click();
            ordernewconnection.SelectProductViaStockCode("TTB 24 Mb/s Premium Annex-M");
            ordernewconnection.SelectLayer3();
            ordernewconnection.OrderFormLayer3NoEndUsers();

            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));


        }
        [Test]
        public void OrderNewConnections_Test_97()
        {

            var ordernewconnection = new OrderNewConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            ordernewconnection.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/OrderNewConnection");
            ordernewconnection.PickSmpfMpfDropdown("SMPF");
            ordernewconnection.SMPF("", "");
            ordernewconnection.AddressDropdown("");
            ordernewconnection.CheckAddressAvalibility.Click();
            ordernewconnection.SelectProductViaStockCode("TTB 24 Mb/s Premium Annex-M");
            ordernewconnection.SelectLayer3();
            ordernewconnection.OrderFormLayer3NoConsent();

            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));


        }

        [Test]
        public void OrderNewConnections_Test_98()
        {

            var ordernewconnection = new OrderNewConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            ordernewconnection.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/OrderNewConnection");
            ordernewconnection.PickSmpfMpfDropdown("MPF");
            ordernewconnection.MPFNewProvide("");
            ordernewconnection.AddressDropdown("");
            ordernewconnection.CheckAddressAvalibility.Click();
            ordernewconnection.SelectProductViaStockCode("TTB SMPF FTTC 80/20 Premium");
            ordernewconnection.SelectLayer3();
            ordernewconnection.OrderFormLayer3Dia();

            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));
        }

        [Test]
        public void OrderNewConnections_Test_99()
        {

            var ordernewconnection = new OrderNewConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            ordernewconnection.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/OrderNewConnection");
            ordernewconnection.PickSmpfMpfDropdown("MPF");
            ordernewconnection.MPFMigration("", "");
            ordernewconnection.AddressDropdown("");
            ordernewconnection.CheckAddressAvalibility.Click();
            ordernewconnection.SelectProductViaStockCode("TTB SMPF FTTC 80/20 Premium");
            ordernewconnection.SelectLayer3();
            ordernewconnection.OrderFormLayer3Dia();

            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));
        }
        [Test]
        public void OrderNewConnections_Test_100()
        {

            var ordernewconnection = new OrderNewConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            ordernewconnection.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/OrderNewConnection");
            ordernewconnection.PickSmpfMpfDropdown("MPF");
            ordernewconnection.MPFNewProvide("");
            ordernewconnection.AddressDropdown("");
            ordernewconnection.CheckAddressAvalibility.Click();
            ordernewconnection.SelectProductViaStockCode("TTB 24 Mb/s Premium Annex-M");
            ordernewconnection.SelectLayer3();
            ordernewconnection.OrderFormLayer3Dia();

            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));
        }

        [Test]
        public void OrderNewConnections_Test_101()
        {

            var ordernewconnection = new OrderNewConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            ordernewconnection.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/OrderNewConnection");
            ordernewconnection.PickSmpfMpfDropdown("MPF");
            ordernewconnection.MPFMigration("", "");
            ordernewconnection.AddressDropdown("");
            ordernewconnection.CheckAddressAvalibility.Click();
            ordernewconnection.SelectProductViaStockCode("TTB 24 Mb/s Premium Annex-M");
            ordernewconnection.SelectLayer3();
            ordernewconnection.OrderFormLayer3Dia();

            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));
        }

        [Test]
        public void OrderNewConnections_Test_102()
        {

            var ordernewconnection = new OrderNewConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            ordernewconnection.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/OrderNewConnection");
            ordernewconnection.PickSmpfMpfDropdown("MPF");
            ordernewconnection.MPFNewProvide("");
            ordernewconnection.AddressDropdown("");
            ordernewconnection.CheckAddressAvalibility.Click();
            ordernewconnection.SelectProductViaStockCode("TTB ADSL Premium");
            ordernewconnection.SelectLayer3();
            ordernewconnection.OrderFormLayer3Dia();

            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));
        }

        [Test]
        public void OrderNewConnections_Test_103()
        {

            var ordernewconnection = new OrderNewConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            ordernewconnection.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/OrderNewConnection");
            ordernewconnection.PickSmpfMpfDropdown("MPF");
            ordernewconnection.MPFMigration("", "");
            ordernewconnection.AddressDropdown("");
            ordernewconnection.CheckAddressAvalibility.Click();
            ordernewconnection.SelectProductViaStockCode("TTB ADSL Premium");
            ordernewconnection.SelectLayer3();
            ordernewconnection.OrderFormLayer3Dia();

            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));
        }

        [Test]
        public void OrderNewConnections_Test_104()
        {

            var ordernewconnection = new OrderNewConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            ordernewconnection.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/OrderNewConnection");
            ordernewconnection.PickSmpfMpfDropdown("SMPF");
            ordernewconnection.SMPF("", "");
            ordernewconnection.AddressDropdown("");
            ordernewconnection.CheckAddressAvalibility.Click();
            ordernewconnection.SelectProductViaStockCode("TTB 24 Mb/s Premium Annex-M");
            ordernewconnection.SelectLayer3();
            ordernewconnection.OrderFormLayer3PwanMpls();

            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));
        }

        //Sliver key address

        [Test]
        public void OrderNewConnections_Test_105()
        {

            var ordernewconnection = new OrderNewConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            ordernewconnection.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/OrderNewConnection");
            ordernewconnection.PickSmpfMpfDropdown("SMPF");
            ordernewconnection.SMPF("", "");
            ordernewconnection.AddressDropdown("");
            ordernewconnection.CheckAddressAvalibility.Click();
            ordernewconnection.SelectProductViaStockCode("TTB 24 Mb/s Premium Annex-M");
            ordernewconnection.SelectLayer3();
            ordernewconnection.OrderFormLayer3Dia();

            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));
        }

        [Test]
        public void OrderNewConnections_Test_106()
        {

            var ordernewconnection = new OrderNewConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            ordernewconnection.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/OrderNewConnection");
            ordernewconnection.PickSmpfMpfDropdown("SMPF");
            ordernewconnection.SMPF("", "");
            ordernewconnection.AddressDropdown("");
            ordernewconnection.CheckAddressAvalibility.Click();
            ordernewconnection.SelectProductViaStockCode("TTB 24 Mb/s Premium Annex-M");
            ordernewconnection.SelectLayer3();
            ordernewconnection.OrderFormLayer3PwanMpls();

            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));
        }

        [Test]
        public void OrderNewConnections_Test_107()
        {

            var ordernewconnection = new OrderNewConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            ordernewconnection.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/OrderNewConnection");
            ordernewconnection.PickSmpfMpfDropdown("SMPF");
            ordernewconnection.SMPF("", "");
            ordernewconnection.AddressDropdown("");
            ordernewconnection.CheckAddressAvalibility.Click();
            ordernewconnection.SelectProductViaStockCode("TTB ADSL Premium");
            ordernewconnection.SelectLayer3();
            ordernewconnection.OrderFormLayer3Dia();

            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));
        }
        //Silver key - book apt
        [Test]
        public void OrderNewConnections_Test_108()
        {

            var ordernewconnection = new OrderNewConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            ordernewconnection.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/OrderNewConnection");
            ordernewconnection.PickSmpfMpfDropdown("SMPF");
            ordernewconnection.SMPF("", "");
            ordernewconnection.AddressDropdown("");
            ordernewconnection.CheckAddressAvalibility.Click();
            ordernewconnection.SelectProductViaStockCode("BT-ADSL2+");
            ordernewconnection.SelectLayer3();
            ordernewconnection.OrderFormLayer3BookApt();

            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));
        }

        //Silver key - self install
        [Test]
        public void OrderNewConnections_Test_109()
        {

            var ordernewconnection = new OrderNewConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            ordernewconnection.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/OrderNewConnection");
            ordernewconnection.PickSmpfMpfDropdown("SMPF");
            ordernewconnection.SMPF("", "");
            ordernewconnection.AddressDropdown("");
            ordernewconnection.CheckAddressAvalibility.Click();
            ordernewconnection.SelectProductViaStockCode("BT-ADSL2+");
            ordernewconnection.SelectLayer3();
            ordernewconnection.OrderFormLayer3BookApt();

            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));
        }

        [Test]
        public void OrderNewConnections_Test_110()
        {

            var ordernewconnection = new OrderNewConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            ordernewconnection.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/OrderNewConnection");
            ordernewconnection.PickSmpfMpfDropdown("SMPF");
            ordernewconnection.SMPF("", "");
            ordernewconnection.AddressDropdown("");
            ordernewconnection.CheckAddressAvalibility.Click();
            ordernewconnection.SelectProductViaStockCode("BT-ADSL2+");
            ordernewconnection.SelectLayer3();
            ordernewconnection.OrderFormLayer3BookApt();

            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));
        }

        //Silver key - self install
        [Test]
        public void OrderNewConnections_Test_111()
        {

            var ordernewconnection = new OrderNewConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            ordernewconnection.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/OrderNewConnection");
            ordernewconnection.PickSmpfMpfDropdown("SMPF");
            ordernewconnection.SMPF("", "");
            ordernewconnection.AddressDropdown("");
            ordernewconnection.CheckAddressAvalibility.Click();
            ordernewconnection.SelectProductViaStockCode("BT-ADSL2+");
            ordernewconnection.SelectLayer3();
            ordernewconnection.OrderFormLayer3SelfInstall();

            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));
        }

        [Test]
        public void OrderNewConnections_Test_112()
        {

            var ordernewconnection = new OrderNewConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            ordernewconnection.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/OrderNewConnection");
            ordernewconnection.PickSmpfMpfDropdown("SIMSMPF");
            ordernewconnection.SimProvide("", "");
            ordernewconnection.AddressDropdown("");
            ordernewconnection.CheckAddressAvalibility.Click();
            ordernewconnection.SelectProductViaStockCode("BT-FTTC");
            ordernewconnection.SelectLayer3();
            ordernewconnection.OrderFormLayer3Dia();

            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));


        }

        [Test]
        public void OrderNewConnections_Test_113()
        {

            var ordernewconnection = new OrderNewConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            ordernewconnection.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/OrderNewConnection");
            ordernewconnection.PickSmpfMpfDropdown("SIMSMPF");
            ordernewconnection.SimProvide("", "");
            ordernewconnection.AddressDropdown("");
            ordernewconnection.CheckAddressAvalibility.Click();
            ordernewconnection.SelectProductViaStockCode("BT-GFAST");
            ordernewconnection.SelectLayer3();
            ordernewconnection.OrderFormLayer3Dia();

            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));


        }

        [Test]
        public void OrderNewConnections_Test_114()
        {

            var ordernewconnection = new OrderNewConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            ordernewconnection.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/OrderNewConnection");
            ordernewconnection.PickSmpfMpfDropdown("SIMSMPF");
            ordernewconnection.SimProvide("", "");
            ordernewconnection.AddressDropdown("");
            ordernewconnection.CheckAddressAvalibility.Click();
            ordernewconnection.SelectProductViaStockCode("BT-FTTP");
            ordernewconnection.SelectLayer3();
            ordernewconnection.OrderFormLayer3Dia();

            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));


        }

        [Test]
        public void OrderNewConnections_Test_115()
        {

            var ordernewconnection = new OrderNewConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            ordernewconnection.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/OrderNewConnection");
            ordernewconnection.PickSmpfMpfDropdown("SIMSMPF");
            ordernewconnection.SimProvide("KT1 3EG", "qwerty23321");
            ordernewconnection.AddressDropdown("");
            ordernewconnection.CheckAddressAvalibility.Click();
            ordernewconnection.SelectProductViaStockCode("BT-FTTC");
            ordernewconnection.SelectLayer3();

            Assert.AreEqual("The Linked Order Reference Number is invalid for a TalkTalk order. It should be of type SIM2.", driver.FindElement(By.CssSelector("#specific-error-msg > span")));
        }

        [Test]
        public void OrderNewConnections_Test_116()
        {

            var ordernewconnection = new OrderNewConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            ordernewconnection.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/OrderNewConnection");
            ordernewconnection.PickSmpfMpfDropdown("SIMSMPF");
            ordernewconnection.SimProvide("", "");
            ordernewconnection.AddressDropdown("");
            ordernewconnection.CheckAddressAvalibility.Click();
            ordernewconnection.SelectProductViaStockCode("TTB ADSL Premium");
            ordernewconnection.SelectLayer3();
            ordernewconnection.OrderFormLayer3Dia();

            Assert.AreEqual("", driver.FindElement(By.CssSelector("")));
        }

        [Test]
        public void OrderNewConnections_Test_117()
        {

            var ordernewconnection = new OrderNewConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            ordernewconnection.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/OrderNewConnection");
            ordernewconnection.PickSmpfMpfDropdown("SMPF");
            ordernewconnection.SMPF("", "");
            ordernewconnection.AddressDropdown("");
            ordernewconnection.CheckAddressAvalibility.Click();
            ordernewconnection.SelectProductViaStockCode("BT-ADSL2+");
            ordernewconnection.SelectLayer3();
            ordernewconnection.SelectContactTest();

            Assert.AreEqual("", driver.FindElement(By.CssSelector("#ContactNameLabel")));

        }

        [Test]
        public void OrderNewConnections_Test_118()
        {

            var ordernewconnection = new OrderNewConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            ordernewconnection.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/OrderNewConnection");
            ordernewconnection.PickSmpfMpfDropdown("SMPF");
            ordernewconnection.SMPF("", "");
            ordernewconnection.AddressDropdown("");
            ordernewconnection.CheckAddressAvalibility.Click();
            ordernewconnection.SelectProductViaStockCode("BT-ADSL2+");
            ordernewconnection.SelectLayer3();
            ordernewconnection.SelectContactTest2();

            Assert.AreEqual("", driver.FindElement(By.CssSelector("#ContactNameLabel")));

        }

        [Test]
        public void OrderNewConnections_Test_119()
        {

            var ordernewconnection = new OrderNewConnectionsPage(driver);
            driver.Navigate().GoToUrl(baseURL + "/Admin/UserManagement");
            ordernewconnection.ImpersonateABZ011();

            driver.Navigate().GoToUrl(baseURL + "/Provisioning/OrderNewConnection");
            ordernewconnection.PickSmpfMpfDropdown("SMPF");
            ordernewconnection.SMPF("", "");
            ordernewconnection.AddressDropdown("");
            ordernewconnection.CheckAddressAvalibility.Click();
            ordernewconnection.SelectProductViaStockCode("BT-ADSL2+");
            ordernewconnection.SelectLayer3();
            ordernewconnection.CreateNewContact();

            Assert.AreEqual("Contact Name: Test User", driver.FindElement(By.CssSelector("#ContactNameLabel")));
            ordernewconnection.VerifyNewContactDisplayed();

            Assert.AreEqual("Test", driver.FindElement(By.CssSelector("#selectContact-grid > tbody > tr:nth-child(4) > td:nth-child(1)")).Text);
            Assert.AreEqual("User", driver.FindElement(By.CssSelector("#selectContact-grid > tbody > tr:nth-child(4) > td:nth-child(2)")).Text);
         
            Assert.AreEqual("07745612345", driver.FindElement(By.CssSelector("#selectContact-grid > tbody > tr:nth-child(4) > td:nth-child(4)")).Text);
         
            Assert.AreEqual("test.user@email.com", driver.FindElement(By.CssSelector("#selectContact-grid > tbody > tr:nth-child(4) > td:nth-child(5)")).Text);
            ordernewconnection.DeleteNewContact();
        }
    }
}
