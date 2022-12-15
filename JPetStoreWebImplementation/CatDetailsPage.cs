using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPetStoreWebImplementation
{
    public class CatDetailsPage
    {
        private IWebDriver driver;
        private By addMalePersian = By.XPath("(//a[text()='Add to Cart'])[2]");

        public CatDetailsPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void AddtoCart()
        {
            driver.FindElement(addMalePersian).Click();
        }
    }
}
