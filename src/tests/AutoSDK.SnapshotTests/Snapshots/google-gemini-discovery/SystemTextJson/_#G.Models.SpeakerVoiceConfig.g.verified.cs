//HintName: G.Models.SpeakerVoiceConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The configuration for a single speaker in a multi speaker setup.
    /// </summary>
    public sealed partial class SpeakerVoiceConfig
    {
        /// <summary>
        /// Required. The name of the speaker to use. Should be the same as in the prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaker")]
        public string? Speaker { get; set; }

        /// <summary>
        /// The configuration for the voice to use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voiceConfig")]
        public global::G.VoiceConfig? VoiceConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeakerVoiceConfig" /> class.
        /// </summary>
        /// <param name="speaker">
        /// Required. The name of the speaker to use. Should be the same as in the prompt.
        /// </param>
        /// <param name="voiceConfig">
        /// The configuration for the voice to use.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeakerVoiceConfig(
            string? speaker,
            global::G.VoiceConfig? voiceConfig)
        {
            this.Speaker = speaker;
            this.VoiceConfig = voiceConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeakerVoiceConfig" /> class.
        /// </summary>
        public SpeakerVoiceConfig()
        {
        }
    }
}