//HintName: G.Commands.PointsFacetCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class PointsFacetCommand : global::System.CommandLine.Command
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
            string key,
            int? limit,
            global::G.Filter? filter,
            bool? exact,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.FacetResponse2 response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> CollectionName { get; } = new(
            name: "collectionName")
        {
            Description = @"Name of the collection to facet in",
        };

        private global::System.CommandLine.Argument<string> Key { get; } = new(
            name: "key")
        {
            Description = @"Payload key to use for faceting.",
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

        private global::System.CommandLine.Option<int?> Limit { get; } = new(
            name: "limit")
        {
            Description = @"Max number of hits to return. Default is 10.",
        };

        private global::System.CommandLine.Option<global::G.Filter?> Filter { get; } = new(
            name: "filter")
        {
            Description = @"Filter conditions - only consider points that satisfy these conditions.",
        };

        private global::System.CommandLine.Option<bool?> Exact { get; } = new(
            name: "exact")
        {
            Description = @"Whether to do a more expensive exact count for each of the values in the facet. Default is false.",
        };


        public PointsFacetCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "facet",
            description: @"Count points that satisfy the given filter for each unique value of a payload key.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(CollectionName);
            Arguments.Add(Key);
            Options.Add(Consistency);
            Options.Add(Timeout);
            Options.Add(ShardKey);
            Options.Add(Limit);
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
            var key = parseResult.GetRequiredValue(Key);
            var limit = parseResult.GetRequiredValue(Limit);
            var filter = parseResult.GetRequiredValue(Filter);
            var exact = parseResult.GetRequiredValue(Exact);

            Validate(
                parseResult: parseResult,
                collectionName: collectionName,
                consistency: consistency,
                timeout: timeout,
                shardKey: shardKey,
                key: key,
                limit: limit,
                filter: filter,
                exact: exact,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Points.FacetAsync(
                collectionName: collectionName,
                consistency: consistency,
                timeout: timeout,
                shardKey: shardKey,
                key: key,
                limit: limit,
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