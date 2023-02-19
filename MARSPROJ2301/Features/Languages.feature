Feature: Seller Add Languages Details 

As a seller
I want the feature to add my languages Details
So that people seeking for some skills can look into my details


Background: Seller logged into Mars successfully
	Given User logged into Mars successfully

@ignore
Scenario: Add a new language with valid data
	When Seller navigates to Language Tab
	And Seller enters Language '<Language>' and Level '<Level>'
	Then The Language and Level were entered as '<Language>' and '<Level>'

@Ignore
Scenario: Edit an existing language 
	When user navigate to language tab
	And  edit an existing language
	Then The existing language should be updated successfully

@Ignore
Scenario: Delete an existing language 
	When user navigate to language tab
	And  delete an existing language
	Then The selected language should be deleted successfully

