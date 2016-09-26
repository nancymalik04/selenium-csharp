using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace PageObjects
{
    public class RegistrationPageObjectImparative
    {
        private IWebDriver driver;
        private IWebElement UserName;
        private IWebElement Email;
        private IWebElement Password;
        private IWebElement ConfirmPassword;

        private IWebElement RegistrationButton;

        public RegistrationPageObjectImparative(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void EnterUsername(string username)
        {
            UserName = driver.FindElement(By.Id("UserName"));
            UserName.Clear();
            UserName.SendKeys(username);
        }

        public void EnterEmailAddress(string email)
        {
            Email = driver.FindElement(By.Id("Email"));
            Email.Clear();
            Email.SendKeys(email);
        }

        public void EnterPassword(string password)
        {
            Password = driver.FindElement(By.Id("Password"));
            Password.Clear();
            Password.SendKeys(password);
        }

        public void EnterConfirmPassword(string conrfirmPassword)
        {
            ConfirmPassword = driver.FindElement(By.Id("ConfirmPassword"));
            ConfirmPassword.Clear();
            ConfirmPassword.SendKeys(conrfirmPassword);
        }

        public void SubmitRegistrationForm()
        {
            RegistrationButton = driver.FindElement(By.CssSelector("input[type=\"submit\"]"));
            RegistrationButton.Submit();
        }
    }
}