using System;
using TechTalk.SpecFlow;

namespace SpecflowTrainingSpecs
{
    [Binding]
    public class SimpleCalculatorSteps
    {
        [Given(@"I have entered (.*) and (.*) into the calculator")]
        public void GivenIHaveEnteredAndIntoTheCalculator(int p0, int p1)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
