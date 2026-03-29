//HintName: G.Commands.DatasetsDeleteDatasetItemsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DatasetsDeleteDatasetItemsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Collections.Generic.IList<global::System.Guid>? itemIds,
            global::System.Guid? datasetId,
            global::System.Collections.Generic.IList<global::G.DatasetItemFilter>? filters,
            global::System.Guid? batchGroupId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::System.Guid>?> ItemIds { get; } = new(
            name: "itemIds")
        {
            Description = @"List of dataset item IDs to delete (max 1000). Use this to delete specific items by their IDs. Mutually exclusive with 'dataset_id' and 'filters'.",
        };

        private global::System.CommandLine.Option<global::System.Guid?> DatasetId { get; } = new(
            name: "datasetId")
        {
            Description = @"Dataset ID to scope the deletion. Required when using 'filters'. Mutually exclusive with 'item_ids'.",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.DatasetItemFilter>?> Filters { get; } = new(
            name: "filters")
        {
            Description = @"Filters to select dataset items to delete within the specified dataset. Must be used with 'dataset_id'. Mutually exclusive with 'item_ids'. Empty array means 'delete all items in the dataset'.",
        };

        private global::System.CommandLine.Option<global::System.Guid?> BatchGroupId { get; } = new(
            name: "batchGroupId")
        {
            Description = @"Optional batch group ID to group multiple delete operations into a single dataset version. If null, mutates the latest version instead of creating a new one.",
        };


        public DatasetsDeleteDatasetItemsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "delete",
            description: @"Delete dataset items using one of two modes:
1. **Delete by IDs**: Provide 'item_ids' to delete specific items by their IDs
2. **Delete by filters**: Provide 'dataset_id' with optional 'filters' to delete items matching criteria

When using filters, an empty 'filters' array will delete all items in the specified dataset.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Options.Add(ItemIds);
            Options.Add(DatasetId);
            Options.Add(Filters);
            Options.Add(BatchGroupId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var itemIds = parseResult.GetRequiredValue(ItemIds);
            var datasetId = parseResult.GetRequiredValue(DatasetId);
            var filters = parseResult.GetRequiredValue(Filters);
            var batchGroupId = parseResult.GetRequiredValue(BatchGroupId);

            Validate(
                parseResult: parseResult,
                itemIds: itemIds,
                datasetId: datasetId,
                filters: filters,
                batchGroupId: batchGroupId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Datasets.DeleteDatasetItemsAsync(
                itemIds: itemIds,
                datasetId: datasetId,
                filters: filters,
                batchGroupId: batchGroupId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}