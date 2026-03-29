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
        [global::Newtonsoft.Json.JsonProperty("voiceName", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.GeminiMultimodalLivePrebuiltVoiceConfigVoiceName VoiceName { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GeminiMultimodalLivePrebuiltVoiceConfig" /> class.
        /// </summary>
        /// <param name="voiceName"></param>
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