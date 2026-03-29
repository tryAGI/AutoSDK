//HintName: G.Models.GeminiMultimodalLivePrebuiltVoiceConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GeminiMultimodalLivePrebuiltVoiceConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voiceName")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.GeminiMultimodalLivePrebuiltVoiceConfigVoiceNameJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GeminiMultimodalLivePrebuiltVoiceConfigVoiceName VoiceName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GeminiMultimodalLivePrebuiltVoiceConfig" /> class.
        /// </summary>
        /// <param name="voiceName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GeminiMultimodalLivePrebuiltVoiceConfig(
            global::G.GeminiMultimodalLivePrebuiltVoiceConfigVoiceName voiceName)
        {
            this.VoiceName = voiceName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GeminiMultimodalLivePrebuiltVoiceConfig" /> class.
        /// </summary>
        public GeminiMultimodalLivePrebuiltVoiceConfig()
        {
        }
    }
}