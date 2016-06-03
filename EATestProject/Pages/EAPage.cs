using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EATestProject.Main;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace EATestProject.Pages
{
    public class EAPage : BasePage
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

        public void IsLoggedIn()
        {
            Driver.driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
            if (btnSave.Displayed == true)
            {
                Console.WriteLine("User details are saved");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("User cannot save the details");
                Console.ReadLine();
                throw new Exception("User not logged in ");
            }
        }
        public void FillDetails(string initial,string firstName, string middleName)
        {
            txtInitial.SendKeys(initial);
            txtFirstName.SendKeys(firstName);
            txtMiddleName.SendKeys(middleName);
            btnSave.Click();
        }

        public void GetFilleddetails(string initial, string firstName, string middleName)
        {
            if (txtInitial.GetAttribute("value") == initial && txtFirstName.GetAttribute("value") == firstName &&
                txtMiddleName.GetAttribute("value") == middleName)
            {
                Console.WriteLine("passed");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Failed");
                Console.ReadLine();
            }
        }




    }
}
