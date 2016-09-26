using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.PageObjects;
using PageObjects;

namespace TestsUsingPageObjects
{
    public class RegistrationPageObjectTests
    {
        [Test]
        public void TestRegistration()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("http://localhost/MusicStore/Account/Register/");

            RegistrationPageObjectDeclarative registerUserPage = new RegistrationPageObjectDeclarative(driver);
            PageFactory.InitElements(driver, registerUserPage);
            registerUserPage.Register("BloggsJ", "j.bloggs @web.com", "Pas1234", "Pas1234");

            driver.Quit();
        }

        [Test]
        public void TestImperativeRegistration()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("http://localhost/MusicStore/Account/Register/");

            RegistrationPageObjectImparative registerUserPage = new RegistrationPageObjectImparative(driver);
            registerUserPage.EnterUsername("jblogs");
            registerUserPage.EnterEmailAddress("jblogs @hahoo.com");
            registerUserPage.EnterPassword("Pas123");
            registerUserPage.EnterConfirmPassword("Pas123");
            registerUserPage.SubmitRegistrationForm();
        }
    }
}