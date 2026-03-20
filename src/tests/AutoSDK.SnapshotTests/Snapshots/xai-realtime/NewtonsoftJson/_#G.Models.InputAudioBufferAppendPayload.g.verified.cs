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
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.InputAudioBufferAppendPayloadType Type { get; set; }

        /// <summary>
        /// Optional event ID.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// Base64-encoded audio data.
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
        /// <param name="type"></param>
        /// <param name="eventId">
        /// Optional event ID.
        /// </param>
        /// <param name="audio">
        /// Base64-encoded audio data.
        /// </param>
        public InputAudioBufferAppendPayload(
            string audio,
            global::G.InputAudioBufferAppendPayloadType type,
            string? eventId)
        {
            this.Audio = audio ?? throw new global::System.ArgumentNullException(nameof(audio));
            this.Type = type;
            this.EventId = eventId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InputAudioBufferAppendPayload" /> class.
        /// </summary>
        public InputAudioBufferAppendPayload()
        {
        }
    }
}