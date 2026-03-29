//HintName: G.Commands.CollectionsUpdateCollectionCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CollectionsUpdateCollectionCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string collectionName,
            int? timeout,
            global::System.Collections.Generic.Dictionary<string, global::G.VectorParamsDiff>? vectors,
            global::G.OptimizersConfigDiff? optimizersConfig,
            global::G.CollectionParamsDiff? @params,
            global::G.HnswConfigDiff? hnswConfig,
            global::G.QuantizationConfigDiff? quantizationConfig,
            global::System.Collections.Generic.Dictionary<string, global::G.SparseVectorParams>? sparseVectors,
            global::G.StrictModeConfig? strictModeConfig,
            global::G.Payload? metadata,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.UpdateCollectionResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> CollectionName { get; } = new(
            name: "collectionName")
        {
            Description = @"Name of the collection to update",
        };

        private global::System.CommandLine.Option<int?> Timeout { get; } = new(
            name: "timeout")
        {
            Description = @"Wait for operation commit timeout in seconds.
If timeout is reached - request will return with service error.",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.Dictionary<string, global::G.VectorParamsDiff>?> Vectors { get; } = new(
            name: "vectors")
        {
            Description = @"Map of vector data parameters to update for each named vector. To update parameters in a collection having a single unnamed vector, use an empty string as name.",
        };

        private global::System.CommandLine.Option<global::G.OptimizersConfigDiff?> OptimizersConfig { get; } = new(
            name: "optimizersConfig")
        {
            Description = @"Custom params for Optimizers.  If none - it is left unchanged. This operation is blocking, it will only proceed once all current optimizations are complete",
        };

        private global::System.CommandLine.Option<global::G.CollectionParamsDiff?> Params { get; } = new(
            name: "@params")
        {
            Description = @"Collection base params. If none - it is left unchanged.",
        };

        private global::System.CommandLine.Option<global::G.HnswConfigDiff?> HnswConfig { get; } = new(
            name: "hnswConfig")
        {
            Description = @"HNSW parameters to update for the collection index. If none - it is left unchanged.",
        };

        private global::System.CommandLine.Option<global::G.QuantizationConfigDiff?> QuantizationConfig { get; } = new(
            name: "quantizationConfig")
        {
            Description = @"Quantization parameters to update. If none - it is left unchanged.",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.Dictionary<string, global::G.SparseVectorParams>?> SparseVectors { get; } = new(
            name: "sparseVectors")
        {
            Description = @"Map of sparse vector data parameters to update for each sparse vector.",
        };

        private global::System.CommandLine.Option<global::G.StrictModeConfig?> StrictModeConfig { get; } = new(
            name: "strictModeConfig")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.Payload?> Metadata { get; } = new(
            name: "metadata")
        {
            Description = @"Metadata to update for the collection. If provided, this will merge with existing metadata. To remove metadata, set it to an empty object.",
        };


        public CollectionsUpdateCollectionCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "update",
            description: @"Update parameters of the existing collection")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(CollectionName);
            Options.Add(Timeout);
            Options.Add(Vectors);
            Options.Add(OptimizersConfig);
            Options.Add(Params);
            Options.Add(HnswConfig);
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
            var optimizersConfig = parseResult.GetRequiredValue(OptimizersConfig);
            var @params = parseResult.GetRequiredValue(Params);
            var hnswConfig = parseResult.GetRequiredValue(HnswConfig);
            var quantizationConfig = parseResult.GetRequiredValue(QuantizationConfig);
            var sparseVectors = parseResult.GetRequiredValue(SparseVectors);
            var strictModeConfig = parseResult.GetRequiredValue(StrictModeConfig);
            var metadata = parseResult.GetRequiredValue(Metadata);

            Validate(
                parseResult: parseResult,
                collectionName: collectionName,
                timeout: timeout,
                vectors: vectors,
                optimizersConfig: optimizersConfig,
                @params: @params,
                hnswConfig: hnswConfig,
                quantizationConfig: quantizationConfig,
                sparseVectors: sparseVectors,
                strictModeConfig: strictModeConfig,
                metadata: metadata,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Collections.UpdateCollectionAsync(
                collectionName: collectionName,
                timeout: timeout,
                vectors: vectors,
                optimizersConfig: optimizersConfig,
                @params: @params,
                hnswConfig: hnswConfig,
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