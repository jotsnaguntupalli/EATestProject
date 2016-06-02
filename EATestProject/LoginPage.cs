using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace EATestProject
{
   public class LoginPage : Base
    {
    
        [FindsBy(How = How.Id, Using = "i0116")]
        public IWebElement username { get; set; }
        [FindsBy(How = How.Id, Using = "i0118")]
        public IWebElement password { get; set; }
        [FindsBy(How = How.Id, Using = "idChkBx_PWD_KMSI0Pwd")]
        public IWebElement chkSignedIn { get; set; }
        [FindsBy(How = How.Id, Using = "idSIButton9")]
        public IWebElement btnSignIn { get; set; }

       public void Login(string userName, string passWord)
       {
           username.SendKeys(userName);
           password.SendKeys(passWord);
           chkSignedIn.Click();
           btnSignIn.Click();
       }


    }
}
