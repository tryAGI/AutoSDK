//HintName: G.Commands.SnapshotsStreamShardSnapshotCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SnapshotsStreamShardSnapshotCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string collectionName,
            int shardId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            byte[] response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> CollectionName { get; } = new(
            name: "collectionName")
        {
            Description = @"Name of the collection",
        };

        private global::System.CommandLine.Argument<int> ShardId { get; } = new(
            name: "shardId")
        {
            Description = @"Id of the shard",
        };



        public SnapshotsStreamShardSnapshotCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "stream",
            description: @"Stream the current state of a shard as a snapshot file")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(CollectionName);
            Arguments.Add(ShardId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var collectionName = parseResult.GetRequiredValue(CollectionName);
            var shardId = parseResult.GetRequiredValue(ShardId);

            Validate(
                parseResult: parseResult,
                collectionName: collectionName,
                shardId: shardId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Snapshots.StreamShardSnapshotAsync(
                collectionName: collectionName,
                shardId: shardId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}