//HintName: G.Commands.GetDubbingByDubbingIdTranscriptByLanguageCodeCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetDubbingByDubbingIdTranscriptByLanguageCodeCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string dubbingId,
            string languageCode,
            global::G.GetDubbedTranscriptV1DubbingDubbingIdTranscriptLanguageCodeGetFormatType? formatType,
            string? xiApiKey,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            string response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> DubbingId { get; } = new(
            name: "dubbingId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> LanguageCode { get; } = new(
            name: "languageCode")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.GetDubbedTranscriptV1DubbingDubbingIdTranscriptLanguageCodeGetFormatType?> FormatType { get; } = new(
            name: "formatType")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = "",
        };
        public GetDubbingByDubbingIdTranscriptByLanguageCodeCommand(G.IApi client) : base(
            name: "get",
            description: @"Returns transcript for the dub as an SRT or WEBVTT file.")
        {
            _client = client;

            Arguments.Add(DubbingId);
            Arguments.Add(LanguageCode);
            Options.Add(FormatType);
            Options.Add(XiApiKey);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var dubbingId = parseResult.GetRequiredValue(DubbingId);
            var languageCode = parseResult.GetRequiredValue(LanguageCode);
            var formatType = parseResult.GetRequiredValue(FormatType);
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);

            Validate(
                parseResult: parseResult,
                dubbingId: dubbingId,
                languageCode: languageCode,
                formatType: formatType,
                xiApiKey: xiApiKey,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Dubbing.GetDubbingByDubbingIdTranscriptByLanguageCodeAsync(
                dubbingId: dubbingId,
                languageCode: languageCode,
                formatType: formatType,
                xiApiKey: xiApiKey,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}