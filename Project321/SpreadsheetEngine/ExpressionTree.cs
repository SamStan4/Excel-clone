using System;

namespace ExpressionTree
{
    /// <summary>
    /// This is the expression tree class that will enable us to evaluate complex expressions that we can input into our spreadsheet application.
    /// </summary>
    public class ExpressionTree
    {
        private string? expression;

        private Dictionary<string, double> variableToValue;

        /// <summary>
        /// Initializes a new instance of the <see cref="ExpressionTree"/> class.
        /// </summary>
        /// <param name="newExpression">
        /// This is the mathematical expression that we wish to evaluate.
        /// </param>
        public ExpressionTree(string newExpression)
        {
            this.expression = newExpression;

            this.variableToValue = new Dictionary<string, double>();
        }

        /// <summary>
        /// Gets the expression data member.
        /// </summary>
        public string? Expression
        {
            get
            {
                return this.expression;
            }
        }

        /// <summary>
        /// This allows us to set the value of variables that we have inside of our expression tree.
        /// </summary>
        /// <param name="variableName">
        /// The name of the variable that we wish to specify value of.
        /// </param>
        /// <param name="variableValue">
        /// The value we wish to assign to variableName.
        /// </param>
        public void SetVariable(string variableName, double variableValue)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// This function will evaluate the contents of the expression tree.
        /// </summary>
        /// <returns>
        /// A double precision value representing the evaluated value of the expression tree.
        /// </returns>
        public double Evaluate()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Determines if a variable is present in an expression tree.
        /// </summary>
        /// <param name="variableName">
        /// This is the variable we wish to determine if it is present or not.
        /// </param>
        /// <returns>
        /// Bool representing if the varaible is in the tree or not.
        /// </returns>
        public bool HasVariable(string variableName)
        {
            throw new NotImplementedException();
        }
    }
}