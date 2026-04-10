//HintName: G.Models.ReturnChatEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReturnChatEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chat_id")]
        public string? ChatId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timestamp")]
        public long? Timestamp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ReturnChatEventRoleJsonConverter))]
        public global::G.ReturnChatEventRole? Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ReturnChatEventTypeJsonConverter))]
        public global::G.ReturnChatEventType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message_text")]
        public string? MessageText { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("emotion_features")]
        public string? EmotionFeatures { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public string? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnChatEvent" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="chatId"></param>
        /// <param name="timestamp"></param>
        /// <param name="role"></param>
        /// <param name="type"></param>
        /// <param name="messageText"></param>
        /// <param name="emotionFeatures"></param>
        /// <param name="metadata"></param>
        public ReturnChatEvent(
            string? id,
            string? chatId,
            long? timestamp,
            global::G.ReturnChatEventRole? role,
            global::G.ReturnChatEventType? type,
            string? messageText,
            string? emotionFeatures,
            string? metadata)
        {
            this.Id = id;
            this.ChatId = chatId;
            this.Timestamp = timestamp;
            this.Role = role;
            this.Type = type;
            this.MessageText = messageText;
            this.EmotionFeatures = emotionFeatures;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnChatEvent" /> class.
        /// </summary>
        public ReturnChatEvent()
        {
        }
    }
}