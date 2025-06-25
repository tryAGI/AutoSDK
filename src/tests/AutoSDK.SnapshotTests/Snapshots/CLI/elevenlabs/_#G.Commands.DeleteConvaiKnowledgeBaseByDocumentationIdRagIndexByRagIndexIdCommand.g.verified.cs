//HintName: G.Commands.DeleteConvaiKnowledgeBaseByDocumentationIdRagIndexByRagIndexIdCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DeleteConvaiKnowledgeBaseByDocumentationIdRagIndexByRagIndexIdCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string documentationId,
            string ragIndexId,
            string? xiApiKey,
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

        private global::System.CommandLine.Argument<string> RagIndexId { get; } = new(
            name: "ragIndexId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = "",
        };
        public DeleteConvaiKnowledgeBaseByDocumentationIdRagIndexByRagIndexIdCommand(G.IApi client) : base(
            name: "delete",
            description: @"Delete RAG index for the knowledgebase document.")
        {
            _client = client;

            Arguments.Add(DocumentationId);
            Arguments.Add(RagIndexId);
            Options.Add(XiApiKey);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var documentationId = parseResult.GetRequiredValue(DocumentationId);
            var ragIndexId = parseResult.GetRequiredValue(RagIndexId);
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);

            Validate(
                parseResult: parseResult,
                documentationId: documentationId,
                ragIndexId: ragIndexId,
                xiApiKey: xiApiKey,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.ConversationalAI.DeleteConvaiKnowledgeBaseByDocumentationIdRagIndexByRagIndexIdAsync(
                documentationId: documentationId,
                ragIndexId: ragIndexId,
                xiApiKey: xiApiKey,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}