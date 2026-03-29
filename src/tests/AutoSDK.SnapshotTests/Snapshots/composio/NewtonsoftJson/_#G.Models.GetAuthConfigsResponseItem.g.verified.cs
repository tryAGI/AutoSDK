//HintName: G.Models.GetAuthConfigsResponseItem.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAuthConfigsResponseItem
    {
        /// <summary>
        /// The unique ID of the authentication configuration
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The UUID of the authentication configuration (for backward compatibility)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("uuid", Required = global::Newtonsoft.Json.Required.Always)]
        public string Uuid { get; set; } = default!;

        /// <summary>
        /// The type of the authentication configuration (custom or default)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.GetAuthConfigsResponseItemType Type { get; set; } = default!;

        /// <summary>
        /// Information about the associated integration
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("toolkit", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.GetAuthConfigsResponseItemToolkit Toolkit { get; set; } = default!;

        /// <summary>
        /// The display name of the authentication configuration
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The authentication scheme used (e.g., OAuth2, API Key, etc.)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("auth_scheme")]
        public global::G.GetAuthConfigsResponseItemAuthScheme? AuthScheme { get; set; }

        /// <summary>
        /// Whether this authentication configuration is managed by Composio or the user
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_composio_managed")]
        public bool? IsComposioManaged { get; set; }

        /// <summary>
        /// The authentication credentials (tokens, keys, etc.) - may be partially hidden for security
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("credentials")]
        public global::System.Collections.Generic.Dictionary<string, object?>? Credentials { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("proxy_config")]
        public global::G.GetAuthConfigsResponseItemProxyConfig? ProxyConfig { get; set; }

        /// <summary>
        /// Current status of the authentication configuration
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.GetAuthConfigsResponseItemStatus Status { get; set; } = default!;

        /// <summary>
        /// The identifier of the user who created the auth config
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_by")]
        public string? CreatedBy { get; set; }

        /// <summary>
        /// ISO 8601 date-time when the auth config was created
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// ISO 8601 date-time when the auth config was last updated
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_updated_at")]
        public string? LastUpdatedAt { get; set; }

        /// <summary>
        /// The number of active connections using this auth config
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("no_of_connections", Required = global::Newtonsoft.Json.Required.Always)]
        public double NoOfConnections { get; set; } = default!;

        /// <summary>
        /// Fields expected during connection initialization
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expected_input_fields")]
        public global::System.Collections.Generic.IList<object>? ExpectedInputFields { get; set; }

        /// <summary>
        /// Use tool_access_config instead. This field will be deprecated in the future.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("restrict_to_following_tools")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<string>? RestrictToFollowingTools { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_access_config", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.GetAuthConfigsResponseItemToolAccessConfig ToolAccessConfig { get; set; } = default!;

        /// <summary>
        /// [EXPERIMENTAL] Shared credentials that will be inherited by all connected accounts using this auth config
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("shared_credentials")]
        public global::System.Collections.Generic.Dictionary<string, object?>? SharedCredentials { get; set; }

        /// <summary>
        /// Whether this auth config is enabled for tool router
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_enabled_for_tool_router")]
        public bool? IsEnabledForToolRouter { get; set; }

        /// <summary>
        /// DEPRECATED: This parameter will be removed in a future version.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deprecated_params")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::G.GetAuthConfigsResponseItemDeprecatedParams? DeprecatedParams { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAuthConfigsResponseItem" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique ID of the authentication configuration
        /// </param>
        /// <param name="uuid">
        /// The UUID of the authentication configuration (for backward compatibility)
        /// </param>
        /// <param name="type">
        /// The type of the authentication configuration (custom or default)
        /// </param>
        /// <param name="toolkit">
        /// Information about the associated integration
        /// </param>
        /// <param name="name">
        /// The display name of the authentication configuration
        /// </param>
        /// <param name="status">
        /// Current status of the authentication configuration
        /// </param>
        /// <param name="noOfConnections">
        /// The number of active connections using this auth config
        /// </param>
        /// <param name="toolAccessConfig"></param>
        /// <param name="authScheme">
        /// The authentication scheme used (e.g., OAuth2, API Key, etc.)
        /// </param>
        /// <param name="isComposioManaged">
        /// Whether this authentication configuration is managed by Composio or the user
        /// </param>
        /// <param name="credentials">
        /// The authentication credentials (tokens, keys, etc.) - may be partially hidden for security
        /// </param>
        /// <param name="proxyConfig"></param>
        /// <param name="createdBy">
        /// The identifier of the user who created the auth config
        /// </param>
        /// <param name="createdAt">
        /// ISO 8601 date-time when the auth config was created
        /// </param>
        /// <param name="lastUpdatedAt">
        /// ISO 8601 date-time when the auth config was last updated
        /// </param>
        /// <param name="expectedInputFields">
        /// Fields expected during connection initialization
        /// </param>
        /// <param name="sharedCredentials">
        /// [EXPERIMENTAL] Shared credentials that will be inherited by all connected accounts using this auth config
        /// </param>
        /// <param name="isEnabledForToolRouter">
        /// Whether this auth config is enabled for tool router
        /// </param>
        public GetAuthConfigsResponseItem(
            string id,
            string uuid,
            global::G.GetAuthConfigsResponseItemType type,
            global::G.GetAuthConfigsResponseItemToolkit toolkit,
            string name,
            global::G.GetAuthConfigsResponseItemStatus status,
            double noOfConnections,
            global::G.GetAuthConfigsResponseItemToolAccessConfig toolAccessConfig,
            global::G.GetAuthConfigsResponseItemAuthScheme? authScheme,
            bool? isComposioManaged,
            global::System.Collections.Generic.Dictionary<string, object?>? credentials,
            global::G.GetAuthConfigsResponseItemProxyConfig? proxyConfig,
            string? createdBy,
            string? createdAt,
            string? lastUpdatedAt,
            global::System.Collections.Generic.IList<object>? expectedInputFields,
            global::System.Collections.Generic.Dictionary<string, object?>? sharedCredentials,
            bool? isEnabledForToolRouter)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Uuid = uuid ?? throw new global::System.ArgumentNullException(nameof(uuid));
            this.Type = type;
            this.Toolkit = toolkit ?? throw new global::System.ArgumentNullException(nameof(toolkit));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.AuthScheme = authScheme;
            this.IsComposioManaged = isComposioManaged;
            this.Credentials = credentials;
            this.ProxyConfig = proxyConfig;
            this.Status = status;
            this.CreatedBy = createdBy;
            this.CreatedAt = createdAt;
            this.LastUpdatedAt = lastUpdatedAt;
            this.NoOfConnections = noOfConnections;
            this.ExpectedInputFields = expectedInputFields;
            this.ToolAccessConfig = toolAccessConfig ?? throw new global::System.ArgumentNullException(nameof(toolAccessConfig));
            this.SharedCredentials = sharedCredentials;
            this.IsEnabledForToolRouter = isEnabledForToolRouter;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAuthConfigsResponseItem" /> class.
        /// </summary>
        public GetAuthConfigsResponseItem()
        {
        }
    }
}