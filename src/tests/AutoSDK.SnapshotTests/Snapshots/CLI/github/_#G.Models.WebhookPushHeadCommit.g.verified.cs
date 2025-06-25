﻿//HintName: G.Models.WebhookPushHeadCommit.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookPushHeadCommit
    {
        /// <summary>
        /// An array of files added in the commit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("added")]
        public global::System.Collections.Generic.IList<string>? Added { get; set; }

        /// <summary>
        /// Metaproperties for Git author/committer information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("author")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhookPushHeadCommitAuthor Author { get; set; }

        /// <summary>
        /// Metaproperties for Git author/committer information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("committer")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhookPushHeadCommitCommitter Committer { get; set; }

        /// <summary>
        /// Whether this commit is distinct from any that have been pushed before.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distinct")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Distinct { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The commit message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// An array of files modified by the commit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modified")]
        public global::System.Collections.Generic.IList<string>? Modified { get; set; }

        /// <summary>
        /// An array of files removed in the commit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("removed")]
        public global::System.Collections.Generic.IList<string>? Removed { get; set; }

        /// <summary>
        /// The ISO 8601 timestamp of the commit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Timestamp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tree_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TreeId { get; set; }

        /// <summary>
        /// URL that points to the commit API resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPushHeadCommit" /> class.
        /// </summary>
        /// <param name="added">
        /// An array of files added in the commit.
        /// </param>
        /// <param name="author">
        /// Metaproperties for Git author/committer information.
        /// </param>
        /// <param name="committer">
        /// Metaproperties for Git author/committer information.
        /// </param>
        /// <param name="distinct">
        /// Whether this commit is distinct from any that have been pushed before.
        /// </param>
        /// <param name="id"></param>
        /// <param name="message">
        /// The commit message.
        /// </param>
        /// <param name="modified">
        /// An array of files modified by the commit.
        /// </param>
        /// <param name="removed">
        /// An array of files removed in the commit.
        /// </param>
        /// <param name="timestamp">
        /// The ISO 8601 timestamp of the commit.
        /// </param>
        /// <param name="treeId"></param>
        /// <param name="url">
        /// URL that points to the commit API resource.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookPushHeadCommit(
            global::G.WebhookPushHeadCommitAuthor author,
            global::G.WebhookPushHeadCommitCommitter committer,
            bool distinct,
            string id,
            string message,
            global::System.DateTime timestamp,
            string treeId,
            string url,
            global::System.Collections.Generic.IList<string>? added,
            global::System.Collections.Generic.IList<string>? modified,
            global::System.Collections.Generic.IList<string>? removed)
        {
            this.Author = author ?? throw new global::System.ArgumentNullException(nameof(author));
            this.Committer = committer ?? throw new global::System.ArgumentNullException(nameof(committer));
            this.Distinct = distinct;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Timestamp = timestamp;
            this.TreeId = treeId ?? throw new global::System.ArgumentNullException(nameof(treeId));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Added = added;
            this.Modified = modified;
            this.Removed = removed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPushHeadCommit" /> class.
        /// </summary>
        public WebhookPushHeadCommit()
        {
        }
    }
}