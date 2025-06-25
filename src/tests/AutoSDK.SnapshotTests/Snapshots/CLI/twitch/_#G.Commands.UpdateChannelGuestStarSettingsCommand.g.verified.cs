//HintName: G.Commands.UpdateChannelGuestStarSettingsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class UpdateChannelGuestStarSettingsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string broadcasterId,
            bool? isModeratorSendLiveEnabled,
            int? slotCount,
            bool? isBrowserSourceAudioEnabled,
            global::G.UpdateChannelGuestStarSettingsBodyGroupLayout? groupLayout,
            bool? regenerateBrowserSources,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> BroadcasterId { get; } = new(
            name: "broadcasterId")
        {
            Description = @"The ID of the broadcaster you want to update Guest Star settings for.",
        };

        private global::System.CommandLine.Option<bool?> IsModeratorSendLiveEnabled { get; } = new(
            name: "isModeratorSendLiveEnabled")
        {
            Description = @"Flag determining if Guest Star moderators have access to control whether a guest is live once assigned to a slot.",
        };

        private global::System.CommandLine.Option<int?> SlotCount { get; } = new(
            name: "slotCount")
        {
            Description = @"Number of slots the Guest Star call interface will allow the host to add to a call. Required to be between 1 and 6.",
        };

        private global::System.CommandLine.Option<bool?> IsBrowserSourceAudioEnabled { get; } = new(
            name: "isBrowserSourceAudioEnabled")
        {
            Description = @"Flag determining if Browser Sources subscribed to sessions on this channel should output audio",
        };

        private global::System.CommandLine.Option<global::G.UpdateChannelGuestStarSettingsBodyGroupLayout?> GroupLayout { get; } = new(
            name: "groupLayout")
        {
            Description = @"This setting determines how the guests within a session should be laid out within the browser source. Can be one of the following values:   
* `TILED_LAYOUT`: All live guests are tiled within the browser source with the same size.
* `SCREENSHARE_LAYOUT`: All live guests are tiled within the browser source with the same size. If there is an active screen share, it is sized larger than the other guests.
* `HORIZONTAL_LAYOUT`: All live guests are arranged in a horizontal bar within the browser source
* `VERTICAL_LAYOUT`: All live guests are arranged in a vertical bar within the browser source",
        };

        private global::System.CommandLine.Option<bool?> RegenerateBrowserSources { get; } = new(
            name: "regenerateBrowserSources")
        {
            Description = @"Flag determining if Guest Star should regenerate the auth token associated with the channel’s browser sources. Providing a true value for this will immediately invalidate all browser sources previously configured in your streaming software.",
        };
        public UpdateChannelGuestStarSettingsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "update",
            description: @"BETA Mutates the channel settings for configuration of the Guest Star feature for a particular host.

__Authorization:__

* Query parameter `broadcaster_id` must match the `user_id` in the [User-Access token](https://dev.twitch.tv/docs/authentication#user-access-tokens)
* Requires OAuth Scope: `channel:manage:guest_star`")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(BroadcasterId);
            Options.Add(IsModeratorSendLiveEnabled);
            Options.Add(SlotCount);
            Options.Add(IsBrowserSourceAudioEnabled);
            Options.Add(GroupLayout);
            Options.Add(RegenerateBrowserSources);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var broadcasterId = parseResult.GetRequiredValue(BroadcasterId);
            var isModeratorSendLiveEnabled = parseResult.GetRequiredValue(IsModeratorSendLiveEnabled);
            var slotCount = parseResult.GetRequiredValue(SlotCount);
            var isBrowserSourceAudioEnabled = parseResult.GetRequiredValue(IsBrowserSourceAudioEnabled);
            var groupLayout = parseResult.GetRequiredValue(GroupLayout);
            var regenerateBrowserSources = parseResult.GetRequiredValue(RegenerateBrowserSources);

            Validate(
                parseResult: parseResult,
                broadcasterId: broadcasterId,
                isModeratorSendLiveEnabled: isModeratorSendLiveEnabled,
                slotCount: slotCount,
                isBrowserSourceAudioEnabled: isBrowserSourceAudioEnabled,
                groupLayout: groupLayout,
                regenerateBrowserSources: regenerateBrowserSources,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.GuestStar.UpdateChannelGuestStarSettingsAsync(
                broadcasterId: broadcasterId,
                isModeratorSendLiveEnabled: isModeratorSendLiveEnabled,
                slotCount: slotCount,
                isBrowserSourceAudioEnabled: isBrowserSourceAudioEnabled,
                groupLayout: groupLayout,
                regenerateBrowserSources: regenerateBrowserSources,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}