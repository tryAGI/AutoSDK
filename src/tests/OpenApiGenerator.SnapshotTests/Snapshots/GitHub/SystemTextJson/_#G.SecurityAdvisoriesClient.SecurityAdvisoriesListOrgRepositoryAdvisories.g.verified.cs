//HintName: G.SecurityAdvisoriesClient.SecurityAdvisoriesListOrgRepositoryAdvisories.g.cs

#nullable enable

namespace G
{
    public partial class SecurityAdvisoriesClient
    {
        /// <summary>
        /// List repository security advisories for an organization
        /// </summary>
        /// <param name="org"></param>
        /// <param name="direction"></param>
        /// <param name="sort"></param>
        /// <param name="before"></param>
        /// <param name="after"></param>
        /// <param name="perPage"></param>
        /// <param name="state"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task SecurityAdvisoriesListOrgRepositoryAdvisoriesAsync(
            string org,
            string direction,
            string sort,
            string before,
            string after,
            int perPage,
            string state,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/orgs/{org}/security-advisories?direction={direction}&sort={sort}&before={before}&after={after}&per_page={perPage}&state={state}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }
    }
}