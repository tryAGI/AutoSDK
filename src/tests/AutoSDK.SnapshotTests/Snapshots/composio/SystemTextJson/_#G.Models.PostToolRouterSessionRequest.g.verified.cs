//HintName: G.Models.PostToolRouterSessionRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostToolRouterSessionRequest
    {
        /// <summary>
        /// The identifier of the user who is initiating the session, ideally a unique identifier from your database like a user ID or email address<br/>
        /// Example: user_123456789
        /// </summary>
        /// <example>user_123456789</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// Toolkit configuration - specify either enable toolkits (allowlist) or disable toolkits (denylist). Mutually exclusive.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolkits")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::G.PostToolRouterSessionRequestToolkitsVariant1, global::G.PostToolRouterSessionRequestToolkitsVariant2>))]
        public global::G.AnyOf<global::G.PostToolRouterSessionRequestToolkitsVariant1, global::G.PostToolRouterSessionRequestToolkitsVariant2>? Toolkits { get; set; }

        /// <summary>
        /// The auth configs to use for the session. This will override the default behavior and use the given auth config when specific toolkits are being executed<br/>
        /// Example: {"gmail":"ac_1223434343","slack":"ac_23343434343434"}
        /// </summary>
        /// <example>{"gmail":"ac_1223434343","slack":"ac_23343434343434"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_configs")]
        public global::System.Collections.Generic.Dictionary<string, string>? AuthConfigs { get; set; }

        /// <summary>
        /// The connected accounts to use for the session. This will override the default behaviour and use the given connected account when specific toolkits are being executed<br/>
        /// Example: {"github":"ca_34454545454545"}
        /// </summary>
        /// <example>{"github":"ca_34454545454545"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("connected_accounts")]
        public global::System.Collections.Generic.Dictionary<string, string>? ConnectedAccounts { get; set; }

        /// <summary>
        /// Configuration for connection management settings<br/>
        /// Default Value: {"enable":true,"enable_wait_for_connections":false,"enable_connection_removal":true}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("manage_connections")]
        public global::G.PostToolRouterSessionRequestManageConnections? ManageConnections { get; set; }

        /// <summary>
        /// Tool-level configuration per toolkit - either specify enable tools (whitelist), disable tools (blacklist), or filter by MCP tags for each toolkit<br/>
        /// Example: {"gmail":{"enable":["GMAIL_SEND_EMAIL","GMAIL_FETCH_EMAILS"]},"slack":{"disable":["SLACK_ADD_EMOJI"]},"slack_bot":{"tags":{"enable":["destructiveHint"],"disable":["openWorldHint"]}}}
        /// </summary>
        /// <example>{"gmail":{"enable":["GMAIL_SEND_EMAIL","GMAIL_FETCH_EMAILS"]},"slack":{"disable":["SLACK_ADD_EMOJI"]},"slack_bot":{"tags":{"enable":["destructiveHint"],"disable":["openWorldHint"]}}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public object? Tools { get; set; }

        /// <summary>
        /// Global MCP tool annotation hints for filtering. Array format is treated as enabled list. Object format supports both enabled (tool must have at least one) and disabled (tool must NOT have any) lists. Toolkit-level tags override this. Toolkit enabled/disabled lists take precedence over tag filtering.<br/>
        /// Example: {"enable":["openWorldHint"],"disable":["destructiveHint"]}
        /// </summary>
        /// <example>{"enable":["openWorldHint"],"disable":["destructiveHint"]}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::G.PostToolRouterSessionRequestTag>, global::G.PostToolRouterSessionRequestTags>))]
        public global::G.AnyOf<global::System.Collections.Generic.IList<global::G.PostToolRouterSessionRequestTag>, global::G.PostToolRouterSessionRequestTags>? Tags { get; set; }

        /// <summary>
        /// Configuration for workbench behavior<br/>
        /// Default Value: {"enable":true,"enable_proxy_execution":true}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workbench")]
        public global::G.PostToolRouterSessionRequestWorkbench? Workbench { get; set; }

        /// <summary>
        /// Experimental features - not stable, may be modified or removed in future versions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("experimental")]
        public global::G.PostToolRouterSessionRequestExperimental? Experimental { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionRequest" /> class.
        /// </summary>
        /// <param name="userId">
        /// The identifier of the user who is initiating the session, ideally a unique identifier from your database like a user ID or email address<br/>
        /// Example: user_123456789
        /// </param>
        /// <param name="toolkits">
        /// Toolkit configuration - specify either enable toolkits (allowlist) or disable toolkits (denylist). Mutually exclusive.
        /// </param>
        /// <param name="authConfigs">
        /// The auth configs to use for the session. This will override the default behavior and use the given auth config when specific toolkits are being executed<br/>
        /// Example: {"gmail":"ac_1223434343","slack":"ac_23343434343434"}
        /// </param>
        /// <param name="connectedAccounts">
        /// The connected accounts to use for the session. This will override the default behaviour and use the given connected account when specific toolkits are being executed<br/>
        /// Example: {"github":"ca_34454545454545"}
        /// </param>
        /// <param name="manageConnections">
        /// Configuration for connection management settings<br/>
        /// Default Value: {"enable":true,"enable_wait_for_connections":false,"enable_connection_removal":true}
        /// </param>
        /// <param name="tools">
        /// Tool-level configuration per toolkit - either specify enable tools (whitelist), disable tools (blacklist), or filter by MCP tags for each toolkit<br/>
        /// Example: {"gmail":{"enable":["GMAIL_SEND_EMAIL","GMAIL_FETCH_EMAILS"]},"slack":{"disable":["SLACK_ADD_EMOJI"]},"slack_bot":{"tags":{"enable":["destructiveHint"],"disable":["openWorldHint"]}}}
        /// </param>
        /// <param name="tags">
        /// Global MCP tool annotation hints for filtering. Array format is treated as enabled list. Object format supports both enabled (tool must have at least one) and disabled (tool must NOT have any) lists. Toolkit-level tags override this. Toolkit enabled/disabled lists take precedence over tag filtering.<br/>
        /// Example: {"enable":["openWorldHint"],"disable":["destructiveHint"]}
        /// </param>
        /// <param name="workbench">
        /// Configuration for workbench behavior<br/>
        /// Default Value: {"enable":true,"enable_proxy_execution":true}
        /// </param>
        /// <param name="experimental">
        /// Experimental features - not stable, may be modified or removed in future versions.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostToolRouterSessionRequest(
            string userId,
            global::G.AnyOf<global::G.PostToolRouterSessionRequestToolkitsVariant1, global::G.PostToolRouterSessionRequestToolkitsVariant2>? toolkits,
            global::System.Collections.Generic.Dictionary<string, string>? authConfigs,
            global::System.Collections.Generic.Dictionary<string, string>? connectedAccounts,
            global::G.PostToolRouterSessionRequestManageConnections? manageConnections,
            object? tools,
            global::G.AnyOf<global::System.Collections.Generic.IList<global::G.PostToolRouterSessionRequestTag>, global::G.PostToolRouterSessionRequestTags>? tags,
            global::G.PostToolRouterSessionRequestWorkbench? workbench,
            global::G.PostToolRouterSessionRequestExperimental? experimental)
        {
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.Toolkits = toolkits;
            this.AuthConfigs = authConfigs;
            this.ConnectedAccounts = connectedAccounts;
            this.ManageConnections = manageConnections;
            this.Tools = tools;
            this.Tags = tags;
            this.Workbench = workbench;
            this.Experimental = experimental;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionRequest" /> class.
        /// </summary>
        public PostToolRouterSessionRequest()
        {
        }
    }
}