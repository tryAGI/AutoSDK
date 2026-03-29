//HintName: G.Commands.IndexesDeleteFieldIndexCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class IndexesDeleteFieldIndexCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string collectionName,
            string fieldName,
            bool? wait,
            global::G.WriteOrdering? ordering,
            int? timeout,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.DeleteFieldIndexResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> CollectionName { get; } = new(
            name: "collectionName")
        {
            Description = @"Name of the collection",
        };

        private global::System.CommandLine.Argument<string> FieldName { get; } = new(
            name: "fieldName")
        {
            Description = @"Name of the field where to delete the index",
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


        public IndexesDeleteFieldIndexCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "delete",
            description: @"Delete field index for collection")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(CollectionName);
            Arguments.Add(FieldName);
            Options.Add(Wait);
            Options.Add(Ordering);
            Options.Add(Timeout);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var collectionName = parseResult.GetRequiredValue(CollectionName);
            var fieldName = parseResult.GetRequiredValue(FieldName);
            var wait = parseResult.GetRequiredValue(Wait);
            var ordering = parseResult.GetRequiredValue(Ordering);
            var timeout = parseResult.GetRequiredValue(Timeout);

            Validate(
                parseResult: parseResult,
                collectionName: collectionName,
                fieldName: fieldName,
                wait: wait,
                ordering: ordering,
                timeout: timeout,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Indexes.DeleteFieldIndexAsync(
                collectionName: collectionName,
                fieldName: fieldName,
                wait: wait,
                ordering: ordering,
                timeout: timeout,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}