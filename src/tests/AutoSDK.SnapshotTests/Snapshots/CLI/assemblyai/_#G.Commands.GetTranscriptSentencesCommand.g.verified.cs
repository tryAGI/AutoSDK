//HintName: G.Commands.GetTranscriptSentencesCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetTranscriptSentencesCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string transcriptId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.SentencesResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> TranscriptId { get; } = new(
            name: "transcriptId")
        {
            Description = @"ID of the transcript",
        };

        public GetTranscriptSentencesCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "get",
            description: @"Get the transcript split by sentences. The API will attempt to semantically segment the transcript into sentences to create more reader-friendly transcripts.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(TranscriptId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var transcriptId = parseResult.GetRequiredValue(TranscriptId);

            Validate(
                parseResult: parseResult,
                transcriptId: transcriptId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Transcript.GetTranscriptSentencesAsync(
                transcriptId: transcriptId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}