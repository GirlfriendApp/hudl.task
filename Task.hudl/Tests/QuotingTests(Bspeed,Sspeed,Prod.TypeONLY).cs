using System;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Linq;
using NUnit.Framework.Interfaces;
using FluidOne.ClientTesting.Dash.Tests.BaseTests;

namespace FluidOne.ClientTesting.Dash.PageObjects
{

    [TestFixture(typeof(Firefox))]
    [TestFixture(typeof(InternetExplorer))]
    [TestFixture(typeof(Chrome))]
    [TestFixture(typeof(Edge))]
    public class BuildQuotes<T> : BaseTest<T> where T : IWebDriver, new()
    {
       

        [SetUp]
        public void setup()
        {

            var login = new LoginPage(driver);
            driver.FindElement(By.CssSelector("body > div.cookieSection > div > button")).Click();
            login.Login(accountCode, email, password);
        }

        //  General Orders
        [TestCase("10", "100", "virtual1", "DIA")]
        [TestCase("10", "100", "virgin_media", "NNI")]
        [TestCase("10", "100", "talk_talk_ethernet", "PWAN")]
        [TestCase("20", "100", "virtual1", "DIA")]
        [TestCase("20", "100", "virgin_media", "NNI")]
        [TestCase("20", "100", "talk_talk_ethernet", "PWAN")]
        [TestCase("30", "100", "virtual1", "DIA")]
        [TestCase("30", "100", "virgin_media", "NNI")]
        [TestCase("30", "100", "talk_talk_ethernet", "PWAN")]
        [TestCase("40", "100", "virtual1", "DIA")]
        [TestCase("40", "100", "virgin_media", "NNI")]
        [TestCase("40", "100", "talk_talk_ethernet", "PWAN")]
        [TestCase("50", "100", "virtual1", "DIA")]
        [TestCase("50", "100", "virgin_media", "NNI")]
        [TestCase("50", "100", "talk_talk_ethernet", "PWAN")]
        [TestCase("60", "100", "virtual1", "DIA")]
        [TestCase("60", "100", "virgin_media", "NNI")]
        [TestCase("60", "100", "talk_talk_ethernet", "PWAN")]
        [TestCase("70", "100", "virtual1", "DIA")]
        [TestCase("70", "100", "virgin_media", "NNI")]
        [TestCase("70", "100", "talk_talk_ethernet", "PWAN")]
        [TestCase("80", "100", "virtual1", "DIA")]
        [TestCase("80", "100", "virgin_media", "NNI")]
        [TestCase("80", "100", "talk_talk_ethernet", "PWAN")]
        [TestCase("90", "100", "virtual1", "DIA")]
        [TestCase("90", "100", "virgin_media", "NNI")]
        [TestCase("90", "100", "talk_talk_ethernet", "PWAN")]
        [TestCase("100", "100", "virtual1", "DIA")]
        [TestCase("100", "100", "virgin_media", "NNI")]
        [TestCase("100", "100", "talk_talk_ethernet", "PWAN")]
        [TestCase("100", "1000", "virtual1", "DIA")]
        [TestCase("100", "1000", "virgin_media", "NNI")]
        [TestCase("100", "1000", "talk_talk_ethernet", "PWAN")]
        [TestCase("200", "1000", "virtual1", "DIA")]
        [TestCase("200", "1000", "virgin_media", "NNI")]
        [TestCase("200", "1000", "talk_talk_ethernet", "PWAN")]
        [TestCase("300", "1000", "virtual1", "DIA")]
        [TestCase("300", "1000", "virgin_media", "NNI")]
        [TestCase("300", "1000", "talk_talk_ethernet", "PWAN")]
        [TestCase("400", "1000", "virtual1", "DIA")]
        [TestCase("400", "1000", "virgin_media", "NNI")]
        [TestCase("400", "1000", "talk_talk_ethernet", "PWAN")]
        [TestCase("500", "1000", "virtual1", "DIA")]
        [TestCase("500", "1000", "virgin_media", "NNI")]
        [TestCase("500", "1000", "talk_talk_ethernet", "PWAN")]
        [TestCase("600", "1000", "virtual1", "DIA")]
        [TestCase("600", "1000", "virgin_media", "NNI")]
        [TestCase("600", "1000", "talk_talk_ethernet", "PWAN")]
        [TestCase("700", "1000", "virtual1", "DIA")]
        [TestCase("700", "1000", "virgin_media", "NNI")]
        [TestCase("700", "1000", "talk_talk_ethernet", "PWAN")]
        [TestCase("800", "1000", "virtual1", "DIA")]
        [TestCase("800", "1000", "virgin_media", "NNI")]
        [TestCase("80", "1000", "talk_talk_ethernet", "PWAN")]
        [TestCase("900", "1000", "virtual1", "DIA")]
        [TestCase("900", "1000", "virgin_media", "NNI")]
        [TestCase("900", "1000", "talk_talk_ethernet", "PWAN")]
        [TestCase("1000", "1000", "virtual1", "DIA")]
        [TestCase("1000", "1000", "virgin_media", "NNI")]
        [TestCase("1000", "1000", "talk_talk_ethernet", "PWAN")]

