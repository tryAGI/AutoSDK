//HintName: G.Models.SearchPageTokenGetResponsesContentApplicationJsonSchemaPageInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An object that provides information about pagination.
    /// </summary>
    public sealed partial class SearchPageTokenGetResponsesContentApplicationJsonSchemaPageInfo
    {
        /// <summary>
        /// The maximum number of items on each page. When grouping by video, this field represents the maximum number of videos per page. Otherwise, it represents the maximum number of video clips per page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit_per_page")]
        public int? LimitPerPage { get; set; }

        /// <summary>
        /// A string representing the date and time, in the RFC 3339 format ("YYYY-MM-DDTHH:mm:ssZ"), that the page expires.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_expires_at")]
        public string? PageExpiresAt { get; set; }

        /// <summary>
        /// The total number of results. When grouping by video, this field represents the total number of video clips matching your query. Otherwise , this field represents the total number of videos.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_results")]
        public int? TotalResults { get; set; }

        /// <summary>
        /// When grouping by video, the platform return this field that shows the total number of video clips matching your query.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_inner_matches")]
        public int? TotalInnerMatches { get; set; }

        /// <summary>
        /// The unique identifier of the next page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_page_token")]
        public string? NextPageToken { get; set; }

        /// <summary>
        /// The unique identifier of the previous page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prev_page_token")]
        public string? PrevPageToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchPageTokenGetResponsesContentApplicationJsonSchemaPageInfo" /> class.
        /// </summary>
        /// <param name="limitPerPage">
        /// The maximum number of items on each page. When grouping by video, this field represents the maximum number of videos per page. Otherwise, it represents the maximum number of video clips per page.
        /// </param>
        /// <param name="pageExpiresAt">
        /// A string representing the date and time, in the RFC 3339 format ("YYYY-MM-DDTHH:mm:ssZ"), that the page expires.
        /// </param>
        /// <param name="totalResults">
        /// The total number of results. When grouping by video, this field represents the total number of video clips matching your query. Otherwise , this field represents the total number of videos.
        /// </param>
        /// <param name="totalInnerMatches">
        /// When grouping by video, the platform return this field that shows the total number of video clips matching your query.
        /// </param>
        /// <param name="nextPageToken">
        /// The unique identifier of the next page.
        /// </param>
        /// <param name="prevPageToken">
        /// The unique identifier of the previous page.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchPageTokenGetResponsesContentApplicationJsonSchemaPageInfo(
            int? limitPerPage,
            string? pageExpiresAt,
            int? totalResults,
            int? totalInnerMatches,
            string? nextPageToken,
            string? prevPageToken)
        {
            this.LimitPerPage = limitPerPage;
            this.PageExpiresAt = pageExpiresAt;
            this.TotalResults = totalResults;
            this.TotalInnerMatches = totalInnerMatches;
            this.NextPageToken = nextPageToken;
            this.PrevPageToken = prevPageToken;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchPageTokenGetResponsesContentApplicationJsonSchemaPageInfo" /> class.
        /// </summary>
        public SearchPageTokenGetResponsesContentApplicationJsonSchemaPageInfo()
        {
        }
    }
}