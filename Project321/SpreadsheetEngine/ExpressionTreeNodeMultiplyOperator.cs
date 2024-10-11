using System;
using ExpressionTreeNodeOperator;

namespace ExpressionTreeNodeMultiplyOperator
{
    /// <summary>
    /// Expression tree node representing the multiplication operation.
    /// </summary>
    internal class ExpressionTreeNodeMultiplyOperator : ExpressionTreeNodeOperator.ExpressionTreeNodeOperator
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExpressionTreeNodeMultiplyOperator"/> class.
        /// </summary>
        /// <param name="newLinkLeft">
        /// New left subtree.
        /// </param>
        /// <param name="newLinkRight">
        /// New right subtree.
        /// </param>
        public ExpressionTreeNodeMultiplyOperator(ExpressionTreeNodeBase.ExpressionTreeNodeBase? newLinkLeft = null, ExpressionTreeNodeBase.ExpressionTreeNodeBase? newLinkRight = null)
            : base(newLinkLeft, newLinkRight)
        {
        }

        /// <summary>
        /// Evaluates the subtree.
        /// </summary>
        /// <param name="variableContext">
        /// This is so we have variable representation in the subtrees.
        /// </param>
        /// <returns>
        /// Double representing the evaluated content.
        /// </returns>
        public override double Evaluate(ref Dictionary<string, double> variableContext)
        {
            if (this.linkLeft == null || this.linkRight == null)
            {
                throw new Exception("child of ExpressionTreeNodeMultiplyOperator node was null");
            }

            return this.linkLeft.Evaluate(ref variableContext) * this.linkRight.Evaluate(ref variableContext);
        }
    }
}