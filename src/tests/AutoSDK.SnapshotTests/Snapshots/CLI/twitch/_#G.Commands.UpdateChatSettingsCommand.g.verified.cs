//HintName: G.Commands.UpdateChatSettingsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class UpdateChatSettingsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string broadcasterId,
            string moderatorId,
            bool? emoteMode,
            bool? followerMode,
            int? followerModeDuration,
            bool? nonModeratorChatDelay,
            int? nonModeratorChatDelayDuration,
            bool? slowMode,
            int? slowModeWaitTime,
            bool? subscriberMode,
            bool? uniqueChatMode,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.UpdateChatSettingsResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> BroadcasterId { get; } = new(
            name: "broadcasterId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<string> ModeratorId { get; } = new(
            name: "moderatorId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<bool?> EmoteMode { get; } = new(
            name: "emoteMode")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<bool?> FollowerMode { get; } = new(
            name: "followerMode")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<int?> FollowerModeDuration { get; } = new(
            name: "followerModeDuration")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<bool?> NonModeratorChatDelay { get; } = new(
            name: "nonModeratorChatDelay")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<int?> NonModeratorChatDelayDuration { get; } = new(
            name: "nonModeratorChatDelayDuration")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<bool?> SlowMode { get; } = new(
            name: "slowMode")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<int?> SlowModeWaitTime { get; } = new(
            name: "slowModeWaitTime")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<bool?> SubscriberMode { get; } = new(
            name: "subscriberMode")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<bool?> UniqueChatMode { get; } = new(
            name: "uniqueChatMode")
        {
            Description = @"",
        };
        public UpdateChatSettingsCommand(G.IApi client) : base(
            name: "update",
            description: @"Updates the broadcaster’s chat settings.

__Authorization:__

Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **moderator:manage:chat\_settings** scope.

__Request Body:__

All fields are optional. Specify only those fields that you want to update.

To set the `slow_mode_wait_time` or `follower_mode_duration` field to its default value, set the corresponding `slow_mode` or `follower_mode` field to **true** (and don’t include the `slow_mode_wait_time` or `follower_mode_duration` field).

To set the `slow_mode_wait_time`, `follower_mode_duration`, or `non_moderator_chat_delay_duration` field’s value, you must set the corresponding `slow_mode`, `follower_mode`, or `non_moderator_chat_delay` field to **true**.

To remove the `slow_mode_wait_time`, `follower_mode_duration`, or `non_moderator_chat_delay_duration` field’s value, set the corresponding `slow_mode`, `follower_mode`, or `non_moderator_chat_delay` field to **false** (and don’t include the `slow_mode_wait_time`, `follower_mode_duration`, or `non_moderator_chat_delay_duration` field).")
        {
            _client = client;

            Arguments.Add(BroadcasterId);
            Arguments.Add(ModeratorId);
            Options.Add(EmoteMode);
            Options.Add(FollowerMode);
            Options.Add(FollowerModeDuration);
            Options.Add(NonModeratorChatDelay);
            Options.Add(NonModeratorChatDelayDuration);
            Options.Add(SlowMode);
            Options.Add(SlowModeWaitTime);
            Options.Add(SubscriberMode);
            Options.Add(UniqueChatMode);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var broadcasterId = parseResult.GetRequiredValue(BroadcasterId);
            var moderatorId = parseResult.GetRequiredValue(ModeratorId);
            var emoteMode = parseResult.GetRequiredValue(EmoteMode);
            var followerMode = parseResult.GetRequiredValue(FollowerMode);
            var followerModeDuration = parseResult.GetRequiredValue(FollowerModeDuration);
            var nonModeratorChatDelay = parseResult.GetRequiredValue(NonModeratorChatDelay);
            var nonModeratorChatDelayDuration = parseResult.GetRequiredValue(NonModeratorChatDelayDuration);
            var slowMode = parseResult.GetRequiredValue(SlowMode);
            var slowModeWaitTime = parseResult.GetRequiredValue(SlowModeWaitTime);
            var subscriberMode = parseResult.GetRequiredValue(SubscriberMode);
            var uniqueChatMode = parseResult.GetRequiredValue(UniqueChatMode);

            Validate(
                parseResult: parseResult,
                broadcasterId: broadcasterId,
                moderatorId: moderatorId,
                emoteMode: emoteMode,
                followerMode: followerMode,
                followerModeDuration: followerModeDuration,
                nonModeratorChatDelay: nonModeratorChatDelay,
                nonModeratorChatDelayDuration: nonModeratorChatDelayDuration,
                slowMode: slowMode,
                slowModeWaitTime: slowModeWaitTime,
                subscriberMode: subscriberMode,
                uniqueChatMode: uniqueChatMode,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Chat.UpdateChatSettingsAsync(
                broadcasterId: broadcasterId,
                moderatorId: moderatorId,
                emoteMode: emoteMode,
                followerMode: followerMode,
                followerModeDuration: followerModeDuration,
                nonModeratorChatDelay: nonModeratorChatDelay,
                nonModeratorChatDelayDuration: nonModeratorChatDelayDuration,
                slowMode: slowMode,
                slowModeWaitTime: slowModeWaitTime,
                subscriberMode: subscriberMode,
                uniqueChatMode: uniqueChatMode,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}