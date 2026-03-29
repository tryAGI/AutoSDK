//HintName: G.Commands.DistributedCreateShardKeyCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DistributedCreateShardKeyCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string collectionName,
            int? timeout,
            global::G.ShardKey shardKey,
            int? shardsNumber,
            int? replicationFactor,
            global::System.Collections.Generic.IList<int>? placement,
            global::G.ReplicaState? initialState,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.CreateShardKeyResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> CollectionName { get; } = new(
            name: "collectionName")
        {
            Description = @"Name of the collection to create shards for",
        };

        private global::System.CommandLine.Argument<global::G.ShardKey> ShardKey { get; } = new(
            name: "shardKey")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<int?> Timeout { get; } = new(
            name: "timeout")
        {
            Description = @"Wait for operation commit timeout in seconds.
If timeout is reached - request will return with service error.",
        };

        private global::System.CommandLine.Option<int?> ShardsNumber { get; } = new(
            name: "shardsNumber")
        {
            Description = @"How many shards to create for this key If not specified, will use the default value from config",
        };

        private global::System.CommandLine.Option<int?> ReplicationFactor { get; } = new(
            name: "replicationFactor")
        {
            Description = @"How many replicas to create for each shard If not specified, will use the default value from config",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<int>?> Placement { get; } = new(
            name: "placement")
        {
            Description = @"Placement of shards for this key List of peer ids, that can be used to place shards for this key If not specified, will be randomly placed among all peers",
        };

        private global::System.CommandLine.Option<global::G.ReplicaState?> InitialState { get; } = new(
            name: "initialState")
        {
            Description = @"Initial state of the shards for this key If not specified, will be `Initializing` first and then `Active` Warning: do not change this unless you know what you are doing",
        };


        public DistributedCreateShardKeyCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(CollectionName);
            Arguments.Add(ShardKey);
            Options.Add(Timeout);
            Options.Add(ShardsNumber);
            Options.Add(ReplicationFactor);
            Options.Add(Placement);
            Options.Add(InitialState);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var collectionName = parseResult.GetRequiredValue(CollectionName);
            var timeout = parseResult.GetRequiredValue(Timeout);
            var shardKey = parseResult.GetRequiredValue(ShardKey);
            var shardsNumber = parseResult.GetRequiredValue(ShardsNumber);
            var replicationFactor = parseResult.GetRequiredValue(ReplicationFactor);
            var placement = parseResult.GetRequiredValue(Placement);
            var initialState = parseResult.GetRequiredValue(InitialState);

            Validate(
                parseResult: parseResult,
                collectionName: collectionName,
                timeout: timeout,
                shardKey: shardKey,
                shardsNumber: shardsNumber,
                replicationFactor: replicationFactor,
                placement: placement,
                initialState: initialState,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Distributed.CreateShardKeyAsync(
                collectionName: collectionName,
                timeout: timeout,
                shardKey: shardKey,
                shardsNumber: shardsNumber,
                replicationFactor: replicationFactor,
                placement: placement,
                initialState: initialState,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}