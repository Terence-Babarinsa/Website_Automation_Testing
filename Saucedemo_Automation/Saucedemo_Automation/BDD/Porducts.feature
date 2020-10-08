Feature: Porducts
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@SelectProducts
Scenario: Select a product
	Given I am on the product page
	When I add a product to the cart
	Then the cart acknowledges the addition

	@SelectProducts
Scenario: Deselect a product
	Given I am on the product page
	And a product is selected
	When I deselect the product
	Then text on add to cart button is "ADD TO CART"
