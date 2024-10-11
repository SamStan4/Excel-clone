using System;
using ExpressionTreeNodeBase;

namespace ExpressionTreeNodeOperator
{
    /// <summary>
    /// Base class for operator nodes.
    /// </summary>
    internal abstract class ExpressionTreeNodeOperator : ExpressionTreeNodeBase.ExpressionTreeNodeBase
    {
        /// <summary>
        /// Left subtree.
        /// </summary>
        protected ExpressionTreeNodeBase.ExpressionTreeNodeBase? linkLeft;

        /// <summary>
        /// Right subtree.
        /// </summary>
        protected ExpressionTreeNodeBase.ExpressionTreeNodeBase? linkRight;

        /// <summary>
        /// Initializes a new instance of the <see cref="ExpressionTreeNodeOperator"/> class.
        /// </summary>
        /// <param name="linkLeft">
        /// The left subtree.
        /// </param>
        /// <param name="linkRight">
        /// The right subtree.
        /// </param>
        protected ExpressionTreeNodeOperator(ExpressionTreeNodeBase.ExpressionTreeNodeBase? linkLeft, ExpressionTreeNodeBase.ExpressionTreeNodeBase? linkRight)
        {
            this.linkLeft = linkLeft;
            this.linkRight = linkRight;
        }

        /// <summary>
        /// Gets or sets the linkLeft data member.
        /// </summary>
        public ExpressionTreeNodeBase.ExpressionTreeNodeBase? LinkLeft
        {
            get
            {
                return this.linkLeft;
            }

            set
            {
                this.linkLeft = value;
            }
        }

        /// <summary>
        /// Gets or sets the linkRight data member.
        /// </summary>
        public ExpressionTreeNodeBase.ExpressionTreeNodeBase? LinkRight
        {
            get
            {
                return this.linkRight;
            }

            set
            {
                this.linkRight = value;
            }
        }
    }
}