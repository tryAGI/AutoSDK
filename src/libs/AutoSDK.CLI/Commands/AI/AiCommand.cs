using System.CommandLine;

namespace AutoSDK.CLI.Commands.AI;

public class AiCommand : Command
{
    public AiCommand() : base(name: "ai", description: "AI subcommands.")
    {
        AddCommand(new SpecFromDocsCommand());
    }
}