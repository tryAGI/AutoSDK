//HintName: G.Commands.DeleteSingleApiKeyCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DeleteSingleApiKeyCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string apiKeyId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> ApiKeyId { get; } = new(
            name: "apiKeyId")
        {
            Description = @"The ID of API key to operate on. Expected to be a URL safe Base64 encoded UUID.",
        };

        public DeleteSingleApiKeyCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "delete",
            description: @"")
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
            await _client.Manage.DeleteSingleApiKeyAsync(
                apiKeyId: apiKeyId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}