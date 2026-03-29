//HintName: G.Models.ClientSideAccessTokensListClientSideAccessTokensResponseToken.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ClientSideAccessTokensListClientSideAccessTokensResponseToken
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("policy")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicy Policy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Token { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hostname")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Hostname { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiresAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExpiresAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientSideAccessTokensListClientSideAccessTokensResponseToken" /> class.
        /// </summary>
        /// <param name="policy"></param>
        /// <param name="token"></param>
        /// <param name="hostname"></param>
        /// <param name="expiresAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClientSideAccessTokensListClientSideAccessTokensResponseToken(
            global::G.ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicy policy,
            string token,
            string hostname,
            string expiresAt)
        {
            this.Policy = policy ?? throw new global::System.ArgumentNullException(nameof(policy));
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
            this.Hostname = hostname ?? throw new global::System.ArgumentNullException(nameof(hostname));
            this.ExpiresAt = expiresAt ?? throw new global::System.ArgumentNullException(nameof(expiresAt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientSideAccessTokensListClientSideAccessTokensResponseToken" /> class.
        /// </summary>
        public ClientSideAccessTokensListClientSideAccessTokensResponseToken()
        {
        }
    }
}