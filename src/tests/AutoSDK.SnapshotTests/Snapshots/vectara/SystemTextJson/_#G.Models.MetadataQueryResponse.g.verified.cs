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
        [global::System.Text.Json.Serialization.JsonPropertyName("documents")]
        public global::System.Collections.Generic.IList<global::G.ScoredDocument>? Documents { get; set; }

        /// <summary>
        /// Total number of matching documents (for pagination).<br/>
        /// Example: 42
        /// </summary>
        /// <example>42</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_count")]
        public int? TotalCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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