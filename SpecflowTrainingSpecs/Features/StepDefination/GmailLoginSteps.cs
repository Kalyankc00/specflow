using System;
using TechTalk.SpecFlow;
using SpecflowTraining;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SpecflowTrainingSpecs
{
    [Binding]
    public class GmailLoginSteps
    {
        GmailLoginPage gmailLoginPage = new GmailLoginPage();
        GmailInboxPage gmailInbox = new GmailInboxPage();

        [Given(@"I am gmail login page")]
        public void GivenIAmGmailLoginPage()
        {
            gmailLoginPage.GoTo();
        }

        [When(@"I logged in with valid (.*) and (.*) to (gmail|drive)")]
        public void WhenIProvideValidCredentials(string username, string password, string app)
        {
            gmailLoginPage.LoginAsUser(username,password) ;
        }

        [When(@"I provide specflowtest@gmail\.com and kjsdgkjds")]
        public void WhenIProvideSpecflowtestGmail_ComAndKjsdgkjds()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I should be on Inbox page of my account")]
        public void ThenIShouldBeOnInboxPageOfMyAccount()
        {
            Assert.IsTrue(gmailInbox.IsCurrentPage());
            Assert.IsTrue(gmailInbox.ValidateUrl());

        }

        [Then(@"I should be error on the page")]
        public void ThenIShouldBeErrorOnThePage()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
