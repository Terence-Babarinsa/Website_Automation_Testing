using System;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace Saucedemo_Automation.BDD
{
    [Binding]
    public class PorductsSteps
    {
        AP_Website AP_Website { get; } = new AP_Website("chrome");

        [Given(@"I am on the product page")]
        public void GivenIAmOnTheProductPage()
        {
            AP_Website.AP_ProductsPage.VisitProductsPage();
        }
        
        [When(@"I add a product to the cart")]
        public void WhenIAddAProductToTheCart()
        {
            AP_Website.AP_ProductsPage.ProductSelect();
        }
        
        [Then(@"the cart acknowledges the addition")]
        public void ThenTheCartAcknowledgesTheAddition()
        {
            Assert.That(AP_Website.AP_ProductsPage.CartCounter(), Is.True);
        }
        [Given(@"a product is selected")]
        public void GivenAProductIsSelected()
        {
            AP_Website.AP_ProductsPage.ProductSelect();
        }

        [When(@"I deselect the product")]
        public void WhenIDeselectTheProduct()
        {
            AP_Website.AP_ProductsPage.ProductSelect();
        }

        [Then(@"text on add to cart button is ""(.*)""")]
        public void ThenTextOnAddToCartButtonIs(string text)
        {
            Assert.That( AP_Website.AP_ProductsPage.ProductSelectText(), Does.Contain(text));
        }


        [AfterScenario]
        public void DisposeWebDriver()
        {
            AP_Website.SeleniumDriver.Quit();
            AP_Website.SeleniumDriver.Dispose();
        }
    }
}
