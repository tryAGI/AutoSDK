//HintName: G.Models.PassageSearchResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Result from a passage search operation with scoring details.
    /// </summary>
    public sealed partial class PassageSearchResult
    {
        /// <summary>
        /// The passage object
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("passage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Passage Passage { get; set; }

        /// <summary>
        /// Relevance score
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Score { get; set; }

        /// <summary>
        /// Additional metadata about the search result
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PassageSearchResult" /> class.
        /// </summary>
        /// <param name="passage">
        /// The passage object
        /// </param>
        /// <param name="score">
        /// Relevance score
        /// </param>
        /// <param name="metadata">
        /// Additional metadata about the search result
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PassageSearchResult(
            global::G.Passage passage,
            double score,
            object? metadata)
        {
            this.Passage = passage ?? throw new global::System.ArgumentNullException(nameof(passage));
            this.Score = score;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PassageSearchResult" /> class.
        /// </summary>
        public PassageSearchResult()
        {
        }
    }
}