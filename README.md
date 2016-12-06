Fluent Color Console
===================


An easy to use console for writing colorful text - designed for .NET Core

----------

![Fluent Color Console](https://github.com/developer82/FluentColorConsole/blob/master/Logo.png?raw=true)

[![Build status](https://ci.appveyor.com/api/projects/status/gob5yjggdok58q5y?svg=true)](https://ci.appveyor.com/project/developer82/fluentcolorconsole)

Installation
-------------
This library is available as a NuGet package at https://www.nuget.org/packages/FluentColorConsole/

Installation:

    Install-Package EntityFramework



Usage
--------
Using Fluent Color Console is very easy.
First, just include FluentColorConsole:

    using FluentColorConsole;

Now lets have a look at some examples:

    // Green text on default console background color
    ColorConsole.WithDarkGreenText.WriteLine("Hello World!");
    
    // Default text on Blue background color
    ColorConsole.WithBlueBackground.WriteLine("Hello World!");

    // Background first - White text on Blue background
    ColorConsole.WithDarkBlueBackground.AndWhiteText.Write("I'm a color console library ");

    // Text first - White text on Red background
    ColorConsole.WithWhiteText.AndRedBackground.WriteLine("And I helped write myself :)");

    // Default Console colors
    Console.WriteLine("You can read more about me at https://github.com/developer82/FluentColorConsole");

