//HintName: G.Commands.CollectionsGetOptimizationsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CollectionsGetOptimizationsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string collectionName,
            string? with,
            int? completedLimit,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.GetOptimizationsResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> CollectionName { get; } = new(
            name: "collectionName")
        {
            Description = @"Name of the collection",
        };

        private global::System.CommandLine.Option<string?> With { get; } = new(
            name: "with")
        {
            Description = @"Comma-separated list of optional fields to include in the response.
Possible values: queued, completed, idle_segments.",
        };

        private global::System.CommandLine.Option<int?> CompletedLimit { get; } = new(
            name: "completedLimit")
        {
            Description = @"Maximum number of completed optimizations to return.
Ignored if `completed` is not in the `with` parameter.",
        };


        public CollectionsGetOptimizationsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "get",
            description: @"Get progress of ongoing and completed optimizations for a collection")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(CollectionName);
            Options.Add(With);
            Options.Add(CompletedLimit);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var collectionName = parseResult.GetRequiredValue(CollectionName);
            var with = parseResult.GetRequiredValue(With);
            var completedLimit = parseResult.GetRequiredValue(CompletedLimit);

            Validate(
                parseResult: parseResult,
                collectionName: collectionName,
                with: with,
                completedLimit: completedLimit,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Collections.GetOptimizationsAsync(
                collectionName: collectionName,
                with: with,
                completedLimit: completedLimit,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}