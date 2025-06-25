//HintName: G.Commands.RetrieveOpenaiBatchV1OpenaiBatchesBatchIdGetCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class RetrieveOpenaiBatchV1OpenaiBatchesBatchIdGetCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string batchId,
            string? xiApiKey,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            string response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> BatchId { get; } = new(
            name: "batchId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = @"",
        };
        public RetrieveOpenaiBatchV1OpenaiBatchesBatchIdGetCommand(G.IApi client) : base(
            name: "retrieve",
            description: @"")
        {
            _client = client;

            Arguments.Add(BatchId);
            Options.Add(XiApiKey);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var batchId = parseResult.GetRequiredValue(BatchId);
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);

            Validate(
                parseResult: parseResult,
                batchId: batchId,
                xiApiKey: xiApiKey,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.RetrieveOpenaiBatchV1OpenaiBatchesBatchIdGetAsync(
                batchId: batchId,
                xiApiKey: xiApiKey,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}