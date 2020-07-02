Feature: 5ManageRequests
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Verify SentRequests in ManageRequest page
	Given User Navigates to ManageListing page
	
	When User is in SentRequests
	Then verify SentRequestContent


Scenario: Verify ReceivedRequests in ManageRequest page
	Given User Navigates to ManageListing page
	
	When User is in Received Request
	Then verify ReceivedRequest Content
