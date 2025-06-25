//HintName: G.Commands.RemoveChannelModeratorCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class RemoveChannelModeratorCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string broadcasterId,
            string userId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> BroadcasterId { get; } = new(
            name: "broadcasterId")
        {
            Description = @"The ID of the broadcaster that owns the chat room. This ID must match the user ID in the access token.",
        };

        private global::System.CommandLine.Argument<string> UserId { get; } = new(
            name: "userId")
        {
            Description = @"The ID of the user to remove as a moderator from the broadcaster’s chat room.",
        };

        public RemoveChannelModeratorCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "remove",
            description: @"Removes a moderator from the broadcaster’s chat room.

**Rate Limits**: The broadcaster may remove a maximum of 10 moderators within a 10-second window.

__Authorization:__

Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **channel:manage:moderators** scope.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(BroadcasterId);
            Arguments.Add(UserId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var broadcasterId = parseResult.GetRequiredValue(BroadcasterId);
            var userId = parseResult.GetRequiredValue(UserId);

            Validate(
                parseResult: parseResult,
                broadcasterId: broadcasterId,
                userId: userId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Moderation.RemoveChannelModeratorAsync(
                broadcasterId: broadcasterId,
                userId: userId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}