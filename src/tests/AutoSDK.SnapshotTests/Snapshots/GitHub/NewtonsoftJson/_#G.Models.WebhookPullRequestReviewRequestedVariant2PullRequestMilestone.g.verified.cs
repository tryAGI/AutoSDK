//HintName: G.Models.WebhookPullRequestReviewRequestedVariant2PullRequestMilestone.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A collection of related issues and pull requests.
    /// </summary>
    public sealed partial class WebhookPullRequestReviewRequestedVariant2PullRequestMilestone
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("closed_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime? ClosedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("closed_issues", Required = global::Newtonsoft.Json.Required.Always)]
        public int ClosedIssues { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("creator", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookPullRequestReviewRequestedVariant2PullRequestMilestoneCreator? Creator { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Description { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("due_on", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime? DueOn { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("html_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string HtmlUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("labels_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string LabelsUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// The number of the milestone.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("number", Required = global::Newtonsoft.Json.Required.Always)]
        public int Number { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("open_issues", Required = global::Newtonsoft.Json.Required.Always)]
        public int OpenIssues { get; set; } = default!;

        /// <summary>
        /// The state of the milestone.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("state", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookPullRequestReviewRequestedVariant2PullRequestMilestoneState State { get; set; } = default!;

        /// <summary>
        /// The title of the milestone.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title", Required = global::Newtonsoft.Json.Required.Always)]
        public string Title { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPullRequestReviewRequestedVariant2PullRequestMilestone" /> class.
        /// </summary>
        /// <param name="closedAt"></param>
        /// <param name="closedIssues"></param>
        /// <param name="createdAt"></param>
        /// <param name="creator"></param>
        /// <param name="description"></param>
        /// <param name="dueOn"></param>
        /// <param name="htmlUrl"></param>
        /// <param name="id"></param>
        /// <param name="labelsUrl"></param>
        /// <param name="nodeId"></param>
        /// <param name="number">
        /// The number of the milestone.
        /// </param>
        /// <param name="openIssues"></param>
        /// <param name="state">
        /// The state of the milestone.
        /// </param>
        /// <param name="title">
        /// The title of the milestone.
        /// </param>
        /// <param name="updatedAt"></param>
        /// <param name="url"></param>
        public WebhookPullRequestReviewRequestedVariant2PullRequestMilestone(
            global::System.DateTime? closedAt,
            int closedIssues,
            global::System.DateTime createdAt,
            global::G.WebhookPullRequestReviewRequestedVariant2PullRequestMilestoneCreator? creator,
            string? description,
            global::System.DateTime? dueOn,
            string htmlUrl,
            int id,
            string labelsUrl,
            string nodeId,
            int number,
            int openIssues,
            global::G.WebhookPullRequestReviewRequestedVariant2PullRequestMilestoneState state,
            string title,
            global::System.DateTime updatedAt,
            string url)
        {
            this.ClosedAt = closedAt;
            this.ClosedIssues = closedIssues;
            this.CreatedAt = createdAt;
            this.Creator = creator ?? throw new global::System.ArgumentNullException(nameof(creator));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.DueOn = dueOn;
            this.HtmlUrl = htmlUrl ?? throw new global::System.ArgumentNullException(nameof(htmlUrl));
            this.Id = id;
            this.LabelsUrl = labelsUrl ?? throw new global::System.ArgumentNullException(nameof(labelsUrl));
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.Number = number;
            this.OpenIssues = openIssues;
            this.State = state;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.UpdatedAt = updatedAt;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPullRequestReviewRequestedVariant2PullRequestMilestone" /> class.
        /// </summary>
        public WebhookPullRequestReviewRequestedVariant2PullRequestMilestone()
        {
        }
    }
}