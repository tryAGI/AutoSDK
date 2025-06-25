//HintName: G.Commands.UpdateConduitsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class UpdateConduitsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string id,
            int shardCount,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.UpdateConduitsResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Id { get; } = new(
            name: "id")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<int> ShardCount { get; } = new(
            name: "shardCount")
        {
            Description = "",
        };

        public UpdateConduitsCommand(G.IApi client) : base(
            name: "update",
            description: @"NEW Updates a [conduit’s](https://dev.twitch.tv/docs/eventsub/handling-conduit-events) shard count. To delete shards, update the count to a lower number, and the shards above the count will be deleted. For example, if the existing shard count is 100, by resetting shard count to 50, shards 50-99 are disabled.

__Authorization:__

Requires an [app access token](https://dev.twitch.tv/docs/authentication#app-access-tokens).")
        {
            _client = client;

            Arguments.Add(Id);
            Arguments.Add(ShardCount);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var id = parseResult.GetRequiredValue(Id);
            var shardCount = parseResult.GetRequiredValue(ShardCount);

            Validate(
                parseResult: parseResult,
                id: id,
                shardCount: shardCount,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Conduits.UpdateConduitsAsync(
                id: id,
                shardCount: shardCount,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}