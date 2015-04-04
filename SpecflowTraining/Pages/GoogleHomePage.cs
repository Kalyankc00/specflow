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
    public class GoogleHomePage : DriverConfig
    {
        [FindsBy(How = How.Id, Using = "gbqfq")]
        public IWebElement SearchBox;

        [FindsBy(How = How.Id, Using = "gbqfb")]
        public IWebElement SearchSubmitButton;

        public GoogleHomePage(): base()
         {
             PageFactory.InitElements(Driver, this);
         }
        
        public GoogleHomePage GoTo(string homeUrl="http://www.google.co.uk")
        {
            Driver.Navigate().GoToUrl(homeUrl);
            return this;
        }

        public bool IsCurrentPage()
        {
            return Driver.Title.ToLower().Contains("google");
        }

        public string SearchOnHomePage(string query)
        {
            SearchBox.Clear();
            SearchBox.SendKeys(query);
            SearchSubmitButton.Click();
            return query;
        }

    }
}
