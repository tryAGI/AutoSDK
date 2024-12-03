//HintName: G.Models.PullRequestReviewCommentLinksSelf.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PullRequestReviewCommentLinksSelf
    {
        /// <summary>
        /// Example: https://api.github.com/repos/octocat/Hello-World/pulls/comments/1
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/pulls/comments/1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("href")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Href { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PullRequestReviewCommentLinksSelf" /> class.
        /// </summary>
        /// <param name="href">
        /// Example: https://api.github.com/repos/octocat/Hello-World/pulls/comments/1
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public PullRequestReviewCommentLinksSelf(
            string href)
        {
            this.Href = href ?? throw new global::System.ArgumentNullException(nameof(href));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PullRequestReviewCommentLinksSelf" /> class.
        /// </summary>
        public PullRequestReviewCommentLinksSelf()
        {
        }
    }
}