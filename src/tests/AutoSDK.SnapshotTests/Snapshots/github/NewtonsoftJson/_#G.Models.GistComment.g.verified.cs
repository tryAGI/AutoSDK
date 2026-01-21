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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Example: MDExOkdpc3RDb21tZW50MQ==
        /// </summary>
        /// <example>MDExOkdpc3RDb21tZW50MQ==</example>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/gists/a6db0bec360bb87e9418/comments/1
        /// </summary>
        /// <example>https://api.github.com/gists/a6db0bec360bb87e9418/comments/1</example>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// The comment text.<br/>
        /// Example: Body of the attachment
        /// </summary>
        /// <example>Body of the attachment</example>
        [global::Newtonsoft.Json.JsonProperty("body", Required = global::Newtonsoft.Json.Required.Always)]
        public string Body { get; set; } = default!;

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.NullableSimpleUser? User { get; set; } = default!;

        /// <summary>
        /// Example: 2011-04-18T23:23:56Z
        /// </summary>
        /// <example>2011-04-18T23:23:56Z</example>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// Example: 2011-04-18T23:23:56Z
        /// </summary>
        /// <example>2011-04-18T23:23:56Z</example>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// How the author is associated with the repository.<br/>
        /// Example: OWNER
        /// </summary>
        /// <example>OWNER</example>
        [global::Newtonsoft.Json.JsonProperty("author_association", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AuthorAssociation AuthorAssociation { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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
        /// <param name="createdAt">
        /// Example: 2011-04-18T23:23:56Z
        /// </param>
        /// <param name="updatedAt">
        /// Example: 2011-04-18T23:23:56Z
        /// </param>
        /// <param name="authorAssociation">
        /// How the author is associated with the repository.<br/>
        /// Example: OWNER
        /// </param>
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