//HintName: G.Commands.SnapshotsRecoverShardFromSnapshotCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SnapshotsRecoverShardFromSnapshotCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string collectionName,
            int shardId,
            bool? wait,
            global::G.ShardSnapshotLocation location,
            global::G.SnapshotPriority? priority,
            string? checksum,
            string? apiKey,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.RecoverShardFromSnapshotResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> CollectionName { get; } = new(
            name: "collectionName")
        {
            Description = @"Name of the collection",
        };

        private global::System.CommandLine.Argument<int> ShardId { get; } = new(
            name: "shardId")
        {
            Description = @"Id of the shard to recover",
        };

        private global::System.CommandLine.Argument<global::G.ShardSnapshotLocation> Location { get; } = new(
            name: "location")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<bool?> Wait { get; } = new(
            name: "wait")
        {
            Description = @"If true, wait for changes to actually happen. If false - let changes happen in background. Default is true.",
        };

        private global::System.CommandLine.Option<global::G.SnapshotPriority?> Priority { get; } = new(
            name: "priority")
        {
            Description = @"",
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


        public SnapshotsRecoverShardFromSnapshotCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "recover",
            description: @"Recover shard of a local collection data from a snapshot. This will overwrite any data, stored in this shard, for the collection.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(CollectionName);
            Arguments.Add(ShardId);
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
            var shardId = parseResult.GetRequiredValue(ShardId);
            var wait = parseResult.GetRequiredValue(Wait);
            var location = parseResult.GetRequiredValue(Location);
            var priority = parseResult.GetRequiredValue(Priority);
            var checksum = parseResult.GetRequiredValue(Checksum);
            var apiKey = parseResult.GetRequiredValue(ApiKey);

            Validate(
                parseResult: parseResult,
                collectionName: collectionName,
                shardId: shardId,
                wait: wait,
                location: location,
                priority: priority,
                checksum: checksum,
                apiKey: apiKey,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Snapshots.RecoverShardFromSnapshotAsync(
                collectionName: collectionName,
                shardId: shardId,
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