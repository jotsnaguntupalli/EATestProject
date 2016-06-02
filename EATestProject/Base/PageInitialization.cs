using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;

namespace EATestProject
{
    public abstract class Base
    {
        public Base()
        {
            PageFactory.InitElements(Driver.driver, this);
        }
    }
}
