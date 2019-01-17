Feature: SpecFlowFeature1
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum and difference of two numbers

@Optellen
Scenario Outline: Add two numbers
	Given I have entered <start> into the calculator
	And I have also entered <eat> into the calculator
	When I press add
	Then the result should be <left> on the screen
  Examples:
	| start | eat | left |
	|    12 |   5 |   17 |
	|    30 |   5 |   35 |
	|   412 |   5 |  417 |
	|    45 |  15 |   60 |


@Aftrekken
Scenario Outline: Subtract two numbers
	Given I have entered <start> into the calculator
	And I have also entered <eat> into the calculator
	When I press subtract
	Then the result should be <left> on the screen
  Examples:
	| start | eat | left |
	|    12 |   5 |    7 |
	|    30 |   5 |   25 |
	|   417 |   5 |  412 |
