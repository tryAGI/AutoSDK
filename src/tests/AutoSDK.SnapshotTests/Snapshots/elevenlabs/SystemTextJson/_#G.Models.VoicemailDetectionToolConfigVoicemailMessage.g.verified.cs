//HintName: G.Models.VoicemailDetectionToolConfigVoicemailMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Optional message to leave on voicemail when detected. If not provided, the call will end immediately when voicemail is detected. Supports dynamic variables (e.g., {{system__time}}, {{system__call_duration_secs}}, {{custom_variable}}).
    /// </summary>
    public sealed partial class VoicemailDetectionToolConfigVoicemailMessage
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}