//HintName: G.Models.ReposCreateOrUpdateFileContentsRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReposCreateOrUpdateFileContentsRequest
    {
        /// <summary>
        /// The commit message.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// The new file content, using Base64 encoding.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public string Content { get; set; } = default!;

        /// <summary>
        /// **Required if you are updating a file**. The blob SHA of the file being replaced.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sha")]
        public string? Sha { get; set; }

        /// <summary>
        /// The branch name. Default: the repository’s default branch.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("branch")]
        public string? Branch { get; set; }

        /// <summary>
        /// The person that committed the file. Default: the authenticated user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("committer")]
        public global::G.ReposCreateOrUpdateFileContentsRequestCommitter? Committer { get; set; }

        /// <summary>
        /// The author of the file. Default: The `committer` or the authenticated user if you omit `committer`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("author")]
        public global::G.ReposCreateOrUpdateFileContentsRequestAuthor? Author { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposCreateOrUpdateFileContentsRequest" /> class.
        /// </summary>
        /// <param name="message">
        /// The commit message.
        /// </param>
        /// <param name="content">
        /// The new file content, using Base64 encoding.
        /// </param>
        /// <param name="sha">
        /// **Required if you are updating a file**. The blob SHA of the file being replaced.
        /// </param>
        /// <param name="branch">
        /// The branch name. Default: the repository’s default branch.
        /// </param>
        /// <param name="committer">
        /// The person that committed the file. Default: the authenticated user.
        /// </param>
        /// <param name="author">
        /// The author of the file. Default: The `committer` or the authenticated user if you omit `committer`.
        /// </param>
        public ReposCreateOrUpdateFileContentsRequest(
            string message,
            string content,
            string? sha,
            string? branch,
            global::G.ReposCreateOrUpdateFileContentsRequestCommitter? committer,
            global::G.ReposCreateOrUpdateFileContentsRequestAuthor? author)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Sha = sha;
            this.Branch = branch;
            this.Committer = committer;
            this.Author = author;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposCreateOrUpdateFileContentsRequest" /> class.
        /// </summary>
        public ReposCreateOrUpdateFileContentsRequest()
        {
        }
    }
}