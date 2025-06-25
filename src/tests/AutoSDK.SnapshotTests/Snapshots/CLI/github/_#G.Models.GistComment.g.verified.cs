//HintName: G.Models.GistComment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A comment made to a gist.
    /// </summary>
    public sealed partial class GistComment
    {
        /// <summary>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// Example: MDExOkdpc3RDb21tZW50MQ==
        /// </summary>
        /// <example>MDExOkdpc3RDb21tZW50MQ==</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// Example: https://api.github.com/gists/a6db0bec360bb87e9418/comments/1
        /// </summary>
        /// <example>https://api.github.com/gists/a6db0bec360bb87e9418/comments/1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// The comment text.<br/>
        /// Example: Body of the attachment
        /// </summary>
        /// <example>Body of the attachment</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Body { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.NullableSimpleUser? User { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GistComment" /> class.
        /// </summary>
        /// <param name="id">
        /// Example: 1
        /// </param>
        /// <param name="nodeId">
        /// Example: MDExOkdpc3RDb21tZW50MQ==
        /// </param>
        /// <param name="url">
        /// Example: https://api.github.com/gists/a6db0bec360bb87e9418/comments/1
        /// </param>
        /// <param name="body">
        /// The comment text.<br/>
        /// Example: Body of the attachment
        /// </param>
        /// <param name="user">
        /// A GitHub user.
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="authorAssociation">
        /// How the author is associated with the repository.<br/>
        /// Example: OWNER
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GistComment(
            int id,
            string nodeId,
            string url,
            string body,
            global::G.NullableSimpleUser? user,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::G.AuthorAssociation authorAssociation)
        {
            this.Id = id;
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Body = body ?? throw new global::System.ArgumentNullException(nameof(body));
            this.User = user ?? throw new global::System.ArgumentNullException(nameof(user));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.AuthorAssociation = authorAssociation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GistComment" /> class.
        /// </summary>
        public GistComment()
        {
        }
    }
}