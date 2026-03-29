//HintName: G.Models.DataSourceOAuth2Params.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Authentication parameters for a OAuth data source.
    /// </summary>
    public sealed partial class DataSourceOAuth2Params
    {
        /// <summary>
        /// Default Value: oauth2
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The timestamp when the OAuth2 credentials were created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// The OAuth2 scope<br/>
        /// Default Value: read
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        public string? Scope { get; set; }

        /// <summary>
        /// The OAuth2 access token
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_token")]
        public string? AccessToken { get; set; }

        /// <summary>
        /// The OAuth2 refresh token
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("refresh_token")]
        public string? RefreshToken { get; set; }

        /// <summary>
        /// The OAuth2 token type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_type")]
        public string? TokenType { get; set; }

        /// <summary>
        /// The OAuth2 token expiration timestamp
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_on")]
        public global::System.DateTime? ExpiresOn { get; set; }

        /// <summary>
        /// Additional parameters for the OAuth2 flow
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("additional_params")]
        public object? AdditionalParams { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DataSourceOAuth2Params" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: oauth2
        /// </param>
        /// <param name="createdAt">
        /// The timestamp when the OAuth2 credentials were created
        /// </param>
        /// <param name="scope">
        /// The OAuth2 scope<br/>
        /// Default Value: read
        /// </param>
        /// <param name="accessToken">
        /// The OAuth2 access token
        /// </param>
        /// <param name="refreshToken">
        /// The OAuth2 refresh token
        /// </param>
        /// <param name="tokenType">
        /// The OAuth2 token type
        /// </param>
        /// <param name="expiresOn">
        /// The OAuth2 token expiration timestamp
        /// </param>
        /// <param name="additionalParams">
        /// Additional parameters for the OAuth2 flow
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DataSourceOAuth2Params(
            string? type,
            global::System.DateTime? createdAt,
            string? scope,
            string? accessToken,
            string? refreshToken,
            string? tokenType,
            global::System.DateTime? expiresOn,
            object? additionalParams)
        {
            this.Type = type;
            this.CreatedAt = createdAt;
            this.Scope = scope;
            this.AccessToken = accessToken;
            this.RefreshToken = refreshToken;
            this.TokenType = tokenType;
            this.ExpiresOn = expiresOn;
            this.AdditionalParams = additionalParams;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataSourceOAuth2Params" /> class.
        /// </summary>
        public DataSourceOAuth2Params()
        {
        }
    }
}