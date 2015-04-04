using System;
using TechTalk.SpecFlow;
using SpecflowTraining;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;


namespace SpecflowTrainingSpecs
{
    public class SearchContent
    {
        public string searchQueryText { get; set; }
    }

    [Binding]
           
    public class GoogleSteps
    {

        GoogleHomePage homePage = new GoogleHomePage();
        GoogleResultPage resultPage = new GoogleResultPage();
        public string queryString = null;
        public IEnumerable<SearchContent> searchContentQuery { get; set; }
        private List<SearchContent> listOfQuery = new List<SearchContent>();
        private List<bool> searchResult = new List<bool>();
       
        [Given(@"I search for (.*)")]
        public void GivenISearchForHomeaway(string query)
        {
            queryString = homePage.SearchOnHomePage(query);
        }

        [When(@"I check content")]
        public void ICheckContent()
        {
           // 
        }

        [Then(@"the result should show (.*)")]
        public void ThenTheResultShouldShowHomeway(string result)
        {
            
            Assert.IsTrue(resultPage.VerifyResult(result));
        }

        [Given(@"I search")]
        public void GivenISearch(Table table)
        {
            foreach (var row in table.Rows)
            {
                var searchText = new SearchContent
                {
                    searchQueryText = ((string[])(row.Values))[0] 
                };
                listOfQuery.Add(searchText);

            }

            foreach (var query in listOfQuery)
            {
                queryString = homePage.SearchOnHomePage(query.searchQueryText);
                searchResult.Add(resultPage.VerifyResult(queryString));
            }

        }

        [Then(@"I should the correct result")]
        public void ThenIShouldTheCorrectResult()
        {
           foreach(bool result in searchResult)
           {
               Assert.IsTrue(result);
           }
        }


    }
}
