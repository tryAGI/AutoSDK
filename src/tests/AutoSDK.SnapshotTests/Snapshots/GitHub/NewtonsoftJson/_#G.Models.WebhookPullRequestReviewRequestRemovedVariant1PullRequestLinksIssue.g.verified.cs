//HintName: G.Models.WebhookPullRequestReviewRequestRemovedVariant1PullRequestLinksIssue.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookPullRequestReviewRequestRemovedVariant1PullRequestLinksIssue
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
        /// Initializes a new instance of the <see cref="WebhookPullRequestReviewRequestRemovedVariant1PullRequestLinksIssue" /> class.
        /// </summary>
        /// <param name="href"></param>
        public WebhookPullRequestReviewRequestRemovedVariant1PullRequestLinksIssue(
            string href)
        {
            this.Href = href ?? throw new global::System.ArgumentNullException(nameof(href));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPullRequestReviewRequestRemovedVariant1PullRequestLinksIssue" /> class.
        /// </summary>
        public WebhookPullRequestReviewRequestRemovedVariant1PullRequestLinksIssue()
        {
        }
    }
}