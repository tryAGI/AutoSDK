//HintName: G.Commands.PointsGetPointsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class PointsGetPointsCommand : global::System.CommandLine.Command
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
            global::System.Collections.Generic.IList<global::G.ExtendedPointId> ids,
            global::G.WithPayloadInterface? withPayload,
            global::G.WithVector? withVector,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.GetPointsResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> CollectionName { get; } = new(
            name: "collectionName")
        {
            Description = @"Name of the collection to retrieve from",
        };

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<global::G.ExtendedPointId>> Ids { get; } = new(
            name: "ids")
        {
            Description = @"Look for points with ids",
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


        public PointsGetPointsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "get",
            description: @"Retrieve multiple points by specified IDs")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(CollectionName);
            Arguments.Add(Ids);
            Options.Add(Consistency);
            Options.Add(Timeout);
            Options.Add(ShardKey);
            Options.Add(WithPayload);
            Options.Add(WithVector);

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
            var ids = parseResult.GetRequiredValue(Ids);
            var withPayload = parseResult.GetRequiredValue(WithPayload);
            var withVector = parseResult.GetRequiredValue(WithVector);

            Validate(
                parseResult: parseResult,
                collectionName: collectionName,
                consistency: consistency,
                timeout: timeout,
                shardKey: shardKey,
                ids: ids,
                withPayload: withPayload,
                withVector: withVector,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Points.GetPointsAsync(
                collectionName: collectionName,
                consistency: consistency,
                timeout: timeout,
                shardKey: shardKey,
                ids: ids,
                withPayload: withPayload,
                withVector: withVector,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}