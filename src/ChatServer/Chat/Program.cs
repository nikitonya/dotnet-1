using Microsoft.AspNetCore.SignalR.Client;
using Spectre.Console;
using System;
using System.Threading.Tasks;

namespace Chat
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var userName = AnsiConsole.Ask<string>("What's your username");

            var connection = new HubConnectionBuilder()
                .WithUrl("http://localhost:5000/chatroom")
                .Build();

            connection.On<string, string>("ReceiveMessage", (user, message) =>
            {
                AnsiConsole.MarkupLine($"[red]{user}[/]: [blue]{message} [/]");
            });

            await connection.StartAsync();
            while (true)
            {
                var message = AnsiConsole.Ask<string>($"{userName}: ");

                if (message == "exit") break;

                connection.InvokeAsync("SendMessage", userName, message);
            }


            await connection.StopAsync();

        }
    }
}
