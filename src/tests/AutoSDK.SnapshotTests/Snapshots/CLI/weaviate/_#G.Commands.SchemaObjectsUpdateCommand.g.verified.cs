//HintName: G.Commands.SchemaObjectsUpdateCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SchemaObjectsUpdateCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string className,
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

        private global::System.CommandLine.Argument<string> ClassName { get; } = new(
            name: "className")
        {
            Description = "",
        };

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
        public SchemaObjectsUpdateCommand(G.IApi client) : base(
            name: "schema",
            description: @"Alter an existing collection definition. <br/><br/>Note that not all settings are mutable ([see this list](https://weaviate.io/developers/weaviate/config-refs/schema#mutability)). To update any other (i.e. immutable) setting, you need to delete the collection, re-create it with the correct setting and then re-import the data. <br/><br/>This endpoint cannot be used to modify properties. Instead use POST /v1/schema/{className}/properties. A typical use case for this endpoint is to update a index configuration, such as `vectorIndexConfig/dynamicEfFactor`. <br/><br/>You should attach a body to this PUT request with the entire new configuration of the collection.")
        {
            _client = client;

            Arguments.Add(ClassName);
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
            var className = parseResult.GetRequiredValue(ClassName);
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
                className: className,
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
            var response = await _client.Schema.SchemaObjectsUpdateAsync(
                className: className,
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