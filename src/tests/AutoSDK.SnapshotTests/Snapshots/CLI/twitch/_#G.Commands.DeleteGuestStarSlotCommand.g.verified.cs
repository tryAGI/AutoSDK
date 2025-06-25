//HintName: G.Commands.DeleteGuestStarSlotCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DeleteGuestStarSlotCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string broadcasterId,
            string moderatorId,
            string sessionId,
            string guestId,
            string slotId,
            string? shouldReinviteGuest,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> BroadcasterId { get; } = new(
            name: "broadcasterId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> ModeratorId { get; } = new(
            name: "moderatorId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> SessionId { get; } = new(
            name: "sessionId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> GuestId { get; } = new(
            name: "guestId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> SlotId { get; } = new(
            name: "slotId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> ShouldReinviteGuest { get; } = new(
            name: "shouldReinviteGuest")
        {
            Description = "",
        };
        public DeleteGuestStarSlotCommand(G.IApi client) : base(
            name: "delete",
            description: @"BETA Allows a caller to remove a slot assignment from a user participating in an active Guest Star session. This revokes their access to the session immediately and disables their access to publish or subscribe to media within the session.

__Authorization:__

* Query parameter `moderator_id` must match the `user_id` in the [User-Access token](https://dev.twitch.tv/docs/authentication#user-access-tokens)
* Requires OAuth Scope: `channel:manage:guest_star` or `moderator:manage:guest_star`")
        {
            _client = client;

            Arguments.Add(BroadcasterId);
            Arguments.Add(ModeratorId);
            Arguments.Add(SessionId);
            Arguments.Add(GuestId);
            Arguments.Add(SlotId);
            Options.Add(ShouldReinviteGuest);

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
            var slotId = parseResult.GetRequiredValue(SlotId);
            var shouldReinviteGuest = parseResult.GetRequiredValue(ShouldReinviteGuest);

            Validate(
                parseResult: parseResult,
                broadcasterId: broadcasterId,
                moderatorId: moderatorId,
                sessionId: sessionId,
                guestId: guestId,
                slotId: slotId,
                shouldReinviteGuest: shouldReinviteGuest,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.GuestStar.DeleteGuestStarSlotAsync(
                broadcasterId: broadcasterId,
                moderatorId: moderatorId,
                sessionId: sessionId,
                guestId: guestId,
                slotId: slotId,
                shouldReinviteGuest: shouldReinviteGuest,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}