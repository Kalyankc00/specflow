Feature: GmailLogin
	In order to access my mail
	As a Gmail User
	I want to be able to loginto my account

Background: 
	Given I am gmail login page 
@gmail
Scenario Outline: Log into my account with credentials
	 When I logged in with valid <username> and <password> to gmail
	 Then I should be on Inbox page of my account 
Examples: 
	 | username               | password		|
	 | specflowtest@gmail.com |	Specflowtest1234|
	 
 @gmail 
Scenario Outline: Logs into user account with invalid inputs 
     When I provide <username> and <password>
	 And I press submit button
	 Then I should be error on the page 
	 Examples: 
	 | username               | password |
	 | specflowtest@gmail.com |kjsdgkjds |