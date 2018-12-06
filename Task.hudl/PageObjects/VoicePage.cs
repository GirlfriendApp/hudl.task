using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;
using FluidOne.ClientTesting.Dash.Entities;
using FluidOne.ClientTesting.Dash.Tests.BaseTests;
using System.Threading;

namespace FluidOne.ClientTesting.Dash.PageObjects
{
    public class VoicePage

    {
        private IWebDriver _driver;




        //Mobile 

        [FindsBy(How = How.Id, Using = "template-toggle")]
        public IWebElement TemplateToggle { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div.col-xs-6.col-sm-3.form-group.pull-left.bulkEditHolder > input")]
        public IWebElement BulkEdit { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#ea67edbf-5bf8-45cc-8ce9-78f5049162d9 > label")]
        private IWebElement SelectAll { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#grid > table > thead > tr:nth-child(1) > th:nth-child(2)")]
        private IWebElement CLI { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#grid > table > thead > tr:nth-child(1) > th:nth-child(2) > a.k-grid-filter > span")]
        private IWebElement CLISearch { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#grid > table > thead > tr:nth-child(1) > th:nth-child(3)")]
        private IWebElement UserName { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#grid > table > thead > tr:nth-child(1) > th:nth-child(3) > a.k-grid-filter > span")]
        private IWebElement UserNameSearch { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#grid > table > thead > tr:nth-child(1) > th:nth-child(4)")]
        private IWebElement SiteName { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#grid > table > thead > tr:nth-child(1) > th:nth-child(4) > a.k-grid-filter > span")]
        private IWebElement SiteNameSearch { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#grid > table > thead > tr:nth-child(1) > th:nth-child(5)")]
        private IWebElement CostCentre { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#grid > table > thead > tr:nth-child(1) > th:nth-child(5) > a.k-grid-filter > span")]
        private IWebElement CostCentreSearch { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#grid > table > thead > tr:nth-child(1) > th:nth-child(6)")]
        private IWebElement ExtraCostCentre { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#grid > table > thead > tr:nth-child(1) > th:nth-child(6) > a.k-grid-filter > span")]
        private IWebElement ExtraCostCentreSearch { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#grid > table > thead > tr:nth-child(1) > th:nth-child(7)")]
        private IWebElement Service { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#grid > table > thead > tr:nth-child(1) > th:nth-child(7) > a.k-grid-filter > span")]
        private IWebElement ServiceSearch { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#grid > table > thead > tr:nth-child(1) > th:nth-child(8)")]
        private IWebElement ServiceCharge { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#grid > table > thead > tr:nth-child(1) > th:nth-child(8) > a.k-grid-filter > span")]
        private IWebElement ServiceChargeSearch { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#grid > table > thead > tr:nth-child(1) > th:nth-child(9) ")]
        private IWebElement ChargeDescription { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#grid > table > thead > tr:nth-child(1) > th:nth-child(9) > a.k-grid-filter")]
        private IWebElement ChargeDescriptionSearch { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#grid > table > tbody > tr:nth-child(1) > td.actionCol > a")]
        private IWebElement EditLine { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#grid > table > tbody > tr:nth-child(1) > td.actionCol > div > a")]
        private IWebElement QuickAction { get; set; }


        //edit line/bulk edit
        [FindsBy(How = How.Id, Using = "createUser")]
        private IWebElement CreateUser { get; set; }

        [FindsBy(How = How.Id, Using = "createCostCentre")]
        private IWebElement CreateCostCentre { get; set; }

        [FindsBy(How = How.Id, Using = "Description")]
        private IWebElement CreateUsername { get; set; }

        [FindsBy(How = How.Id, Using = "Name")]
        private IWebElement CreateCostCentreName { get; set; }


        //Modal window cancel & accept

        [FindsBy(How = How.Id, Using = "VoiceModal-Button")]
        private IWebElement AcceptSave { get; set; }

        [FindsBy(How = How.Id, Using = "VoiceModal-CloseBtn")]
        public IWebElement Cancel { get; set; }


        //Quick action

        [FindsBy(How = How.Id, Using = "simInput0")]
        private IWebElement SimSwapInput { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#simSwap0 > button")]
        private IWebElement SimSwapSubmit { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#lostStolen0 > button")]
        private IWebElement ReportLostStolen { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#openTicket0 > button")]
        private IWebElement RaiseTicket { get; set; }

        //Fixed Line
        [FindsBy(How = How.Id, Using = "bearerSpeed")]
        private IWebElement BearerSpeed { get; set; }

        //SIP
        [FindsBy(How = How.Id, Using = "serviceSpeed")]
        private IWebElement ServiceSpeed { get; set; }

        //Template management
        [FindsBy(How = How.CssSelector, Using = "#template-management-table > tbody > tr:nth-child(2) > td:nth-child(11) > a.edit-detail-btn.button-image.button-option-main-blue.pull-left")]
        private IWebElement EditTemplate { get; set; }

        [FindsBy(How = How.Id, Using = "TemplateName")]
        private IWebElement TemplateName { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#template-table > tbody > tr > td:nth-child(2) > label")]
        private IWebElement ActionCheckbox { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#template-management-table > tbody > tr > td:nth-child(3) > label")]
        private IWebElement ChargeDescriptionCheckbox { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#template-management-table > tbody > tr > td:nth-child(4) > label")]
        private IWebElement CLICheckbox { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#template-management-table > tbody > tr > td:nth-child(5) > label")]
        private IWebElement CostCentreCheckbox { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#template-management-table > tbody > tr > td:nth-child(6) > label")]
        private IWebElement ExCostCentreCheckbox { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#template-management-table > tbody > tr > td:nth-child(7) > label")]
        private IWebElement ServiceCheckbox { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#template-management-table > tbody > tr > td:nth-child(8) > label")]
        private IWebElement ServiceChargeCheckbox { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#template-management-table > tbody > tr > td:nth-child(9) > label")]
        private IWebElement ShortNameCheckbox { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#template-management-table > tbody > tr > td:nth-child(10) > label")]
        private IWebElement UsernameCheckbox { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#template-management-table > tbody > tr:nth-child(2) > td:nth-child(11) > a.delete-template-btn.button-image.button-option-main-blue.pull-right")]
        private IWebElement DeleteTemplate { get; set; }


        [FindsBy(How = How.CssSelector, Using = "div.col-xs-3.col-sm-3.col-md-3.col-lg-2.pull-right > input")]
        private IWebElement AddTemplate { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div.col-xs-5.col-sm-5.col-md-5.col-lg-3.pull-left > input")]
        private IWebElement TemplateAccountManger { get; set; }

        //telerik
        [FindsBy(How = How.CssSelector, Using = "body > div.k-animation-container > form > div:nth-child(1) > input:nth-child(3)")]
        private IWebElement FilterValue { get; set; }

        [FindsBy(How = How.CssSelector, Using = "body > div.k-animation-container > form > div:nth-child(1) > div:nth-child(7) > button.k-button.k-primary")]
        private IWebElement FilterBtn { get; set; }

        [FindsBy(How = How.CssSelector, Using = "body > div.k-animation-container > form > div:nth-child(1) > div:nth-child(7) > button:nth-child(2)")]
        private IWebElement ClearBtn { get; set; }

        public VoicePage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);

        }

        public void PickOptionFromUsernameDropdown(string option)
        {
            _driver.FindElement(By.CssSelector($"#SelectedUserNameID option[value='{option}']"), 30).Click();
        }

        public void PickOptionFromCostCentreDropdown(string option)
        {
            _driver.FindElement(By.CssSelector($"#SelectedCostCentreID option[value='{option}']"), 30).Click();
        }

        public void PickOptionFromExCostCentreDropdown(string option)
        {
            _driver.FindElement(By.CssSelector($"#SelectedCostCentre3ID option[value='{option}']"), 30).Click();
        }
        public void AllItemsPerPage()
        {
            _driver.FindElement(By.CssSelector($"#grid > div.k-pager-wrap.k-grid-pager.k-widget.k-floatwrap > span.k-pager-sizes .k-dropdown-wrap")).Click();
            Thread.Sleep(700);
            _driver.FindElement(By.CssSelector($"body > div.k-animation-container > div > div.k-list-scroller > ul > li:nth-child(5)")).Click();
        }



        public void ImpersonateCOS010()
        {

            var usermanagepage = new AdminPage(_driver);
            usermanagepage.PickOptionFromSeachDropdown("1");
            usermanagepage.SearchUser2("COS010");

        }

        public void ToggleTemplate()
        {
            TemplateToggle.Click();
            _driver.WaitForElementToDisplay(By.CssSelector("#VoiceModal > div > div"), 45);


        }

        public void ChangeTemplate()
        {
            _driver.FindElement(By.CssSelector("#SelectedID > option:nth-child(2)")).Click();
            AcceptSave.Click();

        }

        public void CreateNewTemplate(string templateName)
        {
            _driver.FindElement(By.CssSelector("#mobile-search-form > div > div > div.col-xs-12.col-sm-6 > span > a > strong")).Click();
            AddTemplate.Click();
            _driver.WaitForElementToDisplay(By.Id("VoiceModal-Title"), 30);
            TemplateName.ClickAndSendKeys(templateName);
            _driver.FindElement(By.CssSelector("#template-table > tbody > tr > td:nth-child(2) > label")).Click();
            AcceptSave.Click();


        }
        public void EditExistingTemplate(string templateName)
        {
            _driver.FindElement(By.CssSelector("#mobile-search-form > div > div > div.col-xs-12.col-sm-6 > span > a > strong")).Click();
            EditTemplate.Click();
            _driver.WaitForElementToDisplay(By.Id("VoiceModal-Title"), 30);
            TemplateName.Clear();
            TemplateName.ClickAndSendKeys(templateName);

            AcceptSave.Click();
        }

        public void UntickExistingTemplate()
        {
            _driver.FindElement(By.CssSelector("#mobile-search-form > div > div > div.col-xs-12.col-sm-6 > span > a > strong")).Click();
            EditTemplate.Click();
            _driver.WaitForElementToDisplay(By.Id("VoiceModal-Title"), 30);
            // _driver.FindElement(By.CssSelector("#template-table > tbody > tr > td:nth-child(3) > label")).Click();
            ChargeDescriptionCheckbox.Click();
            AcceptSave.Click();
        }
        public void TickExistingTemplate()
        {
            _driver.FindElement(By.CssSelector("#mobile-search-form > div > div > div.col-xs-12.col-sm-6 > span > a > strong")).Click();
            EditTemplate.Click();
            _driver.WaitForElementToDisplay(By.Id("VoiceModal-Title"), 30);
            //_driver.FindElement(By.CssSelector("#template-table > tbody > tr > td:nth-child(3) > label")).Click();
            ChargeDescriptionCheckbox.Click();
            AcceptSave.Click();
        }
        public void TickandUntick(string inputID, bool checkForTick = true)
        {
            //var chosenInput = _driver.FindElement(By.CssSelector(inputID));
            //chosenInput.Click();
            var chosenInputChecked = _driver.FindElement(By.CssSelector(inputID + ":checked"));
            if (checkForTick)
            {
                if (chosenInputChecked != null)
                {
                    //pass statement here
                    Console.WriteLine("PASS");
                }
                else
                {
                    //fail statement here
                    Console.WriteLine("Fail");
                }
            }
            else
            {
                if (chosenInputChecked == null)
                {
                    //pass statement here
                    Console.WriteLine("PASS");
                }
                else
                {
                    //fail statement here
                    Console.WriteLine("Fail");
                }
            }
        }



        public void DeleteExistingTemplate()
        {
            _driver.FindElement(By.CssSelector("#mobile-search-form > div > div > div.col-xs-12.col-sm-6 > span > a > strong")).Click();
            DeleteTemplate.Click();
            _driver.WaitForElementToDisplay(By.Id("VoiceModal-Title"), 30);
            AcceptSave.Click();


        }

        public void CliAscending()
        {
            CLI.Click();
        }
        public void CliDescending()
        {
            CLI.Click();
        }

        public void CliFilter(string selector, string value)
        {

            CLISearch.Click();
            Thread.Sleep(500);
            _driver.FindElement(By.CssSelector("body > div.k-animation-container > form > div:nth-child(1) > span:nth-child(2) > span")).Click();
            _driver.FindElement(By.CssSelector(selector)).Click();
            FilterValue.ClickAndSendKeys(value);
            FilterBtn.Click();

        }
        public void ClearCliFilter()
        {
            CLISearch.Click();
            Thread.Sleep(500);
            ClearBtn.Click();
        }
        public void UsernameAscending()
        {
            UserName.Click();
        }
        public void UsernameDescending()
        {
            UserName.Click();
        }

        public void UsernameFilter(string selector, string value)
        {

            UserNameSearch.Click();
            Thread.Sleep(500);
            _driver.FindElement(By.CssSelector("body > div.k-animation-container > form > div:nth-child(1) > span:nth-child(2) > span")).Click();
            _driver.FindElement(By.CssSelector(selector)).Click();
            FilterValue.ClickAndSendKeys(value);
            FilterBtn.Click();

        }

        public void ClearUsernameFilter()
        {
            UserNameSearch.Click();
            Thread.Sleep(500);
            ClearBtn.Click();
        }

        public void SiteNameAscending()
        {
            SiteName.Click();
        }
        public void SiteNameDescending()
        {
            SiteName.Click();
        }

        public void SiteNameFilter(string selector, string value)
        {

            SiteNameSearch.Click();

            _driver.FindElement(By.CssSelector("body > div.k-animation-container > form > div:nth-child(1) > span:nth-child(2) > span")).Click();
            _driver.FindElement(By.CssSelector(selector)).Click();
            FilterValue.ClickAndSendKeys(value);
            FilterBtn.Click();

        }

        public void ClearSiteNameFilter()
        {
            SiteNameSearch.Click();
            Thread.Sleep(500);
            ClearBtn.Click();
        }
        public void CostCentreAscending()
        {
            CostCentre.Click();
        }
        public void CostCentreDescending()
        {
            CostCentre.Click();
        }

        public void CostCentreFilter(string selector, string value)
        {

            CostCentreSearch.Click();
            Thread.Sleep(500);
            _driver.FindElement(By.CssSelector("body > div.k-animation-container > form > div:nth-child(1) > span:nth-child(2) > span")).Click();
            _driver.FindElement(By.CssSelector(selector)).Click();
            FilterValue.ClickAndSendKeys(value);
            FilterBtn.Click();

        }

        public void ClearCostCentreFilter()
        {
            CostCentreSearch.Click();
            Thread.Sleep(500);
            ClearBtn.Click();
        }
        public void ExCostCentreAscending()
        {
            ExtraCostCentre.Click();
        }
        public void ExCostCentreDescending()
        {
            ExtraCostCentre.Click();
        }

        public void ExCostCentreFilter(string selector, string value)
        {

            ExtraCostCentreSearch.Click();
            Thread.Sleep(700);
            _driver.FindElement(By.CssSelector("body > div.k-animation-container > form > div:nth-child(1) > span:nth-child(2) > span")).Click();
            _driver.FindElement(By.CssSelector(selector)).Click();
            FilterValue.ClickAndSendKeys(value);
            FilterBtn.Click();

        }

        public void ClearExCostCentreFilter()
        {
            ExtraCostCentreSearch.Click();
            Thread.Sleep(500);
            ClearBtn.Click();
        }
        public void ServiceAscending()
        {
            Service.Click();
        }
        public void ServiceDescending()
        {
            Service.Click();
        }

        public void ServiceFilter(string selector, string value)
        {

            ServiceSearch.Click();
            Thread.Sleep(700);
            _driver.FindElement(By.CssSelector("body > div.k-animation-container > form > div:nth-child(1) > span:nth-child(2) > span")).Click();
            _driver.FindElement(By.CssSelector(selector)).Click();
            FilterValue.ClickAndSendKeys(value);
            FilterBtn.Click();

        }

        public void ClearServiceFilter()
        {
            ServiceSearch.Click();
            Thread.Sleep(500);
            ClearBtn.Click();
        }
        public void ServiceChargeAscending()
        {
            ServiceCharge.Click();
        }
        public void ServiceChargeDescending()
        {
            ServiceCharge.Click();
        }

        public void ServiceChargeFilter(string selector, int value)
        {
            int number = (value);

            ServiceChargeSearch.Click();
            Thread.Sleep(700);
            _driver.FindElement(By.CssSelector("body > div.k-animation-container > form > div:nth-child(1) > span:nth-child(2) > span")).Click();
            _driver.FindElement(By.CssSelector(selector)).Click();
            _driver.FindElement(By.CssSelector("body > div.k-animation-container > form > div:nth-child(1) > span:nth-child(3) > span > input.k-formatted-value.k-input")).Click();
            _driver.FindElement(By.CssSelector("body > div.k-animation-container > form > div:nth-child(1) > span:nth-child(3) > span > input:nth-child(2)")).SendKeys("" + value);
            FilterBtn.Click();

        }

        public void ServiceChargeFilter()
        {
            ServiceChargeSearch.Click();
            Thread.Sleep(500);
            ClearBtn.Click();
        }

        public void ClearServiceChargeFilter()
        {
            ServiceChargeSearch.Click();
            Thread.Sleep(500);
            ClearBtn.Click();
        }

        public void ChargeDescriptionAscending()
        {
            ChargeDescription.Click();
        }
        public void ChargeDescriptionDescending()
        {
            ChargeDescription.Click();
        }

        public void ChargeDescriptionFilter(string selector, string value)
        {

            ChargeDescriptionSearch.Click();
            Thread.Sleep(700);
            _driver.FindElement(By.CssSelector("body > div.k-animation-container > form > div:nth-child(1) > span:nth-child(2) > span")).Click();
            _driver.FindElement(By.CssSelector(selector)).Click();
            FilterValue.ClickAndSendKeys(value);
            FilterBtn.Click();

        }

        public void ClearChargeDescriptionFilter()
        {
            ChargeDescriptionSearch.Click();
            Thread.Sleep(500);
            ClearBtn.Click();
        }

        public void SelectRecord()
        {
            _driver.FindElement(By.CssSelector("#grid > table > tbody > tr:nth-child(1) > td:nth-child(1) > label")).Click();
            _driver.FindElement(By.CssSelector("#grid > table > tbody > tr:nth-child(2) > td:nth-child(1) > label")).Click();
            _driver.FindElement(By.CssSelector("#grid > table > tbody > tr:nth-child(3) > td:nth-child(1) > label")).Click();
            _driver.FindElement(By.CssSelector("#grid > table > tbody > tr:nth-child(4) > td:nth-child(1) > label")).Click();


        }


        public void CheckboxVerification(string inputID, bool checkForTick = true)
        {
            //var chosenInput = _driver.FindElement(By.CssSelector(inputID));
            //chosenInput.Click();
            var checkedCount = int.Parse(_driver.FindElement(By.CssSelector(".bulkAmount")).Text);
            var chosenInputChecked = _driver.FindElements(By.CssSelector(inputID + ":checked"));
            var checkedAmount = chosenInputChecked.Count;

            if (checkedAmount == checkedCount)
            {
                //this is pass
            }
        }

        public void BulkEditUsername(string option)
        {
            _driver.FindElement(By.CssSelector("#grid > table > tbody > tr:nth-child(1) > td:nth-child(1) > label")).Click();
            _driver.FindElement(By.CssSelector("#grid > table > tbody > tr:nth-child(2) > td:nth-child(1) > label")).Click();
            _driver.FindElement(By.CssSelector("#grid > table > tbody > tr:nth-child(3) > td:nth-child(1) > label")).Click();
            _driver.FindElement(By.CssSelector("#grid > table > tbody > tr:nth-child(4) > td:nth-child(1) > label")).Click();

            BulkEdit.Click();
            _driver.WaitForElementToDisplay(By.Id("VoiceModal-Body"), 30);
            _driver.FindElement(By.CssSelector($"#SelectedUserNameID option[value='{option}']"), 30).Click();
            AcceptSave.Click();
            Thread.Sleep(8000);


        }
        public void BulkEditExCostCentre(string option)
        {
            _driver.FindElement(By.CssSelector("#grid > table > tbody > tr:nth-child(5) > td:nth-child(1) > label")).Click();
            _driver.FindElement(By.CssSelector("#grid > table > tbody > tr:nth-child(6) > td:nth-child(1) > label")).Click();
            _driver.FindElement(By.CssSelector("#grid > table > tbody > tr:nth-child(7) > td:nth-child(1) > label")).Click();
            _driver.FindElement(By.CssSelector("#grid > table > tbody > tr:nth-child(8) > td:nth-child(1) > label")).Click();

            BulkEdit.Click();
            _driver.WaitForElementToDisplay(By.Id("VoiceModal-Body"), 30);
            _driver.FindElement(By.CssSelector($"#selectedCostCentre3ID option[value='{option}']"), 30).Click();
            AcceptSave.Click();
            Thread.Sleep(8000);

        }
        public void BulkEditCostCentre(string option)
        {
            _driver.FindElement(By.CssSelector("#grid > table > tbody > tr:nth-child(9) > td:nth-child(1) > label")).Click();
            _driver.FindElement(By.CssSelector("#grid > table > tbody > tr:nth-child(10) > td:nth-child(1) > label")).Click();
            _driver.FindElement(By.CssSelector("#grid > table > tbody > tr:nth-child(11) > td:nth-child(1) > label")).Click();
            _driver.FindElement(By.CssSelector("#grid > table > tbody > tr:nth-child(12) > td:nth-child(1) > label")).Click();

            BulkEdit.Click();
            _driver.WaitForElementToDisplay(By.Id("VoiceModal-Body"), 30);
            _driver.FindElement(By.CssSelector($"#selectedCostCentreID option[value='{option}']"), 30).Click();
            AcceptSave.Click();
            Thread.Sleep(8000);

        }
        public void EditUsername(string option)
        {
            // _driver.FindElement(By.CssSelector("#grid > table > tbody > tr:nth-child(1) > td.actionCol > a")).Click();


            EditLine.Click();
            _driver.WaitForElementToDisplay(By.Id("VoiceModal-Body"), 30);
            _driver.FindElement(By.CssSelector($"#SelectedUserNameID option[value='{option}']"), 30).Click();
            AcceptSave.Click();
            Thread.Sleep(8000);


        }
        public void EditExCostCentre(string option)
        {
            //_driver.FindElement(By.CssSelector("#grid > table > tbody > tr:nth-child(1) > td.actionCol > a")).Click();


            EditLine.Click();
            _driver.WaitForElementToDisplay(By.Id("VoiceModal-Body"), 30);
            _driver.FindElement(By.CssSelector($"#SelectedCostCentre3ID option[value='{option}']"), 30).Click();
            AcceptSave.Click();
            Thread.Sleep(8000);

        }
        public void EditCostCentre(string option)
        {
            // _driver.FindElement(By.CssSelector("#grid > table > tbody > tr:nth-child(1) > td.actionCol > a")).Click();

            EditLine.Click();
            _driver.WaitForElementToDisplay(By.Id("VoiceModal-Body"), 30);
            _driver.FindElement(By.CssSelector($"#SelectedCostCentreID option[value='{option}']"), 30).Click();
            AcceptSave.Click();
            Thread.Sleep(8000);

        }

        public void BulkEditCancel()
        {
            _driver.FindElement(By.CssSelector("#grid > table > tbody > tr:nth-child(1) > td:nth-child(1) > label")).Click();
            _driver.FindElement(By.CssSelector("#grid > table > tbody > tr:nth-child(2) > td:nth-child(1) > label")).Click();
            _driver.FindElement(By.CssSelector("#grid > table > tbody > tr:nth-child(3) > td:nth-child(1) > label")).Click();
            _driver.FindElement(By.CssSelector("#grid > table > tbody > tr:nth-child(4) > td:nth-child(1) > label")).Click();

            BulkEdit.Click();
            _driver.WaitForElementToDisplay(By.Id("VoiceModal-Body"), 30);

            Cancel.Click();
            Thread.Sleep(8000);


        }
        public void EditCancel()
        {
            _driver.FindElement(By.CssSelector("#grid > table > tbody > tr:nth-child(16) > td:nth-child(1) > label")).Click();


            EditLine.Click();
            _driver.WaitForElementToDisplay(By.Id("VoiceModal-Body"), 30);

            Cancel.Click();
            Thread.Sleep(8000);
        }

        public void EditCreateNewUser(string newUsername)
        {
            //_driver.FindElement(By.CssSelector("#grid > table > tbody > tr:nth-child(1) > td:nth-child(1) > label")).Click();

            EditLine.Click();
            _driver.WaitForElementToDisplay(By.Id("VoiceModal-Body"), 30);
            CreateUser.Click();
            Thread.Sleep(1000);
            CreateUsername.ClickAndSendKeys(newUsername);
            AcceptSave.Click();
            Thread.Sleep(4000);
            CliAscending();
            EditLine.Click();
            _driver.WaitForElementToDisplay(By.Id("VoiceModal-Body"), 30);

        }

        public void EditVerifyUsername(string option)
        {
            // _driver.FindElement(By.CssSelector("#grid > table > tbody > tr:nth-child(1) > td.actionCol > a")).Click();


            //EditLine.Click();
            //_driver.WaitForElementToDisplay(By.Id("VoiceModal-Body"), 30);
            _driver.FindElement(By.CssSelector($"#SelectedUserNameID option[value='{option}']"), 30).Click();
           


        }

        public void EditCreateNewCostCentre(string newCostCentre)
        {
            //_driver.FindElement(By.CssSelector("#grid > table > tbody > tr:nth-child(1) > td:nth-child(1) > label")).Click();

            EditLine.Click();
            _driver.WaitForElementToDisplay(By.Id("VoiceModal-Body"), 30);
            CreateCostCentre.Click();
            Thread.Sleep(1000);
            CreateCostCentreName.ClickAndSendKeys(newCostCentre);
            AcceptSave.Click();
            Thread.Sleep(4000);
            CliAscending();
            EditLine.Click();
            _driver.WaitForElementToDisplay(By.Id("VoiceModal-Body"), 30);

        }

        public void EditVerifyCostCentre(string option)
        {
            // _driver.FindElement(By.CssSelector("#grid > table > tbody > tr:nth-child(1) > td.actionCol > a")).Click();


            //EditLine.Click();
            //_driver.WaitForElementToDisplay(By.Id("VoiceModal-Body"), 30);
            _driver.FindElement(By.CssSelector($"#SelectedCostCentre3ID option[value='{option}']"), 30).Click();



        }
        


        public bool ClickAndCheckCli(IWebElement editBtn)
        {
            _driver.WaitForElementToDisplay(By.Id("VoiceModal-Body"), 30);
            var chosenCLI = editBtn.GetAttribute("value");//Get value for each button from attribute
            editBtn.Click();
            var popUpCLI = _driver.FindElement(By.CssSelector("#VoiceModal-Body")).Text;
            if (popUpCLI.Contains(chosenCLI)) //Does the value match -- string = string
            {
                return true; //send this back to line that called it
            }
            else
            {
                return false; //send this back to line that called it
            }
        }

            public bool ClickAndCheckCostCentre(IWebElement costCentre)
            {
            _driver.WaitForElementToDisplay(By.Id("VoiceModal-Body"), 30);
            var chosenCostCentre = costCentre.Text;//Get value for each button from attribute
              
                var popUpCostCentre = _driver.FindElement(By.CssSelector("#VoiceModal-Body")).Text;
             if (popUpCostCentre.Contains(chosenCostCentre)) //Does the value match -- string = string
                {
                    return true; //send this back to line that called it
                }
                else
                {
                    return false; //send this back to line that called it
                }


            }


        
    }
}
