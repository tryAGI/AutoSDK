//HintName: G.Models.VADConfigWorkflowOverride.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"background_voice_detection":false}
    /// </summary>
    public sealed partial class VADConfigWorkflowOverride
    {
        /// <summary>
        /// Whether to use background voice filtering
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background_voice_detection")]
        public bool? BackgroundVoiceDetection { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VADConfigWorkflowOverride" /> class.
        /// </summary>
        /// <param name="backgroundVoiceDetection">
        /// Whether to use background voice filtering
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VADConfigWorkflowOverride(
            bool? backgroundVoiceDetection)
        {
            this.BackgroundVoiceDetection = backgroundVoiceDetection;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VADConfigWorkflowOverride" /> class.
        /// </summary>
        public VADConfigWorkflowOverride()
        {
        }
    }
}