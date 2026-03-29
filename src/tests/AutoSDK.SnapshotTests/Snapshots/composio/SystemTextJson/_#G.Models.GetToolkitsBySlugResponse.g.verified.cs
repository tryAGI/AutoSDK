//HintName: G.Models.GetToolkitsBySlugResponse.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Detailed information about a single toolkit
    /// </summary>
    public sealed partial class GetToolkitsBySlugResponse
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
        /// Indicates if this toolkit is currently enabled and available for use<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

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
        /// Complete authentication configuration details for each supported auth method
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_config_details")]
        public global::System.Collections.Generic.IList<global::G.GetToolkitsBySlugResponseAuthConfigDetail>? AuthConfigDetails { get; set; }

        /// <summary>
        /// URL to a guide page with authentication setup instructions for this toolkit<br/>
        /// Example: https://composio.dev/auth/github
        /// </summary>
        /// <example>https://composio.dev/auth/github</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_guide_url")]
        public string? AuthGuideUrl { get; set; }

        /// <summary>
        /// If evaluation of base URL needs some connection info (like shopify), please create the connection and get the base URL from there<br/>
        /// Example: https://api.github.com
        /// </summary>
        /// <example>https://api.github.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_url")]
        public string? BaseUrl { get; set; }

        /// <summary>
        /// Comprehensive metadata for the toolkit including dates, descriptions, and statistics
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GetToolkitsBySlugResponseMeta Meta { get; set; }

        /// <summary>
        /// Endpoint to get the current user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("get_current_user_endpoint")]
        public string? GetCurrentUserEndpoint { get; set; }

        /// <summary>
        /// HTTP method to use when calling the get current user endpoint (e.g., GET, POST)<br/>
        /// Example: GET
        /// </summary>
        /// <example>GET</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("get_current_user_endpoint_method")]
        public string? GetCurrentUserEndpointMethod { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deprecated")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GetToolkitsBySlugResponseDeprecated Deprecated { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetToolkitsBySlugResponse" /> class.
        /// </summary>
        /// <param name="slug">
        /// URL-friendly unique identifier for the toolkit<br/>
        /// Example: github
        /// </param>
        /// <param name="name">
        /// Human-readable name of the toolkit<br/>
        /// Example: GitHub
        /// </param>
        /// <param name="enabled">
        /// Indicates if this toolkit is currently enabled and available for use<br/>
        /// Example: true
        /// </param>
        /// <param name="isLocalToolkit">
        /// DEPRECATED: This field is no longer meaningful and will always return false. It was previously used to indicate if a toolkit is specific to the current project.<br/>
        /// Example: false
        /// </param>
        /// <param name="meta">
        /// Comprehensive metadata for the toolkit including dates, descriptions, and statistics
        /// </param>
        /// <param name="deprecated"></param>
        /// <param name="composioManagedAuthSchemes">
        /// List of authentication methods that Composio manages for this toolkit<br/>
        /// Example: [oauth2]
        /// </param>
        /// <param name="authConfigDetails">
        /// Complete authentication configuration details for each supported auth method
        /// </param>
        /// <param name="authGuideUrl">
        /// URL to a guide page with authentication setup instructions for this toolkit<br/>
        /// Example: https://composio.dev/auth/github
        /// </param>
        /// <param name="baseUrl">
        /// If evaluation of base URL needs some connection info (like shopify), please create the connection and get the base URL from there<br/>
        /// Example: https://api.github.com
        /// </param>
        /// <param name="getCurrentUserEndpoint">
        /// Endpoint to get the current user
        /// </param>
        /// <param name="getCurrentUserEndpointMethod">
        /// HTTP method to use when calling the get current user endpoint (e.g., GET, POST)<br/>
        /// Example: GET
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetToolkitsBySlugResponse(
            string slug,
            string name,
            bool enabled,
            bool isLocalToolkit,
            global::G.GetToolkitsBySlugResponseMeta meta,
            global::G.GetToolkitsBySlugResponseDeprecated deprecated,
            global::System.Collections.Generic.IList<string>? composioManagedAuthSchemes,
            global::System.Collections.Generic.IList<global::G.GetToolkitsBySlugResponseAuthConfigDetail>? authConfigDetails,
            string? authGuideUrl,
            string? baseUrl,
            string? getCurrentUserEndpoint,
            string? getCurrentUserEndpointMethod)
        {
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Enabled = enabled;
            this.ComposioManagedAuthSchemes = composioManagedAuthSchemes;
            this.IsLocalToolkit = isLocalToolkit;
            this.AuthConfigDetails = authConfigDetails;
            this.AuthGuideUrl = authGuideUrl;
            this.BaseUrl = baseUrl;
            this.Meta = meta ?? throw new global::System.ArgumentNullException(nameof(meta));
            this.GetCurrentUserEndpoint = getCurrentUserEndpoint;
            this.GetCurrentUserEndpointMethod = getCurrentUserEndpointMethod;
            this.Deprecated = deprecated ?? throw new global::System.ArgumentNullException(nameof(deprecated));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetToolkitsBySlugResponse" /> class.
        /// </summary>
        public GetToolkitsBySlugResponse()
        {
        }
    }
}