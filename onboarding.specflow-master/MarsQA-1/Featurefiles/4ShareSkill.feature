Feature: 4ShareSkill
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers


@mytag
Scenario: 1ShareSkill-Add and Save skill
	Given User clicks navigates Service Listing page
	And Add Service listing data
	When User press Save button
	Then Skill should be added in Manage listing page


Scenario: 2Edit shared skill
	Given User navigates to Manage Listing page
	And Clicks on Edit icon and edits data
	When Press save button
	Then Skill should be updated in Manage listing page


Scenario: 3Delete shared skill
	Given User navigates to Manage Listing page
	And Clicks on Delete icon 
	When User press Ok button
	Then Skill should be deleted in Manage listing page