//HintName: G.Models.CodespacesCreateForAuthenticatedUserRequestVariant2PullRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Pull request number for this codespace
    /// </summary>
    public sealed partial class CodespacesCreateForAuthenticatedUserRequestVariant2PullRequest
    {
        /// <summary>
        /// Pull request number
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pull_request_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PullRequestNumber { get; set; }

        /// <summary>
        /// Repository id for this codespace
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RepositoryId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodespacesCreateForAuthenticatedUserRequestVariant2PullRequest" /> class.
        /// </summary>
        /// <param name="pullRequestNumber">
        /// Pull request number
        /// </param>
        /// <param name="repositoryId">
        /// Repository id for this codespace
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CodespacesCreateForAuthenticatedUserRequestVariant2PullRequest(
            int pullRequestNumber,
            int repositoryId)
        {
            this.PullRequestNumber = pullRequestNumber;
            this.RepositoryId = repositoryId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodespacesCreateForAuthenticatedUserRequestVariant2PullRequest" /> class.
        /// </summary>
        public CodespacesCreateForAuthenticatedUserRequestVariant2PullRequest()
        {
        }
    }
}