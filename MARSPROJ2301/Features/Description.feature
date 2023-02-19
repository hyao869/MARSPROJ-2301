Feature: Seller Add Description Details

As a seller
I want the feature to add my description Details
So that people seeking for some skills can look into my details

Background: Seller logged into Mars successfully
	Given User logged into Mars successfully

@ignore
Scenario: Add new description
	When user navigate to description tab
	And  add seller description with max 600 characters
	Then The new description should be displayed successfully

@Ignore
Scenario: Edit description
	When user navigate to description tab
	And  edit an existing description
	Then The description should be updated successfully

