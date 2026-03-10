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
        [global::Newtonsoft.Json.JsonProperty("content")]
        public global::G.FileCommitContent? Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("commit", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.FileCommitCommit Commit { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileCommit" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="commit"></param>
        public FileCommit(
            global::G.FileCommitCommit commit,
            global::G.FileCommitContent? content)
        {
            this.Commit = commit ?? throw new global::System.ArgumentNullException(nameof(commit));
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileCommit" /> class.
        /// </summary>
        public FileCommit()
        {
        }
    }
}