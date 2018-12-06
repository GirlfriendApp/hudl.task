using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
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
    public class Edge : EdgeDriver, IWebDriver
    {
        static EdgeOptions EdgeOptions { get; set;} = new EdgeOptions {
                AcceptInsecureCertificates = true                
            };

        public Edge() : base(EdgeOptions)
        {
        }
    }
}
