//HintName: G.Models.GetToolkitsBySlugResponseAuthConfigDetail.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Detailed configuration for an authentication method
    /// </summary>
    public sealed partial class GetToolkitsBySlugResponseAuthConfigDetail
    {
        /// <summary>
        /// The type of authentication mode (e.g., oauth2, basic_auth, api_key)<br/>
        /// Example: oauth2
        /// </summary>
        /// <example>oauth2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Mode { get; set; }

        /// <summary>
        /// Field groups required for different authentication stages
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fields")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GetToolkitsBySlugResponseAuthConfigDetailFields Fields { get; set; }

        /// <summary>
        /// Configuration for proxying authentication requests to external services
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("proxy")]
        public global::G.GetToolkitsBySlugResponseAuthConfigDetailProxy? Proxy { get; set; }

        /// <summary>
        /// Display name for this authentication method<br/>
        /// Example: OAuth 2.0
        /// </summary>
        /// <example>OAuth 2.0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// URL to a page where users can obtain or configure credentials for this authentication method<br/>
        /// Example: https://github.com/settings/tokens
        /// </summary>
        /// <example>https://github.com/settings/tokens</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_hint_url")]
        public string? AuthHintUrl { get; set; }

        /// <summary>
        /// Authentication URL fields for OAuth 2.0 and OAuth 1.0. We don't recommend using this field for authentication and might break post Aug 31 2025.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deprecated_auth_provider_details")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::G.GetToolkitsBySlugResponseAuthConfigDetailDeprecatedAuthProviderDetails? DeprecatedAuthProviderDetails { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetToolkitsBySlugResponseAuthConfigDetail" /> class.
        /// </summary>
        /// <param name="mode">
        /// The type of authentication mode (e.g., oauth2, basic_auth, api_key)<br/>
        /// Example: oauth2
        /// </param>
        /// <param name="fields">
        /// Field groups required for different authentication stages
        /// </param>
        /// <param name="name">
        /// Display name for this authentication method<br/>
        /// Example: OAuth 2.0
        /// </param>
        /// <param name="proxy">
        /// Configuration for proxying authentication requests to external services
        /// </param>
        /// <param name="authHintUrl">
        /// URL to a page where users can obtain or configure credentials for this authentication method<br/>
        /// Example: https://github.com/settings/tokens
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetToolkitsBySlugResponseAuthConfigDetail(
            string mode,
            global::G.GetToolkitsBySlugResponseAuthConfigDetailFields fields,
            string name,
            global::G.GetToolkitsBySlugResponseAuthConfigDetailProxy? proxy,
            string? authHintUrl)
        {
            this.Mode = mode ?? throw new global::System.ArgumentNullException(nameof(mode));
            this.Fields = fields ?? throw new global::System.ArgumentNullException(nameof(fields));
            this.Proxy = proxy;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.AuthHintUrl = authHintUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetToolkitsBySlugResponseAuthConfigDetail" /> class.
        /// </summary>
        public GetToolkitsBySlugResponseAuthConfigDetail()
        {
        }
    }
}