//HintName: G.Models.WebhooksComment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhooksComment
    {
        /// <summary>
        /// How the author is associated with the repository.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("author_association", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhooksCommentAuthorAssociation AuthorAssociation { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("body", Required = global::Newtonsoft.Json.Required.Always)]
        public string Body { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("child_comment_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int ChildCommentCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("discussion_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int DiscussionId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("html_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string HtmlUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parent_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int? ParentId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reactions", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhooksCommentReactions Reactions { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repository_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string RepositoryUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string UpdatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhooksCommentUser? User { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksComment" /> class.
        /// </summary>
        /// <param name="authorAssociation">
        /// How the author is associated with the repository.
        /// </param>
        /// <param name="body"></param>
        /// <param name="childCommentCount"></param>
        /// <param name="createdAt"></param>
        /// <param name="discussionId"></param>
        /// <param name="htmlUrl"></param>
        /// <param name="id"></param>
        /// <param name="nodeId"></param>
        /// <param name="parentId"></param>
        /// <param name="reactions"></param>
        /// <param name="repositoryUrl"></param>
        /// <param name="updatedAt"></param>
        /// <param name="user"></param>
        public WebhooksComment(
            global::G.WebhooksCommentAuthorAssociation authorAssociation,
            string body,
            int childCommentCount,
            string createdAt,
            int discussionId,
            string htmlUrl,
            int id,
            string nodeId,
            int? parentId,
            global::G.WebhooksCommentReactions reactions,
            string repositoryUrl,
            string updatedAt,
            global::G.WebhooksCommentUser? user)
        {
            this.AuthorAssociation = authorAssociation;
            this.Body = body ?? throw new global::System.ArgumentNullException(nameof(body));
            this.ChildCommentCount = childCommentCount;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.DiscussionId = discussionId;
            this.HtmlUrl = htmlUrl ?? throw new global::System.ArgumentNullException(nameof(htmlUrl));
            this.Id = id;
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.ParentId = parentId;
            this.Reactions = reactions ?? throw new global::System.ArgumentNullException(nameof(reactions));
            this.RepositoryUrl = repositoryUrl ?? throw new global::System.ArgumentNullException(nameof(repositoryUrl));
            this.UpdatedAt = updatedAt ?? throw new global::System.ArgumentNullException(nameof(updatedAt));
            this.User = user ?? throw new global::System.ArgumentNullException(nameof(user));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksComment" /> class.
        /// </summary>
        public WebhooksComment()
        {
        }
    }
}