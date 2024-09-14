//HintName: G.ScalingConfigurationsClient.GetPipelineList.g.cs

#nullable enable

namespace G
{
    public partial class ScalingConfigurationsClient
    {
        partial void PrepareGetPipelineListArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string name,
            ref int skip,
            ref int limit,
            ref string? orderBy);
        partial void PrepareGetPipelineListRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string name,
            int skip,
            int limit,
            string? orderBy);
        partial void ProcessGetPipelineListResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetPipelineListResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get Pipeline List<br/>
        /// Get a list of pipelines scoped to the user which use a scaling configuration
        /// </summary>
        /// <param name="name"></param>
        /// <param name="skip">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="orderBy"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.PaginatedGetLean> GetPipelineListAsync(
            string name,
            int skip = 0,
            int limit = 20,
            string? orderBy = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareGetPipelineListArguments(
                httpClient: _httpClient,
                name: ref name,
                skip: ref skip,
                limit: ref limit,
                orderBy: ref orderBy);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/v4/scaling-configs/pipelines/{name}?skip={skip}&limit={limit}&order_by={orderBy}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareGetPipelineListRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                name: name,
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
            ProcessGetPipelineListResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessGetPipelineListResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.PaginatedGetLean?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}