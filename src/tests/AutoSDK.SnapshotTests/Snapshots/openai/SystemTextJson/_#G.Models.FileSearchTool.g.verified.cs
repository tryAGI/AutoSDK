//HintName: G.Models.FileSearchTool.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// A tool that searches for relevant content from uploaded files.<br/>
    /// Learn more about the [file search tool](/docs/guides/tools-file-search).
    /// </summary>
    public sealed partial class FileSearchTool
    {
        /// <summary>
        /// A filter to apply based on file attributes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.ComparisonFilter, global::G.CompoundFilter>))]
        public global::G.OneOf<global::G.ComparisonFilter, global::G.CompoundFilter>? Filters { get; set; }

        /// <summary>
        /// The maximum number of results to return. This number should be between 1 <br/>
        /// and 50 inclusive.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_num_results")]
        public int? MaxNumResults { get; set; }

        /// <summary>
        /// Ranking options for search.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ranking_options")]
        public global::G.FileSearchToolRankingOptions? RankingOptions { get; set; }

        /// <summary>
        /// The type of the file search tool. Always `file_search`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FileSearchToolTypeJsonConverter))]
        public global::G.FileSearchToolType Type { get; set; }

        /// <summary>
        /// The IDs of the vector stores to search.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vector_store_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> VectorStoreIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileSearchTool" /> class.
        /// </summary>
        /// <param name="filters">
        /// A filter to apply based on file attributes.
        /// </param>
        /// <param name="maxNumResults">
        /// The maximum number of results to return. This number should be between 1 <br/>
        /// and 50 inclusive.
        /// </param>
        /// <param name="rankingOptions">
        /// Ranking options for search.
        /// </param>
        /// <param name="type">
        /// The type of the file search tool. Always `file_search`.
        /// </param>
        /// <param name="vectorStoreIds">
        /// The IDs of the vector stores to search.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FileSearchTool(
            global::System.Collections.Generic.IList<string> vectorStoreIds,
            global::G.OneOf<global::G.ComparisonFilter, global::G.CompoundFilter>? filters,
            int? maxNumResults,
            global::G.FileSearchToolRankingOptions? rankingOptions,
            global::G.FileSearchToolType type)
        {
            this.VectorStoreIds = vectorStoreIds ?? throw new global::System.ArgumentNullException(nameof(vectorStoreIds));
            this.Filters = filters;
            this.MaxNumResults = maxNumResults;
            this.RankingOptions = rankingOptions;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileSearchTool" /> class.
        /// </summary>
        public FileSearchTool()
        {
        }
    }
}