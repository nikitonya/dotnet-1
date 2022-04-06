using promproglab1.Model;
using promproglab1.Repositories;
using Spectre.Console;
using Spectre.Console.Cli;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace promproglab1.Commands
{
    public class MinFunctionCommand : Command<MinFunctionCommand.MinFunctionSetting>
    {
        public class MinFunctionSetting : CommandSettings { }

        private readonly IFunctionsRepository _functionsRepository;

        public MinFunctionCommand(IFunctionsRepository functionsRepository)
        {
            _functionsRepository = functionsRepository; 
        }

        public override int Execute([NotNull] CommandContext context, [NotNull] MinFunctionSetting settings)
        {
            var functions = _functionsRepository.GetFunctions();

            if (functions.Count == 0)
            {
                AnsiConsole.MarkupLine("[red1]The list is empty[/]");
                return 0;
            }
            int value = AnsiConsole.Prompt(new TextPrompt<int>(
                "[deepskyblue1]Enter the value for which you want to find the minimum function = [/]"));
            var min = functions[0].GetValue(value);
            foreach(Function func in functions)
            {
                if(func.GetValue(value) < min)
                {
                    min = func.GetValue(value);
                }
            }
            
            AnsiConsole.MarkupLine($"[green1]Min function is {min}[/]");


            return 0;
        }

        
    }
}
