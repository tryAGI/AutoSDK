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
        [global::Newtonsoft.Json.JsonProperty("voiceConfig", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.GeminiMultimodalLiveVoiceConfig VoiceConfig { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GeminiMultimodalLiveSpeechConfig" /> class.
        /// </summary>
        /// <param name="voiceConfig"></param>
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