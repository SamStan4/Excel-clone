using System;

namespace ExpressionTreeNodeBase
{
    /// <summary>
    /// This is the base class for the expression tree nodes.
    /// </summary>
    internal abstract class ExpressionTreeNodeBase
    {
        /// <summary>
        /// Meant for evaluating subtrees within the expression tree.
        /// </summary>
        /// <param name="variableContext">
        /// Variable context so we can evaluate expressions with variables.
        /// </param>
        /// <returns>
        /// Evaluated double.
        /// </returns>
        public abstract double Evaluate(ref Dictionary<string, double> variableContext);
    }
}