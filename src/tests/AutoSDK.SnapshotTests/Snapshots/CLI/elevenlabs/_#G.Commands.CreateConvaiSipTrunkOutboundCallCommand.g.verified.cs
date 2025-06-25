//HintName: G.Commands.CreateConvaiSipTrunkOutboundCallCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateConvaiSipTrunkOutboundCallCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? xiApiKey,
            string agentId,
            string agentPhoneNumberId,
            string toNumber,
            global::G.ConversationInitiationClientDataRequestInput? conversationInitiationClientData,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.SIPTrunkOutboundCallResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> AgentId { get; } = new(
            name: "agentId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> AgentPhoneNumberId { get; } = new(
            name: "agentPhoneNumberId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> ToNumber { get; } = new(
            name: "toNumber")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.ConversationInitiationClientDataRequestInput?> ConversationInitiationClientData { get; } = new(
            name: "conversationInitiationClientData")
        {
            Description = "",
        };
        public CreateConvaiSipTrunkOutboundCallCommand(G.IApi client) : base(
            name: "create",
            description: @"Handle an outbound call via SIP trunk")
        {
            _client = client;

            Arguments.Add(AgentId);
            Arguments.Add(AgentPhoneNumberId);
            Arguments.Add(ToNumber);
            Options.Add(XiApiKey);
            Options.Add(ConversationInitiationClientData);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);
            var agentId = parseResult.GetRequiredValue(AgentId);
            var agentPhoneNumberId = parseResult.GetRequiredValue(AgentPhoneNumberId);
            var toNumber = parseResult.GetRequiredValue(ToNumber);
            var conversationInitiationClientData = parseResult.GetRequiredValue(ConversationInitiationClientData);

            Validate(
                parseResult: parseResult,
                xiApiKey: xiApiKey,
                agentId: agentId,
                agentPhoneNumberId: agentPhoneNumberId,
                toNumber: toNumber,
                conversationInitiationClientData: conversationInitiationClientData,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.ConversationalAI.CreateConvaiSipTrunkOutboundCallAsync(
                xiApiKey: xiApiKey,
                agentId: agentId,
                agentPhoneNumberId: agentPhoneNumberId,
                toNumber: toNumber,
                conversationInitiationClientData: conversationInitiationClientData,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}