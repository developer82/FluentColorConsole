using System;

namespace FluentColorConsole
{
    public class SimpleConsole : IConsole
    {
        private readonly ConsoleColor _backgroundColor;
        private readonly ConsoleColor _textColor;

        public SimpleConsole(ConsoleColor backgroundColor, ConsoleColor textColor)
        {
            _backgroundColor = backgroundColor;
            _textColor = textColor;
        }

        #region Write
        public void Write(decimal value)
        {
            ArriveAtCenterOfTheMaze(value.ToString());
        }

        public void Write(char[] buffer)
        {
            ArriveAtCenterOfTheMaze(new string(buffer));
        }

        public void Write(float value)
        {
            ArriveAtCenterOfTheMaze(value.ToString());
        }

        public void Write(bool value)
        {
            ArriveAtCenterOfTheMaze(value.ToString());
        }

        public void Write(double value)
        {
            ArriveAtCenterOfTheMaze(value.ToString());
        }

        public void Write(char value)
        {
            ArriveAtCenterOfTheMaze(value.ToString());
        }

        public void Write(object value)
        {
            ArriveAtCenterOfTheMaze(value.ToString());
        }

        public void Write(int value)
        {
            ArriveAtCenterOfTheMaze(value.ToString());
        }

        public void Write(long value)
        {
            ArriveAtCenterOfTheMaze(value.ToString());
        }

        public void Write(string value)
        {
            ArriveAtCenterOfTheMaze(value);
        }

        public void Write(uint value)
        {
            ArriveAtCenterOfTheMaze(value.ToString());
        }

        public void Write(ulong value)
        {
            ArriveAtCenterOfTheMaze(value.ToString());
        }

        public void Write(string format, object arg0)
        {
            ArriveAtCenterOfTheMaze(string.Format(format, arg0));
        }

        public void Write(string format, params object[] arg)
        {
            ArriveAtCenterOfTheMaze(string.Format(format, arg));
        }

        public void Write(char[] buffer, int index, int count)
        {
            char[] subArr = new char[count];
            Array.Copy(buffer, subArr, count);
            Write(subArr);
        }

        public void Write(string format, object arg0, object arg1)
        {
            ArriveAtCenterOfTheMaze(string.Format(format, arg0, arg1));
        }

        public void Write(string format, object arg0, object arg1, object arg2)
        {
            ArriveAtCenterOfTheMaze(string.Format(format, arg0, arg1, arg2));
        }
        #endregion

        #region WriteLine
        public void WriteLine()
        {
            Console.WriteLine();
        }

        public void WriteLine(bool value)
        {
            Write(value);
            WriteLine();
        }

        public void WriteLine(char value)
        {
            Write(value);
            WriteLine();
        }

        public void WriteLine(char[] buffer)
        {
            Write(buffer);
            WriteLine();
        }

        public void WriteLine(uint value)
        {
            Write(value);
            WriteLine();
        }

        public void WriteLine(decimal value)
        {
            Write(value);
            WriteLine();
        }

        public void WriteLine(double value)
        {
            Write(value);
            WriteLine();
        }

        public void WriteLine(int value)
        {
            Write(value);
            WriteLine();
        }

        public void WriteLine(long value)
        {
            Write(value);
            WriteLine();
        }

        public void WriteLine(object value)
        {
            Write(value);
            WriteLine();
        }

        public void WriteLine(float value)
        {
            Write(value);
            WriteLine();
        }

        public void WriteLine(string value)
        {
            Write(value);
            WriteLine();
        }

        public void WriteLine(ulong value)
        {
            Write(value);
            WriteLine();
        }

        public void WriteLine(string format, object arg0)
        {
            Write(format, arg0);
            WriteLine();
        }

        public void WriteLine(string format, params object[] arg)
        {
            Write(format, arg);
            WriteLine();
        }

        public void WriteLine(string format, object arg0, object arg1)
        {
            Write(format, arg0, arg1);
            WriteLine();
        }

        public void WriteLine(char[] buffer, int index, int count)
        {
            WriteLine(buffer, index, count);
            WriteLine();
        }

        public void WriteLine(string format, object arg0, object arg1, object arg2)
        {
            Write(format, arg0, arg1, arg2);
            WriteLine();
        }
        #endregion

        private void ArriveAtCenterOfTheMaze(string text)
        {
            Console.BackgroundColor = _backgroundColor;
            Console.ForegroundColor = _textColor;
            Console.Write(text);
            Console.ResetColor();
        }
    }
}
