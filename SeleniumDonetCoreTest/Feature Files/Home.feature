Feature: Homepage
Enter all details in home page and select save button

Background: 
    I browse the Loginpage

@smoke
Scenario: Enter all details in home page
    Given Enter username and password
	| UserName                     | Password		 |      
	| admin						   | admin		     |
	Then I click login button
	Then Select Title
	Then Enter name
	| Initial | Firstname | Middlename |
	| S       | Ashok     | Kumar    |
	Then Select gender
	Then Select save button