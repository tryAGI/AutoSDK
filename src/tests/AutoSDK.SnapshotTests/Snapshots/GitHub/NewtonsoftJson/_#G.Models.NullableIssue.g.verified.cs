//HintName: G.Models.NullableIssue.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Issues are a great way to keep track of tasks, enhancements, and bugs for your projects.
    /// </summary>
    public sealed partial class NullableIssue
    {
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
        /// URL for the issue<br/>
        /// Example: https://api.github.com/repositories/42/issues/1
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
        /// Number uniquely identifying the issue within its repository<br/>
        /// Example: 42
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("number", Required = global::Newtonsoft.Json.Required.Always)]
        public int Number { get; set; } = default!;

        /// <summary>
        /// State of the issue; either 'open' or 'closed'<br/>
        /// Example: open
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("state", Required = global::Newtonsoft.Json.Required.Always)]
        public string State { get; set; } = default!;

        /// <summary>
        /// The reason for the current state<br/>
        /// Example: not_planned
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("state_reason")]
        public global::G.NullableIssueStateReason? StateReason { get; set; }

        /// <summary>
        /// Title of the issue<br/>
        /// Example: Widget creation fails in Safari on OS X 10.8
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title", Required = global::Newtonsoft.Json.Required.Always)]
        public string Title { get; set; } = default!;

        /// <summary>
        /// Contents of the issue<br/>
        /// Example: It looks like the new widget form is broken on Safari. When I try and create the widget, Safari crashes. This is reproducible on 10.8, but not 10.9. Maybe a browser bug?
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("body")]
        public string? Body { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.NullableSimpleUser? User { get; set; } = default!;

        /// <summary>
        /// Labels to associate with this issue; pass one or more label names to replace the set of labels on this issue; send an empty array to clear all labels from the issue; note that the labels are silently dropped for users without push access to the repository<br/>
        /// Example: [bug, registration]
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("labels", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.OneOf<string, global::G.NullableIssueLabel>> Labels { get; set; } = default!;

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("assignee", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.NullableSimpleUser? Assignee { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("assignees")]
        public global::System.Collections.Generic.IList<global::G.SimpleUser>? Assignees { get; set; }

        /// <summary>
        /// A collection of related issues and pull requests.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("milestone", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.NullableMilestone? Milestone { get; set; } = default!;

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
        [global::Newtonsoft.Json.JsonProperty("comments", Required = global::Newtonsoft.Json.Required.Always)]
        public int Comments { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pull_request")]
        public global::G.NullableIssuePullRequest? PullRequest { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("closed_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime? ClosedAt { get; set; } = default!;

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
        [global::Newtonsoft.Json.JsonProperty("draft")]
        public bool? Draft { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("closed_by")]
        public global::G.NullableSimpleUser? ClosedBy { get; set; }

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
        /// A repository on GitHub.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repository")]
        public global::G.Repository? Repository { get; set; }

        /// <summary>
        /// GitHub apps are a new way to extend GitHub. They can be installed directly on organizations and user accounts and granted access to specific repositories. They come with granular permissions and built-in webhooks. GitHub apps are first class actors within GitHub.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("performed_via_github_app")]
        public global::G.NullableIntegration? PerformedViaGithubApp { get; set; }

        /// <summary>
        /// How the author is associated with the repository.<br/>
        /// Example: OWNER
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("author_association", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AuthorAssociation AuthorAssociation { get; set; } = default!;

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

        /// <summary>
        /// Initializes a new instance of the <see cref="NullableIssue" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nodeId"></param>
        /// <param name="url">
        /// URL for the issue<br/>
        /// Example: https://api.github.com/repositories/42/issues/1
        /// </param>
        /// <param name="repositoryUrl"></param>
        /// <param name="labelsUrl"></param>
        /// <param name="commentsUrl"></param>
        /// <param name="eventsUrl"></param>
        /// <param name="htmlUrl"></param>
        /// <param name="number">
        /// Number uniquely identifying the issue within its repository<br/>
        /// Example: 42
        /// </param>
        /// <param name="state">
        /// State of the issue; either 'open' or 'closed'<br/>
        /// Example: open
        /// </param>
        /// <param name="stateReason">
        /// The reason for the current state<br/>
        /// Example: not_planned
        /// </param>
        /// <param name="title">
        /// Title of the issue<br/>
        /// Example: Widget creation fails in Safari on OS X 10.8
        /// </param>
        /// <param name="body">
        /// Contents of the issue<br/>
        /// Example: It looks like the new widget form is broken on Safari. When I try and create the widget, Safari crashes. This is reproducible on 10.8, but not 10.9. Maybe a browser bug?
        /// </param>
        /// <param name="user">
        /// A GitHub user.
        /// </param>
        /// <param name="labels">
        /// Labels to associate with this issue; pass one or more label names to replace the set of labels on this issue; send an empty array to clear all labels from the issue; note that the labels are silently dropped for users without push access to the repository<br/>
        /// Example: [bug, registration]
        /// </param>
        /// <param name="assignee">
        /// A GitHub user.
        /// </param>
        /// <param name="assignees"></param>
        /// <param name="milestone">
        /// A collection of related issues and pull requests.
        /// </param>
        /// <param name="locked"></param>
        /// <param name="activeLockReason"></param>
        /// <param name="comments"></param>
        /// <param name="pullRequest"></param>
        /// <param name="closedAt"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="draft"></param>
        /// <param name="closedBy">
        /// A GitHub user.
        /// </param>
        /// <param name="bodyHtml"></param>
        /// <param name="bodyText"></param>
        /// <param name="timelineUrl"></param>
        /// <param name="repository">
        /// A repository on GitHub.
        /// </param>
        /// <param name="performedViaGithubApp">
        /// GitHub apps are a new way to extend GitHub. They can be installed directly on organizations and user accounts and granted access to specific repositories. They come with granular permissions and built-in webhooks. GitHub apps are first class actors within GitHub.
        /// </param>
        /// <param name="authorAssociation">
        /// How the author is associated with the repository.<br/>
        /// Example: OWNER
        /// </param>
        /// <param name="reactions"></param>
        public NullableIssue(
            long id,
            string nodeId,
            string url,
            string repositoryUrl,
            string labelsUrl,
            string commentsUrl,
            string eventsUrl,
            string htmlUrl,
            int number,
            string state,
            string title,
            global::G.NullableSimpleUser? user,
            global::System.Collections.Generic.IList<global::G.OneOf<string, global::G.NullableIssueLabel>> labels,
            global::G.NullableSimpleUser? assignee,
            global::G.NullableMilestone? milestone,
            bool locked,
            int comments,
            global::System.DateTime? closedAt,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::G.AuthorAssociation authorAssociation,
            global::G.NullableIssueStateReason? stateReason,
            string? body,
            global::System.Collections.Generic.IList<global::G.SimpleUser>? assignees,
            string? activeLockReason,
            global::G.NullableIssuePullRequest? pullRequest,
            bool? draft,
            global::G.NullableSimpleUser? closedBy,
            string? bodyHtml,
            string? bodyText,
            string? timelineUrl,
            global::G.Repository? repository,
            global::G.NullableIntegration? performedViaGithubApp,
            global::G.ReactionRollup? reactions)
        {
            this.Id = id;
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.RepositoryUrl = repositoryUrl ?? throw new global::System.ArgumentNullException(nameof(repositoryUrl));
            this.LabelsUrl = labelsUrl ?? throw new global::System.ArgumentNullException(nameof(labelsUrl));
            this.CommentsUrl = commentsUrl ?? throw new global::System.ArgumentNullException(nameof(commentsUrl));
            this.EventsUrl = eventsUrl ?? throw new global::System.ArgumentNullException(nameof(eventsUrl));
            this.HtmlUrl = htmlUrl ?? throw new global::System.ArgumentNullException(nameof(htmlUrl));
            this.Number = number;
            this.State = state ?? throw new global::System.ArgumentNullException(nameof(state));
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.User = user ?? throw new global::System.ArgumentNullException(nameof(user));
            this.Labels = labels ?? throw new global::System.ArgumentNullException(nameof(labels));
            this.Assignee = assignee ?? throw new global::System.ArgumentNullException(nameof(assignee));
            this.Milestone = milestone ?? throw new global::System.ArgumentNullException(nameof(milestone));
            this.Locked = locked;
            this.Comments = comments;
            this.ClosedAt = closedAt;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.AuthorAssociation = authorAssociation;
            this.StateReason = stateReason;
            this.Body = body;
            this.Assignees = assignees;
            this.ActiveLockReason = activeLockReason;
            this.PullRequest = pullRequest;
            this.Draft = draft;
            this.ClosedBy = closedBy;
            this.BodyHtml = bodyHtml;
            this.BodyText = bodyText;
            this.TimelineUrl = timelineUrl;
            this.Repository = repository;
            this.PerformedViaGithubApp = performedViaGithubApp;
            this.Reactions = reactions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NullableIssue" /> class.
        /// </summary>
        public NullableIssue()
        {
        }


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.SerializeObject(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.NullableIssue? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.NullableIssue>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER     
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.NullableIssue?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.NullableIssue?>(serializer.Deserialize<global::G.NullableIssue>(jsonReader));
        }

    }
}