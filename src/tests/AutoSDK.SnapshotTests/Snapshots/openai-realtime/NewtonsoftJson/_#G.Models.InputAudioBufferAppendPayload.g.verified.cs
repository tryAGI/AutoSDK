//HintName: G.Models.InputAudioBufferAppendPayload.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Send this event to append audio bytes to the input audio buffer.
    /// </summary>
    public sealed partial class InputAudioBufferAppendPayload
    {
        /// <summary>
        /// Optional client-generated ID.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// The event type.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.InputAudioBufferAppendPayloadTypeJsonConverter))]
        public global::G.InputAudioBufferAppendPayloadType Type { get; set; }

        /// <summary>
        /// Base64-encoded audio bytes.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audio", Required = global::Newtonsoft.Json.Required.Always)]
        public string Audio { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InputAudioBufferAppendPayload" /> class.
        /// </summary>
        /// <param name="audio">
        /// Base64-encoded audio bytes.
        /// </param>
        /// <param name="eventId">
        /// Optional client-generated ID.
        /// </param>
        /// <param name="type">
        /// The event type.
        /// </param>
        public InputAudioBufferAppendPayload(
            string audio,
            string? eventId,
            global::G.InputAudioBufferAppendPayloadType type)
        {
            this.EventId = eventId;
            this.Type = type;
            this.Audio = audio ?? throw new global::System.ArgumentNullException(nameof(audio));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InputAudioBufferAppendPayload" /> class.
        /// </summary>
        public InputAudioBufferAppendPayload()
        {
        }
    }
}