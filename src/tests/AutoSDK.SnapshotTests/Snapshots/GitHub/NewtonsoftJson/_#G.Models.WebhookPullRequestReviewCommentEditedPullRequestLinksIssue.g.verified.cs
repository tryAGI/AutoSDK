//HintName: G.Models.WebhookPullRequestReviewCommentEditedPullRequestLinksIssue.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookPullRequestReviewCommentEditedPullRequestLinksIssue
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
        /// Initializes a new instance of the <see cref="WebhookPullRequestReviewCommentEditedPullRequestLinksIssue" /> class.
        /// </summary>
        /// <param name="href"></param>
        public WebhookPullRequestReviewCommentEditedPullRequestLinksIssue(
            string href)
        {
            this.Href = href ?? throw new global::System.ArgumentNullException(nameof(href));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPullRequestReviewCommentEditedPullRequestLinksIssue" /> class.
        /// </summary>
        public WebhookPullRequestReviewCommentEditedPullRequestLinksIssue()
        {
        }
    }
}