using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPetStoreWebImplementation
{
    public class HomePage
    {
        private IWebDriver driver;
        private By signIn = By.XPath("//a[text()='Sign In']");
        private By catsPage = By.XPath("(//div[@id='SidebarContent']//img)[3]");

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public SignInPage NavigateToSignInPage()
        {
            driver.FindElement(signIn).Click();
            return new SignInPage(driver);
        }

        public void NavigateToDogPage()
        {

        }

        public CatsPage NavigateToCatePage()
        {
            driver.FindElement(catsPage).Click();
            return new CatsPage(driver);
        }

        public ShoppingCartPage CreateShoppingCart()
        {
            return new ShoppingCartPage(driver);
        }
    }
}
