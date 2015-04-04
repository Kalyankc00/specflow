Feature: Amazon
	In order to by products
	As a customer
	I want to use amazon website

@webdriver
Scenario: amazon search
	Given I am on amazon home page
	And I type for cameras
	When I the content displays
	Then the result shows cameras
