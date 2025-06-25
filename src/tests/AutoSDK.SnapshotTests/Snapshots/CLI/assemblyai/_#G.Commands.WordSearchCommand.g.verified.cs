//HintName: G.Commands.WordSearchCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class WordSearchCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string transcriptId,
            global::System.Collections.Generic.IList<string> words,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.WordSearchResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> TranscriptId { get; } = new(
            name: "transcriptId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<string>> Words { get; } = new(
            name: "words")
        {
            Description = "",
        };

        public WordSearchCommand(G.IApi client) : base(
            name: "word",
            description: @"Search through the transcript for keywords. You can search for individual words, numbers, or phrases containing up to five words or numbers.")
        {
            _client = client;

            Arguments.Add(TranscriptId);
            Arguments.Add(Words);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var transcriptId = parseResult.GetRequiredValue(TranscriptId);
            var words = parseResult.GetRequiredValue(Words);

            Validate(
                parseResult: parseResult,
                transcriptId: transcriptId,
                words: words,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Transcript.WordSearchAsync(
                transcriptId: transcriptId,
                words: words,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}