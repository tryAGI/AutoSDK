//HintName: G.Models.RerankingResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RerankingResult
    {
        /// <summary>
        /// The original document text.<br/>
        /// Example: Machine learning is a subset of artificial intelligence
        /// </summary>
        /// <example>Machine learning is a subset of artificial intelligence</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("doc")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Doc { get; set; }

        /// <summary>
        /// Relevance score between 0.0 and 1.0, where higher scores indicate <br/>
        /// greater relevance to the query.<br/>
        /// Example: 0.92
        /// </summary>
        /// <example>0.92</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float Score { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankingResult" /> class.
        /// </summary>
        /// <param name="doc">
        /// The original document text.<br/>
        /// Example: Machine learning is a subset of artificial intelligence
        /// </param>
        /// <param name="score">
        /// Relevance score between 0.0 and 1.0, where higher scores indicate <br/>
        /// greater relevance to the query.<br/>
        /// Example: 0.92
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RerankingResult(
            string doc,
            float score)
        {
            this.Doc = doc ?? throw new global::System.ArgumentNullException(nameof(doc));
            this.Score = score;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankingResult" /> class.
        /// </summary>
        public RerankingResult()
        {
        }
    }
}