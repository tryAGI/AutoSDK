//HintName: G.Models.PostMcpServersCustomRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Parameters for creating a new custom MCP server with multiple applications
    /// </summary>
    public sealed partial class PostMcpServersCustomRequest
    {
        /// <summary>
        /// Human-readable name to identify this custom MCP server (4-30 characters, alphanumeric, spaces, and hyphens only)<br/>
        /// Example: Multi App Integration Server
        /// </summary>
        /// <example>Multi App Integration Server</example>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// ID references to existing authentication configurations<br/>
        /// Example: [auth_cfg_abc123def456, auth_cfg_xyz789]
        /// </summary>
        /// <example>[auth_cfg_abc123def456, auth_cfg_xyz789]</example>
        [global::Newtonsoft.Json.JsonProperty("auth_config_ids")]
        public global::System.Collections.Generic.IList<string>? AuthConfigIds { get; set; }

        /// <summary>
        /// List of application/toolkit identifiers to enable for this server<br/>
        /// Example: [github, jira, slack]
        /// </summary>
        /// <example>[github, jira, slack]</example>
        [global::Newtonsoft.Json.JsonProperty("toolkits")]
        public global::System.Collections.Generic.IList<string>? Toolkits { get; set; }

        /// <summary>
        /// Tool identifiers to enable that aren't part of standard toolkits<br/>
        /// Example: [custom-api-tool, internal-database-tool]
        /// </summary>
        /// <example>[custom-api-tool, internal-database-tool]</example>
        [global::Newtonsoft.Json.JsonProperty("allowed_tools")]
        public global::System.Collections.Generic.IList<string>? AllowedTools { get; set; }

        /// <summary>
        /// DEPRECATED: Use allowed_tools instead. Tool identifiers to enable that aren't part of standard toolkits<br/>
        /// Example: [custom-api-tool, internal-database-tool]
        /// </summary>
        /// <example>[custom-api-tool, internal-database-tool]</example>
        [global::Newtonsoft.Json.JsonProperty("custom_tools")]
        public global::System.Collections.Generic.IList<string>? CustomTools { get; set; }

        /// <summary>
        /// Whether to manage authentication via Composio
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("managed_auth_via_composio")]
        public bool? ManagedAuthViaComposio { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostMcpServersCustomRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Human-readable name to identify this custom MCP server (4-30 characters, alphanumeric, spaces, and hyphens only)<br/>
        /// Example: Multi App Integration Server
        /// </param>
        /// <param name="authConfigIds">
        /// ID references to existing authentication configurations<br/>
        /// Example: [auth_cfg_abc123def456, auth_cfg_xyz789]
        /// </param>
        /// <param name="toolkits">
        /// List of application/toolkit identifiers to enable for this server<br/>
        /// Example: [github, jira, slack]
        /// </param>
        /// <param name="allowedTools">
        /// Tool identifiers to enable that aren't part of standard toolkits<br/>
        /// Example: [custom-api-tool, internal-database-tool]
        /// </param>
        /// <param name="customTools">
        /// DEPRECATED: Use allowed_tools instead. Tool identifiers to enable that aren't part of standard toolkits<br/>
        /// Example: [custom-api-tool, internal-database-tool]
        /// </param>
        /// <param name="managedAuthViaComposio">
        /// Whether to manage authentication via Composio
        /// </param>
        public PostMcpServersCustomRequest(
            string name,
            global::System.Collections.Generic.IList<string>? authConfigIds,
            global::System.Collections.Generic.IList<string>? toolkits,
            global::System.Collections.Generic.IList<string>? allowedTools,
            global::System.Collections.Generic.IList<string>? customTools,
            bool? managedAuthViaComposio)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.AuthConfigIds = authConfigIds;
            this.Toolkits = toolkits;
            this.AllowedTools = allowedTools;
            this.CustomTools = customTools;
            this.ManagedAuthViaComposio = managedAuthViaComposio;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostMcpServersCustomRequest" /> class.
        /// </summary>
        public PostMcpServersCustomRequest()
        {
        }
    }
}