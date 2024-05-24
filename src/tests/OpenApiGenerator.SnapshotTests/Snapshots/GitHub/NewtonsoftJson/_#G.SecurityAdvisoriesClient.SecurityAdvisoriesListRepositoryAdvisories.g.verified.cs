//HintName: G.SecurityAdvisoriesClient.SecurityAdvisoriesListRepositoryAdvisories.g.cs

#nullable enable

namespace G
{
    public partial class SecurityAdvisoriesClient
    {
        /// <summary>
        /// List repository security advisories
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="direction"></param>
        /// <param name="sort"></param>
        /// <param name="before"></param>
        /// <param name="after"></param>
        /// <param name="perPage"></param>
        /// <param name="state"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task SecurityAdvisoriesListRepositoryAdvisoriesAsync(
            string owner,
            string repo,
            SecurityAdvisoriesListRepositoryAdvisoriesDirection direction,
            SecurityAdvisoriesListRepositoryAdvisoriesSort sort,
            string before,
            string after,
            int perPage,
            SecurityAdvisoriesListRepositoryAdvisoriesState state,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var directionValue = direction switch
            {
                SecurityAdvisoriesListRepositoryAdvisoriesDirection.Asc => "asc",
                SecurityAdvisoriesListRepositoryAdvisoriesDirection.Desc => "desc",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var sortValue = sort switch
            {
                SecurityAdvisoriesListRepositoryAdvisoriesSort.Created => "created",
                SecurityAdvisoriesListRepositoryAdvisoriesSort.Updated => "updated",
                SecurityAdvisoriesListRepositoryAdvisoriesSort.Published => "published",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var stateValue = state switch
            {
                SecurityAdvisoriesListRepositoryAdvisoriesState.Triage => "triage",
                SecurityAdvisoriesListRepositoryAdvisoriesState.Draft => "draft",
                SecurityAdvisoriesListRepositoryAdvisoriesState.Published => "published",
                SecurityAdvisoriesListRepositoryAdvisoriesState.Closed => "closed",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/repos/{owner}/{repo}/security-advisories?direction={directionValue}&sort={sortValue}&before={before}&after={after}&per_page={perPage}&state={stateValue}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }
    }
}