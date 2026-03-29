//HintName: G.Models.PostToolkitsMultiResponseItem.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Detailed information about a toolkit
    /// </summary>
    public sealed partial class PostToolkitsMultiResponseItem
    {
        /// <summary>
        /// URL-friendly unique identifier for the toolkit<br/>
        /// Example: github
        /// </summary>
        /// <example>github</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        /// Human-readable name of the toolkit<br/>
        /// Example: GitHub
        /// </summary>
        /// <example>GitHub</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// List of authentication methods supported by this toolkit<br/>
        /// Example: [oauth2, api_key]
        /// </summary>
        /// <example>[oauth2, api_key]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_schemes")]
        public global::System.Collections.Generic.IList<string>? AuthSchemes { get; set; }

        /// <summary>
        /// List of authentication methods that Composio manages for this toolkit<br/>
        /// Example: [oauth2]
        /// </summary>
        /// <example>[oauth2]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("composio_managed_auth_schemes")]
        public global::System.Collections.Generic.IList<string>? ComposioManagedAuthSchemes { get; set; }

        /// <summary>
        /// DEPRECATED: This field is no longer meaningful and will always return false. It was previously used to indicate if a toolkit is specific to the current project.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_local_toolkit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsLocalToolkit { get; set; }

        /// <summary>
        /// When true, this toolkit can be used without authentication<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("no_auth")]
        public bool? NoAuth { get; set; }

        /// <summary>
        /// URL to a guide page with authentication setup instructions for this toolkit<br/>
        /// Example: https://composio.dev/auth/github
        /// </summary>
        /// <example>https://composio.dev/auth/github</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_guide_url")]
        public string? AuthGuideUrl { get; set; }

        /// <summary>
        /// Deprecated toolkit ID<br/>
        /// Example: {"toolkitId":"550e8400-e29b-41d4-a716-446655440000"}
        /// </summary>
        /// <example>{"toolkitId":"550e8400-e29b-41d4-a716-446655440000"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("deprecated")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.DeprecatedToolkitInfo Deprecated { get; set; }

        /// <summary>
        /// Additional metadata about the toolkit
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PostToolkitsMultiResponseItemMeta Meta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolkitsMultiResponseItem" /> class.
        /// </summary>
        /// <param name="slug">
        /// URL-friendly unique identifier for the toolkit<br/>
        /// Example: github
        /// </param>
        /// <param name="name">
        /// Human-readable name of the toolkit<br/>
        /// Example: GitHub
        /// </param>
        /// <param name="isLocalToolkit">
        /// DEPRECATED: This field is no longer meaningful and will always return false. It was previously used to indicate if a toolkit is specific to the current project.<br/>
        /// Example: false
        /// </param>
        /// <param name="deprecated">
        /// Deprecated toolkit ID<br/>
        /// Example: {"toolkitId":"550e8400-e29b-41d4-a716-446655440000"}
        /// </param>
        /// <param name="meta">
        /// Additional metadata about the toolkit
        /// </param>
        /// <param name="authSchemes">
        /// List of authentication methods supported by this toolkit<br/>
        /// Example: [oauth2, api_key]
        /// </param>
        /// <param name="composioManagedAuthSchemes">
        /// List of authentication methods that Composio manages for this toolkit<br/>
        /// Example: [oauth2]
        /// </param>
        /// <param name="noAuth">
        /// When true, this toolkit can be used without authentication<br/>
        /// Example: false
        /// </param>
        /// <param name="authGuideUrl">
        /// URL to a guide page with authentication setup instructions for this toolkit<br/>
        /// Example: https://composio.dev/auth/github
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostToolkitsMultiResponseItem(
            string slug,
            string name,
            bool isLocalToolkit,
            global::G.DeprecatedToolkitInfo deprecated,
            global::G.PostToolkitsMultiResponseItemMeta meta,
            global::System.Collections.Generic.IList<string>? authSchemes,
            global::System.Collections.Generic.IList<string>? composioManagedAuthSchemes,
            bool? noAuth,
            string? authGuideUrl)
        {
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.AuthSchemes = authSchemes;
            this.ComposioManagedAuthSchemes = composioManagedAuthSchemes;
            this.IsLocalToolkit = isLocalToolkit;
            this.NoAuth = noAuth;
            this.AuthGuideUrl = authGuideUrl;
            this.Deprecated = deprecated ?? throw new global::System.ArgumentNullException(nameof(deprecated));
            this.Meta = meta ?? throw new global::System.ArgumentNullException(nameof(meta));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolkitsMultiResponseItem" /> class.
        /// </summary>
        public PostToolkitsMultiResponseItem()
        {
        }
    }
}