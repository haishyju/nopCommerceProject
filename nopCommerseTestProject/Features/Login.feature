Feature: Login
		Check if the Login functionality is working 
		as expected with different permutations and 
		combinations of data.

		@smoke @positive
		Scenario: Check Login with correct UserName and Password
		Given I have navigated to the application
		And I see application opened
		When I clickon Login
		Then I should see Loginpage 
		When User enter credentials
		| UserName | Password |
		| howareu  | 123123   |
		And I click login button
		Then I should see the AccountHome Page
		And I clickon logout button
		