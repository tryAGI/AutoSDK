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
        [global::System.Text.Json.Serialization.JsonPropertyName("author_association")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookCommitCommentCreatedCommentAuthorAssociationJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhookCommitCommentCreatedCommentAuthorAssociation AuthorAssociation { get; set; }

        /// <summary>
        /// The text of the comment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Body { get; set; }

        /// <summary>
        /// The SHA of the commit to which the comment applies.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CommitId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HtmlUrl { get; set; }

        /// <summary>
        /// The ID of the commit comment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// The line of the blob to which the comment applies. The last line of the range for a multi-line comment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("line")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int? Line { get; set; }

        /// <summary>
        /// The node ID of the commit comment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// The relative path of the file to which the comment applies.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Path { get; set; }

        /// <summary>
        /// The line index in the diff to which the comment applies.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("position")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int? Position { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reactions")]
        public global::G.WebhookCommitCommentCreatedCommentReactions? Reactions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhookCommitCommentCreatedCommentUser? User { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public WebhookCommitCommentCreatedComment(
            global::G.WebhookCommitCommentCreatedCommentAuthorAssociation authorAssociation,
            string body,
            string commitId,
            string createdAt,
            string htmlUrl,
            int id,
            int? line,
            string nodeId,
            string? path,
            int? position,
            string updatedAt,
            string url,
            global::G.WebhookCommitCommentCreatedCommentUser? user,
            global::G.WebhookCommitCommentCreatedCommentReactions? reactions)
        {
            this.AuthorAssociation = authorAssociation;
            this.Body = body ?? throw new global::System.ArgumentNullException(nameof(body));
            this.CommitId = commitId ?? throw new global::System.ArgumentNullException(nameof(commitId));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.HtmlUrl = htmlUrl ?? throw new global::System.ArgumentNullException(nameof(htmlUrl));
            this.Id = id;
            this.Line = line;
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.Position = position;
            this.UpdatedAt = updatedAt ?? throw new global::System.ArgumentNullException(nameof(updatedAt));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.User = user ?? throw new global::System.ArgumentNullException(nameof(user));
            this.Reactions = reactions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookCommitCommentCreatedComment" /> class.
        /// </summary>
        public WebhookCommitCommentCreatedComment()
        {
        }
    }
}