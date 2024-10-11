using System;
using ExpressionTreeNodeOperator;

namespace ExpressionTreeNodeSubtractOperator
{
    /// <summary>
    /// Node representing the subtraction operation.
    /// </summary>
    internal class ExpressionTreeNodeSubtractOperator : ExpressionTreeNodeOperator.ExpressionTreeNodeOperator
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExpressionTreeNodeSubtractOperator"/> class.
        /// </summary>
        /// <param name="newLinkLeft">
        /// Link to the left expression subtree.
        /// </param>
        /// <param name="newLinkRight">
        /// Link to the right expression subtree.
        /// </param>
        public ExpressionTreeNodeSubtractOperator(ExpressionTreeNodeBase.ExpressionTreeNodeBase? newLinkLeft = null, ExpressionTreeNodeBase.ExpressionTreeNodeBase? newLinkRight = null)
            : base(newLinkLeft, newLinkRight)
        {
        }

        /// <summary>
        /// Evaluates the contents of a subtraction node.
        /// </summary>
        /// <param name="variableContext">
        /// Hash map for variable values.
        /// </param>
        /// <returns>
        /// Double representing evaluated subtree.
        /// </returns>
        /// <exception cref="Exception">
        /// If the tree is malformed.
        /// </exception>
        public override double Evaluate(ref Dictionary<string, double> variableContext)
        {
            if (this.linkLeft == null || this.linkRight == null)
            {
                throw new Exception("child of ExpressionTreeNodeSubtractOperator node was null");
            }

            return this.linkLeft.Evaluate(ref variableContext) - this.linkRight.Evaluate(ref variableContext);
        }
    }
}