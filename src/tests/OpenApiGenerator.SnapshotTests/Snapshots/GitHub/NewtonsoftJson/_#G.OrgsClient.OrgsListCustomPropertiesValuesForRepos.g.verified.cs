//HintName: G.OrgsClient.OrgsListCustomPropertiesValuesForRepos.g.cs

#nullable enable

namespace G
{
    public partial class OrgsClient
    {
        /// <summary>
        /// List custom property values for organization repositories
        /// </summary>
        /// <param name="org"></param>
        /// <param name="perPage"></param>
        /// <param name="page"></param>
        /// <param name="repositoryQuery"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task OrgsListCustomPropertiesValuesForReposAsync(
            string org,
            int perPage,
            int page,
            string repositoryQuery,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/orgs/{org}/properties/values?per_page={perPage}&page={page}&repository_query={repositoryQuery}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }
    }
}