﻿//HintName: G.Models.GetGameAnalyticsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetGameAnalyticsResponse
    {
        /// <summary>
        /// A list of reports. The reports are returned in no particular order; however, the data within each report is in ascending order by date (newest first). The report contains one row of data per day of the reporting window; the report contains rows for only those days that the game was used. A report is available only if the game was broadcast for at least 5 hours over the reporting period. The array is empty if there are no reports.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.GameAnalytics> Data { get; set; }

        /// <summary>
        /// Contains the information used to page through the list of results. The object is empty if there are no more pages left to page through. [Read More](https://dev.twitch.tv/docs/api/guide#pagination)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pagination")]
        public global::G.GetGameAnalyticsResponsePagination? Pagination { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetGameAnalyticsResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// A list of reports. The reports are returned in no particular order; however, the data within each report is in ascending order by date (newest first). The report contains one row of data per day of the reporting window; the report contains rows for only those days that the game was used. A report is available only if the game was broadcast for at least 5 hours over the reporting period. The array is empty if there are no reports.
        /// </param>
        /// <param name="pagination">
        /// Contains the information used to page through the list of results. The object is empty if there are no more pages left to page through. [Read More](https://dev.twitch.tv/docs/api/guide#pagination)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetGameAnalyticsResponse(
            global::System.Collections.Generic.IList<global::G.GameAnalytics> data,
            global::G.GetGameAnalyticsResponsePagination? pagination)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Pagination = pagination;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetGameAnalyticsResponse" /> class.
        /// </summary>
        public GetGameAnalyticsResponse()
        {
        }
    }
}