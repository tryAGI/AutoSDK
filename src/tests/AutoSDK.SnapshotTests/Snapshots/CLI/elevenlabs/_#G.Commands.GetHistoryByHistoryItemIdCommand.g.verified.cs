//HintName: G.Commands.GetHistoryByHistoryItemIdCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetHistoryByHistoryItemIdCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string historyItemId,
            string? xiApiKey,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.SpeechHistoryItemResponseModel response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> HistoryItemId { get; } = new(
            name: "historyItemId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = "",
        };
        public GetHistoryByHistoryItemIdCommand(G.IApi client) : base(
            name: "get",
            description: @"Retrieves a history item.")
        {
            _client = client;

            Arguments.Add(HistoryItemId);
            Options.Add(XiApiKey);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var historyItemId = parseResult.GetRequiredValue(HistoryItemId);
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);

            Validate(
                parseResult: parseResult,
                historyItemId: historyItemId,
                xiApiKey: xiApiKey,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.SpeechHistory.GetHistoryByHistoryItemIdAsync(
                historyItemId: historyItemId,
                xiApiKey: xiApiKey,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}