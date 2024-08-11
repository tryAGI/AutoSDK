//HintName: G.Models.AccountGetResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AccountGetResponse
    {
        /// <summary>
        /// The GitHub URL of the account.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("github_url")]
        public string? GithubUrl { get; set; }

        /// <summary>
        /// The name of the account.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The account type. Can be a user or an organization.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.AccountGetResponseType? Type { get; set; }

        /// <summary>
        /// The username of the account.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("username")]
        public string? Username { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}