//HintName: G.Models.PatchMcpByIdRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Parameters for updating an existing MCP server configuration
    /// </summary>
    public sealed partial class PatchMcpByIdRequest
    {
        /// <summary>
        /// Human-readable name to identify this MCP server instance (4-30 characters, alphanumeric, spaces, and hyphens only)<br/>
        /// Example: Production GitHub Integration
        /// </summary>
        /// <example>Production GitHub Integration</example>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// List of toolkit slugs this server should be configured to work with.<br/>
        /// Example: [gmail, notion]
        /// </summary>
        /// <example>[gmail, notion]</example>
        [global::Newtonsoft.Json.JsonProperty("toolkits")]
        public global::System.Collections.Generic.IList<string>? Toolkits { get; set; }

        /// <summary>
        /// List of action identifiers that should be enabled for this server<br/>
        /// Example: [GMAIL_ADD_LABEL_TO_EMAIL]
        /// </summary>
        /// <example>[GMAIL_ADD_LABEL_TO_EMAIL]</example>
        [global::Newtonsoft.Json.JsonProperty("allowed_tools")]
        public global::System.Collections.Generic.IList<string>? AllowedTools { get; set; }

        /// <summary>
        /// Whether the MCP server is managed by Composio<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("managed_auth_via_composio")]
        public bool? ManagedAuthViaComposio { get; set; }

        /// <summary>
        /// List of auth config IDs to use for this MCP server.<br/>
        /// Example: [auth_cfg_abc123def456, auth_cfg_xyz789]
        /// </summary>
        /// <example>[auth_cfg_abc123def456, auth_cfg_xyz789]</example>
        [global::Newtonsoft.Json.JsonProperty("auth_config_ids")]
        public global::System.Collections.Generic.IList<string>? AuthConfigIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchMcpByIdRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Human-readable name to identify this MCP server instance (4-30 characters, alphanumeric, spaces, and hyphens only)<br/>
        /// Example: Production GitHub Integration
        /// </param>
        /// <param name="toolkits">
        /// List of toolkit slugs this server should be configured to work with.<br/>
        /// Example: [gmail, notion]
        /// </param>
        /// <param name="allowedTools">
        /// List of action identifiers that should be enabled for this server<br/>
        /// Example: [GMAIL_ADD_LABEL_TO_EMAIL]
        /// </param>
        /// <param name="managedAuthViaComposio">
        /// Whether the MCP server is managed by Composio<br/>
        /// Example: true
        /// </param>
        /// <param name="authConfigIds">
        /// List of auth config IDs to use for this MCP server.<br/>
        /// Example: [auth_cfg_abc123def456, auth_cfg_xyz789]
        /// </param>
        public PatchMcpByIdRequest(
            string? name,
            global::System.Collections.Generic.IList<string>? toolkits,
            global::System.Collections.Generic.IList<string>? allowedTools,
            bool? managedAuthViaComposio,
            global::System.Collections.Generic.IList<string>? authConfigIds)
        {
            this.Name = name;
            this.Toolkits = toolkits;
            this.AllowedTools = allowedTools;
            this.ManagedAuthViaComposio = managedAuthViaComposio;
            this.AuthConfigIds = authConfigIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchMcpByIdRequest" /> class.
        /// </summary>
        public PatchMcpByIdRequest()
        {
        }
    }
}