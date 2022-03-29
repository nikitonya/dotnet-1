using promproglab1.Model;
using Spectre.Console;
using System;
using System.Collections.Generic;

namespace promproglab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var con = new Const(9);
            //var con2 = new Const(6);
            //Console.WriteLine(con.Equals(con2));

            //var lin = new LinearFunction(5, 7);
            //var lin2 = new LinearFunction(6, 7);
            //Console.WriteLine(lin.Equals(lin2));

            //var quad = new Quadratic(1, 2, 3);
            //var quad2 = new Quadratic(1, 2, 3);
            //Console.WriteLine(quad.Equals(quad2));

            //var sin = new Sin(5);
            //var sin2 = new Sin(5);
            //Console.WriteLine(sin.Equals(sin2));

            //var cos = new Cos(8);
            //var cos2 = new Cos(7);
            //Console.WriteLine(cos.Equals(cos2));

            //Console.WriteLine(con.ToString());
            //Console.WriteLine(lin.ToString());
            //Console.WriteLine(quad.ToString());
            //Console.WriteLine(sin.ToString());
            //Console.WriteLine(cos.ToString());

            //Console.WriteLine(con.GetHashCode());
            //Console.WriteLine(lin.GetHashCode());
            //Console.WriteLine(quad.GetHashCode());
            //Console.WriteLine(sin.GetHashCode());
            //Console.WriteLine(cos.GetHashCode());

            List<Function> functions = new List<Function>();

            while (true)
            {
                var fucnType = AnsiConsole.Prompt(new SelectionPrompt<string>()
                    .Title("Выберите тип функции: ")
                    .AddChoices("Константа", "Линейная функция", "Квадратичная функция", "Синус", "Косинус"));

                Function function = fucnType switch
                {
                    "Константа" => new Const(
                        AnsiConsole.Prompt(new TextPrompt<double>("[blue]Число a[/]"))
                        ),
                    "Линейная функция" => new LinearFunction(
                        AnsiConsole.Prompt(new TextPrompt<double>("[blue]Число k[/]")),
                        AnsiConsole.Prompt(new TextPrompt<double>("[blue]Число b[/]"))
                        ),
                    "Квадратичная функция" => new Quadratic(
                        AnsiConsole.Prompt(new TextPrompt<double>("[blue]Число a[/]")),
                        AnsiConsole.Prompt(new TextPrompt<double>("[blue]Число b[/]")),
                        AnsiConsole.Prompt(new TextPrompt<double>("[blue]Число c[/]"))
                        ),
                    "Синус" => new Sin(
                        AnsiConsole.Prompt(new TextPrompt<double>("[blue]Число a[/]"))
                        ),
                    "Косинус" => new Cos(
                        AnsiConsole.Prompt(new TextPrompt<double>("[blue]Число a[/]"))
                        ),
                    _ => null
                };

                if (function == null)
                {
                    AnsiConsole.MarkupLine($"Неизвестный тип фигуры: {fucnType}");
                }
                functions.Add(function);

                var table = new Table();
                table.AddColumn("Type of function");
                table.AddColumn("View");
                table.AddColumn("Derivative");
                

                foreach (Function func in functions)
                {
                    table.AddRow(func.GetType().Name, func.ToString(), func.GetDerivative().ToString());
                }
                AnsiConsole.Write(table);

                var cont = AnsiConsole.Prompt(new SelectionPrompt<string>()
                    .Title("Что пожелаете?")
                    .AddChoices("Продолжить", "Выйти из программы"));

                if(cont == "Выйти из программы")
                {
                    break;
                }
            } 
            

           


        }

    }

}
