using System;
using TechTalk.SpecFlow;
using SpecflowTraining;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SpecflowTrainingSpecs.Features.StepDefination
{
    [Binding]
    public class PropertySearchSteps
    {

        PropertySearchHomepage SearchPage = new PropertySearchHomepage();
        SearchRefinement refinment = new SearchRefinement();


        [When(@"I check for content")]
        public void WhenICheckForContent()
        {
            
        }

        [When(@"I search for (Property For Rent)")]
        public void WhenISearchForPropertyForRent(string dropdownOption)
        {
            refinment.ApplyRefinement("classified option dropdown", dropdownOption);
        }

        [When(@"select (Residential Units for Rent)")]
        public void WhenSelectResidentialUnitsForRent(string dropdownOption)
        {
            refinment.ApplyRefinement("residential option dropdown", dropdownOption);
        }

        [When(@"select (Villa/House for Rent)")]
        public void WhenSelectVillaHouseForRent( string dropdownOption)
        {
            refinment.ApplyRefinement("residential type dropdown", dropdownOption);
        }

        [When(@"add search in neighborhoods of (Dubai Marina) area")]
        public void WhenAddSearchInNeighborhoodsOfDubaiMarinaArea(string searchText)
        {
            refinment.ApplyRefinement("neighbourhood text", searchText);
        }

        [When(@"I search")]
        public void WhenISearch()
        {
            
        }

        [When(@"I narrow down search to minimum (.*) bathroom")]
        public void WhenINarrowDownSearchToMinimumBathroom(string  minBathroom)
        {
            refinment.ApplyRefinement("minimum Bathroom dropdown", minBathroom);
            refinment.ApplyRefinement("maximum Bathroom dropdown", "9");
        }

        [When(@"I search again")]
        public void WhenISearchAgain()
        {
            
        }

        [When(@"I sort search results on (Price Highest to Lowest)")]
        public void WhenISortSearchResultsOnPriceHighestToLowest(string priceSort)
        {
            refinment.ApplyRefinement("price Highest to Lowest dropdown", priceSort);
        }

        [When(@"I open the last item in the search")]
        public void WhenIOpenTheLastItemInTheSearch()
        {
            refinment.GotoLastPageOnSearch();   
        }

        [Then(@"I the title of home page should be (dubizzle Dubai Classifieds)")]
        public void ThenITheTitleOfHomePageShouldBeDubizzleDubaiClassifieds(string expectedTitle)
        {
            Assert.IsTrue(SearchPage.VerifyTitle(expectedTitle));

        }

        [Then(@"I should see (place an ad option|search form|quick links)")]
        public void ThenIShouldSeePlaceAnAdOption(string Links)
        {
            Assert.IsTrue(SearchPage.VerifyLinks(Links));
        }

        

        [Then(@"I should see last item have minimum (.*) bathroom")]
        public void ThenIShouldSeeLastItemHaveMinimumBathroom(int BathroomCount)
        {
            Assert.IsTrue(SearchPage.VerifyCount(BathroomCount));
        }
    }
}
