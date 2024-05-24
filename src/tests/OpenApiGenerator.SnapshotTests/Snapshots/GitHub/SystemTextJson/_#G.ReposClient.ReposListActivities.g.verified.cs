//HintName: G.ReposClient.ReposListActivities.g.cs

#nullable enable

namespace G
{
    public partial class ReposClient
    {
        /// <summary>
        /// List repository activities
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="direction"></param>
        /// <param name="perPage"></param>
        /// <param name="before"></param>
        /// <param name="after"></param>
        /// <param name="@ref"></param>
        /// <param name="actor"></param>
        /// <param name="timePeriod"></param>
        /// <param name="activityType"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task ReposListActivitiesAsync(
            string owner,
            string repo,
            string direction,
            int perPage,
            string before,
            string after,
            string @ref,
            string actor,
            string timePeriod,
            string activityType,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/repos/{owner}/{repo}/activity?direction={direction}&per_page={perPage}&before={before}&after={after}&ref={@ref}&actor={actor}&time_period={timePeriod}&activity_type={activityType}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }
    }
}