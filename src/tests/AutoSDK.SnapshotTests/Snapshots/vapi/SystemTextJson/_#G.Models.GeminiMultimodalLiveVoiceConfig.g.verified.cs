//HintName: G.Models.GeminiMultimodalLiveVoiceConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GeminiMultimodalLiveVoiceConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prebuiltVoiceConfig")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GeminiMultimodalLivePrebuiltVoiceConfig PrebuiltVoiceConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GeminiMultimodalLiveVoiceConfig" /> class.
        /// </summary>
        /// <param name="prebuiltVoiceConfig"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GeminiMultimodalLiveVoiceConfig(
            global::G.GeminiMultimodalLivePrebuiltVoiceConfig prebuiltVoiceConfig)
        {
            this.PrebuiltVoiceConfig = prebuiltVoiceConfig ?? throw new global::System.ArgumentNullException(nameof(prebuiltVoiceConfig));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GeminiMultimodalLiveVoiceConfig" /> class.
        /// </summary>
        public GeminiMultimodalLiveVoiceConfig()
        {
        }
    }
}