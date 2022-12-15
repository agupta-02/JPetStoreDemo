using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPetStoreWebImplementation
{
    public class UserRegistrationPage
    {
        private IWebDriver driver;
        private IWebElement userName { get { return (driver.FindElement(By.XPath("//input[@name = 'username']"))); } }
        private IWebElement password { get { return (driver.FindElement(By.XPath("//input[@name = 'password']"))); } }
        private IWebElement RepeatPassword { get { return (driver.FindElement(By.XPath("//input[@name = 'repeatedPassword']"))); } }
        private IWebElement firstName { get { return (driver.FindElement(By.XPath("//input[@name = 'account.firstName']"))); } }
        private IWebElement lastName { get { return (driver.FindElement(By.XPath("//input[@name = 'account.lastName']"))); } }
        private IWebElement email { get { return (driver.FindElement(By.XPath("//input[@name = 'account.email']"))); } }
        private IWebElement phone { get { return (driver.FindElement(By.XPath("//input[@name = 'account.phone']"))); } }
        private IWebElement address1 { get { return (driver.FindElement(By.XPath("//input[@name = 'account.address1']"))); } }
        private IWebElement address2 { get { return (driver.FindElement(By.XPath("//input[@name = 'account.address2']"))); } }
        private IWebElement city { get { return (driver.FindElement(By.XPath("//input[@name = 'account.city']"))); } }
        private IWebElement state { get { return (driver.FindElement(By.XPath("//input[@name = 'account.state']"))); } }
        private IWebElement zipcode { get { return (driver.FindElement(By.XPath("//input[@name = 'account.zip']"))); } }
        private IWebElement country { get { return (driver.FindElement(By.XPath("//input[@name = 'account.country']"))); } }
        public UserRegistrationPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void EnterUserData()
        {
            userName.SendKeys("akgsdk");
            password.SendKeys("password");
            RepeatPassword.SendKeys("password");
            firstName.SendKeys("Sandy");
            lastName.SendKeys("Mandy");
            email.SendKeys("myemail@gmail.com");
            phone.SendKeys("7890123654");
            address1.SendKeys("123 SK Road");
            address2.SendKeys("456 MG Road");
            city.SendKeys("Tezpur");
            state.SendKeys("Assam");
            zipcode.SendKeys("785000");
            country.SendKeys("India");
            
            driver.FindElement(By.XPath("//input[@name='newAccount']")).Click();
        }
    }
}
