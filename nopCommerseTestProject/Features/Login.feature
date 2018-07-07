Feature: Login
		Check if the Login functionality is working 
		as expected with different permutations and 
		combinations of data.

		@smoke @positive
		Scenario: Check Login with correct username and password
		Given I have navigated to the application
		And I see application opened
		When I clickon Login and I enter Username and Password
		| UserName | Password |
		| howareu  | 123123   |
		Then click login button
		Then I should see the AccountHome Page 
		Then I click Logout
		Then I should see the Login page
	