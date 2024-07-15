//HintName: G.Models.SecretScanningLocationPullRequestReviewComment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Represents a 'pull_request_review_comment' secret scanning location type. This location type shows that a secret was detected in a review comment on a pull request.
    /// </summary>
    public sealed partial class SecretScanningLocationPullRequestReviewComment
    {
        /// <summary>
        /// The API URL to get the pull request review comment where the secret was detected.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/pulls/comments/12
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pull_request_review_comment_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string PullRequestReviewCommentUrl { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}