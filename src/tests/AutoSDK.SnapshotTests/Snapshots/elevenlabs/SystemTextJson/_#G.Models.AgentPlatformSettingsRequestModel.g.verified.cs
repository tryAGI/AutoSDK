//HintName: G.Models.AgentPlatformSettingsRequestModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentPlatformSettingsRequestModel
    {
        /// <summary>
        /// Settings for authentication<br/>
        /// Example: {"allowlist":[{"hostname":"https://example.com"}],"enable_auth":true,"shareable_token":"1234567890"}
        /// </summary>
        /// <example>{"allowlist":[{"hostname":"https://example.com"}],"enable_auth":true,"shareable_token":"1234567890"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth")]
        public global::G.AuthSettings? Auth { get; set; }

        /// <summary>
        /// Settings for evaluation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluation")]
        public global::G.EvaluationSettings? Evaluation { get; set; }

        /// <summary>
        /// Configuration for the widget<br/>
        /// Example: {"custom_avatar_path":"https://example.com/avatar.png","language_selector":false}
        /// </summary>
        /// <example>{"custom_avatar_path":"https://example.com/avatar.png","language_selector":false}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("widget")]
        public global::G.WidgetConfigInput? Widget { get; set; }

        /// <summary>
        /// Data collection settings
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_collection")]
        public global::System.Collections.Generic.Dictionary<string, global::G.LiteralJsonSchemaProperty>? DataCollection { get; set; }

        /// <summary>
        /// Additional overrides for the agent during conversation initiation<br/>
        /// Example: {"custom_llm_extra_body":true,"enable_conversation_initiation_client_data_from_webhook":true}
        /// </summary>
        /// <example>{"custom_llm_extra_body":true,"enable_conversation_initiation_client_data_from_webhook":true}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("overrides")]
        public global::G.ConversationInitiationClientDataConfigInput? Overrides { get; set; }

        /// <summary>
        /// Call limits for the agent<br/>
        /// Example: {"agent_concurrency_limit":-1,"bursting_enabled":true,"daily_limit":100000}
        /// </summary>
        /// <example>{"agent_concurrency_limit":-1,"bursting_enabled":true,"daily_limit":100000}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_limits")]
        public global::G.AgentCallLimits? CallLimits { get; set; }

        /// <summary>
        /// Privacy settings for the agent<br/>
        /// Example: {"apply_to_existing_conversations":false,"delete_audio":false,"delete_transcript_and_pii":false,"record_voice":true,"retention_days":-1,"zero_retention_mode":false}
        /// </summary>
        /// <example>{"apply_to_existing_conversations":false,"delete_audio":false,"delete_transcript_and_pii":false,"record_voice":true,"retention_days":-1,"zero_retention_mode":false}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("privacy")]
        public global::G.PrivacyConfig? Privacy { get; set; }

        /// <summary>
        /// Workspace overrides for the agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_overrides")]
        public global::G.AgentWorkspaceOverridesInput? WorkspaceOverrides { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentPlatformSettingsRequestModel" /> class.
        /// </summary>
        /// <param name="auth">
        /// Settings for authentication<br/>
        /// Example: {"allowlist":[{"hostname":"https://example.com"}],"enable_auth":true,"shareable_token":"1234567890"}
        /// </param>
        /// <param name="evaluation">
        /// Settings for evaluation
        /// </param>
        /// <param name="widget">
        /// Configuration for the widget<br/>
        /// Example: {"custom_avatar_path":"https://example.com/avatar.png","language_selector":false}
        /// </param>
        /// <param name="dataCollection">
        /// Data collection settings
        /// </param>
        /// <param name="overrides">
        /// Additional overrides for the agent during conversation initiation<br/>
        /// Example: {"custom_llm_extra_body":true,"enable_conversation_initiation_client_data_from_webhook":true}
        /// </param>
        /// <param name="callLimits">
        /// Call limits for the agent<br/>
        /// Example: {"agent_concurrency_limit":-1,"bursting_enabled":true,"daily_limit":100000}
        /// </param>
        /// <param name="privacy">
        /// Privacy settings for the agent<br/>
        /// Example: {"apply_to_existing_conversations":false,"delete_audio":false,"delete_transcript_and_pii":false,"record_voice":true,"retention_days":-1,"zero_retention_mode":false}
        /// </param>
        /// <param name="workspaceOverrides">
        /// Workspace overrides for the agent
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentPlatformSettingsRequestModel(
            global::G.AuthSettings? auth,
            global::G.EvaluationSettings? evaluation,
            global::G.WidgetConfigInput? widget,
            global::System.Collections.Generic.Dictionary<string, global::G.LiteralJsonSchemaProperty>? dataCollection,
            global::G.ConversationInitiationClientDataConfigInput? overrides,
            global::G.AgentCallLimits? callLimits,
            global::G.PrivacyConfig? privacy,
            global::G.AgentWorkspaceOverridesInput? workspaceOverrides)
        {
            this.Auth = auth;
            this.Evaluation = evaluation;
            this.Widget = widget;
            this.DataCollection = dataCollection;
            this.Overrides = overrides;
            this.CallLimits = callLimits;
            this.Privacy = privacy;
            this.WorkspaceOverrides = workspaceOverrides;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentPlatformSettingsRequestModel" /> class.
        /// </summary>
        public AgentPlatformSettingsRequestModel()
        {
        }
    }
}