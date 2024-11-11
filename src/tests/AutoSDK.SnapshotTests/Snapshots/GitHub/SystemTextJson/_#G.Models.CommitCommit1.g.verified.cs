//HintName: G.Models.CommitCommit1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CommitCommit1
    {
        /// <summary>
        /// Example: https://api.github.com/repos/octocat/Hello-World/commits/6dcb09b5b57875f334f61aebed695e2e4193db5e
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/commits/6dcb09b5b57875f334f61aebed695e2e4193db5e</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Metaproperties for Git author/committer information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("author")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.NullableGitUser? Author { get; set; }

        /// <summary>
        /// Metaproperties for Git author/committer information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("committer")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.NullableGitUser? Committer { get; set; }

        /// <summary>
        /// Example: Fix all the bugs
        /// </summary>
        /// <example>Fix all the bugs</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("comment_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CommentCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tree")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CommitCommit1Tree Tree { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verification")]
        public global::G.Verification? Verification { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CommitCommit1" /> class.
        /// </summary>
        /// <param name="url">
        /// Example: https://api.github.com/repos/octocat/Hello-World/commits/6dcb09b5b57875f334f61aebed695e2e4193db5e
        /// </param>
        /// <param name="author">
        /// Metaproperties for Git author/committer information.
        /// </param>
        /// <param name="committer">
        /// Metaproperties for Git author/committer information.
        /// </param>
        /// <param name="message">
        /// Example: Fix all the bugs
        /// </param>
        /// <param name="commentCount">
        /// Example: 0
        /// </param>
        /// <param name="tree"></param>
        /// <param name="verification"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CommitCommit1(
            string url,
            global::G.NullableGitUser? author,
            global::G.NullableGitUser? committer,
            string message,
            int commentCount,
            global::G.CommitCommit1Tree tree,
            global::G.Verification? verification)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Author = author ?? throw new global::System.ArgumentNullException(nameof(author));
            this.Committer = committer ?? throw new global::System.ArgumentNullException(nameof(committer));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.CommentCount = commentCount;
            this.Tree = tree ?? throw new global::System.ArgumentNullException(nameof(tree));
            this.Verification = verification;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommitCommit1" /> class.
        /// </summary>
        public CommitCommit1()
        {
        }
    }
}