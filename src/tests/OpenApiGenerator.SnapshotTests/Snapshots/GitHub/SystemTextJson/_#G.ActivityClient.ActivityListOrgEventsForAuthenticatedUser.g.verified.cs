﻿//HintName: G.ActivityClient.ActivityListOrgEventsForAuthenticatedUser.g.cs

#nullable enable

namespace G
{
    public partial class ActivityClient
    {
        /// <summary>
        /// List organization events for the authenticated user
        /// </summary>
        /// <param name="username"></param>
        /// <param name="org"></param>
        /// <param name="perPage"></param>
        /// <param name="page"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task ActivityListOrgEventsForAuthenticatedUserAsync(
            string username,
            string org,
            int perPage,
            int page,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/users/{username}/events/orgs/{org}?per_page={perPage}&page={page}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }
    }
}