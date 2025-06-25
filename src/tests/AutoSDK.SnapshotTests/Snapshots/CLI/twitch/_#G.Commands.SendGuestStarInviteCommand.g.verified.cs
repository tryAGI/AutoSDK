//HintName: G.Commands.SendGuestStarInviteCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SendGuestStarInviteCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string broadcasterId,
            string moderatorId,
            string sessionId,
            string guestId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> BroadcasterId { get; } = new(
            name: "broadcasterId")
        {
            Description = @"The ID of the broadcaster running the Guest Star session.",
        };

        private global::System.CommandLine.Argument<string> ModeratorId { get; } = new(
            name: "moderatorId")
        {
            Description = @"The ID of the broadcaster or a user that has permission to moderate the broadcaster’s chat room. This ID must match the `user_id` in the user access token.",
        };

        private global::System.CommandLine.Argument<string> SessionId { get; } = new(
            name: "sessionId")
        {
            Description = @"The session ID for the invite to be sent on behalf of the broadcaster.",
        };

        private global::System.CommandLine.Argument<string> GuestId { get; } = new(
            name: "guestId")
        {
            Description = @"Twitch User ID for the guest to invite to the Guest Star session.",
        };

        public SendGuestStarInviteCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "send",
            description: @"BETA Sends an invite to a specified guest on behalf of the broadcaster for a Guest Star session in progress.

__Authorization:__

* Query parameter `moderator_id` must match the `user_id` in the [User-Access token](https://dev.twitch.tv/docs/authentication#user-access-tokens)
* Requires OAuth Scope: `channel:manage:guest_star` or `moderator:manage:guest_star`")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(BroadcasterId);
            Arguments.Add(ModeratorId);
            Arguments.Add(SessionId);
            Arguments.Add(GuestId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var broadcasterId = parseResult.GetRequiredValue(BroadcasterId);
            var moderatorId = parseResult.GetRequiredValue(ModeratorId);
            var sessionId = parseResult.GetRequiredValue(SessionId);
            var guestId = parseResult.GetRequiredValue(GuestId);

            Validate(
                parseResult: parseResult,
                broadcasterId: broadcasterId,
                moderatorId: moderatorId,
                sessionId: sessionId,
                guestId: guestId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.GuestStar.SendGuestStarInviteAsync(
                broadcasterId: broadcasterId,
                moderatorId: moderatorId,
                sessionId: sessionId,
                guestId: guestId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}