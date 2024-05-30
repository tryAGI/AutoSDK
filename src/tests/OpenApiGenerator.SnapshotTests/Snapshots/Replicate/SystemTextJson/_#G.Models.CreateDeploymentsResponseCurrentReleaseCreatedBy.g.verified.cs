//HintName: G.Models.CreateDeploymentsResponseCurrentReleaseCreatedBy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDeploymentsResponseCurrentReleaseCreatedBy
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.CreateDeploymentsResponseCurrentReleaseCreatedByTypeJsonConverter))]
        public CreateDeploymentsResponseCurrentReleaseCreatedByType? Type { get; set; }

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
    }
}