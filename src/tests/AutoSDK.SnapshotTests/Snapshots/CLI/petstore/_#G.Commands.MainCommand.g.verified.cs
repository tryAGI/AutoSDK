﻿//HintName: G.Commands.MainCommand.g.cs

#nullable enable

namespace G
{
    internal sealed class MainCommand : global::System.CommandLine.RootCommand
    {
        public MainCommand(
            PetCommand command0)
            : base(
                description: "CLI tool")
        {
            Subcommands.Add(command0);
        }
    }
}