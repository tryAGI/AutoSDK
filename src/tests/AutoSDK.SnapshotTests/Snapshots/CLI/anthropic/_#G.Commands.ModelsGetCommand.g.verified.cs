//HintName: G.Commands.ModelsGetCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ModelsGetCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string modelId,
            string? anthropicVersion,
            string? xApiKey,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ModelInfo response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> ModelId { get; } = new(
            name: "modelId")
        {
            Description = @"Model identifier or alias.",
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
        public ModelsGetCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "models",
            description: @"Get a specific model.

The Models API response can be used to determine information about a specific model or resolve a model alias to a model ID.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(ModelId);
            Options.Add(AnthropicVersion);
            Options.Add(XApiKey);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var modelId = parseResult.GetRequiredValue(ModelId);
            var anthropicVersion = parseResult.GetRequiredValue(AnthropicVersion);
            var xApiKey = parseResult.GetRequiredValue(XApiKey);

            Validate(
                parseResult: parseResult,
                modelId: modelId,
                anthropicVersion: anthropicVersion,
                xApiKey: xApiKey,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.ModelsGetAsync(
                modelId: modelId,
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