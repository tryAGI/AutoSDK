//HintName: G.IAnalyticsClient.GetExtensionAnalytics.g.cs
#nullable enable

namespace G
{
    public partial interface IAnalyticsClient
    {
        /// <summary>
        /// Gets an analytics report for one or more extensions.<br/>
        /// Gets an analytics report for one or more extensions. The response contains the URLs used to download the reports (CSV files). [Learn More](https://dev.twitch.tv/docs/insights)<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **analytics:read:extensions** scope.
        /// </summary>
        /// <param name="extensionId"></param>
        /// <param name="type"></param>
        /// <param name="startedAt"></param>
        /// <param name="endedAt"></param>
        /// <param name="first"></param>
        /// <param name="after"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetExtensionAnalyticsResponse> GetExtensionAnalyticsAsync(
            string? extensionId = default,
            global::G.GetExtensionAnalyticsType? type = default,
            global::System.DateTime? startedAt = default,
            global::System.DateTime? endedAt = default,
            int? first = default,
            string? after = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}