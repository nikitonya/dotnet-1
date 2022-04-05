using promproglab1.Model;
using promproglab1.Repositories;
using Spectre.Console;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace promproglab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var functionRepository = new XmlFunctionsRepository();
            AnsiConsole.WriteLine("Программа");
            
            var ind = 0;

            while (true)
            {
                //var menu = AnsiConsole.Prompt(new SelectionPrompt<string>()
                //    .Title("Основные функции: ")
                //    .AddChoices("Создать объект", "Удалить объект", "Удалить все объекты"
                //    , "Сравнить два объекта", "Вывести коллекцию на экран"));

                //String podmenu = menu switch
                //{
                //    "Создать объект" => AnsiConsole.Prompt(new SelectionPrompt<string>()
                //    .Title("Выберите тип функции: ")
                //    .AddChoices("Константа", "Линейная функция", "Квадратичная функция", "Синус", "Косинус")),

                //};

                var funcType = AnsiConsole.Prompt(new SelectionPrompt<string>()
                    .Title("Выберите тип функции: ")
                    .AddChoices("Константа", "Линейная функция", "Квадратичная функция", "Синус", "Косинус"));



                Function function = funcType switch
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
                    AnsiConsole.MarkupLine($"Неизвестный тип фигуры: {funcType}");
                }

                var table = new Table();
                //table.AddColumn("Index");
                table.AddColumn("Type of function");
                table.AddColumn("View");
                //table.AddColumn("X");
                table.AddColumn("Value");
                table.AddColumn("Derivative");

                
                var x = AnsiConsole.Prompt(new TextPrompt<double>("[blue]Введите число X = [/]"));
                var index = 0;

                //index = AnsiConsole.Prompt(new TextPrompt<int>($"[blue]Введите индекс, по которому нужно вставить объект = [/]"));
                functionRepository.AddFunction(function);
                functionRepository.RemoveAllFunction();




                //foreach (Function func in functionRepository)
                //{
                //    table.AddRow(func.GetType().Name, func.ToString(),
                //        func.GetValue(x).ToString(), func.GetDerivative().ToString());
                //    ind++;
                //}
                //AnsiConsole.Write(table);

                //var xmlSerializer = new XmlSerializer(typeof(List<Function>));
                //using (var fileStream = new FileStream("file.xml", FileMode.Create))
                //{
                //    xmlSerializer.Serialize(fileStream, functionRepository);
                //}
      
                var cont = AnsiConsole.Prompt(new SelectionPrompt<string>()
                    .Title("Что пожелаете?")
                    .AddChoices("Продолжить", "Выйти из программы"));

                if (cont == "Выйти из программы")
                {
                    break;
                }
            } 
            

           


        }

    }

}
