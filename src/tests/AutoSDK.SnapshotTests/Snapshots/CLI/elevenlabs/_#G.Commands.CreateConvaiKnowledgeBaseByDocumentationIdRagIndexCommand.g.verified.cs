//HintName: G.Commands.CreateConvaiKnowledgeBaseByDocumentationIdRagIndexCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateConvaiKnowledgeBaseByDocumentationIdRagIndexCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string documentationId,
            string? xiApiKey,
            global::G.EmbeddingModelEnum model,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.RAGDocumentIndexResponseModel response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> DocumentationId { get; } = new(
            name: "documentationId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<global::G.EmbeddingModelEnum> Model { get; } = new(
            name: "model")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = "",
        };
        public CreateConvaiKnowledgeBaseByDocumentationIdRagIndexCommand(G.IApi client) : base(
            name: "create",
            description: @"In case the document is not RAG indexed, it triggers rag indexing task, otherwise it just returns the current status.")
        {
            _client = client;

            Arguments.Add(DocumentationId);
            Arguments.Add(Model);
            Options.Add(XiApiKey);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var documentationId = parseResult.GetRequiredValue(DocumentationId);
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);
            var model = parseResult.GetRequiredValue(Model);

            Validate(
                parseResult: parseResult,
                documentationId: documentationId,
                xiApiKey: xiApiKey,
                model: model,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.ConversationalAI.CreateConvaiKnowledgeBaseByDocumentationIdRagIndexAsync(
                documentationId: documentationId,
                xiApiKey: xiApiKey,
                model: model,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}