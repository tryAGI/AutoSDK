//HintName: G.Commands.CollectionUpdateCollectionCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CollectionUpdateCollectionCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string tenant,
            string database,
            string collectionId,
            global::G.OneOf<object, global::G.UpdateCollectionConfiguration>? newConfiguration,
            global::G.OneOf<object, global::G.HashMap>? newMetadata,
            string? newName,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.UpdateCollectionResponse response,
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

        private global::System.CommandLine.Option<global::G.OneOf<object, global::G.UpdateCollectionConfiguration>?> NewConfiguration { get; } = new(
            name: "newConfiguration")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.OneOf<object, global::G.HashMap>?> NewMetadata { get; } = new(
            name: "newMetadata")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> NewName { get; } = new(
            name: "newName")
        {
            Description = @"",
        };


        public CollectionUpdateCollectionCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "update",
            description: @"Updates an existing collection's name or metadata.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Tenant);
            Arguments.Add(Database);
            Arguments.Add(CollectionId);
            Options.Add(NewConfiguration);
            Options.Add(NewMetadata);
            Options.Add(NewName);

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
            var newConfiguration = parseResult.GetRequiredValue(NewConfiguration);
            var newMetadata = parseResult.GetRequiredValue(NewMetadata);
            var newName = parseResult.GetRequiredValue(NewName);

            Validate(
                parseResult: parseResult,
                tenant: tenant,
                database: database,
                collectionId: collectionId,
                newConfiguration: newConfiguration,
                newMetadata: newMetadata,
                newName: newName,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Collection.UpdateCollectionAsync(
                tenant: tenant,
                database: database,
                collectionId: collectionId,
                newConfiguration: newConfiguration,
                newMetadata: newMetadata,
                newName: newName,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}