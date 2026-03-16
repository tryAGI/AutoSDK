using System.CommandLine;

namespace AutoSDK.CLI.Commands;

internal sealed class DocsCommand : Command
{
    public DocsCommand() : base(name: "docs", description: "Synchronizes documentation files from integration-test examples.")
    {
        Subcommands.Add(new DocsSyncCommand());
    }
}
