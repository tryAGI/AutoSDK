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
        /// <example>https://api.github.com/repos/octocat/Hello-World/pulls/comments/12</example>
        [global::Newtonsoft.Json.JsonProperty("pull_request_review_comment_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string PullRequestReviewCommentUrl { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretScanningLocationPullRequestReviewComment" /> class.
        /// </summary>
        /// <param name="pullRequestReviewCommentUrl">
        /// The API URL to get the pull request review comment where the secret was detected.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/pulls/comments/12
        /// </param>
        public SecretScanningLocationPullRequestReviewComment(
            string pullRequestReviewCommentUrl)
        {
            this.PullRequestReviewCommentUrl = pullRequestReviewCommentUrl ?? throw new global::System.ArgumentNullException(nameof(pullRequestReviewCommentUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretScanningLocationPullRequestReviewComment" /> class.
        /// </summary>
        public SecretScanningLocationPullRequestReviewComment()
        {
        }
    }
}