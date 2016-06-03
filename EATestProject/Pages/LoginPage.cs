using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EATestProject.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace EATestProject
{
    public class LoginPage : Base
    {
        //PageObjects
        [FindsBy(How = How.Name, Using = "UserName")]
        public IWebElement username { get; set; }
        [FindsBy(How = How.Name, Using = "Password")]
        public IWebElement password { get; set; }
        [FindsBy(How = How.Name, Using = "Login")]
        public IWebElement btnLogin { get; set; }

        public void Login(string userName, string passWord)
        {
            username.SendKeys(userName);
            password.SendKeys(passWord);
        }

        public EAPage ClickLogin()
        {
            btnLogin.Submit();

           if (btnLogin.Displayed == true)
            {
                
                Console.WriteLine("User Logged in");
                Console.ReadLine();
             }

            else
            {
                Console.WriteLine("User login failed");
                Console.ReadLine();
                throw new NoSuchElementException();
            }
            return new EAPage();

        }


    }
}
