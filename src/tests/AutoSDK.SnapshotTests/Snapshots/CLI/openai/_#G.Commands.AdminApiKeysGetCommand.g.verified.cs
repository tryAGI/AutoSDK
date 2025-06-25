//HintName: G.Commands.AdminApiKeysGetCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AdminApiKeysGetCommand : global::System.CommandLine.Command
    {
        private readonly G.IOpenAiClient _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string keyId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.AdminApiKey response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> KeyId { get; } = new(
            name: "keyId")
        {
            Description = "",
        };

        public AdminApiKeysGetCommand(G.IOpenAiClient client) : base(
            name: "admin",
            description: @"Get details for a specific organization API key by its ID.")
        {
            _client = client;

            Arguments.Add(KeyId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var keyId = parseResult.GetRequiredValue(KeyId);

            Validate(
                parseResult: parseResult,
                keyId: keyId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.AdminApiKeysGetAsync(
                keyId: keyId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}