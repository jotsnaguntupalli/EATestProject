using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;

namespace EATestProject.Main
{
    public class BasePage : Base
    {
        public BasePage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }
    }
}
