//HintName: G.Models.IssueSearchResultItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Issue Search Result Item
    /// </summary>
    public sealed partial class IssueSearchResultItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repository_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string RepositoryUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("labels_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string LabelsUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("comments_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string CommentsUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("events_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string EventsUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("html_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string HtmlUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public long Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("number", Required = global::Newtonsoft.Json.Required.Always)]
        public int Number { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title", Required = global::Newtonsoft.Json.Required.Always)]
        public string Title { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("locked", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Locked { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("active_lock_reason")]
        public string? ActiveLockReason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("assignees")]
        public global::System.Collections.Generic.IList<global::G.SimpleUser>? Assignees { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.NullableSimpleUser? User { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("labels", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.IssueSearchResultItemLabel> Labels { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("state", Required = global::Newtonsoft.Json.Required.Always)]
        public string State { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("state_reason")]
        public string? StateReason { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("assignee", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.NullableSimpleUser? Assignee { get; set; } = default!;

        /// <summary>
        /// A collection of related issues and pull requests.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("milestone", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.NullableMilestone? Milestone { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("comments", Required = global::Newtonsoft.Json.Required.Always)]
        public int Comments { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("closed_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime? ClosedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text_matches")]
        public global::System.Collections.Generic.IList<global::G.SearchResultTextMatche>? TextMatches { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pull_request")]
        public global::G.IssueSearchResultItemPullRequest? PullRequest { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("body")]
        public string? Body { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("score", Required = global::Newtonsoft.Json.Required.Always)]
        public double Score { get; set; } = default!;

        /// <summary>
        /// How the author is associated with the repository.<br/>
        /// Example: OWNER
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("author_association", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AuthorAssociation? AuthorAssociation { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("draft")]
        public bool Draft { get; set; }

        /// <summary>
        /// A repository on GitHub.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repository")]
        public global::G.Repository? Repository { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("body_html")]
        public string? BodyHtml { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("body_text")]
        public string? BodyText { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timeline_url")]
        public string? TimelineUrl { get; set; }

        /// <summary>
        /// GitHub apps are a new way to extend GitHub. They can be installed directly on organizations and user accounts and granted access to specific repositories. They come with granular permissions and built-in webhooks. GitHub apps are first class actors within GitHub.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("performed_via_github_app")]
        public global::G.NullableIntegration? PerformedViaGithubApp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reactions")]
        public global::G.ReactionRollup? Reactions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}