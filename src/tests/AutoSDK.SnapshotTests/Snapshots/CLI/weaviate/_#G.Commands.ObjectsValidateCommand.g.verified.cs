//HintName: G.Commands.ObjectsValidateCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ObjectsValidateCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
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
            global::System.Threading.CancellationToken cancellationToken);


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
        public ObjectsValidateCommand(G.IApi client) : base(
            name: "objects",
            description: @"Validate an object's schema and meta-data without creating it. <br/><br/>If the schema of the object is valid, the request should return nothing with a plain RESTful request. Otherwise, an error object will be returned.")
        {
            _client = client;

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
            await _client.Objects.ObjectsValidateAsync(
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
                cancellationToken: cancellationToken);
        }
    }
}