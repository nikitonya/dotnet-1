using promproglab1.Model;
using promproglab1.Repositories;
using Spectre.Console;
using Spectre.Console.Cli;
using System.Diagnostics.CodeAnalysis;

namespace promproglab1.Commands
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
            var index = AnsiConsole.Prompt(new TextPrompt<int>($"[blue]Введите индекс, по которому нужно удалить объект = [/]"));
            _functionsRepository.RemoveFunction(index);
            AnsiConsole.MarkupLine("Deletion completed successfully");
            return 0;
        }
    }
}
