//HintName: G.Commands.CreateHistoryDownloadCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateHistoryDownloadCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? xiApiKey,
            global::System.Collections.Generic.IList<string> historyItemIds,
            string? outputFormat,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            byte[] response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<string>> HistoryItemIds { get; } = new(
            name: "historyItemIds")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> OutputFormat { get; } = new(
            name: "outputFormat")
        {
            Description = "",
        };
        public CreateHistoryDownloadCommand(G.IApi client) : base(
            name: "create",
            description: @"Download one or more history items. If one history item ID is provided, we will return a single audio file. If more than one history item IDs are provided, we will provide the history items packed into a .zip file.")
        {
            _client = client;

            Arguments.Add(HistoryItemIds);
            Options.Add(XiApiKey);
            Options.Add(OutputFormat);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);
            var historyItemIds = parseResult.GetRequiredValue(HistoryItemIds);
            var outputFormat = parseResult.GetRequiredValue(OutputFormat);

            Validate(
                parseResult: parseResult,
                xiApiKey: xiApiKey,
                historyItemIds: historyItemIds,
                outputFormat: outputFormat,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.SpeechHistory.CreateHistoryDownloadAsync(
                xiApiKey: xiApiKey,
                historyItemIds: historyItemIds,
                outputFormat: outputFormat,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}