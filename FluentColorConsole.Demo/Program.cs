using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluentColorConsole.Demo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //var values = Enum.GetValues(typeof(ConsoleColor));

            //foreach (var value in values)
            //{
            //    Console.WriteLine($"public static BackgroundFirstConsole With{value}Background => new BackgroundFirstConsole(ConsoleColor.{value});");
            //}

            //foreach (var value in values)
            //{
            //    Console.WriteLine($"public static TextFirstConsole With{value}Text => new TextFirstConsole(ConsoleColor.{value});");
            //}

            //foreach (var value in values)
            //{
            //    Console.WriteLine($"public SimpleConsole And{value}Text => new SimpleConsole(_backgroundColor, ConsoleColor.{value});");
            //}

            //foreach (var value in values)
            //{
            //    Console.WriteLine($"public SimpleConsole And{value}Background => new SimpleConsole(ConsoleColor.{value}, _textColor);");
            //}

            ColorConsole.WithDarkGreenText.WriteLine("Hello World!");
            ColorConsole.WithDarkBlueBackground.AndWhiteText.Write("I'm a color console library ");
            ColorConsole.WithWhiteText.AndRedBackground.WriteLine("And I helped write myself :)");

            Console.WriteLine("You can read more about me at https://github.com/developer82/ColorConsole");

            Console.ReadLine();
        }
    }
}
