﻿//HintName: G.Models.AgentPlatformSettingsRequestModel.g.cs

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
        [global::Newtonsoft.Json.JsonProperty("auth")]
        public global::G.AuthSettings? Auth { get; set; }

        /// <summary>
        /// Settings to evaluate an agent's performance.<br/>
        /// Agents are evaluated against a set of criteria, with success being defined as meeting some combination of those criteria.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("evaluation")]
        public global::G.EvaluationSettings? Evaluation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("widget")]
        public global::G.WidgetConfigInput? Widget { get; set; }

        /// <summary>
        /// Data collection settings
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data_collection")]
        public global::System.Collections.Generic.Dictionary<string, global::G.LiteralJsonSchemaProperty>? DataCollection { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("overrides")]
        public global::G.ConversationInitiationClientDataConfigInput? Overrides { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("call_limits")]
        public global::G.AgentCallLimits? CallLimits { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("privacy")]
        public global::G.PrivacyConfig? Privacy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workspace_overrides")]
        public global::G.AgentWorkspaceOverridesInput? WorkspaceOverrides { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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