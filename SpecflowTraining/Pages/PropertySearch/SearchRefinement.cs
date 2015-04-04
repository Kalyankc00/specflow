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
    
    public class SearchRefinement  : PropertySearchHomepage
    {
        [FindsBy(How = How.Id, Using = "s:swfield")]
        public IWebElement AdTypeDropDown;

        [FindsBy(How = How.Id, Using = "rc:swfield")]
        public IWebElement ResidentialOptionDropDown;

        [FindsBy(How = How.Id, Using = "c1:swfield")]
        public IWebElement VillaHouseForRentDropDown;

        [FindsBy(How = How.Id, Using = "as_values_id_places__id__in")]
        public IWebElement NeighbourhoodText;

        [FindsBy(How = How.Id, Using = "search-button")]
        public IWebElement SearchSubmitButton;

        [FindsBy(How = How.Id, Using = "bathrooms__gte:swfield")]
        public IWebElement MinimumBathroom;

        [FindsBy(How = How.Id, Using = "bathrooms__lte:swfield")]
        public IWebElement MaximumBathroom;

        [FindsBy(How = How.Id, Using = "search-button-mini")]
        public IWebElement SearchMiniSubmitButton;

        [FindsBy(How = How.Id, Using = "id_sort_by")]
        public IWebElement PriceSort;

        [FindsBy(How = How.CssSelector, Using = "div.paging_forward a#last_page")]
        public IList<IWebElement> LastSearchPage;


        public SearchRefinement() : base ()
        {
            PageFactory.InitElements(Driver, this);

         }

        public void ApplyRefinement(string RefinmentType, string RefinmentOption)
        {
            if (RefinmentType.Contains("dropdown"))
            { SelectOptionsFromRefinementDropdown(RefinmentType, RefinmentOption);}
            if (RefinmentType.Contains("text"))
            { WriteTextOption(RefinmentType, RefinmentOption); }

        }

        public void SelectOptionsFromRefinementDropdown(string dropdownType, string dropdownOption)
        {
            switch (dropdownType)
            {
                case "classified option dropdown":
                    SelectFromDropDownByText(AdTypeDropDown, dropdownOption);
                    WaitForJQueryToExecute(5);
                    break;

                case "residential option dropdown":
                    SelectFromDropDownByText(ResidentialOptionDropDown, dropdownOption);
                    WaitForJQueryToExecute(5);
                    break;

                case "residential type dropdown":
                    SelectFromDropDownByText(VillaHouseForRentDropDown, dropdownOption);
                    WaitForJQueryToExecute(5);
                    break;

                case "minimum Bathroom dropdown":
                    SelectFromDropDownByValue(MinimumBathroom, dropdownOption);
                    WaitForJQueryToExecute(5);
                    //SearchMiniSubmitButton.Click();
                    break;
                case "maximum Bathroom dropdown":
                    SelectFromDropDownByValue(MaximumBathroom, dropdownOption);
                    WaitForJQueryToExecute(5);
                    SearchMiniSubmitButton.Click();
                    break;

                case "price Highest to Lowest dropdown":
                    SelectFromDropDownByText(PriceSort, dropdownOption);
                    WaitForJQueryToExecute(5);
                    break;

                default:
                    break;
            }
        }

        public void WriteTextOption(string textType, string textOption)
        {
            switch (textType)
            {
                case "neighbourhood text":
                    //SelectFromTextboxByText(NeighbourhoodText, textOption);
                    NeighbourhoodText.SendKeys(textOption);
                    WaitForJQueryToExecute(5);
                    SearchSubmitButton.Click();
                    WaitForJQueryToExecute(30);
                    break;

                default:
                    break;
            }
         }

        public void GotoLastPageOnSearch()
        {
            LastSearchPage[1].Click();
            WaitForJQueryToExecute(5);
        }


    }
}
