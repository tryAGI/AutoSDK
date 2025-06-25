//HintName: G.Commands.GetConvaiKnowledgeBaseByDocumentationIdDependentAgentsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetConvaiKnowledgeBaseByDocumentationIdDependentAgentsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string documentationId,
            string? cursor,
            int? pageSize,
            string? xiApiKey,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.GetKnowledgeBaseDependentAgentsResponseModel response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> DocumentationId { get; } = new(
            name: "documentationId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Cursor { get; } = new(
            name: "cursor")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> PageSize { get; } = new(
            name: "pageSize")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = "",
        };
        public GetConvaiKnowledgeBaseByDocumentationIdDependentAgentsCommand(G.IApi client) : base(
            name: "get",
            description: @"Get a list of agents depending on this knowledge base document")
        {
            _client = client;

            Arguments.Add(DocumentationId);
            Options.Add(Cursor);
            Options.Add(PageSize);
            Options.Add(XiApiKey);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var documentationId = parseResult.GetRequiredValue(DocumentationId);
            var cursor = parseResult.GetRequiredValue(Cursor);
            var pageSize = parseResult.GetRequiredValue(PageSize);
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);

            Validate(
                parseResult: parseResult,
                documentationId: documentationId,
                cursor: cursor,
                pageSize: pageSize,
                xiApiKey: xiApiKey,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.ConversationalAI.GetConvaiKnowledgeBaseByDocumentationIdDependentAgentsAsync(
                documentationId: documentationId,
                cursor: cursor,
                pageSize: pageSize,
                xiApiKey: xiApiKey,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}