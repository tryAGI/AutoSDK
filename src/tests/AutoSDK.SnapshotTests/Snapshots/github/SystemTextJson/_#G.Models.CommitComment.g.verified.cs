//HintName: G.Models.CommitComment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Commit Comment
    /// </summary>
    public sealed partial class CommitComment
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HtmlUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Body { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? Path { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("position")]
        public int? Position { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("line")]
        public int? Line { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CommitId { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public global::G.NullableSimpleUser? User { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

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
        /// Initializes a new instance of the <see cref="CommitComment" /> class.
        /// </summary>
        /// <param name="htmlUrl"></param>
        /// <param name="url"></param>
        /// <param name="id"></param>
        /// <param name="nodeId"></param>
        /// <param name="body"></param>
        /// <param name="commitId"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="authorAssociation">
        /// How the author is associated with the repository.<br/>
        /// Example: OWNER
        /// </param>
        /// <param name="path"></param>
        /// <param name="position"></param>
        /// <param name="line"></param>
        /// <param name="user">
        /// A GitHub user.
        /// </param>
        /// <param name="reactions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CommitComment(
            string htmlUrl,
            string url,
            int id,
            string nodeId,
            string body,
            string commitId,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::G.AuthorAssociation authorAssociation,
            string? path,
            int? position,
            int? line,
            global::G.NullableSimpleUser? user,
            global::G.ReactionRollup? reactions)
        {
            this.HtmlUrl = htmlUrl ?? throw new global::System.ArgumentNullException(nameof(htmlUrl));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Id = id;
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.Body = body ?? throw new global::System.ArgumentNullException(nameof(body));
            this.Path = path;
            this.Position = position;
            this.Line = line;
            this.CommitId = commitId ?? throw new global::System.ArgumentNullException(nameof(commitId));
            this.User = user;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.AuthorAssociation = authorAssociation;
            this.Reactions = reactions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommitComment" /> class.
        /// </summary>
        public CommitComment()
        {
        }
    }
}