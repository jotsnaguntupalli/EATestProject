using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace EATestProject.Steps
{
    [Binding]
    public class EASteps
    {
        LoginPage loginPage = new LoginPage();
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
           ScenarioContext.Current.Pending();
        }
        [Then(@"I enter data into all the fields in EA page and click save")]
        public void IEnterDataIntoAllFieldsAndSave()
        {
            ScenarioContext.Current.Pending();
        }
        [Then(@"I should be able to see all the saved details")]
        public void IShouldSeeSavedDetails()
        {
            ScenarioContext.Current.Pending();
        } 
    }
}
