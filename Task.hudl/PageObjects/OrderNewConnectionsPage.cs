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

    public class OrderNewConnectionsPage
    {

        private IWebDriver _driver;

        public OrderNewConnectionsPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);

        }

        [FindsBy(How = How.CssSelector, Using = "#Postcode")]
        private IWebElement Postcode { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#DSL")]
        private IWebElement DSL { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#LORN")]
        private IWebElement LORN { get; set; }


        [FindsBy(How = How.CssSelector, Using = "#get-address-button")]
        private IWebElement GetAddressBtn { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#check-address-button")]
        public IWebElement CheckAddressAvalibility { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#AddressSearch")]
        private IWebElement AddressFilter { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#manual-address-link")]
        private IWebElement ManualAddressEntry { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#PremisesIdentifier")]
        private IWebElement BuildingEntry { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#ThroughfareNumber")]
        private IWebElement NumberEntry { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#ThroughfareName")]
        private IWebElement StreetEntry { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#City")]
        private IWebElement CityEntry { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#manual-address-link-back > a")]
        private IWebElement AddressFromList { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#layer-level-area > label:nth-child(2)")]
        private IWebElement Layer2 { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#layer-level-area > label:nth-child(5)")]
        private IWebElement Layer3 { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#select-product-btn")]
        private IWebElement SelectProductBtn { get; set; }


        [FindsBy(How = How.CssSelector, Using = "#POReference")]
        private IWebElement PORef { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#CircuitNote")]
        private IWebElement CircuitNote { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#SiteReference")]
        private IWebElement SiteRef { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#OrderConnectionSelectContactDIV > div.unit.col-xs-12.col-sm-12.col-md-12.col-lg-12 > div > a")]
        private IWebElement ContactBtn { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#orderconnection-step-3 > div.orderconnection > div.col-xs-12.col-sm-12.col-md-12.col-lg-12 > div:nth-child(6) > div > label")]
        private IWebElement TrafficWeightingCheckbox { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#Layer3RadiusUsername")]
        private IWebElement RadiusUsername { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#Layer3RadiusPassword")]
        private IWebElement RadiusPassword { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#Layer3VM_Layer3_VCORE_WanIPAddress")]
        private IWebElement DiaWanIP { get; set; }


        [FindsBy(How = How.CssSelector, Using = "#Layer3PwanNetworkAddress")]
        private IWebElement PwanLanIP { get; set; }


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

        [FindsBy(How = How.CssSelector, Using = "#CustomerConsentDIV > label")]
        private IWebElement CustomerConstent { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#OrderButton")]
        private IWebElement OrderBtn { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#appointment-area > div:nth-child(2) > div > label")]
        private IWebElement SelfInstall { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#BookAppointmentButton")]
        private IWebElement BookAptBtn { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#BookAppointmentButton")]
        private IWebElement CreateContact { get; set; }



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

        public void PickSmpfMpfDropdown(string option)
        {
            _driver.FindElement(By.CssSelector($"#LineType option[value='{option}']"), 30).Click();
        }

        public void MpfDropdown(string option)
        {
            _driver.FindElement(By.CssSelector($"#OperationType option[value='{option}']"), 30).Click();
        }


        public void AddressDropdown(string option)
        {
            _driver.FindElement(By.CssSelector($"#AddressSelect option[value='{option}']"), 30).Click();
        }

        public void CareLevelDropdown(string option)
        {
            _driver.FindElement(By.CssSelector($"#CareLevel option[value='{option}']"), 30).Click();
        }

        public void StabilityOptionDropdown(string option)
        {
            _driver.FindElement(By.CssSelector($"#StabilityOption option[value='{option}']"), 30).Click();
        }

        public void SpeedDropdown(string option)
        {
            _driver.FindElement(By.CssSelector($"#Speed option[value='{option}']"), 30).Click();
        }

        public void RealmDropdown(string option)
        {
            _driver.FindElement(By.CssSelector($"#Layer3Realm option[value='{option}']"), 30).Click();
        }

        public void TransitOptionDropdown(string option)
        {
            _driver.FindElement(By.CssSelector($"#Layer3TransitOption option[value='{option}']"), 30).Click();
        }

        public void TitleDropdown(string option)
        {
            _driver.FindElement(By.CssSelector($"#EndUserTitle option[value='{option}']"), 30).Click();
        }

        public void SelectProductViaStockCode(string StockCode)
        {
            _driver.FindElement(By.CssSelector($"#ordernewconnection-step2-grid span[data-stockcode*='{StockCode}']"), 30).Click();
        }

        public void SelectContact()
        {
            ContactBtn.Click();
            _driver.WaitForElementToDisplay(By.CssSelector(""), 45);
            _driver.FindElement(By.CssSelector("#selectContact-grid > tbody > tr:nth-child(1) > td:nth-child(7) > div > a")).Click();

        }

        public void SMPF(string postcode, string dsl)
        {
            Postcode.ClickAndSendKeys(postcode);
            DSL.ClickAndSendKeys(dsl);
            GetAddressBtn.Click();

        }


        public void MPFNewProvide(string postcode)
        {
            Postcode.ClickAndSendKeys(postcode);
            GetAddressBtn.Click();

        }



        public void MPFMigration(string postcode, string dsl)
        {
            Postcode.ClickAndSendKeys(postcode);
            DSL.ClickAndSendKeys(dsl);
            GetAddressBtn.Click();

        }

        public void SimProvide(string postcode, string lorn)
        {
            Postcode.ClickAndSendKeys(postcode);
            LORN.ClickAndSendKeys(lorn);
            GetAddressBtn.Click();

        }



        public void SelectLayer2()
        {
            Layer2.Click();
            SelectProductBtn.Click();
        }

        public void SelectLayer3()
        {
            Layer3.Click();
            SelectProductBtn.Click();
        }

        public void OrderFormLayer2()
        {
            PORef.ClickAndSendKeys("Qwerty123");
            SelectContact();
            CustomerConstent.Click();
            OrderBtn.Click();
        }

        public void OrderFormLayer3Dia()
        {
            PORef.ClickAndSendKeys("Qwerty123");
            SelectContact();
            TransitOptionDropdown("DIA");
            DiaWanIP.ClickAndSendKeys("NEED TEST DATA");
            FirstName.ClickAndSendKeys("Test");
            LastName.ClickAndSendKeys("User");
            PrimaryPhoneNumber.ClickAndSendKeys("012345678920");
            Email.ClickAndSendKeys("test@user.com");
            CustomerConstent.Click();
            OrderBtn.Click();
        }

        public void OrderFormLayer3PwanMpls()
        {
            PORef.ClickAndSendKeys("Qwerty123");
            SelectContact();
            TransitOptionDropdown("PWAN/MPLS");
            PwanLanIP.ClickAndSendKeys("NEED TEST DATA");
            FirstName.ClickAndSendKeys("Test");
            LastName.ClickAndSendKeys("User");
            PrimaryPhoneNumber.ClickAndSendKeys("012345678920");
            Email.ClickAndSendKeys("test@user.com");
            CustomerConstent.Click();
            OrderBtn.Click();
        }
        public void OrderFormLayer2NoPoRef()
        {
            SelectContact();
            CustomerConstent.Click();
            OrderBtn.Click();
        }

        public void OrderFormLayer3NoPoRef()
        {

            SelectContact();
            TransitOptionDropdown("DIA");
            DiaWanIP.ClickAndSendKeys("NEED TEST DATA");
            FirstName.ClickAndSendKeys("Test");
            LastName.ClickAndSendKeys("User");
            PrimaryPhoneNumber.ClickAndSendKeys("012345678920");
            Email.ClickAndSendKeys("test@user.com");
            CustomerConstent.Click();
            OrderBtn.Click();
        }


        public void OrderFormLayer2NoContact()
        {
            PORef.ClickAndSendKeys("Qwerty123");
            CustomerConstent.Click();
            OrderBtn.Click();
        }

        public void OrderFormLayer3NoContact()
        {
            PORef.ClickAndSendKeys("Qwerty123");

            TransitOptionDropdown("DIA");
            DiaWanIP.ClickAndSendKeys("NEED TEST DATA");
            FirstName.ClickAndSendKeys("Test");
            LastName.ClickAndSendKeys("User");
            PrimaryPhoneNumber.ClickAndSendKeys("012345678920");
            Email.ClickAndSendKeys("test@user.com");
            CustomerConstent.Click();
            OrderBtn.Click();
        }


        public void OrderFormLayer3NoEndUsers()
        {
            PORef.ClickAndSendKeys("Qwerty123");
            SelectContact();
            TransitOptionDropdown("DIA");
            DiaWanIP.ClickAndSendKeys("NEED TEST DATA");

            CustomerConstent.Click();
            OrderBtn.Click();
        }
        public void OrderFormLayer2NoConsent()
        {
            PORef.ClickAndSendKeys("Qwerty123");
            SelectContact();

            OrderBtn.Click();
        }

        public void OrderFormLayer3NoConsent()
        {
            PORef.ClickAndSendKeys("Qwerty123");
            SelectContact();
            TransitOptionDropdown("DIA");
            DiaWanIP.ClickAndSendKeys("NEED TEST DATA");
            FirstName.ClickAndSendKeys("Test");
            LastName.ClickAndSendKeys("User");
            PrimaryPhoneNumber.ClickAndSendKeys("012345678920");
            Email.ClickAndSendKeys("test@user.com");

            OrderBtn.Click();
        }

        public void OrderFormLayer3NoConsentADSL2()
        {
            PORef.ClickAndSendKeys("Qwerty123");
            SelectContact();
            TransitOptionDropdown("DIA");
            DiaWanIP.ClickAndSendKeys("NEED TEST DATA");


            OrderBtn.Click();
        }
        public void OrderFormLayer3NoContactADSL2()
        {
            PORef.ClickAndSendKeys("Qwerty123");

            TransitOptionDropdown("DIA");
            DiaWanIP.ClickAndSendKeys("NEED TEST DATA");

            CustomerConstent.Click();
            OrderBtn.Click();
        }

        public void OrderFormLayer3NoPoRefASDL2()
        {

            SelectContact();
            TransitOptionDropdown("DIA");
            DiaWanIP.ClickAndSendKeys("NEED TEST DATA");

            CustomerConstent.Click();
            OrderBtn.Click();
        }


        public void BookAppointment()
        {
            DateTime newdate = DateTime.Today.AddMonths(1).AddDays(3);
            BookAptBtn.ClickAndSendKeys(newdate.ToShortDateString());
        }

        public void OrderFormLayer3BookApt()
        {
            PORef.ClickAndSendKeys("Qwerty123");
            SelectContact();
            BookAppointment();
            TransitOptionDropdown("DIA");
            DiaWanIP.ClickAndSendKeys("NEED TEST DATA");
            FirstName.ClickAndSendKeys("Test");
            LastName.ClickAndSendKeys("User");
            PrimaryPhoneNumber.ClickAndSendKeys("012345678920");
            Email.ClickAndSendKeys("test@user.com");
            CustomerConstent.Click();
            OrderBtn.Click();
        }

        public void OrderFormLayer3SelfInstall()
        {
            PORef.ClickAndSendKeys("Qwerty123");
            SelectContact();
            SelfInstall.Click();
            TransitOptionDropdown("DIA");
            DiaWanIP.ClickAndSendKeys("NEED TEST DATA");
            FirstName.ClickAndSendKeys("Test");
            LastName.ClickAndSendKeys("User");
            PrimaryPhoneNumber.ClickAndSendKeys("012345678920");
            Email.ClickAndSendKeys("test@user.com");
            CustomerConstent.Click();
            OrderBtn.Click();
        }


        public void SelectContactTest()
        {
            SelectContact();
        }

        public void SelectContactTest2()
        {
            SelectContact();
            ContactBtn.Click();
            _driver.WaitForElementToDisplay(By.CssSelector("#contactModal > div > div"), 45);
            _driver.FindElement(By.CssSelector("#selectContact-grid > tbody > tr:nth-child(3) > td:nth-child(7) > div > a")).Click();
        }

        public void CreateNewContact()
        {
            SelectContact();
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


       
    }
}

