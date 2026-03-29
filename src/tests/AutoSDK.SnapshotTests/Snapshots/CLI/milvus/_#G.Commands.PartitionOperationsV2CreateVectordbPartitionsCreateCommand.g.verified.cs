//HintName: G.Commands.PartitionOperationsV2CreateVectordbPartitionsCreateCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class PartitionOperationsV2CreateVectordbPartitionsCreateCommand : global::System.CommandLine.Command
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
            string partitionName1,
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

        private global::System.CommandLine.Argument<string> PartitionName1 { get; } = new(
            name: "partitionName1")
        {
            Description = @"The name of the target parition.",
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


        public PartitionOperationsV2CreateVectordbPartitionsCreateCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"This operation creates a partition in a collection.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(CollectionName);
            Arguments.Add(PartitionName1);
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
            var partitionName1 = parseResult.GetRequiredValue(PartitionName1);

            Validate(
                parseResult: parseResult,
                requestTimeout: requestTimeout,
                authorization: authorization,
                dbName: dbName,
                collectionName: collectionName,
                partitionName1: partitionName1,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.PartitionOperationsV2.CreateVectordbPartitionsCreateAsync(
                requestTimeout: requestTimeout,
                authorization: authorization,
                dbName: dbName,
                collectionName: collectionName,
                partitionName1: partitionName1,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}