//HintName: G.IAdminApiClient.AdminGetAnalytics.g.cs
#nullable enable

namespace G
{
    public partial interface IAdminApiClient
    {
        /// <summary>
        /// Get usage statistics as an admin<br/>
        /// Retrieve usage statistics for the organization within a specified date range.<br/>
        /// Optionally group the results by API key or by API key and day.
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="groupBy"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AdminUsageReport> AdminGetAnalyticsAsync(
            global::System.DateTime startDate,
            global::System.DateTime endDate,
            global::G.AdminGetAnalyticsGroupBy? groupBy = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get usage statistics as an admin<br/>
        /// Retrieve usage statistics for the organization within a specified date range.<br/>
        /// Optionally group the results by API key or by API key and day.
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="groupBy"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AutoSDKHttpResponse<global::G.AdminUsageReport>> AdminGetAnalyticsAsResponseAsync(
            global::System.DateTime startDate,
            global::System.DateTime endDate,
            global::G.AdminGetAnalyticsGroupBy? groupBy = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}