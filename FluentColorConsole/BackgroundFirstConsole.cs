using System;

namespace FluentColorConsole
{
    public class BackgroundFirstConsole : IConsole
    {
        private readonly ConsoleColor _backgroundColor;

        private SimpleConsole ConsoleWriter => new SimpleConsole(_backgroundColor, Console.ForegroundColor);

        public BackgroundFirstConsole(ConsoleColor backgroundColor)
        {
            _backgroundColor = backgroundColor;
        }

        #region Color Properties
        public SimpleConsole AndBlackText => new SimpleConsole(_backgroundColor, ConsoleColor.Black);
        public SimpleConsole AndDarkBlueText => new SimpleConsole(_backgroundColor, ConsoleColor.DarkBlue);
        public SimpleConsole AndDarkGreenText => new SimpleConsole(_backgroundColor, ConsoleColor.DarkGreen);
        public SimpleConsole AndDarkCyanText => new SimpleConsole(_backgroundColor, ConsoleColor.DarkCyan);
        public SimpleConsole AndDarkRedText => new SimpleConsole(_backgroundColor, ConsoleColor.DarkRed);
        public SimpleConsole AndDarkMagentaText => new SimpleConsole(_backgroundColor, ConsoleColor.DarkMagenta);
        public SimpleConsole AndDarkYellowText => new SimpleConsole(_backgroundColor, ConsoleColor.DarkYellow);
        public SimpleConsole AndGrayText => new SimpleConsole(_backgroundColor, ConsoleColor.Gray);
        public SimpleConsole AndDarkGrayText => new SimpleConsole(_backgroundColor, ConsoleColor.DarkGray);
        public SimpleConsole AndBlueText => new SimpleConsole(_backgroundColor, ConsoleColor.Blue);
        public SimpleConsole AndGreenText => new SimpleConsole(_backgroundColor, ConsoleColor.Green);
        public SimpleConsole AndCyanText => new SimpleConsole(_backgroundColor, ConsoleColor.Cyan);
        public SimpleConsole AndRedText => new SimpleConsole(_backgroundColor, ConsoleColor.Red);
        public SimpleConsole AndMagentaText => new SimpleConsole(_backgroundColor, ConsoleColor.Magenta);
        public SimpleConsole AndYellowText => new SimpleConsole(_backgroundColor, ConsoleColor.Yellow);
        public SimpleConsole AndWhiteText => new SimpleConsole(_backgroundColor, ConsoleColor.White);
        #endregion

        #region IConsole
        public void Write(decimal value)
        {
            throw new NotImplementedException();
        }

        public void Write(char[] buffer)
        {
            throw new NotImplementedException();
        }

        public void Write(float value)
        {
            throw new NotImplementedException();
        }

        public void Write(bool value)
        {
            throw new NotImplementedException();
        }

        public void Write(double value)
        {
            throw new NotImplementedException();
        }

        public void Write(char value)
        {
            throw new NotImplementedException();
        }

        public void Write(object value)
        {
            throw new NotImplementedException();
        }

        public void Write(int value)
        {
            throw new NotImplementedException();
        }

        public void Write(long value)
        {
            throw new NotImplementedException();
        }

        public void Write(string value)
        {
            throw new NotImplementedException();
        }

        public void Write(uint value)
        {
            throw new NotImplementedException();
        }

        public void Write(ulong value)
        {
            throw new NotImplementedException();
        }

        public void Write(string format, object arg0)
        {
            throw new NotImplementedException();
        }

        public void Write(string format, params object[] arg)
        {
            throw new NotImplementedException();
        }

        public void Write(char[] buffer, int index, int count)
        {
            throw new NotImplementedException();
        }

        public void Write(string format, object arg0, object arg1)
        {
            throw new NotImplementedException();
        }

        public void Write(string format, object arg0, object arg1, object arg2)
        {
            throw new NotImplementedException();
        }

        public void WriteLine()
        {
            throw new NotImplementedException();
        }

        public void WriteLine(bool value)
        {
            throw new NotImplementedException();
        }

        public void WriteLine(char value)
        {
            throw new NotImplementedException();
        }

        public void WriteLine(char[] buffer)
        {
            throw new NotImplementedException();
        }

        public void WriteLine(uint value)
        {
            throw new NotImplementedException();
        }

        public void WriteLine(decimal value)
        {
            throw new NotImplementedException();
        }

        public void WriteLine(double value)
        {
            throw new NotImplementedException();
        }

        public void WriteLine(int value)
        {
            throw new NotImplementedException();
        }

        public void WriteLine(long value)
        {
            throw new NotImplementedException();
        }

        public void WriteLine(object value)
        {
            throw new NotImplementedException();
        }

        public void WriteLine(float value)
        {
            throw new NotImplementedException();
        }

        public void WriteLine(string value)
        {
            throw new NotImplementedException();
        }

        public void WriteLine(ulong value)
        {
            throw new NotImplementedException();
        }

        public void WriteLine(string format, object arg0)
        {
            throw new NotImplementedException();
        }

        public void WriteLine(string format, params object[] arg)
        {
            throw new NotImplementedException();
        }

        public void WriteLine(string format, object arg0, object arg1)
        {
            throw new NotImplementedException();
        }

        public void WriteLine(char[] buffer, int index, int count)
        {
            throw new NotImplementedException();
        }

        public void WriteLine(string format, object arg0, object arg1, object arg2)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
