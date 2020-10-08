using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace Saucedemo_Automation
{
    public class AP_ProductsPage
    {
        private IWebDriver _driver;

        private string _productPageUrl = AppConfigReader.ProductsPageUrl ;
        private IWebElement _productSelect => this._driver.FindElement(By.XPath("//div[@id='inventory_container']/div/div/div[3]/button"));
        private IWebElement _cartCounter => this._driver.FindElement(By.XPath("//div[@id='shopping_cart_container']/a/span"));

        public AP_ProductsPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void VisitProductsPage()
        {
            _driver.Navigate().GoToUrl(_productPageUrl);
        }

        public void ProductSelect()
        {
            _productSelect.Click();
        }
        public string ProductSelectText()
        {
            return _productSelect.Text;
        }
        public bool CartCounter()
        {
           return _cartCounter.Displayed;
        }
    }
}
