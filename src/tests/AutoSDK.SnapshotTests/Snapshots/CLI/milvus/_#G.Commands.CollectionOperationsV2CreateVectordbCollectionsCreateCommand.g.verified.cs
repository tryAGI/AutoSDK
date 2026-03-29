//HintName: G.Commands.CollectionOperationsV2CreateVectordbCollectionsCreateCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CollectionOperationsV2CreateVectordbCollectionsCreateCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            int requestTimeout,
            string? authorization,
            string? dbName,
            string? collectionName,
            int? dimension,
            string? metricType,
            string? idType,
            string autoID,
            string? primaryFieldName,
            string? vectorFieldName,
            global::G.CollectionSchema? schema,
            global::System.Collections.Generic.IList<global::G.IndexParam>? indexParams,
            global::G.CollectionParams? @params,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.HttpapiGenericRespCustomerCreateIndexResp response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<int> RequestTimeout { get; } = new(
            name: "requestTimeout")
        {
            Description = @"The timeout duration for this operation. Setting this to None indicates that this operation times out when any response returns or an error occurs.",
        };

        private global::System.CommandLine.Argument<string> AutoID { get; } = new(
            name: "autoID")
        {
            Description = @"Whether the primary field automatically increments. This parameter is designed for the quick-setup of a collection and will be ignored if __schema__ is defined.",
        };

        private global::System.CommandLine.Option<string?> Authorization { get; } = new(
            name: "authorization")
        {
            Description = @"The authentication token.",
        };

        private global::System.CommandLine.Option<string?> DbName { get; } = new(
            name: "dbName")
        {
            Description = @"The name of the database. <zilliz>This parameter applies only to dedicated clusters.</zilliz>",
        };

        private global::System.CommandLine.Option<string?> CollectionName { get; } = new(
            name: "collectionName")
        {
            Description = @"The name of the collection to create.",
        };

        private global::System.CommandLine.Option<int?> Dimension { get; } = new(
            name: "dimension")
        {
            Description = @"The number of dimensions a vector value should have.
This is required if **dtype** of this field is set to **DataType.FLOAT_VECTOR**.",
        };

        private global::System.CommandLine.Option<string?> MetricType { get; } = new(
            name: "metricType")
        {
            Description = @"The metric type applied to this operation. 
Possible values are **L2**, **IP**, and **COSINE**.",
        };

        private global::System.CommandLine.Option<string?> IdType { get; } = new(
            name: "idType")
        {
            Description = @"The data type of the primary field. This parameter is designed for the quick-setup of a collection and will be ignored if __schema__ is defined.",
        };

        private global::System.CommandLine.Option<string?> PrimaryFieldName { get; } = new(
            name: "primaryFieldName")
        {
            Description = @"The name of the primary field. This parameter is designed for the quick-setup of a collection and will be ignored if __schema__ is defined.",
        };

        private global::System.CommandLine.Option<string?> VectorFieldName { get; } = new(
            name: "vectorFieldName")
        {
            Description = @"The name of the vector field. This parameter is designed for the quick-setup of a collection and will be ignored if __schema__ is defined.",
        };

        private global::System.CommandLine.Option<global::G.CollectionSchema?> Schema { get; } = new(
            name: "schema")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.IndexParam>?> IndexParams { get; } = new(
            name: "indexParams")
        {
            Description = @"The parameters that apply to the index-building process.",
        };

        private global::System.CommandLine.Option<global::G.CollectionParams?> Params { get; } = new(
            name: "@params")
        {
            Description = @"",
        };


        public CollectionOperationsV2CreateVectordbCollectionsCreateCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"This operation creates a collection in a specified cluster.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(RequestTimeout);
            Arguments.Add(AutoID);
            Options.Add(Authorization);
            Options.Add(DbName);
            Options.Add(CollectionName);
            Options.Add(Dimension);
            Options.Add(MetricType);
            Options.Add(IdType);
            Options.Add(PrimaryFieldName);
            Options.Add(VectorFieldName);
            Options.Add(Schema);
            Options.Add(IndexParams);
            Options.Add(Params);

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
            var dimension = parseResult.GetRequiredValue(Dimension);
            var metricType = parseResult.GetRequiredValue(MetricType);
            var idType = parseResult.GetRequiredValue(IdType);
            var autoID = parseResult.GetRequiredValue(AutoID);
            var primaryFieldName = parseResult.GetRequiredValue(PrimaryFieldName);
            var vectorFieldName = parseResult.GetRequiredValue(VectorFieldName);
            var schema = parseResult.GetRequiredValue(Schema);
            var indexParams = parseResult.GetRequiredValue(IndexParams);
            var @params = parseResult.GetRequiredValue(Params);

            Validate(
                parseResult: parseResult,
                requestTimeout: requestTimeout,
                authorization: authorization,
                dbName: dbName,
                collectionName: collectionName,
                dimension: dimension,
                metricType: metricType,
                idType: idType,
                autoID: autoID,
                primaryFieldName: primaryFieldName,
                vectorFieldName: vectorFieldName,
                schema: schema,
                indexParams: indexParams,
                @params: @params,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.CollectionOperationsV2.CreateVectordbCollectionsCreateAsync(
                requestTimeout: requestTimeout,
                authorization: authorization,
                dbName: dbName,
                collectionName: collectionName,
                dimension: dimension,
                metricType: metricType,
                idType: idType,
                autoID: autoID,
                primaryFieldName: primaryFieldName,
                vectorFieldName: vectorFieldName,
                schema: schema,
                indexParams: indexParams,
                @params: @params,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}