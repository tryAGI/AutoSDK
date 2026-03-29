//HintName: G.Models.VoiceConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The configuration for the voice to use.
    /// </summary>
    public sealed partial class VoiceConfig
    {
        /// <summary>
        /// The configuration for the prebuilt speaker to use.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prebuiltVoiceConfig")]
        public global::G.PrebuiltVoiceConfig? PrebuiltVoiceConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceConfig" /> class.
        /// </summary>
        /// <param name="prebuiltVoiceConfig">
        /// The configuration for the prebuilt speaker to use.
        /// </param>
        public VoiceConfig(
            global::G.PrebuiltVoiceConfig? prebuiltVoiceConfig)
        {
            this.PrebuiltVoiceConfig = prebuiltVoiceConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceConfig" /> class.
        /// </summary>
        public VoiceConfig()
        {
        }
    }
}