using System;
using TechTalk.SpecFlow;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using Calc;

namespace UnitTestProjectSpecFlow
{

    [Binding]
    public class CalculatorSteps
    {
        int firstNumber;
        int secondNumber;
        int result;

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int number)
        {
            firstNumber = number;
        }
        
        [Given(@"I have also entered (.*) into the calculator")]
        public void GivenIHaveAlsoEnteredIntoTheCalculator(int number)
        {
            secondNumber = number;
        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            result = Calculator.Add(firstNumber, secondNumber);
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int expectedResult)
        {
            Assert.AreEqual(result, expectedResult);
        }
    }
}
