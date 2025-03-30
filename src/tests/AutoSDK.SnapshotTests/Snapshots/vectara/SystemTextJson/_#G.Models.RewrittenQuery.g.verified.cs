//HintName: G.Models.RewrittenQuery.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The rewritten query for a corpus that was searched.
    /// </summary>
    public sealed partial class RewrittenQuery
    {
        /// <summary>
        /// The corpus key that the query was made on.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("corpus_key")]
        public string? CorpusKey { get; set; }

        /// <summary>
        /// The result of query filter extraction.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter_extraction")]
        public global::G.FilterExtraction? FilterExtraction { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RewrittenQuery" /> class.
        /// </summary>
        /// <param name="corpusKey">
        /// The corpus key that the query was made on.
        /// </param>
        /// <param name="filterExtraction">
        /// The result of query filter extraction.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RewrittenQuery(
            string? corpusKey,
            global::G.FilterExtraction? filterExtraction)
        {
            this.CorpusKey = corpusKey;
            this.FilterExtraction = filterExtraction;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RewrittenQuery" /> class.
        /// </summary>
        public RewrittenQuery()
        {
        }
    }
}