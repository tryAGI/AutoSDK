using System.CommandLine;
using AutoSDK.Docs;

namespace AutoSDK.CLI.Commands;

internal sealed class DocsSyncCommand : Command
{
    private Argument<string> PathArgument { get; } = new(
        name: "path")
    {
        DefaultValueFactory = _ => ".",
        Description = "Solution directory",
    };

    private Option<string> Config { get; } = new(
        name: "--config")
    {
        DefaultValueFactory = _ => string.Empty,
        Description = "Optional docs config path. Defaults to autosdk.docs.json in the solution root.",
    };

    public DocsSyncCommand() : base(name: "sync", description: "Syncs README, docs pages, and MkDocs example nav.")
    {
        Arguments.Add(PathArgument);
        Options.Add(Config);

        SetAction(HandleAsync);
    }

    private async Task HandleAsync(ParseResult parseResult)
    {
        var path = parseResult.GetRequiredValue(PathArgument);
        var configPath = parseResult.GetRequiredValue(Config);
        var result = await DocsSynchronizer.SyncAsync(path, configPath).ConfigureAwait(false);

        Console.WriteLine(
            $"Synchronized {result.ExampleCount} documentation example{(result.ExampleCount == 1 ? string.Empty : "s")} using {result.Mode} mode.");
    }
}
