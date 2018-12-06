using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluidOne.ClientTesting.Dash
{
    public class InternetExplorer : InternetExplorerDriver, IWebDriver
    {
        static InternetExplorerOptions Options { get; set; } = new InternetExplorerOptions()
        {
            IgnoreZoomLevel = true,
            EnablePersistentHover = true,
            IntroduceInstabilityByIgnoringProtectedModeSettings = true,
            EnableNativeEvents = false,
            UnhandledPromptBehavior = UnhandledPromptBehavior.Accept
        };

        static InternetExplorerDriverService Service { get; set; } = InternetExplorerDriverService.CreateDefaultService();

        public InternetExplorer() : base(Service, Options, TimeSpan.FromSeconds(240))
        {
        }
    }
}
