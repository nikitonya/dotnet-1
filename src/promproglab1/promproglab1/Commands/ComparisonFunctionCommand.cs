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
            var index1 = AnsiConsole.Prompt(new TextPrompt<int>("[aqua]Enter the index of the first object to compare = [/]"));
            var index2 = AnsiConsole.Prompt(new TextPrompt<int>("[aqua]Enter the index of the second object to compare = [/]"));

            if (index1 < 0 || index2 < 0)
            {
                return -1;
            }
            
            bool isEqual = _functionsRepository.ComparisonFunction(index1, index2);
            AnsiConsole.MarkupLine($"[deepskyblue1]Functions {index1} and {index2} {(isEqual ? "are" : "are not")} equal![/]");
            return 0;
        }
    }
}
