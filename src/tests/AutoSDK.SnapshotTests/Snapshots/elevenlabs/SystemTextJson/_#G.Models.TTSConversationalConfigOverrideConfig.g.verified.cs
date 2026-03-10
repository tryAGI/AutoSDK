//HintName: G.Models.TTSConversationalConfigOverrideConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TTSConversationalConfigOverrideConfig
    {
        /// <summary>
        /// Whether to allow overriding the voice_id field.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_id")]
        public bool? VoiceId { get; set; }

        /// <summary>
        /// Whether to allow overriding the stability field.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stability")]
        public bool? Stability { get; set; }

        /// <summary>
        /// Whether to allow overriding the speed field.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed")]
        public bool? Speed { get; set; }

        /// <summary>
        /// Whether to allow overriding the similarity_boost field.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("similarity_boost")]
        public bool? SimilarityBoost { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TTSConversationalConfigOverrideConfig" /> class.
        /// </summary>
        /// <param name="voiceId">
        /// Whether to allow overriding the voice_id field.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="stability">
        /// Whether to allow overriding the stability field.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="speed">
        /// Whether to allow overriding the speed field.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="similarityBoost">
        /// Whether to allow overriding the similarity_boost field.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TTSConversationalConfigOverrideConfig(
            bool? voiceId,
            bool? stability,
            bool? speed,
            bool? similarityBoost)
        {
            this.VoiceId = voiceId;
            this.Stability = stability;
            this.Speed = speed;
            this.SimilarityBoost = similarityBoost;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TTSConversationalConfigOverrideConfig" /> class.
        /// </summary>
        public TTSConversationalConfigOverrideConfig()
        {
        }
    }
}