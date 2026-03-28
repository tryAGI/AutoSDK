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
        [global::Newtonsoft.Json.JsonProperty("message_type")]
        public global::G.InputAudioChunkPayloadMessageType MessageType { get; set; }

        /// <summary>
        /// Base64-encoded audio data.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audio_base_64", Required = global::Newtonsoft.Json.Required.Always)]
        public string AudioBase64 { get; set; } = default!;

        /// <summary>
        /// Whether to commit the audio buffer.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("commit", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Commit { get; set; } = default!;

        /// <summary>
        /// Audio sample rate in Hz.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sample_rate", Required = global::Newtonsoft.Json.Required.Always)]
        public int SampleRate { get; set; } = default!;

        /// <summary>
        /// Optional previous text context.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("previous_text")]
        public string? PreviousText { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InputAudioChunkPayload" /> class.
        /// </summary>
        /// <param name="audioBase64">
        /// Base64-encoded audio data.
        /// </param>
        /// <param name="commit">
        /// Whether to commit the audio buffer.
        /// </param>
        /// <param name="sampleRate">
        /// Audio sample rate in Hz.
        /// </param>
        /// <param name="messageType">
        /// Must be 'input_audio_chunk'.
        /// </param>
        /// <param name="previousText">
        /// Optional previous text context.
        /// </param>
        public InputAudioChunkPayload(
            string audioBase64,
            bool commit,
            int sampleRate,
            global::G.InputAudioChunkPayloadMessageType messageType,
            string? previousText)
        {
            this.MessageType = messageType;
            this.AudioBase64 = audioBase64 ?? throw new global::System.ArgumentNullException(nameof(audioBase64));
            this.Commit = commit;
            this.SampleRate = sampleRate;
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