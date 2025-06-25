//HintName: G.Commands.UpdateGuestStarSlotSettingsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class UpdateGuestStarSlotSettingsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string broadcasterId,
            string moderatorId,
            string sessionId,
            string slotId,
            bool? isAudioEnabled,
            bool? isVideoEnabled,
            bool? isLive,
            int? volume,
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
            Description = @"The ID of the broadcaster or a user that has permission to moderate the broadcaster’s chat room. This ID must match the user ID in the user access token.",
        };

        private global::System.CommandLine.Argument<string> SessionId { get; } = new(
            name: "sessionId")
        {
            Description = @"The ID of the Guest Star session in which to update a slot’s settings.",
        };

        private global::System.CommandLine.Argument<string> SlotId { get; } = new(
            name: "slotId")
        {
            Description = @"The slot assignment that has previously been assigned to a user.",
        };

        private global::System.CommandLine.Option<bool?> IsAudioEnabled { get; } = new(
            name: "isAudioEnabled")
        {
            Description = @"Flag indicating whether the slot is allowed to share their audio with the rest of the session. If false, the slot will be muted in any views containing the slot.",
        };

        private global::System.CommandLine.Option<bool?> IsVideoEnabled { get; } = new(
            name: "isVideoEnabled")
        {
            Description = @"Flag indicating whether the slot is allowed to share their video with the rest of the session. If false, the slot will have no video shared in any views containing the slot.",
        };

        private global::System.CommandLine.Option<bool?> IsLive { get; } = new(
            name: "isLive")
        {
            Description = @"Flag indicating whether the user assigned to this slot is visible/can be heard from any public subscriptions. Generally, this determines whether or not the slot is enabled in any broadcasting software integrations.",
        };

        private global::System.CommandLine.Option<int?> Volume { get; } = new(
            name: "volume")
        {
            Description = @"Value from 0-100 that controls the audio volume for shared views containing the slot.",
        };
        public UpdateGuestStarSlotSettingsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "update",
            description: @"BETA Allows a user to update slot settings for a particular guest within a Guest Star session, such as allowing the user to share audio or video within the call as a host. These settings will be broadcasted to all subscribers which control their view of the guest in that slot. One or more of the optional parameters to this API can be specified at any time.

__Authorization:__

* Query parameter `moderator_id` must match the `user_id` in the [User-Access token](https://dev.twitch.tv/docs/authentication#user-access-tokens)
* Requires OAuth Scope: `channel:manage:guest_star` or `moderator:manage:guest_star`")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(BroadcasterId);
            Arguments.Add(ModeratorId);
            Arguments.Add(SessionId);
            Arguments.Add(SlotId);
            Options.Add(IsAudioEnabled);
            Options.Add(IsVideoEnabled);
            Options.Add(IsLive);
            Options.Add(Volume);

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
            var slotId = parseResult.GetRequiredValue(SlotId);
            var isAudioEnabled = parseResult.GetRequiredValue(IsAudioEnabled);
            var isVideoEnabled = parseResult.GetRequiredValue(IsVideoEnabled);
            var isLive = parseResult.GetRequiredValue(IsLive);
            var volume = parseResult.GetRequiredValue(Volume);

            Validate(
                parseResult: parseResult,
                broadcasterId: broadcasterId,
                moderatorId: moderatorId,
                sessionId: sessionId,
                slotId: slotId,
                isAudioEnabled: isAudioEnabled,
                isVideoEnabled: isVideoEnabled,
                isLive: isLive,
                volume: volume,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.GuestStar.UpdateGuestStarSlotSettingsAsync(
                broadcasterId: broadcasterId,
                moderatorId: moderatorId,
                sessionId: sessionId,
                slotId: slotId,
                isAudioEnabled: isAudioEnabled,
                isVideoEnabled: isVideoEnabled,
                isLive: isLive,
                volume: volume,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}