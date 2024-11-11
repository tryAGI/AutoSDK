//HintName: G.Models.WebhookIssueCommentEditedIssueVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The [issue](https://docs.github.com/rest/issues/issues#get-an-issue) itself.
    /// </summary>
    public sealed partial class WebhookIssueCommentEditedIssueVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("active_lock_reason", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookIssueCommentEditedIssueVariant1ActiveLockReason? ActiveLockReason { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("assignee")]
        public global::G.WebhookIssueCommentEditedIssueVariant1Assignee? Assignee { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("assignees", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.WebhookIssueCommentEditedIssueVariant1Assignee2> Assignees { get; set; } = default!;

        /// <summary>
        /// How the author is associated with the repository.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("author_association", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookIssueCommentEditedIssueVariant1AuthorAssociation AuthorAssociation { get; set; } = default!;

        /// <summary>
        /// Contents of the issue
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("body", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Body { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("closed_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime? ClosedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("comments", Required = global::Newtonsoft.Json.Required.Always)]
        public int Comments { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("comments_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string CommentsUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("draft")]
        public bool? Draft { get; set; }

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
        [global::Newtonsoft.Json.JsonProperty("labels")]
        public global::System.Collections.Generic.IList<global::G.WebhookIssueCommentEditedIssueVariant1Label>? Labels { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("labels_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string LabelsUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("locked")]
        public bool? Locked { get; set; }

        /// <summary>
        /// A collection of related issues and pull requests.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("milestone", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookIssueCommentEditedIssueVariant1Milestone? Milestone { get; set; } = default!;

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
        /// GitHub apps are a new way to extend GitHub. They can be installed directly on organizations and user accounts and granted access to specific repositories. They come with granular permissions and built-in webhooks. GitHub apps are first class actors within GitHub.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("performed_via_github_app")]
        public global::G.WebhookIssueCommentEditedIssueVariant1PerformedViaGithubApp? PerformedViaGithubApp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pull_request")]
        public global::G.WebhookIssueCommentEditedIssueVariant1PullRequest? PullRequest { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reactions", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookIssueCommentEditedIssueVariant1Reactions Reactions { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repository_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string RepositoryUrl { get; set; } = default!;

        /// <summary>
        /// State of the issue; either 'open' or 'closed'
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("state")]
        public global::G.WebhookIssueCommentEditedIssueVariant1State? State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("state_reason")]
        public string? StateReason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timeline_url")]
        public string? TimelineUrl { get; set; }

        /// <summary>
        /// Title of the issue
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title", Required = global::Newtonsoft.Json.Required.Always)]
        public string Title { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// URL for the issue
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookIssueCommentEditedIssueVariant1User? User { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookIssueCommentEditedIssueVariant1" /> class.
        /// </summary>
        /// <param name="activeLockReason"></param>
        /// <param name="assignee"></param>
        /// <param name="assignees"></param>
        /// <param name="authorAssociation">
        /// How the author is associated with the repository.
        /// </param>
        /// <param name="body">
        /// Contents of the issue
        /// </param>
        /// <param name="closedAt"></param>
        /// <param name="comments"></param>
        /// <param name="commentsUrl"></param>
        /// <param name="createdAt"></param>
        /// <param name="draft"></param>
        /// <param name="eventsUrl"></param>
        /// <param name="htmlUrl"></param>
        /// <param name="id"></param>
        /// <param name="labels"></param>
        /// <param name="labelsUrl"></param>
        /// <param name="locked"></param>
        /// <param name="milestone">
        /// A collection of related issues and pull requests.
        /// </param>
        /// <param name="nodeId"></param>
        /// <param name="number"></param>
        /// <param name="performedViaGithubApp">
        /// GitHub apps are a new way to extend GitHub. They can be installed directly on organizations and user accounts and granted access to specific repositories. They come with granular permissions and built-in webhooks. GitHub apps are first class actors within GitHub.
        /// </param>
        /// <param name="pullRequest"></param>
        /// <param name="reactions"></param>
        /// <param name="repositoryUrl"></param>
        /// <param name="state">
        /// State of the issue; either 'open' or 'closed'
        /// </param>
        /// <param name="stateReason"></param>
        /// <param name="timelineUrl"></param>
        /// <param name="title">
        /// Title of the issue
        /// </param>
        /// <param name="updatedAt"></param>
        /// <param name="url">
        /// URL for the issue
        /// </param>
        /// <param name="user"></param>
        public WebhookIssueCommentEditedIssueVariant1(
            global::G.WebhookIssueCommentEditedIssueVariant1ActiveLockReason? activeLockReason,
            global::System.Collections.Generic.IList<global::G.WebhookIssueCommentEditedIssueVariant1Assignee2> assignees,
            global::G.WebhookIssueCommentEditedIssueVariant1AuthorAssociation authorAssociation,
            string? body,
            global::System.DateTime? closedAt,
            int comments,
            string commentsUrl,
            global::System.DateTime createdAt,
            string eventsUrl,
            string htmlUrl,
            long id,
            string labelsUrl,
            global::G.WebhookIssueCommentEditedIssueVariant1Milestone? milestone,
            string nodeId,
            int number,
            global::G.WebhookIssueCommentEditedIssueVariant1Reactions reactions,
            string repositoryUrl,
            string title,
            global::System.DateTime updatedAt,
            string url,
            global::G.WebhookIssueCommentEditedIssueVariant1User? user,
            global::G.WebhookIssueCommentEditedIssueVariant1Assignee? assignee,
            bool? draft,
            global::System.Collections.Generic.IList<global::G.WebhookIssueCommentEditedIssueVariant1Label>? labels,
            bool? locked,
            global::G.WebhookIssueCommentEditedIssueVariant1PerformedViaGithubApp? performedViaGithubApp,
            global::G.WebhookIssueCommentEditedIssueVariant1PullRequest? pullRequest,
            global::G.WebhookIssueCommentEditedIssueVariant1State? state,
            string? stateReason,
            string? timelineUrl)
        {
            this.ActiveLockReason = activeLockReason;
            this.Assignees = assignees ?? throw new global::System.ArgumentNullException(nameof(assignees));
            this.AuthorAssociation = authorAssociation;
            this.Body = body ?? throw new global::System.ArgumentNullException(nameof(body));
            this.ClosedAt = closedAt;
            this.Comments = comments;
            this.CommentsUrl = commentsUrl ?? throw new global::System.ArgumentNullException(nameof(commentsUrl));
            this.CreatedAt = createdAt;
            this.EventsUrl = eventsUrl ?? throw new global::System.ArgumentNullException(nameof(eventsUrl));
            this.HtmlUrl = htmlUrl ?? throw new global::System.ArgumentNullException(nameof(htmlUrl));
            this.Id = id;
            this.LabelsUrl = labelsUrl ?? throw new global::System.ArgumentNullException(nameof(labelsUrl));
            this.Milestone = milestone ?? throw new global::System.ArgumentNullException(nameof(milestone));
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.Number = number;
            this.Reactions = reactions ?? throw new global::System.ArgumentNullException(nameof(reactions));
            this.RepositoryUrl = repositoryUrl ?? throw new global::System.ArgumentNullException(nameof(repositoryUrl));
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.UpdatedAt = updatedAt;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.User = user ?? throw new global::System.ArgumentNullException(nameof(user));
            this.Assignee = assignee;
            this.Draft = draft;
            this.Labels = labels;
            this.Locked = locked;
            this.PerformedViaGithubApp = performedViaGithubApp;
            this.PullRequest = pullRequest;
            this.State = state;
            this.StateReason = stateReason;
            this.TimelineUrl = timelineUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookIssueCommentEditedIssueVariant1" /> class.
        /// </summary>
        public WebhookIssueCommentEditedIssueVariant1()
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
        public static global::G.WebhookIssueCommentEditedIssueVariant1? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.WebhookIssueCommentEditedIssueVariant1>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.WebhookIssueCommentEditedIssueVariant1?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.WebhookIssueCommentEditedIssueVariant1?>(serializer.Deserialize<global::G.WebhookIssueCommentEditedIssueVariant1>(jsonReader));
        }

    }
}