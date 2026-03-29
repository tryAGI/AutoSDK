//HintName: G.Commands.SearchRecommendPointsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SearchRecommendPointsCommand : global::System.CommandLine.Command
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
            global::System.Collections.Generic.IList<global::G.RecommendExample>? positive,
            global::System.Collections.Generic.IList<global::G.RecommendExample>? negative,
            global::G.RecommendStrategy? strategy,
            global::G.Filter? filter,
            global::G.SearchParams? @params,
            int limit,
            int? offset,
            global::G.WithPayloadInterface? withPayload,
            global::G.WithVector? withVector,
            float? scoreThreshold,
            global::G.UsingVector? @using,
            global::G.LookupLocation? lookupFrom,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.RecommendPointsResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> CollectionName { get; } = new(
            name: "collectionName")
        {
            Description = @"Name of the collection to search in",
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

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.RecommendExample>?> Positive { get; } = new(
            name: "positive")
        {
            Description = @"Look for vectors closest to those",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.RecommendExample>?> Negative { get; } = new(
            name: "negative")
        {
            Description = @"Try to avoid vectors like this",
        };

        private global::System.CommandLine.Option<global::G.RecommendStrategy?> Strategy { get; } = new(
            name: "strategy")
        {
            Description = @"How to use positive and negative examples to find the results",
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

        private global::System.CommandLine.Option<global::G.UsingVector?> Using { get; } = new(
            name: "@using")
        {
            Description = @"Define which vector to use for recommendation, if not specified - try to use default vector",
        };

        private global::System.CommandLine.Option<global::G.LookupLocation?> LookupFrom { get; } = new(
            name: "lookupFrom")
        {
            Description = @"The location used to lookup vectors. If not specified - use current collection. Note: the other collection should have the same vector size as the current collection",
        };


        public SearchRecommendPointsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "recommend",
            description: @"Look for the points which are closer to stored positive examples and at the same time further to negative examples.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(CollectionName);
            Arguments.Add(Limit);
            Options.Add(Consistency);
            Options.Add(Timeout);
            Options.Add(ShardKey);
            Options.Add(Positive);
            Options.Add(Negative);
            Options.Add(Strategy);
            Options.Add(Filter);
            Options.Add(Params);
            Options.Add(Offset);
            Options.Add(WithPayload);
            Options.Add(WithVector);
            Options.Add(ScoreThreshold);
            Options.Add(Using);
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
            var positive = parseResult.GetRequiredValue(Positive);
            var negative = parseResult.GetRequiredValue(Negative);
            var strategy = parseResult.GetRequiredValue(Strategy);
            var filter = parseResult.GetRequiredValue(Filter);
            var @params = parseResult.GetRequiredValue(Params);
            var limit = parseResult.GetRequiredValue(Limit);
            var offset = parseResult.GetRequiredValue(Offset);
            var withPayload = parseResult.GetRequiredValue(WithPayload);
            var withVector = parseResult.GetRequiredValue(WithVector);
            var scoreThreshold = parseResult.GetRequiredValue(ScoreThreshold);
            var @using = parseResult.GetRequiredValue(Using);
            var lookupFrom = parseResult.GetRequiredValue(LookupFrom);

            Validate(
                parseResult: parseResult,
                collectionName: collectionName,
                consistency: consistency,
                timeout: timeout,
                shardKey: shardKey,
                positive: positive,
                negative: negative,
                strategy: strategy,
                filter: filter,
                @params: @params,
                limit: limit,
                offset: offset,
                withPayload: withPayload,
                withVector: withVector,
                scoreThreshold: scoreThreshold,
                @using: @using,
                lookupFrom: lookupFrom,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Search.RecommendPointsAsync(
                collectionName: collectionName,
                consistency: consistency,
                timeout: timeout,
                shardKey: shardKey,
                positive: positive,
                negative: negative,
                strategy: strategy,
                filter: filter,
                @params: @params,
                limit: limit,
                offset: offset,
                withPayload: withPayload,
                withVector: withVector,
                scoreThreshold: scoreThreshold,
                @using: @using,
                lookupFrom: lookupFrom,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}