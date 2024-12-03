//HintName: G.Models.TimelineReviewedEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Timeline Reviewed Event
    /// </summary>
    public sealed partial class TimelineReviewedEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Event { get; set; }

        /// <summary>
        /// Unique identifier of the review<br/>
        /// Example: 42
        /// </summary>
        /// <example>42</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// Example: MDE3OlB1bGxSZXF1ZXN0UmV2aWV3ODA=
        /// </summary>
        /// <example>MDE3OlB1bGxSZXF1ZXN0UmV2aWV3ODA=</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SimpleUser User { get; set; }

        /// <summary>
        /// The text of the review.<br/>
        /// Example: This looks great.
        /// </summary>
        /// <example>This looks great.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Body { get; set; }

        /// <summary>
        /// Example: CHANGES_REQUESTED
        /// </summary>
        /// <example>CHANGES_REQUESTED</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string State { get; set; }

        /// <summary>
        /// Example: https://github.com/octocat/Hello-World/pull/12#pullrequestreview-80
        /// </summary>
        /// <example>https://github.com/octocat/Hello-World/pull/12#pullrequestreview-80</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HtmlUrl { get; set; }

        /// <summary>
        /// Example: https://api.github.com/repos/octocat/Hello-World/pulls/12
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/pulls/12</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("pull_request_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PullRequestUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_links")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.TimelineReviewedEventLinks Links { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("submitted_at")]
        public global::System.DateTime? SubmittedAt { get; set; }

        /// <summary>
        /// A commit SHA for the review.<br/>
        /// Example: 54bb654c9e6025347f57900a4a5c2313a96b8035
        /// </summary>
        /// <example>54bb654c9e6025347f57900a4a5c2313a96b8035</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CommitId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body_html")]
        public string? BodyHtml { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body_text")]
        public string? BodyText { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TimelineReviewedEvent" /> class.
        /// </summary>
        /// <param name="event"></param>
        /// <param name="id">
        /// Unique identifier of the review<br/>
        /// Example: 42
        /// </param>
        /// <param name="nodeId">
        /// Example: MDE3OlB1bGxSZXF1ZXN0UmV2aWV3ODA=
        /// </param>
        /// <param name="user">
        /// A GitHub user.
        /// </param>
        /// <param name="body">
        /// The text of the review.<br/>
        /// Example: This looks great.
        /// </param>
        /// <param name="state">
        /// Example: CHANGES_REQUESTED
        /// </param>
        /// <param name="htmlUrl">
        /// Example: https://github.com/octocat/Hello-World/pull/12#pullrequestreview-80
        /// </param>
        /// <param name="pullRequestUrl">
        /// Example: https://api.github.com/repos/octocat/Hello-World/pulls/12
        /// </param>
        /// <param name="links"></param>
        /// <param name="submittedAt"></param>
        /// <param name="commitId">
        /// A commit SHA for the review.<br/>
        /// Example: 54bb654c9e6025347f57900a4a5c2313a96b8035
        /// </param>
        /// <param name="bodyHtml"></param>
        /// <param name="bodyText"></param>
        /// <param name="authorAssociation">
        /// How the author is associated with the repository.<br/>
        /// Example: OWNER
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public TimelineReviewedEvent(
            string @event,
            int id,
            string nodeId,
            global::G.SimpleUser user,
            string? body,
            string state,
            string htmlUrl,
            string pullRequestUrl,
            global::G.TimelineReviewedEventLinks links,
            string commitId,
            global::G.AuthorAssociation authorAssociation,
            global::System.DateTime? submittedAt,
            string? bodyHtml,
            string? bodyText)
        {
            this.Event = @event ?? throw new global::System.ArgumentNullException(nameof(@event));
            this.Id = id;
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.User = user ?? throw new global::System.ArgumentNullException(nameof(user));
            this.Body = body ?? throw new global::System.ArgumentNullException(nameof(body));
            this.State = state ?? throw new global::System.ArgumentNullException(nameof(state));
            this.HtmlUrl = htmlUrl ?? throw new global::System.ArgumentNullException(nameof(htmlUrl));
            this.PullRequestUrl = pullRequestUrl ?? throw new global::System.ArgumentNullException(nameof(pullRequestUrl));
            this.Links = links ?? throw new global::System.ArgumentNullException(nameof(links));
            this.CommitId = commitId ?? throw new global::System.ArgumentNullException(nameof(commitId));
            this.AuthorAssociation = authorAssociation;
            this.SubmittedAt = submittedAt;
            this.BodyHtml = bodyHtml;
            this.BodyText = bodyText;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TimelineReviewedEvent" /> class.
        /// </summary>
        public TimelineReviewedEvent()
        {
        }
    }
}