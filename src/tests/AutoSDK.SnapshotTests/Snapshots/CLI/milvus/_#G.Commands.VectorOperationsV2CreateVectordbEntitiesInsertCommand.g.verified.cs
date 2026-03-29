//HintName: G.Commands.VectorOperationsV2CreateVectordbEntitiesInsertCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class VectorOperationsV2CreateVectordbEntitiesInsertCommand : global::System.CommandLine.Command
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
            global::G.AnyOf<global::G.CreateVectordbEntitiesInsertRequestData, global::System.Collections.Generic.IList<object>> data,
            string? partitionName,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.HttpapiGenericRespCustomerInsertResp response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> CollectionName { get; } = new(
            name: "collectionName")
        {
            Description = @"The name of an existing collection.",
        };

        private global::System.CommandLine.Argument<global::G.AnyOf<global::G.CreateVectordbEntitiesInsertRequestData, global::System.Collections.Generic.IList<object>>> Data { get; } = new(
            name: "data")
        {
            Description = @"The data to insert into the current collection.
The data to insert should be a dictionary that matches the schema of the current collection or a list of such dictionaries.",
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
            Description = @"The name of the target database.",
        };

        private global::System.CommandLine.Option<string?> PartitionName { get; } = new(
            name: "partitionName")
        {
            Description = @"The name of a partition in the current collection. 
If specified, the data is to be inserted into the specified partition.",
        };


        public VectorOperationsV2CreateVectordbEntitiesInsertCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"This operation inserts data into a specific collection. You can insert a maximum of 100 entities at a time. To insert large volumes of data, please use [the bulk-insert API](https://docs.zilliz.com/docs/data-import).")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(CollectionName);
            Arguments.Add(Data);
            Options.Add(RequestTimeout);
            Options.Add(Authorization);
            Options.Add(DbName);
            Options.Add(PartitionName);

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
            var data = parseResult.GetRequiredValue(Data);
            var partitionName = parseResult.GetRequiredValue(PartitionName);

            Validate(
                parseResult: parseResult,
                requestTimeout: requestTimeout,
                authorization: authorization,
                dbName: dbName,
                collectionName: collectionName,
                data: data,
                partitionName: partitionName,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.VectorOperationsV2.CreateVectordbEntitiesInsertAsync(
                requestTimeout: requestTimeout,
                authorization: authorization,
                dbName: dbName,
                collectionName: collectionName,
                data: data,
                partitionName: partitionName,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}