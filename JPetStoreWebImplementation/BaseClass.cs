using JPetStore.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium;

namespace JPetStoreWebImplementation
{
    public class BaseClass:IBaseClass
    {
        private IWebDriver _driver;

        public HomePage LaunchBrowser(string browser)
        {
            switch (browser)
            {
                case "chrome":
                    _driver = new ChromeDriver();
                    break;
                case "edge":
                    _driver = new EdgeDriver();
                    break;
                case "remote":
                    _driver = new RemoteWebDriver(new Uri("http://localhost:9515"), new ChromeOptions());
                    break;
                default:
                    break;
            }
            _driver.Navigate().GoToUrl("https://petstore.octoperf.com/actions/Catalog.action");

            return new HomePage(_driver);
        }

        public void CloseBrowser()
        {
            _driver.Close();
        }
    }
}
