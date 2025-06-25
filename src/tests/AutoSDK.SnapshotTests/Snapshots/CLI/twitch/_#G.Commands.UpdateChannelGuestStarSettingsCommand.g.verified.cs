//HintName: G.Commands.UpdateChannelGuestStarSettingsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class UpdateChannelGuestStarSettingsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

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
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> IsModeratorSendLiveEnabled { get; } = new(
            name: "isModeratorSendLiveEnabled")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> SlotCount { get; } = new(
            name: "slotCount")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> IsBrowserSourceAudioEnabled { get; } = new(
            name: "isBrowserSourceAudioEnabled")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.UpdateChannelGuestStarSettingsBodyGroupLayout?> GroupLayout { get; } = new(
            name: "groupLayout")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> RegenerateBrowserSources { get; } = new(
            name: "regenerateBrowserSources")
        {
            Description = "",
        };
        public UpdateChannelGuestStarSettingsCommand(G.IApi client) : base(
            name: "update",
            description: @"BETA Mutates the channel settings for configuration of the Guest Star feature for a particular host.

__Authorization:__

* Query parameter `broadcaster_id` must match the `user_id` in the [User-Access token](https://dev.twitch.tv/docs/authentication#user-access-tokens)
* Requires OAuth Scope: `channel:manage:guest_star`")
        {
            _client = client;

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