using promproglab1.Model;
using promproglab1.Repositories;
using Spectre.Console;
using Spectre.Console.Cli;
using System.Diagnostics.CodeAnalysis;

namespace promproglab1.Commands
{
    public class ComparisonFunctionCommand : Command<ComparisonFunctionCommand.ComparisonFunctionSettings>
    {
        public class ComparisonFunctionSettings : CommandSettings { }

        private readonly IFunctionsRepository _functionsRepository;

        public ComparisonFunctionCommand(IFunctionsRepository functionsRepository)
        {
            _functionsRepository = functionsRepository; 
        }

        public override int Execute([NotNull] CommandContext context, [NotNull] ComparisonFunctionSettings settings)
        {
            var index1 = AnsiConsole.Prompt(new TextPrompt<int>($"[blue]Enter the index of the first object to compare = [/]"));
            var index2 = AnsiConsole.Prompt(new TextPrompt<int>($"[blue]Enter the index of the second object to compare = [/]"));

            if (index1 < 0 || index2 < 0)
            {
                return -1;
            }

            if (_functionsRepository.ComparisonFunction(index1, index2) == true)
            {
                AnsiConsole.MarkupLine("The objects are equal");
            }
            else
            {
                AnsiConsole.MarkupLine("Objects are not equal");
            }
            return 0;
        }
    }
}
