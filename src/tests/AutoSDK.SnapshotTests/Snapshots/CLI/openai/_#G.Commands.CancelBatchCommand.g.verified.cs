//HintName: G.Commands.CancelBatchCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CancelBatchCommand : global::System.CommandLine.Command
    {
        private readonly G.IOpenAiClient _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string batchId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.Batch response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> BatchId { get; } = new(
            name: "batchId")
        {
            Description = "",
        };

        public CancelBatchCommand(G.IOpenAiClient client) : base(
            name: "cancel",
            description: @"")
        {
            _client = client;

            Arguments.Add(BatchId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var batchId = parseResult.GetRequiredValue(BatchId);

            Validate(
                parseResult: parseResult,
                batchId: batchId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Batch.CancelBatchAsync(
                batchId: batchId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}