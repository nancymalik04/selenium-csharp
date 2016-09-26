using TechTalk.SpecFlow;
using PageObjects;
using NUnit.Framework;

namespace TestsUsingPageObjects
{
    [Binding]
    public class LoginStepDefinition
    {
        LoginPageObject loginPage;
        
        [Given(@"I am on Login Page")]
        public void GivenIAmOnLoginPage()
        {
            loginPage = new LoginPageObject();
            loginPage.NavigateToLoginPage();
        }


        [When(@"I enter my username '(.*)' and password '(.*)'")]
        public void WhenIEnterMyUsernameAndPassword(string username, string password)
        {
            loginPage.EnterUserName(username);
            loginPage.EnterPassword(password);
            loginPage.ClickSubmit();
        }

        [Then(@"I see a Welcome message '(.*)'")]
        public void ThenISeeAWelcomeMessage(string welcomeMessage)
        {
            //Assert.IsTrue(loginPage.IsWelcomeMessageDisplayed(welcomeMessage));
            Assert.IsTrue(loginPage.IsWelcomeMessageDisplayed(welcomeMessage), "Incorrect Message Shown on Page");
            loginPage.TearDown();
        }

        [Then(@"I see a error message '(.*)'")]
        public void ThenISeeAErrorMessage(string errorMessage)
        {
            Assert.IsTrue(loginPage.IsErrorMessageDisplayed(errorMessage), "Incorrect Message Shown on Page");
            loginPage.TearDown();
        }


    }
}

