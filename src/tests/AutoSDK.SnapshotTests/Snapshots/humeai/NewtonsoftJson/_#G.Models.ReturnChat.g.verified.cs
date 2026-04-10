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
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chat_group_id")]
        public string? ChatGroupId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tag")]
        public string? Tag { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ReturnChatStatusJsonConverter))]
        public global::G.ReturnChatStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_timestamp")]
        public long? StartTimestamp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_timestamp")]
        public long? EndTimestamp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event_count")]
        public int? EventCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public string? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("config")]
        public global::G.ReturnConfig? Config { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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