//HintName: G.Commands.BetaModelsGetCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class BetaModelsGetCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string modelId,
            string? anthropicVersion,
            string? xApiKey,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.BetaModelInfo response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> ModelId { get; } = new(
            name: "modelId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> AnthropicVersion { get; } = new(
            name: "anthropicVersion")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> XApiKey { get; } = new(
            name: "xApiKey")
        {
            Description = "",
        };
        public BetaModelsGetCommand(G.IApi client) : base(
            name: "beta",
            description: @"Get a specific model.

The Models API response can be used to determine information about a specific model or resolve a model alias to a model ID.")
        {
            _client = client;

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
            var response = await _client.BetaModelsGetAsync(
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