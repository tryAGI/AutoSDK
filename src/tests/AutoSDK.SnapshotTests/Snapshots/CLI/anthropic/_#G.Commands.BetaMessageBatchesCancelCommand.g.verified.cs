//HintName: G.Commands.BetaMessageBatchesCancelCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class BetaMessageBatchesCancelCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string messageBatchId,
            string? anthropicBeta,
            string? anthropicVersion,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.BetaMessageBatch response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> MessageBatchId { get; } = new(
            name: "messageBatchId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> AnthropicBeta { get; } = new(
            name: "anthropicBeta")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> AnthropicVersion { get; } = new(
            name: "anthropicVersion")
        {
            Description = "",
        };
        public BetaMessageBatchesCancelCommand(G.IApi client) : base(
            name: "beta",
            description: @"Batches may be canceled any time before processing ends. Once cancellation is initiated, the batch enters a `canceling` state, at which time the system may complete any in-progress, non-interruptible requests before finalizing cancellation.

The number of canceled requests is specified in `request_counts`. To determine which requests were canceled, check the individual results within the batch. Note that cancellation may not result in any canceled requests if they were non-interruptible.

Learn more about the Message Batches API in our [user guide](/en/docs/build-with-claude/batch-processing)")
        {
            _client = client;

            Arguments.Add(MessageBatchId);
            Options.Add(AnthropicBeta);
            Options.Add(AnthropicVersion);

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

            Validate(
                parseResult: parseResult,
                messageBatchId: messageBatchId,
                anthropicBeta: anthropicBeta,
                anthropicVersion: anthropicVersion,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.MessageBatches.BetaMessageBatchesCancelAsync(
                messageBatchId: messageBatchId,
                anthropicBeta: anthropicBeta,
                anthropicVersion: anthropicVersion,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}