//HintName: G.Commands.GetSubtitlesCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetSubtitlesCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string transcriptId,
            global::G.SubtitleFormat subtitleFormat,
            int? charsPerCaption,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            string response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> TranscriptId { get; } = new(
            name: "transcriptId")
        {
            Description = @"ID of the transcript",
        };

        private global::System.CommandLine.Argument<global::G.SubtitleFormat> SubtitleFormat { get; } = new(
            name: "subtitleFormat")
        {
            Description = @"The format of the captions",
        };

        private global::System.CommandLine.Option<int?> CharsPerCaption { get; } = new(
            name: "charsPerCaption")
        {
            Description = @"The maximum number of characters per caption",
        };
        public GetSubtitlesCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "get",
            description: @"Export your transcript in SRT or VTT format to use with a video player for subtitles and closed captions.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(TranscriptId);
            Arguments.Add(SubtitleFormat);
            Options.Add(CharsPerCaption);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var transcriptId = parseResult.GetRequiredValue(TranscriptId);
            var subtitleFormat = parseResult.GetRequiredValue(SubtitleFormat);
            var charsPerCaption = parseResult.GetRequiredValue(CharsPerCaption);

            Validate(
                parseResult: parseResult,
                transcriptId: transcriptId,
                subtitleFormat: subtitleFormat,
                charsPerCaption: charsPerCaption,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Transcript.GetSubtitlesAsync(
                transcriptId: transcriptId,
                subtitleFormat: subtitleFormat,
                charsPerCaption: charsPerCaption,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}