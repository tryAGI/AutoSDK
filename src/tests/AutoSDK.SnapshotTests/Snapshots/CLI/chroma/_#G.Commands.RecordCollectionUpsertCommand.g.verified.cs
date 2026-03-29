//HintName: G.Commands.RecordCollectionUpsertCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class RecordCollectionUpsertCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string tenant,
            string database,
            string collectionId,
            global::System.Collections.Generic.IList<string>? documents,
            global::G.EmbeddingsPayload embeddings,
            global::System.Collections.Generic.IList<string> ids,
            global::System.Collections.Generic.IList<global::G.OneOf<object, global::G.HashMap>>? metadatas,
            global::System.Collections.Generic.IList<string>? uris,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.UpsertCollectionRecordsResponse response,
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

        private global::System.CommandLine.Argument<global::G.EmbeddingsPayload> Embeddings { get; } = new(
            name: "embeddings")
        {
            Description = @"Embeddings for each record. Can contain the raw f32 arrays or base64 encoded strings.",
        };

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<string>> Ids { get; } = new(
            name: "ids")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> Documents { get; } = new(
            name: "documents")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.OneOf<object, global::G.HashMap>>?> Metadatas { get; } = new(
            name: "metadatas")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> Uris { get; } = new(
            name: "uris")
        {
            Description = @"",
        };


        public RecordCollectionUpsertCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "collection",
            description: @"Upserts records in a collection (create if not exists, otherwise update).")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Tenant);
            Arguments.Add(Database);
            Arguments.Add(CollectionId);
            Arguments.Add(Embeddings);
            Arguments.Add(Ids);
            Options.Add(Documents);
            Options.Add(Metadatas);
            Options.Add(Uris);

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
            var documents = parseResult.GetRequiredValue(Documents);
            var embeddings = parseResult.GetRequiredValue(Embeddings);
            var ids = parseResult.GetRequiredValue(Ids);
            var metadatas = parseResult.GetRequiredValue(Metadatas);
            var uris = parseResult.GetRequiredValue(Uris);

            Validate(
                parseResult: parseResult,
                tenant: tenant,
                database: database,
                collectionId: collectionId,
                documents: documents,
                embeddings: embeddings,
                ids: ids,
                metadatas: metadatas,
                uris: uris,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Record.CollectionUpsertAsync(
                tenant: tenant,
                database: database,
                collectionId: collectionId,
                documents: documents,
                embeddings: embeddings,
                ids: ids,
                metadatas: metadatas,
                uris: uris,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}