//HintName: G.Models.GeminiMultimodalLiveSpeechConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GeminiMultimodalLiveSpeechConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voiceConfig")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GeminiMultimodalLiveVoiceConfig VoiceConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GeminiMultimodalLiveSpeechConfig" /> class.
        /// </summary>
        /// <param name="voiceConfig"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GeminiMultimodalLiveSpeechConfig(
            global::G.GeminiMultimodalLiveVoiceConfig voiceConfig)
        {
            this.VoiceConfig = voiceConfig ?? throw new global::System.ArgumentNullException(nameof(voiceConfig));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GeminiMultimodalLiveSpeechConfig" /> class.
        /// </summary>
        public GeminiMultimodalLiveSpeechConfig()
        {
        }
    }
}