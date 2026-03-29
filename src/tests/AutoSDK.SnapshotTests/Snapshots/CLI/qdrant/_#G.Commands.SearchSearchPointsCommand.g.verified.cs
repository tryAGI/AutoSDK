//HintName: G.Commands.SearchSearchPointsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SearchSearchPointsCommand : global::System.CommandLine.Command
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
            int limit,
            int? offset,
            global::G.WithPayloadInterface? withPayload,
            global::G.WithVector? withVector,
            float? scoreThreshold,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.SearchPointsResponse response,
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

        private global::System.CommandLine.Argument<int> Limit { get; } = new(
            name: "limit")
        {
            Description = @"Max number of result to return",
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

        private global::System.CommandLine.Option<int?> Offset { get; } = new(
            name: "offset")
        {
            Description = @"Offset of the first result to return. May be used to paginate results. Note: large offset values may cause performance issues.",
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


        public SearchSearchPointsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "search",
            description: @"Retrieve closest points based on vector similarity and given filtering conditions")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(CollectionName);
            Arguments.Add(Vector);
            Arguments.Add(Limit);
            Options.Add(Consistency);
            Options.Add(Timeout);
            Options.Add(ShardKey);
            Options.Add(Filter);
            Options.Add(Params);
            Options.Add(Offset);
            Options.Add(WithPayload);
            Options.Add(WithVector);
            Options.Add(ScoreThreshold);

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
            var limit = parseResult.GetRequiredValue(Limit);
            var offset = parseResult.GetRequiredValue(Offset);
            var withPayload = parseResult.GetRequiredValue(WithPayload);
            var withVector = parseResult.GetRequiredValue(WithVector);
            var scoreThreshold = parseResult.GetRequiredValue(ScoreThreshold);

            Validate(
                parseResult: parseResult,
                collectionName: collectionName,
                consistency: consistency,
                timeout: timeout,
                shardKey: shardKey,
                vector: vector,
                filter: filter,
                @params: @params,
                limit: limit,
                offset: offset,
                withPayload: withPayload,
                withVector: withVector,
                scoreThreshold: scoreThreshold,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Search.SearchPointsAsync(
                collectionName: collectionName,
                consistency: consistency,
                timeout: timeout,
                shardKey: shardKey,
                vector: vector,
                filter: filter,
                @params: @params,
                limit: limit,
                offset: offset,
                withPayload: withPayload,
                withVector: withVector,
                scoreThreshold: scoreThreshold,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}