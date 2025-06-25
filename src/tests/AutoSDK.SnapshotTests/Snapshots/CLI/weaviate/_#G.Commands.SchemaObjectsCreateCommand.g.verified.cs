//HintName: G.Commands.SchemaObjectsCreateCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SchemaObjectsCreateCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string class1,
            global::G.ClassVectorConfig? vectorConfig,
            global::G.VectorIndexType? vectorIndexType,
            object? vectorIndexConfig,
            global::G.ShardingConfig? shardingConfig,
            global::G.ReplicationConfig? replicationConfig,
            global::G.InvertedIndexConfig? invertedIndexConfig,
            global::G.MultiTenancyConfig? multiTenancyConfig,
            global::G.Vectorizer? vectorizer,
            global::G.ClassModuleConfig? moduleConfig,
            string? description,
            global::System.Collections.Generic.IList<global::G.Property>? properties,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.Class response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Class1 { get; } = new(
            name: "class1")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.ClassVectorConfig?> VectorConfig { get; } = new(
            name: "vectorConfig")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.VectorIndexType?> VectorIndexType { get; } = new(
            name: "vectorIndexType")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<object?> VectorIndexConfig { get; } = new(
            name: "vectorIndexConfig")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.ShardingConfig?> ShardingConfig { get; } = new(
            name: "shardingConfig")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.ReplicationConfig?> ReplicationConfig { get; } = new(
            name: "replicationConfig")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.InvertedIndexConfig?> InvertedIndexConfig { get; } = new(
            name: "invertedIndexConfig")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.MultiTenancyConfig?> MultiTenancyConfig { get; } = new(
            name: "multiTenancyConfig")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.Vectorizer?> Vectorizer { get; } = new(
            name: "vectorizer")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.ClassModuleConfig?> ModuleConfig { get; } = new(
            name: "moduleConfig")
        {
            Description = "",
        };

        private new global::System.CommandLine.Option<string?> Description { get; } = new(
            name: "description")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.Property>?> Properties { get; } = new(
            name: "properties")
        {
            Description = "",
        };
        public SchemaObjectsCreateCommand(G.IApi client) : base(
            name: "schema",
            description: @"Create a new data object collection. <br/><br/>If [AutoSchema](https://weaviate.io/developers/weaviate/config-refs/schema#auto-schema) is enabled, Weaviate will attempt to infer the schema from the data at import time. However, manual schema definition is recommended for production environments. <br/><br/>For further discussions of parameters, please see the [schema reference page](https://weaviate.io/developers/weaviate/config-refs/schema).")
        {
            _client = client;

            Arguments.Add(Class1);
            Options.Add(VectorConfig);
            Options.Add(VectorIndexType);
            Options.Add(VectorIndexConfig);
            Options.Add(ShardingConfig);
            Options.Add(ReplicationConfig);
            Options.Add(InvertedIndexConfig);
            Options.Add(MultiTenancyConfig);
            Options.Add(Vectorizer);
            Options.Add(ModuleConfig);
            Options.Add(Description);
            Options.Add(Properties);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var class1 = parseResult.GetRequiredValue(Class1);
            var vectorConfig = parseResult.GetRequiredValue(VectorConfig);
            var vectorIndexType = parseResult.GetRequiredValue(VectorIndexType);
            var vectorIndexConfig = parseResult.GetRequiredValue(VectorIndexConfig);
            var shardingConfig = parseResult.GetRequiredValue(ShardingConfig);
            var replicationConfig = parseResult.GetRequiredValue(ReplicationConfig);
            var invertedIndexConfig = parseResult.GetRequiredValue(InvertedIndexConfig);
            var multiTenancyConfig = parseResult.GetRequiredValue(MultiTenancyConfig);
            var vectorizer = parseResult.GetRequiredValue(Vectorizer);
            var moduleConfig = parseResult.GetRequiredValue(ModuleConfig);
            var description = parseResult.GetRequiredValue(Description);
            var properties = parseResult.GetRequiredValue(Properties);

            Validate(
                parseResult: parseResult,
                class1: class1,
                vectorConfig: vectorConfig,
                vectorIndexType: vectorIndexType,
                vectorIndexConfig: vectorIndexConfig,
                shardingConfig: shardingConfig,
                replicationConfig: replicationConfig,
                invertedIndexConfig: invertedIndexConfig,
                multiTenancyConfig: multiTenancyConfig,
                vectorizer: vectorizer,
                moduleConfig: moduleConfig,
                description: description,
                properties: properties,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Schema.SchemaObjectsCreateAsync(
                class1: class1,
                vectorConfig: vectorConfig,
                vectorIndexType: vectorIndexType,
                vectorIndexConfig: vectorIndexConfig,
                shardingConfig: shardingConfig,
                replicationConfig: replicationConfig,
                invertedIndexConfig: invertedIndexConfig,
                multiTenancyConfig: multiTenancyConfig,
                vectorizer: vectorizer,
                moduleConfig: moduleConfig,
                description: description,
                properties: properties,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}