//HintName: G.Models.WebhookIssueCommentEditedIssueVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookIssueCommentEditedIssueVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active_lock_reason")]
        public string? ActiveLockReason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assignee")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhookIssueCommentEditedIssueVariant2Assignee? Assignee { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assignees")]
        public global::System.Collections.Generic.IList<object>? Assignees { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("author_association")]
        public string? AuthorAssociation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        public string? Body { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("closed_at")]
        public string? ClosedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comments")]
        public int? Comments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comments_url")]
        public string? CommentsUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events_url")]
        public string? EventsUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        public string? HtmlUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.WebhookIssueCommentEditedIssueVariant2Label> Labels { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels_url")]
        public string? LabelsUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("locked")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Locked { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("milestone")]
        public object? Milestone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        public string? NodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("number")]
        public int? Number { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("performed_via_github_app")]
        public object? PerformedViaGithubApp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reactions")]
        public global::G.WebhookIssueCommentEditedIssueVariant2Reactions? Reactions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_url")]
        public string? RepositoryUrl { get; set; }

        /// <summary>
        /// State of the issue; either 'open' or 'closed'
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookIssueCommentEditedIssueVariant2StateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhookIssueCommentEditedIssueVariant2State State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeline_url")]
        public string? TimelineUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public global::G.WebhookIssueCommentEditedIssueVariant2User? User { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookIssueCommentEditedIssueVariant2" /> class.
        /// </summary>
        /// <param name="activeLockReason"></param>
        /// <param name="assignee"></param>
        /// <param name="assignees"></param>
        /// <param name="authorAssociation"></param>
        /// <param name="body"></param>
        /// <param name="closedAt"></param>
        /// <param name="comments"></param>
        /// <param name="commentsUrl"></param>
        /// <param name="createdAt"></param>
        /// <param name="eventsUrl"></param>
        /// <param name="htmlUrl"></param>
        /// <param name="id"></param>
        /// <param name="labels"></param>
        /// <param name="labelsUrl"></param>
        /// <param name="locked"></param>
        /// <param name="milestone"></param>
        /// <param name="nodeId"></param>
        /// <param name="number"></param>
        /// <param name="performedViaGithubApp"></param>
        /// <param name="reactions"></param>
        /// <param name="repositoryUrl"></param>
        /// <param name="state">
        /// State of the issue; either 'open' or 'closed'
        /// </param>
        /// <param name="timelineUrl"></param>
        /// <param name="title"></param>
        /// <param name="updatedAt"></param>
        /// <param name="url"></param>
        /// <param name="user"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public WebhookIssueCommentEditedIssueVariant2(
            global::G.WebhookIssueCommentEditedIssueVariant2Assignee? assignee,
            global::System.Collections.Generic.IList<global::G.WebhookIssueCommentEditedIssueVariant2Label> labels,
            bool locked,
            global::G.WebhookIssueCommentEditedIssueVariant2State state,
            string? activeLockReason,
            global::System.Collections.Generic.IList<object>? assignees,
            string? authorAssociation,
            string? body,
            string? closedAt,
            int? comments,
            string? commentsUrl,
            string? createdAt,
            string? eventsUrl,
            string? htmlUrl,
            int? id,
            string? labelsUrl,
            object? milestone,
            string? nodeId,
            int? number,
            object? performedViaGithubApp,
            global::G.WebhookIssueCommentEditedIssueVariant2Reactions? reactions,
            string? repositoryUrl,
            string? timelineUrl,
            string? title,
            string? updatedAt,
            string? url,
            global::G.WebhookIssueCommentEditedIssueVariant2User? user)
        {
            this.Assignee = assignee ?? throw new global::System.ArgumentNullException(nameof(assignee));
            this.Labels = labels ?? throw new global::System.ArgumentNullException(nameof(labels));
            this.Locked = locked;
            this.State = state;
            this.ActiveLockReason = activeLockReason;
            this.Assignees = assignees;
            this.AuthorAssociation = authorAssociation;
            this.Body = body;
            this.ClosedAt = closedAt;
            this.Comments = comments;
            this.CommentsUrl = commentsUrl;
            this.CreatedAt = createdAt;
            this.EventsUrl = eventsUrl;
            this.HtmlUrl = htmlUrl;
            this.Id = id;
            this.LabelsUrl = labelsUrl;
            this.Milestone = milestone;
            this.NodeId = nodeId;
            this.Number = number;
            this.PerformedViaGithubApp = performedViaGithubApp;
            this.Reactions = reactions;
            this.RepositoryUrl = repositoryUrl;
            this.TimelineUrl = timelineUrl;
            this.Title = title;
            this.UpdatedAt = updatedAt;
            this.Url = url;
            this.User = user;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookIssueCommentEditedIssueVariant2" /> class.
        /// </summary>
        public WebhookIssueCommentEditedIssueVariant2()
        {
        }
    }
}