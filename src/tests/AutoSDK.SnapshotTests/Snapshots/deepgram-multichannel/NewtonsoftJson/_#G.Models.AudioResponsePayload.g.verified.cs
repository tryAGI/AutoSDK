//HintName: G.Models.AudioResponsePayload.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Synthesized audio response.
    /// </summary>
    public sealed partial class AudioResponsePayload
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message_type")]
        public global::G.AudioResponsePayloadMessageType MessageType { get; set; }

        /// <summary>
        /// Base64-encoded synthesized audio.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audio_base_64", Required = global::Newtonsoft.Json.Required.Always)]
        public string AudioBase64 { get; set; } = default!;

        /// <summary>
        /// Audio duration in milliseconds.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("duration_ms")]
        public int? DurationMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioResponsePayload" /> class.
        /// </summary>
        /// <param name="messageType"></param>
        /// <param name="audioBase64">
        /// Base64-encoded synthesized audio.
        /// </param>
        /// <param name="durationMs">
        /// Audio duration in milliseconds.
        /// </param>
        public AudioResponsePayload(
            string audioBase64,
            global::G.AudioResponsePayloadMessageType messageType,
            int? durationMs)
        {
            this.AudioBase64 = audioBase64 ?? throw new global::System.ArgumentNullException(nameof(audioBase64));
            this.MessageType = messageType;
            this.DurationMs = durationMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioResponsePayload" /> class.
        /// </summary>
        public AudioResponsePayload()
        {
        }
    }
}