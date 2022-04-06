using PromProgLab1.Model;
using PromProgLab1.Repositories;
using Spectre.Console;
using Spectre.Console.Cli;
using System.Diagnostics.CodeAnalysis;

namespace PromProgLab1.Commands
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
            var minFunc = functions[0].ToString();

            foreach (Function func in functions)
            {
                if (func.GetValue(value) < min)
                {
                    min = func.GetValue(value);
                    minFunc = func.ToString();
                }

            }
            AnsiConsole.MarkupLine($"[green1]Min function {minFunc} value is {min}[/]");


            return 0;
        }


    }
}
