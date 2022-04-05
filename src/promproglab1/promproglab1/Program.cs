using Lab1.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using promproglab1.Commands;
using promproglab1.Repositories;
using Spectre.Console;
using Spectre.Console.Cli;

namespace promproglab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddSingleton<IFunctionsRepository, XmlFunctionsRepository>();

            var registrar = new TypeRegistrar(serviceCollection);
            var app = new CommandApp(registrar);

            app.Configure(config =>
            {
                config.AddCommand<AddFunctionCommand>("add");
                config.AddCommand<PrintAllFunctionsCommand>("print");
                config.AddCommand<InsertFunctionCommand>("Insert");
                config.AddCommand<RemoveFunctionCommand>("Remove");
                config.AddCommand<RemoveAllFunctionCommand>("RemoveAll");
            });

            app.Run(args);
            
            //while (true)
            //{
            //    //var menu = AnsiConsole.Prompt(new SelectionPrompt<string>()
            //    //    .Title("Основные функции: ")
            //    //    .AddChoices("Создать объект", "Удалить объект", "Удалить все объекты"
            //    //    , "Сравнить два объекта", "Вывести коллекцию на экран"));

            //    //String podmenu = menu switch
            //    //{
            //    //    "Создать объект" => AnsiConsole.Prompt(new SelectionPrompt<string>()
            //    //    .Title("Выберите тип функции: ")
            //    //    .AddChoices("Константа", "Линейная функция", "Квадратичная функция", "Синус", "Косинус")),
            //    //}
            //    //index = AnsiConsole.Prompt(new TextPrompt<int>($"[blue]Введите индекс, по которому нужно вставить объект = [/]"));               

            //    //var xmlSerializer = new XmlSerializer(typeof(List<Function>));
            //    //using (var fileStream = new FileStream("file.xml", FileMode.Create))
            //    //{
            //    //    xmlSerializer.Serialize(fileStream, functionRepository);
            //    //}
      
            //    var cont = AnsiConsole.Prompt(new SelectionPrompt<string>()
            //        .Title("Что пожелаете?")
            //        .AddChoices("Продолжить", "Выйти из программы"));

            //    if (cont == "Выйти из программы")
            //    {
            //        break;
            //    }
            } 
            

           


        }

    }

