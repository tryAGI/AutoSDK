//HintName: G.Models.PostConnectedAccountsRequestConnectionStateVariant2ValVariant3AuthedUser.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// for slack user scopes
    /// </summary>
    public sealed partial class PostConnectedAccountsRequestConnectionStateVariant2ValVariant3AuthedUser
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("access_token")]
        public string? AccessToken { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("scope")]
        public string? Scope { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostConnectedAccountsRequestConnectionStateVariant2ValVariant3AuthedUser" /> class.
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="scope"></param>
        public PostConnectedAccountsRequestConnectionStateVariant2ValVariant3AuthedUser(
            string? accessToken,
            string? scope)
        {
            this.AccessToken = accessToken;
            this.Scope = scope;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostConnectedAccountsRequestConnectionStateVariant2ValVariant3AuthedUser" /> class.
        /// </summary>
        public PostConnectedAccountsRequestConnectionStateVariant2ValVariant3AuthedUser()
        {
        }
    }
}