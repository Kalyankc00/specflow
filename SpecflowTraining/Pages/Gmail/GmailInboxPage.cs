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
    public class GmailInboxPage : GmailLoginPage
    {

         public GmailInboxPage()
            : base()
         {
             PageFactory.InitElements(Driver, this);
         }

        public new bool IsCurrentPage()
        {
            WaitForJQueryToExecute(10);
            return Driver.Title.ToLower().Contains("inbox");
        }

        public new bool ValidateUrl(string validator="inbox")
        {
            return  Driver.Url.ToLower().Contains(validator);
        }


    }
}
