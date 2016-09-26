using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using PageObjects;
using NUnit;
using NUnit.Framework;
using OpenQA.Selenium.Firefox;
using System.Text;
using System;

namespace TestsUsingPageObjects
{
    public class Class1
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;

        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            baseURL = "http://localhost";
            verificationErrors = new StringBuilder();
            driver.Navigate().GoToUrl(baseURL + "/MusicStore/Account/Register/");
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }

        [Test]
        public void RegisterUser() 
        {
            PageFactory.InitElements(driver, (new RegisterUserPageObject()));
      
            RegisterUserPageObject registerUserPage = new RegisterUserPageObject();
            registerUserPage.Init(driver);
            registerUserPage.EnterUsername("BloggsJ");
            registerUserPage.EnterEmailAddress("j.bloggs @web.com");
            registerUserPage.EnterPassword("Pas1234");
            registerUserPage.EnterConfirmPassword("Pas1234");
            registerUserPage.SubmitRegistrationForm();
        }

    }
}
