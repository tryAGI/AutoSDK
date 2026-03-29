//HintName: G.Models.SearchRequestLogsRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Search and filter request logs with structured filters, free-text search, sorting, and pagination.
    /// </summary>
    public sealed partial class SearchRequestLogsRequest
    {
        /// <summary>
        /// Nested filter group with AND/OR logic. Use this for complex queries.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter_group")]
        public global::G.StructuredFilterGroup? FilterGroup { get; set; }

        /// <summary>
        /// Free-text search query. Searches across the prompt input and LLM output text using fuzzy prefix matching.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("q")]
        public string? Q { get; set; }

        /// <summary>
        /// Page number for pagination. Defaults to 1.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page")]
        public int? Page { get; set; }

        /// <summary>
        /// Number of results per page. Defaults to 10, maximum 25.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("per_page")]
        public int? PerPage { get; set; }

        /// <summary>
        /// Field to sort results by.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sort_by")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SearchRequestLogsRequestSortByJsonConverter))]
        public global::G.SearchRequestLogsRequestSortBy? SortBy { get; set; }

        /// <summary>
        /// Sort direction. Must be provided together with sort_by.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sort_order")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SearchRequestLogsRequestSortOrderJsonConverter))]
        public global::G.SearchRequestLogsRequestSortOrder? SortOrder { get; set; }

        /// <summary>
        /// When true, includes the prompt template name in each result item. Defaults to false.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_prompt_name")]
        public bool? IncludePromptName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchRequestLogsRequest" /> class.
        /// </summary>
        /// <param name="filterGroup">
        /// Nested filter group with AND/OR logic. Use this for complex queries.
        /// </param>
        /// <param name="q">
        /// Free-text search query. Searches across the prompt input and LLM output text using fuzzy prefix matching.
        /// </param>
        /// <param name="page">
        /// Page number for pagination. Defaults to 1.
        /// </param>
        /// <param name="perPage">
        /// Number of results per page. Defaults to 10, maximum 25.
        /// </param>
        /// <param name="sortBy">
        /// Field to sort results by.
        /// </param>
        /// <param name="sortOrder">
        /// Sort direction. Must be provided together with sort_by.
        /// </param>
        /// <param name="includePromptName">
        /// When true, includes the prompt template name in each result item. Defaults to false.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchRequestLogsRequest(
            global::G.StructuredFilterGroup? filterGroup,
            string? q,
            int? page,
            int? perPage,
            global::G.SearchRequestLogsRequestSortBy? sortBy,
            global::G.SearchRequestLogsRequestSortOrder? sortOrder,
            bool? includePromptName)
        {
            this.FilterGroup = filterGroup;
            this.Q = q;
            this.Page = page;
            this.PerPage = perPage;
            this.SortBy = sortBy;
            this.SortOrder = sortOrder;
            this.IncludePromptName = includePromptName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchRequestLogsRequest" /> class.
        /// </summary>
        public SearchRequestLogsRequest()
        {
        }
    }
}