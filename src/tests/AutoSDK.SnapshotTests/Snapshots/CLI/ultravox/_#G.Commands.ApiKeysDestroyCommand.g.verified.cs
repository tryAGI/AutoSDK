//HintName: G.Commands.ApiKeysDestroyCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ApiKeysDestroyCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string apiKeyPrefix,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> ApiKeyPrefix { get; } = new(
            name: "apiKeyPrefix")
        {
            Description = @"",
        };

        public ApiKeysDestroyCommand(G.IApi client) : base(
            name: "api",
            description: @"Deletes an API key.")
        {
            _client = client;

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
            await _client.ApiKeys.ApiKeysDestroyAsync(
                apiKeyPrefix: apiKeyPrefix,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}