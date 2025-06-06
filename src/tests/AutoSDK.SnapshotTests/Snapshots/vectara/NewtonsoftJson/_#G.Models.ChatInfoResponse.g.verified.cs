﻿//HintName: G.Models.ChatInfoResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Information about the chat.
    /// </summary>
    public sealed partial class ChatInfoResponse
    {
        /// <summary>
        /// This will be `chat_info` when the stream event contains information<br/>
        /// about how the chat is stored.<br/>
        /// Default Value: chat_info
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// ID of the chat.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chat_id")]
        public string? ChatId { get; set; }

        /// <summary>
        /// ID of the turn.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("turn_id")]
        public string? TurnId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatInfoResponse" /> class.
        /// </summary>
        /// <param name="type">
        /// This will be `chat_info` when the stream event contains information<br/>
        /// about how the chat is stored.<br/>
        /// Default Value: chat_info
        /// </param>
        /// <param name="chatId">
        /// ID of the chat.
        /// </param>
        /// <param name="turnId">
        /// ID of the turn.
        /// </param>
        public ChatInfoResponse(
            string? type,
            string? chatId,
            string? turnId)
        {
            this.Type = type;
            this.ChatId = chatId;
            this.TurnId = turnId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatInfoResponse" /> class.
        /// </summary>
        public ChatInfoResponse()
        {
        }
    }
}