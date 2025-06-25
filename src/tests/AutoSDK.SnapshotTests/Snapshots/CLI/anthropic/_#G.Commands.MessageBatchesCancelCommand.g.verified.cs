//HintName: G.Commands.MessageBatchesCancelCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class MessageBatchesCancelCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string messageBatchId,
            string? anthropicVersion,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.MessageBatch response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> MessageBatchId { get; } = new(
            name: "messageBatchId")
        {
            Description = @"ID of the Message Batch.",
        };

        private global::System.CommandLine.Option<string?> AnthropicVersion { get; } = new(
            name: "anthropicVersion")
        {
            Description = @"The version of the Anthropic API you want to use.

Read more about versioning and our version history [here](https://docs.anthropic.com/en/api/versioning).",
        };
        public MessageBatchesCancelCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "message",
            description: @"Batches may be canceled any time before processing ends. Once cancellation is initiated, the batch enters a `canceling` state, at which time the system may complete any in-progress, non-interruptible requests before finalizing cancellation.

The number of canceled requests is specified in `request_counts`. To determine which requests were canceled, check the individual results within the batch. Note that cancellation may not result in any canceled requests if they were non-interruptible.

Learn more about the Message Batches API in our [user guide](/en/docs/build-with-claude/batch-processing)")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(MessageBatchId);
            Options.Add(AnthropicVersion);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var messageBatchId = parseResult.GetRequiredValue(MessageBatchId);
            var anthropicVersion = parseResult.GetRequiredValue(AnthropicVersion);

            Validate(
                parseResult: parseResult,
                messageBatchId: messageBatchId,
                anthropicVersion: anthropicVersion,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.MessageBatches.MessageBatchesCancelAsync(
                messageBatchId: messageBatchId,
                anthropicVersion: anthropicVersion,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}