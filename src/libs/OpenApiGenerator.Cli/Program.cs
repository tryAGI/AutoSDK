﻿using System.CommandLine;
using OpenApiGenerator.Cli.Commands;

var rootCommand = new RootCommand(
    description: "CLI tool to use OpenApiGenerator");
rootCommand.AddCommand(new GenerateCommand());

return await rootCommand.InvokeAsync(args).ConfigureAwait(false);