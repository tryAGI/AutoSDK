//HintName: G.Commands.VectorOperationsV2CreateVectordbEntitiesGetCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class VectorOperationsV2CreateVectordbEntitiesGetCommand : global::System.CommandLine.Command
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
            global::G.AnyOf<int?, string, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<string>> id,
            global::System.Collections.Generic.IList<string>? outputFields,
            global::System.Collections.Generic.IList<string>? partitionNames,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.CreateVectordbEntitiesGetResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> CollectionName { get; } = new(
            name: "collectionName")
        {
            Description = @"The name of the collection to which this operation applies.",
        };

        private global::System.CommandLine.Argument<global::G.AnyOf<int?, string, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<string>>> Id { get; } = new(
            name: "id")
        {
            Description = @"A specific entity ID or a list of entity IDs.",
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
            Description = @"The name of the database.",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> OutputFields { get; } = new(
            name: "outputFields")
        {
            Description = @"An array of fields to return along with the search results.",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> PartitionNames { get; } = new(
            name: "partitionNames")
        {
            Description = @"The name of the partitions to which this operation applies.",
        };


        public VectorOperationsV2CreateVectordbEntitiesGetCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"This operation gets specific entities by their IDs.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(CollectionName);
            Arguments.Add(Id);
            Options.Add(RequestTimeout);
            Options.Add(Authorization);
            Options.Add(DbName);
            Options.Add(OutputFields);
            Options.Add(PartitionNames);

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
            var id = parseResult.GetRequiredValue(Id);
            var outputFields = parseResult.GetRequiredValue(OutputFields);
            var partitionNames = parseResult.GetRequiredValue(PartitionNames);

            Validate(
                parseResult: parseResult,
                requestTimeout: requestTimeout,
                authorization: authorization,
                dbName: dbName,
                collectionName: collectionName,
                id: id,
                outputFields: outputFields,
                partitionNames: partitionNames,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.VectorOperationsV2.CreateVectordbEntitiesGetAsync(
                requestTimeout: requestTimeout,
                authorization: authorization,
                dbName: dbName,
                collectionName: collectionName,
                id: id,
                outputFields: outputFields,
                partitionNames: partitionNames,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}