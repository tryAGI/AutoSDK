//HintName: G.Models.SessionInputAudioTranscription.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration for input audio transcription.
    /// </summary>
    public sealed partial class SessionInputAudioTranscription
    {
        /// <summary>
        /// Whether transcription is enabled.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// The model to use for transcription.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionInputAudioTranscription" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Whether transcription is enabled.
        /// </param>
        /// <param name="model">
        /// The model to use for transcription.
        /// </param>
        public SessionInputAudioTranscription(
            bool? enabled,
            string? model)
        {
            this.Enabled = enabled;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionInputAudioTranscription" /> class.
        /// </summary>
        public SessionInputAudioTranscription()
        {
        }
    }
}