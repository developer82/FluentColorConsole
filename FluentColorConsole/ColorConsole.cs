using System;

namespace FluentColorConsole
{
    public static class ColorConsole
    {
        /*
         * Background Color
         */
        public static BackgroundFirstConsole WithBlackBackground => new BackgroundFirstConsole(ConsoleColor.Black);
        public static BackgroundFirstConsole WithDarkBlueBackground => new BackgroundFirstConsole(ConsoleColor.DarkBlue);
        public static BackgroundFirstConsole WithDarkGreenBackground => new BackgroundFirstConsole(ConsoleColor.DarkGreen);
        public static BackgroundFirstConsole WithDarkCyanBackground => new BackgroundFirstConsole(ConsoleColor.DarkCyan);
        public static BackgroundFirstConsole WithDarkRedBackground => new BackgroundFirstConsole(ConsoleColor.DarkRed);
        public static BackgroundFirstConsole WithDarkMagentaBackground => new BackgroundFirstConsole(ConsoleColor.DarkMagenta);
        public static BackgroundFirstConsole WithDarkYellowBackground => new BackgroundFirstConsole(ConsoleColor.DarkYellow);
        public static BackgroundFirstConsole WithGrayBackground => new BackgroundFirstConsole(ConsoleColor.Gray);
        public static BackgroundFirstConsole WithDarkGrayBackground => new BackgroundFirstConsole(ConsoleColor.DarkGray);
        public static BackgroundFirstConsole WithBlueBackground => new BackgroundFirstConsole(ConsoleColor.Blue);
        public static BackgroundFirstConsole WithGreenBackground => new BackgroundFirstConsole(ConsoleColor.Green);
        public static BackgroundFirstConsole WithCyanBackground => new BackgroundFirstConsole(ConsoleColor.Cyan);
        public static BackgroundFirstConsole WithRedBackground => new BackgroundFirstConsole(ConsoleColor.Red);
        public static BackgroundFirstConsole WithMagentaBackground => new BackgroundFirstConsole(ConsoleColor.Magenta);
        public static BackgroundFirstConsole WithYellowBackground => new BackgroundFirstConsole(ConsoleColor.Yellow);
        public static BackgroundFirstConsole WithWhiteBackground => new BackgroundFirstConsole(ConsoleColor.White);

        /*
         * Text Color
         */
        public static TextFirstConsole WithBlackText => new TextFirstConsole(ConsoleColor.Black);
        public static TextFirstConsole WithDarkBlueText => new TextFirstConsole(ConsoleColor.DarkBlue);
        public static TextFirstConsole WithDarkGreenText => new TextFirstConsole(ConsoleColor.DarkGreen);
        public static TextFirstConsole WithDarkCyanText => new TextFirstConsole(ConsoleColor.DarkCyan);
        public static TextFirstConsole WithDarkRedText => new TextFirstConsole(ConsoleColor.DarkRed);
        public static TextFirstConsole WithDarkMagentaText => new TextFirstConsole(ConsoleColor.DarkMagenta);
        public static TextFirstConsole WithDarkYellowText => new TextFirstConsole(ConsoleColor.DarkYellow);
        public static TextFirstConsole WithGrayText => new TextFirstConsole(ConsoleColor.Gray);
        public static TextFirstConsole WithDarkGrayText => new TextFirstConsole(ConsoleColor.DarkGray);
        public static TextFirstConsole WithBlueText => new TextFirstConsole(ConsoleColor.Blue);
        public static TextFirstConsole WithGreenText => new TextFirstConsole(ConsoleColor.Green);
        public static TextFirstConsole WithCyanText => new TextFirstConsole(ConsoleColor.Cyan);
        public static TextFirstConsole WithRedText => new TextFirstConsole(ConsoleColor.Red);
        public static TextFirstConsole WithMagentaText => new TextFirstConsole(ConsoleColor.Magenta);
        public static TextFirstConsole WithYellowText => new TextFirstConsole(ConsoleColor.Yellow);
        public static TextFirstConsole WithWhiteText => new TextFirstConsole(ConsoleColor.White);
    }
}
