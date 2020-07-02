Feature: 3Profile
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: 1Add Education in Profile
	Given User Navigates to Education Tab
	When User adds Educations
	Then Verify if Education is added


@mytag
Scenario: 2Edit Education in profile
	Given User Navigates to Education Tab
	When User edits Educations
	Then Verify if Education is Edited


@mytag
Scenario: 3Delete Education in profile
	Given User Navigates to Education Tab
	When User Deletes Education
	Then Verify if Education is Deleted


@mytag
Scenario: 4Add Certification in Profile
	Given User Navigates to Certificate Tab
	When User adds Certificate
	Then Verify if Certificate is added


@mytag
Scenario: 5Edit Certification in profile
	Given User Navigates to Certificate Tab
	When User edits Certificate
	Then Verify if Certificate is Edited


@mytag
Scenario: 6Delete Certification in profile
	Given User Navigates to Certificate Tab
	When User Deletes Certificate
	Then Verify if Certificate is Deleted


@mytag
Scenario: 7Update Description
	Given User is in Profile page
	When Users updates description
	Then Verify if Description is updated 


	@mytag
Scenario: 8Update UserName
	Given User is in Profile page
	And user clicks on username expand button and modifies username
	When user clicks on Save button
	Then Username should be updated 



		@mytag
Scenario: 9Update Availability
	Given User is in Profile page
	And user clicks edit icon of Availability
	When user edits Availability
	Then Availability should be updated 



		@mytag
Scenario: 9.1SearchSkill and Filter
	Given User is in Profile page
	And user performs search for Category and SubCategory
	When User Filters search results 
	Then Verify result for Search