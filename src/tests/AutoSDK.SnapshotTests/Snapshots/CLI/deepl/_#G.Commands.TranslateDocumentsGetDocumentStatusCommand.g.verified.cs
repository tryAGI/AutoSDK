//HintName: G.Commands.TranslateDocumentsGetDocumentStatusCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class TranslateDocumentsGetDocumentStatusCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string documentId,
            string documentKey1,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.GetDocumentStatusResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> DocumentId { get; } = new(
            name: "documentId")
        {
            Description = @"The document ID that was sent to the client when the document was uploaded to the API.",
        };

        private global::System.CommandLine.Argument<string> DocumentKey1 { get; } = new(
            name: "documentKey1")
        {
            Description = @"The document encryption key that was sent to the client when the document was uploaded to the API.",
        };



        public TranslateDocumentsGetDocumentStatusCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "get",
            description: @"Retrieve the current status of a document translation process.
If the translation is still in progress, the estimated time remaining is also included in the response.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(DocumentId);
            Arguments.Add(DocumentKey1);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var documentId = parseResult.GetRequiredValue(DocumentId);
            var documentKey1 = parseResult.GetRequiredValue(DocumentKey1);

            Validate(
                parseResult: parseResult,
                documentId: documentId,
                documentKey1: documentKey1,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.TranslateDocuments.GetDocumentStatusAsync(
                documentId: documentId,
                documentKey1: documentKey1,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}