//HintName: G.Commands.PointsCountPointsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class PointsCountPointsCommand : global::System.CommandLine.Command
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
            global::G.Filter? filter,
            bool? exact,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.CountPointsResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> CollectionName { get; } = new(
            name: "collectionName")
        {
            Description = @"Name of the collection to count in",
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

        private global::System.CommandLine.Option<bool?> Exact { get; } = new(
            name: "exact")
        {
            Description = @"If true, count exact number of points. If false, count approximate number of points faster. Approximate count might be unreliable during the indexing process. Default: true",
        };


        public PointsCountPointsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "count",
            description: @"Count points which matches given filtering condition")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(CollectionName);
            Options.Add(Consistency);
            Options.Add(Timeout);
            Options.Add(ShardKey);
            Options.Add(Filter);
            Options.Add(Exact);

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
            var filter = parseResult.GetRequiredValue(Filter);
            var exact = parseResult.GetRequiredValue(Exact);

            Validate(
                parseResult: parseResult,
                collectionName: collectionName,
                consistency: consistency,
                timeout: timeout,
                shardKey: shardKey,
                filter: filter,
                exact: exact,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Points.CountPointsAsync(
                collectionName: collectionName,
                consistency: consistency,
                timeout: timeout,
                shardKey: shardKey,
                filter: filter,
                exact: exact,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}