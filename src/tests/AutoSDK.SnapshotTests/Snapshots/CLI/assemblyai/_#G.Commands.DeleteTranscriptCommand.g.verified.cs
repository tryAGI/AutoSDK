//HintName: G.Commands.DeleteTranscriptCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DeleteTranscriptCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string transcriptId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.Transcript response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> TranscriptId { get; } = new(
            name: "transcriptId")
        {
            Description = "",
        };

        public DeleteTranscriptCommand(G.IApi client) : base(
            name: "delete",
            description: @"Remove the data from the transcript and mark it as deleted.")
        {
            _client = client;

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
            var response = await _client.Transcript.DeleteTranscriptAsync(
                transcriptId: transcriptId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}