//HintName: G.Commands.DeleteApiTokenV1ApiTokensApiTokenDeleteCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DeleteApiTokenV1ApiTokensApiTokenDeleteCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string apiToken,
            string? xiApiKey,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            string response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> ApiToken { get; } = new(
            name: "apiToken")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = @"",
        };
        public DeleteApiTokenV1ApiTokensApiTokenDeleteCommand(G.IApi client) : base(
            name: "delete",
            description: @"")
        {
            _client = client;

            Arguments.Add(ApiToken);
            Options.Add(XiApiKey);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var apiToken = parseResult.GetRequiredValue(ApiToken);
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);

            Validate(
                parseResult: parseResult,
                apiToken: apiToken,
                xiApiKey: xiApiKey,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.DeleteApiTokenV1ApiTokensApiTokenDeleteAsync(
                apiToken: apiToken,
                xiApiKey: xiApiKey,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}