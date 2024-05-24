//HintName: G.Models.WebhookCommitCommentCreatedComment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The [commit comment](https://docs.github.com/rest/commits/comments#get-a-commit-comment) resource.
    /// </summary>
    public sealed partial class WebhookCommitCommentCreatedComment
    {
        /// <summary>
        /// How the author is associated with the repository.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("author_association", Required = global::Newtonsoft.Json.Required.Always)]
        public WebhookCommitCommentCreatedCommentAuthorAssociation AuthorAssociation { get; set; } = default!;

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
        [global::Newtonsoft.Json.JsonProperty("line", Required = global::Newtonsoft.Json.Required.Always)]
        public int? Line { get; set; } = default!;

        /// <summary>
        /// The node ID of the commit comment.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// The relative path of the file to which the comment applies.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("path", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Path { get; set; } = default!;

        /// <summary>
        /// The line index in the diff to which the comment applies.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("position", Required = global::Newtonsoft.Json.Required.Always)]
        public int? Position { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reactions")]
        public WebhookCommitCommentCreatedCommentReactions? Reactions { get; set; }

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
        [global::Newtonsoft.Json.JsonProperty("user", Required = global::Newtonsoft.Json.Required.Always)]
        public WebhookCommitCommentCreatedCommentUser? User { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}