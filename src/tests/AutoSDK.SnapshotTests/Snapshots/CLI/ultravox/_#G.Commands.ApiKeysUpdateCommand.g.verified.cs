//HintName: G.Commands.ApiKeysUpdateCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ApiKeysUpdateCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string apiKeyPrefix,
            bool? revoked,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.APIKey response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> ApiKeyPrefix { get; } = new(
            name: "apiKeyPrefix")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<bool?> Revoked { get; } = new(
            name: "revoked")
        {
            Description = @"If the API key is revoked, clients cannot use it anymore. (This cannot be undone.)",
        };
        public ApiKeysUpdateCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "api",
            description: @"Updates an API key.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(ApiKeyPrefix);
            Options.Add(Revoked);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var apiKeyPrefix = parseResult.GetRequiredValue(ApiKeyPrefix);
            var revoked = parseResult.GetRequiredValue(Revoked);

            Validate(
                parseResult: parseResult,
                apiKeyPrefix: apiKeyPrefix,
                revoked: revoked,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.ApiKeys.ApiKeysUpdateAsync(
                apiKeyPrefix: apiKeyPrefix,
                revoked: revoked,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}