using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPetStoreWebImplementation
{
    public class SignInPage
    {
        private IWebDriver driver;
        private By clickRegisterNow = By.LinkText("Register Now!");
        private IWebElement password { get { return (driver.FindElement(By.XPath("//input[@name = 'password']"))); } }

        public SignInPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public UserRegistrationPage NavigateToUserRegistration()
        {
            driver.FindElement(clickRegisterNow).Click();
            return new UserRegistrationPage(driver);
        }
        public void EnterUserCred()
        {
            password.Clear();
            password.SendKeys("password");
            driver.FindElement(By.XPath("//input[@name = 'signon']")).Click();
        }
    }
}
