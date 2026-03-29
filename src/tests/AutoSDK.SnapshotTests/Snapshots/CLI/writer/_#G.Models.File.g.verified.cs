//HintName: G.Models.File.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A file-based reference containing text snippets from uploaded documents in the Knowledge Graph.
    /// </summary>
    public sealed partial class File
    {
        /// <summary>
        /// The exact text snippet from the source document that was used to support the response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// The unique identifier of the file in your Writer account.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FileId { get; set; }

        /// <summary>
        /// Internal score used during the retrieval process for ranking and selecting relevant snippets.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Score { get; set; }

        /// <summary>
        /// Page number where this snippet was found in the source document.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page")]
        public int? Page { get; set; }

        /// <summary>
        /// Unique citation ID that appears in inline citations within the response text (null if not cited).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cite")]
        public string? Cite { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="File" /> class.
        /// </summary>
        /// <param name="text">
        /// The exact text snippet from the source document that was used to support the response.
        /// </param>
        /// <param name="fileId">
        /// The unique identifier of the file in your Writer account.
        /// </param>
        /// <param name="score">
        /// Internal score used during the retrieval process for ranking and selecting relevant snippets.
        /// </param>
        /// <param name="page">
        /// Page number where this snippet was found in the source document.
        /// </param>
        /// <param name="cite">
        /// Unique citation ID that appears in inline citations within the response text (null if not cited).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public File(
            string text,
            string fileId,
            double score,
            int? page,
            string? cite)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.FileId = fileId ?? throw new global::System.ArgumentNullException(nameof(fileId));
            this.Score = score;
            this.Page = page;
            this.Cite = cite;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="File" /> class.
        /// </summary>
        public File()
        {
        }
    }
}