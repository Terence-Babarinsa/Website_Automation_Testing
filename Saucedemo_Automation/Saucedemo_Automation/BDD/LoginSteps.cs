using System;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace Saucedemo_Automation.BDD
{
    [Binding]
    public class LoginSteps
    {
        AP_Website AP_Website { get; } = new AP_Website("chrome");

        [Given(@"I am on the login page")]
        public void GivenIAmOnTheLoginPage()
        {
            AP_Website.AP_SignInPage.VisitSignInPage();
        }
        
        [Given(@"I have entered the username (.*)")]
        public void GivenIHaveEnteredTheUsername(string username)
        {
            AP_Website.AP_SignInPage.InsertUsername(username);
        }
        
        [Given(@"I have entered the password (.*)")]
        public void GivenIHaveEnteredThePassword(string password)
        {
            AP_Website.AP_SignInPage.InserPassword(password);
        }
        
        [When(@"I click the login button")]
        public void WhenIClickTheLoginButton()
        {
            AP_Website.AP_SignInPage.ClickLogin();
        }
        
        [Then(@"I should get see an alert that states ""(.*)""")]
        public void ThenIShouldGetSeeAnAlertThatStates(string message)
        {
            Assert.That(AP_Website.AP_SignInPage.AlertMessage, Does.Contain(message));
        }

        [Then(@"I should get a confirmation heading that displays ""(.*)""")]
        public void ThenIShouldGetAConfirmationHeadingThatDisplays(string heading)
        {
            Assert.That(AP_Website.AP_SignInPage.HeadingfromProductPage(), Does.Contain(heading));
        }

        [AfterScenario]
        public void DisposeWebDriver()
        {
            AP_Website.SeleniumDriver.Quit();
            AP_Website.SeleniumDriver.Dispose();
        }
    }
}
