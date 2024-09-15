using System.CommandLine;
using AutoSDK.CLI.Commands;
using AutoSDK.CLI.Commands.AI;

var rootCommand = new RootCommand(
    description: "CLI tool to use AutoSDK");
rootCommand.AddCommand(new GenerateCommand());
rootCommand.AddCommand(new SimplifyCommand());
rootCommand.AddCommand(new InitializeCommand());
rootCommand.AddCommand(new AiCommand());

return await rootCommand.InvokeAsync(args).ConfigureAwait(false);