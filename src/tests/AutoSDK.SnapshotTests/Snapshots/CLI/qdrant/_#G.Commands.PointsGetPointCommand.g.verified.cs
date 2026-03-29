//HintName: G.Commands.PointsGetPointCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class PointsGetPointCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string collectionName,
            global::G.ExtendedPointId id,
            global::G.ReadConsistency? consistency,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.GetPointResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> CollectionName { get; } = new(
            name: "collectionName")
        {
            Description = @"Name of the collection to retrieve from",
        };

        private global::System.CommandLine.Argument<global::G.ExtendedPointId> Id { get; } = new(
            name: "id")
        {
            Description = @"Id of the point",
        };

        private global::System.CommandLine.Option<global::G.ReadConsistency?> Consistency { get; } = new(
            name: "consistency")
        {
            Description = @"Define read consistency guarantees for the operation",
        };


        public PointsGetPointCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "get",
            description: @"Retrieve full information of single point by id")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(CollectionName);
            Arguments.Add(Id);
            Options.Add(Consistency);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var collectionName = parseResult.GetRequiredValue(CollectionName);
            var id = parseResult.GetRequiredValue(Id);
            var consistency = parseResult.GetRequiredValue(Consistency);

            Validate(
                parseResult: parseResult,
                collectionName: collectionName,
                id: id,
                consistency: consistency,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Points.GetPointAsync(
                collectionName: collectionName,
                id: id,
                consistency: consistency,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}