using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Saucedemo_Automation
{
    public class AP_Website
    {
        public IWebDriver SeleniumDriver { get; set; }
        public AP_SignInPages AP_SignInPage { get; internal set; }
        public AP_ProductsPage AP_ProductsPage { get; internal set; }
        public AP_CartPage AP_CartPage { get; internal set; }

        public AP_Website(string driverName, int pageLoadWaitInSecs = 10, int implicitWaitInSecs = 10)
        {
            SeleniumDriver = new SeleniumDriverConfig(driverName, pageLoadWaitInSecs, implicitWaitInSecs).Driver;
            AP_SignInPage = new AP_SignInPages(SeleniumDriver);
            AP_ProductsPage = new AP_ProductsPage(SeleniumDriver);
            AP_CartPage = new AP_CartPage(SeleniumDriver);
        }
    }
}
