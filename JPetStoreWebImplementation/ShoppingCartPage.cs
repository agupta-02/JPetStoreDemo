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

        public ShoppingCartPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void NaviagateToHomePage()
        {
            driver.FindElement(By.LinkText("Return to Main Menu")).Click();
        }
    }
}
