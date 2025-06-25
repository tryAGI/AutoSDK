//HintName: G.Commands.CreateDubbingResourceByDubbingIdTranslateCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateDubbingResourceByDubbingIdTranslateCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string dubbingId,
            string? xiApiKey,
            global::System.Collections.Generic.IList<string> segments,
            global::System.Collections.Generic.IList<string>? languages,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.SegmentTranslationResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> DubbingId { get; } = new(
            name: "dubbingId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<string>> Segments { get; } = new(
            name: "segments")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<string>?> Languages { get; } = new(
            name: "languages")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = "",
        };
        public CreateDubbingResourceByDubbingIdTranslateCommand(G.IApi client) : base(
            name: "create",
            description: @"Regenerate the translations for either the entire resource or the specified segments/languages. Will automatically transcribe missing transcriptions. Will not automatically regenerate the dubs.")
        {
            _client = client;

            Arguments.Add(DubbingId);
            Arguments.Add(Segments);
            Arguments.Add(Languages);
            Options.Add(XiApiKey);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var dubbingId = parseResult.GetRequiredValue(DubbingId);
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);
            var segments = parseResult.GetRequiredValue(Segments);
            var languages = parseResult.GetRequiredValue(Languages);

            Validate(
                parseResult: parseResult,
                dubbingId: dubbingId,
                xiApiKey: xiApiKey,
                segments: segments,
                languages: languages,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Dubbing.CreateDubbingResourceByDubbingIdTranslateAsync(
                dubbingId: dubbingId,
                xiApiKey: xiApiKey,
                segments: segments,
                languages: languages,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}