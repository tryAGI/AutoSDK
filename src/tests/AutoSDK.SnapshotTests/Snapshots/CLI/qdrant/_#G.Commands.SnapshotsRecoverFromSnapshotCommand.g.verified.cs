//HintName: G.Commands.SnapshotsRecoverFromSnapshotCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SnapshotsRecoverFromSnapshotCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string collectionName,
            bool? wait,
            string location,
            global::G.SnapshotPriority? priority,
            string? checksum,
            string? apiKey,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.RecoverFromSnapshotResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> CollectionName { get; } = new(
            name: "collectionName")
        {
            Description = @"Name of the collection",
        };

        private global::System.CommandLine.Argument<string> Location { get; } = new(
            name: "location")
        {
            Description = @"Examples: - URL `http://localhost:8080/collections/my_collection/snapshots/my_snapshot` - Local path `file:///qdrant/snapshots/test_collection-2022-08-04-10-49-10.snapshot`",
        };

        private global::System.CommandLine.Option<bool?> Wait { get; } = new(
            name: "wait")
        {
            Description = @"If true, wait for changes to actually happen. If false - let changes happen in background. Default is true.",
        };

        private global::System.CommandLine.Option<global::G.SnapshotPriority?> Priority { get; } = new(
            name: "priority")
        {
            Description = @"Defines which data should be used as a source of truth if there are other replicas in the cluster. If set to `Snapshot`, the snapshot will be used as a source of truth, and the current state will be overwritten. If set to `Replica`, the current state will be used as a source of truth, and after recovery if will be synchronized with the snapshot.",
        };

        private global::System.CommandLine.Option<string?> Checksum { get; } = new(
            name: "checksum")
        {
            Description = @"Optional SHA256 checksum to verify snapshot integrity before recovery.",
        };

        private global::System.CommandLine.Option<string?> ApiKey { get; } = new(
            name: "apiKey")
        {
            Description = @"Optional API key used when fetching the snapshot from a remote URL.",
        };


        public SnapshotsRecoverFromSnapshotCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "recover",
            description: @"Recover local collection data from a snapshot. This will overwrite any data, stored on this node, for the collection. If collection does not exist - it will be created.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(CollectionName);
            Arguments.Add(Location);
            Options.Add(Wait);
            Options.Add(Priority);
            Options.Add(Checksum);
            Options.Add(ApiKey);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var collectionName = parseResult.GetRequiredValue(CollectionName);
            var wait = parseResult.GetRequiredValue(Wait);
            var location = parseResult.GetRequiredValue(Location);
            var priority = parseResult.GetRequiredValue(Priority);
            var checksum = parseResult.GetRequiredValue(Checksum);
            var apiKey = parseResult.GetRequiredValue(ApiKey);

            Validate(
                parseResult: parseResult,
                collectionName: collectionName,
                wait: wait,
                location: location,
                priority: priority,
                checksum: checksum,
                apiKey: apiKey,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Snapshots.RecoverFromSnapshotAsync(
                collectionName: collectionName,
                wait: wait,
                location: location,
                priority: priority,
                checksum: checksum,
                apiKey: apiKey,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}