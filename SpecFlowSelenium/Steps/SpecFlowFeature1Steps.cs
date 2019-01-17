using Example;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace SpecFlowSelenium.Steps
{
    [Binding]
    public class CalculatorSteps
    {
        private int result;
        private Calculator calculator = new Calculator();

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int number)
        {
            calculator.FirstNumber = number;
        }

        [Given(@"I have also entered (.*) into the calculator")]
        public void GivenIHaveAlsoEnteredIntoTheCalculator(int number)
        {
            calculator.SecondNumber = number;
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            result = calculator.Add();
        }


        [When(@"I press subtract")]
        public void WhenIPressSubtract()
        {
            result = calculator.Subtract();
        }


        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int expectedResult)
        {
            //string reportingMessage = "eikel";
            Assert.AreEqual(expectedResult, result);

        }
    }
}
