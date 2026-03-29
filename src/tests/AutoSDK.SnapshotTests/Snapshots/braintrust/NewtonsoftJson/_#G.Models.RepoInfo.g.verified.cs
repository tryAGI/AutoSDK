//HintName: G.Models.RepoInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Metadata about the state of the repo when the experiment was created
    /// </summary>
    public sealed partial class RepoInfo
    {
        /// <summary>
        /// SHA of most recent commit
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("commit")]
        public string? Commit { get; set; }

        /// <summary>
        /// Name of the branch the most recent commit belongs to
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("branch")]
        public string? Branch { get; set; }

        /// <summary>
        /// Name of the tag on the most recent commit
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tag")]
        public string? Tag { get; set; }

        /// <summary>
        /// Whether or not the repo had uncommitted changes when snapshotted
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dirty")]
        public bool? Dirty { get; set; }

        /// <summary>
        /// Name of the author of the most recent commit
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("author_name")]
        public string? AuthorName { get; set; }

        /// <summary>
        /// Email of the author of the most recent commit
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("author_email")]
        public string? AuthorEmail { get; set; }

        /// <summary>
        /// Most recent commit message
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("commit_message")]
        public string? CommitMessage { get; set; }

        /// <summary>
        /// Time of the most recent commit
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("commit_time")]
        public string? CommitTime { get; set; }

        /// <summary>
        /// If the repo was dirty when run, this includes the diff between the current state of the repo and the most recent commit.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("git_diff")]
        public string? GitDiff { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepoInfo" /> class.
        /// </summary>
        /// <param name="commit">
        /// SHA of most recent commit
        /// </param>
        /// <param name="branch">
        /// Name of the branch the most recent commit belongs to
        /// </param>
        /// <param name="tag">
        /// Name of the tag on the most recent commit
        /// </param>
        /// <param name="dirty">
        /// Whether or not the repo had uncommitted changes when snapshotted
        /// </param>
        /// <param name="authorName">
        /// Name of the author of the most recent commit
        /// </param>
        /// <param name="authorEmail">
        /// Email of the author of the most recent commit
        /// </param>
        /// <param name="commitMessage">
        /// Most recent commit message
        /// </param>
        /// <param name="commitTime">
        /// Time of the most recent commit
        /// </param>
        /// <param name="gitDiff">
        /// If the repo was dirty when run, this includes the diff between the current state of the repo and the most recent commit.
        /// </param>
        public RepoInfo(
            string? commit,
            string? branch,
            string? tag,
            bool? dirty,
            string? authorName,
            string? authorEmail,
            string? commitMessage,
            string? commitTime,
            string? gitDiff)
        {
            this.Commit = commit;
            this.Branch = branch;
            this.Tag = tag;
            this.Dirty = dirty;
            this.AuthorName = authorName;
            this.AuthorEmail = authorEmail;
            this.CommitMessage = commitMessage;
            this.CommitTime = commitTime;
            this.GitDiff = gitDiff;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepoInfo" /> class.
        /// </summary>
        public RepoInfo()
        {
        }
    }
}