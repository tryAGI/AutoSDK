//HintName: G.Models.TTSConversationalConfigWorkflowOverrideInputTextNormalisationType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Method for converting numbers to words before converting text to speech. If set to SYSTEM_PROMPT, the system prompt will be updated to include normalization instructions. If set to ELEVENLABS, the text will be normalized after generation, incurring slight additional latency.
    /// </summary>
    public sealed partial class TTSConversationalConfigWorkflowOverrideInputTextNormalisationType
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}