//HintName: G.Commands.ObjectsCreateCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ObjectsCreateCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ObjectsCreateConsistencyLevel? consistencyLevel,
            string? @class,
            object? vectorWeights,
            object? properties,
            global::System.Guid? id,
            long? creationTimeUnix,
            long? lastUpdateTimeUnix,
            global::System.Collections.Generic.IList<float>? vector,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<float>>? vectors,
            string? tenant,
            global::System.Collections.Generic.Dictionary<string, object>? additional,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.Object response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<global::G.ObjectsCreateConsistencyLevel?> ConsistencyLevel { get; } = new(
            name: "consistencyLevel")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Class { get; } = new(
            name: "@class")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<object?> VectorWeights { get; } = new(
            name: "vectorWeights")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<object?> Properties { get; } = new(
            name: "properties")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Guid?> Id { get; } = new(
            name: "id")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<long?> CreationTimeUnix { get; } = new(
            name: "creationTimeUnix")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<long?> LastUpdateTimeUnix { get; } = new(
            name: "lastUpdateTimeUnix")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<float>?> Vector { get; } = new(
            name: "vector")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<float>>?> Vectors { get; } = new(
            name: "vectors")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Tenant { get; } = new(
            name: "tenant")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.Dictionary<string, object>?> Additional { get; } = new(
            name: "additional")
        {
            Description = "",
        };
        public ObjectsCreateCommand(G.IApi client) : base(
            name: "objects",
            description: @"Create a new object. <br/><br/>Meta-data and schema values are validated. <br/><br/>**Note: Use `/batch` for importing many objects**: <br/>If you plan on importing a large number of objects, it's much more efficient to use the `/batch` endpoint. Otherwise, sending multiple single requests sequentially would incur a large performance penalty. <br/><br/>**Note: idempotence of `/objects`**: <br/>POST /objects will fail if an id is provided which already exists in the class. To update an existing object with the objects endpoint, use the PUT or PATCH method.")
        {
            _client = client;

            Options.Add(ConsistencyLevel);
            Options.Add(Class);
            Options.Add(VectorWeights);
            Options.Add(Properties);
            Options.Add(Id);
            Options.Add(CreationTimeUnix);
            Options.Add(LastUpdateTimeUnix);
            Options.Add(Vector);
            Options.Add(Vectors);
            Options.Add(Tenant);
            Options.Add(Additional);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var consistencyLevel = parseResult.GetRequiredValue(ConsistencyLevel);
            var @class = parseResult.GetRequiredValue(Class);
            var vectorWeights = parseResult.GetRequiredValue(VectorWeights);
            var properties = parseResult.GetRequiredValue(Properties);
            var id = parseResult.GetRequiredValue(Id);
            var creationTimeUnix = parseResult.GetRequiredValue(CreationTimeUnix);
            var lastUpdateTimeUnix = parseResult.GetRequiredValue(LastUpdateTimeUnix);
            var vector = parseResult.GetRequiredValue(Vector);
            var vectors = parseResult.GetRequiredValue(Vectors);
            var tenant = parseResult.GetRequiredValue(Tenant);
            var additional = parseResult.GetRequiredValue(Additional);

            Validate(
                parseResult: parseResult,
                consistencyLevel: consistencyLevel,
                @class: @class,
                vectorWeights: vectorWeights,
                properties: properties,
                id: id,
                creationTimeUnix: creationTimeUnix,
                lastUpdateTimeUnix: lastUpdateTimeUnix,
                vector: vector,
                vectors: vectors,
                tenant: tenant,
                additional: additional,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Objects.ObjectsCreateAsync(
                consistencyLevel: consistencyLevel,
                @class: @class,
                vectorWeights: vectorWeights,
                properties: properties,
                id: id,
                creationTimeUnix: creationTimeUnix,
                lastUpdateTimeUnix: lastUpdateTimeUnix,
                vector: vector,
                vectors: vectors,
                tenant: tenant,
                additional: additional,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}