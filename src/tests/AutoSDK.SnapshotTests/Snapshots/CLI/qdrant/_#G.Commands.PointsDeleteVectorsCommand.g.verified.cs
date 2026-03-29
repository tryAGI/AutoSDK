//HintName: G.Commands.PointsDeleteVectorsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class PointsDeleteVectorsCommand : global::System.CommandLine.Command
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
            global::System.Collections.Generic.IList<global::G.ExtendedPointId>? points,
            global::G.Filter? filter,
            global::System.Collections.Generic.IList<string> vector,
            global::G.ShardKeySelector? shardKey,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.DeleteVectorsResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> CollectionName { get; } = new(
            name: "collectionName")
        {
            Description = @"Name of the collection to delete from",
        };

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<string>> Vector { get; } = new(
            name: "vector")
        {
            Description = @"Vector names",
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


        public PointsDeleteVectorsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "delete",
            description: @"Delete named vectors from the given points.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(CollectionName);
            Arguments.Add(Vector);
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
            var points = parseResult.GetRequiredValue(Points);
            var filter = parseResult.GetRequiredValue(Filter);
            var vector = parseResult.GetRequiredValue(Vector);
            var shardKey = parseResult.GetRequiredValue(ShardKey);

            Validate(
                parseResult: parseResult,
                collectionName: collectionName,
                wait: wait,
                ordering: ordering,
                timeout: timeout,
                points: points,
                filter: filter,
                vector: vector,
                shardKey: shardKey,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Points.DeleteVectorsAsync(
                collectionName: collectionName,
                wait: wait,
                ordering: ordering,
                timeout: timeout,
                points: points,
                filter: filter,
                vector: vector,
                shardKey: shardKey,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}