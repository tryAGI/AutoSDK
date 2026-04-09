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
        [global::Newtonsoft.Json.JsonProperty("event_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string EventId { get; set; } = default!;

        /// <summary>
        /// The event type.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.InputAudioBufferCommittedPayloadTypeJsonConverter))]
        public global::G.InputAudioBufferCommittedPayloadType Type { get; set; }

        /// <summary>
        /// The ID of the preceding item.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("previous_item_id")]
        public string? PreviousItemId { get; set; }

        /// <summary>
        /// The ID of the user message item that will be created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("item_id")]
        public string? ItemId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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