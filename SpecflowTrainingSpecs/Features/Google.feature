
Feature: Google 4556
	In order search for my problems
	As a researcher 
	I want to use google search engine

@webdriver
Scenario: google search
	Given I am on google home page
	And I search for homeaway
	When I check content 
	Then the result should show homeaway

@webdriver
Scenario Outline: google search for
	Given I am on google home page
	And I search for <SearchQuery>
	When I check content 
	Then the result should show <SearchQuery>
Examples: 
	| SearchQuery |
	| aruna       |
	| gilmund     |
	| london      |


@webdriver
Scenario: google search with differet example
	Given I am on google home page
	And I search
	| SearchQuery |
	| aruna       |
	| gilmund     |
	| london      |
	When I check content 
	Then I should the correct result 
	