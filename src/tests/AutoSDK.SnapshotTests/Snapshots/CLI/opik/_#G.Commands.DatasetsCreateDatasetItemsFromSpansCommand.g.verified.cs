//HintName: G.Commands.DatasetsCreateDatasetItemsFromSpansCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DatasetsCreateDatasetItemsFromSpansCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid datasetId,
            global::System.Collections.Generic.IList<global::System.Guid> spanIds,
            global::G.SpanEnrichmentOptions enrichmentOptions,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Guid> DatasetId { get; } = new(
            name: "datasetId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<global::System.Guid>> SpanIds { get; } = new(
            name: "spanIds")
        {
            Description = @"Set of span IDs to add to the dataset",
        };

        private global::System.CommandLine.Argument<global::G.SpanEnrichmentOptions> EnrichmentOptions { get; } = new(
            name: "enrichmentOptions")
        {
            Description = @"Options for enriching span data",
        };



        public DatasetsCreateDatasetItemsFromSpansCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"Create dataset items from spans with enriched metadata")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(DatasetId);
            Arguments.Add(SpanIds);
            Arguments.Add(EnrichmentOptions);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var datasetId = parseResult.GetRequiredValue(DatasetId);
            var spanIds = parseResult.GetRequiredValue(SpanIds);
            var enrichmentOptions = parseResult.GetRequiredValue(EnrichmentOptions);

            Validate(
                parseResult: parseResult,
                datasetId: datasetId,
                spanIds: spanIds,
                enrichmentOptions: enrichmentOptions,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Datasets.CreateDatasetItemsFromSpansAsync(
                datasetId: datasetId,
                spanIds: spanIds,
                enrichmentOptions: enrichmentOptions,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}