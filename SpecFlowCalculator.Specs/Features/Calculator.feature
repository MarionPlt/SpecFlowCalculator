Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](SpecFlowCalculator.Specs/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@addition
Scenario: Add two numbers
	Given the first number is 50
	And the second number is 70
	When the two numbers are added
	Then the result should be 120

	@substraction
Scenario: Substract two numbers
	Given the first number is 70
	And the second number is 50
	When the two numbers are substracted
	Then the result should be 20

	@multiplication
	Scenario: Multiply two numbers
	Given the first number is 10
	And the second number is 18
	When the two numbers are multiplied
	Then the result should be 180

	@division
	Scenario: divide two numbers
	Given the first number is 25
	And the second number is 5
	When the two numbers are divided
	Then the result should be 5

	@division
	Scenario: throw error if divide by zero
	Given the first number is 25
	And the second number is 0
	When the two numbers are divided
	Then the user get an error message "Error"

	@N-operation
	Scenario Outline: operation with N numbers
	Given the complete <calculus>
	When the operation is applied
	Then the result should be <result>
	
	  Examples:
    | calculus  | result |
	| 25+7+10   | 42     |
	| 35-20-7-4 | 4      |
	| 5*6*3     | 90     |
	| 12/3/2    | 2      |


	@N-operation
	Scenario Outline: different operations in a same calculus
	Given the complete <calculus>
	When the operation is applied
	Then the result should be <result>
	
	  Examples:
    | calculus  | result |
	| 25+7-10   | 22     |
	| 35-20-7*4 | 32     |
	| 5*6/3     | 10     |
	| 12-3/3    | 3      |
	