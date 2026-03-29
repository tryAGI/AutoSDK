//HintName: G.Models.MultiSpeakerVoiceConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The configuration for the multi-speaker setup.
    /// </summary>
    public sealed partial class MultiSpeakerVoiceConfig
    {
        /// <summary>
        /// Required. All the enabled speaker voices.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speakerVoiceConfigs")]
        public global::System.Collections.Generic.IList<global::G.SpeakerVoiceConfig>? SpeakerVoiceConfigs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MultiSpeakerVoiceConfig" /> class.
        /// </summary>
        /// <param name="speakerVoiceConfigs">
        /// Required. All the enabled speaker voices.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MultiSpeakerVoiceConfig(
            global::System.Collections.Generic.IList<global::G.SpeakerVoiceConfig>? speakerVoiceConfigs)
        {
            this.SpeakerVoiceConfigs = speakerVoiceConfigs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MultiSpeakerVoiceConfig" /> class.
        /// </summary>
        public MultiSpeakerVoiceConfig()
        {
        }
    }
}