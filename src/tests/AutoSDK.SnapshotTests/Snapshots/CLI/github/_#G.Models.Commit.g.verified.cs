﻿//HintName: G.Models.Commit.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Commit
    /// </summary>
    public sealed partial class Commit
    {
        /// <summary>
        /// Example: https://api.github.com/repos/octocat/Hello-World/commits/6dcb09b5b57875f334f61aebed695e2e4193db5e
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/commits/6dcb09b5b57875f334f61aebed695e2e4193db5e</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Example: 6dcb09b5b57875f334f61aebed695e2e4193db5e
        /// </summary>
        /// <example>6dcb09b5b57875f334f61aebed695e2e4193db5e</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sha")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Sha { get; set; }

        /// <summary>
        /// Example: MDY6Q29tbWl0NmRjYjA5YjViNTc4NzVmMzM0ZjYxYWViZWQ2OTVlMmU0MTkzZGI1ZQ==
        /// </summary>
        /// <example>MDY6Q29tbWl0NmRjYjA5YjViNTc4NzVmMzM0ZjYxYWViZWQ2OTVlMmU0MTkzZGI1ZQ==</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// Example: https://github.com/octocat/Hello-World/commit/6dcb09b5b57875f334f61aebed695e2e4193db5e
        /// </summary>
        /// <example>https://github.com/octocat/Hello-World/commit/6dcb09b5b57875f334f61aebed695e2e4193db5e</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HtmlUrl { get; set; }

        /// <summary>
        /// Example: https://api.github.com/repos/octocat/Hello-World/commits/6dcb09b5b57875f334f61aebed695e2e4193db5e/comments
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/commits/6dcb09b5b57875f334f61aebed695e2e4193db5e/comments</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("comments_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CommentsUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CommitCommit1 Commit1 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("author")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.SimpleUser, global::G.EmptyObject>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OneOf<global::G.SimpleUser, global::G.EmptyObject>? Author { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("committer")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.SimpleUser, global::G.EmptyObject>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OneOf<global::G.SimpleUser, global::G.EmptyObject>? Committer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.CommitParent> Parents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stats")]
        public global::G.CommitStats? Stats { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files")]
        public global::System.Collections.Generic.IList<global::G.DiffEntry>? Files { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Commit" /> class.
        /// </summary>
        /// <param name="url">
        /// Example: https://api.github.com/repos/octocat/Hello-World/commits/6dcb09b5b57875f334f61aebed695e2e4193db5e
        /// </param>
        /// <param name="sha">
        /// Example: 6dcb09b5b57875f334f61aebed695e2e4193db5e
        /// </param>
        /// <param name="nodeId">
        /// Example: MDY6Q29tbWl0NmRjYjA5YjViNTc4NzVmMzM0ZjYxYWViZWQ2OTVlMmU0MTkzZGI1ZQ==
        /// </param>
        /// <param name="htmlUrl">
        /// Example: https://github.com/octocat/Hello-World/commit/6dcb09b5b57875f334f61aebed695e2e4193db5e
        /// </param>
        /// <param name="commentsUrl">
        /// Example: https://api.github.com/repos/octocat/Hello-World/commits/6dcb09b5b57875f334f61aebed695e2e4193db5e/comments
        /// </param>
        /// <param name="commit1"></param>
        /// <param name="author"></param>
        /// <param name="committer"></param>
        /// <param name="parents"></param>
        /// <param name="stats"></param>
        /// <param name="files"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Commit(
            string url,
            string sha,
            string nodeId,
            string htmlUrl,
            string commentsUrl,
            global::G.CommitCommit1 commit1,
            global::G.OneOf<global::G.SimpleUser, global::G.EmptyObject>? author,
            global::G.OneOf<global::G.SimpleUser, global::G.EmptyObject>? committer,
            global::System.Collections.Generic.IList<global::G.CommitParent> parents,
            global::G.CommitStats? stats,
            global::System.Collections.Generic.IList<global::G.DiffEntry>? files)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Sha = sha ?? throw new global::System.ArgumentNullException(nameof(sha));
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.HtmlUrl = htmlUrl ?? throw new global::System.ArgumentNullException(nameof(htmlUrl));
            this.CommentsUrl = commentsUrl ?? throw new global::System.ArgumentNullException(nameof(commentsUrl));
            this.Commit1 = commit1 ?? throw new global::System.ArgumentNullException(nameof(commit1));
            this.Author = author;
            this.Committer = committer;
            this.Parents = parents ?? throw new global::System.ArgumentNullException(nameof(parents));
            this.Stats = stats;
            this.Files = files;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Commit" /> class.
        /// </summary>
        public Commit()
        {
        }
    }
}