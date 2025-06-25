//HintName: G.Commands.ObjectsPatchCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ObjectsPatchCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid id,
            global::G.ObjectsPatchConsistencyLevel? consistencyLevel,
            string? @class,
            object? vectorWeights,
            object? properties,
            global::System.Guid? requestId,
            long? creationTimeUnix,
            long? lastUpdateTimeUnix,
            global::System.Collections.Generic.IList<float>? vector,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<float>>? vectors,
            string? tenant,
            global::System.Collections.Generic.Dictionary<string, object>? additional,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Guid> Id { get; } = new(
            name: "id")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.ObjectsPatchConsistencyLevel?> ConsistencyLevel { get; } = new(
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

        private global::System.CommandLine.Option<global::System.Guid?> RequestId { get; } = new(
            name: "requestId")
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
        public ObjectsPatchCommand(G.IApi client) : base(
            name: "objects",
            description: @"Update an object based on its UUID (using patch semantics). This method supports json-merge style patch semantics (RFC 7396). Provided meta-data and schema values are validated. LastUpdateTime is set to the time this function is called.")
        {
            _client = client;

            Arguments.Add(Id);
            Options.Add(ConsistencyLevel);
            Options.Add(Class);
            Options.Add(VectorWeights);
            Options.Add(Properties);
            Options.Add(RequestId);
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
            var id = parseResult.GetRequiredValue(Id);
            var consistencyLevel = parseResult.GetRequiredValue(ConsistencyLevel);
            var @class = parseResult.GetRequiredValue(Class);
            var vectorWeights = parseResult.GetRequiredValue(VectorWeights);
            var properties = parseResult.GetRequiredValue(Properties);
            var requestId = parseResult.GetRequiredValue(RequestId);
            var creationTimeUnix = parseResult.GetRequiredValue(CreationTimeUnix);
            var lastUpdateTimeUnix = parseResult.GetRequiredValue(LastUpdateTimeUnix);
            var vector = parseResult.GetRequiredValue(Vector);
            var vectors = parseResult.GetRequiredValue(Vectors);
            var tenant = parseResult.GetRequiredValue(Tenant);
            var additional = parseResult.GetRequiredValue(Additional);

            Validate(
                parseResult: parseResult,
                id: id,
                consistencyLevel: consistencyLevel,
                @class: @class,
                vectorWeights: vectorWeights,
                properties: properties,
                requestId: requestId,
                creationTimeUnix: creationTimeUnix,
                lastUpdateTimeUnix: lastUpdateTimeUnix,
                vector: vector,
                vectors: vectors,
                tenant: tenant,
                additional: additional,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Objects.ObjectsPatchAsync(
                id: id,
                consistencyLevel: consistencyLevel,
                @class: @class,
                vectorWeights: vectorWeights,
                properties: properties,
                requestId: requestId,
                creationTimeUnix: creationTimeUnix,
                lastUpdateTimeUnix: lastUpdateTimeUnix,
                vector: vector,
                vectors: vectors,
                tenant: tenant,
                additional: additional,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}