Feature: Login
	In order to login to the Hotmail homepage
	As a registered user
	I want to login to my account

@Test
@Browser:Firefox
Scenario Outline: Login to Hotmail page
	Given I have navigated to the Hotmail application
	And   I filled the <Username> and <Password> fields.
	When  I press login button
	Then  I should see the Hotmail homepage

Examples:
 | Username | Password |
 | djotsna@outlook   | sairam   |
 | gnk@hotmail  | Aditi    |
 