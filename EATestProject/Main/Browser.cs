using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace EATestProject.Main
{
    public enum BrowserType
    {
        IE,
        Chrome,
        Firefox
    };
    public class Browser
    {
        private readonly IWebDriver _driver;

        public Browser(IWebDriver driver)
        {
            _driver = driver;
        }

        public static void OpenUrl(string url)
        {
            Driver.driver.Url = url;
        }

        public static void OpenBrowser(BrowserType browserType = BrowserType.Firefox)
        {
            switch (browserType)
            {
                    case BrowserType.Firefox:
                    Driver.driver = new FirefoxDriver();
                    Driver.browser = new Browser(Driver.driver);
                    break;

                case BrowserType.Chrome:
                    Driver.driver = new ChromeDriver(@"c:\\SeleniumLibrary\");
                    Driver.browser = new Browser(Driver.driver);
                    break;

                case BrowserType.IE:
                    Driver.driver = new InternetExplorerDriver(@"c:\\SeleniumLibrary\");
                    Driver.browser = new Browser(Driver.driver);
                    break;
            }
        }

    }
}
