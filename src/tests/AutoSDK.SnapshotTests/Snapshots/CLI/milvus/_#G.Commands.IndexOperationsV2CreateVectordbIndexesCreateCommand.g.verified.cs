//HintName: G.Commands.IndexOperationsV2CreateVectordbIndexesCreateCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class IndexOperationsV2CreateVectordbIndexesCreateCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            int? requestTimeout,
            string? authorization,
            string? dbName,
            string collectionName,
            global::System.Collections.Generic.IList<global::G.IndexParam> indexParams,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> CollectionName { get; } = new(
            name: "collectionName")
        {
            Description = @"The name of the target collection.
Setting this to a non-existing collection results in a **MilvusException**.",
        };

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<global::G.IndexParam>> IndexParams { get; } = new(
            name: "indexParams")
        {
            Description = @"The parameters that apply to the index-building process.",
        };

        private global::System.CommandLine.Option<int?> RequestTimeout { get; } = new(
            name: "requestTimeout")
        {
            Description = @"The timeout duration for this operation.
Setting this to None indicates that this operation timeouts when any response arrives or any error occurs.",
        };

        private global::System.CommandLine.Option<string?> Authorization { get; } = new(
            name: "authorization")
        {
            Description = @"The authentication token.",
        };

        private global::System.CommandLine.Option<string?> DbName { get; } = new(
            name: "dbName")
        {
            Description = @"The name of the database to which the collection belongs.
Setting this to a non-existing database results in a **MilvusException**.",
        };


        public IndexOperationsV2CreateVectordbIndexesCreateCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"This creates a named index for a target field, which can either be a vector field or a scalar field.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(CollectionName);
            Arguments.Add(IndexParams);
            Options.Add(RequestTimeout);
            Options.Add(Authorization);
            Options.Add(DbName);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var requestTimeout = parseResult.GetRequiredValue(RequestTimeout);
            var authorization = parseResult.GetRequiredValue(Authorization);
            var dbName = parseResult.GetRequiredValue(DbName);
            var collectionName = parseResult.GetRequiredValue(CollectionName);
            var indexParams = parseResult.GetRequiredValue(IndexParams);

            Validate(
                parseResult: parseResult,
                requestTimeout: requestTimeout,
                authorization: authorization,
                dbName: dbName,
                collectionName: collectionName,
                indexParams: indexParams,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.IndexOperationsV2.CreateVectordbIndexesCreateAsync(
                requestTimeout: requestTimeout,
                authorization: authorization,
                dbName: dbName,
                collectionName: collectionName,
                indexParams: indexParams,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}