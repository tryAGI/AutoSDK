//HintName: G.Commands.DatasetsDeleteDatasetByNameCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DatasetsDeleteDatasetByNameCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string datasetName,
            string? projectName,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> DatasetName { get; } = new(
            name: "datasetName")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> ProjectName { get; } = new(
            name: "projectName")
        {
            Description = @"",
        };


        public DatasetsDeleteDatasetByNameCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "delete",
            description: @"Delete dataset by name")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(DatasetName);
            Options.Add(ProjectName);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var datasetName = parseResult.GetRequiredValue(DatasetName);
            var projectName = parseResult.GetRequiredValue(ProjectName);

            Validate(
                parseResult: parseResult,
                datasetName: datasetName,
                projectName: projectName,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Datasets.DeleteDatasetByNameAsync(
                datasetName: datasetName,
                projectName: projectName,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}