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
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// The event type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.InputAudioBufferAppendPayloadTypeJsonConverter))]
        public global::G.InputAudioBufferAppendPayloadType Type { get; set; }

        /// <summary>
        /// Base64-encoded audio bytes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Audio { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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