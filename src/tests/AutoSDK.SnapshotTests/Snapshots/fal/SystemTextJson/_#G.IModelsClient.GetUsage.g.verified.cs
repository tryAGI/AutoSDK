//HintName: G.IModelsClient.GetUsage.g.cs
#nullable enable

namespace G
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Usage<br/>
        /// Returns paginated usage records for your workspace with filters for endpoint,<br/>
        /// user, date range, and auth method. Each item includes the billed unit<br/>
        /// quantity and unit price used to compute cost.<br/>
        /// **Key Features:**<br/>
        /// - Usage data for all endpoints or filtered by specific endpoint(s)<br/>
        /// - Flexible date range filtering<br/>
        /// - User-specific usage tracking<br/>
        /// - Detailed usage line items with unit quantity and price<br/>
        /// - Paginated results for large datasets<br/>
        /// **Common Use Cases:**<br/>
        /// - Generate usage reports for all endpoints or specific models<br/>
        /// - Track usage patterns<br/>
        /// - Monitor endpoint usage across different auth methods<br/>
        /// - Build usage dashboards and visualizations<br/>
        /// See [fal.ai docs](https://docs.fal.ai/model-apis/faq) for more details.<br/>
        ///     
        /// </summary>
        /// <param name="limit">
        /// Maximum number of items to return. Actual maximum depends on query type and expansion parameters.<br/>
        /// Example: 50
        /// </param>
        /// <param name="cursor">
        /// Pagination cursor from previous response. Encodes the page number.<br/>
        /// Example: Mg==
        /// </param>
        /// <param name="start">
        /// Start date in ISO8601 format (e.g., '2025-01-01T00:00:00Z' or '2025-01-01'). Defaults to 24 hours ago.<br/>
        /// Example: 2025-01-01T00:00:00Z
        /// </param>
        /// <param name="end">
        /// End date in ISO8601 format, exclusive (e.g., '2025-02-01T00:00:00Z' or '2025-02-01'). Data up to but not including this timestamp is returned. Defaults to current time.<br/>
        /// Example: 2025-02-01T00:00:00Z
        /// </param>
        /// <param name="timezone">
        /// Timezone for date aggregation and boundaries. All timestamps in responses are in UTC, but this controls how dates are bucketed.<br/>
        /// Default Value: UTC<br/>
        /// Example: UTC
        /// </param>
        /// <param name="timeframe">
        /// Aggregation timeframe for timeseries data (auto-detected from date range if not specified). Auto-detection uses: minute (&lt;2h), hour (&lt;2d), day (&lt;64d), week (&lt;183d), month (&gt;=183d).<br/>
        /// Example: day
        /// </param>
        /// <param name="boundToTimeframe">
        /// Whether to adjust start/end dates to align with timeframe boundaries and use exclusive end. Defaults to true. When true, dates are aligned to the start of the timeframe period (e.g., start of day) and end is made exclusive (e.g., start of next day). When false, uses exact dates provided.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </param>
        /// <param name="endpointId">
        /// Filter by specific endpoint ID(s). Accepts 1-50 endpoint IDs. Supports comma-separated values: ?endpoint_id=model1,model2 or array syntax: ?endpoint_id=model1&amp;endpoint_id=model2<br/>
        /// Example: [fal-ai/flux/dev]
        /// </param>
        /// <param name="expand">
        /// Data to include in the response. Use 'time_series' for time-bucketed data, 'summary' for aggregate statistics, and 'auth_method' to include authentication method information (formatted with user key aliases). At least one of 'time_series' or 'summary' is required.<br/>
        /// Default Value: [time_series]<br/>
        /// Example: [time_series, auth_method]
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetUsageResponse> GetUsageAsync(
            int? limit = default,
            string? cursor = default,
            global::G.AnyOf<global::System.DateTime?, string>? start = default,
            global::G.AnyOf<global::System.DateTime?, string>? end = default,
            string? timezone = default,
            global::G.GetUsageTimeframe? timeframe = default,
            global::G.GetUsageBoundToTimeframe? boundToTimeframe = default,
            global::G.AnyOf<string, global::System.Collections.Generic.IList<string>>? endpointId = default,
            global::G.AnyOf<string, global::System.Collections.Generic.IList<string>>? expand = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}