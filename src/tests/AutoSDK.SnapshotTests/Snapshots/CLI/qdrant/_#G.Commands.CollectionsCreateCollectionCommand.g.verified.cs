//HintName: G.Commands.CollectionsCreateCollectionCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CollectionsCreateCollectionCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string collectionName,
            int? timeout,
            global::G.VectorsConfig? vectors,
            int? shardNumber,
            global::G.ShardingMethod? shardingMethod,
            int? replicationFactor,
            int? writeConsistencyFactor,
            bool? onDiskPayload,
            global::G.HnswConfigDiff? hnswConfig,
            global::G.WalConfigDiff? walConfig,
            global::G.OptimizersConfigDiff? optimizersConfig,
            global::G.QuantizationConfig? quantizationConfig,
            global::System.Collections.Generic.Dictionary<string, global::G.SparseVectorParams>? sparseVectors,
            global::G.StrictModeConfig? strictModeConfig,
            global::G.Payload? metadata,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.CreateCollectionResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> CollectionName { get; } = new(
            name: "collectionName")
        {
            Description = @"Name of the new collection",
        };

        private global::System.CommandLine.Option<int?> Timeout { get; } = new(
            name: "timeout")
        {
            Description = @"Wait for operation commit timeout in seconds.
If timeout is reached - request will return with service error.",
        };

        private global::System.CommandLine.Option<global::G.VectorsConfig?> Vectors { get; } = new(
            name: "vectors")
        {
            Description = @"Vector params separator for single and multiple vector modes Single mode:

{ ""size"": 128, ""distance"": ""Cosine"" }

or multiple mode:

{ ""default"": { ""size"": 128, ""distance"": ""Cosine"" } }",
        };

        private global::System.CommandLine.Option<int?> ShardNumber { get; } = new(
            name: "shardNumber")
        {
            Description = @"For auto sharding: Number of shards in collection. - Default is 1 for standalone, otherwise equal to the number of nodes - Minimum is 1

For custom sharding: Number of shards in collection per shard group. - Default is 1, meaning that each shard key will be mapped to a single shard - Minimum is 1",
        };

        private global::System.CommandLine.Option<global::G.ShardingMethod?> ShardingMethod { get; } = new(
            name: "shardingMethod")
        {
            Description = @"Sharding method Default is Auto - points are distributed across all available shards Custom - points are distributed across shards according to shard key",
        };

        private global::System.CommandLine.Option<int?> ReplicationFactor { get; } = new(
            name: "replicationFactor")
        {
            Description = @"Number of shards replicas. Default is 1 Minimum is 1",
        };

        private global::System.CommandLine.Option<int?> WriteConsistencyFactor { get; } = new(
            name: "writeConsistencyFactor")
        {
            Description = @"Defines how many replicas should apply the operation for us to consider it successful. Increasing this number will make the collection more resilient to inconsistencies, but will also make it fail if not enough replicas are available. Does not have any performance impact.",
        };

        private global::System.CommandLine.Option<bool?> OnDiskPayload { get; } = new(
            name: "onDiskPayload")
        {
            Description = @"If true - point's payload will not be stored in memory. It will be read from the disk every time it is requested. This setting saves RAM by (slightly) increasing the response time. Note: those payload values that are involved in filtering and are indexed - remain in RAM.

Default: true",
        };

        private global::System.CommandLine.Option<global::G.HnswConfigDiff?> HnswConfig { get; } = new(
            name: "hnswConfig")
        {
            Description = @"Custom params for HNSW index. If none - values from service configuration file are used.",
        };

        private global::System.CommandLine.Option<global::G.WalConfigDiff?> WalConfig { get; } = new(
            name: "walConfig")
        {
            Description = @"Custom params for WAL. If none - values from service configuration file are used.",
        };

        private global::System.CommandLine.Option<global::G.OptimizersConfigDiff?> OptimizersConfig { get; } = new(
            name: "optimizersConfig")
        {
            Description = @"Custom params for Optimizers.  If none - values from service configuration file are used.",
        };

        private global::System.CommandLine.Option<global::G.QuantizationConfig?> QuantizationConfig { get; } = new(
            name: "quantizationConfig")
        {
            Description = @"Quantization parameters. If none - quantization is disabled.",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.Dictionary<string, global::G.SparseVectorParams>?> SparseVectors { get; } = new(
            name: "sparseVectors")
        {
            Description = @"Sparse vector data config.",
        };

        private global::System.CommandLine.Option<global::G.StrictModeConfig?> StrictModeConfig { get; } = new(
            name: "strictModeConfig")
        {
            Description = @"Strict-mode config.",
        };

        private global::System.CommandLine.Option<global::G.Payload?> Metadata { get; } = new(
            name: "metadata")
        {
            Description = @"Arbitrary JSON metadata for the collection This can be used to store application-specific information such as creation time, migration data, inference model info, etc.",
        };


        public CollectionsCreateCollectionCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"Create new collection with given parameters")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(CollectionName);
            Options.Add(Timeout);
            Options.Add(Vectors);
            Options.Add(ShardNumber);
            Options.Add(ShardingMethod);
            Options.Add(ReplicationFactor);
            Options.Add(WriteConsistencyFactor);
            Options.Add(OnDiskPayload);
            Options.Add(HnswConfig);
            Options.Add(WalConfig);
            Options.Add(OptimizersConfig);
            Options.Add(QuantizationConfig);
            Options.Add(SparseVectors);
            Options.Add(StrictModeConfig);
            Options.Add(Metadata);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var collectionName = parseResult.GetRequiredValue(CollectionName);
            var timeout = parseResult.GetRequiredValue(Timeout);
            var vectors = parseResult.GetRequiredValue(Vectors);
            var shardNumber = parseResult.GetRequiredValue(ShardNumber);
            var shardingMethod = parseResult.GetRequiredValue(ShardingMethod);
            var replicationFactor = parseResult.GetRequiredValue(ReplicationFactor);
            var writeConsistencyFactor = parseResult.GetRequiredValue(WriteConsistencyFactor);
            var onDiskPayload = parseResult.GetRequiredValue(OnDiskPayload);
            var hnswConfig = parseResult.GetRequiredValue(HnswConfig);
            var walConfig = parseResult.GetRequiredValue(WalConfig);
            var optimizersConfig = parseResult.GetRequiredValue(OptimizersConfig);
            var quantizationConfig = parseResult.GetRequiredValue(QuantizationConfig);
            var sparseVectors = parseResult.GetRequiredValue(SparseVectors);
            var strictModeConfig = parseResult.GetRequiredValue(StrictModeConfig);
            var metadata = parseResult.GetRequiredValue(Metadata);

            Validate(
                parseResult: parseResult,
                collectionName: collectionName,
                timeout: timeout,
                vectors: vectors,
                shardNumber: shardNumber,
                shardingMethod: shardingMethod,
                replicationFactor: replicationFactor,
                writeConsistencyFactor: writeConsistencyFactor,
                onDiskPayload: onDiskPayload,
                hnswConfig: hnswConfig,
                walConfig: walConfig,
                optimizersConfig: optimizersConfig,
                quantizationConfig: quantizationConfig,
                sparseVectors: sparseVectors,
                strictModeConfig: strictModeConfig,
                metadata: metadata,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Collections.CreateCollectionAsync(
                collectionName: collectionName,
                timeout: timeout,
                vectors: vectors,
                shardNumber: shardNumber,
                shardingMethod: shardingMethod,
                replicationFactor: replicationFactor,
                writeConsistencyFactor: writeConsistencyFactor,
                onDiskPayload: onDiskPayload,
                hnswConfig: hnswConfig,
                walConfig: walConfig,
                optimizersConfig: optimizersConfig,
                quantizationConfig: quantizationConfig,
                sparseVectors: sparseVectors,
                strictModeConfig: strictModeConfig,
                metadata: metadata,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}