//HintName: G.Models.ConversationItemAddedEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A conversation item has been added.
    /// </summary>
    public sealed partial class ConversationItemAddedEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ConversationItemAddedEventTypeJsonConverter))]
        public global::G.ConversationItemAddedEventType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// A conversation item (message or function output).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("item")]
        public global::G.ConversationItem? Item { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationItemAddedEvent" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="eventId"></param>
        /// <param name="item">
        /// A conversation item (message or function output).
        /// </param>
        public ConversationItemAddedEvent(
            global::G.ConversationItemAddedEventType? type,
            string? eventId,
            global::G.ConversationItem? item)
        {
            this.Type = type;
            this.EventId = eventId;
            this.Item = item;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationItemAddedEvent" /> class.
        /// </summary>
        public ConversationItemAddedEvent()
        {
        }
    }
}