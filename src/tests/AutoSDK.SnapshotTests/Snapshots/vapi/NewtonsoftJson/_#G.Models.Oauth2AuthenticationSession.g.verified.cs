//HintName: G.Models.Oauth2AuthenticationSession.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Oauth2AuthenticationSession
    {
        /// <summary>
        /// This is the OAuth2 access token.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("accessToken")]
        public string? AccessToken { get; set; }

        /// <summary>
        /// This is the OAuth2 access token expiration.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expiresAt")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// This is the OAuth2 refresh token.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("refreshToken")]
        public string? RefreshToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Oauth2AuthenticationSession" /> class.
        /// </summary>
        /// <param name="accessToken">
        /// This is the OAuth2 access token.
        /// </param>
        /// <param name="expiresAt">
        /// This is the OAuth2 access token expiration.
        /// </param>
        /// <param name="refreshToken">
        /// This is the OAuth2 refresh token.
        /// </param>
        public Oauth2AuthenticationSession(
            string? accessToken,
            global::System.DateTime? expiresAt,
            string? refreshToken)
        {
            this.AccessToken = accessToken;
            this.ExpiresAt = expiresAt;
            this.RefreshToken = refreshToken;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Oauth2AuthenticationSession" /> class.
        /// </summary>
        public Oauth2AuthenticationSession()
        {
        }
    }
}