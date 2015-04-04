using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading;

namespace SpecflowTraining
{
    public class GoogleResultPage : GoogleHomePage
    {
        [FindsBy(How = How.CssSelector, Using = "div.kno-ecr-pt")]
        public IWebElement CompanyHeader;






        public GoogleResultPage()
            : base()
         {
             
             PageFactory.InitElements(Driver, this);

         }

        public bool VerifyResult(string searchString)
        {
            WaitForJQueryToExecute(3);
            Console.WriteLine(Driver.Title);
           //return Driver.Title.ToLower().Contains(searchString) &&  CompanyHeader.Text.ToLower().Contains(searchString);
            return Driver.Title.ToLower().Contains(searchString);
        }
    }
}
