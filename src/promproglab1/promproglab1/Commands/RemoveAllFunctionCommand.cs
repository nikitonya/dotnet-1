using promproglab1.Model;
using promproglab1.Repositories;
using Spectre.Console;
using Spectre.Console.Cli;
using System.Diagnostics.CodeAnalysis;

namespace promproglab1.Commands
{
    public class RemoveAllFunctionCommand : Command<RemoveAllFunctionCommand.RemoveAllFunctionSettings>
    {
        public class RemoveAllFunctionSettings : CommandSettings { }

        private readonly IFunctionsRepository _functionsRepository;

        public RemoveAllFunctionCommand(IFunctionsRepository functionsRepository)
        {
            _functionsRepository = functionsRepository; 
        }

        public override int Execute([NotNull] CommandContext context, [NotNull] RemoveAllFunctionSettings settings)
        {
            _functionsRepository.RemoveAllFunction();
            AnsiConsole.MarkupLine("Deletion of all objects has been completed successfully!");
            return 0;
        }
    }
}
