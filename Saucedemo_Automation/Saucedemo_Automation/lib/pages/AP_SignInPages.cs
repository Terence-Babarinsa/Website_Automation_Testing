using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Saucedemo_Automation
{
    public class AP_SignInPages
    {
        private IWebDriver _driver;

        private string _signINPageUrl = AppConfigReader.BaseUrl;
        private IWebElement _usernameField => this._driver.FindElement(By.Id("user-name"));
        private IWebElement _passwordField => this._driver.FindElement(By.Id("password"));
        private IWebElement _loginButton => this._driver.FindElement(By.Id("login-button"));
        private IWebElement _alert => this._driver.FindElement(By.Id("login_button_container"));
        private IWebElement _headingFromProductPage => this._driver.FindElement(By.Id("inventory_filter_container"));
        public AP_SignInPages(IWebDriver driver)
        {
            _driver = driver;
        }

        public void VisitSignInPage()
        {
            _driver.Navigate().GoToUrl(_signINPageUrl);
        }
        public void InsertUsername(string username)
        {
            _usernameField.SendKeys(username);
        }
        public void InserPassword(string password)
        {
            _passwordField.SendKeys(password);
        }
        public void ClickLogin()
        {
            _loginButton.Click();
        }
        public string AlertMessage()
        {
            
           return _alert.Text;
        }
        public string HeadingfromProductPage()
        {
            return _headingFromProductPage.Text;
        }

    }
}
