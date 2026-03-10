//HintName: G.Models.TTSConversationalConfigOverride.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"similarity_boost":0.8,"speed":1.0,"stability":0.5,"voice_id":"cjVigY5qzO86Huf0OWal"}
    /// </summary>
    public sealed partial class TTSConversationalConfigOverride
    {
        /// <summary>
        /// The voice ID to use for TTS
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voice_id")]
        public string? VoiceId { get; set; }

        /// <summary>
        /// The stability of generated speech
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stability")]
        public double? Stability { get; set; }

        /// <summary>
        /// The speed of generated speech
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("speed")]
        public double? Speed { get; set; }

        /// <summary>
        /// The similarity boost for generated speech
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("similarity_boost")]
        public double? SimilarityBoost { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TTSConversationalConfigOverride" /> class.
        /// </summary>
        /// <param name="voiceId">
        /// The voice ID to use for TTS
        /// </param>
        /// <param name="stability">
        /// The stability of generated speech
        /// </param>
        /// <param name="speed">
        /// The speed of generated speech
        /// </param>
        /// <param name="similarityBoost">
        /// The similarity boost for generated speech
        /// </param>
        public TTSConversationalConfigOverride(
            string? voiceId,
            double? stability,
            double? speed,
            double? similarityBoost)
        {
            this.VoiceId = voiceId;
            this.Stability = stability;
            this.Speed = speed;
            this.SimilarityBoost = similarityBoost;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TTSConversationalConfigOverride" /> class.
        /// </summary>
        public TTSConversationalConfigOverride()
        {
        }
    }
}