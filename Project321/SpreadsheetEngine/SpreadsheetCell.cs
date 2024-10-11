using System;
using Cell;

namespace SpreadsheetCell
{
    /// <summary>
    /// The concrete class for cell.
    /// </summary>
    public class SpreadsheetCell : Cell.Cell
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SpreadsheetCell"/> class.
        /// </summary>
        /// <param name="newRowIdx">
        /// the given row index of the cell.
        /// </param>
        /// <param name="newColIdx">
        /// the given column index of the cell.
        /// </param>
        public SpreadsheetCell(int newRowIdx, int newColIdx)
            : base(newRowIdx, newColIdx)
        {
        }
    }
}