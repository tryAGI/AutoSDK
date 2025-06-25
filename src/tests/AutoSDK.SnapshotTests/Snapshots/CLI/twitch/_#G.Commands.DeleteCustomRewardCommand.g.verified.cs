//HintName: G.Commands.DeleteCustomRewardCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DeleteCustomRewardCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string broadcasterId,
            string id,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> BroadcasterId { get; } = new(
            name: "broadcasterId")
        {
            Description = @"The ID of the broadcaster that created the custom reward. This ID must match the user ID found in the OAuth token.",
        };

        private global::System.CommandLine.Argument<string> Id { get; } = new(
            name: "id")
        {
            Description = @"The ID of the custom reward to delete.",
        };

        public DeleteCustomRewardCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "delete",
            description: @"Deletes a custom reward that the broadcaster created.

The app used to create the reward is the only app that may delete it. If the reward’s redemption status is UNFULFILLED at the time the reward is deleted, its redemption status is marked as FULFILLED.

__Authorization:__

Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **channel:manage:redemptions** scope.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(BroadcasterId);
            Arguments.Add(Id);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var broadcasterId = parseResult.GetRequiredValue(BroadcasterId);
            var id = parseResult.GetRequiredValue(Id);

            Validate(
                parseResult: parseResult,
                broadcasterId: broadcasterId,
                id: id,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.ChannelPoints.DeleteCustomRewardAsync(
                broadcasterId: broadcasterId,
                id: id,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}