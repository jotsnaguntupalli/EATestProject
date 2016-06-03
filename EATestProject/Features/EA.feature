Feature: EA
	In this feature we will test the filling the user form with details in EA page
	As a user
	I want to see the saved details of the form

@Regressiontest
Scenario: Enter all data in the user form in EA page
	Given I am on EA homepage
	Then I should see EA page
	When I enter data into all the fields in EA page and click save
		 | Initial | Firstname | Middlename |
		 | Mrs     | Jotsna    | Guntupalli |
	Then I should be able to see all the saved details