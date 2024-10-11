// Samuel Stanley
// 11818268

using System;
using System.Collections.Specialized;
using System.ComponentModel;
using Spreadsheet;

namespace Spreadsheet_Samuel_Stanley
{
    /// <summary>
    /// Form class for the user interface.
    /// </summary>
    public partial class Form1 : Form
    {
        private Spreadsheet.Spreadsheet cellSheet;

        /// <summary>
        /// Initializes a new instance of the <see cref="Form1"/> class.
        /// </summary>
        public Form1()
        {
            this.InitializeComponent();
            this.InitializeDataGrid(50, 26);
            this.cellSheet = new Spreadsheet.Spreadsheet(50, 26);
            this.cellSheet.PropertyChanged += this.CellPropertyChangedEventHandler;
        }

        /// <summary>
        /// Event handler for the button being pressed.
        /// </summary>
        /// <param name="sender">
        /// reference to the object that triggered the event.
        /// </param>
        /// <param name="e">
        /// Event args.
        /// </param>
        private void ButtonDemo_Click(object sender, EventArgs e)
        {
            this.cellSheet.RunSpreadsheetDemo();
        }

        /// <summary>
        /// Initializes the data grid UI componet.
        /// </summary>
        /// <param name="newNumRows">
        /// this is the numebr of rows that we are going to have in our application.
        /// </param>
        /// <param name="newNumCols">
        /// this is the numebr of columns that we are going to have in our application.
        /// </param>
        private void InitializeDataGrid(int newNumRows, int newNumCols)
        {
            // set the number of rows and columns for the applicaiton
            this.dataGridView1.ColumnCount = newNumCols;
            this.dataGridView1.RowCount = newNumRows;

            // set the row and column headers to visible so we can see our cool work
            this.dataGridView1.RowHeadersVisible = true;
            this.dataGridView1.ColumnHeadersVisible = true;

            // this just looks the best in my opinion
            this.dataGridView1.RowHeadersWidth = 70;

            // this initializes the column headers
            for (int i = 0; i < newNumCols; ++i)
            {
                this.dataGridView1.Columns[i].Name = Utils.Utils.IntToBase26(i);
            }

            // this initializes the row headers
            for (int i = 0; i < newNumRows; ++i)
            {
                this.dataGridView1.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
        }

        /// <summary>
        /// Handles the event where a cell changes its state.
        /// </summary>
        /// <param name="sender">
        /// This is the object that is sending the change.
        /// </param>
        /// <param name="e">
        /// This is the function/property that made the change.
        /// </param>
        private void CellPropertyChangedEventHandler(object sender, PropertyChangedEventArgs e)
        {
            Cell.Cell changedCell = (Cell.Cell)sender;

            this.dataGridView1.Rows[changedCell.RowIdx].Cells[changedCell.ColIdx].Value = changedCell.VisibleText;
        }
    }
}