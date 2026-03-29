//HintName: G.Models.GetAnalyticsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response containing performance analytics with pagination support
    /// </summary>
    public sealed partial class GetAnalyticsResponse
    {
        /// <summary>
        /// Cursor for the next page of results, null if no more pages
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("next_cursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// Boolean indicating if more results are available (convenience field derived from next_cursor)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("has_more", Required = global::Newtonsoft.Json.Required.Always)]
        public bool HasMore { get; set; } = default!;

        /// <summary>
        /// Time series analytics data grouped by time bucket (when expand includes 'time_series'). Each bucket contains all analytics records for that time period.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("time_series")]
        public global::System.Collections.Generic.IList<global::G.GetAnalyticsResponseTimeSerie>? TimeSeries { get; set; }

        /// <summary>
        /// Aggregate statistics (when expand includes 'summary')
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("summary")]
        public global::System.Collections.Generic.IList<global::G.GetAnalyticsResponseSummaryItem>? Summary { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsResponse" /> class.
        /// </summary>
        /// <param name="hasMore">
        /// Boolean indicating if more results are available (convenience field derived from next_cursor)
        /// </param>
        /// <param name="nextCursor">
        /// Cursor for the next page of results, null if no more pages
        /// </param>
        /// <param name="timeSeries">
        /// Time series analytics data grouped by time bucket (when expand includes 'time_series'). Each bucket contains all analytics records for that time period.
        /// </param>
        /// <param name="summary">
        /// Aggregate statistics (when expand includes 'summary')
        /// </param>
        public GetAnalyticsResponse(
            bool hasMore,
            string? nextCursor,
            global::System.Collections.Generic.IList<global::G.GetAnalyticsResponseTimeSerie>? timeSeries,
            global::System.Collections.Generic.IList<global::G.GetAnalyticsResponseSummaryItem>? summary)
        {
            this.NextCursor = nextCursor;
            this.HasMore = hasMore;
            this.TimeSeries = timeSeries;
            this.Summary = summary;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsResponse" /> class.
        /// </summary>
        public GetAnalyticsResponse()
        {
        }
    }
}