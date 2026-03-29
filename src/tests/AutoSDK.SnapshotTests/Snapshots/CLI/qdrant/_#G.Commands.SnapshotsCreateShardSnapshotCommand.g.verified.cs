//HintName: G.Commands.SnapshotsCreateShardSnapshotCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SnapshotsCreateShardSnapshotCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string collectionName,
            int shardId,
            bool? wait,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.CreateShardSnapshotResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> CollectionName { get; } = new(
            name: "collectionName")
        {
            Description = @"Name of the collection for which to create a snapshot",
        };

        private global::System.CommandLine.Argument<int> ShardId { get; } = new(
            name: "shardId")
        {
            Description = @"Id of the shard",
        };

        private global::System.CommandLine.Option<bool?> Wait { get; } = new(
            name: "wait")
        {
            Description = @"If true, wait for changes to actually happen. If false - let changes happen in background. Default is true.",
        };


        public SnapshotsCreateShardSnapshotCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"Create new snapshot of a shard for a collection")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(CollectionName);
            Arguments.Add(ShardId);
            Options.Add(Wait);

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

            Validate(
                parseResult: parseResult,
                collectionName: collectionName,
                shardId: shardId,
                wait: wait,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Snapshots.CreateShardSnapshotAsync(
                collectionName: collectionName,
                shardId: shardId,
                wait: wait,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}