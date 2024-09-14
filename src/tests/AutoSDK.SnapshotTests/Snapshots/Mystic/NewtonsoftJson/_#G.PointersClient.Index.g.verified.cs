//HintName: G.PointersClient.Index.g.cs

#nullable enable

namespace G
{
    public partial class PointersClient
    {
        partial void PrepareIndexArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? pipelineName,
            ref int skip,
            ref int limit,
            ref string? orderBy);
        partial void PrepareIndexRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? pipelineName,
            int skip,
            int limit,
            string? orderBy);
        partial void ProcessIndexResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessIndexResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Index<br/>
        /// Retrieve a paginated set of pipeline pointers that satisfy query parameters.<br/>
        /// Users are authorised to query for pointers:<br/>
        /// -related to a given pipeline family<br/>
        ///     `pipeline_name=marjory92/falcon`
        /// </summary>
        /// <param name="pipelineName"></param>
        /// <param name="skip">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="orderBy"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.PaginatedPointerGet> IndexAsync(
            string? pipelineName = default,
            int skip = 0,
            int limit = 20,
            string? orderBy = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareIndexArguments(
                httpClient: _httpClient,
                pipelineName: ref pipelineName,
                skip: ref skip,
                limit: ref limit,
                orderBy: ref orderBy);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/v4/pointers?pipeline_name={pipelineName}&skip={skip}&limit={limit}&order_by={orderBy}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareIndexRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                pipelineName: pipelineName,
                skip: skip,
                limit: limit,
                orderBy: orderBy);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessIndexResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessIndexResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.PaginatedPointerGet?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}