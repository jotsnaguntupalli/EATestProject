Feature: Login Feature
	In order to login to the EA homepage
	As a registered user
	I want to login to my account

@RegressionTest
Scenario Outline: Verify if the Login functionality is working(+ve case)
	Given I have navigated to the EA application
	And   I filled the <Username> and <Password> fields.
	When  I press login button
	Then  I should see the EA homepage
Examples:
 | Username | Password |
 | jotsna   | sairam   |
 | karthik  | Aditi    |

 
 