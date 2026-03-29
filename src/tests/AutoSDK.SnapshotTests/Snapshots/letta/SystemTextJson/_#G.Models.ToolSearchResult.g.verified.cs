//HintName: G.Models.ToolSearchResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Result from a tool search operation.
    /// </summary>
    public sealed partial class ToolSearchResult
    {
        /// <summary>
        /// The matched tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Tool Tool { get; set; }

        /// <summary>
        /// The embedded text content used for matching.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedded_text")]
        public string? EmbeddedText { get; set; }

        /// <summary>
        /// Full-text search rank position.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fts_rank")]
        public int? FtsRank { get; set; }

        /// <summary>
        /// Vector search rank position.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vector_rank")]
        public int? VectorRank { get; set; }

        /// <summary>
        /// Combined relevance score (RRF for hybrid mode).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("combined_score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CombinedScore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolSearchResult" /> class.
        /// </summary>
        /// <param name="tool">
        /// The matched tool.
        /// </param>
        /// <param name="combinedScore">
        /// Combined relevance score (RRF for hybrid mode).
        /// </param>
        /// <param name="embeddedText">
        /// The embedded text content used for matching.
        /// </param>
        /// <param name="ftsRank">
        /// Full-text search rank position.
        /// </param>
        /// <param name="vectorRank">
        /// Vector search rank position.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolSearchResult(
            global::G.Tool tool,
            double combinedScore,
            string? embeddedText,
            int? ftsRank,
            int? vectorRank)
        {
            this.Tool = tool ?? throw new global::System.ArgumentNullException(nameof(tool));
            this.EmbeddedText = embeddedText;
            this.FtsRank = ftsRank;
            this.VectorRank = vectorRank;
            this.CombinedScore = combinedScore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolSearchResult" /> class.
        /// </summary>
        public ToolSearchResult()
        {
        }
    }
}