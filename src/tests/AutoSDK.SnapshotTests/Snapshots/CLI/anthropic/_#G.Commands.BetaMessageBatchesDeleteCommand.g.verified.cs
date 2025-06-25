//HintName: G.Commands.BetaMessageBatchesDeleteCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class BetaMessageBatchesDeleteCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string messageBatchId,
            string? anthropicBeta,
            string? anthropicVersion,
            string? xApiKey,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.BetaDeleteMessageBatchResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> MessageBatchId { get; } = new(
            name: "messageBatchId")
        {
            Description = @"ID of the Message Batch.",
        };

        private global::System.CommandLine.Option<string?> AnthropicBeta { get; } = new(
            name: "anthropicBeta")
        {
            Description = @"Optional header to specify the beta version(s) you want to use.

To use multiple betas, use a comma separated list like `beta1,beta2` or specify the header multiple times for each beta.",
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
        public BetaMessageBatchesDeleteCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "beta",
            description: @"Delete a Message Batch.

Message Batches can only be deleted once they've finished processing. If you'd like to delete an in-progress batch, you must first cancel it.

Learn more about the Message Batches API in our [user guide](/en/docs/build-with-claude/batch-processing)")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(MessageBatchId);
            Options.Add(AnthropicBeta);
            Options.Add(AnthropicVersion);
            Options.Add(XApiKey);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var messageBatchId = parseResult.GetRequiredValue(MessageBatchId);
            var anthropicBeta = parseResult.GetRequiredValue(AnthropicBeta);
            var anthropicVersion = parseResult.GetRequiredValue(AnthropicVersion);
            var xApiKey = parseResult.GetRequiredValue(XApiKey);

            Validate(
                parseResult: parseResult,
                messageBatchId: messageBatchId,
                anthropicBeta: anthropicBeta,
                anthropicVersion: anthropicVersion,
                xApiKey: xApiKey,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.MessageBatches.BetaMessageBatchesDeleteAsync(
                messageBatchId: messageBatchId,
                anthropicBeta: anthropicBeta,
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