//HintName: G.IUsageClient.GetUsageCharacterStats.g.cs
#nullable enable

namespace G
{
    public partial interface IUsageClient
    {
        /// <summary>
        /// Get Characters Usage Metrics<br/>
        /// Returns the usage metrics for the current user or the entire workspace they are part of. The response provides a time axis based on the specified aggregation interval (default: day), with usage values for each interval along that axis. Usage is broken down by the selected breakdown type. For example, breakdown type "voice" will return the usage of each voice for each interval along the time axis.
        /// </summary>
        /// <param name="startUnix">
        /// UTC Unix timestamp for the start of the usage window, in milliseconds. To include the first day of the window, the timestamp should be at 00:00:00 of that day.<br/>
        /// Example: 1685574000
        /// </param>
        /// <param name="endUnix">
        /// UTC Unix timestamp for the end of the usage window, in milliseconds. To include the last day of the window, the timestamp should be at 23:59:59 of that day.<br/>
        /// Example: 1688165999
        /// </param>
        /// <param name="includeWorkspaceMetrics">
        /// Whether or not to include the statistics of the entire workspace.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="breakdownType">
        /// How to break down the information. Cannot be "user" or "api_key" if include_workspace_metrics is False.
        /// </param>
        /// <param name="aggregationInterval">
        /// The time interval over which to aggregate the usage data.
        /// </param>
        /// <param name="metric"></param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.UsageCharactersResponseModel> GetUsageCharacterStatsAsync(
            global::System.DateTimeOffset startUnix,
            global::System.DateTimeOffset endUnix,
            bool? includeWorkspaceMetrics = default,
            global::G.BreakdownTypes? breakdownType = default,
            global::G.UsageAggregationInterval? aggregationInterval = default,
            global::G.MetricType? metric = default,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}