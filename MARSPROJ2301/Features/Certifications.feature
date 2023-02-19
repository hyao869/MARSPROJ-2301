Feature: Seller Add certifications Details 

As a seller
I want the feature to add my certifications Details
So that people seeking for some skills can look into my details


Background: Seller logged into Mars successfully
	Given User logged into Mars successfully

@Ignore
Scenario: Add a new Certification 
	When user navigate to Certifications tab
	And add new '<Certificate>' , '<From>', '<Year>' 
	Then The new Certificate should be added

@Ignore
Scenario: Edit an existing Certification record
	When user navigate to Certifications tab
	And  update an existing record with '<Certificate>' , '<CertifiedFrom>', '<Year>'  
	Then The existing Certificate should be updated successfully

@Ignore
Scenario: Delete an existing Certification 
	When user navigate to Certifications tab
	And  delete an existing Certificate
	Then The selected Certificate should be deleted successfully

