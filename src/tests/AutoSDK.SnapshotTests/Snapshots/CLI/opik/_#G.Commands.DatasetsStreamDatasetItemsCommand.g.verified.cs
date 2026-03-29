//HintName: G.Commands.DatasetsStreamDatasetItemsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DatasetsStreamDatasetItemsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string datasetName,
            global::System.Guid? lastRetrievedId,
            int? steamLimit,
            string? datasetVersion,
            string? projectName,
            string? filters,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            byte[] response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> DatasetName { get; } = new(
            name: "datasetName")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.Guid?> LastRetrievedId { get; } = new(
            name: "lastRetrievedId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<int?> SteamLimit { get; } = new(
            name: "steamLimit")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> DatasetVersion { get; } = new(
            name: "datasetVersion")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> ProjectName { get; } = new(
            name: "projectName")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> Filters { get; } = new(
            name: "filters")
        {
            Description = @"",
        };


        public DatasetsStreamDatasetItemsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "stream",
            description: @"Stream dataset items")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(DatasetName);
            Options.Add(LastRetrievedId);
            Options.Add(SteamLimit);
            Options.Add(DatasetVersion);
            Options.Add(ProjectName);
            Options.Add(Filters);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var datasetName = parseResult.GetRequiredValue(DatasetName);
            var lastRetrievedId = parseResult.GetRequiredValue(LastRetrievedId);
            var steamLimit = parseResult.GetRequiredValue(SteamLimit);
            var datasetVersion = parseResult.GetRequiredValue(DatasetVersion);
            var projectName = parseResult.GetRequiredValue(ProjectName);
            var filters = parseResult.GetRequiredValue(Filters);

            Validate(
                parseResult: parseResult,
                datasetName: datasetName,
                lastRetrievedId: lastRetrievedId,
                steamLimit: steamLimit,
                datasetVersion: datasetVersion,
                projectName: projectName,
                filters: filters,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Datasets.StreamDatasetItemsAsync(
                datasetName: datasetName,
                lastRetrievedId: lastRetrievedId,
                steamLimit: steamLimit,
                datasetVersion: datasetVersion,
                projectName: projectName,
                filters: filters,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}