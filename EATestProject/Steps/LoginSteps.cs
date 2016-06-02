using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace EATestProject.Steps
{
    [Binding]
    public class LoginSteps
    {
        [Given(@"I have navigated to the EA application")]
        public void IHaveNavigatedToEAApplication()
        {
            Driver.driver = new FirefoxDriver();
            Driver.driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["seleniumBaseUrl"]);
            Driver.driver.Manage().Window.Maximize();
        }
        [When((@""))]

    }
}
