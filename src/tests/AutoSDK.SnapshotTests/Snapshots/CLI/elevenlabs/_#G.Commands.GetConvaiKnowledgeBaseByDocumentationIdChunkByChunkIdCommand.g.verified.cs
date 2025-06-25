//HintName: G.Commands.GetConvaiKnowledgeBaseByDocumentationIdChunkByChunkIdCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetConvaiKnowledgeBaseByDocumentationIdChunkByChunkIdCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string documentationId,
            string chunkId,
            string? xiApiKey,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.KnowledgeBaseDocumentChunkResponseModel response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> DocumentationId { get; } = new(
            name: "documentationId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> ChunkId { get; } = new(
            name: "chunkId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = "",
        };
        public GetConvaiKnowledgeBaseByDocumentationIdChunkByChunkIdCommand(G.IApi client) : base(
            name: "get",
            description: @"Get details about a specific documentation part used by RAG.")
        {
            _client = client;

            Arguments.Add(DocumentationId);
            Arguments.Add(ChunkId);
            Options.Add(XiApiKey);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var documentationId = parseResult.GetRequiredValue(DocumentationId);
            var chunkId = parseResult.GetRequiredValue(ChunkId);
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);

            Validate(
                parseResult: parseResult,
                documentationId: documentationId,
                chunkId: chunkId,
                xiApiKey: xiApiKey,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.ConversationalAI.GetConvaiKnowledgeBaseByDocumentationIdChunkByChunkIdAsync(
                documentationId: documentationId,
                chunkId: chunkId,
                xiApiKey: xiApiKey,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}