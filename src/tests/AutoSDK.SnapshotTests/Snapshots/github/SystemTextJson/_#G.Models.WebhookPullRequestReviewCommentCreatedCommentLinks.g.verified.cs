//HintName: G.Models.WebhookPullRequestReviewCommentCreatedCommentLinks.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookPullRequestReviewCommentCreatedCommentLinks
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhookPullRequestReviewCommentCreatedCommentLinksHtml Html { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pull_request")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhookPullRequestReviewCommentCreatedCommentLinksPullRequest PullRequest { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("self")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhookPullRequestReviewCommentCreatedCommentLinksSelf Self { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPullRequestReviewCommentCreatedCommentLinks" /> class.
        /// </summary>
        /// <param name="html"></param>
        /// <param name="pullRequest"></param>
        /// <param name="self"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookPullRequestReviewCommentCreatedCommentLinks(
            global::G.WebhookPullRequestReviewCommentCreatedCommentLinksHtml html,
            global::G.WebhookPullRequestReviewCommentCreatedCommentLinksPullRequest pullRequest,
            global::G.WebhookPullRequestReviewCommentCreatedCommentLinksSelf self)
        {
            this.Html = html ?? throw new global::System.ArgumentNullException(nameof(html));
            this.PullRequest = pullRequest ?? throw new global::System.ArgumentNullException(nameof(pullRequest));
            this.Self = self ?? throw new global::System.ArgumentNullException(nameof(self));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPullRequestReviewCommentCreatedCommentLinks" /> class.
        /// </summary>
        public WebhookPullRequestReviewCommentCreatedCommentLinks()
        {
        }
    }
}