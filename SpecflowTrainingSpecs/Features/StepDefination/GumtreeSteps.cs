using System;
using TechTalk.SpecFlow;
using SpecflowTraining;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SpecflowTrainingSpecs.Features.StepDefination
{
    [Binding]
    public class GumtreeSteps
    {
        
        [When(@"I search for houses for rent")]
public void WhenISearchForHousesForRent()
{
    ScenarioContext.Current.Pending();
}

        [Then(@"i should see result in search results")]
public void ThenIShouldSeeResultInSearchResults()
{
    ScenarioContext.Current.Pending();
}
    }
}
