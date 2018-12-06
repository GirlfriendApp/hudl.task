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

    public class LiveConnectionsPage
    {

        private IWebDriver _driver;

        public LiveConnectionsPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);

        }
        [FindsBy(How = How.CssSelector, Using = "#telerik-div > table > tbody > tr:nth-child(70) > td:nth-child(12) > div > a")]
        private IWebElement Editbtn { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#EditReferenceModal-Button")]
        private IWebElement Save { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#EditSiteReference")]
        private IWebElement SiteRef { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#EditCircuitNote")]
        private IWebElement CircuitNote { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#EditPOReference")]
        private IWebElement PoRef { get; set; }

        [FindsBy(How = How.CssSelector, Using = "**********")]
        private IWebElement DetailsBtn { get; set; }

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

        public void EditPOref(string newRef)
        {
            Editbtn.Click();
            _driver.WaitForElementToDisplay(By.CssSelector("#EditReferenceModal > div > div"), 45);
            
            PoRef.Clear();
            PoRef.ClickAndSendKeys(newRef);
            Save.Click();
            Thread.Sleep(4000);
            Editbtn.Click();
            _driver.WaitForElementToDisplay(By.CssSelector("#EditReferenceModal > div > div"), 45);

        }

        public void EditSiteRef(string newRef)
        {
            Editbtn.Click();
            _driver.WaitForElementToDisplay(By.CssSelector("#EditReferenceModal > div > div"), 45);

            SiteRef.Clear();
            SiteRef.ClickAndSendKeys(newRef);
            Save.Click();
            Thread.Sleep(4000);
            Editbtn.Click();
            _driver.WaitForElementToDisplay(By.CssSelector("#EditReferenceModal > div > div"), 45);

        }

        public void EditCircuitNote(string newCircuitNote)
        {
            Editbtn.Click();
            _driver.WaitForElementToDisplay(By.CssSelector("#EditReferenceModal > div > div"), 45);

           CircuitNote.Clear();
           CircuitNote.ClickAndSendKeys(newCircuitNote);
            Save.Click();
            Thread.Sleep(4000);
            Editbtn.Click();
            _driver.WaitForElementToDisplay(By.CssSelector("#EditReferenceModal > div > div"), 45);

        }

        public void ClickDetailsBtn ()
        {
            DetailsBtn.Click();

        }

    }
}
