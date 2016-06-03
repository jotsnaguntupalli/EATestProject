using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace EATestProject.Main
{
    public class Base
    {
        private IWebDriver _driver;
        public static BasePage CurrentPage{ get; set; }

        protected TPage GetInstance<TPage>() where TPage : BasePage, new()
        {
            TPage pageInstance = new TPage
            {
                _driver = Driver.driver
            };
            return pageInstance;
        }

        public TPage As<TPage>() where TPage : BasePage
        {
            return (TPage) this;
        }
    }
}