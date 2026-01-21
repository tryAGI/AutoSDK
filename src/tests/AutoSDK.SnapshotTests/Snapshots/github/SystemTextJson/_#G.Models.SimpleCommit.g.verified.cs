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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// SHA for the commit's tree
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tree_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TreeId { get; set; }

        /// <summary>
        /// Message describing the purpose of the commit<br/>
        /// Example: Fix #42
        /// </summary>
        /// <example>Fix #42</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Timestamp of the commit<br/>
        /// Example: 2014-08-09T08:02:04+12:00
        /// </summary>
        /// <example>2014-08-09T08:02:04+12:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Timestamp { get; set; }

        /// <summary>
        /// Information about the Git author
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("author")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SimpleCommitAuthor? Author { get; set; }

        /// <summary>
        /// Information about the Git committer
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("committer")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SimpleCommitCommitter? Committer { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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