using PromProgLab1.Repositories;
using Spectre.Console;
using Spectre.Console.Cli;
using System.Diagnostics.CodeAnalysis;

namespace PromProgLab1.Commands
{
    public class RemoveFunctionCommand : Command<RemoveFunctionCommand.RemoveFunctionSettings>
    {
        public class RemoveFunctionSettings : CommandSettings { }

        private readonly IFunctionsRepository _functionsRepository;

        public RemoveFunctionCommand(IFunctionsRepository functionsRepository)
        {
            _functionsRepository = functionsRepository;
        }

        public override int Execute([NotNull] CommandContext context, [NotNull] RemoveFunctionSettings settings)
        {
            var index = AnsiConsole.Prompt(new TextPrompt<int>($"[deepskyblue1]Enter the index by which you want to delete the object = [/]"));
            _functionsRepository.RemoveFunction(index);
            AnsiConsole.MarkupLine("[green1]Deletion completed successfully![/]");
            return 0;
        }
    }
}
