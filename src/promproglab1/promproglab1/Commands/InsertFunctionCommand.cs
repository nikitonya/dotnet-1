using promproglab1.Model;
using promproglab1.Repositories;
using Spectre.Console;
using Spectre.Console.Cli;
using System.Diagnostics.CodeAnalysis;

namespace promproglab1.Commands
{
    public class InsertFunctionCommand : Command<InsertFunctionCommand.InsertFunctionSettings>
    {
        public class InsertFunctionSettings : CommandSettings { }

        private readonly IFunctionsRepository _functionsRepository;

        public InsertFunctionCommand(IFunctionsRepository functionsRepository)
        {
            _functionsRepository = functionsRepository; 
        }

        public override int Execute([NotNull] CommandContext context, [NotNull] InsertFunctionSettings settings)
        {
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
                return -1;
            }

            var index = AnsiConsole.Prompt(new TextPrompt<int>($"[blue]Введите индекс, по которому нужно вставить объект = [/]"));
            _functionsRepository.InsertFunction(index, function);
            AnsiConsole.MarkupLine($"The insertion of the object at index has been completed successfully!");
            return 0;
        }
    }
}
