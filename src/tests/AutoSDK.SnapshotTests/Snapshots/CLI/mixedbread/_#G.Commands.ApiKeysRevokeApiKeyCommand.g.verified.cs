//HintName: G.Commands.ApiKeysRevokeApiKeyCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ApiKeysRevokeApiKeyCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid apiKeyId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.ApiKey response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Guid> ApiKeyId { get; } = new(
            name: "apiKeyId")
        {
            Description = @"The ID of the API key to revoke",
        };



        public ApiKeysRevokeApiKeyCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "revoke",
            description: @"Revoke a specific API key by its ID.

Args:
    api_key_id: The ID of the API key to revoke.

Returns:
    ApiKey: The response containing the details of the revoked API key.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(ApiKeyId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var apiKeyId = parseResult.GetRequiredValue(ApiKeyId);

            Validate(
                parseResult: parseResult,
                apiKeyId: apiKeyId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.ApiKeys.RevokeApiKeyAsync(
                apiKeyId: apiKeyId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}