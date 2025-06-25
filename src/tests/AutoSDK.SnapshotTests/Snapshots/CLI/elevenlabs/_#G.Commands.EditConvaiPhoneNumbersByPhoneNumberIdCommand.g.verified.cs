//HintName: G.Commands.EditConvaiPhoneNumbersByPhoneNumberIdCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class EditConvaiPhoneNumbersByPhoneNumberIdCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string phoneNumberId,
            string? xiApiKey,
            string? agentId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.UpdatePhoneNumberV1ConvaiPhoneNumbersPhoneNumberIdPatchResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> PhoneNumberId { get; } = new(
            name: "phoneNumberId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> AgentId { get; } = new(
            name: "agentId")
        {
            Description = "",
        };
        public EditConvaiPhoneNumbersByPhoneNumberIdCommand(G.IApi client) : base(
            name: "edit",
            description: @"Update Phone Number details by ID")
        {
            _client = client;

            Arguments.Add(PhoneNumberId);
            Options.Add(XiApiKey);
            Options.Add(AgentId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var phoneNumberId = parseResult.GetRequiredValue(PhoneNumberId);
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);
            var agentId = parseResult.GetRequiredValue(AgentId);

            Validate(
                parseResult: parseResult,
                phoneNumberId: phoneNumberId,
                xiApiKey: xiApiKey,
                agentId: agentId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.ConversationalAI.EditConvaiPhoneNumbersByPhoneNumberIdAsync(
                phoneNumberId: phoneNumberId,
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