using System;
using ExpressionTreeNodePowerOperator;

namespace ExpressionTreeNodePowerOperatorTests
{
    /// <summary>
    /// Test cases for power operator node.
    /// </summary>
    public class ExpressionTreeNodePowerOperatorTests
    {
        /// <summary>
        /// Test case for when the power is zero.
        /// </summary>
        [Test]
        public void TestPowerEvaluationEdgeCaseOne()
        {
            Dictionary<string, double> variableContext = new Dictionary<string, double>();

            ExpressionTreeNodePowerOperator.ExpressionTreeNodePowerOperator testCase = new ExpressionTreeNodePowerOperator.ExpressionTreeNodePowerOperator();

            testCase.LinkLeft = new ExpressionTreeNodeConstant.ExpressionTreeNodeConstant(10);

            testCase.LinkRight = new ExpressionTreeNodeConstant.ExpressionTreeNodeConstant(0);

            Assert.That(testCase.Evaluate(ref variableContext), Is.EqualTo(Math.Pow(10, 0)));
        }

        /// <summary>
        /// Test case for when the subtrees are null.
        /// </summary>
        [Test]
        public void TestPowerEvaluationExceptionCaseOne()
        {
            Dictionary<string, double> variableContext = new Dictionary<string, double>();

            ExpressionTreeNodePowerOperator.ExpressionTreeNodePowerOperator testCase = new ExpressionTreeNodePowerOperator.ExpressionTreeNodePowerOperator();

            Assert.Throws<Exception>(() => testCase.Evaluate(ref variableContext));
        }

        /// <summary>
        /// Test case for when the right subtree is null.
        /// </summary>
        [Test]
        public void TestPowerEvaluationExceptionCaseTwo()
        {
            Dictionary<string, double> variableContext = new Dictionary<string, double>();

            ExpressionTreeNodePowerOperator.ExpressionTreeNodePowerOperator testCase = new ExpressionTreeNodePowerOperator.ExpressionTreeNodePowerOperator();

            testCase.LinkLeft = new ExpressionTreeNodeConstant.ExpressionTreeNodeConstant(1);

            Assert.Throws<Exception>(() => testCase.Evaluate(ref variableContext));
        }

        /// <summary>
        /// Test case for when the left subtree is null.
        /// </summary>
        [Test]
        public void TestPowerEvaluationExceptionCaseThree()
        {
            Dictionary<string, double> variableContext = new Dictionary<string, double>();

            ExpressionTreeNodePowerOperator.ExpressionTreeNodePowerOperator testCase = new ExpressionTreeNodePowerOperator.ExpressionTreeNodePowerOperator();

            testCase.LinkRight = new ExpressionTreeNodeConstant.ExpressionTreeNodeConstant(1);

            Assert.Throws<Exception>(() => testCase.Evaluate(ref variableContext));
        }

        /// <summary>
        /// Normal test case for the power.
        /// </summary>
        [Test]
        public void TestPowerEvaluationRegularCaseOne()
        {
            Dictionary<string, double> variableContext = new Dictionary<string, double>();

            ExpressionTreeNodePowerOperator.ExpressionTreeNodePowerOperator testCase = new ExpressionTreeNodePowerOperator.ExpressionTreeNodePowerOperator();

            testCase.LinkLeft = new ExpressionTreeNodeConstant.ExpressionTreeNodeConstant(10);

            testCase.LinkRight = new ExpressionTreeNodeConstant.ExpressionTreeNodeConstant(2);

            Assert.That(testCase.Evaluate(ref variableContext), Is.EqualTo(Math.Pow(10, 2)));
        }
    }
}