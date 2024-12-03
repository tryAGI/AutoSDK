//HintName: G.Models.IssueEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Issue Event
    /// </summary>
    public sealed partial class IssueEvent
    {
        /// <summary>
        /// Example: 1L
        /// </summary>
        /// <example>1L</example>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public long Id { get; set; } = default!;

        /// <summary>
        /// Example: MDEwOklzc3VlRXZlbnQx
        /// </summary>
        /// <example>MDEwOklzc3VlRXZlbnQx</example>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/repos/octocat/Hello-World/issues/events/1
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/issues/events/1</example>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("actor", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.NullableSimpleUser? Actor { get; set; } = default!;

        /// <summary>
        /// Example: closed
        /// </summary>
        /// <example>closed</example>
        [global::Newtonsoft.Json.JsonProperty("event", Required = global::Newtonsoft.Json.Required.Always)]
        public string Event { get; set; } = default!;

        /// <summary>
        /// Example: 6dcb09b5b57875f334f61aebed695e2e4193db5e
        /// </summary>
        /// <example>6dcb09b5b57875f334f61aebed695e2e4193db5e</example>
        [global::Newtonsoft.Json.JsonProperty("commit_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string? CommitId { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/repos/octocat/Hello-World/commits/6dcb09b5b57875f334f61aebed695e2e4193db5e
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/commits/6dcb09b5b57875f334f61aebed695e2e4193db5e</example>
        [global::Newtonsoft.Json.JsonProperty("commit_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string? CommitUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// Issues are a great way to keep track of tasks, enhancements, and bugs for your projects.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("issue")]
        public global::G.NullableIssue? Issue { get; set; }

        /// <summary>
        /// Issue Event Label
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("label")]
        public global::G.IssueEventLabel? Label { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("assignee")]
        public global::G.NullableSimpleUser? Assignee { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("assigner")]
        public global::G.NullableSimpleUser? Assigner { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("review_requester")]
        public global::G.NullableSimpleUser? ReviewRequester { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("requested_reviewer")]
        public global::G.NullableSimpleUser? RequestedReviewer { get; set; }

        /// <summary>
        /// Groups of organization members that gives permissions on specified repositories.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("requested_team")]
        public global::G.Team? RequestedTeam { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dismissed_review")]
        public global::G.IssueEventDismissedReview? DismissedReview { get; set; }

        /// <summary>
        /// Issue Event Milestone
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("milestone")]
        public global::G.IssueEventMilestone? Milestone { get; set; }

        /// <summary>
        /// Issue Event Project Card
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_card")]
        public global::G.IssueEventProjectCard? ProjectCard { get; set; }

        /// <summary>
        /// Issue Event Rename
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rename")]
        public global::G.IssueEventRename? Rename { get; set; }

        /// <summary>
        /// How the author is associated with the repository.<br/>
        /// Example: OWNER
        /// </summary>
        /// <example>OWNER</example>
        [global::Newtonsoft.Json.JsonProperty("author_association")]
        public global::G.AuthorAssociation? AuthorAssociation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lock_reason")]
        public string? LockReason { get; set; }

        /// <summary>
        /// GitHub apps are a new way to extend GitHub. They can be installed directly on organizations and user accounts and granted access to specific repositories. They come with granular permissions and built-in webhooks. GitHub apps are first class actors within GitHub.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("performed_via_github_app")]
        public global::G.NullableIntegration? PerformedViaGithubApp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IssueEvent" /> class.
        /// </summary>
        /// <param name="id">
        /// Example: 1L
        /// </param>
        /// <param name="nodeId">
        /// Example: MDEwOklzc3VlRXZlbnQx
        /// </param>
        /// <param name="url">
        /// Example: https://api.github.com/repos/octocat/Hello-World/issues/events/1
        /// </param>
        /// <param name="actor">
        /// A GitHub user.
        /// </param>
        /// <param name="event">
        /// Example: closed
        /// </param>
        /// <param name="commitId">
        /// Example: 6dcb09b5b57875f334f61aebed695e2e4193db5e
        /// </param>
        /// <param name="commitUrl">
        /// Example: https://api.github.com/repos/octocat/Hello-World/commits/6dcb09b5b57875f334f61aebed695e2e4193db5e
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="issue">
        /// Issues are a great way to keep track of tasks, enhancements, and bugs for your projects.
        /// </param>
        /// <param name="label">
        /// Issue Event Label
        /// </param>
        /// <param name="assignee">
        /// A GitHub user.
        /// </param>
        /// <param name="assigner">
        /// A GitHub user.
        /// </param>
        /// <param name="reviewRequester">
        /// A GitHub user.
        /// </param>
        /// <param name="requestedReviewer">
        /// A GitHub user.
        /// </param>
        /// <param name="requestedTeam">
        /// Groups of organization members that gives permissions on specified repositories.
        /// </param>
        /// <param name="dismissedReview"></param>
        /// <param name="milestone">
        /// Issue Event Milestone
        /// </param>
        /// <param name="projectCard">
        /// Issue Event Project Card
        /// </param>
        /// <param name="rename">
        /// Issue Event Rename
        /// </param>
        /// <param name="authorAssociation">
        /// How the author is associated with the repository.<br/>
        /// Example: OWNER
        /// </param>
        /// <param name="lockReason"></param>
        /// <param name="performedViaGithubApp">
        /// GitHub apps are a new way to extend GitHub. They can be installed directly on organizations and user accounts and granted access to specific repositories. They come with granular permissions and built-in webhooks. GitHub apps are first class actors within GitHub.
        /// </param>
        public IssueEvent(
            long id,
            string nodeId,
            string url,
            global::G.NullableSimpleUser? actor,
            string @event,
            string? commitId,
            string? commitUrl,
            global::System.DateTime createdAt,
            global::G.NullableIssue? issue,
            global::G.IssueEventLabel? label,
            global::G.NullableSimpleUser? assignee,
            global::G.NullableSimpleUser? assigner,
            global::G.NullableSimpleUser? reviewRequester,
            global::G.NullableSimpleUser? requestedReviewer,
            global::G.Team? requestedTeam,
            global::G.IssueEventDismissedReview? dismissedReview,
            global::G.IssueEventMilestone? milestone,
            global::G.IssueEventProjectCard? projectCard,
            global::G.IssueEventRename? rename,
            global::G.AuthorAssociation? authorAssociation,
            string? lockReason,
            global::G.NullableIntegration? performedViaGithubApp)
        {
            this.Id = id;
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Actor = actor ?? throw new global::System.ArgumentNullException(nameof(actor));
            this.Event = @event ?? throw new global::System.ArgumentNullException(nameof(@event));
            this.CommitId = commitId ?? throw new global::System.ArgumentNullException(nameof(commitId));
            this.CommitUrl = commitUrl ?? throw new global::System.ArgumentNullException(nameof(commitUrl));
            this.CreatedAt = createdAt;
            this.Issue = issue;
            this.Label = label;
            this.Assignee = assignee;
            this.Assigner = assigner;
            this.ReviewRequester = reviewRequester;
            this.RequestedReviewer = requestedReviewer;
            this.RequestedTeam = requestedTeam;
            this.DismissedReview = dismissedReview;
            this.Milestone = milestone;
            this.ProjectCard = projectCard;
            this.Rename = rename;
            this.AuthorAssociation = authorAssociation;
            this.LockReason = lockReason;
            this.PerformedViaGithubApp = performedViaGithubApp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IssueEvent" /> class.
        /// </summary>
        public IssueEvent()
        {
        }
    }
}