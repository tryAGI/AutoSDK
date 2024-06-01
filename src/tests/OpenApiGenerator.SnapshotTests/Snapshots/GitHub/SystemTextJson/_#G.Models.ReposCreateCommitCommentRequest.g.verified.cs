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
        public int Position { get; set; }

        /// <summary>
        /// **Deprecated**. Use **position** parameter instead. Line number in the file to comment on.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("line")]
        public int Line { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}