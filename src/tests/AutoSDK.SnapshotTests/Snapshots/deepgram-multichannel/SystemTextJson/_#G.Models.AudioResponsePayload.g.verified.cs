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
        [global::System.Text.Json.Serialization.JsonPropertyName("message_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AudioResponsePayloadMessageTypeJsonConverter))]
        public global::G.AudioResponsePayloadMessageType MessageType { get; set; }

        /// <summary>
        /// Base64-encoded synthesized audio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_base_64")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AudioBase64 { get; set; }

        /// <summary>
        /// Audio duration in milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_ms")]
        public int? DurationMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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