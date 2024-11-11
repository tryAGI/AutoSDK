//HintName: G.Models.PullRequestReviewCommentLinksHtml.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PullRequestReviewCommentLinksHtml
    {
        /// <summary>
        /// Example: https://github.com/octocat/Hello-World/pull/1#discussion-diff-1
        /// </summary>
        /// <example>https://github.com/octocat/Hello-World/pull/1#discussion-diff-1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("href")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Href { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PullRequestReviewCommentLinksHtml" /> class.
        /// </summary>
        /// <param name="href">
        /// Example: https://github.com/octocat/Hello-World/pull/1#discussion-diff-1
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public PullRequestReviewCommentLinksHtml(
            string href)
        {
            this.Href = href ?? throw new global::System.ArgumentNullException(nameof(href));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PullRequestReviewCommentLinksHtml" /> class.
        /// </summary>
        public PullRequestReviewCommentLinksHtml()
        {
        }
    }
}