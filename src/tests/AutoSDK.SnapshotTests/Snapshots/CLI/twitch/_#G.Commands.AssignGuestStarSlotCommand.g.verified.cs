//HintName: G.Commands.AssignGuestStarSlotCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AssignGuestStarSlotCommand : global::System.CommandLine.Command
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
            string slotId,
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
            Description = @"The ID of the Guest Star session in which to assign the slot.",
        };

        private global::System.CommandLine.Argument<string> GuestId { get; } = new(
            name: "guestId")
        {
            Description = @"The Twitch User ID corresponding to the guest to assign a slot in the session. This user must already have an invite to this session, and have indicated that they are ready to join.",
        };

        private global::System.CommandLine.Argument<string> SlotId { get; } = new(
            name: "slotId")
        {
            Description = @"The slot assignment to give to the user. Must be a numeric identifier between “1” and “N” where N is the max number of slots for the session. Max number of slots allowed for the session is reported by [Get Channel Guest Star Settings](https://dev.twitch.tv/docs/api/reference#get-channel-guest-star-settings).",
        };

        public AssignGuestStarSlotCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "assign",
            description: @"BETA Allows a previously invited user to be assigned a slot within the active Guest Star session, once that guest has indicated they are ready to join.

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
            Arguments.Add(SlotId);

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

            Validate(
                parseResult: parseResult,
                broadcasterId: broadcasterId,
                moderatorId: moderatorId,
                sessionId: sessionId,
                guestId: guestId,
                slotId: slotId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.GuestStar.AssignGuestStarSlotAsync(
                broadcasterId: broadcasterId,
                moderatorId: moderatorId,
                sessionId: sessionId,
                guestId: guestId,
                slotId: slotId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}