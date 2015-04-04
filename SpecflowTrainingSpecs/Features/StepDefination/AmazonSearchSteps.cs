using System;
using TechTalk.SpecFlow;
using SpecflowTraining;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SpecflowTrainingSpecs
{
    [Binding]
    public class AmazonSearchSteps
        
    {
        AmazonSearchHomePage amazonSearchPage = new AmazonSearchHomePage();
 
        [Given(@"I type for cameras")]
        public void GivenITypeForCameras()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I the content displays")]
        public void WhenITheContentDisplays()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the result shows cameras")]
        public void ThenTheResultShowsCameras()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
