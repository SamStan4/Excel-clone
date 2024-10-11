using System;
using ExpressionTreeNodeBase;

namespace ExpressionTreeNodeConstant
{
    /// <summary>
    /// This is the node class that represents constant values.
    /// </summary>
    internal class ExpressionTreeNodeConstant : ExpressionTreeNodeBase.ExpressionTreeNodeBase
    {
        private double constantValue;

        /// <summary>
        /// Initializes a new instance of the <see cref="ExpressionTreeNodeConstant"/> class.
        /// </summary>
        /// <param name="newConstantValue">
        /// The constant double value that we are setting our node equal to.
        /// </param>
        public ExpressionTreeNodeConstant(double newConstantValue)
        {
            this.constantValue = newConstantValue;
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
            return this.constantValue;
        }
    }
}