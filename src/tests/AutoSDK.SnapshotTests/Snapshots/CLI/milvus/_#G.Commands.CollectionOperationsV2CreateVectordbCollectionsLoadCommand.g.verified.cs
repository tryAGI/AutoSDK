//HintName: G.Commands.CollectionOperationsV2CreateVectordbCollectionsLoadCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CollectionOperationsV2CreateVectordbCollectionsLoadCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            int requestHeader,
            string? authorization,
            string? dbName,
            string collectionName1,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<int> RequestHeader { get; } = new(
            name: "requestHeader")
        {
            Description = @"The timeout duration for this operation in seconds. Setting this to None indicates that this operation timeouts when any response arrives or any error occurs.",
        };

        private global::System.CommandLine.Argument<string> CollectionName1 { get; } = new(
            name: "collectionName1")
        {
            Description = @"The name of the target collection.
Setting this to a non-existing collection results in a **MilvusException**.",
        };

        private global::System.CommandLine.Option<string?> Authorization { get; } = new(
            name: "authorization")
        {
            Description = @"The authentication token",
        };

        private global::System.CommandLine.Option<string?> DbName { get; } = new(
            name: "dbName")
        {
            Description = @"The name of the database to which the collection belongs.
Setting this to a non-existing database results in a **MilvusException**.",
        };


        public CollectionOperationsV2CreateVectordbCollectionsLoadCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"This operation loads the data of the current collection into memory.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(RequestHeader);
            Arguments.Add(CollectionName1);
            Options.Add(Authorization);
            Options.Add(DbName);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var requestHeader = parseResult.GetRequiredValue(RequestHeader);
            var authorization = parseResult.GetRequiredValue(Authorization);
            var dbName = parseResult.GetRequiredValue(DbName);
            var collectionName1 = parseResult.GetRequiredValue(CollectionName1);

            Validate(
                parseResult: parseResult,
                requestHeader: requestHeader,
                authorization: authorization,
                dbName: dbName,
                collectionName1: collectionName1,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.CollectionOperationsV2.CreateVectordbCollectionsLoadAsync(
                requestHeader: requestHeader,
                authorization: authorization,
                dbName: dbName,
                collectionName1: collectionName1,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}