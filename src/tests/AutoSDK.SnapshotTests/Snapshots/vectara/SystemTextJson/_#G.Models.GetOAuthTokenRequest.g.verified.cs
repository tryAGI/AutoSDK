//HintName: G.Models.GetOAuthTokenRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetOAuthTokenRequest
    {
        /// <summary>
        /// The client ID of the application
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClientId { get; set; }

        /// <summary>
        /// The client secret of the application
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_secret")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClientSecret { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("grant_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object GrantType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOAuthTokenRequest" /> class.
        /// </summary>
        /// <param name="clientId">
        /// The client ID of the application
        /// </param>
        /// <param name="clientSecret">
        /// The client secret of the application
        /// </param>
        /// <param name="grantType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetOAuthTokenRequest(
            string clientId,
            string clientSecret,
            object grantType)
        {
            this.ClientId = clientId ?? throw new global::System.ArgumentNullException(nameof(clientId));
            this.ClientSecret = clientSecret ?? throw new global::System.ArgumentNullException(nameof(clientSecret));
            this.GrantType = grantType ?? throw new global::System.ArgumentNullException(nameof(grantType));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOAuthTokenRequest" /> class.
        /// </summary>
        public GetOAuthTokenRequest()
        {
        }
    }
}