using System;
using ExpressionTreeNodeAddOperator;
using ExpressionTreeNodeConstant;

namespace ExpressionTreeNodeAddOperatorTests
{
    /// <summary>
    /// Test cases for the expression tree node add class.
    /// </summary>
    public class ExpressionTreeNodeAddOperatorTests
    {
        /// <summary>
        /// Tests the edge case for the expression tree addition nodes where the result of evaluate is very large.
        /// </summary>
        [Test]
        public void TestAddEvaluationEdgeCaseOne()
        {
            Dictionary<string, double> variableContext = new Dictionary<string, double>();

            ExpressionTreeNodeAddOperator.ExpressionTreeNodeAddOperator testCase = new ExpressionTreeNodeAddOperator.ExpressionTreeNodeAddOperator();

            testCase.LinkLeft = new ExpressionTreeNodeConstant.ExpressionTreeNodeConstant(double.MaxValue);

            testCase.LinkRight = new ExpressionTreeNodeConstant.ExpressionTreeNodeConstant(double.MaxValue);

            Assert.That(testCase.Evaluate(ref variableContext), Is.EqualTo(double.PositiveInfinity));
        }

        /// <summary>
        /// Tests the edge case for the expression tree addition class when nodes are very negative.
        /// </summary>
        [Test]
        public void TestAddEvaluationEdgeCaseTwo()
        {
            Dictionary<string, double> variableContext = new Dictionary<string, double>();

            ExpressionTreeNodeAddOperator.ExpressionTreeNodeAddOperator testCase = new ExpressionTreeNodeAddOperator.ExpressionTreeNodeAddOperator();

            testCase.LinkLeft = new ExpressionTreeNodeConstant.ExpressionTreeNodeConstant(double.MinValue);

            testCase.LinkRight = new ExpressionTreeNodeConstant.ExpressionTreeNodeConstant(double.MinValue);

            Assert.That(testCase.Evaluate(ref variableContext), Is.EqualTo(double.NegativeInfinity));
        }

        /// <summary>
        /// Exceptional test case for the node.
        /// Both subtrees are null.
        /// </summary>
        [Test]
        public void TestCaseEvaluateExceptionalCaseOne()
        {
            Dictionary<string, double> variableContext = new Dictionary<string, double>();

            ExpressionTreeNodeAddOperator.ExpressionTreeNodeAddOperator testCase = new ExpressionTreeNodeAddOperator.ExpressionTreeNodeAddOperator();

            Assert.Throws<Exception>(() => testCase.Evaluate(ref variableContext));
        }

        /// <summary>
        /// Exceptional test case for the node.
        /// Right subtree is null.
        /// </summary>
        [Test]
        public void TestCaseEvaluateExceptionalCaseTwo()
        {
            Dictionary<string, double> variableContext = new Dictionary<string, double>();

            ExpressionTreeNodeAddOperator.ExpressionTreeNodeAddOperator testCase = new ExpressionTreeNodeAddOperator.ExpressionTreeNodeAddOperator();

            testCase.LinkLeft = new ExpressionTreeNodeConstant.ExpressionTreeNodeConstant(1);

            Assert.Throws<Exception>(() => testCase.Evaluate(ref variableContext));
        }

        /// <summary>
        /// Exceptional test case for the node.
        /// Right subtree is null.
        /// </summary>
        [Test]
        public void TestCaseEvaluateExceptionalCaseThree()
        {
            Dictionary<string, double> variableContext = new Dictionary<string, double>();

            ExpressionTreeNodeAddOperator.ExpressionTreeNodeAddOperator testCase = new ExpressionTreeNodeAddOperator.ExpressionTreeNodeAddOperator();

            testCase.LinkRight = new ExpressionTreeNodeConstant.ExpressionTreeNodeConstant(1);

            Assert.Throws<Exception>(() => testCase.Evaluate(ref variableContext));
        }

        /// <summary>
        /// Tests regular test case 1 + 1.
        /// </summary>
        [Test]
        public void TestCaseEvaluateRegularCaseOne()
        {
            Dictionary<string, double> variableContext = new Dictionary<string, double>();

            ExpressionTreeNodeAddOperator.ExpressionTreeNodeAddOperator testCase = new ExpressionTreeNodeAddOperator.ExpressionTreeNodeAddOperator();

            testCase.LinkRight = new ExpressionTreeNodeConstant.ExpressionTreeNodeConstant(1);

            testCase.LinkLeft = new ExpressionTreeNodeConstant.ExpressionTreeNodeConstant(1);

            Assert.That(testCase.Evaluate(ref variableContext), Is.EqualTo(1 + 1));
        }
    }
}