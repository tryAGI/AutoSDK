//HintName: G.Models.GetUsageResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response containing usage data with pagination support
    /// </summary>
    public sealed partial class GetUsageResponse
    {
        /// <summary>
        /// Cursor for the next page of results, null if no more pages
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// Boolean indicating if more results are available (convenience field derived from next_cursor)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasMore { get; set; }

        /// <summary>
        /// Time series usage data grouped by time bucket (when expand includes 'time_series'). Each bucket contains all usage records for that time period.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("time_series")]
        public global::System.Collections.Generic.IList<global::G.GetUsageResponseTimeSerie>? TimeSeries { get; set; }

        /// <summary>
        /// Aggregate statistics (when expand includes 'summary')
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public global::System.Collections.Generic.IList<global::G.GetUsageResponseSummaryItem>? Summary { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUsageResponse" /> class.
        /// </summary>
        /// <param name="hasMore">
        /// Boolean indicating if more results are available (convenience field derived from next_cursor)
        /// </param>
        /// <param name="nextCursor">
        /// Cursor for the next page of results, null if no more pages
        /// </param>
        /// <param name="timeSeries">
        /// Time series usage data grouped by time bucket (when expand includes 'time_series'). Each bucket contains all usage records for that time period.
        /// </param>
        /// <param name="summary">
        /// Aggregate statistics (when expand includes 'summary')
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetUsageResponse(
            bool hasMore,
            string? nextCursor,
            global::System.Collections.Generic.IList<global::G.GetUsageResponseTimeSerie>? timeSeries,
            global::System.Collections.Generic.IList<global::G.GetUsageResponseSummaryItem>? summary)
        {
            this.NextCursor = nextCursor;
            this.HasMore = hasMore;
            this.TimeSeries = timeSeries;
            this.Summary = summary;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUsageResponse" /> class.
        /// </summary>
        public GetUsageResponse()
        {
        }
    }
}