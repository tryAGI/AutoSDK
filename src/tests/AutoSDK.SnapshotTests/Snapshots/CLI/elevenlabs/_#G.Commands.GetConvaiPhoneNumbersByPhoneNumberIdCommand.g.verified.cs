//HintName: G.Commands.GetConvaiPhoneNumbersByPhoneNumberIdCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetConvaiPhoneNumbersByPhoneNumberIdCommand : global::System.CommandLine.Command
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
            global::G.GetPhoneNumberV1ConvaiPhoneNumbersPhoneNumberIdGetResponse response,
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
        public GetConvaiPhoneNumbersByPhoneNumberIdCommand(G.IApi client) : base(
            name: "get",
            description: @"Retrieve Phone Number details by ID")
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
            var response = await _client.ConversationalAI.GetConvaiPhoneNumbersByPhoneNumberIdAsync(
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