        //  EoD Orders

        [TestCase("10", "100", "sky_business_sdn", "DIA")]
        [TestCase("10", "100", "sky_business_sdn", "NNI")]
        [TestCase("10", "100", "sky_business_sdn", "PWAN")]
        [TestCase("20", "100", "sky_business_sdn", "DIA")]
        [TestCase("20", "100", "sky_business_sdn", "NNI")]
        [TestCase("20", "100", "sky_business_sdn", "PWAN")]
        [TestCase("30", "100", "sky_business_sdn", "DIA")]
        [TestCase("30", "100", "sky_business_sdn", "NNI")]
        [TestCase("30", "100", "sky_business_sdn", "PWAN")]
        [TestCase("40", "100", "sky_business_sdn", "DIA")]
        [TestCase("40", "100", "sky_business_sdn", "NNI")]
        [TestCase("40", "100", "sky_business_sdn", "PWAN")]
        [TestCase("50", "100", "sky_business_sdn", "DIA")]
        [TestCase("50", "100", "sky_business_sdn", "NNI")]
        [TestCase("50", "100", "sky_business_sdn", "PWAN")]
        [TestCase("60", "100", "sky_business_sdn", "DIA")]
        [TestCase("60", "100", "sky_business_sdn", "NNI")]
        [TestCase("60", "100", "sky_business_sdn", "PWAN")]
        [TestCase("70", "100", "sky_business_sdn", "DIA")]
        [TestCase("70", "100", "sky_business_sdn", "NNI")]
        [TestCase("70", "100", "sky_business_sdn", "PWAN")]
        [TestCase("80", "100", "sky_business_sdn", "DIA")]
        [TestCase("80", "100", "sky_business_sdn", "NNI")]
        [TestCase("80", "100", "sky_business_sdn", "PWAN")]
        [TestCase("90", "100", "sky_business_sdn", "DIA")]
        [TestCase("90", "100", "sky_business_sdn", "NNI")]
        [TestCase("90", "100", "sky_business_sdn", "PWAN")]
        [TestCase("100", "100", "sky_business_sdn", "DIA")]
        [TestCase("100", "100", "sky_business_sdn", "NNI")]
        [TestCase("100", "100", "sky_business_sdn", "PWAN")]
        [TestCase("100", "1000", "sky_business_sdn", "DIA")]
        [TestCase("100", "1000", "sky_business_sdn", "NNI")]
        [TestCase("100", "1000", "sky_business_sdn", "PWAN")]
        [TestCase("200", "1000", "sky_business_sdn", "DIA")]
        [TestCase("200", "1000", "sky_business_sdn", "NNI")]
        [TestCase("200", "1000", "sky_business_sdn", "PWAN")]
        [TestCase("300", "1000", "sky_business_sdn", "DIA")]
        [TestCase("300", "1000", "sky_business_sdn", "NNI")]
        [TestCase("300", "1000", "sky_business_sdn", "PWAN")]
        [TestCase("400", "1000", "sky_business_sdn", "DIA")]
        [TestCase("400", "1000", "sky_business_sdn", "NNI")]
        [TestCase("400", "1000", "sky_business_sdn", "PWAN")]
        [TestCase("500", "1000", "sky_business_sdn", "DIA")]
        [TestCase("500", "1000", "sky_business_sdn", "NNI")]
        [TestCase("500", "1000", "sky_business_sdn", "PWAN")]
        [TestCase("600", "1000", "sky_business_sdn", "DIA")]
        [TestCase("600", "1000", "sky_business_sdn", "NNI")]
        [TestCase("600", "1000", "sky_business_sdn", "PWAN")]
        [TestCase("700", "1000", "sky_business_sdn", "DIA")]
        [TestCase("700", "1000", "sky_business_sdn", "NNI")]
        [TestCase("700", "1000", "sky_business_sdn", "PWAN")]
        [TestCase("800", "1000", "sky_business_sdn", "DIA")]
        [TestCase("800", "1000", "sky_business_sdn", "NNI")]
        [TestCase("800", "1000", "sky_business_sdn", "PWAN")]
        [TestCase("900", "1000", "sky_business_sdn", "DIA")]
        [TestCase("900", "1000", "sky_business_sdn", "NNI")]
        [TestCase("900", "1000", "sky_business_sdn", "PWAN")]
        [TestCase("1000", "1000", "sky_business_sdn", "DIA")]
        [TestCase("1000", "1000", "sky_business_sdn", "NNI")]
        [TestCase("1000", "1000", "sky_business_sdn", "PWAN")]
        public void Quote_WholeProcess_Success(string serviceSpeed, string bearerSpeed, string provider, string orderType)
        {
            // page 0

            var usermanagepage = new AdminPage(driver);
            usermanagepage.PickOptionFromSeachDropdown("1");
            usermanagepage.SearchABZ011("ABZ011");
            driver.Navigate().GoToUrl(baseURL + "/Quotes/Build");
          

            // page 1
            driver.FindElement(By.Id("Postcode")).ClickAndSendKeys("SE145BA");
            driver.FindElement(By.CssSelector($"#bearerSpeed option[value='{bearerSpeed}']")).Click();
            driver.FindElement(By.CssSelector($"#serviceSpeed option[value='{serviceSpeed}']")).Click();
            driver.FindElement(By.Id("btnAddSite")).Click();

            // page 2, type and provider selection
            if (orderType == "NNI")
            {
                driver.FindElement(By.CssSelector("#nni-area > label"), waitPeriod).Click();
            }
            else if (orderType == "PWAN")
            {
                driver.FindElement(By.CssSelector("#mpls-area > label"), waitPeriod).Click();
            }
            driver.FindElement(By.Id("btnGenerateQuote"), waitPeriod).Click();

            // check for the provider expected 
            driver.WaitForElementToDisplay(By.CssSelector($"td[data-provider=\"{provider}\"] > a"), 60, $"Provider: {provider} never found");
            driver.FindElement(By.CssSelector($"td[data-provider=\"{provider}\"] > a")).Click();

            // PAGE 3
            driver.FindElement(By.Id("CompanyName"), 60).ClickAndSendKeys("Qwerty");
            driver.FindElement(By.Id("FloorNumber")).ClickAndSendKeys("Qwerty");
            driver.FindElement(By.Id("AccessInformation")).ClickAndSendKeys("Qwerty");
            driver.FindElement(By.Id("RoomUnit")).ClickAndSendKeys("Qwerty");
            driver.FindElement(By.Id("RackLocation")).ClickAndSendKeys("Qwerty");

            driver.FindElements(By.CssSelector(".select-contacts a"), waitPeriod).FirstOrDefault(x => x.Displayed).Click();
            driver.WaitForElementToDisplay(By.Id("selectContactView"), 60);
            driver.FindElements(By.CssSelector("#selectContactView tbody td a"), 60).First(x => x.Displayed).Click();


            driver.FindElements(By.CssSelector("input.button-action-secondary[value=\"Next\"]"), waitPeriod).First(x => x.Displayed).Click();

            if (orderType == "DIA" || orderType == "PWAN")
            {
                driver.FindElements(By.CssSelector("input.button-action-secondary[value=\"Next\"]"), waitPeriod).First(x => x.Displayed).Click();
            }

            driver.FindElement(By.Id("SiteReference"), waitPeriod).ClickAndSendKeys("Qwerty123");

            try
            {
                if (bearerSpeed == "1000")
                {
                    driver.FindElement(By.CssSelector($"#SelectedConnectorTypeID option[value='1']"), waitPeriod).Click();
                }
            }
            catch (Exception e) { } // we don't always have this option 

            driver.FindElements(By.CssSelector(".select-contacts a"), waitPeriod).FirstOrDefault(x => x.Displayed).Click();
            driver.WaitForElementToDisplay(By.Id("selectContactView"), waitPeriod);
            driver.FindElements(By.CssSelector("#selectContactView tbody td a"), waitPeriod).First(x => x.Displayed).Click();

            driver.FindElements(By.CssSelector("input.button-action-secondary[value=\"Next\"]"), waitPeriod).First(x => x.Displayed).Click();

            driver.FindElements(By.Id("PurchaseOrderRef"), waitPeriod).First(x => x.Displayed).ClickAndSendKeys("98451985856");

            driver.FindElements(By.CssSelector("input.button-action-secondary[value=\"Next\"]"), waitPeriod).First(x => x.Displayed).Click();

            if (orderType.Contains("DIA"))
            {
                driver.FindElement(By.Id("Layer3VM_Layer3_VCORE_WanIPAddress")).ClickAndSendKeys("20.0.0.0");
                driver.FindElement(By.Id("Layer3VM_Layer3_VCORE_LanIPPrefix")).ClickAndSendKeys("10.0.0.0");
            }

        

            if (orderType.Contains("PWAN"))
            {
                driver.FindElement(By.Id("Layer3PwanNetworkAddress")).ClickAndSendKeys("10.0.0.0");
            }



            var quote = driver.Url;
            driver.FindElement(By.Id("summary-order-button"), waitPeriod).Click();
            driver.FindElement(By.Id("ethernetOrderSummary-CloseBtn"), waitPeriod).Click();
            driver.FindElement(By.Id("submit-order-button"), waitPeriod).Click();

            // Page 4, end
            driver.WaitForElementToDisplay(By.ClassName("OrderComplete"), 60, "Failed after" + quote);

            Assert.AreEqual("Order Ethernet Complete".ToLower(), driver.FindElement(By.CssSelector("span.txt-blue")).Text.ToLower());

        }

        
        [TestCase("10", "100", "talk_talk_ethernet", "DIA", "RAP011")]
        [TestCase("10", "100", "talk_talk_ethernet", "NNI", "RAP011")]
        [TestCase("10", "100", "talk_talk_ethernet", "PWAN", "RAP011")]
        public void Quote_StepInRightsPartnerSection_Success(string serviceSpeed, string bearerSpeed, string providerEnum, string orderType, string impersonateAccountCode)
        {
            // page 0
            driver.Impersonate(impersonateAccountCode, baseURL);

            driver.Navigate().GoToUrl(baseURL + "/Quotes/Build");

            //// page 1
            //driver.FindElement(By.Id("Postcode")).ClickAndSendKeys("SE145BA");
            //driver.FindElement(By.CssSelector($"#bearerSpeed option[value='{bearerSpeed}']")).Click();
            //driver.FindElement(By.CssSelector($"#serviceSpeed option[value='{serviceSpeed}']")).Click();
            //driver.FindElement(By.Id("btnAddSite")).Click();

            var buildQuote = new BuildQuotes(driver);
            buildQuote.BuildQuote("SE145BA", bearerSpeed, serviceSpeed);

            // page 2, type and provider selection
            if (orderType == "NNI")
            {
                driver.FindElement(By.CssSelector("#nni-area > label"), waitPeriod).Click();
            }
            else if (orderType == "PWAN")
            {
                driver.FindElement(By.CssSelector("#mpls-area > label"), waitPeriod).Click();
            }

            // only select one provider
            driver.FindElement(By.CssSelector("label[for='CheckAll']"), waitPeriod).Click();
            driver.FindElement(By.CssSelector($"label[for='TalkTalkInternet']"), waitPeriod).Click();

            driver.FindElement(By.Id("btnGenerateQuote"), waitPeriod).Click();

            // check for the provider expected 
            driver.WaitForElementToDisplay(By.CssSelector($"td[data-provider=\"{providerEnum}\"] > a"), 60, $"Provider: {providerEnum} never found");
            driver.FindElement(By.CssSelector($"td[data-provider=\"{providerEnum}\"] > a")).Click();

            // PAGE 3
            driver.WaitForElementToDisplay(By.Id("CompanyName"), 60);

            driver.FindElement(By.Id("CompanyName"), 60).ClickAndSendKeys("Qwerty");
            driver.FindElement(By.Id("FloorNumber")).ClickAndSendKeys("Qwerty");
            driver.FindElement(By.Id("AccessInformation")).ClickAndSendKeys("Qwerty");
            driver.FindElement(By.Id("RoomUnit")).ClickAndSendKeys("Qwerty");
            driver.FindElement(By.Id("RackLocation")).ClickAndSendKeys("Qwerty");

            driver.FindElements(By.CssSelector(".select-contacts a"), waitPeriod).FirstOrDefault(x => x.Displayed).Click();
            driver.WaitForElementToDisplay(By.Id("selectContactView"), 60);
            driver.FindElements(By.CssSelector("#selectContactView tbody td a"), 60).First(x => x.Displayed).Click();


            driver.FindElements(By.CssSelector("input.button-action-secondary[value=\"Next\"]"), waitPeriod).First(x => x.Displayed).Click();

            if (orderType == "DIA" || orderType == "PWAN")
            {
                driver.FindElements(By.CssSelector("input.button-action-secondary[value=\"Next\"]"), waitPeriod).First(x => x.Displayed).Click();
            }

            driver.FindElement(By.Id("SiteReference"), waitPeriod, el => el.Displayed && el.Enabled).ClickAndSendKeys("Qwerty123");

            try
            {
                if (bearerSpeed == "1000")
                {
                    driver.FindElement(By.CssSelector($"#SelectedConnectorTypeID option[value='1']"), waitPeriod).Click();
                }
            }
            catch (Exception e) { } // we don't always have this option 

            driver.FindElements(By.CssSelector(".select-contacts a"), waitPeriod).FirstOrDefault(x => x.Displayed).Click();
            driver.WaitForElementToDisplay(By.Id("selectContactView"), waitPeriod);
            driver.FindElements(By.CssSelector("#selectContactView tbody td a"), waitPeriod).First(x => x.Displayed).Click();

            driver.FindElements(By.CssSelector("input.button-action-secondary[value=\"Next\"]"), waitPeriod).First(x => x.Displayed).Click();

            driver.FindElement(By.Id("PurchaseOrderRef"), waitPeriod, el => el.Displayed && el.Enabled).ClickAndSendKeys("98451985856");

            driver.FindElements(By.CssSelector("input.button-action-secondary[value=\"Next\"]"), waitPeriod).Last(x => x.Displayed).Click();

            if (orderType.Contains("PWAN"))
            {
                driver.FindElement(By.Id("Layer3PwanNetworkAddress"), waitPeriod, el => el.Displayed && el.Enabled).ClickAndSendKeys("10.0.0.0");
            }

            driver.FindElements(By.CssSelector("input.button-action-secondary[value=\"Next\"]"), waitPeriod).Last(x => x.Displayed).Click();

            driver.FindElement(By.Id("StepInCompanyInformation_CompanyName"), waitPeriod, el => el.Displayed && el.Enabled).ClickAndSendKeys("Qwerty123");
            driver.FindElement(By.Id("StepInCompanyInformation_ContactFirstName")).ClickAndSendKeys("Qwerty123");
            driver.FindElement(By.Id("StepInCompanyInformation_ContactLastName")).ClickAndSendKeys("Qwerty123");
            driver.FindElement(By.Id("StepInCompanyInformation_ContactEmail")).ClickAndSendKeys("a@b.com");
            driver.FindElement(By.Id("StepInCompanyInformation_ContactPhoneNumber")).ClickAndSendKeys("07917440000");

            driver.FindElement(By.Id("StepInCompanyAddress_Postcode")).ClickAndSendKeys("n77pa");
            driver.FindElement(By.CssSelector("input.get-address-button")).Click();

            driver.WaitForElementToDisplay(By.CssSelector(".StepInCompanyAddress_AddressSelect option"), waitPeriod);
            driver.FindElements(By.CssSelector(".StepInCompanyAddress_AddressSelect option"), waitPeriod).First(x => x.Displayed).Click();


            driver.FindElement(By.Id("submit-order-button"), waitPeriod).Click();

            // Page 4, end
            driver.WaitForElementToDisplay(By.ClassName("OrderComplete"), 60);

            Assert.AreEqual("Order Ethernet Complete".ToLower(), driver.FindElement(By.CssSelector("span.txt-blue")).Text.ToLower());
        }
         
        
    }
}

