//HintName: G.Models.DocumentsExtractResponse200.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DocumentsExtractResponse200
    {
        /// <summary>
        /// The parsed document title.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// The parsed document contents.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contents")]
        public string? Contents { get; set; }

        /// <summary>
        /// The word count for the document.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        public int? Count { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentsExtractResponse200" /> class.
        /// </summary>
        /// <param name="title">
        /// The parsed document title.
        /// </param>
        /// <param name="contents">
        /// The parsed document contents.
        /// </param>
        /// <param name="count">
        /// The word count for the document.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DocumentsExtractResponse200(
            string? title,
            string? contents,
            int? count)
        {
            this.Title = title;
            this.Contents = contents;
            this.Count = count;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentsExtractResponse200" /> class.
        /// </summary>
        public DocumentsExtractResponse200()
        {
        }
    }
}