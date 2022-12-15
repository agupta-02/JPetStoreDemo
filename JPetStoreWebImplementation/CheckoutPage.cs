using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPetStoreWebImplementation
{
    public class CheckoutPage
    {
        private IWebDriver driver;
        private By continueToOrder = By.XPath("//input[@name='newOrder']");
        private By confirmOrder = By.LinkText("Confirm");
        public CheckoutPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void FinishCheckout()
        {
            driver.FindElement(continueToOrder).Click();
            driver.FindElement(confirmOrder).Click();   
        }
        public void NavigateBackToHomePage() 
        {
            driver.FindElement(By.LinkText("Return to Main Menu")).Click();
        }
    }
}
