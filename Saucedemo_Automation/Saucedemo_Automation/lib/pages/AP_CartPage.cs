using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Saucedemo_Automation
{
    public class AP_CartPage
    {

        private string _cartPage = AppConfigReader.CartPageUrl;

        private IWebDriver _driver;
        private IWebElement _checkoutButton => this._driver.FindElement(By.Id("cart_contents_container"));
        private IWebElement _continueShoppingButton => this._driver.FindElement(By.XPath("//div[@id='cart_contents_container']/div/div[2]/a"));
        private IWebElement _productPageIdentifier => this._driver.FindElement(By.Id("inventory_filter_container"));
        private IWebElement _informationPageIdentifier => this._driver.FindElement(By.ClassName("subheader"));

        public AP_CartPage(IWebDriver driver)
        {
            _driver = driver;
        }
        public void VisitCartPage()
        {
            _driver.Navigate().GoToUrl(_cartPage);
        }
       public void CheckoutButton()
        {
            _checkoutButton.Click();
        }
        public void ContinuteShoppingButton()
        {
            _continueShoppingButton.Click();
        }
        public string ProductPageIdentifier()
        {
          return  _productPageIdentifier.Text;
        }
        public string InformationPageIdentifier()
        {
           return _informationPageIdentifier.Text;
        }
    }
}
