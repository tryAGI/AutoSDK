//HintName: G.Models.SecretScanningLocationPullRequestReview.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Represents a 'pull_request_review' secret scanning location type. This location type shows that a secret was detected in a review on a pull request.
    /// </summary>
    public sealed partial class SecretScanningLocationPullRequestReview
    {
        /// <summary>
        /// The API URL to get the pull request review where the secret was detected.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/pulls/2846/reviews/80
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/pulls/2846/reviews/80</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("pull_request_review_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PullRequestReviewUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretScanningLocationPullRequestReview" /> class.
        /// </summary>
        /// <param name="pullRequestReviewUrl">
        /// The API URL to get the pull request review where the secret was detected.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/pulls/2846/reviews/80
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SecretScanningLocationPullRequestReview(
            string pullRequestReviewUrl)
        {
            this.PullRequestReviewUrl = pullRequestReviewUrl ?? throw new global::System.ArgumentNullException(nameof(pullRequestReviewUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretScanningLocationPullRequestReview" /> class.
        /// </summary>
        public SecretScanningLocationPullRequestReview()
        {
        }
    }
}