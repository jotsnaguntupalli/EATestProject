using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using EATestProject.Main;
using EATestProject.Pages;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace EATestProject.Steps
{
    [Binding]
    public class EASteps
    {
       
        [Given(@"I filled the <Username> and <Password> fields")]
        public void IFilledUsernamePasswordFields(Table table)
        {
            dynamic values = table.CreateDynamicInstance();
            loginPage.Login(values.userName, values.passWord);
        }
        [When(@" I click Login button")]
        public void IClickLoginButton()
        {
            loginPage.ClickLogin();
        }
        [Then(@"I should see EA page")]
        public void IShouldSeeEAPage()
        {

           //((EAPage)Base.CurrentPage).IsLoggedIn();
        }
        [Then(@"I enter data into all the fields in EA page and click save")]
        public void IEnterDataIntoAllFieldsAndSave(Table table)
        {
            dynamic values = table.CreateDynamicInstance();
            //((EAPage)Base.CurrentPage).FillDetails(values.initial, values.firstName, values.middleName);
        }
        [Then(@"I should be able to see all the saved details")]
        public void IShouldSeeSavedDetails(Table table)
        {
            dynamic values = table.CreateDynamicInstance();
            //((EAPage)Base.CurrentPage).GetFilleddetails(values.initial, values.firstName, values.middleName);
            
        } 
    }
}
