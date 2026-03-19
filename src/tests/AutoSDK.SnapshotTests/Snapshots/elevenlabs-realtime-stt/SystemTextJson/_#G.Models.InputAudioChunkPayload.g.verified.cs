//HintName: G.Models.InputAudioChunkPayload.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Audio chunk sent by the client.
    /// </summary>
    public sealed partial class InputAudioChunkPayload
    {
        /// <summary>
        /// Must be 'input_audio_chunk'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.InputAudioChunkPayloadMessageTypeJsonConverter))]
        public global::G.InputAudioChunkPayloadMessageType MessageType { get; set; }

        /// <summary>
        /// Base64-encoded audio data.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_base_64")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AudioBase64 { get; set; }

        /// <summary>
        /// Whether to commit the audio buffer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Commit { get; set; }

        /// <summary>
        /// Audio sample rate in Hz.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sample_rate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SampleRate { get; set; }

        /// <summary>
        /// Optional previous text context.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previous_text")]
        public string? PreviousText { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InputAudioChunkPayload" /> class.
        /// </summary>
        /// <param name="messageType">
        /// Must be 'input_audio_chunk'.
        /// </param>
        /// <param name="audioBase64">
        /// Base64-encoded audio data.
        /// </param>
        /// <param name="commit">
        /// Whether to commit the audio buffer.
        /// </param>
        /// <param name="sampleRate">
        /// Audio sample rate in Hz.
        /// </param>
        /// <param name="previousText">
        /// Optional previous text context.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InputAudioChunkPayload(
            string audioBase64,
            bool commit,
            int sampleRate,
            global::G.InputAudioChunkPayloadMessageType messageType,
            string? previousText)
        {
            this.AudioBase64 = audioBase64 ?? throw new global::System.ArgumentNullException(nameof(audioBase64));
            this.Commit = commit;
            this.SampleRate = sampleRate;
            this.MessageType = messageType;
            this.PreviousText = previousText;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InputAudioChunkPayload" /> class.
        /// </summary>
        public InputAudioChunkPayload()
        {
        }
    }
}