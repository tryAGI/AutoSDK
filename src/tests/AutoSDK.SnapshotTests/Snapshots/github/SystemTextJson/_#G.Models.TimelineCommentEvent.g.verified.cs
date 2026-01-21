//HintName: G.Models.TimelineCommentEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Timeline Comment Event
    /// </summary>
    public sealed partial class TimelineCommentEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Event { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actor")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SimpleUser Actor { get; set; }

        /// <summary>
        /// Unique identifier of the issue comment<br/>
        /// Example: 42
        /// </summary>
        /// <example>42</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// URL for the issue comment<br/>
        /// Example: https://api.github.com/repositories/42/issues/comments/1
        /// </summary>
        /// <example>https://api.github.com/repositories/42/issues/comments/1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Contents of the issue comment<br/>
        /// Example: What version of Safari were you using when you observed this bug?
        /// </summary>
        /// <example>What version of Safari were you using when you observed this bug?</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        public string? Body { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body_text")]
        public string? BodyText { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body_html")]
        public string? BodyHtml { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HtmlUrl { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SimpleUser User { get; set; }

        /// <summary>
        /// Example: 2011-04-14T16:00:49Z
        /// </summary>
        /// <example>2011-04-14T16:00:49Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Example: 2011-04-14T16:00:49Z
        /// </summary>
        /// <example>2011-04-14T16:00:49Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issue_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IssueUrl { get; set; }

        /// <summary>
        /// How the author is associated with the repository.<br/>
        /// Example: OWNER
        /// </summary>
        /// <example>OWNER</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("author_association")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AuthorAssociationJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AuthorAssociation AuthorAssociation { get; set; }

        /// <summary>
        /// GitHub apps are a new way to extend GitHub. They can be installed directly on organizations and user accounts and granted access to specific repositories. They come with granular permissions and built-in webhooks. GitHub apps are first class actors within GitHub.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("performed_via_github_app")]
        public global::G.NullableIntegration? PerformedViaGithubApp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reactions")]
        public global::G.ReactionRollup? Reactions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TimelineCommentEvent" /> class.
        /// </summary>
        /// <param name="event"></param>
        /// <param name="actor">
        /// A GitHub user.
        /// </param>
        /// <param name="id">
        /// Unique identifier of the issue comment<br/>
        /// Example: 42
        /// </param>
        /// <param name="nodeId"></param>
        /// <param name="url">
        /// URL for the issue comment<br/>
        /// Example: https://api.github.com/repositories/42/issues/comments/1
        /// </param>
        /// <param name="body">
        /// Contents of the issue comment<br/>
        /// Example: What version of Safari were you using when you observed this bug?
        /// </param>
        /// <param name="bodyText"></param>
        /// <param name="bodyHtml"></param>
        /// <param name="htmlUrl"></param>
        /// <param name="user">
        /// A GitHub user.
        /// </param>
        /// <param name="createdAt">
        /// Example: 2011-04-14T16:00:49Z
        /// </param>
        /// <param name="updatedAt">
        /// Example: 2011-04-14T16:00:49Z
        /// </param>
        /// <param name="issueUrl"></param>
        /// <param name="authorAssociation">
        /// How the author is associated with the repository.<br/>
        /// Example: OWNER
        /// </param>
        /// <param name="performedViaGithubApp">
        /// GitHub apps are a new way to extend GitHub. They can be installed directly on organizations and user accounts and granted access to specific repositories. They come with granular permissions and built-in webhooks. GitHub apps are first class actors within GitHub.
        /// </param>
        /// <param name="reactions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TimelineCommentEvent(
            string @event,
            global::G.SimpleUser actor,
            int id,
            string nodeId,
            string url,
            string htmlUrl,
            global::G.SimpleUser user,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string issueUrl,
            global::G.AuthorAssociation authorAssociation,
            string? body,
            string? bodyText,
            string? bodyHtml,
            global::G.NullableIntegration? performedViaGithubApp,
            global::G.ReactionRollup? reactions)
        {
            this.Event = @event ?? throw new global::System.ArgumentNullException(nameof(@event));
            this.Actor = actor ?? throw new global::System.ArgumentNullException(nameof(actor));
            this.Id = id;
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.HtmlUrl = htmlUrl ?? throw new global::System.ArgumentNullException(nameof(htmlUrl));
            this.User = user ?? throw new global::System.ArgumentNullException(nameof(user));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.IssueUrl = issueUrl ?? throw new global::System.ArgumentNullException(nameof(issueUrl));
            this.AuthorAssociation = authorAssociation;
            this.Body = body;
            this.BodyText = bodyText;
            this.BodyHtml = bodyHtml;
            this.PerformedViaGithubApp = performedViaGithubApp;
            this.Reactions = reactions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TimelineCommentEvent" /> class.
        /// </summary>
        public TimelineCommentEvent()
        {
        }
    }
}