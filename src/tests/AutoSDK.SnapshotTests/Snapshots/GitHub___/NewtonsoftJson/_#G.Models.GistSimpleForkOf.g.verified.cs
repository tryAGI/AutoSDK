//HintName: G.Models.GistSimpleForkOf.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Gist
    /// </summary>
    public sealed partial class GistSimpleForkOf
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("forks_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string ForksUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("commits_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string CommitsUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("git_pull_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string GitPullUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("git_push_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string GitPushUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("html_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string HtmlUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("files", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, global::G.GistSimpleForkOfFiles2> Files { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("public", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Public { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Description { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("comments", Required = global::Newtonsoft.Json.Required.Always)]
        public int Comments { get; set; } = default!;

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.NullableSimpleUser? User { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("comments_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string CommentsUrl { get; set; } = default!;

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("owner")]
        public global::G.NullableSimpleUser? Owner { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("truncated")]
        public bool? Truncated { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("forks")]
        public global::System.Collections.Generic.IList<object>? Forks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("history")]
        public global::System.Collections.Generic.IList<object>? History { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GistSimpleForkOf" /> class.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="forksUrl"></param>
        /// <param name="commitsUrl"></param>
        /// <param name="id"></param>
        /// <param name="nodeId"></param>
        /// <param name="gitPullUrl"></param>
        /// <param name="gitPushUrl"></param>
        /// <param name="htmlUrl"></param>
        /// <param name="files"></param>
        /// <param name="public"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="description"></param>
        /// <param name="comments"></param>
        /// <param name="user">
        /// A GitHub user.
        /// </param>
        /// <param name="commentsUrl"></param>
        /// <param name="owner">
        /// A GitHub user.
        /// </param>
        /// <param name="truncated"></param>
        /// <param name="forks"></param>
        /// <param name="history"></param>
        public GistSimpleForkOf(
            string url,
            string forksUrl,
            string commitsUrl,
            string id,
            string nodeId,
            string gitPullUrl,
            string gitPushUrl,
            string htmlUrl,
            global::System.Collections.Generic.Dictionary<string, global::G.GistSimpleForkOfFiles2> files,
            bool @public,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? description,
            int comments,
            global::G.NullableSimpleUser? user,
            string commentsUrl,
            global::G.NullableSimpleUser? owner,
            bool? truncated,
            global::System.Collections.Generic.IList<object>? forks,
            global::System.Collections.Generic.IList<object>? history)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.ForksUrl = forksUrl ?? throw new global::System.ArgumentNullException(nameof(forksUrl));
            this.CommitsUrl = commitsUrl ?? throw new global::System.ArgumentNullException(nameof(commitsUrl));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.GitPullUrl = gitPullUrl ?? throw new global::System.ArgumentNullException(nameof(gitPullUrl));
            this.GitPushUrl = gitPushUrl ?? throw new global::System.ArgumentNullException(nameof(gitPushUrl));
            this.HtmlUrl = htmlUrl ?? throw new global::System.ArgumentNullException(nameof(htmlUrl));
            this.Files = files ?? throw new global::System.ArgumentNullException(nameof(files));
            this.Public = @public;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Comments = comments;
            this.User = user ?? throw new global::System.ArgumentNullException(nameof(user));
            this.CommentsUrl = commentsUrl ?? throw new global::System.ArgumentNullException(nameof(commentsUrl));
            this.Owner = owner;
            this.Truncated = truncated;
            this.Forks = forks;
            this.History = history;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GistSimpleForkOf" /> class.
        /// </summary>
        public GistSimpleForkOf()
        {
        }
    }
}