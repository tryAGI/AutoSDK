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
        [global::Newtonsoft.Json.JsonProperty("policy", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.PolicyItem> Policy { get; set; } = default!;

        /// <summary>
        /// The hostname of the client side application. Please specify the full URL including the protocol (http or https).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hostname", Required = global::Newtonsoft.Json.Required.Always)]
        public string Hostname { get; set; } = default!;

        /// <summary>
        /// The expiration date of the token. If not provided, the token will expire in 5 minutes
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expires_at")]
        public string? ExpiresAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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