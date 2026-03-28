//HintName: G.Models.InputAudioBufferAppendPayload.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Append audio data to the input buffer.
    /// </summary>
    public sealed partial class InputAudioBufferAppendPayload
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.InputAudioBufferAppendPayloadTypeJsonConverter))]
        public global::G.InputAudioBufferAppendPayloadType Type { get; set; }

        /// <summary>
        /// Optional event ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// Base64-encoded audio data.
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
        /// Base64-encoded audio data.
        /// </param>
        /// <param name="type"></param>
        /// <param name="eventId">
        /// Optional event ID.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InputAudioBufferAppendPayload(
            string audio,
            global::G.InputAudioBufferAppendPayloadType type,
            string? eventId)
        {
            this.Type = type;
            this.EventId = eventId;
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