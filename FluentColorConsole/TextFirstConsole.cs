using System;

namespace FluentColorConsole
{
    public class TextFirstConsole : IConsole
    {
        private readonly ConsoleColor _textColor;

        private SimpleConsole ConsoleWriter => new SimpleConsole(Console.BackgroundColor, _textColor);

        public TextFirstConsole(ConsoleColor textColor)
        {
            _textColor = textColor;
        }

        #region Color Properties
        public SimpleConsole AndBlackBackground => new SimpleConsole(ConsoleColor.Black, _textColor);
        public SimpleConsole AndDarkBlueBackground => new SimpleConsole(ConsoleColor.DarkBlue, _textColor);
        public SimpleConsole AndDarkGreenBackground => new SimpleConsole(ConsoleColor.DarkGreen, _textColor);
        public SimpleConsole AndDarkCyanBackground => new SimpleConsole(ConsoleColor.DarkCyan, _textColor);
        public SimpleConsole AndDarkRedBackground => new SimpleConsole(ConsoleColor.DarkRed, _textColor);
        public SimpleConsole AndDarkMagentaBackground => new SimpleConsole(ConsoleColor.DarkMagenta, _textColor);
        public SimpleConsole AndDarkYellowBackground => new SimpleConsole(ConsoleColor.DarkYellow, _textColor);
        public SimpleConsole AndGrayBackground => new SimpleConsole(ConsoleColor.Gray, _textColor);
        public SimpleConsole AndDarkGrayBackground => new SimpleConsole(ConsoleColor.DarkGray, _textColor);
        public SimpleConsole AndBlueBackground => new SimpleConsole(ConsoleColor.Blue, _textColor);
        public SimpleConsole AndGreenBackground => new SimpleConsole(ConsoleColor.Green, _textColor);
        public SimpleConsole AndCyanBackground => new SimpleConsole(ConsoleColor.Cyan, _textColor);
        public SimpleConsole AndRedBackground => new SimpleConsole(ConsoleColor.Red, _textColor);
        public SimpleConsole AndMagentaBackground => new SimpleConsole(ConsoleColor.Magenta, _textColor);
        public SimpleConsole AndYellowBackground => new SimpleConsole(ConsoleColor.Yellow, _textColor);
        public SimpleConsole AndWhiteBackground => new SimpleConsole(ConsoleColor.White, _textColor);
        #endregion

        #region IConsole
        public void Write(decimal value)
        {
            ConsoleWriter.Write(value);
        }

        public void Write(char[] buffer)
        {
            ConsoleWriter.Write(buffer);
        }

        public void Write(float value)
        {
            ConsoleWriter.Write(value);
        }

        public void Write(bool value)
        {
            ConsoleWriter.Write(value);
        }

        public void Write(double value)
        {
            ConsoleWriter.Write(value);
        }

        public void Write(char value)
        {
            ConsoleWriter.Write(value);
        }

        public void Write(object value)
        {
            ConsoleWriter.Write(value);
        }

        public void Write(int value)
        {
            ConsoleWriter.Write(value);
        }

        public void Write(long value)
        {
            ConsoleWriter.Write(value);
        }

        public void Write(string value)
        {
            ConsoleWriter.Write(value);
        }

        public void Write(uint value)
        {
            ConsoleWriter.Write(value);
        }

        public void Write(ulong value)
        {
            ConsoleWriter.Write(value);
        }

        public void Write(string format, object arg0)
        {
            ConsoleWriter.Write(format, arg0);
        }

        public void Write(string format, params object[] arg)
        {
            ConsoleWriter.Write(format, arg);
        }

        public void Write(char[] buffer, int index, int count)
        {
            ConsoleWriter.Write(buffer, index, count);
        }

        public void Write(string format, object arg0, object arg1)
        {
            ConsoleWriter.Write(format, arg0, arg1);
        }

        public void Write(string format, object arg0, object arg1, object arg2)
        {
            ConsoleWriter.Write(format, arg0, arg1, arg2);
        }

        public void WriteLine()
        {
            Console.WriteLine();
        }

        public void WriteLine(bool value)
        {
            ConsoleWriter.WriteLine(value);
        }

        public void WriteLine(char value)
        {
            ConsoleWriter.WriteLine(value);
        }

        public void WriteLine(char[] buffer)
        {
            ConsoleWriter.WriteLine(buffer);
        }

        public void WriteLine(uint value)
        {
            ConsoleWriter.WriteLine(value);
        }

        public void WriteLine(decimal value)
        {
            ConsoleWriter.WriteLine(value);
        }

        public void WriteLine(double value)
        {
            ConsoleWriter.WriteLine(value);
        }

        public void WriteLine(int value)
        {
            ConsoleWriter.WriteLine(value);
        }

        public void WriteLine(long value)
        {
            ConsoleWriter.WriteLine(value);
        }

        public void WriteLine(object value)
        {
            ConsoleWriter.WriteLine(value);
        }

        public void WriteLine(float value)
        {
            ConsoleWriter.WriteLine(value);
        }

        public void WriteLine(string value)
        {
            ConsoleWriter.WriteLine(value);
        }

        public void WriteLine(ulong value)
        {
            ConsoleWriter.WriteLine(value);
        }

        public void WriteLine(string format, object arg0)
        {
            ConsoleWriter.WriteLine(format, arg0);
        }

        public void WriteLine(string format, params object[] arg)
        {
            ConsoleWriter.WriteLine(format, arg);
        }

        public void WriteLine(string format, object arg0, object arg1)
        {
            ConsoleWriter.WriteLine(format, arg0, arg1);
        }

        public void WriteLine(char[] buffer, int index, int count)
        {
            ConsoleWriter.WriteLine(buffer, index, count);
        }

        public void WriteLine(string format, object arg0, object arg1, object arg2)
        {
            ConsoleWriter.WriteLine(format, arg0, arg1, arg2);
        }
        #endregion
    }
}
