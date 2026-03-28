//HintName: G.Models.AudioDataPayload.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Audio data sent for transcription.
    /// </summary>
    public sealed partial class AudioDataPayload
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AudioDataPayloadMessageTypeJsonConverter))]
        public global::G.AudioDataPayloadMessageType MessageType { get; set; }

        /// <summary>
        /// Base64-encoded audio data.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_base_64")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AudioBase64 { get; set; }

        /// <summary>
        /// Audio sample rate in Hz.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sample_rate")]
        public int? SampleRate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioDataPayload" /> class.
        /// </summary>
        /// <param name="audioBase64">
        /// Base64-encoded audio data.
        /// </param>
        /// <param name="messageType"></param>
        /// <param name="sampleRate">
        /// Audio sample rate in Hz.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioDataPayload(
            string audioBase64,
            global::G.AudioDataPayloadMessageType messageType,
            int? sampleRate)
        {
            this.MessageType = messageType;
            this.AudioBase64 = audioBase64 ?? throw new global::System.ArgumentNullException(nameof(audioBase64));
            this.SampleRate = sampleRate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioDataPayload" /> class.
        /// </summary>
        public AudioDataPayload()
        {
        }
    }
}