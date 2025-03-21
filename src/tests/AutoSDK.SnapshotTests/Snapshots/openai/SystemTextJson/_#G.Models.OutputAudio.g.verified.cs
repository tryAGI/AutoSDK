//HintName: G.Models.OutputAudio.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An audio output from the model.
    /// </summary>
    public sealed partial class OutputAudio
    {
        /// <summary>
        /// The type of the output audio. Always `output_audio`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OutputAudioTypeJsonConverter))]
        public global::G.OutputAudioType Type { get; set; }

        /// <summary>
        /// Base64-encoded audio data from the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Data { get; set; }

        /// <summary>
        /// The transcript of the audio data from the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcript")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Transcript { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputAudio" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the output audio. Always `output_audio`.
        /// </param>
        /// <param name="data">
        /// Base64-encoded audio data from the model.
        /// </param>
        /// <param name="transcript">
        /// The transcript of the audio data from the model.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OutputAudio(
            string data,
            string transcript,
            global::G.OutputAudioType type)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Transcript = transcript ?? throw new global::System.ArgumentNullException(nameof(transcript));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputAudio" /> class.
        /// </summary>
        public OutputAudio()
        {
        }
    }
}