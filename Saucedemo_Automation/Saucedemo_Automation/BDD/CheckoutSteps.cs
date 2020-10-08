using System;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace Saucedemo_Automation.BDD
{
    [Binding]
    public class CheckoutSteps
    {
        AP_Website AP_Website { get; } = new AP_Website("chrome");

        [Given(@"I am on the cart page")]
        public void GivenIAmOnTheCartPage()
        {
            AP_Website.AP_CartPage.VisitCartPage();
        }
        
        [When(@"I click the checkout button")]
        public void WhenIClickTheCheckoutButton()
        {
            AP_Website.AP_CartPage.CheckoutButton();
        }
        
        [When(@"I click the continue shopping button")]
        public void WhenIClickTheContinueShoppingButton()
        {
            AP_Website.AP_CartPage.ContinuteShoppingButton();
        }

        [Then(@"I am directed to the information page ""(.*)""")]
        public void ThenIAmDirectedToTheInformationPage(string text)
        {
            Assert.That(AP_Website.AP_CartPage.InformationPageIdentifier(), Does.Contain(text));
        }

        [Then(@"I am directed to the product page ""(.*)""")]
        public void ThenIAmDirectedToTheProductPage(string text)
        {
            Assert.That(AP_Website.AP_CartPage.ProductPageIdentifier(), Does.Contain(text));
        }

        [AfterScenario]
        public void DisposeWebDriver()
        {
            AP_Website.SeleniumDriver.Quit();
            AP_Website.SeleniumDriver.Dispose();
        }
    }
}
