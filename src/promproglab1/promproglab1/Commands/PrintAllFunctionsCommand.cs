using promproglab1.Model;
using promproglab1.Repositories;
using Spectre.Console;
using Spectre.Console.Cli;
using System.Diagnostics.CodeAnalysis;

namespace promproglab1.Commands
{
    public class PrintAllFunctionsCommand : Command<PrintAllFunctionsCommand.GetAllFunctionsSettings>
    {
        public class GetAllFunctionsSettings : CommandSettings
        {

        }

        private readonly IFunctionsRepository _functionsRepository;
        public PrintAllFunctionsCommand(IFunctionsRepository functionsRepository)
        {
            _functionsRepository = functionsRepository; 
        }
        public override int Execute([NotNull] CommandContext context, [NotNull] GetAllFunctionsSettings settings)
        {
            var functions = _functionsRepository.GetFunctions();

            var table = new Table();
            var counter = 0;
            table.AddColumn("[royalblue1]Type of function[/]");
            table.AddColumn("[royalblue1]Function[/]");
            table.AddColumn("[royalblue1]Value[/]");
            table.AddColumn("[royalblue1]Derivative[/]");


            var x = AnsiConsole.Prompt(new TextPrompt<double>("[deepskyblue1]Enter a number X = [/]"));
            if (functions != null)
            {
                foreach (Function func in functions)
                {
                    if (counter < 10)
                    {
                        table.AddRow(func.GetType().Name, func.ToString(),
                            func.GetValue(x).ToString(), func.GetDerivative().ToString());
                        counter++;
                    }
                    else
                    {
                        table.AddRow("...", "...", "...", "...");
                        break;
                    }
                }
            }
            else
            {
                table.AddRow("null", "null", "null");
            }

            AnsiConsole.Write(table);
            return 0;
        }
    }
}
