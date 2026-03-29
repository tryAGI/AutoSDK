//HintName: G.Models.SearchRequestLogsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Paginated search results.
    /// </summary>
    public sealed partial class SearchRequestLogsResponse
    {
        /// <summary>
        /// Indicates the request was successful.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        public bool? Success { get; set; }

        /// <summary>
        /// List of matching request log summaries.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        public global::System.Collections.Generic.IList<object>? Items { get; set; }

        /// <summary>
        /// Current page number.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page")]
        public int? Page { get; set; }

        /// <summary>
        /// Total number of pages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pages")]
        public int? Pages { get; set; }

        /// <summary>
        /// Number of results per page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("per_page")]
        public int? PerPage { get; set; }

        /// <summary>
        /// Total number of matching results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        public int? Total { get; set; }

        /// <summary>
        /// Whether there are more pages after the current one.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_next")]
        public bool? HasNext { get; set; }

        /// <summary>
        /// Whether there are pages before the current one.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_prev")]
        public bool? HasPrev { get; set; }

        /// <summary>
        /// Next page number, or null if on the last page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_num")]
        public int? NextNum { get; set; }

        /// <summary>
        /// Previous page number, or null if on the first page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prev_num")]
        public int? PrevNum { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchRequestLogsResponse" /> class.
        /// </summary>
        /// <param name="success">
        /// Indicates the request was successful.
        /// </param>
        /// <param name="items">
        /// List of matching request log summaries.
        /// </param>
        /// <param name="page">
        /// Current page number.
        /// </param>
        /// <param name="pages">
        /// Total number of pages.
        /// </param>
        /// <param name="perPage">
        /// Number of results per page.
        /// </param>
        /// <param name="total">
        /// Total number of matching results.
        /// </param>
        /// <param name="hasNext">
        /// Whether there are more pages after the current one.
        /// </param>
        /// <param name="hasPrev">
        /// Whether there are pages before the current one.
        /// </param>
        /// <param name="nextNum">
        /// Next page number, or null if on the last page.
        /// </param>
        /// <param name="prevNum">
        /// Previous page number, or null if on the first page.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchRequestLogsResponse(
            bool? success,
            global::System.Collections.Generic.IList<object>? items,
            int? page,
            int? pages,
            int? perPage,
            int? total,
            bool? hasNext,
            bool? hasPrev,
            int? nextNum,
            int? prevNum)
        {
            this.Success = success;
            this.Items = items;
            this.Page = page;
            this.Pages = pages;
            this.PerPage = perPage;
            this.Total = total;
            this.HasNext = hasNext;
            this.HasPrev = hasPrev;
            this.NextNum = nextNum;
            this.PrevNum = prevNum;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchRequestLogsResponse" /> class.
        /// </summary>
        public SearchRequestLogsResponse()
        {
        }
    }
}