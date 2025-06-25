//HintName: G.Commands.GetConvaiAgentsByAgentIdWidgetCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetConvaiAgentsByAgentIdWidgetCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string agentId,
            string? conversationSignature,
            string? xiApiKey,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.GetAgentEmbedResponseModel response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> AgentId { get; } = new(
            name: "agentId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> ConversationSignature { get; } = new(
            name: "conversationSignature")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = "",
        };
        public GetConvaiAgentsByAgentIdWidgetCommand(G.IApi client) : base(
            name: "get",
            description: @"Retrieve the widget configuration for an agent")
        {
            _client = client;

            Arguments.Add(AgentId);
            Options.Add(ConversationSignature);
            Options.Add(XiApiKey);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var agentId = parseResult.GetRequiredValue(AgentId);
            var conversationSignature = parseResult.GetRequiredValue(ConversationSignature);
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);

            Validate(
                parseResult: parseResult,
                agentId: agentId,
                conversationSignature: conversationSignature,
                xiApiKey: xiApiKey,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.ConversationalAI.GetConvaiAgentsByAgentIdWidgetAsync(
                agentId: agentId,
                conversationSignature: conversationSignature,
                xiApiKey: xiApiKey,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}