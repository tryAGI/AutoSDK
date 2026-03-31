//HintName: G.Models.AgentAdvancedSettings.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentAdvancedSettings
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interrupt_enabled")]
        public bool? InterruptEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_timeout_seconds")]
        public double? SessionTimeoutSeconds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("morph_enabled")]
        public bool? MorphEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message_limit")]
        public double? MessageLimit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vm_account_id")]
        public string? VmAccountId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ui_debug_mode")]
        public bool? UiDebugMode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentAdvancedSettings" /> class.
        /// </summary>
        /// <param name="interruptEnabled"></param>
        /// <param name="sessionTimeoutSeconds"></param>
        /// <param name="morphEnabled"></param>
        /// <param name="messageLimit"></param>
        /// <param name="vmAccountId"></param>
        /// <param name="uiDebugMode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentAdvancedSettings(
            bool? interruptEnabled,
            double? sessionTimeoutSeconds,
            bool? morphEnabled,
            double? messageLimit,
            string? vmAccountId,
            bool? uiDebugMode)
        {
            this.InterruptEnabled = interruptEnabled;
            this.SessionTimeoutSeconds = sessionTimeoutSeconds;
            this.MorphEnabled = morphEnabled;
            this.MessageLimit = messageLimit;
            this.VmAccountId = vmAccountId;
            this.UiDebugMode = uiDebugMode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentAdvancedSettings" /> class.
        /// </summary>
        public AgentAdvancedSettings()
        {
        }
    }
}