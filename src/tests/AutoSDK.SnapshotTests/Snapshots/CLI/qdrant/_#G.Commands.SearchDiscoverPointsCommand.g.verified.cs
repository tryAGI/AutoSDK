//HintName: G.Commands.SearchDiscoverPointsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SearchDiscoverPointsCommand : global::System.CommandLine.Command
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
            global::G.RecommendExample? target,
            global::System.Collections.Generic.IList<global::G.ContextExamplePair>? context,
            global::G.Filter? filter,
            global::G.SearchParams? @params,
            int limit,
            int? offset,
            global::G.WithPayloadInterface? withPayload,
            global::G.WithVector? withVector,
            global::G.UsingVector? @using,
            global::G.LookupLocation? lookupFrom,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.DiscoverPointsResponse response,
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

        private global::System.CommandLine.Option<global::G.RecommendExample?> Target { get; } = new(
            name: "target")
        {
            Description = @"Look for vectors closest to this.

When using the target (with or without context), the integer part of the score represents the rank with respect to the context, while the decimal part of the score relates to the distance to the target.",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.ContextExamplePair>?> Context { get; } = new(
            name: "context")
        {
            Description = @"Pairs of { positive, negative } examples to constrain the search.

When using only the context (without a target), a special search - called context search - is performed where pairs of points are used to generate a loss that guides the search towards the zone where most positive examples overlap. This means that the score minimizes the scenario of finding a point closer to a negative than to a positive part of a pair.

Since the score of a context relates to loss, the maximum score a point can get is 0.0, and it becomes normal that many points can have a score of 0.0.

For discovery search (when including a target), the context part of the score for each pair is calculated +1 if the point is closer to a positive than to a negative part of a pair, and -1 otherwise.",
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


        public SearchDiscoverPointsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "discover",
            description: @"Use context and a target to find the most similar points to the target, constrained by the context.
When using only the context (without a target), a special search - called context search - is performed where pairs of points are used to generate a loss that guides the search towards the zone where most positive examples overlap. This means that the score minimizes the scenario of finding a point closer to a negative than to a positive part of a pair.
Since the score of a context relates to loss, the maximum score a point can get is 0.0, and it becomes normal that many points can have a score of 0.0.
When using target (with or without context), the score behaves a little different: The integer part of the score represents the rank with respect to the context, while the decimal part of the score relates to the distance to the target. The context part of the score for each pair is calculated +1 if the point is closer to a positive than to a negative part of a pair, and -1 otherwise.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(CollectionName);
            Arguments.Add(Limit);
            Options.Add(Consistency);
            Options.Add(Timeout);
            Options.Add(ShardKey);
            Options.Add(Target);
            Options.Add(Context);
            Options.Add(Filter);
            Options.Add(Params);
            Options.Add(Offset);
            Options.Add(WithPayload);
            Options.Add(WithVector);
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
            var target = parseResult.GetRequiredValue(Target);
            var context = parseResult.GetRequiredValue(Context);
            var filter = parseResult.GetRequiredValue(Filter);
            var @params = parseResult.GetRequiredValue(Params);
            var limit = parseResult.GetRequiredValue(Limit);
            var offset = parseResult.GetRequiredValue(Offset);
            var withPayload = parseResult.GetRequiredValue(WithPayload);
            var withVector = parseResult.GetRequiredValue(WithVector);
            var @using = parseResult.GetRequiredValue(Using);
            var lookupFrom = parseResult.GetRequiredValue(LookupFrom);

            Validate(
                parseResult: parseResult,
                collectionName: collectionName,
                consistency: consistency,
                timeout: timeout,
                shardKey: shardKey,
                target: target,
                context: context,
                filter: filter,
                @params: @params,
                limit: limit,
                offset: offset,
                withPayload: withPayload,
                withVector: withVector,
                @using: @using,
                lookupFrom: lookupFrom,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Search.DiscoverPointsAsync(
                collectionName: collectionName,
                consistency: consistency,
                timeout: timeout,
                shardKey: shardKey,
                target: target,
                context: context,
                filter: filter,
                @params: @params,
                limit: limit,
                offset: offset,
                withPayload: withPayload,
                withVector: withVector,
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