using System.CommandLine;
using AutoSDK.CLI.Commands;

var rootCommand = new RootCommand(
    description: "CLI tool to generate .NET SDKs from OpenAPI and AsyncAPI specifications");
rootCommand.Subcommands.Add(new GenerateCommand());
rootCommand.Subcommands.Add(new HttpCommand());
rootCommand.Subcommands.Add(new CliCommand());
rootCommand.Subcommands.Add(new CliProjectCommand());
rootCommand.Subcommands.Add(new DocsCommand());
rootCommand.Subcommands.Add(new SimplifyCommand());
rootCommand.Subcommands.Add(new ConvertCommand());
rootCommand.Subcommands.Add(new InitializeCommand());
rootCommand.Subcommands.Add(new TrimCommand());
rootCommand.Subcommands.Add(new SkillCommand());

return await rootCommand.Parse(args).InvokeAsync().ConfigureAwait(false);
