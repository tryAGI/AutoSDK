//HintName: G.Models.ReturnChat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReturnChat
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chat_group_id")]
        public string? ChatGroupId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag")]
        public string? Tag { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ReturnChatStatusJsonConverter))]
        public global::G.ReturnChatStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_timestamp")]
        public long? StartTimestamp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_timestamp")]
        public long? EndTimestamp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_count")]
        public int? EventCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public string? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public global::G.ReturnConfig? Config { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnChat" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="chatGroupId"></param>
        /// <param name="tag"></param>
        /// <param name="status"></param>
        /// <param name="startTimestamp"></param>
        /// <param name="endTimestamp"></param>
        /// <param name="eventCount"></param>
        /// <param name="metadata"></param>
        /// <param name="config"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReturnChat(
            string? id,
            string? chatGroupId,
            string? tag,
            global::G.ReturnChatStatus? status,
            long? startTimestamp,
            long? endTimestamp,
            int? eventCount,
            string? metadata,
            global::G.ReturnConfig? config)
        {
            this.Id = id;
            this.ChatGroupId = chatGroupId;
            this.Tag = tag;
            this.Status = status;
            this.StartTimestamp = startTimestamp;
            this.EndTimestamp = endTimestamp;
            this.EventCount = eventCount;
            this.Metadata = metadata;
            this.Config = config;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnChat" /> class.
        /// </summary>
        public ReturnChat()
        {
        }
    }
}