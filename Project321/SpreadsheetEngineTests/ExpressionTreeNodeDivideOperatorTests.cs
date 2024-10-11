using System;
using ExpressionTreeNodeBase;
using ExpressionTreeNodeDivideOperator;

namespace ExpressionTreeNodeDivideOperatorTests
{
    /// <summary>
    /// Test cases for the ExpressionTreeNodeDivideOperator class.
    /// </summary>
    public class ExpressionTreeNodeDivideOperatorTests
    {
        /// <summary>
        /// Divide by zero case.
        /// </summary>
        [Test]
        public void TestDivideEvaluationEdgeCaseOne()
        {
            Dictionary<string, double> variableContext = new Dictionary<string, double>();

            double numerator = 1, denominator = 0;

            ExpressionTreeNodeDivideOperator.ExpressionTreeNodeDivideOperator testCase = new ExpressionTreeNodeDivideOperator.ExpressionTreeNodeDivideOperator();

            testCase.LinkLeft = new ExpressionTreeNodeConstant.ExpressionTreeNodeConstant(numerator);

            testCase.LinkRight = new ExpressionTreeNodeConstant.ExpressionTreeNodeConstant(denominator);

            Assert.That(testCase.Evaluate(ref variableContext), Is.EqualTo(numerator / denominator));
        }

        /// <summary>
        /// Large quotent case.
        /// </summary>
        [Test]
        public void TestDivideEvaluationEdgeCaseTwo()
        {
            Dictionary<string, double> variableContext = new Dictionary<string, double>();

            double numerator = double.MaxValue, denominator = 0.00001;

            ExpressionTreeNodeDivideOperator.ExpressionTreeNodeDivideOperator testCase = new ExpressionTreeNodeDivideOperator.ExpressionTreeNodeDivideOperator();

            testCase.LinkLeft = new ExpressionTreeNodeConstant.ExpressionTreeNodeConstant(numerator);

            testCase.LinkRight = new ExpressionTreeNodeConstant.ExpressionTreeNodeConstant(denominator);

            Assert.That(testCase.Evaluate(ref variableContext), Is.EqualTo(numerator / denominator));
        }

        /// <summary>
        /// Both subtrees empty.
        /// </summary>
        [Test]
        public void TestDivideEvaluationExceptionalCaseOne()
        {
            Dictionary<string, double> variableContext = new Dictionary<string, double>();

            ExpressionTreeNodeDivideOperator.ExpressionTreeNodeDivideOperator testCase = new ExpressionTreeNodeDivideOperator.ExpressionTreeNodeDivideOperator();

            Assert.Throws<Exception>(() => testCase.Evaluate(ref variableContext));
        }

        /// <summary>
        /// Right subtree empty.
        /// </summary>
        [Test]
        public void TestDivideEvaluationExceptionalCaseTwo()
        {
            Dictionary<string, double> variableContext = new Dictionary<string, double>();

            ExpressionTreeNodeDivideOperator.ExpressionTreeNodeDivideOperator testCase = new ExpressionTreeNodeDivideOperator.ExpressionTreeNodeDivideOperator();

            testCase.LinkLeft = new ExpressionTreeNodeConstant.ExpressionTreeNodeConstant(1);

            Assert.Throws<Exception>(() => testCase.Evaluate(ref variableContext));
        }

        /// <summary>
        /// Left subtree empty.
        /// </summary>
        [Test]
        public void TestDivideEvaluationExceptionalCaseTHree()
        {
            Dictionary<string, double> variableContext = new Dictionary<string, double>();

            ExpressionTreeNodeDivideOperator.ExpressionTreeNodeDivideOperator testCase = new ExpressionTreeNodeDivideOperator.ExpressionTreeNodeDivideOperator();

            testCase.LinkRight = new ExpressionTreeNodeConstant.ExpressionTreeNodeConstant(1);

            Assert.Throws<Exception>(() => testCase.Evaluate(ref variableContext));
        }

        /// <summary>
        /// Divide by zero case.
        /// </summary>
        [Test]
        public void TestDivideEvaluationRegularCaseOne()
        {
            Dictionary<string, double> variableContext = new Dictionary<string, double>();

            double numerator = 2, denominator = 1;

            ExpressionTreeNodeDivideOperator.ExpressionTreeNodeDivideOperator testCase = new ExpressionTreeNodeDivideOperator.ExpressionTreeNodeDivideOperator();

            testCase.LinkLeft = new ExpressionTreeNodeConstant.ExpressionTreeNodeConstant(numerator);

            testCase.LinkRight = new ExpressionTreeNodeConstant.ExpressionTreeNodeConstant(denominator);

            Assert.That(testCase.Evaluate(ref variableContext), Is.EqualTo(numerator / denominator));
        }
    }
}