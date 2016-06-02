Feature: Login
	In order to login to the EA homepage
	As a registered user
	I want to login to my account

@Test
@Browser:Firefox
Scenario Outline: Login to EA page
	Given I have navigated to the EA application
	And   I filled the <Username> and <Password> fields.
	When  I press login button
	Then  I should see the EA homepage

Examples:
 | Username | Password |
 | djotsna@outlook   | sairam   |
 
 