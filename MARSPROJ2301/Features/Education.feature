Feature: Seller Add Education Details 

As a seller
I want the feature to add my education Details
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

Scenario: Remove education record
	When user navigate to education tab
	And delete an existing education record
	Then The record should be deleted successfully
