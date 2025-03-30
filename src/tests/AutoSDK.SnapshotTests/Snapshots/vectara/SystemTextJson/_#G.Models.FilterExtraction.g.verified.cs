//HintName: G.Models.FilterExtraction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The result of query filter extraction.
    /// </summary>
    public sealed partial class FilterExtraction
    {
        /// <summary>
        /// The query rephrased from the input query and executed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        public string? Query { get; set; }

        /// <summary>
        /// The metadata filter extracted from the input query.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata_filter")]
        public string? MetadataFilter { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FilterExtraction" /> class.
        /// </summary>
        /// <param name="query">
        /// The query rephrased from the input query and executed.
        /// </param>
        /// <param name="metadataFilter">
        /// The metadata filter extracted from the input query.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FilterExtraction(
            string? query,
            string? metadataFilter)
        {
            this.Query = query;
            this.MetadataFilter = metadataFilter;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FilterExtraction" /> class.
        /// </summary>
        public FilterExtraction()
        {
        }
    }
}