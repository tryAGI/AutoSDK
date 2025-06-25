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
        [global::System.Text.Json.Serialization.JsonPropertyName("pull_request_review_comment_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PullRequestReviewCommentUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretScanningLocationPullRequestReviewComment" /> class.
        /// </summary>
        /// <param name="pullRequestReviewCommentUrl">
        /// The API URL to get the pull request review comment where the secret was detected.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/pulls/comments/12
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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