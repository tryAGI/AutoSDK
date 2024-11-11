//HintName: G.Models.WebhookPullRequestReviewRequestRemovedVariant2PullRequestLinksReviewComment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookPullRequestReviewRequestRemovedVariant2PullRequestLinksReviewComment
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("href", Required = global::Newtonsoft.Json.Required.Always)]
        public string Href { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPullRequestReviewRequestRemovedVariant2PullRequestLinksReviewComment" /> class.
        /// </summary>
        /// <param name="href"></param>
        public WebhookPullRequestReviewRequestRemovedVariant2PullRequestLinksReviewComment(
            string href)
        {
            this.Href = href ?? throw new global::System.ArgumentNullException(nameof(href));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPullRequestReviewRequestRemovedVariant2PullRequestLinksReviewComment" /> class.
        /// </summary>
        public WebhookPullRequestReviewRequestRemovedVariant2PullRequestLinksReviewComment()
        {
        }
    }
}