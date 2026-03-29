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
        [global::Newtonsoft.Json.JsonProperty("policy", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicy Policy { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("token", Required = global::Newtonsoft.Json.Required.Always)]
        public string Token { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hostname", Required = global::Newtonsoft.Json.Required.Always)]
        public string Hostname { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expiresAt", Required = global::Newtonsoft.Json.Required.Always)]
        public string ExpiresAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientSideAccessTokensListClientSideAccessTokensResponseToken" /> class.
        /// </summary>
        /// <param name="policy"></param>
        /// <param name="token"></param>
        /// <param name="hostname"></param>
        /// <param name="expiresAt"></param>
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