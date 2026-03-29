//HintName: G.Models.RerankPostResponsesContentApplicationJsonSchemaResultsItems.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RerankPostResponsesContentApplicationJsonSchemaResultsItems
    {
        /// <summary>
        /// The index position in the collection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        public int? Index { get; set; }

        /// <summary>
        /// The relevance ranking score.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("relevance_score")]
        public double? RelevanceScore { get; set; }

        /// <summary>
        /// The returned document
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankPostResponsesContentApplicationJsonSchemaResultsItems" /> class.
        /// </summary>
        /// <param name="index">
        /// The index position in the collection.
        /// </param>
        /// <param name="relevanceScore">
        /// The relevance ranking score.
        /// </param>
        /// <param name="text">
        /// The returned document
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RerankPostResponsesContentApplicationJsonSchemaResultsItems(
            int? index,
            double? relevanceScore,
            string? text)
        {
            this.Index = index;
            this.RelevanceScore = relevanceScore;
            this.Text = text;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankPostResponsesContentApplicationJsonSchemaResultsItems" /> class.
        /// </summary>
        public RerankPostResponsesContentApplicationJsonSchemaResultsItems()
        {
        }
    }
}