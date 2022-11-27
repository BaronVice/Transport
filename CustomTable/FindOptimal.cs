using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Transport.CustomTable
{
    class FindOptimal
    {
        private static List<int> elementsOfProduce = new List<int>();
        private static List<int> elementsOfConsume = new List<int>();
        private static List<List<int>> elementsOfCosts = new List<List<int>>();
        private static List<List<int>> basisElements = new List<List<int>>();
        private static int tableColumns;
        private static int tableRows;

        public static void fillSolutionTables(GridTable A, GridTable B, GridTable Costs)
        {
            elementsOfProduce.Clear();
            elementsOfConsume.Clear();
            elementsOfCosts.Clear();

            tableRows = A.columns;
            tableColumns = B.columns;

            for (int i = 0; i < A.columns; i++)
            {
               elementsOfProduce.Add(int.Parse(A.grid[i, 0].Value.ToString()));
            }
            
            for (int i = 0; i < B.columns; i++)
            {
                elementsOfConsume.Add(int.Parse(B.grid[i, 0].Value.ToString()));
            }
            
            for (int i = 1; i < Costs.rows; i++)
            {
                List<int> currentRow = new List<int>();
                List<int> toBasis = new List<int>();
                for (int j = 1; j < Costs.columns; j++)
                {
                    currentRow.Add(int.Parse(Costs.grid[j, i].Value.ToString()));
                    toBasis.Add(0);
                }
                basisElements.Add(toBasis);
                elementsOfCosts.Add(currentRow);
            }
        }

        public static void findSolution()
        {
            int currentMaximum = 0;
            foreach (List<int> row in elementsOfCosts)
                foreach (int el in row)
                    currentMaximum = Math.Max(currentMaximum, el);

            int currentMinimum = 0;
            int minRowIndex = 0, minColumnIndex = 0, passed = 0;
            while (passed < tableColumns + tableRows)
            {
                currentMinimum = currentMaximum;
                for (int i = 0; i < tableRows; i++)
                {
                    for (int j = 0; j < tableColumns; j++)
                    {
                        if (currentMinimum > elementsOfCosts[i][j])
                        {
                            currentMinimum = elementsOfCosts[i][j];
                            minRowIndex = i;
                            minColumnIndex = j;
                        }
                    }
                }

                if (elementsOfProduce[minRowIndex] < elementsOfConsume[minColumnIndex])
                {
                    basisElements[minRowIndex][minColumnIndex] = elementsOfProduce[minRowIndex];
                    elementsOfConsume[minColumnIndex] -= elementsOfProduce[minRowIndex];
                    elementsOfProduce[minRowIndex] = 0;
                    for (int i = 0; i < tableRows; i++)
                        elementsOfCosts[minRowIndex][i] = currentMaximum + 1;
                }
                else
                {
                    basisElements[minRowIndex][minColumnIndex] = elementsOfConsume[minColumnIndex];
                    elementsOfProduce[minRowIndex] -= elementsOfConsume[minColumnIndex];
                    elementsOfConsume[minColumnIndex] = 0;
                    for (int i = 0; i < tableColumns; i++)
                        elementsOfCosts[i][minColumnIndex] = currentMaximum + 1;
                }

                passed++;
            }
        }
    }
}
