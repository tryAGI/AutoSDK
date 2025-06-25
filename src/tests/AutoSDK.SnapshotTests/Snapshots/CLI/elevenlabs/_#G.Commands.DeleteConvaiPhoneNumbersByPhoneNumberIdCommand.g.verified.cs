//HintName: G.Commands.DeleteConvaiPhoneNumbersByPhoneNumberIdCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DeleteConvaiPhoneNumbersByPhoneNumberIdCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string phoneNumberId,
            string? xiApiKey,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            string response,
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
        public DeleteConvaiPhoneNumbersByPhoneNumberIdCommand(G.IApi client) : base(
            name: "delete",
            description: @"Delete Phone Number by ID")
        {
            _client = client;

            Arguments.Add(PhoneNumberId);
            Options.Add(XiApiKey);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var phoneNumberId = parseResult.GetRequiredValue(PhoneNumberId);
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);

            Validate(
                parseResult: parseResult,
                phoneNumberId: phoneNumberId,
                xiApiKey: xiApiKey,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.ConversationalAI.DeleteConvaiPhoneNumbersByPhoneNumberIdAsync(
                phoneNumberId: phoneNumberId,
                xiApiKey: xiApiKey,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}