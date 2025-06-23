using System.CommandLine;
using AutoSDK.CLI.Commands;
using AutoSDK.CLI.Commands.AI;

var rootCommand = new RootCommand(
    description: "CLI tool to use AutoSDK");
rootCommand.Subcommands.Add(new GenerateCommand());
rootCommand.Subcommands.Add(new HttpCommand());
rootCommand.Subcommands.Add(new CliCommand());
rootCommand.Subcommands.Add(new SimplifyCommand());
rootCommand.Subcommands.Add(new ConvertCommand());
rootCommand.Subcommands.Add(new InitializeCommand());
rootCommand.Subcommands.Add(new AiCommand());

return await rootCommand.Parse(args).InvokeAsync().ConfigureAwait(false);