//HintName: G.Models.UltravoxV1CorpusQueryResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A single result from a corpus query (corresponding to a chunk).
    /// </summary>
    public sealed partial class UltravoxV1CorpusQueryResult
    {
        /// <summary>
        /// The content of the retrieved chunk.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// The score of this chunk, with higher scores indicating better matches.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        public double? Score { get; set; }

        /// <summary>
        /// A citation for this chunk.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("citation")]
        public global::G.UltravoxV1CorpusQueryResultCitation? Citation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1CorpusQueryResult" /> class.
        /// </summary>
        /// <param name="content">
        /// The content of the retrieved chunk.
        /// </param>
        /// <param name="score">
        /// The score of this chunk, with higher scores indicating better matches.
        /// </param>
        /// <param name="citation">
        /// A citation for this chunk.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UltravoxV1CorpusQueryResult(
            string? content,
            double? score,
            global::G.UltravoxV1CorpusQueryResultCitation? citation)
        {
            this.Content = content;
            this.Score = score;
            this.Citation = citation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1CorpusQueryResult" /> class.
        /// </summary>
        public UltravoxV1CorpusQueryResult()
        {
        }
    }
}