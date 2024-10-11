using System;
using System.Collections.Specialized;
using System.ComponentModel;

namespace Cell
{
    /// <summary>
    /// This is the class that is going to serve as the blueprint for the data grid cell in our winforms project.
    /// </summary>
    public abstract class Cell : INotifyPropertyChanged
    {
        /// <summary>
        /// this represents the text that the user will see in the cell.
        /// </summary>
        protected string visibleText;

        /// <summary>
        /// This represents the text that the user actually puts into the cell.
        /// </summary>
        protected string hiddenText;

        private int rowIdx;
        private int colIdx;

        /// <summary>
        /// Initializes a new instance of the <see cref="Cell"/> class.
        /// </summary>
        /// <param name="newRowIdx">
        /// represents the row that the cell is in the grid.
        /// </param>
        /// <param name="newColIdx">
        /// represents the col that the cell is in the grid.
        /// </param>
        protected Cell(int newRowIdx, int newColIdx)
        {
            this.rowIdx = newRowIdx;
            this.colIdx = newColIdx;

            this.visibleText = string.Empty;
            this.hiddenText = string.Empty;

            this.PropertyChanged = delegate { };
        }

        /// <summary>
        /// Observer list for state change of the cell's visible text.
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// Gets the rowIdx data member.
        /// </summary>
        public int RowIdx
        {
            get
            {
                return this.rowIdx;
            }
        }

        /// <summary>
        /// Gets the colIdx data member.
        /// </summary>
        public int ColIdx
        {
            get
            {
                return this.colIdx;
            }
        }

        /// <summary>
        /// Gets or sets the hiddenText data member.
        /// </summary>
        public string HiddenText
        {
            get
            {
                return this.hiddenText;
            }

            set
            {
                if (this.hiddenText == value)
                {
                    return;
                }

                this.hiddenText = value;

                if (this.PropertyChanged == null)
                {
                    return;
                }

                this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(this.HiddenText)));
            }
        }

        /// <summary>
        /// Gets the visibleText member.
        /// </summary>
        public string VisibleText
        {
            get
            {
                return this.visibleText;
            }

            internal set
            {
                this.visibleText = value;
            }
        }

        /// <summary>
        /// This funciton returns true if the cell is an equation, false otherwise.
        /// </summary>
        /// <returns>
        /// Boolean representing if the cell is an equation.
        /// </returns>
        public bool IsEquation()
        {
            string s = this.hiddenText.Replace(" ", string.Empty);

            if (s.Length == 0)
            {
                return false;
            }

            return s[0] == '=';
        }
    }
}