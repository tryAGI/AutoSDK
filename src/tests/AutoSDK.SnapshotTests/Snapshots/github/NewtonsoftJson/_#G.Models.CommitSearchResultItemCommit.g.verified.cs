﻿//HintName: G.Models.CommitSearchResultItemCommit.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CommitSearchResultItemCommit
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("author", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CommitSearchResultItemCommitAuthor Author { get; set; } = default!;

        /// <summary>
        /// Metaproperties for Git author/committer information.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("committer", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.NullableGitUser? Committer { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("comment_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int CommentCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tree", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CommitSearchResultItemCommitTree Tree { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("verification")]
        public global::G.Verification? Verification { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CommitSearchResultItemCommit" /> class.
        /// </summary>
        /// <param name="author"></param>
        /// <param name="committer">
        /// Metaproperties for Git author/committer information.
        /// </param>
        /// <param name="commentCount"></param>
        /// <param name="message"></param>
        /// <param name="tree"></param>
        /// <param name="url"></param>
        /// <param name="verification"></param>
        public CommitSearchResultItemCommit(
            global::G.CommitSearchResultItemCommitAuthor author,
            global::G.NullableGitUser? committer,
            int commentCount,
            string message,
            global::G.CommitSearchResultItemCommitTree tree,
            string url,
            global::G.Verification? verification)
        {
            this.Author = author ?? throw new global::System.ArgumentNullException(nameof(author));
            this.Committer = committer ?? throw new global::System.ArgumentNullException(nameof(committer));
            this.CommentCount = commentCount;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Tree = tree ?? throw new global::System.ArgumentNullException(nameof(tree));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Verification = verification;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommitSearchResultItemCommit" /> class.
        /// </summary>
        public CommitSearchResultItemCommit()
        {
        }
    }
}