using System;
using ExpressionTreeNodeConstant;

namespace ExpressionTreeNodeConstantTests
{
    /// <summary>
    /// Test cases for the expression tree node constant.
    /// </summary>
    public class ExpressionTreeNodeConstantTests
    {
        /// <summary>
        /// Regular test case one.
        /// </summary>
        [Test]
        public void TestConstantRegularCaseOne()
        {
            Dictionary<string, double> variableContext = new Dictionary<string, double>();

            ExpressionTreeNodeConstant.ExpressionTreeNodeConstant testCase = new ExpressionTreeNodeConstant.ExpressionTreeNodeConstant(1);

            Assert.That(testCase.Evaluate(ref variableContext), Is.EqualTo(1));
        }

        /// <summary>
        /// Regular test case two.
        /// </summary>
        [Test]
        public void TestConstantRegularCaseTwo()
        {
            Dictionary<string, double> variableContext = new Dictionary<string, double>();

            ExpressionTreeNodeConstant.ExpressionTreeNodeConstant testCase = new ExpressionTreeNodeConstant.ExpressionTreeNodeConstant(1000);

            Assert.That(testCase.Evaluate(ref variableContext), Is.EqualTo(1000));
        }
    }
}