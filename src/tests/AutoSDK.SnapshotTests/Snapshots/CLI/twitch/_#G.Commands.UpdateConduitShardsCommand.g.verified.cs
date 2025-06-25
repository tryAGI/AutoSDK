//HintName: G.Commands.UpdateConduitShardsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class UpdateConduitShardsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string conduitId,
            global::System.Collections.Generic.IList<global::G.UpdateConduitShardsBodyShard> shards,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.UpdateConduitShardsResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> ConduitId { get; } = new(
            name: "conduitId")
        {
            Description = @"Conduit ID.",
        };

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<global::G.UpdateConduitShardsBodyShard>> Shards { get; } = new(
            name: "shards")
        {
            Description = @"List of shards to update.",
        };

        public UpdateConduitShardsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "update",
            description: @"NEW Updates shard(s) for a [conduit](https://dev.twitch.tv/docs/eventsub/handling-conduit-events).

**NOTE:** Shard IDs are indexed starting at 0, so a conduit with a `shard_count` of 5 will have shards with IDs 0 through 4.

__Authorization:__

Requires an [app access token](https://dev.twitch.tv/docs/authentication#app-access-tokens).")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(ConduitId);
            Arguments.Add(Shards);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var conduitId = parseResult.GetRequiredValue(ConduitId);
            var shards = parseResult.GetRequiredValue(Shards);

            Validate(
                parseResult: parseResult,
                conduitId: conduitId,
                shards: shards,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Conduits.UpdateConduitShardsAsync(
                conduitId: conduitId,
                shards: shards,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}