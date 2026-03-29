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
        [global::Newtonsoft.Json.JsonProperty("passage", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Passage Passage { get; set; } = default!;

        /// <summary>
        /// Relevance score
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("score", Required = global::Newtonsoft.Json.Required.Always)]
        public double Score { get; set; } = default!;

        /// <summary>
        /// Additional metadata about the search result
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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