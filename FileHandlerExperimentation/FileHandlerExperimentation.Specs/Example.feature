Feature: Example

Scenario: Upload a single file
	Given I navigated to the single file page
	And Testing
	And I entered data
		| Field | Value |
		| File  | file1 |
	When I choose the submit button
	Then I wait for the results page
	And I am on the results page
