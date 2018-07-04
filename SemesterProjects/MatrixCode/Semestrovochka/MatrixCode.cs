using System;
using System.Collections;

namespace Semestrovochka
{
    class MatrixCode
    {
        /// <summary>
        /// Cell storage list
        /// </summary>
        public LinkedList ListMatrix;

        /// <summary>
        /// Dimension of the matrix
        /// </summary>
        public const int Dimension = 10;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="matrix">Matrix with values</param>
        public MatrixCode(int[][] matrix)
        {
            if (matrix == null)
                throw new NullReferenceException("The matrix reference is null");

            ListMatrix = new LinkedList();

            for (int i = 0; i < Dimension; i++)
            {
                for (int j = 0; j < Dimension; j++)
                {
                    if (matrix[i][j] != 0)
                    {
                        ListMatrix.AddLast(i, j, matrix[i][j]);
                    }
                }
            }
        }

        /// <summary>
        /// Converts the list to the matrix
        /// </summary>
        /// <returns>Matrix with values</returns>
        public int[][] Decode()
        {
            var array = new int[Dimension][];

            for (int i = 0; i < Dimension; i++)
            {
                array[i] = new int[Dimension];
            }

            var cell = ListMatrix.Head;
            while (cell != null)
            {
                array[cell.Row][cell.Column] = cell.Value;
                cell = cell.Next;
            }
            return array;
        }

        /// <summary>
        /// Insert element to the list or replace it
        /// </summary>
        /// <param name="i">Element row</param>
        /// <param name="j">Element column</param>
        /// <param name="value">Element value</param>
        public void Insert(int i, int j, int value)
        {
            if (i >= Dimension || j >= Dimension || i < 0 || j < 0)
            {
                throw new IndexOutOfRangeException();
            }

            if (value == 0)
            {
                Delete(i, j);
            }
            else
            {
                var cell = new Cell() {Row = i, Column = j, Value = value};
                cell = ListMatrix.FindCell(cell);

                if (cell == null)
                {
                    ListMatrix.AddLast(i, j, value);
                }
                else
                {
                    cell.Value = value;
                }
            }
        }

        /// <summary>
        /// Delete element on certain row and column
        /// </summary>
        /// <param name="i">Element row</param>
        /// <param name="j">Element column</param>
        public void Delete(int i, int j)
        {
            if (i >= Dimension || j >= Dimension || i < 0 || j < 0)
            {
                throw new IndexOutOfRangeException();
            }
            ListMatrix.Remove(i, j);
        }

        /// <summary>
        /// Delete required element
        /// </summary>
        /// <param name="cell">Required element to delete</param>
        public void Delete(Cell cell)
        {
            ListMatrix.Remove(cell);
        }

        /// <summary>
        /// Find minimal elements from each column
        /// </summary>
        /// <returns>ArrayList of minimal elements from each column</returns>
        public ArrayList MinList()
        {
            var valuesArray = new int[10];

            if (ListMatrix.Head != null)
            {
                var countsArray = new int[10];
                var cell = ListMatrix.Head;

                while (cell != null)
                {
                    var col = cell.Column;
                    if (countsArray[col] == 0)
                    {
                        valuesArray[col] = cell.Value;
                    }
                    else
                    {
                        if (valuesArray[col] > cell.Value)
                        {
                            valuesArray[col] = cell.Value;
                        }
                    }
                    countsArray[col]++;
                    cell = cell.Next;
                }

                for (int i = 0; i < valuesArray.Length; i++)
                {
                    if (countsArray[i] != 10 && valuesArray[i] > 0)
                    {
                        valuesArray[i] = 0;
                    }
                }
            }

            return new ArrayList(valuesArray);
        }

        /// <summary>
        /// Calculates the sum of diagonals
        /// </summary>
        /// <returns>Sum of the elements on the diagonals</returns>
        public int SumDiag()
        {
            var cell = ListMatrix.Head;
            int sum = 0;

            while (cell != null)
            {
                if (cell.Row == cell.Column || cell.Row + cell.Column == Dimension - 1)
                {
                    sum += cell.Value;
                }
                cell = cell.Next;
            }

            return sum;
        }

        /// <summary>
        /// Transpose matrix
        /// </summary>
        public void Transpose()
        {
            var cell = ListMatrix.Head;

            while (cell != null)
            {
                Swap(ref cell.Row, ref cell.Column);
                cell = cell.Next;
            }
        }

        /// <summary>
        /// Change elements in place
        /// </summary>
        /// <param name="a">First element</param>
        /// <param name="b">Second element</param>
        private static void Swap(ref int a, ref int b)
        {
            var c = a;
            a = b;
            b = c;
        }

        /// <summary>
        /// Summarize two columns and write result in first
        /// </summary>
        /// <param name="j1">First column number</param>
        /// <param name="j2">Seconds column number</param>
        public void SumColumns(int j1, int j2)
        {
            if (j1 >= Dimension || j2 >= Dimension || j2 < 0 || j1 < 0)
            {
                throw new IndexOutOfRangeException();
            }

            var cell = ListMatrix.Head;
            var array = new int[Dimension];

            while (cell != null)
            {
                if (cell.Column == j1 || cell.Column == j2)
                {
                    array[cell.Row] += cell.Value;
                }
                if (cell.Column == j1)
                {
                    Delete(cell);
                }
                cell = cell.Next;
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != 0)
                {
                    ListMatrix.AddLast(i, j1, array[i]);
                }
            }
        }
    }
}
