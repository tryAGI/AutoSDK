//HintName: G.Models.InputAudioBufferCommittedPayload.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Returned when an input audio buffer is committed.
    /// </summary>
    public sealed partial class InputAudioBufferCommittedPayload
    {
        /// <summary>
        /// The unique ID of the server event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventId { get; set; }

        /// <summary>
        /// The event type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.InputAudioBufferCommittedPayloadTypeJsonConverter))]
        public global::G.InputAudioBufferCommittedPayloadType Type { get; set; }

        /// <summary>
        /// The ID of the preceding item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previous_item_id")]
        public string? PreviousItemId { get; set; }

        /// <summary>
        /// The ID of the user message item that will be created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_id")]
        public string? ItemId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InputAudioBufferCommittedPayload" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the server event.
        /// </param>
        /// <param name="type">
        /// The event type.
        /// </param>
        /// <param name="previousItemId">
        /// The ID of the preceding item.
        /// </param>
        /// <param name="itemId">
        /// The ID of the user message item that will be created.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InputAudioBufferCommittedPayload(
            string eventId,
            global::G.InputAudioBufferCommittedPayloadType type,
            string? previousItemId,
            string? itemId)
        {
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.Type = type;
            this.PreviousItemId = previousItemId;
            this.ItemId = itemId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InputAudioBufferCommittedPayload" /> class.
        /// </summary>
        public InputAudioBufferCommittedPayload()
        {
        }
    }
}