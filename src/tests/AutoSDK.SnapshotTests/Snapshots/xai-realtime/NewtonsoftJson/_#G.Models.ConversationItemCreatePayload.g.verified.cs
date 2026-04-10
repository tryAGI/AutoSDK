//HintName: G.Models.ConversationItemCreatePayload.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Add a conversation item.
    /// </summary>
    public sealed partial class ConversationItemCreatePayload
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ConversationItemCreatePayloadTypeJsonConverter))]
        public global::G.ConversationItemCreatePayloadType Type { get; set; }

        /// <summary>
        /// Optional event ID.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// A conversation item (message or function output).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("item", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ConversationItem Item { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationItemCreatePayload" /> class.
        /// </summary>
        /// <param name="item">
        /// A conversation item (message or function output).
        /// </param>
        /// <param name="type"></param>
        /// <param name="eventId">
        /// Optional event ID.
        /// </param>
        public ConversationItemCreatePayload(
            global::G.ConversationItem item,
            global::G.ConversationItemCreatePayloadType type,
            string? eventId)
        {
            this.Type = type;
            this.EventId = eventId;
            this.Item = item ?? throw new global::System.ArgumentNullException(nameof(item));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationItemCreatePayload" /> class.
        /// </summary>
        public ConversationItemCreatePayload()
        {
        }
    }
}