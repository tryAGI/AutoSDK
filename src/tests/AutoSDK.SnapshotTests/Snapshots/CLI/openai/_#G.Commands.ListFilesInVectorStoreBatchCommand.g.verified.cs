//HintName: G.Commands.ListFilesInVectorStoreBatchCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ListFilesInVectorStoreBatchCommand : global::System.CommandLine.Command
    {
        private readonly G.IOpenAiClient _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string vectorStoreId,
            string batchId,
            int? limit,
            global::G.ListFilesInVectorStoreBatchOrder? order,
            string? after,
            string? before,
            global::G.ListFilesInVectorStoreBatchFilter? filter,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ListVectorStoreFilesResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> VectorStoreId { get; } = new(
            name: "vectorStoreId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> BatchId { get; } = new(
            name: "batchId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> Limit { get; } = new(
            name: "limit")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.ListFilesInVectorStoreBatchOrder?> Order { get; } = new(
            name: "order")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> After { get; } = new(
            name: "after")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Before { get; } = new(
            name: "before")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.ListFilesInVectorStoreBatchFilter?> Filter { get; } = new(
            name: "filter")
        {
            Description = "",
        };
        public ListFilesInVectorStoreBatchCommand(G.IOpenAiClient client) : base(
            name: "list",
            description: @"")
        {
            _client = client;

            Arguments.Add(VectorStoreId);
            Arguments.Add(BatchId);
            Options.Add(Limit);
            Options.Add(Order);
            Options.Add(After);
            Options.Add(Before);
            Options.Add(Filter);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var vectorStoreId = parseResult.GetRequiredValue(VectorStoreId);
            var batchId = parseResult.GetRequiredValue(BatchId);
            var limit = parseResult.GetRequiredValue(Limit);
            var order = parseResult.GetRequiredValue(Order);
            var after = parseResult.GetRequiredValue(After);
            var before = parseResult.GetRequiredValue(Before);
            var filter = parseResult.GetRequiredValue(Filter);

            Validate(
                parseResult: parseResult,
                vectorStoreId: vectorStoreId,
                batchId: batchId,
                limit: limit,
                order: order,
                after: after,
                before: before,
                filter: filter,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.VectorStores.ListFilesInVectorStoreBatchAsync(
                vectorStoreId: vectorStoreId,
                batchId: batchId,
                limit: limit,
                order: order,
                after: after,
                before: before,
                filter: filter,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}