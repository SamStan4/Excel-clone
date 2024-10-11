using System;
using ExpressionTree;

namespace ExpresionTreeTests
{
    /// <summary>
    /// Test cases for the expression tree class.
    /// </summary>
    public class ExpresionTreeTests
    {
        /// <summary>
        /// Tests the expression tree generation when there is an invalid operation.
        /// </summary>
        [Test]
        public void TestExpressionTreeGenerationExceptionalCaseOne()
        {
            Assert.Throws<Exception>(() =>
            {
                ExpressionTree.ExpressionTree testCase = new ExpressionTree.ExpressionTree("1+-1");
            });
        }

        /// <summary>
        /// Test case for when there is a mismatch in parenthesis.
        /// </summary>
        [Test]
        public void TestExpressionTreeGenerationExceptionalCaseTwo()
        {
            Assert.Throws<Exception>(() =>
            {
                ExpressionTree.ExpressionTree testCase = new ExpressionTree.ExpressionTree("(2-1))");
            });
        }

        /// <summary>
        /// Test case for when the input expression is an empty string.
        /// </summary>
        [Test]
        public void TestExpressionTreeGenerationExceptionalCaseThree()
        {
            Assert.Throws<Exception>(() =>
            {
                ExpressionTree.ExpressionTree testCase = new ExpressionTree.ExpressionTree(string.Empty);
            });
        }

        /// <summary>
        /// Divide by zero test case.
        /// </summary>
        [Test]
        public void TestExpressionTreeGenerationEdgeCaseOne()
        {
            double numerator = 1, denominator = 0;

            ExpressionTree.ExpressionTree testCase = new ExpressionTree.ExpressionTree("1/0");

            Assert.That(testCase.Evaluate(), Is.EqualTo(numerator / denominator));
        }

        /// <summary>
        /// Large number multiplication.
        /// </summary>
        [Test]
        public void TestExpressionTreeGenerationEdgeCaseTwo()
        {
            double numOne = double.MaxValue, numTwo = double.MaxValue;

            ExpressionTree.ExpressionTree testCase = new ExpressionTree.ExpressionTree($"{numOne.ToString()}*{numTwo.ToString()}");

            Assert.That(testCase.Evaluate(), Is.EqualTo(numOne * numTwo));
        }

        /// <summary>
        /// Large number division.
        /// </summary>
        [Test]
        public void TestExpressionTreeGenerationEdgeCaseThree()
        {
            double numOne = double.MaxValue, numTwo = 0.000001;

            ExpressionTree.ExpressionTree testCase = new ExpressionTree.ExpressionTree($"{numOne.ToString()}/{numTwo.ToString()}");

            Assert.That(testCase.Evaluate(), Is.EqualTo(numOne / numTwo));
        }

        /// <summary>
        /// Regular case one 1 + 1.
        /// </summary>
        [Test]
        public void TestExpressionTreeGenerationRegularCaseOne()
        {
            double numOne = 1, numTwo = 1;

            ExpressionTree.ExpressionTree testCase = new ExpressionTree.ExpressionTree($"{numOne.ToString()}+{numTwo.ToString()}");

            Assert.That(testCase.Evaluate(), Is.EqualTo(numOne + numTwo));
        }

        /// <summary>
        /// Regular case two 1 - 1.
        /// </summary>
        [Test]
        public void TestExpressionTreeGenerationRegularCaseTwo()
        {
            double numOne = 1, numTwo = 1;

            ExpressionTree.ExpressionTree testCase = new ExpressionTree.ExpressionTree($"{numOne.ToString()}-{numTwo.ToString()}");

            Assert.That(testCase.Evaluate(), Is.EqualTo(numOne - numTwo));
        }

        /// <summary>
        /// Regular case three 1 - 1 + 1.
        /// </summary>
        [Test]
        public void TestExpressionTreeGenerationRegularCaseThree()
        {
            double numOne = 1, numTwo = 1, numThree = 1;

            ExpressionTree.ExpressionTree testCase = new ExpressionTree.ExpressionTree($"{numOne.ToString()}-{numTwo.ToString()}+{numThree}");

            Assert.That(testCase.Evaluate(), Is.EqualTo(numOne - numTwo + numThree));
        }

        /// <summary>
        /// regular test case with a lot of operators.
        /// </summary>
        [Test]
        public void TestExpressionTreeGenerationRegularCaseFour()
        {
            ExpressionTree.ExpressionTree testCase = new ExpressionTree.ExpressionTree("((((4+3)+2/5)-18*(34-1)+11)/4)");

            Assert.That(testCase.Evaluate(), Is.EqualTo(-143.9));
        }
    }
}