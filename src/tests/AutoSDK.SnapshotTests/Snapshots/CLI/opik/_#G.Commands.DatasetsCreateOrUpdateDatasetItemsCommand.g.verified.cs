//HintName: G.Commands.DatasetsCreateOrUpdateDatasetItemsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DatasetsCreateOrUpdateDatasetItemsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? datasetName,
            global::System.Guid? datasetId,
            string? projectName,
            global::System.Guid? projectId,
            global::System.Collections.Generic.IList<global::G.DatasetItemWrite> items,
            global::System.Guid? batchGroupId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<global::G.DatasetItemWrite>> Items { get; } = new(
            name: "items")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> DatasetName { get; } = new(
            name: "datasetName")
        {
            Description = @"If null, dataset_id must be provided",
        };

        private global::System.CommandLine.Option<global::System.Guid?> DatasetId { get; } = new(
            name: "datasetId")
        {
            Description = @"If null, dataset_name must be provided",
        };

        private global::System.CommandLine.Option<string?> ProjectName { get; } = new(
            name: "projectName")
        {
            Description = @"Optional. Associates the batch with a project by name. Ignored if project_id is provided.",
        };

        private global::System.CommandLine.Option<global::System.Guid?> ProjectId { get; } = new(
            name: "projectId")
        {
            Description = @"Optional. Associates the batch with a project by ID. Takes precedence over project_name.",
        };

        private global::System.CommandLine.Option<global::System.Guid?> BatchGroupId { get; } = new(
            name: "batchGroupId")
        {
            Description = @"Optional batch group ID to group multiple batches into a single dataset version. If null, mutates the latest version instead of creating a new one.",
        };


        public DatasetsCreateOrUpdateDatasetItemsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"Create/update dataset items based on dataset item id.
Each item's 'id' field is the stable identifier and upsert key.
Provide it to update an existing item, or omit it to create a new one.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Items);
            Options.Add(DatasetName);
            Options.Add(DatasetId);
            Options.Add(ProjectName);
            Options.Add(ProjectId);
            Options.Add(BatchGroupId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var datasetName = parseResult.GetRequiredValue(DatasetName);
            var datasetId = parseResult.GetRequiredValue(DatasetId);
            var projectName = parseResult.GetRequiredValue(ProjectName);
            var projectId = parseResult.GetRequiredValue(ProjectId);
            var items = parseResult.GetRequiredValue(Items);
            var batchGroupId = parseResult.GetRequiredValue(BatchGroupId);

            Validate(
                parseResult: parseResult,
                datasetName: datasetName,
                datasetId: datasetId,
                projectName: projectName,
                projectId: projectId,
                items: items,
                batchGroupId: batchGroupId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Datasets.CreateOrUpdateDatasetItemsAsync(
                datasetName: datasetName,
                datasetId: datasetId,
                projectName: projectName,
                projectId: projectId,
                items: items,
                batchGroupId: batchGroupId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}