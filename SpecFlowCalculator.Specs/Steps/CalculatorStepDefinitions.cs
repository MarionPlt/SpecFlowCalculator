using TechTalk.SpecFlow;
using FluentAssertions;
using System.Collections.Generic;

namespace SpecFlowCalculator.Specs.Steps
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {

        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;
        private readonly Calculator _calculator = new Calculator();
        private int _result;
        private string _message;

        public CalculatorStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            _calculator.FirstNumber = number;
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            _calculator.SecondNumber = number;
        }

        [Given(@"the complete (.*)")]
        public void GivenTheCompleteCalculus(string c)
        {
            _calculator.Operation = c;
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            _result = _calculator.Add();
        }

        [When("the two numbers are substracted")]
        public void WhenTheTwoNumbersAreSubstracted()
        {
            _result = _calculator.Substract();
        }
    


        [When("the two numbers are multiplied")]
        public void WhenTheTwoNumbersAreMultiplied()
        {
            _result = _calculator.Multiply();
        }

        [When("the two numbers are divided")]
        public void WhenTheTwoNumbersAreDivided()
        {
            try
            {
                _result = _calculator.Divide();
            } catch(System.Exception _e)
            {
                _message = "Error";
            }
          
        }
        [When("the operation is applied")]
        public void WhenTheOperationIsApplied()
        {
            _result = _calculator.SuperCalculator();
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            _result.Should().Be(result);
        }

        [Then(@"the user get an error message ""(.*)""")]
        public void ThenTheUserGetAnErrorMessage(string p0)
        {
            _message.Should().Be(p0);
        }


    }
}
