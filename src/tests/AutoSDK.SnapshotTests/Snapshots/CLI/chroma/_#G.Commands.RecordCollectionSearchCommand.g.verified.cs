//HintName: G.Commands.RecordCollectionSearchCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class RecordCollectionSearchCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string tenant,
            string database,
            string collectionId,
            global::G.ReadLevel? readLevel,
            global::System.Collections.Generic.IList<global::G.SearchPayload> searches,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.SearchResponse response,
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

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<global::G.SearchPayload>> Searches { get; } = new(
            name: "searches")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.ReadLevel?> ReadLevel { get; } = new(
            name: "readLevel")
        {
            Description = @"Specifies whether to include unindexed data in the search results.",
        };


        public RecordCollectionSearchCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "collection",
            description: @"Searches records from a collection with dense, sparse, or hybrid vector search.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Tenant);
            Arguments.Add(Database);
            Arguments.Add(CollectionId);
            Arguments.Add(Searches);
            Options.Add(ReadLevel);

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
            var readLevel = parseResult.GetRequiredValue(ReadLevel);
            var searches = parseResult.GetRequiredValue(Searches);

            Validate(
                parseResult: parseResult,
                tenant: tenant,
                database: database,
                collectionId: collectionId,
                readLevel: readLevel,
                searches: searches,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Record.CollectionSearchAsync(
                tenant: tenant,
                database: database,
                collectionId: collectionId,
                readLevel: readLevel,
                searches: searches,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}