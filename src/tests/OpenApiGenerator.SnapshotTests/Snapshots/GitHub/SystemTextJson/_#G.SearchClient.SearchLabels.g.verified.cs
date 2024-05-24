//HintName: G.SearchClient.SearchLabels.g.cs

#nullable enable

namespace G
{
    public partial class SearchClient
    {
        /// <summary>
        /// Search labels
        /// </summary>
        /// <param name="repositoryId"></param>
        /// <param name="q"></param>
        /// <param name="sort"></param>
        /// <param name="order"></param>
        /// <param name="perPage"></param>
        /// <param name="page"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task SearchLabelsAsync(
            int repositoryId,
            string q,
            string sort,
            string order,
            int perPage,
            int page,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/search/labels?repository_id={repositoryId}&q={q}&sort={sort}&order={order}&per_page={perPage}&page={page}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }
    }
}