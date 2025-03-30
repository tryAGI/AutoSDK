//HintName: G.Models.RerankedSearchResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An individual reranked search result from a query.
    /// </summary>
    public sealed partial class RerankedSearchResult
    {
        /// <summary>
        /// The document part altered by the context configuration that matches the query.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// The score of the individual result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        public double? Score { get; set; }

        /// <summary>
        /// The original score of the individual result before reranking.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("original_score")]
        public double? OriginalScore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankedSearchResult" /> class.
        /// </summary>
        /// <param name="text">
        /// The document part altered by the context configuration that matches the query.
        /// </param>
        /// <param name="score">
        /// The score of the individual result.
        /// </param>
        /// <param name="originalScore">
        /// The original score of the individual result before reranking.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RerankedSearchResult(
            string? text,
            double? score,
            double? originalScore)
        {
            this.Text = text;
            this.Score = score;
            this.OriginalScore = originalScore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankedSearchResult" /> class.
        /// </summary>
        public RerankedSearchResult()
        {
        }
    }
}