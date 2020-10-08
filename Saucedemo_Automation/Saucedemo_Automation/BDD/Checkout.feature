Feature: Checkout
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@Checkout
Scenario: Checkout
	Given I am on the cart page
	When I click the checkout button
	Then I am directed to the information page "Checkout: Your Information"

	@Checkout
Scenario: Cancel Checkout
	Given I am on the cart page
	When I click the continue shopping button
	Then I am directed to the product page "Products"
