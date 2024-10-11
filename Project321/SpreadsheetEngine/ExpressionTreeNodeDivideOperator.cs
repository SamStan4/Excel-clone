using System;
using ExpressionTreeNodeOperator;

namespace ExpressionTreeNodeDivideOperator
{
    /// <summary>
    /// Node for divisioin operators.
    /// </summary>
    internal class ExpressionTreeNodeDivideOperator : ExpressionTreeNodeOperator.ExpressionTreeNodeOperator
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExpressionTreeNodeDivideOperator"/> class.
        /// </summary>
        /// <param name="newLinkLeft">
        /// New left subtree.
        /// </param>
        /// <param name="newLinkRight">
        /// New right subtree.
        /// </param>
        public ExpressionTreeNodeDivideOperator(ExpressionTreeNodeBase.ExpressionTreeNodeBase? newLinkLeft = null, ExpressionTreeNodeBase.ExpressionTreeNodeBase? newLinkRight = null)
            : base(newLinkLeft, newLinkRight)
        {
        }

        /// <summary>
        /// Evaluates the division operator.
        /// </summary>
        /// <param name="variableContext">
        /// Context for variable nodes.
        /// </param>
        /// <returns>
        /// Returns the evaluated value.
        /// </returns>
        public override double Evaluate(ref Dictionary<string, double> variableContext)
        {
            if (this.linkLeft == null || this.linkRight == null)
            {
                throw new Exception("child of ExpressionTreeNodeMultiplyOperator node was null");
            }

            return this.linkLeft.Evaluate(ref variableContext) / this.linkRight.Evaluate(ref variableContext);
        }
    }
}