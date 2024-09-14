//HintName: G.ClusterClient.ListPipelines.g.cs

#nullable enable

namespace G
{
    public partial class ClusterClient
    {
        partial void PrepareListPipelinesArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string clusterId,
            ref int skip,
            ref int limit);
        partial void PrepareListPipelinesRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string clusterId,
            int skip,
            int limit);
        partial void ProcessListPipelinesResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessListPipelinesResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List Pipelines<br/>
        /// List pipelines deployed to a given cluster
        /// </summary>
        /// <param name="clusterId"></param>
        /// <param name="skip">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.PaginatedClusterDeployedPipelineGet> ListPipelinesAsync(
            string clusterId,
            int skip = 0,
            int limit = 20,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareListPipelinesArguments(
                httpClient: _httpClient,
                clusterId: ref clusterId,
                skip: ref skip,
                limit: ref limit);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/v4/clusters/{clusterId}/pipelines?skip={skip}&limit={limit}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareListPipelinesRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                clusterId: clusterId,
                skip: skip,
                limit: limit);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessListPipelinesResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessListPipelinesResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.PaginatedClusterDeployedPipelineGet?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}