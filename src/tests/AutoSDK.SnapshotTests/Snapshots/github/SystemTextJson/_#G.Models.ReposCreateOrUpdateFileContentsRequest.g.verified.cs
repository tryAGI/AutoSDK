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
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// The new file content, using Base64 encoding.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// **Required if you are updating a file**. The blob SHA of the file being replaced.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sha")]
        public string? Sha { get; set; }

        /// <summary>
        /// The branch name. Default: the repository’s default branch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("branch")]
        public string? Branch { get; set; }

        /// <summary>
        /// The person that committed the file. Default: the authenticated user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("committer")]
        public global::G.ReposCreateOrUpdateFileContentsRequestCommitter? Committer { get; set; }

        /// <summary>
        /// The author of the file. Default: The `committer` or the authenticated user if you omit `committer`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("author")]
        public global::G.ReposCreateOrUpdateFileContentsRequestAuthor? Author { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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