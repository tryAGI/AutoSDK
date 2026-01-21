//HintName: G.Models.SimpleCommit.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A commit.
    /// </summary>
    public sealed partial class SimpleCommit
    {
        /// <summary>
        /// SHA for the commit<br/>
        /// Example: 7638417db6d59f3c431d3e1f261cc637155684cd
        /// </summary>
        /// <example>7638417db6d59f3c431d3e1f261cc637155684cd</example>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// SHA for the commit's tree
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tree_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string TreeId { get; set; } = default!;

        /// <summary>
        /// Message describing the purpose of the commit<br/>
        /// Example: Fix #42
        /// </summary>
        /// <example>Fix #42</example>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// Timestamp of the commit<br/>
        /// Example: 2014-08-09T08:02:04+12:00
        /// </summary>
        /// <example>2014-08-09T08:02:04+12:00</example>
        [global::Newtonsoft.Json.JsonProperty("timestamp", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime Timestamp { get; set; } = default!;

        /// <summary>
        /// Information about the Git author
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("author", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SimpleCommitAuthor? Author { get; set; } = default!;

        /// <summary>
        /// Information about the Git committer
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("committer", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SimpleCommitCommitter? Committer { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleCommit" /> class.
        /// </summary>
        /// <param name="id">
        /// SHA for the commit<br/>
        /// Example: 7638417db6d59f3c431d3e1f261cc637155684cd
        /// </param>
        /// <param name="treeId">
        /// SHA for the commit's tree
        /// </param>
        /// <param name="message">
        /// Message describing the purpose of the commit<br/>
        /// Example: Fix #42
        /// </param>
        /// <param name="timestamp">
        /// Timestamp of the commit<br/>
        /// Example: 2014-08-09T08:02:04+12:00
        /// </param>
        /// <param name="author">
        /// Information about the Git author
        /// </param>
        /// <param name="committer">
        /// Information about the Git committer
        /// </param>
        public SimpleCommit(
            string id,
            string treeId,
            string message,
            global::System.DateTime timestamp,
            global::G.SimpleCommitAuthor? author,
            global::G.SimpleCommitCommitter? committer)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.TreeId = treeId ?? throw new global::System.ArgumentNullException(nameof(treeId));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Timestamp = timestamp;
            this.Author = author ?? throw new global::System.ArgumentNullException(nameof(author));
            this.Committer = committer ?? throw new global::System.ArgumentNullException(nameof(committer));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleCommit" /> class.
        /// </summary>
        public SimpleCommit()
        {
        }
    }
}