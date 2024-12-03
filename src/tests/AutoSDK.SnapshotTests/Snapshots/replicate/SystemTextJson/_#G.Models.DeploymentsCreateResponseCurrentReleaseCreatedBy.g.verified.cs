//HintName: G.Models.DeploymentsCreateResponseCurrentReleaseCreatedBy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeploymentsCreateResponseCurrentReleaseCreatedBy
    {
        /// <summary>
        /// The GitHub URL of the account that created the release.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("github_url")]
        public string? GithubUrl { get; set; }

        /// <summary>
        /// The name of the account that created the release.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The account type of the creator. Can be a user or an organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.DeploymentsCreateResponseCurrentReleaseCreatedByTypeJsonConverter))]
        public global::G.DeploymentsCreateResponseCurrentReleaseCreatedByType? Type { get; set; }

        /// <summary>
        /// The username of the account that created the release.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        public string? Username { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentsCreateResponseCurrentReleaseCreatedBy" /> class.
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
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public DeploymentsCreateResponseCurrentReleaseCreatedBy(
            string? githubUrl,
            string? name,
            global::G.DeploymentsCreateResponseCurrentReleaseCreatedByType? type,
            string? username)
        {
            this.GithubUrl = githubUrl;
            this.Name = name;
            this.Type = type;
            this.Username = username;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentsCreateResponseCurrentReleaseCreatedBy" /> class.
        /// </summary>
        public DeploymentsCreateResponseCurrentReleaseCreatedBy()
        {
        }
    }
}