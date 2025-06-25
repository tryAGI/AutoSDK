﻿//HintName: G.Models.UpdateChatSettingsBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateChatSettingsBody
    {
        /// <summary>
        /// A Boolean value that determines whether chat messages must contain only emotes.  <br/>
        ///   <br/>
        /// Set to **true** if only emotes are allowed; otherwise, **false**. The default is **false**.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emote_mode")]
        public bool? EmoteMode { get; set; }

        /// <summary>
        /// A Boolean value that determines whether the broadcaster restricts the chat room to followers only.  <br/>
        ///   <br/>
        /// Set to **true** if the broadcaster restricts the chat room to followers only; otherwise, **false**. The default is **true**.  <br/>
        ///   <br/>
        /// To specify how long users must follow the broadcaster before being able to participate in the chat room, see the `follower_mode_duration` field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("follower_mode")]
        public bool? FollowerMode { get; set; }

        /// <summary>
        /// The length of time, in minutes, that users must follow the broadcaster before being able to participate in the chat room. Set only if `follower_mode` is **true**. Possible values are: 0 (no restriction) through 129600 (3 months). The default is 0.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("follower_mode_duration")]
        public int? FollowerModeDuration { get; set; }

        /// <summary>
        /// A Boolean value that determines whether the broadcaster adds a short delay before chat messages appear in the chat room. This gives chat moderators and bots a chance to remove them before viewers can see the message.  <br/>
        ///   <br/>
        /// Set to **true** if the broadcaster applies a delay; otherwise, **false**. The default is **false**.  <br/>
        ///   <br/>
        /// To specify the length of the delay, see the `non_moderator_chat_delay_duration` field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("non_moderator_chat_delay")]
        public bool? NonModeratorChatDelay { get; set; }

        /// <summary>
        /// The amount of time, in seconds, that messages are delayed before appearing in chat. Set only if `non_moderator_chat_delay` is **true**. Possible values are:  <br/>
        ///   <br/>
        /// * 2 — 2 second delay (recommended)<br/>
        /// * 4 — 4 second delay<br/>
        /// * 6 — 6 second delay
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("non_moderator_chat_delay_duration")]
        public int? NonModeratorChatDelayDuration { get; set; }

        /// <summary>
        /// A Boolean value that determines whether the broadcaster limits how often users in the chat room are allowed to send messages. Set to **true** if the broadcaster applies a wait period between messages; otherwise, **false**. The default is **false**.  <br/>
        ///   <br/>
        /// To specify the delay, see the `slow_mode_wait_time` field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slow_mode")]
        public bool? SlowMode { get; set; }

        /// <summary>
        /// The amount of time, in seconds, that users must wait between sending messages. Set only if `slow_mode` is **true**.  <br/>
        ///   <br/>
        /// Possible values are: 3 (3 second delay) through 120 (2 minute delay). The default is 30 seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slow_mode_wait_time")]
        public int? SlowModeWaitTime { get; set; }

        /// <summary>
        /// A Boolean value that determines whether only users that subscribe to the broadcaster’s channel may talk in the chat room.  <br/>
        ///   <br/>
        /// Set to **true** if the broadcaster restricts the chat room to subscribers only; otherwise, **false**. The default is **false**.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscriber_mode")]
        public bool? SubscriberMode { get; set; }

        /// <summary>
        /// A Boolean value that determines whether the broadcaster requires users to post only unique messages in the chat room.  <br/>
        ///   <br/>
        /// Set to **true** if the broadcaster allows only unique messages; otherwise, **false**. The default is **false**.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unique_chat_mode")]
        public bool? UniqueChatMode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateChatSettingsBody" /> class.
        /// </summary>
        /// <param name="emoteMode">
        /// A Boolean value that determines whether chat messages must contain only emotes.  <br/>
        ///   <br/>
        /// Set to **true** if only emotes are allowed; otherwise, **false**. The default is **false**.
        /// </param>
        /// <param name="followerMode">
        /// A Boolean value that determines whether the broadcaster restricts the chat room to followers only.  <br/>
        ///   <br/>
        /// Set to **true** if the broadcaster restricts the chat room to followers only; otherwise, **false**. The default is **true**.  <br/>
        ///   <br/>
        /// To specify how long users must follow the broadcaster before being able to participate in the chat room, see the `follower_mode_duration` field.
        /// </param>
        /// <param name="followerModeDuration">
        /// The length of time, in minutes, that users must follow the broadcaster before being able to participate in the chat room. Set only if `follower_mode` is **true**. Possible values are: 0 (no restriction) through 129600 (3 months). The default is 0.
        /// </param>
        /// <param name="nonModeratorChatDelay">
        /// A Boolean value that determines whether the broadcaster adds a short delay before chat messages appear in the chat room. This gives chat moderators and bots a chance to remove them before viewers can see the message.  <br/>
        ///   <br/>
        /// Set to **true** if the broadcaster applies a delay; otherwise, **false**. The default is **false**.  <br/>
        ///   <br/>
        /// To specify the length of the delay, see the `non_moderator_chat_delay_duration` field.
        /// </param>
        /// <param name="nonModeratorChatDelayDuration">
        /// The amount of time, in seconds, that messages are delayed before appearing in chat. Set only if `non_moderator_chat_delay` is **true**. Possible values are:  <br/>
        ///   <br/>
        /// * 2 — 2 second delay (recommended)<br/>
        /// * 4 — 4 second delay<br/>
        /// * 6 — 6 second delay
        /// </param>
        /// <param name="slowMode">
        /// A Boolean value that determines whether the broadcaster limits how often users in the chat room are allowed to send messages. Set to **true** if the broadcaster applies a wait period between messages; otherwise, **false**. The default is **false**.  <br/>
        ///   <br/>
        /// To specify the delay, see the `slow_mode_wait_time` field.
        /// </param>
        /// <param name="slowModeWaitTime">
        /// The amount of time, in seconds, that users must wait between sending messages. Set only if `slow_mode` is **true**.  <br/>
        ///   <br/>
        /// Possible values are: 3 (3 second delay) through 120 (2 minute delay). The default is 30 seconds.
        /// </param>
        /// <param name="subscriberMode">
        /// A Boolean value that determines whether only users that subscribe to the broadcaster’s channel may talk in the chat room.  <br/>
        ///   <br/>
        /// Set to **true** if the broadcaster restricts the chat room to subscribers only; otherwise, **false**. The default is **false**.
        /// </param>
        /// <param name="uniqueChatMode">
        /// A Boolean value that determines whether the broadcaster requires users to post only unique messages in the chat room.  <br/>
        ///   <br/>
        /// Set to **true** if the broadcaster allows only unique messages; otherwise, **false**. The default is **false**.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateChatSettingsBody(
            bool? emoteMode,
            bool? followerMode,
            int? followerModeDuration,
            bool? nonModeratorChatDelay,
            int? nonModeratorChatDelayDuration,
            bool? slowMode,
            int? slowModeWaitTime,
            bool? subscriberMode,
            bool? uniqueChatMode)
        {
            this.EmoteMode = emoteMode;
            this.FollowerMode = followerMode;
            this.FollowerModeDuration = followerModeDuration;
            this.NonModeratorChatDelay = nonModeratorChatDelay;
            this.NonModeratorChatDelayDuration = nonModeratorChatDelayDuration;
            this.SlowMode = slowMode;
            this.SlowModeWaitTime = slowModeWaitTime;
            this.SubscriberMode = subscriberMode;
            this.UniqueChatMode = uniqueChatMode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateChatSettingsBody" /> class.
        /// </summary>
        public UpdateChatSettingsBody()
        {
        }
    }
}