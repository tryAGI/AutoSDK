//HintName: G.Commands.SchemaObjectsPropertiesAddCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SchemaObjectsPropertiesAddCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string className,
            global::System.Collections.Generic.IList<global::G.DataTypeItem> dataType,
            string? description,
            global::G.PropertyModuleConfig? moduleConfig,
            string name,
            bool? indexInverted,
            bool? indexFilterable,
            bool? indexSearchable,
            bool? indexRangeFilters,
            global::G.Tokenization? tokenization,
            global::System.Collections.Generic.IList<global::G.NestedProperty>? nestedProperties,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.Property response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> ClassName { get; } = new(
            name: "className")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<global::G.DataTypeItem>> DataType { get; } = new(
            name: "dataType")
        {
            Description = "",
        };

        private new global::System.CommandLine.Argument<string> Name { get; } = new(
            name: "name")
        {
            Description = "",
        };

        private new global::System.CommandLine.Option<string?> Description { get; } = new(
            name: "description")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.PropertyModuleConfig?> ModuleConfig { get; } = new(
            name: "moduleConfig")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> IndexInverted { get; } = new(
            name: "indexInverted")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> IndexFilterable { get; } = new(
            name: "indexFilterable")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> IndexSearchable { get; } = new(
            name: "indexSearchable")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> IndexRangeFilters { get; } = new(
            name: "indexRangeFilters")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.Tokenization?> Tokenization { get; } = new(
            name: "tokenization")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.NestedProperty>?> NestedProperties { get; } = new(
            name: "nestedProperties")
        {
            Description = "",
        };
        public SchemaObjectsPropertiesAddCommand(G.IApi client) : base(
            name: "schema",
            description: @"Add a property to an existing collection. <br/><br/>If possible, we encourage you to create all required properties at collection creation time. Adding a property after collection creation can lead to [some indexing limitations](https://weaviate.io/developers/weaviate/config-refs/schema).")
        {
            _client = client;

            Arguments.Add(ClassName);
            Arguments.Add(DataType);
            Arguments.Add(Name);
            Options.Add(Description);
            Options.Add(ModuleConfig);
            Options.Add(IndexInverted);
            Options.Add(IndexFilterable);
            Options.Add(IndexSearchable);
            Options.Add(IndexRangeFilters);
            Options.Add(Tokenization);
            Options.Add(NestedProperties);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var className = parseResult.GetRequiredValue(ClassName);
            var dataType = parseResult.GetRequiredValue(DataType);
            var description = parseResult.GetRequiredValue(Description);
            var moduleConfig = parseResult.GetRequiredValue(ModuleConfig);
            var name = parseResult.GetRequiredValue(Name);
            var indexInverted = parseResult.GetRequiredValue(IndexInverted);
            var indexFilterable = parseResult.GetRequiredValue(IndexFilterable);
            var indexSearchable = parseResult.GetRequiredValue(IndexSearchable);
            var indexRangeFilters = parseResult.GetRequiredValue(IndexRangeFilters);
            var tokenization = parseResult.GetRequiredValue(Tokenization);
            var nestedProperties = parseResult.GetRequiredValue(NestedProperties);

            Validate(
                parseResult: parseResult,
                className: className,
                dataType: dataType,
                description: description,
                moduleConfig: moduleConfig,
                name: name,
                indexInverted: indexInverted,
                indexFilterable: indexFilterable,
                indexSearchable: indexSearchable,
                indexRangeFilters: indexRangeFilters,
                tokenization: tokenization,
                nestedProperties: nestedProperties,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Schema.SchemaObjectsPropertiesAddAsync(
                className: className,
                dataType: dataType,
                description: description,
                moduleConfig: moduleConfig,
                name: name,
                indexInverted: indexInverted,
                indexFilterable: indexFilterable,
                indexSearchable: indexSearchable,
                indexRangeFilters: indexRangeFilters,
                tokenization: tokenization,
                nestedProperties: nestedProperties,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}