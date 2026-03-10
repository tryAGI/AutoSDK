//HintName: G.Models.WebhookCommitCommentCreatedComment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The [commit comment](${externalDocsUpapp/api/description/components/schemas/webhooks/issue-comment-created.yamlrl}/rest/commits/comments#get-a-commit-comment) resource.
    /// </summary>
    public sealed partial class WebhookCommitCommentCreatedComment
    {
        /// <summary>
        /// How the author is associated with the repository.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("author_association", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookCommitCommentCreatedCommentAuthorAssociation AuthorAssociation { get; set; } = default!;

        /// <summary>
        /// The text of the comment.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("body", Required = global::Newtonsoft.Json.Required.Always)]
        public string Body { get; set; } = default!;

        /// <summary>
        /// The SHA of the commit to which the comment applies.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("commit_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string CommitId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("html_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string HtmlUrl { get; set; } = default!;

        /// <summary>
        /// The ID of the commit comment.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// The line of the blob to which the comment applies. The last line of the range for a multi-line comment
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("line")]
        public int? Line { get; set; }

        /// <summary>
        /// The node ID of the commit comment.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// The relative path of the file to which the comment applies.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("path")]
        public string? Path { get; set; }

        /// <summary>
        /// The line index in the diff to which the comment applies.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("position")]
        public int? Position { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reactions")]
        public global::G.WebhookCommitCommentCreatedCommentReactions? Reactions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string UpdatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user")]
        public global::G.WebhookCommitCommentCreatedCommentUser? User { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookCommitCommentCreatedComment" /> class.
        /// </summary>
        /// <param name="authorAssociation">
        /// How the author is associated with the repository.
        /// </param>
        /// <param name="body">
        /// The text of the comment.
        /// </param>
        /// <param name="commitId">
        /// The SHA of the commit to which the comment applies.
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="htmlUrl"></param>
        /// <param name="id">
        /// The ID of the commit comment.
        /// </param>
        /// <param name="line">
        /// The line of the blob to which the comment applies. The last line of the range for a multi-line comment
        /// </param>
        /// <param name="nodeId">
        /// The node ID of the commit comment.
        /// </param>
        /// <param name="path">
        /// The relative path of the file to which the comment applies.
        /// </param>
        /// <param name="position">
        /// The line index in the diff to which the comment applies.
        /// </param>
        /// <param name="reactions"></param>
        /// <param name="updatedAt"></param>
        /// <param name="url"></param>
        /// <param name="user"></param>
        public WebhookCommitCommentCreatedComment(
            global::G.WebhookCommitCommentCreatedCommentAuthorAssociation authorAssociation,
            string body,
            string commitId,
            string createdAt,
            string htmlUrl,
            int id,
            string nodeId,
            string updatedAt,
            string url,
            int? line,
            string? path,
            int? position,
            global::G.WebhookCommitCommentCreatedCommentReactions? reactions,
            global::G.WebhookCommitCommentCreatedCommentUser? user)
        {
            this.AuthorAssociation = authorAssociation;
            this.Body = body ?? throw new global::System.ArgumentNullException(nameof(body));
            this.CommitId = commitId ?? throw new global::System.ArgumentNullException(nameof(commitId));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.HtmlUrl = htmlUrl ?? throw new global::System.ArgumentNullException(nameof(htmlUrl));
            this.Id = id;
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.UpdatedAt = updatedAt ?? throw new global::System.ArgumentNullException(nameof(updatedAt));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Line = line;
            this.Path = path;
            this.Position = position;
            this.Reactions = reactions;
            this.User = user;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookCommitCommentCreatedComment" /> class.
        /// </summary>
        public WebhookCommitCommentCreatedComment()
        {
        }
    }
}