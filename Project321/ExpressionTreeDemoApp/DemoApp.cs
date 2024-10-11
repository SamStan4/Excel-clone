using System;
using ExpressionTree;

namespace DemoApp
{
    /// <summary>
    /// This is the class that will run the application.
    /// </summary>
    internal class DemoApp
    {
        private ExpressionTree.ExpressionTree? expressionTree;

        /// <summary>
        /// Initializes a new instance of the <see cref="DemoApp"/> class.
        /// </summary>
        public DemoApp()
        {
            this.expressionTree = null;
        }

        /// <summary>
        /// This will start the loop that will run the application.
        /// </summary>
        public void RunApp()
        {
            int decision = 0;

            do
            {
                Console.Clear();
                this.ShowMenu();

                try
                {
                    decision = this.GetUsersMenuChoice();

                    switch (decision)
                    {
                        case 1:
                            this.SetNewExpression();
                            break;
                        case 2:
                            this.SetExpressionVariable();
                            break;
                        case 3:
                            Console.WriteLine("decision 3");
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("\nError, enter a number cooresponding to a choice on the list");
                }

                Console.WriteLine("\npress any key...");
                Console.ReadKey();

            } while (decision != 4);
        }

        /// <summary>
        /// This function will show the menu options to the user.
        /// </summary>
        private void ShowMenu()
        {
            string? expression = string.Empty;

            if (this.expressionTree != null)
            {
                expression = this.expressionTree.Expression;
            }

            Console.Write(
                "Menu (Current expression = \"" + expression + "\")\n" +
                "  1 = Enter a new expression\n" +
                "  2 = Set a variable value\n" +
                "  3 = Evaluate tree\n" +
                "  4 = Quit\n\n" +
                "  Enter:  ");
        }

        /// <summary>
        /// Trys to get the users input.
        /// </summary>
        /// <returns>
        /// Returns the valud integer choice from the user.
        /// </returns>
        /// <exception cref="Exception">
        /// If the user enters something not on the list of options.
        /// </exception>
        private int GetUsersMenuChoice()
        {
            string? userInput = Console.ReadLine();

            if (!int.TryParse(userInput, out int number))
            {
                throw new Exception("Invalid user input");
            }

            if ((number > 4) || (number < 1))
            {
                throw new Exception("Invalid user input");
            }

            return number;
        }

        /// <summary>
        /// This function will set a new expression for the expression tree.
        /// </summary>
        private void SetNewExpression()
        {
            Console.Write("\nEnter new expression here: ");

            string? newExpression = Console.ReadLine();

            if (newExpression != null)
            {
                try
                {
                    this.expressionTree = new ExpressionTree.ExpressionTree(newExpression);
                }
                catch
                {
                    Console.WriteLine("\nError parsing your input");

                    this.expressionTree = null;
                }
            }
        }

        /// <summary>
        /// Sets one of the expression variables in the expression tree.
        /// </summary>
        private void SetExpressionVariable()
        {
            // we first check if we have a valid expression tree to work with.
            if (this.expressionTree == null)
            {
                Console.WriteLine("Error, no expression tree loaded");

                return;
            }

            Console.Write("\nEnter in the variable you want to set here: ");

            string? targetVariable = Console.ReadLine();

            if (targetVariable == null)
            {
                Console.WriteLine("Error, couldnt read user input");

                return;
            }

            if (!this.expressionTree.HasVariable(targetVariable))
            {
                Console.WriteLine($"Error, {targetVariable} does not exist in the expression");

                return;
            }

            Console.Write("\nEnter in the value you wish to set the variable to: ");

            string? newValue = Console.ReadLine();

            if (newValue == null)
            {
                Console.WriteLine("Error, coutdnt read user input");

                return;
            }

            if (!double.TryParse(newValue, out double number))
            {
                Console.WriteLine($"Error, {newValue} is not a valid number");

                return;
            }

            this.expressionTree.SetVariable(targetVariable, number);
        }
    }
}