using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace FluidOne.ClientTesting.Dash
{
    public class Chrome : ChromeDriver, IWebDriver
    {
        public Chrome() : base()
        {
        }
    }
}
