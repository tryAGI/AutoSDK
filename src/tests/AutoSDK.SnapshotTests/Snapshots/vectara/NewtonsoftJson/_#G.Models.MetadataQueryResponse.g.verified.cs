//HintName: G.Models.MetadataQueryResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Returns document search results with relevance scores.
    /// </summary>
    public sealed partial class MetadataQueryResponse
    {
        /// <summary>
        /// Matched documents ordered by relevance score (highest first).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("documents")]
        public global::System.Collections.Generic.IList<global::G.ScoredDocument>? Documents { get; set; }

        /// <summary>
        /// Total number of matching documents (for pagination).<br/>
        /// Example: 42
        /// </summary>
        /// <example>42</example>
        [global::Newtonsoft.Json.JsonProperty("total_count")]
        public int? TotalCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataQueryResponse" /> class.
        /// </summary>
        /// <param name="documents">
        /// Matched documents ordered by relevance score (highest first).
        /// </param>
        /// <param name="totalCount">
        /// Total number of matching documents (for pagination).<br/>
        /// Example: 42
        /// </param>
        public MetadataQueryResponse(
            global::System.Collections.Generic.IList<global::G.ScoredDocument>? documents,
            int? totalCount)
        {
            this.Documents = documents;
            this.TotalCount = totalCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataQueryResponse" /> class.
        /// </summary>
        public MetadataQueryResponse()
        {
        }
    }
}