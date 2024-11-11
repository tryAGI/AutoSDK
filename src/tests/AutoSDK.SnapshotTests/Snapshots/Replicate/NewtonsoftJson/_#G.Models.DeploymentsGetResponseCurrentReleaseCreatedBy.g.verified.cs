//HintName: G.Models.DeploymentsGetResponseCurrentReleaseCreatedBy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeploymentsGetResponseCurrentReleaseCreatedBy
    {
        /// <summary>
        /// The GitHub URL of the account that created the release.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("github_url")]
        public string? GithubUrl { get; set; }

        /// <summary>
        /// The name of the account that created the release.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The account type of the creator. Can be a user or an organization.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.DeploymentsGetResponseCurrentReleaseCreatedByType? Type { get; set; }

        /// <summary>
        /// The username of the account that created the release.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("username")]
        public string? Username { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentsGetResponseCurrentReleaseCreatedBy" /> class.
        /// </summary>
        /// <param name="githubUrl">
        /// The GitHub URL of the account that created the release.
        /// </param>
        /// <param name="name">
        /// The name of the account that created the release.
        /// </param>
        /// <param name="type">
        /// The account type of the creator. Can be a user or an organization.
        /// </param>
        /// <param name="username">
        /// The username of the account that created the release.
        /// </param>
        public DeploymentsGetResponseCurrentReleaseCreatedBy(
            string? githubUrl,
            string? name,
            global::G.DeploymentsGetResponseCurrentReleaseCreatedByType? type,
            string? username)
        {
            this.GithubUrl = githubUrl;
            this.Name = name;
            this.Type = type;
            this.Username = username;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentsGetResponseCurrentReleaseCreatedBy" /> class.
        /// </summary>
        public DeploymentsGetResponseCurrentReleaseCreatedBy()
        {
        }
    }
}