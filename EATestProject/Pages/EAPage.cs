using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace EATestProject.Pages
{
    public class EAPage : Base
    {
        //PageObjects
        [FindsBy(How = How.Id, Using = "TitleId")]
        public IWebElement ddlTitle { get; set; }
        [FindsBy(How = How.Name, Using = "Initial")]
        public IWebElement txtInitial { get; set; }
        [FindsBy(How = How.Name, Using = "FirstName")]
        public IWebElement txtFirstName { get; set; }
        [FindsBy(How = How.Name, Using = "MiddleName")]
        public IWebElement txtMiddleName { get; set; }
        [FindsBy(How = How.Name, Using = "Male")]
        public IWebElement rbtnMale { get; set; }
        [FindsBy(How = How.Name, Using = "Female")]
        public IWebElement rbtnFemale { get; set; }
        [FindsBy(How = How.Name, Using = "Hindi")]
        public IWebElement chkLanguage { get; set; }
        [FindsBy(How = How.Name, Using = "Save")]
        public IWebElement btnSave { get; set; }

        public void FillDetails(string firstName, string middleName)
        {
            SelectElement element = new SelectElement(ddlTitle);
           
        }



    }
}
