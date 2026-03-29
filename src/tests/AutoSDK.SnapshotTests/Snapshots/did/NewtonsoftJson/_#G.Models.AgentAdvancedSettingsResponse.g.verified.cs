//HintName: G.Models.AgentAdvancedSettingsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentAdvancedSettingsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("interrupt_enabled")]
        public bool? InterruptEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("session_timeout_seconds")]
        public double? SessionTimeoutSeconds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("morph_enabled")]
        public bool? MorphEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message_limit")]
        public double? MessageLimit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vm_account_id")]
        public string? VmAccountId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ui_debug_mode")]
        public bool? UiDebugMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("defaults")]
        public global::G.AgentAdvancedSettingsResponseDefaults? Defaults { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentAdvancedSettingsResponse" /> class.
        /// </summary>
        /// <param name="interruptEnabled"></param>
        /// <param name="sessionTimeoutSeconds"></param>
        /// <param name="morphEnabled"></param>
        /// <param name="messageLimit"></param>
        /// <param name="vmAccountId"></param>
        /// <param name="uiDebugMode"></param>
        /// <param name="defaults"></param>
        public AgentAdvancedSettingsResponse(
            bool? interruptEnabled,
            double? sessionTimeoutSeconds,
            bool? morphEnabled,
            double? messageLimit,
            string? vmAccountId,
            bool? uiDebugMode,
            global::G.AgentAdvancedSettingsResponseDefaults? defaults)
        {
            this.InterruptEnabled = interruptEnabled;
            this.SessionTimeoutSeconds = sessionTimeoutSeconds;
            this.MorphEnabled = morphEnabled;
            this.MessageLimit = messageLimit;
            this.VmAccountId = vmAccountId;
            this.UiDebugMode = uiDebugMode;
            this.Defaults = defaults;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentAdvancedSettingsResponse" /> class.
        /// </summary>
        public AgentAdvancedSettingsResponse()
        {
        }
    }
}