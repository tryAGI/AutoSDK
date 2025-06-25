//HintName: G.Commands.MessageBatchesPostCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class MessageBatchesPostCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? anthropicVersion,
            global::System.Collections.Generic.IList<global::G.MessageBatchIndividualRequestParams> requests,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.MessageBatch response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<global::G.MessageBatchIndividualRequestParams>> Requests { get; } = new(
            name: "requests")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> AnthropicVersion { get; } = new(
            name: "anthropicVersion")
        {
            Description = "",
        };
        public MessageBatchesPostCommand(G.IApi client) : base(
            name: "message",
            description: @"Send a batch of Message creation requests.

The Message Batches API can be used to process multiple Messages API requests at once. Once a Message Batch is created, it begins processing immediately. Batches can take up to 24 hours to complete.

Learn more about the Message Batches API in our [user guide](/en/docs/build-with-claude/batch-processing)")
        {
            _client = client;

            Arguments.Add(Requests);
            Options.Add(AnthropicVersion);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var anthropicVersion = parseResult.GetRequiredValue(AnthropicVersion);
            var requests = parseResult.GetRequiredValue(Requests);

            Validate(
                parseResult: parseResult,
                anthropicVersion: anthropicVersion,
                requests: requests,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.MessageBatches.MessageBatchesPostAsync(
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