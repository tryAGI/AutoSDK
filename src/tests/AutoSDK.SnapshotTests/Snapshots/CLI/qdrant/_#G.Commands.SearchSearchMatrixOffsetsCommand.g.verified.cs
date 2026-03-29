//HintName: G.Commands.SearchSearchMatrixOffsetsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SearchSearchMatrixOffsetsCommand : global::System.CommandLine.Command
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
            int? sample,
            int? limit,
            string? @using,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.SearchMatrixOffsetsResponse2 response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> CollectionName { get; } = new(
            name: "collectionName")
        {
            Description = @"Name of the collection to search in",
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

        private global::System.CommandLine.Option<int?> Sample { get; } = new(
            name: "sample")
        {
            Description = @"How many points to select and search within. Default is 10.",
        };

        private global::System.CommandLine.Option<int?> Limit { get; } = new(
            name: "limit")
        {
            Description = @"How many neighbours per sample to find. Default is 3.",
        };

        private global::System.CommandLine.Option<string?> Using { get; } = new(
            name: "@using")
        {
            Description = @"Define which vector name to use for querying. If missing, the default vector is used.",
        };


        public SearchSearchMatrixOffsetsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "search",
            description: @"Compute distance matrix for sampled points with an offset based output format")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(CollectionName);
            Options.Add(Consistency);
            Options.Add(Timeout);
            Options.Add(ShardKey);
            Options.Add(Filter);
            Options.Add(Sample);
            Options.Add(Limit);
            Options.Add(Using);

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
            var sample = parseResult.GetRequiredValue(Sample);
            var limit = parseResult.GetRequiredValue(Limit);
            var @using = parseResult.GetRequiredValue(Using);

            Validate(
                parseResult: parseResult,
                collectionName: collectionName,
                consistency: consistency,
                timeout: timeout,
                shardKey: shardKey,
                filter: filter,
                sample: sample,
                limit: limit,
                @using: @using,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Search.SearchMatrixOffsetsAsync(
                collectionName: collectionName,
                consistency: consistency,
                timeout: timeout,
                shardKey: shardKey,
                filter: filter,
                sample: sample,
                limit: limit,
                @using: @using,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}