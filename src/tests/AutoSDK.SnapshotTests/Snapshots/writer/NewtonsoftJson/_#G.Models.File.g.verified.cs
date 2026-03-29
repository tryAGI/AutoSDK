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
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// The unique identifier of the file in your Writer account.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fileId", Required = global::Newtonsoft.Json.Required.Always)]
        public string FileId { get; set; } = default!;

        /// <summary>
        /// Internal score used during the retrieval process for ranking and selecting relevant snippets.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("score", Required = global::Newtonsoft.Json.Required.Always)]
        public double Score { get; set; } = default!;

        /// <summary>
        /// Page number where this snippet was found in the source document.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("page")]
        public int? Page { get; set; }

        /// <summary>
        /// Unique citation ID that appears in inline citations within the response text (null if not cited).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cite")]
        public string? Cite { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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