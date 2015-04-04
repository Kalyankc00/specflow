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
    public class GmailLoginPage : GoogleHomePage
    {

        [FindsBy(How = How.Id, Using = "Email")]
        public IWebElement UsernameText;

        [FindsBy(How = How.Id, Using = "Passwd")]
        public IWebElement PasswordText;

        [FindsBy(How = How.Id, Using = "signIn")]
        public IWebElement SubmitCredentials;


        public GmailLoginPage()
            : base()
         {
             PageFactory.InitElements(Driver, this);
         }

        public GmailLoginPage GoTo(string homeUrl = "https://accounts.google.com/ServiceLogin?service=mail&continue=https://mail.google.com/mail/")
        {
            Driver.Navigate().GoToUrl(homeUrl);
            return this;
        }

        public new bool IsCurrentPage()
        {
            return Driver.Title.ToLower().Contains("gmail");
        }

        public void LoginAsUser(string username, string password)
        {
            UsernameText.Clear();
            UsernameText.SendKeys(username);
            PasswordText.Clear();
            PasswordText.SendKeys(password);
            SubmitCredentials.Click();
        }

        
    }
}
