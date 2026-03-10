//HintName: G.Models.VADConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"background_voice_detection":false}
    /// </summary>
    public sealed partial class VADConfig
    {
        /// <summary>
        /// Whether to use background voice filtering<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("background_voice_detection")]
        public bool? BackgroundVoiceDetection { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VADConfig" /> class.
        /// </summary>
        /// <param name="backgroundVoiceDetection">
        /// Whether to use background voice filtering<br/>
        /// Default Value: false
        /// </param>
        public VADConfig(
            bool? backgroundVoiceDetection)
        {
            this.BackgroundVoiceDetection = backgroundVoiceDetection;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VADConfig" /> class.
        /// </summary>
        public VADConfig()
        {
        }
    }
}