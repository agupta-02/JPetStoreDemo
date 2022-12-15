using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPetStoreWebImplementation
{
    public class ShoppingCartPage
    {
        private IWebDriver driver;
        private By checkout = By.LinkText("Proceed to Checkout");

        public ShoppingCartPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void NaviagateToHomePage()
        {
            driver.FindElement(By.LinkText("Return to Main Menu")).Click();
        }
        public CheckoutPage CheckoutPage()
        {
            driver.FindElement(checkout).Click();
            return new CheckoutPage(driver);
        }
    }
}
