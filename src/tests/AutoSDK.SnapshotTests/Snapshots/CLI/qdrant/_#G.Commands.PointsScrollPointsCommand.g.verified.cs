//HintName: G.Commands.PointsScrollPointsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class PointsScrollPointsCommand : global::System.CommandLine.Command
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
            global::G.ExtendedPointId? offset,
            int? limit,
            global::G.Filter? filter,
            global::G.WithPayloadInterface? withPayload,
            global::G.WithVector? withVector,
            global::G.OrderByInterface? orderBy,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.ScrollPointsResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> CollectionName { get; } = new(
            name: "collectionName")
        {
            Description = @"Name of the collection to retrieve from",
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

        private global::System.CommandLine.Option<global::G.ExtendedPointId?> Offset { get; } = new(
            name: "offset")
        {
            Description = @"Start ID to read points from.",
        };

        private global::System.CommandLine.Option<int?> Limit { get; } = new(
            name: "limit")
        {
            Description = @"Page size. Default: 10",
        };

        private global::System.CommandLine.Option<global::G.Filter?> Filter { get; } = new(
            name: "filter")
        {
            Description = @"Look only for points which satisfies this conditions. If not provided - all points.",
        };

        private global::System.CommandLine.Option<global::G.WithPayloadInterface?> WithPayload { get; } = new(
            name: "withPayload")
        {
            Description = @"Select which payload to return with the response. Default is true.",
        };

        private global::System.CommandLine.Option<global::G.WithVector?> WithVector { get; } = new(
            name: "withVector")
        {
            Description = @"Options for specifying which vector to include",
        };

        private global::System.CommandLine.Option<global::G.OrderByInterface?> OrderBy { get; } = new(
            name: "orderBy")
        {
            Description = @"Order the records by a payload field.",
        };


        public PointsScrollPointsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "scroll",
            description: @"Scroll request - paginate over all points which matches given filtering condition")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(CollectionName);
            Options.Add(Consistency);
            Options.Add(Timeout);
            Options.Add(ShardKey);
            Options.Add(Offset);
            Options.Add(Limit);
            Options.Add(Filter);
            Options.Add(WithPayload);
            Options.Add(WithVector);
            Options.Add(OrderBy);

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
            var offset = parseResult.GetRequiredValue(Offset);
            var limit = parseResult.GetRequiredValue(Limit);
            var filter = parseResult.GetRequiredValue(Filter);
            var withPayload = parseResult.GetRequiredValue(WithPayload);
            var withVector = parseResult.GetRequiredValue(WithVector);
            var orderBy = parseResult.GetRequiredValue(OrderBy);

            Validate(
                parseResult: parseResult,
                collectionName: collectionName,
                consistency: consistency,
                timeout: timeout,
                shardKey: shardKey,
                offset: offset,
                limit: limit,
                filter: filter,
                withPayload: withPayload,
                withVector: withVector,
                orderBy: orderBy,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Points.ScrollPointsAsync(
                collectionName: collectionName,
                consistency: consistency,
                timeout: timeout,
                shardKey: shardKey,
                offset: offset,
                limit: limit,
                filter: filter,
                withPayload: withPayload,
                withVector: withVector,
                orderBy: orderBy,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}