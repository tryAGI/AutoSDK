using System.CommandLine;

namespace AutoSDK.CLI.Commands.AI;

internal sealed class AiCommand : Command
{
    public AiCommand() : base(name: "ai", description: "AI subcommands.")
    {
        Subcommands.Add(new SpecFromDocsCommand());
    }
}