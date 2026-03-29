//HintName: G.Commands.DatasetsRestoreDatasetVersionCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DatasetsRestoreDatasetVersionCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid id,
            string versionRef,
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

        private global::System.CommandLine.Argument<string> VersionRef { get; } = new(
            name: "versionRef")
        {
            Description = @"Version hash or tag to restore from",
        };



        public DatasetsRestoreDatasetVersionCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "restore",
            description: @"Restores the dataset to a previous version state by creating a new version with items copied from the specified version. If the version is already the latest, returns it as-is (no-op).")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Id);
            Arguments.Add(VersionRef);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var id = parseResult.GetRequiredValue(Id);
            var versionRef = parseResult.GetRequiredValue(VersionRef);

            Validate(
                parseResult: parseResult,
                id: id,
                versionRef: versionRef,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Datasets.RestoreDatasetVersionAsync(
                id: id,
                versionRef: versionRef,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}