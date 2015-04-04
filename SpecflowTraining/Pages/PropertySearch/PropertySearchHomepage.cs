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
    public class PropertySearchHomepage :DriverConfig
    {
        [FindsBy(How = How.Id, Using = "place_an_ad_callout_en")]
        public IWebElement PlaceAnAd;

        [FindsBy(How = How.Id, Using = "search-widget-form")]
        public IWebElement QuickSearch;

        [FindsBy(How = How.Id, Using = "head-motors")]
        public IWebElement MotorQuickLinks;

        [FindsBy(How = How.XPath, Using = ".//*[@id='results-list']/div[26]/div/div/div[2]/div[2]/ul/li[2]/ul[1]/li[2]/strong")]
        public IWebElement BathroomCount;

        public PropertySearchHomepage(): base()
         {
             
             PageFactory.InitElements(Driver, this);

         }
        public PropertySearchHomepage GoTo(string homeUrl = "http://dubai.dubizzle.com")
        {
            Driver.Navigate().GoToUrl(homeUrl);
            return this;
        }

        public bool IsCurrentPage()
        {
            return Driver.Title.ToLower().Contains("dubizzle");
        }

        public bool VerifyTitle(string ExpectedTitle)
        {
            return Driver.Title.ToLower().Contains(ExpectedTitle.ToLower());
        }

        public bool VerifyLinks(string ExpectedLink)
        {
            bool result = false;
            switch(ExpectedLink)
            {
                case "place an ad option":
                result = PlaceAnAd.Displayed;
                break;

                case "search form":
                result = QuickSearch.Displayed;
                break;

                case "quick links":
                result = MotorQuickLinks.Displayed;
                break;

                default:
                break;
            }
            return result;
        }

        public bool VerifyCount(int Count)
        {
            bool result = false;
            switch(Count)
            {
                case 2 :
                    if(Convert.ToInt32(BathroomCount.Text) > Count)
                    result = true;
                    break;

                default:
                    break;
            }
            return result;
        }
    }
}
