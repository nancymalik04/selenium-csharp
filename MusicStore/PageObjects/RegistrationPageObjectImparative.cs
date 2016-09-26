using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects; 

namespace PageObjects
{
    public class RegistrationPageObjectDeclarative
    {
        private IWebDriver driver;

        [FindsBy] 
        private IWebElement UserName;

        [FindsBy] 
        private IWebElement Email;

        [FindsBy] 
        private IWebElement Password;

        [FindsBy] 
        private IWebElement ConfirmPassword;

        [FindsBy(How = How.CssSelector, Using = "input[type=\"submit\"]")]
        private IWebElement RegistrationButton;

        public RegistrationPageObjectDeclarative(IWebDriver driver)
        {
            this.driver = driver;
        }
        
        public void Register(string username, string email, string password, string confirmPassword)
        {
            UserName.SendKeys(username);
            Email.SendKeys(email);
            Password.SendKeys(password);
            ConfirmPassword.SendKeys(confirmPassword);
            RegistrationButton.Submit();
        }
    }
}