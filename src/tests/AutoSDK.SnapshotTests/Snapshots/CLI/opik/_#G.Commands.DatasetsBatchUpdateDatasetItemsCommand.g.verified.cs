//HintName: G.Commands.DatasetsBatchUpdateDatasetItemsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DatasetsBatchUpdateDatasetItemsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Collections.Generic.IList<global::System.Guid>? ids,
            global::System.Collections.Generic.IList<global::G.DatasetItemFilter>? filters,
            global::System.Guid? datasetId,
            global::G.DatasetItemUpdate update,
            bool? mergeTags,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::G.DatasetItemUpdate> Update { get; } = new(
            name: "update")
        {
            Description = @"Dataset item update request",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::System.Guid>?> Ids { get; } = new(
            name: "ids")
        {
            Description = @"List of dataset item IDs to update (max 1000). Mutually exclusive with 'filters'.",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.DatasetItemFilter>?> Filters { get; } = new(
            name: "filters")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.Guid?> DatasetId { get; } = new(
            name: "datasetId")
        {
            Description = @"Dataset ID. Required when using 'filters', optional when using 'ids'.",
        };

        private global::System.CommandLine.Option<bool?> MergeTags { get; } = new(
            name: "mergeTags")
        {
            Description = @"If true, merge tags with existing tags instead of replacing them. Default: false. When using 'filters', this is automatically set to true.",
        };


        public DatasetsBatchUpdateDatasetItemsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "batch",
            description: @"Update multiple dataset items")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Update);
            Options.Add(Ids);
            Options.Add(Filters);
            Options.Add(DatasetId);
            Options.Add(MergeTags);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var ids = parseResult.GetRequiredValue(Ids);
            var filters = parseResult.GetRequiredValue(Filters);
            var datasetId = parseResult.GetRequiredValue(DatasetId);
            var update = parseResult.GetRequiredValue(Update);
            var mergeTags = parseResult.GetRequiredValue(MergeTags);

            Validate(
                parseResult: parseResult,
                ids: ids,
                filters: filters,
                datasetId: datasetId,
                update: update,
                mergeTags: mergeTags,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Datasets.BatchUpdateDatasetItemsAsync(
                ids: ids,
                filters: filters,
                datasetId: datasetId,
                update: update,
                mergeTags: mergeTags,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}