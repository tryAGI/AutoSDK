//HintName: G.Models.WebhookPullRequestReviewDismissedReview.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The review that was affected.
    /// </summary>
    public sealed partial class WebhookPullRequestReviewDismissedReview
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("_links", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookPullRequestReviewDismissedReviewLinks Links { get; set; } = default!;

        /// <summary>
        /// How the author is associated with the repository.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("author_association", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookPullRequestReviewDismissedReviewAuthorAssociation AuthorAssociation { get; set; } = default!;

        /// <summary>
        /// The text of the review.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("body", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Body { get; set; } = default!;

        /// <summary>
        /// A commit SHA for the review.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("commit_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string CommitId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("html_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string HtmlUrl { get; set; } = default!;

        /// <summary>
        /// Unique identifier of the review
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pull_request_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string PullRequestUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("state", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookPullRequestReviewDismissedReviewState State { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("submitted_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime SubmittedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookPullRequestReviewDismissedReviewUser? User { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPullRequestReviewDismissedReview" /> class.
        /// </summary>
        /// <param name="links"></param>
        /// <param name="authorAssociation">
        /// How the author is associated with the repository.
        /// </param>
        /// <param name="body">
        /// The text of the review.
        /// </param>
        /// <param name="commitId">
        /// A commit SHA for the review.
        /// </param>
        /// <param name="htmlUrl"></param>
        /// <param name="id">
        /// Unique identifier of the review
        /// </param>
        /// <param name="nodeId"></param>
        /// <param name="pullRequestUrl"></param>
        /// <param name="state"></param>
        /// <param name="submittedAt"></param>
        /// <param name="user"></param>
        public WebhookPullRequestReviewDismissedReview(
            global::G.WebhookPullRequestReviewDismissedReviewLinks links,
            global::G.WebhookPullRequestReviewDismissedReviewAuthorAssociation authorAssociation,
            string? body,
            string commitId,
            string htmlUrl,
            int id,
            string nodeId,
            string pullRequestUrl,
            global::G.WebhookPullRequestReviewDismissedReviewState state,
            global::System.DateTime submittedAt,
            global::G.WebhookPullRequestReviewDismissedReviewUser? user)
        {
            this.Links = links ?? throw new global::System.ArgumentNullException(nameof(links));
            this.AuthorAssociation = authorAssociation;
            this.Body = body ?? throw new global::System.ArgumentNullException(nameof(body));
            this.CommitId = commitId ?? throw new global::System.ArgumentNullException(nameof(commitId));
            this.HtmlUrl = htmlUrl ?? throw new global::System.ArgumentNullException(nameof(htmlUrl));
            this.Id = id;
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.PullRequestUrl = pullRequestUrl ?? throw new global::System.ArgumentNullException(nameof(pullRequestUrl));
            this.State = state;
            this.SubmittedAt = submittedAt;
            this.User = user ?? throw new global::System.ArgumentNullException(nameof(user));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPullRequestReviewDismissedReview" /> class.
        /// </summary>
        public WebhookPullRequestReviewDismissedReview()
        {
        }
    }
}