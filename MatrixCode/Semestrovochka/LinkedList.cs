using System;

namespace Semestrovochka
{
    class Cell
    {
        public Cell Next;
        public Cell Prev;

        public int Row;
        public int Column;
        public int Value;
    }

    class LinkedList
    {
        public Cell Head { get; set; }
        public Cell Current { get; set; }
        public int Count { get; private set; }

        /// <summary>
        /// Add element to the beginning of the list
        /// </summary>
        /// <param name="row">Line number of the cell</param>
        /// <param name="column">Column number of the cell</param>
        /// <param name="value">Value of the cell</param>
        public void AddFirst(int row, int column, int value)
        {
            var newCell = new Cell(){Row = row, Column = column, Value = value, Next = Head};
            if (Head != null)
            {
                Head.Prev = newCell;
            }

            Head = newCell;
            Count++;
        }

        /// <summary>
        /// Add element to the end of the list
        /// </summary>
        /// <param name="row">Line number of the cell</param>
        /// <param name="column">Column number of the cell</param>
        /// <param name="value">Value of the cell</param>
        public void AddLast(int row, int column, int value)
        {
            if (Head == null)
            {
                Current = Head = new Cell() { Row = row, Column = column, Value = value };
            }
            else
            {
                Current.Next = new Cell() { Row = row, Column = column, Value = value };
                Current.Next.Prev = Current;
                Current = Current.Next;
            }
            Count++;
        }

        /// <summary>
        /// Remove element from the list
        /// </summary>
        /// <param name="cell">Element to remove</param>
        public void Remove(Cell cell)
        {
            if (Head != null)
            {
                if (cell == Head || cell == Current)
                {
                    Remove(cell.Row, cell.Column);
                }
                else
                {
                    RemoveFromMiddle(cell);
                }
                Count--;
            }
        }

        /// <summary>
        /// Remove element at specific position
        /// </summary>
        /// <param name="i">Row number of element</param>
        /// <param name="j">Column number of element</param>
        public void Remove(int i, int j)
        {
            if (Head != null)
            {
                if (Head.Row == i && Head.Column == j)
                {
                    RemoveFromBegin();
                }
                else
                {
                    if (Current.Row == i && Current.Column == j)
                    {
                        RemoveFromEnd();
                    }
                    else
                    {
                        var cell = Head;

                        while (cell != null)
                        {
                            if (cell.Row == i && cell.Column == j)
                            {
                                RemoveFromMiddle(cell);
                                break;
                            }
                            cell = cell.Next;
                        }
                    }
                }
                Count--;
            }
        }

        /// <summary>
        /// Remove element from beginning of the list
        /// </summary>
        private void RemoveFromBegin()
        {
            if (Head == Current)
            {
                Current = Head = Head.Next;
            }
            else
            {
                Head = Head.Next;
                Head.Prev.Next = null;
                Head.Prev = null;
            }
        }

        /// <summary>
        /// Remove element from the lis body
        /// </summary>
        /// <param name="cell">Element to remove</param>
        private void RemoveFromMiddle(Cell cell)
        {
            cell.Prev.Next = cell.Next;
            cell.Next.Prev = cell.Prev;
            cell.Prev = null;
            cell.Next = null;
        }

        /// <summary>
        /// Remove element from the end of the list
        /// </summary>
        private void RemoveFromEnd()
        {
            if (Head == Current)
            {
                Current = Head = Head.Next;
            }
            else
            {
                Current = Current.Prev;
                Current.Next.Prev = null;
                Current.Next = null;
            }
        }

        /// <summary>
        /// Find element required element
        /// </summary>
        /// <param name="cell">Required element</param>
        /// <returns>Required element</returns>
        public Cell FindCell(Cell cell)
        {
            if (cell == null)
                throw new NullReferenceException("Incorrect null cell");
            if (cell == Current)
                return Current;

            var newCell = Head;

            while (newCell != cell && newCell != null)
            {
                newCell = newCell.Next;
            }
            return newCell;
        }

        /// <summary>
        /// Clear the list
        /// </summary>
        public void Clear()
        {
            Current = Head = null;
            Count = 0;
        }

        /// <summary>
        /// Find element on certain position
        /// </summary>
        /// <param name="index">Index of the required element</param>
        /// <returns>Required element on index position</returns>
        public Cell this[int index]
        {
            get
            {
                var current = Head;
                for (int i = 0; i < index; i++)
                {
                    current = current.Next;
                }
                return current;
            }
        }
    }
}