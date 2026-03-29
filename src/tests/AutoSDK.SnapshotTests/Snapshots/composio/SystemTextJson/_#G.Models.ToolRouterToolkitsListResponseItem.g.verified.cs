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
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Unique slug identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        /// Whether the toolkit is enabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// Whether the toolkit is no-auth
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_no_auth")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsNoAuth { get; set; }

        /// <summary>
        /// Available Composio-managed auth schemes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("composio_managed_auth_schemes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> ComposioManagedAuthSchemes { get; set; }

        /// <summary>
        /// Toolkit metadata
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ToolRouterToolkitsListResponseItemMeta Meta { get; set; }

        /// <summary>
        /// Connected account if available
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connected_account")]
        public global::G.ToolRouterToolkitsListResponseItemConnectedAccount? ConnectedAccount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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