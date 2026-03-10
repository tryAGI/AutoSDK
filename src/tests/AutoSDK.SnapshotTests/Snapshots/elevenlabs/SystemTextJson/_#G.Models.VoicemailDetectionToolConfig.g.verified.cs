//HintName: G.Models.VoicemailDetectionToolConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Allows the agent to detect when a voicemail system is encountered.<br/>
    /// This tool should be invoked by the LLM when it detects that the call has been<br/>
    /// answered by a voicemail system rather than a human. If a voicemail message<br/>
    /// is configured, it will be played; otherwise the call will end immediately.
    /// </summary>
    public sealed partial class VoicemailDetectionToolConfig
    {
        /// <summary>
        /// Default Value: voicemail_detection
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system_tool_type")]
        public string? SystemToolType { get; set; }

        /// <summary>
        /// Optional message to leave on voicemail when detected. If not provided, the call will end immediately when voicemail is detected. Supports dynamic variables (e.g., {{system__time}}, {{system__call_duration_secs}}, {{custom_variable}}).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voicemail_message")]
        public string? VoicemailMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoicemailDetectionToolConfig" /> class.
        /// </summary>
        /// <param name="systemToolType">
        /// Default Value: voicemail_detection
        /// </param>
        /// <param name="voicemailMessage">
        /// Optional message to leave on voicemail when detected. If not provided, the call will end immediately when voicemail is detected. Supports dynamic variables (e.g., {{system__time}}, {{system__call_duration_secs}}, {{custom_variable}}).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoicemailDetectionToolConfig(
            string? systemToolType,
            string? voicemailMessage)
        {
            this.SystemToolType = systemToolType;
            this.VoicemailMessage = voicemailMessage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoicemailDetectionToolConfig" /> class.
        /// </summary>
        public VoicemailDetectionToolConfig()
        {
        }
    }
}