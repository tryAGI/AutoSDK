//HintName: G.Models.SessionConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Session configuration returned by the server.
    /// </summary>
    public sealed partial class SessionConfig
    {
        /// <summary>
        /// The model used for transcription.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_id")]
        public string? ModelId { get; set; }

        /// <summary>
        /// Audio format being used.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audio_format")]
        public string? AudioFormat { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionConfig" /> class.
        /// </summary>
        /// <param name="modelId">
        /// The model used for transcription.
        /// </param>
        /// <param name="audioFormat">
        /// Audio format being used.
        /// </param>
        public SessionConfig(
            string? modelId,
            string? audioFormat)
        {
            this.ModelId = modelId;
            this.AudioFormat = audioFormat;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionConfig" /> class.
        /// </summary>
        public SessionConfig()
        {
        }
    }
}