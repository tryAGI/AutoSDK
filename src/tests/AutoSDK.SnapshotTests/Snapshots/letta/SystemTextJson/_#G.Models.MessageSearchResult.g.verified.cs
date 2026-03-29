//HintName: G.Models.MessageSearchResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Result from a message search operation with scoring details.
    /// </summary>
    public sealed partial class MessageSearchResult
    {
        /// <summary>
        /// The embedded content (LLM-friendly)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedded_text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EmbeddedText { get; set; }

        /// <summary>
        /// The raw message object
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Message Message { get; set; }

        /// <summary>
        /// Full-text search rank position if FTS was used
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fts_rank")]
        public int? FtsRank { get; set; }

        /// <summary>
        /// Vector search rank position if vector search was used
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vector_rank")]
        public int? VectorRank { get; set; }

        /// <summary>
        /// Reciprocal Rank Fusion combined score
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rrf_score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double RrfScore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageSearchResult" /> class.
        /// </summary>
        /// <param name="embeddedText">
        /// The embedded content (LLM-friendly)
        /// </param>
        /// <param name="message">
        /// The raw message object
        /// </param>
        /// <param name="rrfScore">
        /// Reciprocal Rank Fusion combined score
        /// </param>
        /// <param name="ftsRank">
        /// Full-text search rank position if FTS was used
        /// </param>
        /// <param name="vectorRank">
        /// Vector search rank position if vector search was used
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessageSearchResult(
            string embeddedText,
            global::G.Message message,
            double rrfScore,
            int? ftsRank,
            int? vectorRank)
        {
            this.EmbeddedText = embeddedText ?? throw new global::System.ArgumentNullException(nameof(embeddedText));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.FtsRank = ftsRank;
            this.VectorRank = vectorRank;
            this.RrfScore = rrfScore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageSearchResult" /> class.
        /// </summary>
        public MessageSearchResult()
        {
        }
    }
}