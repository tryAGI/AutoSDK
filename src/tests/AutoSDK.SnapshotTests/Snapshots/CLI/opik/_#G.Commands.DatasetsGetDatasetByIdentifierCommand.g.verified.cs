//HintName: G.Commands.DatasetsGetDatasetByIdentifierCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DatasetsGetDatasetByIdentifierCommand : global::System.CommandLine.Command
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

            global::G.DatasetPublic response,
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


        public DatasetsGetDatasetByIdentifierCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "get",
            description: @"Get dataset by name")
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
            var response = await _client.Datasets.GetDatasetByIdentifierAsync(
                datasetName: datasetName,
                projectName: projectName,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}