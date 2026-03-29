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
        [global::Newtonsoft.Json.JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// The parsed document contents.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("contents")]
        public string? Contents { get; set; }

        /// <summary>
        /// The word count for the document.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("count")]
        public int? Count { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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