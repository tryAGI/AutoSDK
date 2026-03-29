//HintName: G.ISubpackageAnalyticsClient.GetUserActivity.g.cs
#nullable enable

namespace G
{
    public partial interface ISubpackageAnalyticsClient
    {
        /// <summary>
        /// Get user activity grouped by endpoint<br/>
        /// Returns user activity data grouped by endpoint for the last 30 (completed) UTC days. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="date"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AnalyticsGetUserActivityResponse200> GetUserActivityAsync(
            string? date = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}