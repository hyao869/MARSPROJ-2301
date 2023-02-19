Feature: Seller Add Skills Details 

As a seller
I want the feature to add my skills Details
So that people seeking for some skills can look into my details


Background: Seller logged into Mars successfully
	Given User logged into Mars successfully

	@Ignore
Scenario: Add a new Skill on Profile Page
	When user navigate to skill tab
	And  add new Skill and select Level
	Then The new Skill should be added to the Skill List

@Ignore
Scenario: Edit an existing Skill 
	When user navigate to skill tab
	And  edit an existing Skill
	Then The existing Skill should be updated successfully

@Ignore
Scenario: Delete an existing Skill 
	When user navigate to skill tab
	And  delete an existing Skill
	Then The selected Skill should be deleted successfully
