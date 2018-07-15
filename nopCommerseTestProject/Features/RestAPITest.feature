Feature: RestAPITest
	

@smoke
Scenario: Get API Response for a given endpoint
	Given the endpoint is /posts/
	When I send the RestRequest using GET
	Then I get the API Response in Json format
