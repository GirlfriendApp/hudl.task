using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;
using FluidOne.ClientTesting.Dash.Entities;

namespace FluidOne.ClientTesting.Dash.PageObjects

{
   
    public class PageAccessRights
    {
     
        private IWebDriver _driver;

        public PageAccessRights(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);

        }

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
    }
}
