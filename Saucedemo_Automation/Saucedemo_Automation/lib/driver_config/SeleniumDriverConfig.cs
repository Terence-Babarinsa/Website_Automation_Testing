using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Saucedemo_Automation
{
    class SeleniumDriverConfig
    {
        public IWebDriver Driver { get; set; }

        public SeleniumDriverConfig(string driver, int pageLoadInSecs, int implicitWaitInSecs)
        {
            DriverSetup(driver, pageLoadInSecs, implicitWaitInSecs);
        }

        public void DriverSetup(string driver, int pageLoadInSecs, int implicitWaitInSecs)
        {
            if (driver.ToLower() == "chrome")
            {
                SetChromeDriver();
                SetDriverConfiguration(pageLoadInSecs, implicitWaitInSecs);
            }
            else
                throw new Exception("please enter a valid driver");
        }

        public void SetChromeDriver()
        {
           // ChromeOptions options = new ChromeOptions();
            //options.AddArgument("headless");
            Driver = new ChromeDriver();
        }
        public void SetDriverConfiguration(int pageLoadInSecs, int implicitWaitInSecs)
        {
            Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(pageLoadInSecs);
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(implicitWaitInSecs);
        }
    }
}
