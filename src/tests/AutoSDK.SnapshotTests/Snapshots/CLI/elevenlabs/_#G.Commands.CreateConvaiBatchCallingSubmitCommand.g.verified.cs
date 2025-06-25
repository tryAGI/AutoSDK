//HintName: G.Commands.CreateConvaiBatchCallingSubmitCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateConvaiBatchCallingSubmitCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? xiApiKey,
            string callName,
            string agentId,
            string agentPhoneNumberId,
            int? scheduledTimeUnix,
            global::System.Collections.Generic.IList<global::G.OutboundCallRecipient> recipients,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.BatchCallResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> CallName { get; } = new(
            name: "callName")
        {
            Description = "",
        };

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

        private global::System.CommandLine.Argument<int?> ScheduledTimeUnix { get; } = new(
            name: "scheduledTimeUnix")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<global::G.OutboundCallRecipient>> Recipients { get; } = new(
            name: "recipients")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = "",
        };
        public CreateConvaiBatchCallingSubmitCommand(G.IApi client) : base(
            name: "create",
            description: @"Submit a batch call request to schedule calls for multiple recipients.")
        {
            _client = client;

            Arguments.Add(CallName);
            Arguments.Add(AgentId);
            Arguments.Add(AgentPhoneNumberId);
            Arguments.Add(ScheduledTimeUnix);
            Arguments.Add(Recipients);
            Options.Add(XiApiKey);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);
            var callName = parseResult.GetRequiredValue(CallName);
            var agentId = parseResult.GetRequiredValue(AgentId);
            var agentPhoneNumberId = parseResult.GetRequiredValue(AgentPhoneNumberId);
            var scheduledTimeUnix = parseResult.GetRequiredValue(ScheduledTimeUnix);
            var recipients = parseResult.GetRequiredValue(Recipients);

            Validate(
                parseResult: parseResult,
                xiApiKey: xiApiKey,
                callName: callName,
                agentId: agentId,
                agentPhoneNumberId: agentPhoneNumberId,
                scheduledTimeUnix: scheduledTimeUnix,
                recipients: recipients,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.ConversationalAI.CreateConvaiBatchCallingSubmitAsync(
                xiApiKey: xiApiKey,
                callName: callName,
                agentId: agentId,
                agentPhoneNumberId: agentPhoneNumberId,
                scheduledTimeUnix: scheduledTimeUnix,
                recipients: recipients,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}