//HintName: G.ActionsClient.ActionsGetActionsCacheList.g.cs

#nullable enable

namespace G
{
    public partial class ActionsClient
    {
        partial void PrepareActionsGetActionsCacheListArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string owner,
            ref string repo,
            ref int perPage,
            ref int page,
            ref string? @ref,
            ref string? key,
            ref global::G.ActionsGetActionsCacheListSort? sort,
            ref global::G.ActionsGetActionsCacheListDirection? direction);
        partial void PrepareActionsGetActionsCacheListRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string owner,
            string repo,
            int perPage,
            int page,
            string? @ref,
            string? key,
            global::G.ActionsGetActionsCacheListSort? sort,
            global::G.ActionsGetActionsCacheListDirection? direction);
        partial void ProcessActionsGetActionsCacheListResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessActionsGetActionsCacheListResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List GitHub Actions caches for a repository<br/>
        /// Lists the GitHub Actions caches for a repository.<br/>
        /// OAuth tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="ref"></param>
        /// <param name="key"></param>
        /// <param name="sort">
        /// Default Value: last_accessed_at
        /// </param>
        /// <param name="direction">
        /// Default Value: desc
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ActionsCacheList> ActionsGetActionsCacheListAsync(
            string owner,
            string repo,
            int perPage = 30,
            int page = 1,
            string? @ref = default,
            string? key = default,
            global::G.ActionsGetActionsCacheListSort? sort = global::G.ActionsGetActionsCacheListSort.LastAccessedAt,
            global::G.ActionsGetActionsCacheListDirection? direction = global::G.ActionsGetActionsCacheListDirection.Desc,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareActionsGetActionsCacheListArguments(
                httpClient: _httpClient,
                owner: ref owner,
                repo: ref repo,
                perPage: ref perPage,
                page: ref page,
                @ref: ref @ref,
                key: ref key,
                sort: ref sort,
                direction: ref direction);

            var sortValue = sort switch
            {
                global::G.ActionsGetActionsCacheListSort.CreatedAt => "created_at",
                global::G.ActionsGetActionsCacheListSort.LastAccessedAt => "last_accessed_at",
                global::G.ActionsGetActionsCacheListSort.SizeInBytes => "size_in_bytes",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var directionValue = direction switch
            {
                global::G.ActionsGetActionsCacheListDirection.Asc => "asc",
                global::G.ActionsGetActionsCacheListDirection.Desc => "desc",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/repos/{owner}/{repo}/actions/caches?per_page={perPage}&page={page}&ref={@ref}&key={key}&sort={(global::System.Uri.EscapeDataString(sortValue?.ToString() ?? string.Empty))}&direction={(global::System.Uri.EscapeDataString(directionValue?.ToString() ?? string.Empty))}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareActionsGetActionsCacheListRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                owner: owner,
                repo: repo,
                perPage: perPage,
                page: page,
                @ref: @ref,
                key: key,
                sort: sort,
                direction: direction);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessActionsGetActionsCacheListResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessActionsGetActionsCacheListResponseContent(
                httpClient: _httpClient,
                httpResponseMessage: response,
                content: ref __content);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.ActionsCacheList?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}