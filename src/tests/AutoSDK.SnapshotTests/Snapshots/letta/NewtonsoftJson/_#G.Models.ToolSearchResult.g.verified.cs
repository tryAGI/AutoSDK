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
        [global::Newtonsoft.Json.JsonProperty("tool", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Tool Tool { get; set; } = default!;

        /// <summary>
        /// The embedded text content used for matching.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("embedded_text")]
        public string? EmbeddedText { get; set; }

        /// <summary>
        /// Full-text search rank position.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fts_rank")]
        public int? FtsRank { get; set; }

        /// <summary>
        /// Vector search rank position.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vector_rank")]
        public int? VectorRank { get; set; }

        /// <summary>
        /// Combined relevance score (RRF for hybrid mode).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("combined_score", Required = global::Newtonsoft.Json.Required.Always)]
        public double CombinedScore { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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