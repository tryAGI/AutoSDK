//HintName: G.Commands.DatasetsCreateDatasetItemsFromTracesCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DatasetsCreateDatasetItemsFromTracesCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid datasetId,
            global::System.Collections.Generic.IList<global::System.Guid> traceIds,
            global::G.TraceEnrichmentOptions enrichmentOptions,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Guid> DatasetId { get; } = new(
            name: "datasetId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<global::System.Guid>> TraceIds { get; } = new(
            name: "traceIds")
        {
            Description = @"Set of trace IDs to add to the dataset",
        };

        private global::System.CommandLine.Argument<global::G.TraceEnrichmentOptions> EnrichmentOptions { get; } = new(
            name: "enrichmentOptions")
        {
            Description = @"Options for enriching trace data",
        };



        public DatasetsCreateDatasetItemsFromTracesCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"Create dataset items from traces with enriched metadata")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(DatasetId);
            Arguments.Add(TraceIds);
            Arguments.Add(EnrichmentOptions);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var datasetId = parseResult.GetRequiredValue(DatasetId);
            var traceIds = parseResult.GetRequiredValue(TraceIds);
            var enrichmentOptions = parseResult.GetRequiredValue(EnrichmentOptions);

            Validate(
                parseResult: parseResult,
                datasetId: datasetId,
                traceIds: traceIds,
                enrichmentOptions: enrichmentOptions,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Datasets.CreateDatasetItemsFromTracesAsync(
                datasetId: datasetId,
                traceIds: traceIds,
                enrichmentOptions: enrichmentOptions,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}