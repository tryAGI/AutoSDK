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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth")]
        public global::G.AuthSettings? Auth { get; set; }

        /// <summary>
        /// Settings to evaluate an agent's performance.<br/>
        /// Agents are evaluated against a set of criteria, with success being defined as meeting some combination of those criteria.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluation")]
        public global::G.EvaluationSettings? Evaluation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("widget")]
        public global::G.WidgetConfig? Widget { get; set; }

        /// <summary>
        /// Data collection settings
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_collection")]
        public global::System.Collections.Generic.Dictionary<string, global::G.LiteralJsonSchemaProperty>? DataCollection { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("overrides")]
        public global::G.ConversationInitiationClientDataConfigInput? Overrides { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_limits")]
        public global::G.AgentCallLimits? CallLimits { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("privacy")]
        public global::G.PrivacyConfig? Privacy { get; set; }

        /// <summary>
        /// 
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
        /// <param name="auth"></param>
        /// <param name="evaluation">
        /// Settings to evaluate an agent's performance.<br/>
        /// Agents are evaluated against a set of criteria, with success being defined as meeting some combination of those criteria.
        /// </param>
        /// <param name="widget"></param>
        /// <param name="dataCollection">
        /// Data collection settings
        /// </param>
        /// <param name="overrides"></param>
        /// <param name="callLimits"></param>
        /// <param name="privacy"></param>
        /// <param name="workspaceOverrides"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentPlatformSettingsRequestModel(
            global::G.AuthSettings? auth,
            global::G.EvaluationSettings? evaluation,
            global::G.WidgetConfig? widget,
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