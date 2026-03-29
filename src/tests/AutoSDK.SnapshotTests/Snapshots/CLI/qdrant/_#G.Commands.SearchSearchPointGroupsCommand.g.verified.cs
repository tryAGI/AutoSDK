//HintName: G.Commands.SearchSearchPointGroupsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SearchSearchPointGroupsCommand : global::System.CommandLine.Command
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
            global::G.NamedVectorStruct vector,
            global::G.Filter? filter,
            global::G.SearchParams? @params,
            global::G.WithPayloadInterface? withPayload,
            global::G.WithVector? withVector,
            float? scoreThreshold,
            string groupBy,
            int groupSize,
            int limit,
            global::G.WithLookupInterface? withLookup,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.SearchPointGroupsResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> CollectionName { get; } = new(
            name: "collectionName")
        {
            Description = @"Name of the collection to search in",
        };

        private global::System.CommandLine.Argument<global::G.NamedVectorStruct> Vector { get; } = new(
            name: "vector")
        {
            Description = @"Vector data separator for named and unnamed modes Unnamed mode:

{ ""vector"": [1.0, 2.0, 3.0] }

or named mode:

{ ""vector"": { ""vector"": [1.0, 2.0, 3.0], ""name"": ""image-embeddings"" } }",
        };

        private global::System.CommandLine.Argument<string> GroupBy { get; } = new(
            name: "groupBy")
        {
            Description = @"Payload field to group by, must be a string or number field. If the field contains more than 1 value, all values will be used for grouping. One point can be in multiple groups.",
        };

        private global::System.CommandLine.Argument<int> GroupSize { get; } = new(
            name: "groupSize")
        {
            Description = @"Maximum amount of points to return per group",
        };

        private global::System.CommandLine.Argument<int> Limit { get; } = new(
            name: "limit")
        {
            Description = @"Maximum amount of groups to return",
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
            Description = @"Specify in which shards to look for the points, if not specified - look in all shards",
        };

        private global::System.CommandLine.Option<global::G.Filter?> Filter { get; } = new(
            name: "filter")
        {
            Description = @"Look only for points which satisfies this conditions",
        };

        private global::System.CommandLine.Option<global::G.SearchParams?> Params { get; } = new(
            name: "@params")
        {
            Description = @"Additional search params",
        };

        private global::System.CommandLine.Option<global::G.WithPayloadInterface?> WithPayload { get; } = new(
            name: "withPayload")
        {
            Description = @"Select which payload to return with the response. Default is false.",
        };

        private global::System.CommandLine.Option<global::G.WithVector?> WithVector { get; } = new(
            name: "withVector")
        {
            Description = @"Options for specifying which vectors to include into response. Default is false.",
        };

        private global::System.CommandLine.Option<float?> ScoreThreshold { get; } = new(
            name: "scoreThreshold")
        {
            Description = @"Define a minimal score threshold for the result. If defined, less similar results will not be returned. Score of the returned result might be higher or smaller than the threshold depending on the Distance function used. E.g. for cosine similarity only higher scores will be returned.",
        };

        private global::System.CommandLine.Option<global::G.WithLookupInterface?> WithLookup { get; } = new(
            name: "withLookup")
        {
            Description = @"Look for points in another collection using the group ids",
        };


        public SearchSearchPointGroupsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "search",
            description: @"Retrieve closest points based on vector similarity and given filtering conditions, grouped by a given payload field")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(CollectionName);
            Arguments.Add(Vector);
            Arguments.Add(GroupBy);
            Arguments.Add(GroupSize);
            Arguments.Add(Limit);
            Options.Add(Consistency);
            Options.Add(Timeout);
            Options.Add(ShardKey);
            Options.Add(Filter);
            Options.Add(Params);
            Options.Add(WithPayload);
            Options.Add(WithVector);
            Options.Add(ScoreThreshold);
            Options.Add(WithLookup);

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
            var vector = parseResult.GetRequiredValue(Vector);
            var filter = parseResult.GetRequiredValue(Filter);
            var @params = parseResult.GetRequiredValue(Params);
            var withPayload = parseResult.GetRequiredValue(WithPayload);
            var withVector = parseResult.GetRequiredValue(WithVector);
            var scoreThreshold = parseResult.GetRequiredValue(ScoreThreshold);
            var groupBy = parseResult.GetRequiredValue(GroupBy);
            var groupSize = parseResult.GetRequiredValue(GroupSize);
            var limit = parseResult.GetRequiredValue(Limit);
            var withLookup = parseResult.GetRequiredValue(WithLookup);

            Validate(
                parseResult: parseResult,
                collectionName: collectionName,
                consistency: consistency,
                timeout: timeout,
                shardKey: shardKey,
                vector: vector,
                filter: filter,
                @params: @params,
                withPayload: withPayload,
                withVector: withVector,
                scoreThreshold: scoreThreshold,
                groupBy: groupBy,
                groupSize: groupSize,
                limit: limit,
                withLookup: withLookup,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Search.SearchPointGroupsAsync(
                collectionName: collectionName,
                consistency: consistency,
                timeout: timeout,
                shardKey: shardKey,
                vector: vector,
                filter: filter,
                @params: @params,
                withPayload: withPayload,
                withVector: withVector,
                scoreThreshold: scoreThreshold,
                groupBy: groupBy,
                groupSize: groupSize,
                limit: limit,
                withLookup: withLookup,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}