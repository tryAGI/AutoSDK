//HintName: G.Models.WebhookPullRequestReviewThreadUnresolvedThreadCommentLinks.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookPullRequestReviewThreadUnresolvedThreadCommentLinks
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("html", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookPullRequestReviewThreadUnresolvedThreadCommentLinksHtml Html { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pull_request", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookPullRequestReviewThreadUnresolvedThreadCommentLinksPullRequest PullRequest { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("self", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookPullRequestReviewThreadUnresolvedThreadCommentLinksSelf Self { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPullRequestReviewThreadUnresolvedThreadCommentLinks" /> class.
        /// </summary>
        /// <param name="html"></param>
        /// <param name="pullRequest"></param>
        /// <param name="self"></param>
        public WebhookPullRequestReviewThreadUnresolvedThreadCommentLinks(
            global::G.WebhookPullRequestReviewThreadUnresolvedThreadCommentLinksHtml html,
            global::G.WebhookPullRequestReviewThreadUnresolvedThreadCommentLinksPullRequest pullRequest,
            global::G.WebhookPullRequestReviewThreadUnresolvedThreadCommentLinksSelf self)
        {
            this.Html = html ?? throw new global::System.ArgumentNullException(nameof(html));
            this.PullRequest = pullRequest ?? throw new global::System.ArgumentNullException(nameof(pullRequest));
            this.Self = self ?? throw new global::System.ArgumentNullException(nameof(self));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPullRequestReviewThreadUnresolvedThreadCommentLinks" /> class.
        /// </summary>
        public WebhookPullRequestReviewThreadUnresolvedThreadCommentLinks()
        {
        }
    }
}