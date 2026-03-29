//HintName: G.Commands.IndexesCreateFieldIndexCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class IndexesCreateFieldIndexCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string collectionName,
            bool? wait,
            global::G.WriteOrdering? ordering,
            int? timeout,
            string fieldName,
            global::G.PayloadFieldSchema? fieldSchema,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.CreateFieldIndexResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> CollectionName { get; } = new(
            name: "collectionName")
        {
            Description = @"Name of the collection",
        };

        private global::System.CommandLine.Argument<string> FieldName { get; } = new(
            name: "fieldName")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<bool?> Wait { get; } = new(
            name: "wait")
        {
            Description = @"If true, wait for changes to actually happen",
        };

        private global::System.CommandLine.Option<global::G.WriteOrdering?> Ordering { get; } = new(
            name: "ordering")
        {
            Description = @"define ordering guarantees for the operation",
        };

        private global::System.CommandLine.Option<int?> Timeout { get; } = new(
            name: "timeout")
        {
            Description = @"Timeout for the operation",
        };

        private global::System.CommandLine.Option<global::G.PayloadFieldSchema?> FieldSchema { get; } = new(
            name: "fieldSchema")
        {
            Description = @"",
        };


        public IndexesCreateFieldIndexCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"Create index for field in collection")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(CollectionName);
            Arguments.Add(FieldName);
            Options.Add(Wait);
            Options.Add(Ordering);
            Options.Add(Timeout);
            Options.Add(FieldSchema);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var collectionName = parseResult.GetRequiredValue(CollectionName);
            var wait = parseResult.GetRequiredValue(Wait);
            var ordering = parseResult.GetRequiredValue(Ordering);
            var timeout = parseResult.GetRequiredValue(Timeout);
            var fieldName = parseResult.GetRequiredValue(FieldName);
            var fieldSchema = parseResult.GetRequiredValue(FieldSchema);

            Validate(
                parseResult: parseResult,
                collectionName: collectionName,
                wait: wait,
                ordering: ordering,
                timeout: timeout,
                fieldName: fieldName,
                fieldSchema: fieldSchema,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Indexes.CreateFieldIndexAsync(
                collectionName: collectionName,
                wait: wait,
                ordering: ordering,
                timeout: timeout,
                fieldName: fieldName,
                fieldSchema: fieldSchema,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}