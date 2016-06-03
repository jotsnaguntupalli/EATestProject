using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EATestProject.Main;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace EATestProject.Steps
{
    [Binding]
    public class LoginSteps
    {
        //LoginPage loginPage = new LoginPage();
        
        public void IHaveNavigatedToEAApplication()
        {
            Driver.driver = new FirefoxDriver();
            Driver.driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["seleniumBaseUrl"]);
            Base.currentPage = new LoginPage();
            Driver.driver.Manage().Window.Maximize();
        }

        [Given(@" I filled the <Username> and <Password> fields")]
        public void IFilledUsernamePasswordFields(string userName, string passWord)
        {
            Base.currentPage.As<LoginPage>().Login(userName, passWord);
        }

        [When(@"I press login button and see Homepage")]
        public void IPressLoginButtonAndSeeHomepage()
        {
            Base.currentPage.As<LoginPage>().ClickLogin();
        }

    
    }
}
