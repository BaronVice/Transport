using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Transport.CustomTable
{
    class TableManip
    {
        public static void clearChosenTable(GridTable gridTable)
        {
            gridTable.grid.Columns.Clear();
            gridTable.grid.Rows.Clear();
            gridTable.grid.Refresh();
        }

        public static void clearTables(List<GridTable> gridTables)
        {
            foreach (GridTable gridTable in gridTables)
            {
                clearChosenTable(gridTable);
            }
        }

        public static void buildTables(List<GridTable> gridTables)
        {
            clearTables(gridTables);

            foreach (GridTable gridTable in gridTables)
            {
                setTable(gridTable);
            }
            decorateTable(gridTables[2]);
        }

        public static void setTable(GridTable gridTable)
        {
            int width = Math.Max(951 / gridTable.columns, 80);
            for (int i = 0; i < gridTable.columns; i++)
            {
                gridTable.grid.Columns.Add("column" + gridTable.columnLetter + (i + 1).ToString(), gridTable.columnLetter + (i + 1).ToString());
                gridTable.grid.Columns[i].Width = width;
            }
            for (int i = 0; i < gridTable.rows; i++)
            {
                gridTable.grid.Rows.Add();
            }
        }

        public static void decorateTable(GridTable gridTable)
        {
            gridTable.grid[0, 0].Value = "A\\B";

            for (int i = 1; i < gridTable.columns; i++)
            {
                gridTable.grid[i, 0].Value = "B" + i.ToString();
            }

            for (int i = 1; i < gridTable.rows; i++)
            {
                gridTable.grid[0, i].Value = "A" + i.ToString();
            }

            gridTable.grid.Rows[0].ReadOnly = true;
            gridTable.grid.Columns[0].ReadOnly = true;
        }

        public static void checkCell(DataGridViewCellValidatingEventArgs e, bool isThird = false)
        {
            bool forParse = Convert.ToString(e.FormattedValue).All(char.IsDigit);
            
            if (isThird && (e.RowIndex==0 || e.ColumnIndex == 0)){

            }
            else if (!forParse)
            {
                e.Cancel = true;
            }

        }
    }
}
