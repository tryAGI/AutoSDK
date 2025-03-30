//HintName: G.Models.TTSConversationalConfigOverrideConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TTSConversationalConfigOverrideConfig
    {
        /// <summary>
        /// Whether to allow overriding the voice ID<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_id")]
        public bool? VoiceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TTSConversationalConfigOverrideConfig" /> class.
        /// </summary>
        /// <param name="voiceId">
        /// Whether to allow overriding the voice ID<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TTSConversationalConfigOverrideConfig(
            bool? voiceId)
        {
            this.VoiceId = voiceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TTSConversationalConfigOverrideConfig" /> class.
        /// </summary>
        public TTSConversationalConfigOverrideConfig()
        {
        }
    }
}