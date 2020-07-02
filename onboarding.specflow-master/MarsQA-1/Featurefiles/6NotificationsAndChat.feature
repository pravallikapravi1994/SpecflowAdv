Feature: 6NotificationsAndChat
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Verify Notifications page
	Given User is in Profile or Home page
 
	When User navigates to notifications 
	Then Verify for Notifications

@mytag
Scenario: Verify Chat page
	Given User is in Profile or Home page
 
	When User navigates to Chat page 
	Then Verify for Chats