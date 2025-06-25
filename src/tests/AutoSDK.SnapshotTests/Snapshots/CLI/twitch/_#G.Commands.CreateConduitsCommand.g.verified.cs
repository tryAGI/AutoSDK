//HintName: G.Commands.CreateConduitsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateConduitsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            int shardCount,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.CreateConduitsResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<int> ShardCount { get; } = new(
            name: "shardCount")
        {
            Description = @"The number of shards to create for this conduit.",
        };

        public CreateConduitsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"NEW Creates a new [conduit](https://dev.twitch.tv/docs/eventsub/handling-conduit-events).

__Authorization:__

Requires an [app access token](https://dev.twitch.tv/docs/authentication#app-access-tokens).")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(ShardCount);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var shardCount = parseResult.GetRequiredValue(ShardCount);

            Validate(
                parseResult: parseResult,
                shardCount: shardCount,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Conduits.CreateConduitsAsync(
                shardCount: shardCount,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}