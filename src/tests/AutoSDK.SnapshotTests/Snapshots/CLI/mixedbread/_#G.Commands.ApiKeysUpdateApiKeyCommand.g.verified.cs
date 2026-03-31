//HintName: G.Commands.ApiKeysUpdateApiKeyCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ApiKeysUpdateApiKeyCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid apiKeyId,
            string? name,
            global::System.DateTime? expiresAt,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.ApiKey response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Guid> ApiKeyId { get; } = new(
            name: "apiKeyId")
        {
            Description = @"The ID of the API key to update",
        };

        private new global::System.CommandLine.Option<string?> Name { get; } = new(
            name: "name")
        {
            Description = @"A name/description for the API key",
        };

        private global::System.CommandLine.Option<global::System.DateTime?> ExpiresAt { get; } = new(
            name: "expiresAt")
        {
            Description = @"Optional expiration datetime",
        };


        public ApiKeysUpdateApiKeyCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "update",
            description: @"Update a specific API key by its ID.

Args:
    api_key_id: The ID of the API key to update.
    params: The parameters to update.

Returns:
    ApiKey: The updated API key details.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(ApiKeyId);
            Options.Add(Name);
            Options.Add(ExpiresAt);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var apiKeyId = parseResult.GetRequiredValue(ApiKeyId);
            var name = parseResult.GetRequiredValue(Name);
            var expiresAt = parseResult.GetRequiredValue(ExpiresAt);

            Validate(
                parseResult: parseResult,
                apiKeyId: apiKeyId,
                name: name,
                expiresAt: expiresAt,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.ApiKeys.UpdateApiKeyAsync(
                apiKeyId: apiKeyId,
                name: name,
                expiresAt: expiresAt,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}