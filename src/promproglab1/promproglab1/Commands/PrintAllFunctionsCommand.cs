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
            //table.AddColumn("Index");
            table.AddColumn("Type of function");
            table.AddColumn("View");
            //table.AddColumn("X");
            table.AddColumn("Value");
            table.AddColumn("Derivative");


            var x = AnsiConsole.Prompt(new TextPrompt<double>("[blue]Введите число X = [/]"));

            foreach (Function func in functions)
            {
                table.AddRow(func.GetType().Name, func.ToString(),
                    func.GetValue(x).ToString(), func.GetDerivative().ToString());
            }
            AnsiConsole.Write(table);
            return 0;
        }
    }
}
