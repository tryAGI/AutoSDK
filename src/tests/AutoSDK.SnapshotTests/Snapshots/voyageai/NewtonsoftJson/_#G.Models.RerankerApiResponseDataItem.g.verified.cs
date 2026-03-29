//HintName: G.Models.RerankerApiResponseDataItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RerankerApiResponseDataItem
    {
        /// <summary>
        /// The index of the document in the input list.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("index")]
        public int? Index { get; set; }

        /// <summary>
        /// The relevance score of the document with respect to the query.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("relevance_score")]
        public double? RelevanceScore { get; set; }

        /// <summary>
        /// The document string. Only returned when return_documents is set to true.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("document")]
        public string? Document { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankerApiResponseDataItem" /> class.
        /// </summary>
        /// <param name="index">
        /// The index of the document in the input list.
        /// </param>
        /// <param name="relevanceScore">
        /// The relevance score of the document with respect to the query.
        /// </param>
        /// <param name="document">
        /// The document string. Only returned when return_documents is set to true.
        /// </param>
        public RerankerApiResponseDataItem(
            int? index,
            double? relevanceScore,
            string? document)
        {
            this.Index = index;
            this.RelevanceScore = relevanceScore;
            this.Document = document;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankerApiResponseDataItem" /> class.
        /// </summary>
        public RerankerApiResponseDataItem()
        {
        }
    }
}