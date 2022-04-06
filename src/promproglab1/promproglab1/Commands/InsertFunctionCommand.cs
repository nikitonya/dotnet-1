using PromProgLab1.Model;
using PromProgLab1.Repositories;
using Spectre.Console;
using Spectre.Console.Cli;
using System.Diagnostics.CodeAnalysis;

namespace PromProgLab1.Commands
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
                    .Title("[aqua]Select the type of function: " +
                    "[/]")
                    .AddChoices("[lime]Const[/]", "[lime]Linear function[/]", "[lime]Quadratic function[/]", "[lime]Sin[/]", "[lime]Cos[/]"));

            Function function = funcType switch
            {
                "[lime]Const[/]" => new Const(
                    AnsiConsole.Prompt(new TextPrompt<double>("[deepskyblue1]Number a = [/]"))
                    ),
                "[lime]Linear function[/]" => new LinearFunction(
                    AnsiConsole.Prompt(new TextPrompt<double>("[deepskyblue1]Coefficient k = [/]")),
                    AnsiConsole.Prompt(new TextPrompt<double>("[deepskyblue1]Coefficient b = [/]"))
                    ),
                "[lime]Quadratic function[/]" => new Quadratic(
                    AnsiConsole.Prompt(new TextPrompt<double>("[deepskyblue1]Coefficient a = [/]")),
                    AnsiConsole.Prompt(new TextPrompt<double>("[deepskyblue1]Coefficient b = [/]")),
                    AnsiConsole.Prompt(new TextPrompt<double>("[deepskyblue1]Coefficient c = [/]"))
                    ),
                "[lime]Sin[/]" => new Sin(
                    AnsiConsole.Prompt(new TextPrompt<double>("[deepskyblue1]Coefficient a = [/]"))
                    ),
                "[lime]Cos[/]" => new Cos(
                    AnsiConsole.Prompt(new TextPrompt<double>("[deepskyblue1]Coefficient a = [/]"))
                    ),
                _ => null
            };

            if (function == null)
            {
                AnsiConsole.MarkupLine($"[red1]Unknown shape type: {funcType}[/]");
                return -1;
            }

            var index = AnsiConsole.Prompt(new TextPrompt<int>("[deepskyblue1]Enter the index by which you want to insert the object = [/]"));
            _functionsRepository.InsertFunction(index, function);
            AnsiConsole.MarkupLine("[green1]The insertion of the object at index has been completed successfully![/]");
            return 0;
        }
    }
}
