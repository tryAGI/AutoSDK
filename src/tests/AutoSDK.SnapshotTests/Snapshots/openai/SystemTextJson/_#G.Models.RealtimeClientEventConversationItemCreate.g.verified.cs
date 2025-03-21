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
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// The item to add to the conversation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.RealtimeConversationItem Item { get; set; }

        /// <summary>
        /// The ID of the preceding item after which the new item will be inserted. <br/>
        /// If not set, the new item will be appended to the end of the conversation.<br/>
        /// If set to `root`, the new item will be added to the beginning of the conversation.<br/>
        /// If set to an existing ID, it allows an item to be inserted mid-conversation. If the<br/>
        /// ID cannot be found, an error will be returned and the item will not be added.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previous_item_id")]
        public string? PreviousItemId { get; set; }

        /// <summary>
        /// The event type, must be `conversation.item.create`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RealtimeClientEventConversationItemCreateTypeJsonConverter))]
        public global::G.RealtimeClientEventConversationItemCreateType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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