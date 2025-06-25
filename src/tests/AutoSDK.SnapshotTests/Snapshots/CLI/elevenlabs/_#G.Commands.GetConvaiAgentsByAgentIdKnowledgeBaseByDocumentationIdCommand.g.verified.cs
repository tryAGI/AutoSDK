//HintName: G.Commands.GetConvaiAgentsByAgentIdKnowledgeBaseByDocumentationIdCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetConvaiAgentsByAgentIdKnowledgeBaseByDocumentationIdCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string documentationId,
            string? xiApiKey,
            string agentId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.GetDocumentationFromKnowledgeBaseV1ConvaiAgentsAgentIdKnowledgeBaseDocumentationIdGetResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> DocumentationId { get; } = new(
            name: "documentationId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> AgentId { get; } = new(
            name: "agentId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = "",
        };
        public GetConvaiAgentsByAgentIdKnowledgeBaseByDocumentationIdCommand(G.IApi client) : base(
            name: "get",
            description: @"Get details about a specific documentation making up the agent's knowledge base")
        {
            _client = client;

            Arguments.Add(DocumentationId);
            Arguments.Add(AgentId);
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
            var agentId = parseResult.GetRequiredValue(AgentId);

            Validate(
                parseResult: parseResult,
                documentationId: documentationId,
                xiApiKey: xiApiKey,
                agentId: agentId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.ConversationalAI.GetConvaiAgentsByAgentIdKnowledgeBaseByDocumentationIdAsync(
                documentationId: documentationId,
                xiApiKey: xiApiKey,
                agentId: agentId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}