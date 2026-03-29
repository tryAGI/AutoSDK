//HintName: G.Models.InvokeApiMcpAuth2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InvokeApiMcpAuth2
    {
        /// <summary>
        /// The OAuth token to use
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("oauth_token")]
        public string? OauthToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InvokeApiMcpAuth2" /> class.
        /// </summary>
        /// <param name="oauthToken">
        /// The OAuth token to use
        /// </param>
        public InvokeApiMcpAuth2(
            string? oauthToken)
        {
            this.OauthToken = oauthToken;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvokeApiMcpAuth2" /> class.
        /// </summary>
        public InvokeApiMcpAuth2()
        {
        }
    }
}