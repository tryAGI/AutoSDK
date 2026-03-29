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
        [global::Newtonsoft.Json.JsonProperty("embedded_text", Required = global::Newtonsoft.Json.Required.Always)]
        public string EmbeddedText { get; set; } = default!;

        /// <summary>
        /// The raw message object
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Message Message { get; set; } = default!;

        /// <summary>
        /// Full-text search rank position if FTS was used
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fts_rank")]
        public int? FtsRank { get; set; }

        /// <summary>
        /// Vector search rank position if vector search was used
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vector_rank")]
        public int? VectorRank { get; set; }

        /// <summary>
        /// Reciprocal Rank Fusion combined score
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rrf_score", Required = global::Newtonsoft.Json.Required.Always)]
        public double RrfScore { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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