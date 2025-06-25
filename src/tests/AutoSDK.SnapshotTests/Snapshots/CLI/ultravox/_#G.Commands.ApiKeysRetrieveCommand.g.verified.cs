//HintName: G.Commands.ApiKeysRetrieveCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ApiKeysRetrieveCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string apiKeyPrefix,
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

        public ApiKeysRetrieveCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "api",
            description: @"Gets an API key.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(ApiKeyPrefix);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var apiKeyPrefix = parseResult.GetRequiredValue(ApiKeyPrefix);

            Validate(
                parseResult: parseResult,
                apiKeyPrefix: apiKeyPrefix,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.ApiKeys.ApiKeysRetrieveAsync(
                apiKeyPrefix: apiKeyPrefix,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}