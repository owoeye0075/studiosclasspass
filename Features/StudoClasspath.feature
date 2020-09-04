Feature: StudoClasspath
	As a user
	In order to use the Studio Classpath Website
	The user will need to register

@mytag
Scenario: Registration page of Studio page
	Given the user navigate to "https://studios.classpass.com/path-to-partnership"
	And the user enter the first name "Philip"
	And the user enter the last name "Eliot"
	And the user eneter email address "services.desk01@yahoo.com"
	And the user enter website "www.mindmybusiness.com"
	And the user click Sign Up for Free
	And the user select country 
	And the user enter phone number "07459014352"
	And Click next button
	And the user click individual
	And the user click next
	And the user enter partner name "Evelyn Tosin"
	And the user enter the city and Country of operation "Birmingham, UK"
	And the user click the Business Next button
	And the user select the type of services off 
	And the user click the services Next button
	And the user should confirm Yes or No for who has legal entity
	And the user enter the legal entity name "Jordon Radio"
	And the user should tick the agreement box
	When the user click the Agree button 
	Then the user should be successfully registered

