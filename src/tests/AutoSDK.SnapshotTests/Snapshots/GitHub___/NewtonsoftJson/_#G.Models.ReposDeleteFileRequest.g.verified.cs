//HintName: G.Models.ReposDeleteFileRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReposDeleteFileRequest
    {
        /// <summary>
        /// The commit message.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// The blob SHA of the file being deleted.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sha", Required = global::Newtonsoft.Json.Required.Always)]
        public string Sha { get; set; } = default!;

        /// <summary>
        /// The branch name. Default: the repository’s default branch
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("branch")]
        public string? Branch { get; set; }

        /// <summary>
        /// object containing information about the committer.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("committer")]
        public global::G.ReposDeleteFileRequestCommitter? Committer { get; set; }

        /// <summary>
        /// object containing information about the author.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("author")]
        public global::G.ReposDeleteFileRequestAuthor? Author { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposDeleteFileRequest" /> class.
        /// </summary>
        /// <param name="message">
        /// The commit message.
        /// </param>
        /// <param name="sha">
        /// The blob SHA of the file being deleted.
        /// </param>
        /// <param name="branch">
        /// The branch name. Default: the repository’s default branch
        /// </param>
        /// <param name="committer">
        /// object containing information about the committer.
        /// </param>
        /// <param name="author">
        /// object containing information about the author.
        /// </param>
        public ReposDeleteFileRequest(
            string message,
            string sha,
            string? branch,
            global::G.ReposDeleteFileRequestCommitter? committer,
            global::G.ReposDeleteFileRequestAuthor? author)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Sha = sha ?? throw new global::System.ArgumentNullException(nameof(sha));
            this.Branch = branch;
            this.Committer = committer;
            this.Author = author;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposDeleteFileRequest" /> class.
        /// </summary>
        public ReposDeleteFileRequest()
        {
        }
    }
}