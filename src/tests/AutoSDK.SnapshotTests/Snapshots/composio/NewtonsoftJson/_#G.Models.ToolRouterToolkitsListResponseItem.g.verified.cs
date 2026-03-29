//HintName: G.Models.ToolRouterToolkitsListResponseItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolRouterToolkitsListResponseItem
    {
        /// <summary>
        /// Display name of the toolkit
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Unique slug identifier
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("slug", Required = global::Newtonsoft.Json.Required.Always)]
        public string Slug { get; set; } = default!;

        /// <summary>
        /// Whether the toolkit is enabled
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enabled", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Enabled { get; set; } = default!;

        /// <summary>
        /// Whether the toolkit is no-auth
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_no_auth", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsNoAuth { get; set; } = default!;

        /// <summary>
        /// Available Composio-managed auth schemes
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("composio_managed_auth_schemes", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> ComposioManagedAuthSchemes { get; set; } = default!;

        /// <summary>
        /// Toolkit metadata
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("meta", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ToolRouterToolkitsListResponseItemMeta Meta { get; set; } = default!;

        /// <summary>
        /// Connected account if available
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("connected_account")]
        public global::G.ToolRouterToolkitsListResponseItemConnectedAccount? ConnectedAccount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolRouterToolkitsListResponseItem" /> class.
        /// </summary>
        /// <param name="name">
        /// Display name of the toolkit
        /// </param>
        /// <param name="slug">
        /// Unique slug identifier
        /// </param>
        /// <param name="enabled">
        /// Whether the toolkit is enabled
        /// </param>
        /// <param name="isNoAuth">
        /// Whether the toolkit is no-auth
        /// </param>
        /// <param name="composioManagedAuthSchemes">
        /// Available Composio-managed auth schemes
        /// </param>
        /// <param name="meta">
        /// Toolkit metadata
        /// </param>
        /// <param name="connectedAccount">
        /// Connected account if available
        /// </param>
        public ToolRouterToolkitsListResponseItem(
            string name,
            string slug,
            bool enabled,
            bool isNoAuth,
            global::System.Collections.Generic.IList<string> composioManagedAuthSchemes,
            global::G.ToolRouterToolkitsListResponseItemMeta meta,
            global::G.ToolRouterToolkitsListResponseItemConnectedAccount? connectedAccount)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.Enabled = enabled;
            this.IsNoAuth = isNoAuth;
            this.ComposioManagedAuthSchemes = composioManagedAuthSchemes ?? throw new global::System.ArgumentNullException(nameof(composioManagedAuthSchemes));
            this.Meta = meta ?? throw new global::System.ArgumentNullException(nameof(meta));
            this.ConnectedAccount = connectedAccount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolRouterToolkitsListResponseItem" /> class.
        /// </summary>
        public ToolRouterToolkitsListResponseItem()
        {
        }
    }
}