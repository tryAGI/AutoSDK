//HintName: G.Models.OAuthAuthorizeResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OAuthAuthorizeResponse
    {
        /// <summary>
        /// The OAuth 2.0 redirect url. Redirect the user to this url to authorize the connector.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redirect_url")]
        public string? RedirectUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OAuthAuthorizeResponse" /> class.
        /// </summary>
        /// <param name="redirectUrl">
        /// The OAuth 2.0 redirect url. Redirect the user to this url to authorize the connector.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public OAuthAuthorizeResponse(
            string? redirectUrl)
        {
            this.RedirectUrl = redirectUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OAuthAuthorizeResponse" /> class.
        /// </summary>
        public OAuthAuthorizeResponse()
        {
        }
    }
}