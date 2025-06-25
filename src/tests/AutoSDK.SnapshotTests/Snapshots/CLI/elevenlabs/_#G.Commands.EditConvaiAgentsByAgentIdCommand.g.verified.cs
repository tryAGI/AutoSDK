//HintName: G.Commands.EditConvaiAgentsByAgentIdCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class EditConvaiAgentsByAgentIdCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string agentId,
            string? xiApiKey,
            object? conversationConfig,
            object? platformSettings,
            string? name,
            global::System.Collections.Generic.IList<string>? tags,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.GetAgentResponseModel response,
            global::System.Threading.CancellationToken cancellationToken);

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

        private global::System.CommandLine.Option<object?> ConversationConfig { get; } = new(
            name: "conversationConfig")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<object?> PlatformSettings { get; } = new(
            name: "platformSettings")
        {
            Description = "",
        };

        private new global::System.CommandLine.Option<string?> Name { get; } = new(
            name: "name")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> Tags { get; } = new(
            name: "tags")
        {
            Description = "",
        };
        public EditConvaiAgentsByAgentIdCommand(G.IApi client) : base(
            name: "edit",
            description: @"Patches an Agent settings")
        {
            _client = client;

            Arguments.Add(AgentId);
            Options.Add(XiApiKey);
            Options.Add(ConversationConfig);
            Options.Add(PlatformSettings);
            Options.Add(Name);
            Options.Add(Tags);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var agentId = parseResult.GetRequiredValue(AgentId);
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);
            var conversationConfig = parseResult.GetRequiredValue(ConversationConfig);
            var platformSettings = parseResult.GetRequiredValue(PlatformSettings);
            var name = parseResult.GetRequiredValue(Name);
            var tags = parseResult.GetRequiredValue(Tags);

            Validate(
                parseResult: parseResult,
                agentId: agentId,
                xiApiKey: xiApiKey,
                conversationConfig: conversationConfig,
                platformSettings: platformSettings,
                name: name,
                tags: tags,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.ConversationalAI.EditConvaiAgentsByAgentIdAsync(
                agentId: agentId,
                xiApiKey: xiApiKey,
                conversationConfig: conversationConfig,
                platformSettings: platformSettings,
                name: name,
                tags: tags,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}