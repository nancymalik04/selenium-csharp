using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.PageObjects;
using PageObjects;

namespace PageObjects
{
    public class LoginPageObject
    {
        private IWebDriver driver;

        public void NavigateToLoginPage()
        {
            driver = new FirefoxDriver();
            //driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.musicstore.de/en_GB/GBP/login");
            driver.Manage().Window.Maximize();
        }

        public void EnterUserName(String username)
        {
            IWebElement usernameField = driver.FindElement(By.Id("ShopLoginForm_Login"));
            usernameField.Clear();
            usernameField.SendKeys(username);

        }

        public void EnterPassword(String password)
        {
            IWebElement passwordField = driver.FindElement(By.Id("ShopLoginForm_Password"));
            passwordField.Clear(); ;
            passwordField.SendKeys(password);
        }

        public void ClickSubmit()
        {
            IWebElement submitButton = driver.FindElement(By.XPath("//*[@id='login-user-form']/div/div[2]/div[4]/button"));
            submitButton.Click();
        }

        public bool IsWelcomeMessageDisplayed(String expectedWelcomeMessage)
        {
            String actualWelcomeMessage = driver.FindElement(By.XPath("//*[@id='account-page']/div/div[2]/div[2]/div[1]/div/h1")).Text;
            if (expectedWelcomeMessage.Equals(actualWelcomeMessage))
            
                return true;
            
            else
                //Console.WriteLine("Message did not match, Expected Message " + expectedWelcomeMessage, "Actual Message " + actualMessage);
            //Console.ReadLine();
            return false;
               
        }

        public bool IsErrorMessageDisplayed(String expectedErrorMessage)
        {
            String actualErrorMessage = driver.FindElement(By.XPath("//*[@id='account-login-page']/div/div[2]/div/div[2]/div[2]/div/div[2]/div[2]/div[1]/span[2]")).Text;
            if (expectedErrorMessage.Equals(actualErrorMessage))

                return true;

            else
                return false;

        }

        public void TearDown()
        {
            driver.Quit();
        }

    }
}
