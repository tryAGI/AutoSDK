//HintName: G.Models.GetToolkitsBySlugResponseAuthConfigDetailDeprecatedAuthProviderDetails.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Authentication URL fields for OAuth 2.0 and OAuth 1.0. We don't recommend using this field for authentication and might break post Aug 31 2025.
    /// </summary>
    [global::System.Obsolete("This model marked as deprecated.")]
    public sealed partial class GetToolkitsBySlugResponseAuthConfigDetailDeprecatedAuthProviderDetails
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authorization_url")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? AuthorizationUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_url")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? TokenUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetToolkitsBySlugResponseAuthConfigDetailDeprecatedAuthProviderDetails" /> class.
        /// </summary>
        /// <param name="authorizationUrl"></param>
        /// <param name="tokenUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetToolkitsBySlugResponseAuthConfigDetailDeprecatedAuthProviderDetails(
            string? authorizationUrl,
            string? tokenUrl)
        {
            this.AuthorizationUrl = authorizationUrl;
            this.TokenUrl = tokenUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetToolkitsBySlugResponseAuthConfigDetailDeprecatedAuthProviderDetails" /> class.
        /// </summary>
        public GetToolkitsBySlugResponseAuthConfigDetailDeprecatedAuthProviderDetails()
        {
        }
    }
}