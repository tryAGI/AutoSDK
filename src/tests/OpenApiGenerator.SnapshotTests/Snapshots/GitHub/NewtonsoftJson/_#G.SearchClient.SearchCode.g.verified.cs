//HintName: G.SearchClient.SearchCode.g.cs

#nullable enable

namespace G
{
    public partial class SearchClient
    {
        partial void PrepareSearchCodeArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string q,
            ref global::G.SearchCodeSort? sort,
            ref global::G.SearchCodeOrder? order,
            ref int perPage,
            ref int page);
        partial void PrepareSearchCodeRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string q,
            global::G.SearchCodeSort? sort,
            global::G.SearchCodeOrder? order,
            int perPage,
            int page);
        partial void ProcessSearchCodeResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessSearchCodeResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Search code<br/>
        /// Searches for query terms inside of a file. This method returns up to 100 results [per page](https://docs.github.com/rest/guides/using-pagination-in-the-rest-api).<br/>
        /// When searching for code, you can get text match metadata for the file **content** and file **path** fields when you pass the `text-match` media type. For more details about how to receive highlighted search results, see [Text match metadata](https://docs.github.com/rest/search/search#text-match-metadata).<br/>
        /// For example, if you want to find the definition of the `addClass` function inside [jQuery](https://github.com/jquery/jquery) repository, your query would look something like this:<br/>
        /// `q=addClass+in:file+language:js+repo:jquery/jquery`<br/>
        /// This query searches for the keyword `addClass` within a file's contents. The query limits the search to files where the language is JavaScript in the `jquery/jquery` repository.<br/>
        /// Considerations for code search:<br/>
        /// Due to the complexity of searching code, there are a few restrictions on how searches are performed:<br/>
        /// *   Only the _default branch_ is considered. In most cases, this will be the `master` branch.<br/>
        /// *   Only files smaller than 384 KB are searchable.<br/>
        /// *   You must always include at least one search term when searching source code. For example, searching for [`language:go`](https://github.com/search?utf8=%E2%9C%93&amp;q=language%3Ago&amp;type=Code) is not valid, while [`amazing<br/>
        /// language:go`](https://github.com/search?utf8=%E2%9C%93&amp;q=amazing+language%3Ago&amp;type=Code) is.<br/>
        /// This endpoint requires you to authenticate and limits you to 10 requests per minute.
        /// </summary>
        /// <param name="q"></param>
        /// <param name="sort"></param>
        /// <param name="order">
        /// Default Value: desc
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.SearchCodeResponse> SearchCodeAsync(
            string q,
            global::G.SearchCodeSort? sort = default,
            global::G.SearchCodeOrder? order = global::G.SearchCodeOrder.Desc,
            int perPage = 30,
            int page = 1,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareSearchCodeArguments(
                httpClient: _httpClient,
                q: ref q,
                sort: ref sort,
                order: ref order,
                perPage: ref perPage,
                page: ref page);

            var sortValue = sort switch
            {
                global::G.SearchCodeSort.Indexed => "indexed",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var orderValue = order switch
            {
                global::G.SearchCodeOrder.Desc => "desc",
                global::G.SearchCodeOrder.Asc => "asc",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/search/code?q={q}&sort={(global::System.Uri.EscapeDataString(sortValue?.ToString() ?? string.Empty))}&order={(global::System.Uri.EscapeDataString(orderValue?.ToString() ?? string.Empty))}&per_page={perPage}&page={page}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareSearchCodeRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                q: q,
                sort: sort,
                order: order,
                perPage: perPage,
                page: page);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessSearchCodeResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessSearchCodeResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.SearchCodeResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}