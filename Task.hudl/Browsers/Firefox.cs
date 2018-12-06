using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluidOne.ClientTesting.Dash
{
    public class Firefox : FirefoxDriver, IWebDriver
    {
        static DesiredCapabilities _DC { get; set; } = new DesiredCapabilities(new Dictionary<string, object> { { CapabilityType.AcceptInsecureCertificates, true } });

        public Firefox() : base(_DC)
        {
        }
    }
}
