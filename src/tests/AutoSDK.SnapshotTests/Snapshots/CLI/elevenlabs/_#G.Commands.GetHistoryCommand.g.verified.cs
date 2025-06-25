//HintName: G.Commands.GetHistoryCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetHistoryCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            int? pageSize,
            string? startAfterHistoryItemId,
            string? voiceId,
            string? search,
            global::G.ListGeneratedItemsV1HistoryGetSource? source,
            string? xiApiKey,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.GetSpeechHistoryResponseModel response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<int?> PageSize { get; } = new(
            name: "pageSize")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> StartAfterHistoryItemId { get; } = new(
            name: "startAfterHistoryItemId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> VoiceId { get; } = new(
            name: "voiceId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Search { get; } = new(
            name: "search")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.ListGeneratedItemsV1HistoryGetSource?> Source { get; } = new(
            name: "source")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = "",
        };
        public GetHistoryCommand(G.IApi client) : base(
            name: "get",
            description: @"Returns a list of your generated audio.")
        {
            _client = client;

            Options.Add(PageSize);
            Options.Add(StartAfterHistoryItemId);
            Options.Add(VoiceId);
            Options.Add(Search);
            Options.Add(Source);
            Options.Add(XiApiKey);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var pageSize = parseResult.GetRequiredValue(PageSize);
            var startAfterHistoryItemId = parseResult.GetRequiredValue(StartAfterHistoryItemId);
            var voiceId = parseResult.GetRequiredValue(VoiceId);
            var search = parseResult.GetRequiredValue(Search);
            var source = parseResult.GetRequiredValue(Source);
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);

            Validate(
                parseResult: parseResult,
                pageSize: pageSize,
                startAfterHistoryItemId: startAfterHistoryItemId,
                voiceId: voiceId,
                search: search,
                source: source,
                xiApiKey: xiApiKey,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.SpeechHistory.GetHistoryAsync(
                pageSize: pageSize,
                startAfterHistoryItemId: startAfterHistoryItemId,
                voiceId: voiceId,
                search: search,
                source: source,
                xiApiKey: xiApiKey,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}