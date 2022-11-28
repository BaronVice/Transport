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

        private static List<int> potU = new List<int>();
        private static List<int> potV = new List<int>();

        private static List<int> potUFinal = new List<int>();
        private static List<int> potVFinal = new List<int>();

        private static List<List<int>> relScore = new List<List<int>>();

        private static int tableColumns;
        private static int tableRows;

        // Заполнение коллекций из таблиц
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
                for (int j = 1; j < Costs.columns; j++)
                    currentRow.Add(int.Parse(Costs.grid[j, i].Value.ToString()));
                
                elementsOfCosts.Add(currentRow);
            }
        }

        // Сброс данных списка
        private static void reloadList(List<int> l, int length)
        {
            l.Clear();
            for (int i = 0; i < length; i++)
                l.Add(0);
        }

        // Сброс данных матрицы
        private static void reloadMatrix(List<List<int>> m)
        {
            m.Clear();
            for (int i = 0; i < tableRows; i++)
            {
                List<int> row = new List<int>();
                for (int j = 0; j < tableColumns; j++)
                    row.Add(0);

                m.Add(row);
            }
            
        }

        // Составление опорного плана
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
                    for (int i = 0; i < tableColumns; i++)
                        elementsOfCosts[minRowIndex][i] = currentMaximum + 1;
                }
                else
                {
                    basisElements[minRowIndex][minColumnIndex] = elementsOfConsume[minColumnIndex];
                    elementsOfProduce[minRowIndex] -= elementsOfConsume[minColumnIndex];
                    elementsOfConsume[minColumnIndex] = 0;
                    for (int i = 0; i < tableRows; i++)
                        elementsOfCosts[i][minColumnIndex] = currentMaximum + 1;
                }

                passed++;
            }

            for (int i = 0; i < tableRows; i++)
                for (int j = 0; j < tableColumns; j++)
                    if ((elementsOfProduce[i] != 0) && (elementsOfConsume[i] != 0))
                    {
                        basisElements[i][j] = elementsOfProduce[i];
                        elementsOfProduce[i] -= elementsOfConsume[j];
                    }
        }

        // Проверка на оптимальность
        private static bool isOptimal()
        {
            for (int i = 0; i < tableRows; i++)
                for (int j = 0; j < tableColumns; j++)
                    if ((basisElements[i][j] == -1) && (relScore[i][j] < 0))
                    {
                        return false;
                    }
            return true;
        }

        // Нахождение оптимального решения
        public static void findOptimalSolution()
        {
            reloadList(potU, tableRows);
            reloadList(potUFinal, tableRows);
            reloadList(potV, tableColumns);
            reloadList(potVFinal, tableColumns);

            potUFinal[0] = 0;
            potU[0] = 1;

            int passed = 0;
            while (passed < tableColumns + tableRows)
            {
                for (int i = 0; i < tableRows; i++)
                {
                    if (potU[i] == 1)
                    {
                        for (int j = 0; j < tableColumns; j++)
                        {
                            if ((basisElements[i][j] != -1) && (potV[j] == 0))
                            {
                                potVFinal[j] = basisElements[i][j] - potUFinal[i];
                                potV[j] = 1;
                            }
                        }
                    }
                }
                for (int i = 0; i < tableColumns; i++)
                {
                    if (potV[i] == 1)
                    {
                        for (int j = 0; j < tableRows; j++)
                        {
                            if ((basisElements[j][i] != -1) && (potU[j] == 0))
                            {
                                potUFinal[j] = basisElements[j][i] - potVFinal[i];
                                potU[j] = 1;
                            }
                        }
                    }
                }

                passed++;

            }

            reloadMatrix(relScore);

            for (int i = 0; i < tableRows; i++)
                for (int j = 0; j < tableColumns; j++)
                    if (basisElements[i][j] == -1)
                        relScore[i][j] = basisElements[i][j] - (potUFinal[i] - potVFinal[j]);

            if (isOptimal())
            {
                // Вывод результатов
            }
            else
            {
                // Перерасчет
            }

        }
    }
}
