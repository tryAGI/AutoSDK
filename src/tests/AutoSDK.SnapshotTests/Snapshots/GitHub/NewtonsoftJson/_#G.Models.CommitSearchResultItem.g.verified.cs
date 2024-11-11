//HintName: G.Models.CommitSearchResultItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Commit Search Result Item
    /// </summary>
    public sealed partial class CommitSearchResultItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sha", Required = global::Newtonsoft.Json.Required.Always)]
        public string Sha { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("html_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string HtmlUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("comments_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string CommentsUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("commit", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CommitSearchResultItemCommit Commit { get; set; } = default!;

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("author", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.NullableSimpleUser? Author { get; set; } = default!;

        /// <summary>
        /// Metaproperties for Git author/committer information.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("committer", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.NullableGitUser? Committer { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parents", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.CommitSearchResultItemParent> Parents { get; set; } = default!;

        /// <summary>
        /// Minimal Repository
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repository", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.MinimalRepository Repository { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("score", Required = global::Newtonsoft.Json.Required.Always)]
        public double Score { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text_matches")]
        public global::System.Collections.Generic.IList<global::G.SearchResultTextMatche>? TextMatches { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CommitSearchResultItem" /> class.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="sha"></param>
        /// <param name="htmlUrl"></param>
        /// <param name="commentsUrl"></param>
        /// <param name="commit"></param>
        /// <param name="author">
        /// A GitHub user.
        /// </param>
        /// <param name="committer">
        /// Metaproperties for Git author/committer information.
        /// </param>
        /// <param name="parents"></param>
        /// <param name="repository">
        /// Minimal Repository
        /// </param>
        /// <param name="score"></param>
        /// <param name="nodeId"></param>
        /// <param name="textMatches"></param>
        public CommitSearchResultItem(
            string url,
            string sha,
            string htmlUrl,
            string commentsUrl,
            global::G.CommitSearchResultItemCommit commit,
            global::G.NullableSimpleUser? author,
            global::G.NullableGitUser? committer,
            global::System.Collections.Generic.IList<global::G.CommitSearchResultItemParent> parents,
            global::G.MinimalRepository repository,
            double score,
            string nodeId,
            global::System.Collections.Generic.IList<global::G.SearchResultTextMatche>? textMatches)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Sha = sha ?? throw new global::System.ArgumentNullException(nameof(sha));
            this.HtmlUrl = htmlUrl ?? throw new global::System.ArgumentNullException(nameof(htmlUrl));
            this.CommentsUrl = commentsUrl ?? throw new global::System.ArgumentNullException(nameof(commentsUrl));
            this.Commit = commit ?? throw new global::System.ArgumentNullException(nameof(commit));
            this.Author = author ?? throw new global::System.ArgumentNullException(nameof(author));
            this.Committer = committer ?? throw new global::System.ArgumentNullException(nameof(committer));
            this.Parents = parents ?? throw new global::System.ArgumentNullException(nameof(parents));
            this.Repository = repository ?? throw new global::System.ArgumentNullException(nameof(repository));
            this.Score = score;
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.TextMatches = textMatches;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommitSearchResultItem" /> class.
        /// </summary>
        public CommitSearchResultItem()
        {
        }
    }
}