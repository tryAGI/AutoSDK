//HintName: G.Models.RealtimeClientEventConversationItemCreate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Add a new Item to the Conversation's context, including messages, function <br/>
    /// calls, and function call responses. This event can be used both to populate a <br/>
    /// "history" of the conversation and to add new items mid-stream, but has the <br/>
    /// current limitation that it cannot populate assistant audio messages.<br/>
    /// If successful, the server will respond with a `conversation.item.created` <br/>
    /// event, otherwise an `error` event will be sent.
    /// </summary>
    public sealed partial class RealtimeClientEventConversationItemCreate
    {
        /// <summary>
        /// Optional client-generated ID used to identify this event.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// The item to add to the conversation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("item", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RealtimeConversationItem Item { get; set; } = default!;

        /// <summary>
        /// The ID of the preceding item after which the new item will be inserted. <br/>
        /// If not set, the new item will be appended to the end of the conversation.<br/>
        /// If set to `root`, the new item will be added to the beginning of the conversation.<br/>
        /// If set to an existing ID, it allows an item to be inserted mid-conversation. If the<br/>
        /// ID cannot be found, an error will be returned and the item will not be added.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("previous_item_id")]
        public string? PreviousItemId { get; set; }

        /// <summary>
        /// The event type, must be `conversation.item.create`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.RealtimeClientEventConversationItemCreateType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeClientEventConversationItemCreate" /> class.
        /// </summary>
        /// <param name="eventId">
        /// Optional client-generated ID used to identify this event.
        /// </param>
        /// <param name="item">
        /// The item to add to the conversation.
        /// </param>
        /// <param name="previousItemId">
        /// The ID of the preceding item after which the new item will be inserted. <br/>
        /// If not set, the new item will be appended to the end of the conversation.<br/>
        /// If set to `root`, the new item will be added to the beginning of the conversation.<br/>
        /// If set to an existing ID, it allows an item to be inserted mid-conversation. If the<br/>
        /// ID cannot be found, an error will be returned and the item will not be added.
        /// </param>
        /// <param name="type">
        /// The event type, must be `conversation.item.create`.
        /// </param>
        public RealtimeClientEventConversationItemCreate(
            global::G.RealtimeConversationItem item,
            string? eventId,
            string? previousItemId,
            global::G.RealtimeClientEventConversationItemCreateType type)
        {
            this.Item = item ?? throw new global::System.ArgumentNullException(nameof(item));
            this.EventId = eventId;
            this.PreviousItemId = previousItemId;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeClientEventConversationItemCreate" /> class.
        /// </summary>
        public RealtimeClientEventConversationItemCreate()
        {
        }
    }
}