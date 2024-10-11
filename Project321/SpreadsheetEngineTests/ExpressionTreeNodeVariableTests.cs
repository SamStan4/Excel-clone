using System;
using ExpressionTreeNodeVariable;

namespace ExpressionTreeNodeVariableTests
{
    /// <summary>
    /// Test cases for variable expression tree nodes.
    /// </summary>
    public class ExpressionTreeNodeVariableTests
    {
        /// <summary>
        /// Test case where the node throws an exveption.
        /// </summary>
        [Test]
        public void TestVariableEvaluationExceptionalCaseOne()
        {
            string key = "someVariable";

            Dictionary<string, double> variableContext = new Dictionary<string, double>();

            ExpressionTreeNodeVariable.ExpressionTreeNodeVariable testCase = new ExpressionTreeNodeVariable.ExpressionTreeNodeVariable(key);

            Assert.Throws<Exception>(() => testCase.Evaluate(ref variableContext));
        }

        /// <summary>
        /// Regular test case for variable node.
        /// </summary>
        [Test]
        public void TestVariableEvaluationRegularCaseOne()
        {
            string key = "someVariable";

            double value = 1.0;

            Dictionary<string, double> variableContext = new Dictionary<string, double>();

            variableContext[key] = value;

            ExpressionTreeNodeVariable.ExpressionTreeNodeVariable testCase = new ExpressionTreeNodeVariable.ExpressionTreeNodeVariable(key);

            Assert.That(testCase.Evaluate(ref variableContext), Is.EqualTo(value));
        }
    }
}