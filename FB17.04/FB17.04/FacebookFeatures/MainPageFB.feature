Feature: MainPageFB
	In order to use social network Facebook
	As a potential Facebook user
	I want to register account through main page

	Scenario: Successful authorization
	Given Main page is opened
	When I input '0955763144' in email field
	And I input 'k2i4ij1hj3' in password field
	And I click on Submit button
	Then Visibility of SignOut link is 'true'