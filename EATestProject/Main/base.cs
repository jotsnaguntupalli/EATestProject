using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace EATestProject.Main
{
    public class Base
    {
        private IWebDriver _driver;
        private static BasePage _currentpage;

        public static BasePage currentPage
        {
            get {return _currentpage;}
            set
            {
                ScenarioContext.Current["class"] = value;
                _currentpage = ScenarioContext.Current.Get<BasePage>("class");
            }
        }

        public TPage As<TPage>() where TPage : BasePage
        {
            return (TPage) this;
        }
        //protected TPage GetInstance<TPage>() where TPage : BasePage, new()
        //{
        //    TPage pageInstance = new TPage
        //    {
        //        _driver = Driver.driver
        //    };
        //    return pageInstance;
        //}
    }

}