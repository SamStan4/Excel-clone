using System;
using ExpressionTreeNodeConstant;
using ExpressionTreeNodeMultiplyOperator;

namespace ExpressionTreeNodeMultiplyOperatorTests
{
    /// <summary>
    /// Test cases for the expression tree node multiplication class.
    /// </summary>
    public class ExpressionTreeNodeMultiplyOperatorTests
    {
        /// <summary>
        /// Test case for when the product of evaluation is very large.
        /// </summary>
        [Test]
        public void TestMultiplyEvaluationEdgeCaseOne()
        {
            Dictionary<string, double> variableContext = new Dictionary<string, double>();

            ExpressionTreeNodeMultiplyOperator.ExpressionTreeNodeMultiplyOperator testCase = new ExpressionTreeNodeMultiplyOperator.ExpressionTreeNodeMultiplyOperator();

            testCase.LinkLeft = new ExpressionTreeNodeConstant.ExpressionTreeNodeConstant(double.MaxValue);

            testCase.LinkRight = new ExpressionTreeNodeConstant.ExpressionTreeNodeConstant(double.MaxValue);

            Assert.That(testCase.Evaluate(ref variableContext), Is.EqualTo(double.MaxValue * double.MaxValue));
        }

        /// <summary>
        /// Test case for when the product of evaluation is very small.
        /// </summary>
        [Test]
        public void TestMultiplyEvaluationEdgeCaseTwo()
        {
            Dictionary<string, double> variableContext = new Dictionary<string, double>();

            ExpressionTreeNodeMultiplyOperator.ExpressionTreeNodeMultiplyOperator testCase = new ExpressionTreeNodeMultiplyOperator.ExpressionTreeNodeMultiplyOperator();

            testCase.LinkLeft = new ExpressionTreeNodeConstant.ExpressionTreeNodeConstant(double.MinValue);

            testCase.LinkRight = new ExpressionTreeNodeConstant.ExpressionTreeNodeConstant(double.MaxValue);

            Assert.That(testCase.Evaluate(ref variableContext), Is.EqualTo(double.MinValue * double.MaxValue));
        }

        /// <summary>
        /// Test case for when left and right subtree are null.
        /// </summary>
        [Test]
        public void TestMultiplyEvaluateExceptionalCaseOne()
        {
            Dictionary<string, double> variableContext = new Dictionary<string, double>();

            ExpressionTreeNodeMultiplyOperator.ExpressionTreeNodeMultiplyOperator testCase = new ExpressionTreeNodeMultiplyOperator.ExpressionTreeNodeMultiplyOperator();

            Assert.Throws<Exception>(() => testCase.Evaluate(ref variableContext));
        }

        /// <summary>
        /// Test case for when the right subtree is null.
        /// </summary>
        [Test]
        public void TestMultiplyEvaluateExceptionalCaseTwo()
        {
            Dictionary<string, double> variableContext = new Dictionary<string, double>();

            ExpressionTreeNodeMultiplyOperator.ExpressionTreeNodeMultiplyOperator testCase = new ExpressionTreeNodeMultiplyOperator.ExpressionTreeNodeMultiplyOperator();

            testCase.LinkLeft = new ExpressionTreeNodeConstant.ExpressionTreeNodeConstant(1);

            Assert.Throws<Exception>(() => testCase.Evaluate(ref variableContext));
        }

        /// <summary>
        /// Test case for when the left subtree is null.
        /// </summary>
        [Test]
        public void TestMultiplyEvaluateExceptionalCaseThree()
        {
            Dictionary<string, double> variableContext = new Dictionary<string, double>();

            ExpressionTreeNodeMultiplyOperator.ExpressionTreeNodeMultiplyOperator testCase = new ExpressionTreeNodeMultiplyOperator.ExpressionTreeNodeMultiplyOperator();

            testCase.LinkRight = new ExpressionTreeNodeConstant.ExpressionTreeNodeConstant(1);

            Assert.Throws<Exception>(() => testCase.Evaluate(ref variableContext));
        }

        /// <summary>
        /// Test case for 1 - 1.
        /// </summary>
        [Test]
        public void TestMultiplyEvaluateRegularCaseOne()
        {
            Dictionary<string, double> variableContext = new Dictionary<string, double>();

            ExpressionTreeNodeMultiplyOperator.ExpressionTreeNodeMultiplyOperator testCase = new ExpressionTreeNodeMultiplyOperator.ExpressionTreeNodeMultiplyOperator();

            testCase.LinkLeft = new ExpressionTreeNodeConstant.ExpressionTreeNodeConstant(1);

            testCase.LinkRight = new ExpressionTreeNodeConstant.ExpressionTreeNodeConstant(1);

            Assert.That(testCase.Evaluate(ref variableContext), Is.EqualTo(1 * 1));
        }
    }
}