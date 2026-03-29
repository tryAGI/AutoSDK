//HintName: G.Models.PostToolRouterSessionResponseConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The session configuration including user, toolkits, and overrides
    /// </summary>
    public sealed partial class PostToolRouterSessionResponseConfig
    {
        /// <summary>
        /// User identifier for this session
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// Toolkit configuration - either enabled list or disabled list
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolkits")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::G.PostToolRouterSessionResponseConfigToolkitsVariant1, global::G.PostToolRouterSessionResponseConfigToolkitsVariant2>))]
        public global::G.AnyOf<global::G.PostToolRouterSessionResponseConfigToolkitsVariant1, global::G.PostToolRouterSessionResponseConfigToolkitsVariant2>? Toolkits { get; set; }

        /// <summary>
        /// Auth config overrides per toolkit
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_configs")]
        public global::System.Collections.Generic.Dictionary<string, string>? AuthConfigs { get; set; }

        /// <summary>
        /// Connected account overrides per toolkit
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connected_accounts")]
        public global::System.Collections.Generic.Dictionary<string, string>? ConnectedAccounts { get; set; }

        /// <summary>
        /// Manage connections configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("manage_connections")]
        public global::G.PostToolRouterSessionResponseConfigManageConnections? ManageConnections { get; set; }

        /// <summary>
        /// Tool-level configuration per toolkit
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public object? Tools { get; set; }

        /// <summary>
        /// MCP tool annotation hints for filtering tools with enabled/disabled support. enabled: tags that the tool must have at least one of. disabled: tags that the tool must NOT have any of. Both conditions must be satisfied.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::G.PostToolRouterSessionResponseConfigTags? Tags { get; set; }

        /// <summary>
        /// Workbench configuration<br/>
        /// Default Value: {"enable":true,"proxy_execution_enabled":true}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workbench")]
        public global::G.PostToolRouterSessionResponseConfigWorkbench? Workbench { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionResponseConfig" /> class.
        /// </summary>
        /// <param name="userId">
        /// User identifier for this session
        /// </param>
        /// <param name="toolkits">
        /// Toolkit configuration - either enabled list or disabled list
        /// </param>
        /// <param name="authConfigs">
        /// Auth config overrides per toolkit
        /// </param>
        /// <param name="connectedAccounts">
        /// Connected account overrides per toolkit
        /// </param>
        /// <param name="manageConnections">
        /// Manage connections configuration
        /// </param>
        /// <param name="tools">
        /// Tool-level configuration per toolkit
        /// </param>
        /// <param name="tags">
        /// MCP tool annotation hints for filtering tools with enabled/disabled support. enabled: tags that the tool must have at least one of. disabled: tags that the tool must NOT have any of. Both conditions must be satisfied.
        /// </param>
        /// <param name="workbench">
        /// Workbench configuration<br/>
        /// Default Value: {"enable":true,"proxy_execution_enabled":true}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostToolRouterSessionResponseConfig(
            string userId,
            global::G.AnyOf<global::G.PostToolRouterSessionResponseConfigToolkitsVariant1, global::G.PostToolRouterSessionResponseConfigToolkitsVariant2>? toolkits,
            global::System.Collections.Generic.Dictionary<string, string>? authConfigs,
            global::System.Collections.Generic.Dictionary<string, string>? connectedAccounts,
            global::G.PostToolRouterSessionResponseConfigManageConnections? manageConnections,
            object? tools,
            global::G.PostToolRouterSessionResponseConfigTags? tags,
            global::G.PostToolRouterSessionResponseConfigWorkbench? workbench)
        {
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.Toolkits = toolkits;
            this.AuthConfigs = authConfigs;
            this.ConnectedAccounts = connectedAccounts;
            this.ManageConnections = manageConnections;
            this.Tools = tools;
            this.Tags = tags;
            this.Workbench = workbench;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionResponseConfig" /> class.
        /// </summary>
        public PostToolRouterSessionResponseConfig()
        {
        }
    }
}