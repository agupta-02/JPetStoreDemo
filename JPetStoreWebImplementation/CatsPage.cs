using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V106.Audits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPetStoreWebImplementation
{
    public class CatsPage
    {
        private IWebDriver driver;
        private By persianCat = By.LinkText("FL-DLH-02");

        public CatsPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public CatDetailsPage NavigateToPersianCatDetailsPage()
        {
            driver.FindElement(persianCat).Click();
            return new CatDetailsPage(driver);
        }
    }
}
