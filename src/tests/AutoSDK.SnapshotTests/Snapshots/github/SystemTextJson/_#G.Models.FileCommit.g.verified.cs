//HintName: G.Models.FileCommit.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// File Commit
    /// </summary>
    public sealed partial class FileCommit
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.FileCommitContent? Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.FileCommitCommit Commit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileCommit" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="commit"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FileCommit(
            global::G.FileCommitContent? content,
            global::G.FileCommitCommit commit)
        {
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Commit = commit ?? throw new global::System.ArgumentNullException(nameof(commit));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileCommit" /> class.
        /// </summary>
        public FileCommit()
        {
        }
    }
}