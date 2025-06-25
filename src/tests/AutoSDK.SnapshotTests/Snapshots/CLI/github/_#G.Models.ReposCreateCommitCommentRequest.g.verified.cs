//HintName: G.Models.ReposCreateCommitCommentRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReposCreateCommitCommentRequest
    {
        /// <summary>
        /// The contents of the comment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Body { get; set; }

        /// <summary>
        /// Relative path of the file to comment on.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? Path { get; set; }

        /// <summary>
        /// Line index in the diff to comment on.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("position")]
        public int? Position { get; set; }

        /// <summary>
        /// **Deprecated**. Use **position** parameter instead. Line number in the file to comment on.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("line")]
        public int? Line { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposCreateCommitCommentRequest" /> class.
        /// </summary>
        /// <param name="body">
        /// The contents of the comment.
        /// </param>
        /// <param name="path">
        /// Relative path of the file to comment on.
        /// </param>
        /// <param name="position">
        /// Line index in the diff to comment on.
        /// </param>
        /// <param name="line">
        /// **Deprecated**. Use **position** parameter instead. Line number in the file to comment on.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReposCreateCommitCommentRequest(
            string body,
            string? path,
            int? position,
            int? line)
        {
            this.Body = body ?? throw new global::System.ArgumentNullException(nameof(body));
            this.Path = path;
            this.Position = position;
            this.Line = line;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposCreateCommitCommentRequest" /> class.
        /// </summary>
        public ReposCreateCommitCommentRequest()
        {
        }
    }
}