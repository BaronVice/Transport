﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Transport
{
    class GridTable
    {
        public GridTable() { }

        public GridTable(DataGridView grid, int columns, int rows, string columnLetter)
        {
            this.grid = grid;
            this.columns = columns;
            this.rows = rows;
            this.columnLetter = columnLetter;
        }

        public DataGridView grid { get; set; }
        public int columns { get; set; }
        public int rows { get; set; }
        public string columnLetter { get; set; }

        public void setArguments(DataGridView grid, int columns, int rows, string columnLetter)
        {
            this.grid = grid;
            this.columns = columns;
            this.rows = rows;
            this.columnLetter = columnLetter;
        }
    }
}
