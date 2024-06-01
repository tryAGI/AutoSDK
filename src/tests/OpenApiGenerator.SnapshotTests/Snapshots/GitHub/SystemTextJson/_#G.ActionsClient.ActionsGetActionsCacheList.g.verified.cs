//HintName: G.ActionsClient.ActionsGetActionsCacheList.g.cs

#nullable enable

namespace G
{
    public partial class ActionsClient
    {
        /// <summary>
        /// List GitHub Actions caches for a repository
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="perPage"></param>
        /// <param name="page"></param>
        /// <param name="@ref"></param>
        /// <param name="key"></param>
        /// <param name="sort"></param>
        /// <param name="direction"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<ActionsCacheList> ActionsGetActionsCacheListAsync(
            string owner,
            string repo,
            int perPage,
            int page,
            string @ref,
            string key,
            ActionsGetActionsCacheListSort sort,
            ActionsGetActionsCacheListDirection direction,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/repos/{owner}/{repo}/actions/caches?per_page={perPage}&page={page}&ref={@ref}&key={key}&sort={sort}&direction={direction}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::System.Text.Json.JsonSerializer.Deserialize<ActionsCacheList?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}