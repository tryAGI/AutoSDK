//HintName: G.Commands.SnapshotsRecoverShardFromUploadedSnapshotCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SnapshotsRecoverShardFromUploadedSnapshotCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string collectionName,
            int shardId,
            bool? wait,
            global::G.SnapshotPriority? priority,
            string? checksum,
            byte[]? snapshot,
            string? snapshotname,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.RecoverShardFromUploadedSnapshotResponse response,
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

        private global::System.CommandLine.Option<bool?> Wait { get; } = new(
            name: "wait")
        {
            Description = @"If true, wait for changes to actually happen. If false - let changes happen in background. Default is true.",
        };

        private global::System.CommandLine.Option<global::G.SnapshotPriority?> Priority { get; } = new(
            name: "priority")
        {
            Description = @"Defines source of truth for snapshot recovery",
        };

        private global::System.CommandLine.Option<string?> Checksum { get; } = new(
            name: "checksum")
        {
            Description = @"Optional SHA256 checksum to verify snapshot integrity before recovery.",
        };

        private global::System.CommandLine.Option<byte[]?> Snapshot { get; } = new(
            name: "snapshot")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> Snapshotname { get; } = new(
            name: "snapshotname")
        {
            Description = @"",
        };


        public SnapshotsRecoverShardFromUploadedSnapshotCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "recover",
            description: @"Recover shard of a local collection from an uploaded snapshot. This will overwrite any data, stored on this node, for the collection shard.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(CollectionName);
            Arguments.Add(ShardId);
            Options.Add(Wait);
            Options.Add(Priority);
            Options.Add(Checksum);
            Options.Add(Snapshot);
            Options.Add(Snapshotname);

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
            var priority = parseResult.GetRequiredValue(Priority);
            var checksum = parseResult.GetRequiredValue(Checksum);
            var snapshot = parseResult.GetRequiredValue(Snapshot);
            var snapshotname = parseResult.GetRequiredValue(Snapshotname);

            Validate(
                parseResult: parseResult,
                collectionName: collectionName,
                shardId: shardId,
                wait: wait,
                priority: priority,
                checksum: checksum,
                snapshot: snapshot,
                snapshotname: snapshotname,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Snapshots.RecoverShardFromUploadedSnapshotAsync(
                collectionName: collectionName,
                shardId: shardId,
                wait: wait,
                priority: priority,
                checksum: checksum,
                snapshot: snapshot,
                snapshotname: snapshotname,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}