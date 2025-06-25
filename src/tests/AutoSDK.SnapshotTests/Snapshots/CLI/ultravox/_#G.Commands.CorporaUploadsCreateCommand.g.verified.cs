//HintName: G.Commands.CorporaUploadsCreateCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CorporaUploadsCreateCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid corpusId,
            string mimeType,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.CorpusUploadsResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Guid> CorpusId { get; } = new(
            name: "corpusId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<string> MimeType { get; } = new(
            name: "mimeType")
        {
            Description = @"",
        };

        public CorporaUploadsCreateCommand(G.IApi client) : base(
            name: "corpora",
            description: @"Request a presigned URL for uploading a document.")
        {
            _client = client;

            Arguments.Add(CorpusId);
            Arguments.Add(MimeType);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var corpusId = parseResult.GetRequiredValue(CorpusId);
            var mimeType = parseResult.GetRequiredValue(MimeType);

            Validate(
                parseResult: parseResult,
                corpusId: corpusId,
                mimeType: mimeType,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Corpora.CorporaUploadsCreateAsync(
                corpusId: corpusId,
                mimeType: mimeType,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}