﻿//HintName: G.Models.SendChatMessageBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SendChatMessageBody
    {
        /// <summary>
        /// The ID of the broadcaster whose chat room the message will be sent to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("broadcaster_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BroadcasterId { get; set; }

        /// <summary>
        /// The ID of the user sending the message. This ID must match the user ID in the user access token.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sender_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SenderId { get; set; }

        /// <summary>
        /// The message to send. The message is limited to a maximum of 500 characters. Chat messages can also include emoticons. To include emoticons, use the name of the emote. The names are case sensitive. Don’t include colons around the name (e.g., :bleedPurple:). If Twitch recognizes the name, Twitch converts the name to the emote before writing the chat message to the chat room
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// The ID of the chat message being replied to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reply_parent_message_id")]
        public string? ReplyParentMessageId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SendChatMessageBody" /> class.
        /// </summary>
        /// <param name="broadcasterId">
        /// The ID of the broadcaster whose chat room the message will be sent to.
        /// </param>
        /// <param name="senderId">
        /// The ID of the user sending the message. This ID must match the user ID in the user access token.
        /// </param>
        /// <param name="message">
        /// The message to send. The message is limited to a maximum of 500 characters. Chat messages can also include emoticons. To include emoticons, use the name of the emote. The names are case sensitive. Don’t include colons around the name (e.g., :bleedPurple:). If Twitch recognizes the name, Twitch converts the name to the emote before writing the chat message to the chat room
        /// </param>
        /// <param name="replyParentMessageId">
        /// The ID of the chat message being replied to.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SendChatMessageBody(
            string broadcasterId,
            string senderId,
            string message,
            string? replyParentMessageId)
        {
            this.BroadcasterId = broadcasterId ?? throw new global::System.ArgumentNullException(nameof(broadcasterId));
            this.SenderId = senderId ?? throw new global::System.ArgumentNullException(nameof(senderId));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.ReplyParentMessageId = replyParentMessageId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SendChatMessageBody" /> class.
        /// </summary>
        public SendChatMessageBody()
        {
        }
    }
}