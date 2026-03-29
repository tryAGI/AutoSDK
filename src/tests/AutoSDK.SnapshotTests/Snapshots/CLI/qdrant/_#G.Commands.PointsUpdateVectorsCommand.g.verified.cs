//HintName: G.Commands.PointsUpdateVectorsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class PointsUpdateVectorsCommand : global::System.CommandLine.Command
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
            global::System.Collections.Generic.IList<global::G.PointVectors> points,
            global::G.ShardKeySelector? shardKey,
            global::G.Filter? updateFilter,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.UpdateVectorsResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> CollectionName { get; } = new(
            name: "collectionName")
        {
            Description = @"Name of the collection to update from",
        };

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<global::G.PointVectors>> Points { get; } = new(
            name: "points")
        {
            Description = @"Points with named vectors",
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

        private global::System.CommandLine.Option<global::G.ShardKeySelector?> ShardKey { get; } = new(
            name: "shardKey")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.Filter?> UpdateFilter { get; } = new(
            name: "updateFilter")
        {
            Description = @"",
        };


        public PointsUpdateVectorsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "update",
            description: @"Update specified named vectors on points, keep unspecified vectors intact.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(CollectionName);
            Arguments.Add(Points);
            Options.Add(Wait);
            Options.Add(Ordering);
            Options.Add(Timeout);
            Options.Add(ShardKey);
            Options.Add(UpdateFilter);

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
            var shardKey = parseResult.GetRequiredValue(ShardKey);
            var updateFilter = parseResult.GetRequiredValue(UpdateFilter);

            Validate(
                parseResult: parseResult,
                collectionName: collectionName,
                wait: wait,
                ordering: ordering,
                timeout: timeout,
                points: points,
                shardKey: shardKey,
                updateFilter: updateFilter,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Points.UpdateVectorsAsync(
                collectionName: collectionName,
                wait: wait,
                ordering: ordering,
                timeout: timeout,
                points: points,
                shardKey: shardKey,
                updateFilter: updateFilter,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}