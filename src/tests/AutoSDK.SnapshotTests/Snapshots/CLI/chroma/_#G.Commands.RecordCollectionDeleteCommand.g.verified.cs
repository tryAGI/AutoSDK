//HintName: G.Commands.RecordCollectionDeleteCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class RecordCollectionDeleteCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string tenant,
            string database,
            string collectionId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.DeleteCollectionRecordsResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Tenant { get; } = new(
            name: "tenant")
        {
            Description = @"Tenant UUID",
        };

        private global::System.CommandLine.Argument<string> Database { get; } = new(
            name: "database")
        {
            Description = @"Database name",
        };

        private global::System.CommandLine.Argument<string> CollectionId { get; } = new(
            name: "collectionId")
        {
            Description = @"Collection UUID",
        };



        public RecordCollectionDeleteCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "collection",
            description: @"Deletes records in a collection. Can filter by IDs or metadata.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Tenant);
            Arguments.Add(Database);
            Arguments.Add(CollectionId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var tenant = parseResult.GetRequiredValue(Tenant);
            var database = parseResult.GetRequiredValue(Database);
            var collectionId = parseResult.GetRequiredValue(CollectionId);

            Validate(
                parseResult: parseResult,
                tenant: tenant,
                database: database,
                collectionId: collectionId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Record.CollectionDeleteAsync(
                tenant: tenant,
                database: database,
                collectionId: collectionId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}