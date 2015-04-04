
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.PageObjects;

namespace SpecflowTraining
{
   public  class GumtreeHomePage : DriverConfig
    {
       public GumtreeHomePage()
           : base()
         {
             
             PageFactory.InitElements(Driver, this);

         }
       public GumtreeHomePage GoTo(string homeUrl = "http://www.gumtree.com")
        {
            Driver.Navigate().GoToUrl(homeUrl);
            return this;
        }
    }
}
