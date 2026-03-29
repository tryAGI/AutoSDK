//HintName: G.Commands.PointsDeletePayloadCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class PointsDeletePayloadCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string collectionName,
            bool? wait,
            global::G.WriteOrdering? ordering,
            int? timeout,
            global::System.Collections.Generic.IList<string> keys,
            global::System.Collections.Generic.IList<global::G.ExtendedPointId>? points,
            global::G.Filter? filter,
            global::G.ShardKeySelector? shardKey,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.DeletePayloadResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> CollectionName { get; } = new(
            name: "collectionName")
        {
            Description = @"Name of the collection to delete from",
        };

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<string>> Keys { get; } = new(
            name: "keys")
        {
            Description = @"List of payload keys to remove from payload",
        };

        private global::System.CommandLine.Option<bool?> Wait { get; } = new(
            name: "wait")
        {
            Description = @"If true, wait for changes to actually happen",
        };

        private global::System.CommandLine.Option<global::G.WriteOrdering?> Ordering { get; } = new(
            name: "ordering")
        {
            Description = @"define ordering guarantees for the operation",
        };

        private global::System.CommandLine.Option<int?> Timeout { get; } = new(
            name: "timeout")
        {
            Description = @"Timeout for the operation",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.ExtendedPointId>?> Points { get; } = new(
            name: "points")
        {
            Description = @"Deletes values from each point in this list",
        };

        private global::System.CommandLine.Option<global::G.Filter?> Filter { get; } = new(
            name: "filter")
        {
            Description = @"Deletes values from points that satisfy this filter condition",
        };

        private global::System.CommandLine.Option<global::G.ShardKeySelector?> ShardKey { get; } = new(
            name: "shardKey")
        {
            Description = @"",
        };


        public PointsDeletePayloadCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "delete",
            description: @"Delete specified key payload for points")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(CollectionName);
            Arguments.Add(Keys);
            Options.Add(Wait);
            Options.Add(Ordering);
            Options.Add(Timeout);
            Options.Add(Points);
            Options.Add(Filter);
            Options.Add(ShardKey);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var collectionName = parseResult.GetRequiredValue(CollectionName);
            var wait = parseResult.GetRequiredValue(Wait);
            var ordering = parseResult.GetRequiredValue(Ordering);
            var timeout = parseResult.GetRequiredValue(Timeout);
            var keys = parseResult.GetRequiredValue(Keys);
            var points = parseResult.GetRequiredValue(Points);
            var filter = parseResult.GetRequiredValue(Filter);
            var shardKey = parseResult.GetRequiredValue(ShardKey);

            Validate(
                parseResult: parseResult,
                collectionName: collectionName,
                wait: wait,
                ordering: ordering,
                timeout: timeout,
                keys: keys,
                points: points,
                filter: filter,
                shardKey: shardKey,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Points.DeletePayloadAsync(
                collectionName: collectionName,
                wait: wait,
                ordering: ordering,
                timeout: timeout,
                keys: keys,
                points: points,
                filter: filter,
                shardKey: shardKey,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}