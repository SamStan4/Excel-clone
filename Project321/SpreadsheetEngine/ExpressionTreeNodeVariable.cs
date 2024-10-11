using System;
using ExpressionTreeNodeBase;

namespace ExpressionTreeNodeVariable
{
    /// <summary>
    /// This class represents nodes that are variables in the tree.
    /// </summary>
    internal class ExpressionTreeNodeVariable : ExpressionTreeNodeBase.ExpressionTreeNodeBase
    {
        private string variableName;

        /// <summary>
        /// Initializes a new instance of the <see cref="ExpressionTreeNodeVariable"/> class.
        /// </summary>
        /// <param name="newVariableName">
        /// The new variable name that we are going to have in our program.
        /// </param>
        public ExpressionTreeNodeVariable(string newVariableName)
        {
            this.variableName = newVariableName;
        }

        /// <summary>
        /// Evaluates the content of the node.
        /// </summary>
        /// <param name="variableContext">
        /// This represents the variable context.
        /// </param>
        /// <returns>
        /// evaluated double result.
        /// </returns>
        public override double Evaluate(ref Dictionary<string, double> variableContext)
        {
            if (!variableContext.ContainsKey(this.variableName))
            {
                throw new Exception($"value for {this.variableName} not given");
            }
            else if (variableContext[this.variableName] == null)
            {
                throw new Exception($"value for {this.variableName} was null");
            }

            return variableContext[this.variableName];
        }
    }
}