//HintName: G.Commands.GetConvaiKnowledgeBaseByDocumentationIdContentCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetConvaiKnowledgeBaseByDocumentationIdContentCommand : global::System.CommandLine.Command
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
        public GetConvaiKnowledgeBaseByDocumentationIdContentCommand(G.IApi client) : base(
            name: "get",
            description: @"Get the entire content of a document from the knowledge base")
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
            await _client.ConversationalAI.GetConvaiKnowledgeBaseByDocumentationIdContentAsync(
                documentationId: documentationId,
                xiApiKey: xiApiKey,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}