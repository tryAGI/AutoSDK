//HintName: G.Commands.BetaMessageBatchesPostCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class BetaMessageBatchesPostCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? anthropicBeta,
            string? anthropicVersion,
            global::System.Collections.Generic.IList<global::G.BetaMessageBatchIndividualRequestParams> requests,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.BetaMessageBatch response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<global::G.BetaMessageBatchIndividualRequestParams>> Requests { get; } = new(
            name: "requests")
        {
            Description = @"",
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
        public BetaMessageBatchesPostCommand(G.IApi client) : base(
            name: "beta",
            description: @"Send a batch of Message creation requests.

The Message Batches API can be used to process multiple Messages API requests at once. Once a Message Batch is created, it begins processing immediately. Batches can take up to 24 hours to complete.

Learn more about the Message Batches API in our [user guide](/en/docs/build-with-claude/batch-processing)")
        {
            _client = client;

            Arguments.Add(Requests);
            Options.Add(AnthropicBeta);
            Options.Add(AnthropicVersion);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var anthropicBeta = parseResult.GetRequiredValue(AnthropicBeta);
            var anthropicVersion = parseResult.GetRequiredValue(AnthropicVersion);
            var requests = parseResult.GetRequiredValue(Requests);

            Validate(
                parseResult: parseResult,
                anthropicBeta: anthropicBeta,
                anthropicVersion: anthropicVersion,
                requests: requests,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.MessageBatches.BetaMessageBatchesPostAsync(
                anthropicBeta: anthropicBeta,
                anthropicVersion: anthropicVersion,
                requests: requests,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}