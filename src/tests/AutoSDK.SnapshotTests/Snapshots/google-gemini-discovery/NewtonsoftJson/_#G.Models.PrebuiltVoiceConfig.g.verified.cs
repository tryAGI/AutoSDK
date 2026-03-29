//HintName: G.Models.PrebuiltVoiceConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The configuration for the prebuilt speaker to use.
    /// </summary>
    public sealed partial class PrebuiltVoiceConfig
    {
        /// <summary>
        /// The name of the preset voice to use.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voiceName")]
        public string? VoiceName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PrebuiltVoiceConfig" /> class.
        /// </summary>
        /// <param name="voiceName">
        /// The name of the preset voice to use.
        /// </param>
        public PrebuiltVoiceConfig(
            string? voiceName)
        {
            this.VoiceName = voiceName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrebuiltVoiceConfig" /> class.
        /// </summary>
        public PrebuiltVoiceConfig()
        {
        }
    }
}