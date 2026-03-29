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
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        public int? Index { get; set; }

        /// <summary>
        /// The relevance score of the document with respect to the query.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("relevance_score")]
        public double? RelevanceScore { get; set; }

        /// <summary>
        /// The document string. Only returned when return_documents is set to true.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document")]
        public string? Document { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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