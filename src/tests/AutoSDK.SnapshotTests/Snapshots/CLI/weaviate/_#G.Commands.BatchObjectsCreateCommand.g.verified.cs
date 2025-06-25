//HintName: G.Commands.BatchObjectsCreateCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class BatchObjectsCreateCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::G.BatchObjectsCreateConsistencyLevel? consistencyLevel,
            global::System.Collections.Generic.IList<global::G.BatchObjectsCreateRequestField>? fields,
            global::System.Collections.Generic.IList<global::G.Object>? objects,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Collections.Generic.IList<global::G.ObjectsGetResponse> response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<global::G.BatchObjectsCreateConsistencyLevel?> ConsistencyLevel { get; } = new(
            name: "consistencyLevel")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.BatchObjectsCreateRequestField>?> Fields { get; } = new(
            name: "fields")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.Object>?> Objects { get; } = new(
            name: "objects")
        {
            Description = "",
        };
        public BatchObjectsCreateCommand(G.IApi client) : base(
            name: "batch",
            description: @"Create new objects in bulk. <br/><br/>Meta-data and schema values are validated. <br/><br/>**Note: idempotence of `/batch/objects`**: <br/>`POST /batch/objects` is idempotent, and will overwrite any existing object given the same id.")
        {
            _client = client;

            Options.Add(ConsistencyLevel);
            Options.Add(Fields);
            Options.Add(Objects);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var consistencyLevel = parseResult.GetRequiredValue(ConsistencyLevel);
            var fields = parseResult.GetRequiredValue(Fields);
            var objects = parseResult.GetRequiredValue(Objects);

            Validate(
                parseResult: parseResult,
                consistencyLevel: consistencyLevel,
                fields: fields,
                objects: objects,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Batch.BatchObjectsCreateAsync(
                consistencyLevel: consistencyLevel,
                fields: fields,
                objects: objects,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}