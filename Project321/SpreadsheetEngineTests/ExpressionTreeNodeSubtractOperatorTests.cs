using System;
using ExpressionTreeNodeConstant;
using ExpressionTreeNodeSubtractOperator;

namespace ExpressionTreeNodeSubtractOperatorTests
{
    /// <summary>
    /// Test cases for the Expression Tree Node subtraction class.
    /// </summary>
    public class ExpressionTreeNodeSubtractOperatorTests
    {
        /// <summary>
        /// Edge test case one.
        /// Tests for very negative number.
        /// </summary>
        [Test]
        public void TestSubtractEvaluationEdgeCaseOne()
        {
            Dictionary<string, double> variableContext = new Dictionary<string, double>();

            ExpressionTreeNodeSubtractOperator.ExpressionTreeNodeSubtractOperator testCase = new ExpressionTreeNodeSubtractOperator.ExpressionTreeNodeSubtractOperator();

            testCase.LinkLeft = new ExpressionTreeNodeConstant.ExpressionTreeNodeConstant(double.MinValue);

            testCase.LinkRight = new ExpressionTreeNodeConstant.ExpressionTreeNodeConstant(double.MaxValue);

            Assert.That(testCase.Evaluate(ref variableContext), Is.EqualTo(double.MinValue - double.MaxValue));
        }

        /// <summary>
        /// Edge test two.
        /// Tests for a very large positive number.
        /// </summary>
        [Test]
        public void TestSubtractEvaluationEdgeCaseTwo()
        {
            Dictionary<string, double> variableContext = new Dictionary<string, double>();

            ExpressionTreeNodeSubtractOperator.ExpressionTreeNodeSubtractOperator testCase = new ExpressionTreeNodeSubtractOperator.ExpressionTreeNodeSubtractOperator();

            testCase.LinkLeft = new ExpressionTreeNodeConstant.ExpressionTreeNodeConstant(double.MaxValue);

            testCase.LinkRight = new ExpressionTreeNodeConstant.ExpressionTreeNodeConstant(double.MinValue);

            Assert.That(testCase.Evaluate(ref variableContext), Is.EqualTo(double.MaxValue - double.MinValue));
        }

        /// <summary>
        /// Exceptional test case one.
        /// Tests when both subtrees are null.
        /// </summary>
        [Test]
        public void TestSubtractEvaluationExceptionalCaseOne()
        {
            Dictionary<string, double> variableContext = new Dictionary<string, double>();

            ExpressionTreeNodeSubtractOperator.ExpressionTreeNodeSubtractOperator testCase = new ExpressionTreeNodeSubtractOperator.ExpressionTreeNodeSubtractOperator();

            Assert.Throws<Exception>(() => testCase.Evaluate(ref variableContext));
        }

        /// <summary>
        /// Exceptional test case Two.
        /// Tests when right subtrees are null.
        /// </summary>
        [Test]
        public void TestSubtractEvaluationExceptionalCaseTwo()
        {
            Dictionary<string, double> variableContext = new Dictionary<string, double>();

            ExpressionTreeNodeSubtractOperator.ExpressionTreeNodeSubtractOperator testCase = new ExpressionTreeNodeSubtractOperator.ExpressionTreeNodeSubtractOperator();

            testCase.LinkLeft = new ExpressionTreeNodeConstant.ExpressionTreeNodeConstant(1);

            Assert.Throws<Exception>(() => testCase.Evaluate(ref variableContext));
        }

        /// <summary>
        /// Exceptional test case Three.
        /// Tests when left subtrees are null.
        /// </summary>
        [Test]
        public void TestSubtractEvaluationExceptionalCaseThree()
        {
            Dictionary<string, double> variableContext = new Dictionary<string, double>();

            ExpressionTreeNodeSubtractOperator.ExpressionTreeNodeSubtractOperator testCase = new ExpressionTreeNodeSubtractOperator.ExpressionTreeNodeSubtractOperator();

            testCase.LinkRight = new ExpressionTreeNodeConstant.ExpressionTreeNodeConstant(1);

            Assert.Throws<Exception>(() => testCase.Evaluate(ref variableContext));
        }

        /// <summary>
        /// Edge test case one.
        /// Tests for very negative number.
        /// </summary>
        [Test]
        public void TestSubtractEvaluateRegularCaseOne()
        {
            Dictionary<string, double> variableContext = new Dictionary<string, double>();

            ExpressionTreeNodeSubtractOperator.ExpressionTreeNodeSubtractOperator testCase = new ExpressionTreeNodeSubtractOperator.ExpressionTreeNodeSubtractOperator();

            testCase.LinkLeft = new ExpressionTreeNodeConstant.ExpressionTreeNodeConstant(1);

            testCase.LinkRight = new ExpressionTreeNodeConstant.ExpressionTreeNodeConstant(1);

            Assert.That(testCase.Evaluate(ref variableContext), Is.EqualTo(1 - 1));
        }
    }
}