//HintName: G.Commands.SearchQueryPointsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SearchQueryPointsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string collectionName,
            global::G.ReadConsistency? consistency,
            int? timeout,
            global::G.ShardKeySelector? shardKey,
            global::G.AnyOf<global::G.Prefetch2, global::System.Collections.Generic.IList<global::G.Prefetch2>, object>? prefetch,
            global::G.QueryInterface? query,
            string? @using,
            global::G.Filter? filter,
            global::G.SearchParams? @params,
            float? scoreThreshold,
            int? limit,
            int? offset,
            global::G.WithVector? withVector,
            global::G.WithPayloadInterface? withPayload,
            global::G.LookupLocation? lookupFrom,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.QueryPointsResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> CollectionName { get; } = new(
            name: "collectionName")
        {
            Description = @"Name of the collection to query",
        };

        private global::System.CommandLine.Option<global::G.ReadConsistency?> Consistency { get; } = new(
            name: "consistency")
        {
            Description = @"Define read consistency guarantees for the operation",
        };

        private global::System.CommandLine.Option<int?> Timeout { get; } = new(
            name: "timeout")
        {
            Description = @"If set, overrides global timeout for this request. Unit is seconds.",
        };

        private global::System.CommandLine.Option<global::G.ShardKeySelector?> ShardKey { get; } = new(
            name: "shardKey")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.AnyOf<global::G.Prefetch2, global::System.Collections.Generic.IList<global::G.Prefetch2>, object>?> Prefetch { get; } = new(
            name: "prefetch")
        {
            Description = @"Sub-requests to perform first. If present, the query will be performed on the results of the prefetch(es).",
        };

        private global::System.CommandLine.Option<global::G.QueryInterface?> Query { get; } = new(
            name: "query")
        {
            Description = @"Query to perform. If missing without prefetches, returns points ordered by their IDs.",
        };

        private global::System.CommandLine.Option<string?> Using { get; } = new(
            name: "@using")
        {
            Description = @"Define which vector name to use for querying. If missing, the default vector is used.",
        };

        private global::System.CommandLine.Option<global::G.Filter?> Filter { get; } = new(
            name: "filter")
        {
            Description = @"Filter conditions - return only those points that satisfy the specified conditions.",
        };

        private global::System.CommandLine.Option<global::G.SearchParams?> Params { get; } = new(
            name: "@params")
        {
            Description = @"Search params for when there is no prefetch",
        };

        private global::System.CommandLine.Option<float?> ScoreThreshold { get; } = new(
            name: "scoreThreshold")
        {
            Description = @"Return points with scores better than this threshold.",
        };

        private global::System.CommandLine.Option<int?> Limit { get; } = new(
            name: "limit")
        {
            Description = @"Max number of points to return. Default is 10.",
        };

        private global::System.CommandLine.Option<int?> Offset { get; } = new(
            name: "offset")
        {
            Description = @"Offset of the result. Skip this many points. Default is 0",
        };

        private global::System.CommandLine.Option<global::G.WithVector?> WithVector { get; } = new(
            name: "withVector")
        {
            Description = @"Options for specifying which vectors to include into the response. Default is false.",
        };

        private global::System.CommandLine.Option<global::G.WithPayloadInterface?> WithPayload { get; } = new(
            name: "withPayload")
        {
            Description = @"Options for specifying which payload to include or not. Default is false.",
        };

        private global::System.CommandLine.Option<global::G.LookupLocation?> LookupFrom { get; } = new(
            name: "lookupFrom")
        {
            Description = @"The location to use for IDs lookup, if not specified - use the current collection and the 'using' vector Note: the other collection vectors should have the same vector size as the 'using' vector in the current collection",
        };


        public SearchQueryPointsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "query",
            description: @"Universally query points. This endpoint covers all capabilities of search, recommend, discover, filters. But also enables hybrid and multi-stage queries.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(CollectionName);
            Options.Add(Consistency);
            Options.Add(Timeout);
            Options.Add(ShardKey);
            Options.Add(Prefetch);
            Options.Add(Query);
            Options.Add(Using);
            Options.Add(Filter);
            Options.Add(Params);
            Options.Add(ScoreThreshold);
            Options.Add(Limit);
            Options.Add(Offset);
            Options.Add(WithVector);
            Options.Add(WithPayload);
            Options.Add(LookupFrom);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var collectionName = parseResult.GetRequiredValue(CollectionName);
            var consistency = parseResult.GetRequiredValue(Consistency);
            var timeout = parseResult.GetRequiredValue(Timeout);
            var shardKey = parseResult.GetRequiredValue(ShardKey);
            var prefetch = parseResult.GetRequiredValue(Prefetch);
            var query = parseResult.GetRequiredValue(Query);
            var @using = parseResult.GetRequiredValue(Using);
            var filter = parseResult.GetRequiredValue(Filter);
            var @params = parseResult.GetRequiredValue(Params);
            var scoreThreshold = parseResult.GetRequiredValue(ScoreThreshold);
            var limit = parseResult.GetRequiredValue(Limit);
            var offset = parseResult.GetRequiredValue(Offset);
            var withVector = parseResult.GetRequiredValue(WithVector);
            var withPayload = parseResult.GetRequiredValue(WithPayload);
            var lookupFrom = parseResult.GetRequiredValue(LookupFrom);

            Validate(
                parseResult: parseResult,
                collectionName: collectionName,
                consistency: consistency,
                timeout: timeout,
                shardKey: shardKey,
                prefetch: prefetch,
                query: query,
                @using: @using,
                filter: filter,
                @params: @params,
                scoreThreshold: scoreThreshold,
                limit: limit,
                offset: offset,
                withVector: withVector,
                withPayload: withPayload,
                lookupFrom: lookupFrom,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Search.QueryPointsAsync(
                collectionName: collectionName,
                consistency: consistency,
                timeout: timeout,
                shardKey: shardKey,
                prefetch: prefetch,
                query: query,
                @using: @using,
                filter: filter,
                @params: @params,
                scoreThreshold: scoreThreshold,
                limit: limit,
                offset: offset,
                withVector: withVector,
                withPayload: withPayload,
                lookupFrom: lookupFrom,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}