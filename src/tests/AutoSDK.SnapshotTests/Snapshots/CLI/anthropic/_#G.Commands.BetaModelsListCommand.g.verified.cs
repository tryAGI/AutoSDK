//HintName: G.Commands.BetaModelsListCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class BetaModelsListCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? beforeId,
            string? afterId,
            int? limit,
            string? anthropicVersion,
            string? xApiKey,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.BetaListResponseModelInfo response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<string?> BeforeId { get; } = new(
            name: "beforeId")
        {
            Description = @"ID of the object to use as a cursor for pagination. When provided, returns the page of results immediately before this object.",
        };

        private global::System.CommandLine.Option<string?> AfterId { get; } = new(
            name: "afterId")
        {
            Description = @"ID of the object to use as a cursor for pagination. When provided, returns the page of results immediately after this object.",
        };

        private global::System.CommandLine.Option<int?> Limit { get; } = new(
            name: "limit")
        {
            Description = @"Number of items to return per page.

Defaults to `20`. Ranges from `1` to `1000`.",
        };

        private global::System.CommandLine.Option<string?> AnthropicVersion { get; } = new(
            name: "anthropicVersion")
        {
            Description = @"The version of the Anthropic API you want to use.

Read more about versioning and our version history [here](https://docs.anthropic.com/en/api/versioning).",
        };

        private global::System.CommandLine.Option<string?> XApiKey { get; } = new(
            name: "xApiKey")
        {
            Description = @"Your unique API key for authentication.

This key is required in the header of all API requests, to authenticate your account and access Anthropic's services. Get your API key through the [Console](https://console.anthropic.com/settings/keys). Each key is scoped to a Workspace.",
        };
        public BetaModelsListCommand(G.IApi client) : base(
            name: "beta",
            description: @"List available models.

The Models API response can be used to determine which models are available for use in the API. More recently released models are listed first.")
        {
            _client = client;

            Options.Add(BeforeId);
            Options.Add(AfterId);
            Options.Add(Limit);
            Options.Add(AnthropicVersion);
            Options.Add(XApiKey);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var beforeId = parseResult.GetRequiredValue(BeforeId);
            var afterId = parseResult.GetRequiredValue(AfterId);
            var limit = parseResult.GetRequiredValue(Limit);
            var anthropicVersion = parseResult.GetRequiredValue(AnthropicVersion);
            var xApiKey = parseResult.GetRequiredValue(XApiKey);

            Validate(
                parseResult: parseResult,
                beforeId: beforeId,
                afterId: afterId,
                limit: limit,
                anthropicVersion: anthropicVersion,
                xApiKey: xApiKey,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.BetaModelsListAsync(
                beforeId: beforeId,
                afterId: afterId,
                limit: limit,
                anthropicVersion: anthropicVersion,
                xApiKey: xApiKey,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}