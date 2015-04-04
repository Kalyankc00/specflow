using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using SpecflowTraining;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SpecflowTrainingSpecs
{
[Binding]
    public class CommonBindingSteps
    {

        [BeforeScenario("webdriver","aruna","facebook","gumtree","gmail")]
        public static void BeforeFeature()
        {
            DriverConfig driverConfig = new DriverConfig();
             driverConfig.LaunchWebdriver();
        }
   
        [AfterScenario("webdriver","aruna","facebook","gumtree","gmail")]
        public static void AfterFeature()
        {
            DriverConfig driverConfig = new DriverConfig();
            driverConfig.QuitWebdriver();
        }


        [Given(@"I am on google home page")]
        public void GivenIAmOnGoogleHomePage()
        {
            GoogleHomePage homepage = new GoogleHomePage();
            homepage.GoTo();
            Assert.IsTrue(homepage.IsCurrentPage());
        }

        [Given(@"I am on dubizzle dubai home page")]
        public void GivenIAmOnDubizzleDubaiHomePage()
        {
            PropertySearchHomepage homepage = new PropertySearchHomepage();
            homepage.GoTo();

        }

        [Given(@"I am on amazon home page")]
        public void GivenIAmOnAmazonHomePage()
        {
            AmazonSearchHomePage homepage = new AmazonSearchHomePage();
            homepage.GoTo();
        }

        [Given(@"I am on gumtree homepage")]
        public void GivenIAmOnGumtreeHomepage()
        {
            GumtreeHomePage homepage = new GumtreeHomePage();
            homepage.GoTo();
        }

    }
}
           
