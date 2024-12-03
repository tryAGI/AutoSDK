//HintName: G.Models.WebhookPullRequestAutoMergeDisabledPullRequestLinks.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookPullRequestAutoMergeDisabledPullRequestLinks
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("comments", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookPullRequestAutoMergeDisabledPullRequestLinksComments Comments { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("commits", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookPullRequestAutoMergeDisabledPullRequestLinksCommits Commits { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("html", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookPullRequestAutoMergeDisabledPullRequestLinksHtml Html { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("issue", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookPullRequestAutoMergeDisabledPullRequestLinksIssue Issue { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("review_comment", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookPullRequestAutoMergeDisabledPullRequestLinksReviewComment ReviewComment { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("review_comments", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookPullRequestAutoMergeDisabledPullRequestLinksReviewComments ReviewComments { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("self", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookPullRequestAutoMergeDisabledPullRequestLinksSelf Self { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("statuses", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookPullRequestAutoMergeDisabledPullRequestLinksStatuses Statuses { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPullRequestAutoMergeDisabledPullRequestLinks" /> class.
        /// </summary>
        /// <param name="comments"></param>
        /// <param name="commits"></param>
        /// <param name="html"></param>
        /// <param name="issue"></param>
        /// <param name="reviewComment"></param>
        /// <param name="reviewComments"></param>
        /// <param name="self"></param>
        /// <param name="statuses"></param>
        public WebhookPullRequestAutoMergeDisabledPullRequestLinks(
            global::G.WebhookPullRequestAutoMergeDisabledPullRequestLinksComments comments,
            global::G.WebhookPullRequestAutoMergeDisabledPullRequestLinksCommits commits,
            global::G.WebhookPullRequestAutoMergeDisabledPullRequestLinksHtml html,
            global::G.WebhookPullRequestAutoMergeDisabledPullRequestLinksIssue issue,
            global::G.WebhookPullRequestAutoMergeDisabledPullRequestLinksReviewComment reviewComment,
            global::G.WebhookPullRequestAutoMergeDisabledPullRequestLinksReviewComments reviewComments,
            global::G.WebhookPullRequestAutoMergeDisabledPullRequestLinksSelf self,
            global::G.WebhookPullRequestAutoMergeDisabledPullRequestLinksStatuses statuses)
        {
            this.Comments = comments ?? throw new global::System.ArgumentNullException(nameof(comments));
            this.Commits = commits ?? throw new global::System.ArgumentNullException(nameof(commits));
            this.Html = html ?? throw new global::System.ArgumentNullException(nameof(html));
            this.Issue = issue ?? throw new global::System.ArgumentNullException(nameof(issue));
            this.ReviewComment = reviewComment ?? throw new global::System.ArgumentNullException(nameof(reviewComment));
            this.ReviewComments = reviewComments ?? throw new global::System.ArgumentNullException(nameof(reviewComments));
            this.Self = self ?? throw new global::System.ArgumentNullException(nameof(self));
            this.Statuses = statuses ?? throw new global::System.ArgumentNullException(nameof(statuses));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPullRequestAutoMergeDisabledPullRequestLinks" /> class.
        /// </summary>
        public WebhookPullRequestAutoMergeDisabledPullRequestLinks()
        {
        }
    }
}