//HintName: G.Models.GetConnectedAccountsResponseItemStateVariant2ValVariant4AuthedUser.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// for slack user scopes
    /// </summary>
    public sealed partial class GetConnectedAccountsResponseItemStateVariant2ValVariant4AuthedUser
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
        /// Initializes a new instance of the <see cref="GetConnectedAccountsResponseItemStateVariant2ValVariant4AuthedUser" /> class.
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="scope"></param>
        public GetConnectedAccountsResponseItemStateVariant2ValVariant4AuthedUser(
            string? accessToken,
            string? scope)
        {
            this.AccessToken = accessToken;
            this.Scope = scope;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConnectedAccountsResponseItemStateVariant2ValVariant4AuthedUser" /> class.
        /// </summary>
        public GetConnectedAccountsResponseItemStateVariant2ValVariant4AuthedUser()
        {
        }
    }
}