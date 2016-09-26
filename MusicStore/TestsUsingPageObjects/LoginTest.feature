Feature: LoginTest
	As a registered customer
	I want to be able to login
	So that I can have access to my account

@Live
Scenario: Login User Successfully
	Given I am on Login Page
	When I enter my username 'uesrname' and password 'test123'
	Then I see a Welcome message 'username'  

@Live
Scenario: Login User Unsuccessfully
	Given I am on Login Page
	When I enter my username 'uesrname' and password 'password123'
	Then I see a error message 'E-Mail/Password is not correct. Please try again.'


