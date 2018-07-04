using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingApp
{
    enum Operations
    {
        Insert,
        DeleteChar
    }

    class Operation
    {
        public Operations Type;
        public int Row { get; set; }
        public int Col { get; set; }
        public char Symbol;
    }

    class TextEditor
    {
        private readonly Stack<Operation> _done = new Stack<Operation>(); //стек законченных операций
        private readonly Stack<Operation> _undone = new Stack<Operation>(); //стек незаконченных операций

        public int Row { get;private set; } //текущая строка курсора
        public int Col { get;private set; } //текущий столбец курсора

        public List<string> Text; //изначальный текст

        //методы MoveCursorTo, Insert, DeleteChar не реализованы до конца, т.к. не учитано множество случаев
        //в задании сказано реализовать Undo и Redo, поэтому данные три метода я написал лишь для общего понимания

        //также я добавил bool pushStack у данных методов, чтобы можно было контролировать занесение в стек
        //это нужно чтобы при вызове данных методов в Undo действия не добавлялись в стек

        public void MoveCursorTo(int row, int col)
        {
            Row = row;
            Col = col;
        }

        public void Insert(char c, bool pushStack)
        {
            Text[Row] = Text[Row].Insert(Col,c.ToString());

            if (pushStack)
            {
                if (_undone.Count != 0)
                _undone.Clear();
                _done.Push(new Operation()
                {
                    Type = Operations.Insert,
                    Row = this.Row,
                    Col = this.Col,
                    Symbol = c
                });
            }
        }

        public void DeleteChar(bool pushStack)
        {
            Text[Row] = Text[Row].Remove(Col, 1);

            if (pushStack)
            {
                if (_undone.Count != 0)
                    _undone.Clear();
                _done.Push(new Operation()
                {
                    Type = Operations.DeleteChar,
                    Row = this.Row,
                    Col = this.Col,
                    Symbol = Text[this.Row][this.Col]
                });
            }
        }

        public void Undo()
        {
            if (_done.Count != 0)
            {
                var operation = _done.Pop();
                _undone.Push(operation);

                switch (operation.Type)
                {
                    case Operations.Insert:
                    {
                        MoveCursorTo(operation.Row,operation.Col);
                        DeleteChar(false);
                        break;
                    }
                    case Operations.DeleteChar:
                    {
                        MoveCursorTo(operation.Row,operation.Col);
                        Insert(operation.Symbol, false);
                        break;
                    }
                }
            }
        }

        public void Redo()
        {
            if (_undone.Count != 0)
            {
                var operation = _undone.Pop();

                switch (operation.Type)
                {
                    case Operations.Insert:
                    {
                        MoveCursorTo(operation.Row, operation.Col);
                        Insert(operation.Symbol,true);
                        break;
                    }
                    case Operations.DeleteChar:
                    {
                        MoveCursorTo(operation.Row, operation.Col);
                        DeleteChar(true);
                        break;
                    }
                }
            }
        }
    }

    class Program
    {
        public static void Main()
        {

        }
    }
}
