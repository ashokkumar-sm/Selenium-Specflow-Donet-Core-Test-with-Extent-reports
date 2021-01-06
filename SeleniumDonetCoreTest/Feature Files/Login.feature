Feature: Login Test
	I  want to login to website
Background: 
    I browse the Loginpage

@smoke
Scenario Outline: Login to Website 
	Given Enter username and password
	| UserName                     | Password		 |      
	| admin						   | admin		     |
	Then I click login button
	Then I should see logout link