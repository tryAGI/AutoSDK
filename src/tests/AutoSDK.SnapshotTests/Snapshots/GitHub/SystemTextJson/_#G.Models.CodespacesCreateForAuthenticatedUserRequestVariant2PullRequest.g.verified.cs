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
    }
}