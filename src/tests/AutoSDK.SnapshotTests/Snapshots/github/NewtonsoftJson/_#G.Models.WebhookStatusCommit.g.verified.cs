//HintName: G.Models.WebhookStatusCommit.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookStatusCommit
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("author")]
        public global::G.WebhookStatusCommitAuthor? Author { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("comments_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string CommentsUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("commit", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookStatusCommitCommit Commit { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("committer")]
        public global::G.WebhookStatusCommitCommitter? Committer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("html_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string HtmlUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parents", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.WebhookStatusCommitParent> Parents { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sha", Required = global::Newtonsoft.Json.Required.Always)]
        public string Sha { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookStatusCommit" /> class.
        /// </summary>
        /// <param name="commentsUrl"></param>
        /// <param name="commit"></param>
        /// <param name="htmlUrl"></param>
        /// <param name="nodeId"></param>
        /// <param name="parents"></param>
        /// <param name="sha"></param>
        /// <param name="url"></param>
        /// <param name="author"></param>
        /// <param name="committer"></param>
        public WebhookStatusCommit(
            string commentsUrl,
            global::G.WebhookStatusCommitCommit commit,
            string htmlUrl,
            string nodeId,
            global::System.Collections.Generic.IList<global::G.WebhookStatusCommitParent> parents,
            string sha,
            string url,
            global::G.WebhookStatusCommitAuthor? author,
            global::G.WebhookStatusCommitCommitter? committer)
        {
            this.Author = author;
            this.CommentsUrl = commentsUrl ?? throw new global::System.ArgumentNullException(nameof(commentsUrl));
            this.Commit = commit ?? throw new global::System.ArgumentNullException(nameof(commit));
            this.Committer = committer;
            this.HtmlUrl = htmlUrl ?? throw new global::System.ArgumentNullException(nameof(htmlUrl));
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.Parents = parents ?? throw new global::System.ArgumentNullException(nameof(parents));
            this.Sha = sha ?? throw new global::System.ArgumentNullException(nameof(sha));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookStatusCommit" /> class.
        /// </summary>
        public WebhookStatusCommit()
        {
        }
    }
}