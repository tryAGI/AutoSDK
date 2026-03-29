//HintName: G.Models.ClientSideAccessTokensCreateClientSideAccessTokenRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ClientSideAccessTokensCreateClientSideAccessTokenRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("policy")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.PolicyItem> Policy { get; set; }

        /// <summary>
        /// The hostname of the client side application. Please specify the full URL including the protocol (http or https).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hostname")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Hostname { get; set; }

        /// <summary>
        /// The expiration date of the token. If not provided, the token will expire in 5 minutes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public string? ExpiresAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientSideAccessTokensCreateClientSideAccessTokenRequest" /> class.
        /// </summary>
        /// <param name="policy"></param>
        /// <param name="hostname">
        /// The hostname of the client side application. Please specify the full URL including the protocol (http or https).
        /// </param>
        /// <param name="expiresAt">
        /// The expiration date of the token. If not provided, the token will expire in 5 minutes
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClientSideAccessTokensCreateClientSideAccessTokenRequest(
            global::System.Collections.Generic.IList<global::G.PolicyItem> policy,
            string hostname,
            string? expiresAt)
        {
            this.Policy = policy ?? throw new global::System.ArgumentNullException(nameof(policy));
            this.Hostname = hostname ?? throw new global::System.ArgumentNullException(nameof(hostname));
            this.ExpiresAt = expiresAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientSideAccessTokensCreateClientSideAccessTokenRequest" /> class.
        /// </summary>
        public ClientSideAccessTokensCreateClientSideAccessTokenRequest()
        {
        }
    }
}