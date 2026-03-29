//HintName: G.Commands.DatasetsCreateDatasetItemsFromCsvCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DatasetsCreateDatasetItemsFromCsvCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            object file,
            global::System.Guid datasetId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<object> File { get; } = new(
            name: "file")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<global::System.Guid> DatasetId { get; } = new(
            name: "datasetId")
        {
            Description = @"",
        };



        public DatasetsCreateDatasetItemsFromCsvCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"Create dataset items from uploaded CSV file. CSV should have headers in the first row. Processing happens asynchronously in batches.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(File);
            Arguments.Add(DatasetId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var file = parseResult.GetRequiredValue(File);
            var datasetId = parseResult.GetRequiredValue(DatasetId);

            Validate(
                parseResult: parseResult,
                file: file,
                datasetId: datasetId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Datasets.CreateDatasetItemsFromCsvAsync(
                file: file,
                datasetId: datasetId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}