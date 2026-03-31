//HintName: G.Commands.ApiKeysCreateApiKeyCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ApiKeysCreateApiKeyCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? name,
            global::System.Collections.Generic.IList<global::G.Scope>? scope,
            global::System.DateTime? expiresAt,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.ApiKeyCreated response,
            global::System.Threading.CancellationToken cancellationToken);


        private new global::System.CommandLine.Option<string?> Name { get; } = new(
            name: "name")
        {
            Description = @"A name/description for the API key",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.Scope>?> Scope { get; } = new(
            name: "scope")
        {
            Description = @"The scope of the API key",
        };

        private global::System.CommandLine.Option<global::System.DateTime?> ExpiresAt { get; } = new(
            name: "expiresAt")
        {
            Description = @"Optional expiration datetime",
        };


        public ApiKeysCreateApiKeyCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"Create a new API key.

Args:
    params: The parameters for creating the API key.

Returns:
    ApiKeyCreated: The response containing the details of the created API key.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Options.Add(Name);
            Options.Add(Scope);
            Options.Add(ExpiresAt);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var name = parseResult.GetRequiredValue(Name);
            var scope = parseResult.GetRequiredValue(Scope);
            var expiresAt = parseResult.GetRequiredValue(ExpiresAt);

            Validate(
                parseResult: parseResult,
                name: name,
                scope: scope,
                expiresAt: expiresAt,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.ApiKeys.CreateApiKeyAsync(
                name: name,
                scope: scope,
                expiresAt: expiresAt,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}