//HintName: G.Commands.VectorOperationsV2CreateVectordbEntitiesSearchCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class VectorOperationsV2CreateVectordbEntitiesSearchCommand : global::System.CommandLine.Command
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
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::G.AnyOf<int?, string>>> vector,
            string? annsField,
            string? filter,
            int? limit,
            int? offset,
            string? groupingField,
            global::System.Collections.Generic.IList<string>? outputFields,
            global::G.SearchParams searchParams,
            global::System.Collections.Generic.IList<string>? partitionNames,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.CreateVectordbEntitiesSearchResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> CollectionName { get; } = new(
            name: "collectionName")
        {
            Description = @"The name of the collection to which this operation applies.",
        };

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::G.AnyOf<int?, string>>>> Vector { get; } = new(
            name: "vector")
        {
            Description = @"A list of vector embeddings.
<include target=""milvus"">Milvus</include><include target=""zilliz"">Zilliz Cloud</include> searches for the most similar vector embeddings to the specified ones.",
        };

        private global::System.CommandLine.Argument<global::G.SearchParams> SearchParams { get; } = new(
            name: "searchParams")
        {
            Description = @"",
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

        private global::System.CommandLine.Option<string?> AnnsField { get; } = new(
            name: "annsField")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> Filter { get; } = new(
            name: "filter")
        {
            Description = @"The filter used to find matches for the search.",
        };

        private global::System.CommandLine.Option<int?> Limit { get; } = new(
            name: "limit")
        {
            Description = @"The total number of entities to return.
You can use this parameter in combination with **offset** in **param** to enable pagination.
The sum of this value and **offset** in **param** should be less than 16,384.",
        };

        private global::System.CommandLine.Option<int?> Offset { get; } = new(
            name: "offset")
        {
            Description = @"The number of records to skip in the search result.      You can use this parameter in combination with limit to enable pagination.     The sum of this value and limit should be less than 16,384.",
        };

        private global::System.CommandLine.Option<string?> GroupingField { get; } = new(
            name: "groupingField")
        {
            Description = @"https://zilliverse.feishu.cn/docx/S3brdwmUHoG33dxhifpcruAYnsb",
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


        public VectorOperationsV2CreateVectordbEntitiesSearchCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"This operation conducts a vector similarity search with an optional scalar filtering expression.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(CollectionName);
            Arguments.Add(Vector);
            Arguments.Add(SearchParams);
            Options.Add(RequestTimeout);
            Options.Add(Authorization);
            Options.Add(DbName);
            Options.Add(AnnsField);
            Options.Add(Filter);
            Options.Add(Limit);
            Options.Add(Offset);
            Options.Add(GroupingField);
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
            var vector = parseResult.GetRequiredValue(Vector);
            var annsField = parseResult.GetRequiredValue(AnnsField);
            var filter = parseResult.GetRequiredValue(Filter);
            var limit = parseResult.GetRequiredValue(Limit);
            var offset = parseResult.GetRequiredValue(Offset);
            var groupingField = parseResult.GetRequiredValue(GroupingField);
            var outputFields = parseResult.GetRequiredValue(OutputFields);
            var searchParams = parseResult.GetRequiredValue(SearchParams);
            var partitionNames = parseResult.GetRequiredValue(PartitionNames);

            Validate(
                parseResult: parseResult,
                requestTimeout: requestTimeout,
                authorization: authorization,
                dbName: dbName,
                collectionName: collectionName,
                vector: vector,
                annsField: annsField,
                filter: filter,
                limit: limit,
                offset: offset,
                groupingField: groupingField,
                outputFields: outputFields,
                searchParams: searchParams,
                partitionNames: partitionNames,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.VectorOperationsV2.CreateVectordbEntitiesSearchAsync(
                requestTimeout: requestTimeout,
                authorization: authorization,
                dbName: dbName,
                collectionName: collectionName,
                vector: vector,
                annsField: annsField,
                filter: filter,
                limit: limit,
                offset: offset,
                groupingField: groupingField,
                outputFields: outputFields,
                searchParams: searchParams,
                partitionNames: partitionNames,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}