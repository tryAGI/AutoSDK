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
        /// Base64-encoded audio data from the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public string Data { get; set; } = default!;

        /// <summary>
        /// The transcript of the audio data from the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transcript", Required = global::Newtonsoft.Json.Required.Always)]
        public string Transcript { get; set; } = default!;

        /// <summary>
        /// The type of the output audio. Always `output_audio`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.OutputAudioType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputAudio" /> class.
        /// </summary>
        /// <param name="data">
        /// Base64-encoded audio data from the model.
        /// </param>
        /// <param name="transcript">
        /// The transcript of the audio data from the model.
        /// </param>
        /// <param name="type">
        /// The type of the output audio. Always `output_audio`.
        /// </param>
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