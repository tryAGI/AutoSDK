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
        [global::Newtonsoft.Json.JsonProperty("prebuiltVoiceConfig", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.GeminiMultimodalLivePrebuiltVoiceConfig PrebuiltVoiceConfig { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GeminiMultimodalLiveVoiceConfig" /> class.
        /// </summary>
        /// <param name="prebuiltVoiceConfig"></param>
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