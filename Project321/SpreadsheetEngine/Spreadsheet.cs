using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using SpreadsheetCell;

namespace Spreadsheet
{
    /// <summary>
    /// This is the spreadsheet class that will take care of all of the logic behind the spreadsheet UI.
    /// </summary>
    public class Spreadsheet : INotifyPropertyChanged
    {
        private SpreadsheetCell.SpreadsheetCell[,] cellGrid;

        /// <summary>
        /// Initializes a new instance of the <see cref="Spreadsheet"/> class.
        /// </summary>
        /// <param name="numRows">
        /// Represents the number of rows that we are going to have in our spreadsheet.
        /// </param>
        /// <param name="numCols">
        /// Represent the number of columns that we are going to have in our spreadsheet.
        /// </param>
        public Spreadsheet(int numRows, int numCols)
        {
            this.cellGrid = new SpreadsheetCell.SpreadsheetCell[numRows, numCols];

            for (int i = 0; i < numRows; ++i)
            {
                for (int j = 0; j < numCols; ++j)
                {
                    this.cellGrid[i, j] = new SpreadsheetCell.SpreadsheetCell(i, j);
                    this.cellGrid[i, j].PropertyChanged += this.CellPropertyChangedEventHandler;
                }
            }

            this.PropertyChanged = delegate { };
        }

        /// <summary>
        /// List of observers for when this one of the cells has an event.
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// Runs the demo of the cells working.
        /// </summary>
        public void RunSpreadsheetDemo()
        {
            // step one, set the random values
            Random random = new Random();

            for (int i = 0; i < 50; ++i)
            {
                int randRow = random.Next(0, this.cellGrid.GetLength(0));
                int randCol = random.Next(0, this.cellGrid.GetLength(1));

                this.cellGrid[randRow, randCol].HiddenText = "I tolerate C#";
            }

            // step two, set the B column
            for (int i = 0; i < this.cellGrid.GetLength(0); ++i)
            {
                this.cellGrid[i, 1].HiddenText = "This is cell B" + (i + 1).ToString();
            }

            // step three, set the A column
            for (int i = 0; i < this.cellGrid.GetLength(0); ++i)
            {
                this.cellGrid[i, 0].HiddenText = "=B" + (i + 1).ToString();
            }
        }

        /// <summary>
        /// This function handles the event when there is a cell in the application that has an event.
        /// </summary>
        /// <param name="sender">
        /// A cell reference to the cell that is changing.
        /// </param>
        /// <param name="e">
        /// The function that is sending the event.
        /// </param>
        private void CellPropertyChangedEventHandler(object sender, PropertyChangedEventArgs e)
        {
            Cell.Cell senderCell = (Cell.Cell)sender;

            if (senderCell == null)
            {
                return;
            }

            if (this.PropertyChanged == null)
            {
                return;
            }

            this.UpdateCellVisibleText(senderCell);

            // pass this on through.
            this.PropertyChanged.Invoke(sender, e);
        }

        /// <summary>
        /// this function will update the cell's visible text.
        /// </summary>
        /// <param name="updateCell">
        /// A reference to the cell that we are going to change.
        /// </param>
        private void UpdateCellVisibleText(Cell.Cell updateCell)
        {
            if (!updateCell.IsEquation())
            {
                updateCell.VisibleText = updateCell.HiddenText;

                return;
            }

            Cell.Cell? sourceCell = this.GetCell(updateCell.HiddenText);

            if (sourceCell == null)
            {
                updateCell.VisibleText = "Error";

                return;
            }

            updateCell.VisibleText = sourceCell.VisibleText;
        }

        private Cell.Cell? GetCell(string cellReference)
        {
            string s = cellReference.Replace(" ", string.Empty).Replace("=", string.Empty);

            if (!Utils.Utils.MatchesCellReferencePattern(s))
            {
                return null;
            }

            int i = 0;

            StringBuilder sbOne = new StringBuilder();
            StringBuilder sbTwo = new StringBuilder();

            // build out the base 26 number
            for (i = 0; i < s.Length && char.IsUpper(s[i]); ++i)
            {
                sbOne.Append(s[i]);
            }

            for (; i < s.Length; ++i)
            {
                sbTwo.Append(s[i]);
            }

            if (sbOne.Length == 0 || sbTwo.Length == 0)
            {
                return null;
            }

            int row = int.Parse(sbTwo.ToString()) - 1;
            int col = Utils.Utils.Base26ToInt(sbOne.ToString());

            return this.GetCell(row, col);
        }

        /// <summary>
        /// One of the getters of cells in the spreadsheet class.
        /// </summary>
        /// <param name="rowIdx">
        /// The desired row.
        /// </param>
        /// <param name="colIdx">
        /// The desired column.
        /// </param>
        /// <returns>
        /// Returns a cell.
        /// </returns>
        private Cell.Cell? GetCell(int rowIdx, int colIdx)
        {
            if (rowIdx < 0 || colIdx < 0 || rowIdx >= this.cellGrid.GetLength(0) || colIdx >= this.cellGrid.GetLength(1))
            {
                return null;
            }

            return this.cellGrid[rowIdx, colIdx];
        }
    }
}