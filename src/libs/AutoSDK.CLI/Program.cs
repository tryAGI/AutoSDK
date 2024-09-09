using System.CommandLine;
using AutoSDK.CLI.Commands;

var rootCommand = new RootCommand(
    description: "CLI tool to use AutoSDK");
rootCommand.AddCommand(new GenerateCommand());
rootCommand.AddCommand(new SimplifyCommand());
rootCommand.AddCommand(new InitializeCommand());

return await rootCommand.InvokeAsync(args).ConfigureAwait(false);