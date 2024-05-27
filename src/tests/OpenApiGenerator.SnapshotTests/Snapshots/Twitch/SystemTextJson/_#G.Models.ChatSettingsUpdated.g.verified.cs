//HintName: G.Models.ChatSettingsUpdated.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatSettingsUpdated
    {
        /// <summary>
        /// The ID of the broadcaster specified in the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("broadcaster_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BroadcasterId { get; set; }

        /// <summary>
        /// A Boolean value that determines whether chat messages must contain only emotes. Is **true** if chat messages may contain only emotes; otherwise, **false**.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emote_mode")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool EmoteMode { get; set; }

        /// <summary>
        /// A Boolean value that determines whether the broadcaster restricts the chat room to followers only.  
        ///   
        /// Is **true** if the broadcaster restricts the chat room to followers only; otherwise, **false**.  
        ///   
        /// See the `follower_mode_duration` field for how long users must follow the broadcaster before being able to participate in the chat room.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("follower_mode")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool FollowerMode { get; set; }

        /// <summary>
        /// The length of time, in minutes, that users must follow the broadcaster before being able to participate in the chat room. Is **null** if `follower_mode` is **false**.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("follower_mode_duration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int? FollowerModeDuration { get; set; }

        /// <summary>
        /// The moderator’s ID. The response includes this field only if the request specifies a user access token that includes the **moderator:read:chat\_settings** scope.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("moderator_id")]
        public string? ModeratorId { get; set; }

        /// <summary>
        /// A Boolean value that determines whether the broadcaster adds a short delay before chat messages appear in the chat room. This gives chat moderators and bots a chance to remove them before viewers can see the message. See the `non_moderator_chat_delay_duration` field for the length of the delay. Is **true** if the broadcaster applies a delay; otherwise, **false**.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("non_moderator_chat_delay")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool NonModeratorChatDelay { get; set; }

        /// <summary>
        /// The amount of time, in seconds, that messages are delayed before appearing in chat. Is **null** if `non_moderator_chat_delay` is **false**.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("non_moderator_chat_delay_duration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int? NonModeratorChatDelayDuration { get; set; }

        /// <summary>
        /// A Boolean value that determines whether the broadcaster limits how often users in the chat room are allowed to send messages.  
        ///   
        /// Is **true** if the broadcaster applies a delay; otherwise, **false**.  
        ///   
        /// See the `slow_mode_wait_time` field for the delay.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slow_mode")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool SlowMode { get; set; }

        /// <summary>
        /// The amount of time, in seconds, that users must wait between sending messages.  
        ///   
        /// Is **null** if slow\_mode is **false**.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slow_mode_wait_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int? SlowModeWaitTime { get; set; }

        /// <summary>
        /// A Boolean value that determines whether only users that subscribe to the broadcaster’s channel may talk in the chat room.  
        ///   
        /// Is **true** if the broadcaster restricts the chat room to subscribers only; otherwise, **false**.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscriber_mode")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool SubscriberMode { get; set; }

        /// <summary>
        /// A Boolean value that determines whether the broadcaster requires users to post only unique messages in the chat room.  
        ///   
        /// Is **true** if the broadcaster requires unique messages only; otherwise, **false**.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unique_chat_mode")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool UniqueChatMode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}