Feature: Login
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@Login
Scenario: Incorrect login
	Given I am on the login page
	And I have entered the username <username>
	And I have entered the password <password>
	When I click the login button
	Then I should get see an alert that states "Epic sadface: "
	Examples: 
	| username | password |
	|iubsc_uyebci |eiyfv_eubc|
	|eiucvbe_yuiec|eiyucbe_ecvb|
	|efiuhcv_ec|edc_ecve|

	@Login
Scenario: Correct login
	Given I am on the login page
	And I have entered the username <username>
	And I have entered the password <password>
	When I click the login button
	Then I should get a confirmation heading that displays "Product"
	Examples: 
	| username | password |
	|standard_user |secret_sauce|
	|problem_user|secret_sauce|
	|performance_glitch_user|secret_sauce|