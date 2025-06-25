//HintName: G.Commands.GetConvaiKnowledgeBaseByDocumentationIdRagIndexCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetConvaiKnowledgeBaseByDocumentationIdRagIndexCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string documentationId,
            string? xiApiKey,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.RAGDocumentIndexesResponseModel response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> DocumentationId { get; } = new(
            name: "documentationId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = "",
        };
        public GetConvaiKnowledgeBaseByDocumentationIdRagIndexCommand(G.IApi client) : base(
            name: "get",
            description: @"Provides information about all RAG indexes of the specified knowledgebase document.")
        {
            _client = client;

            Arguments.Add(DocumentationId);
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

            Validate(
                parseResult: parseResult,
                documentationId: documentationId,
                xiApiKey: xiApiKey,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.ConversationalAI.GetConvaiKnowledgeBaseByDocumentationIdRagIndexAsync(
                documentationId: documentationId,
                xiApiKey: xiApiKey,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}