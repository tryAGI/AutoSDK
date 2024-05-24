//HintName: G.ActivityClient.ActivityListNotificationsForAuthenticatedUser.g.cs

#nullable enable

namespace G
{
    public partial class ActivityClient
    {
        /// <summary>
        /// List notifications for the authenticated user
        /// </summary>
        /// <param name="all"></param>
        /// <param name="participating"></param>
        /// <param name="since"></param>
        /// <param name="before"></param>
        /// <param name="page"></param>
        /// <param name="perPage"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task ActivityListNotificationsForAuthenticatedUserAsync(
            bool all,
            bool participating,
            global::System.DateTime since,
            global::System.DateTime before,
            int page,
            int perPage,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/notifications?all={all}&participating={participating}&since={since}&before={before}&page={page}&per_page={perPage}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }
    }
}