//HintName: G.Commands.DatasetsRetrieveDatasetVersionCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DatasetsRetrieveDatasetVersionCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid id,
            string versionName,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.DatasetVersionPublic response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Guid> Id { get; } = new(
            name: "id")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<string> VersionName { get; } = new(
            name: "versionName")
        {
            Description = @"Version name in format 'vN' (e.g., 'v1', 'v373')",
        };



        public DatasetsRetrieveDatasetVersionCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "retrieve",
            description: @"Get a specific version by its version name (e.g., 'v1', 'v373'). This is more efficient than paginating through all versions for large datasets.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Id);
            Arguments.Add(VersionName);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var id = parseResult.GetRequiredValue(Id);
            var versionName = parseResult.GetRequiredValue(VersionName);

            Validate(
                parseResult: parseResult,
                id: id,
                versionName: versionName,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Datasets.RetrieveDatasetVersionAsync(
                id: id,
                versionName: versionName,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}