//HintName: G.Commands.UpdateChatSettingsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class UpdateChatSettingsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

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
            Description = @"The ID of the broadcaster whose chat settings you want to update.",
        };

        private global::System.CommandLine.Argument<string> ModeratorId { get; } = new(
            name: "moderatorId")
        {
            Description = @"The ID of a user that has permission to moderate the broadcaster’s chat room, or the broadcaster’s ID if they’re making the update. This ID must match the user ID in the user access token.",
        };

        private global::System.CommandLine.Option<bool?> EmoteMode { get; } = new(
            name: "emoteMode")
        {
            Description = @"A Boolean value that determines whether chat messages must contain only emotes.  
Set to **true** if only emotes are allowed; otherwise, **false**. The default is **false**.",
        };

        private global::System.CommandLine.Option<bool?> FollowerMode { get; } = new(
            name: "followerMode")
        {
            Description = @"A Boolean value that determines whether the broadcaster restricts the chat room to followers only.  
Set to **true** if the broadcaster restricts the chat room to followers only; otherwise, **false**. The default is **true**.  
To specify how long users must follow the broadcaster before being able to participate in the chat room, see the `follower_mode_duration` field.",
        };

        private global::System.CommandLine.Option<int?> FollowerModeDuration { get; } = new(
            name: "followerModeDuration")
        {
            Description = @"The length of time, in minutes, that users must follow the broadcaster before being able to participate in the chat room. Set only if `follower_mode` is **true**. Possible values are: 0 (no restriction) through 129600 (3 months). The default is 0.",
        };

        private global::System.CommandLine.Option<bool?> NonModeratorChatDelay { get; } = new(
            name: "nonModeratorChatDelay")
        {
            Description = @"A Boolean value that determines whether the broadcaster adds a short delay before chat messages appear in the chat room. This gives chat moderators and bots a chance to remove them before viewers can see the message.  
Set to **true** if the broadcaster applies a delay; otherwise, **false**. The default is **false**.  
To specify the length of the delay, see the `non_moderator_chat_delay_duration` field.",
        };

        private global::System.CommandLine.Option<int?> NonModeratorChatDelayDuration { get; } = new(
            name: "nonModeratorChatDelayDuration")
        {
            Description = @"The amount of time, in seconds, that messages are delayed before appearing in chat. Set only if `non_moderator_chat_delay` is **true**. Possible values are:  
* 2 — 2 second delay (recommended)
* 4 — 4 second delay
* 6 — 6 second delay",
        };

        private global::System.CommandLine.Option<bool?> SlowMode { get; } = new(
            name: "slowMode")
        {
            Description = @"A Boolean value that determines whether the broadcaster limits how often users in the chat room are allowed to send messages. Set to **true** if the broadcaster applies a wait period between messages; otherwise, **false**. The default is **false**.  
To specify the delay, see the `slow_mode_wait_time` field.",
        };

        private global::System.CommandLine.Option<int?> SlowModeWaitTime { get; } = new(
            name: "slowModeWaitTime")
        {
            Description = @"The amount of time, in seconds, that users must wait between sending messages. Set only if `slow_mode` is **true**.  
Possible values are: 3 (3 second delay) through 120 (2 minute delay). The default is 30 seconds.",
        };

        private global::System.CommandLine.Option<bool?> SubscriberMode { get; } = new(
            name: "subscriberMode")
        {
            Description = @"A Boolean value that determines whether only users that subscribe to the broadcaster’s channel may talk in the chat room.  
Set to **true** if the broadcaster restricts the chat room to subscribers only; otherwise, **false**. The default is **false**.",
        };

        private global::System.CommandLine.Option<bool?> UniqueChatMode { get; } = new(
            name: "uniqueChatMode")
        {
            Description = @"A Boolean value that determines whether the broadcaster requires users to post only unique messages in the chat room.  
Set to **true** if the broadcaster allows only unique messages; otherwise, **false**. The default is **false**.",
        };
        public UpdateChatSettingsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
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
            _serviceProvider = serviceProvider;

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