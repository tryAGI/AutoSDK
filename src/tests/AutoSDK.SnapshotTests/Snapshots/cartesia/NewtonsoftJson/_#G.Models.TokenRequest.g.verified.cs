//HintName: G.Models.TokenRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TokenRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("grants")]
        public global::G.TokenGrant? Grants { get; set; }

        /// <summary>
        /// The number of seconds the token will be valid for since the time of generation. The maximum is 1 hour (3600 seconds).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expires_in")]
        public int? ExpiresIn { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenRequest" /> class.
        /// </summary>
        /// <param name="grants"></param>
        /// <param name="expiresIn">
        /// The number of seconds the token will be valid for since the time of generation. The maximum is 1 hour (3600 seconds).
        /// </param>
        public TokenRequest(
            global::G.TokenGrant? grants,
            int? expiresIn)
        {
            this.Grants = grants;
            this.ExpiresIn = expiresIn;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenRequest" /> class.
        /// </summary>
        public TokenRequest()
        {
        }
    }
}