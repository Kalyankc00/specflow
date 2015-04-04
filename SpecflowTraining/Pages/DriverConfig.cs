using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System.Threading;
using OpenQA.Selenium.Support.UI;


namespace SpecflowTraining
{
    public class DriverConfig
    {
        public static IWebDriver Driver { get; set; }



        public void  LaunchWebdriver()
        {
            Driver = new FirefoxDriver();

        }

        public void QuitWebdriver()
        {
            Driver.Quit();
        }
        public void WaitForJQueryToExecute(int timout = 1)
        {
            Thread.Sleep(timout * 1000);
        }

        public void SelectFromDropDownByText(IWebElement element, string text)
        {
            var selectElement = new SelectElement(element);
            selectElement.SelectByText(text);
        }

        public void SelectFromDropDownByValue(IWebElement element, string value)
        {
            var selectElement = new SelectElement(element);
            selectElement.SelectByValue(value);
        }

        public void SelectFromDropDownByIndex(IWebElement element, int index)
        {
            var selectElement = new SelectElement(element);
            selectElement.SelectByIndex(index);
        }

        public void SelectFromTextboxByText(IWebElement element, string  value)
        {
            var selectElement = new SelectElement(element);
            //selectElement.Senf
        }
    }
}
