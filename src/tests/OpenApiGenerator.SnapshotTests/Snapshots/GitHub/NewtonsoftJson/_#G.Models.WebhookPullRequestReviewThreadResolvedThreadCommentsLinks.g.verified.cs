//HintName: G.Models.WebhookPullRequestReviewThreadResolvedThreadCommentsLinks.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookPullRequestReviewThreadResolvedThreadCommentsLinks
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("html", Required = global::Newtonsoft.Json.Required.Always)]
        public WebhookPullRequestReviewThreadResolvedThreadCommentsLinksHtml Html { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pull_request", Required = global::Newtonsoft.Json.Required.Always)]
        public WebhookPullRequestReviewThreadResolvedThreadCommentsLinksPullRequest PullRequest { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("self", Required = global::Newtonsoft.Json.Required.Always)]
        public WebhookPullRequestReviewThreadResolvedThreadCommentsLinksSelf Self { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}