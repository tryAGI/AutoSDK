﻿//HintName: G.Models.WebhooksIssueComment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The [comment](https://docs.github.com/rest/issues/comments#get-an-issue-comment) itself.
    /// </summary>
    public sealed partial class WebhooksIssueComment
    {
        /// <summary>
        /// How the author is associated with the repository.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("author_association", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhooksIssueCommentAuthorAssociation AuthorAssociation { get; set; } = default!;

        /// <summary>
        /// Contents of the issue comment
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("body", Required = global::Newtonsoft.Json.Required.Always)]
        public string Body { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("html_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string HtmlUrl { get; set; } = default!;

        /// <summary>
        /// Unique identifier of the issue comment
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public long Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("issue_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string IssueUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// GitHub apps are a new way to extend GitHub. They can be installed directly on organizations and user accounts and granted access to specific repositories. They come with granular permissions and built-in webhooks. GitHub apps are first class actors within GitHub.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("performed_via_github_app", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Integration? PerformedViaGithubApp { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reactions", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhooksIssueCommentReactions Reactions { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// URL for the issue comment
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhooksIssueCommentUser? User { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksIssueComment" /> class.
        /// </summary>
        /// <param name="authorAssociation">
        /// How the author is associated with the repository.
        /// </param>
        /// <param name="body">
        /// Contents of the issue comment
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="htmlUrl"></param>
        /// <param name="id">
        /// Unique identifier of the issue comment
        /// </param>
        /// <param name="issueUrl"></param>
        /// <param name="nodeId"></param>
        /// <param name="performedViaGithubApp">
        /// GitHub apps are a new way to extend GitHub. They can be installed directly on organizations and user accounts and granted access to specific repositories. They come with granular permissions and built-in webhooks. GitHub apps are first class actors within GitHub.
        /// </param>
        /// <param name="reactions"></param>
        /// <param name="updatedAt"></param>
        /// <param name="url">
        /// URL for the issue comment
        /// </param>
        /// <param name="user"></param>
        public WebhooksIssueComment(
            global::G.WebhooksIssueCommentAuthorAssociation authorAssociation,
            string body,
            global::System.DateTime createdAt,
            string htmlUrl,
            long id,
            string issueUrl,
            string nodeId,
            global::G.Integration? performedViaGithubApp,
            global::G.WebhooksIssueCommentReactions reactions,
            global::System.DateTime updatedAt,
            string url,
            global::G.WebhooksIssueCommentUser? user)
        {
            this.AuthorAssociation = authorAssociation;
            this.Body = body ?? throw new global::System.ArgumentNullException(nameof(body));
            this.CreatedAt = createdAt;
            this.HtmlUrl = htmlUrl ?? throw new global::System.ArgumentNullException(nameof(htmlUrl));
            this.Id = id;
            this.IssueUrl = issueUrl ?? throw new global::System.ArgumentNullException(nameof(issueUrl));
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.PerformedViaGithubApp = performedViaGithubApp ?? throw new global::System.ArgumentNullException(nameof(performedViaGithubApp));
            this.Reactions = reactions ?? throw new global::System.ArgumentNullException(nameof(reactions));
            this.UpdatedAt = updatedAt;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.User = user ?? throw new global::System.ArgumentNullException(nameof(user));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksIssueComment" /> class.
        /// </summary>
        public WebhooksIssueComment()
        {
        }
    }
}