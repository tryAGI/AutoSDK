//HintName: G.IAnalyticsClient.ApiAnalyticsKpisRetrieve2.g.cs
#nullable enable

namespace G
{
    public partial interface IAnalyticsClient
    {
        /// <summary>
        /// Get KPI data with optional segmentation<br/>
        /// Retrieve data for a specific KPI with support for filtering and segmentation. Can segment by time (hourly, daily, weekly, monthly, yearly), by user, or both (2D matrix). If no segmentation is specified, returns a single total value. Supports filtering by projects, members, and date range. Date filters are interpreted in the specified timezone (required parameter). Maximum 50 projects allowed per request for performance reasons.
        /// </summary>
        /// <param name="end"></param>
        /// <param name="kpiKey"></param>
        /// <param name="members"></param>
        /// <param name="projects"></param>
        /// <param name="segmentByProject"></param>
        /// <param name="segmentByTime"></param>
        /// <param name="segmentByUser"></param>
        /// <param name="start"></param>
        /// <param name="tz"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.KPIDetailResponse> ApiAnalyticsKpisRetrieve2Async(
            string kpiKey,
            string tz,
            global::System.DateTime? end = default,
            string? members = default,
            string? projects = default,
            bool? segmentByProject = default,
            string? segmentByTime = default,
            bool? segmentByUser = default,
            global::System.DateTime? start = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}