//HintName: G.Models.SearchResultItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchResultItem
    {
        /// <summary>
        /// Coordinates corresponding to the areas of the document where the chunk appears
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("boundingBoxes")]
        public global::System.Collections.Generic.IList<global::G.BoundingBoxDetail>? BoundingBoxes { get; set; }

        /// <summary>
        /// Content bucket the search result belongs to
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bucketId")]
        public int? BucketId { get; set; }

        /// <summary>
        /// Unique system generated ID for the chunk
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chunkId")]
        public string? ChunkId { get; set; }

        /// <summary>
        /// Unique system generated ID for the document
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("documentId")]
        public global::System.Guid? DocumentId { get; set; }

        /// <summary>
        /// Name of ingested file
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fileName")]
        public string? FileName { get; set; }

        /// <summary>
        /// An image clipping of the table or figure object from the document
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("multimodalUrl")]
        public string? MultimodalUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pageImages")]
        public global::System.Collections.Generic.IList<string>? PageImages { get; set; }

        /// <summary>
        /// Confidence score in the search result
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("score")]
        public double? Score { get; set; }

        /// <summary>
        /// Document, section, and chunk search data, both custom and system-generated
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("searchData")]
        public object? SearchData { get; set; }

        /// <summary>
        /// Source document URL
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sourceUrl")]
        public string? SourceUrl { get; set; }

        /// <summary>
        /// System-generated text, re-written for LLM completions
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("suggestedText")]
        public string? SuggestedText { get; set; }

        /// <summary>
        /// Original text from the source document
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResultItem" /> class.
        /// </summary>
        /// <param name="boundingBoxes">
        /// Coordinates corresponding to the areas of the document where the chunk appears
        /// </param>
        /// <param name="bucketId">
        /// Content bucket the search result belongs to
        /// </param>
        /// <param name="chunkId">
        /// Unique system generated ID for the chunk
        /// </param>
        /// <param name="documentId">
        /// Unique system generated ID for the document
        /// </param>
        /// <param name="fileName">
        /// Name of ingested file
        /// </param>
        /// <param name="multimodalUrl">
        /// An image clipping of the table or figure object from the document
        /// </param>
        /// <param name="pageImages"></param>
        /// <param name="score">
        /// Confidence score in the search result
        /// </param>
        /// <param name="searchData">
        /// Document, section, and chunk search data, both custom and system-generated
        /// </param>
        /// <param name="sourceUrl">
        /// Source document URL
        /// </param>
        /// <param name="suggestedText">
        /// System-generated text, re-written for LLM completions
        /// </param>
        /// <param name="text">
        /// Original text from the source document
        /// </param>
        public SearchResultItem(
            global::System.Collections.Generic.IList<global::G.BoundingBoxDetail>? boundingBoxes,
            int? bucketId,
            string? chunkId,
            global::System.Guid? documentId,
            string? fileName,
            string? multimodalUrl,
            global::System.Collections.Generic.IList<string>? pageImages,
            double? score,
            object? searchData,
            string? sourceUrl,
            string? suggestedText,
            string? text)
        {
            this.BoundingBoxes = boundingBoxes;
            this.BucketId = bucketId;
            this.ChunkId = chunkId;
            this.DocumentId = documentId;
            this.FileName = fileName;
            this.MultimodalUrl = multimodalUrl;
            this.PageImages = pageImages;
            this.Score = score;
            this.SearchData = searchData;
            this.SourceUrl = sourceUrl;
            this.SuggestedText = suggestedText;
            this.Text = text;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResultItem" /> class.
        /// </summary>
        public SearchResultItem()
        {
        }
    }
}