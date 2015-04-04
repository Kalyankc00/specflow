Feature: Gumtree
	In Order to Seoarch 
	for Homes
	I need to be on Gumtree 

@gumtree
Scenario: Search for houses
	Given I am on gumtree homepage 
	When I search for houses for rent
	Then i should see result in search results 