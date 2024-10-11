using System;
using ExpressionTreeNodeOperator;

namespace ExpressionTreeNodePowerOperator
{
    /// <summary>
    /// Experssion Tree Node that represents the power operator.
    /// </summary>
    internal class ExpressionTreeNodePowerOperator : ExpressionTreeNodeOperator.ExpressionTreeNodeOperator
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExpressionTreeNodePowerOperator"/> class.
        /// </summary>
        /// <param name="newLinkLeft">
        /// Link to the left expression subtree.
        /// </param>
        /// <param name="newLinkRight">
        /// Link to the right expression subtree.
        /// </param>
        public ExpressionTreeNodePowerOperator(ExpressionTreeNodeBase.ExpressionTreeNodeBase? newLinkLeft = null, ExpressionTreeNodeBase.ExpressionTreeNodeBase? newLinkRight = null)
            : base(newLinkLeft, newLinkRight)
        {
        }

        /// <summary>
        /// Evaluates the power operation.
        /// </summary>
        /// <param name="variableContext">
        /// Represents teh variable context for nodes that hold variables.
        /// </param>
        /// <returns>
        /// Double representing the evaluated result.
        /// </returns>
        public override double Evaluate(ref Dictionary<string, double> variableContext)
        {
            if (this.linkLeft == null || this.linkRight == null)
            {
                throw new Exception("child of ExpressionTreeNodePowerOperator node was null");
            }

            return Math.Pow(this.linkLeft.Evaluate(ref variableContext), this.linkRight.Evaluate(ref variableContext));
        }
    }
}