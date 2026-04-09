//HintName: G.Models.InputAudioBufferClearedPayload.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Returned when the input audio buffer is cleared.
    /// </summary>
    public sealed partial class InputAudioBufferClearedPayload
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
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.InputAudioBufferClearedPayloadTypeJsonConverter))]
        public global::G.InputAudioBufferClearedPayloadType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InputAudioBufferClearedPayload" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the server event.
        /// </param>
        /// <param name="type">
        /// The event type.
        /// </param>
        public InputAudioBufferClearedPayload(
            string eventId,
            global::G.InputAudioBufferClearedPayloadType type)
        {
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InputAudioBufferClearedPayload" /> class.
        /// </summary>
        public InputAudioBufferClearedPayload()
        {
        }
    }
}