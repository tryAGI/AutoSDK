//HintName: G.Models.InputAudioBufferCommittedEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Audio buffer has been committed.
    /// </summary>
    public sealed partial class InputAudioBufferCommittedEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.InputAudioBufferCommittedEventTypeJsonConverter))]
        public global::G.InputAudioBufferCommittedEventType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_id")]
        public string? ItemId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previous_item_id")]
        public string? PreviousItemId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InputAudioBufferCommittedEvent" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="eventId"></param>
        /// <param name="itemId"></param>
        /// <param name="previousItemId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InputAudioBufferCommittedEvent(
            global::G.InputAudioBufferCommittedEventType? type,
            string? eventId,
            string? itemId,
            string? previousItemId)
        {
            this.Type = type;
            this.EventId = eventId;
            this.ItemId = itemId;
            this.PreviousItemId = previousItemId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InputAudioBufferCommittedEvent" /> class.
        /// </summary>
        public InputAudioBufferCommittedEvent()
        {
        }
    }
}