Feature: Seller Add Profile Details

As a seller
I want the feature to add my Profile Details
So that people seeking for some skills can look into my details

Background: Seller logged into Mars successfully
	Given User logged into Mars successfully

Scenario Outline: Add education history with valid details
	When user navigate to education tab
	And create new education record with '<Institute>', '<Country>', '<Title>', '<Degree>', '<Year>'
	Then The record should be added successfully '<Institute>', '<Country>', '<Title>', '<Degree>', '<Year>'

Examples: 
| Institute | Country     | Title | Degree     | Year |
| AUT       | New Zealand | B.A   |Science    | 2009 |
#| MIT       | New Zealand | M.A   | Education | 2012 |
#| MASSY     | New Zealand | PHD   |  Medical | 2020 |

Scenario: Edit existing education record with valid details
	When user navigate to education tab
	And Edit '<Institute>', '<Degree>', '<Year>'on an exsiting education record 
	Then The record should have been modified to '<Institute>', '<Degree>', '<Year>'

Examples: 
| Institute |  Degree     | Year |
#| AUT       |  Science    | 2009 |
| MIT       |  Education  | 2012 |
#| MASSY     |  Medical    | 2020 |


Scenario: Delete education record
	When user navigate to education tab
	And delete an existing education record
	Then The record should be deleted successfully

@ignore
Scenario: Add new description
	When user navigate to description tab
	And add or update seller description with max 600 characters
	Then The description should be displayed successfully

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
