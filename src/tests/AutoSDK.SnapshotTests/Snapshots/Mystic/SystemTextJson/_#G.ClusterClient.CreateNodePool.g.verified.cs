//HintName: G.ClusterClient.CreateNodePool.g.cs

#nullable enable

namespace G
{
    public partial class ClusterClient
    {
        partial void PrepareCreateNodePoolArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string clusterId,
            global::G.NodePoolCreate request);
        partial void PrepareCreateNodePoolRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string clusterId,
            global::G.NodePoolCreate request);
        partial void ProcessCreateNodePoolResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateNodePoolResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create Node Pool
        /// </summary>
        /// <param name="clusterId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CreateNodePoolV4ClustersClusterIdNodePoolsPostResponse> CreateNodePoolAsync(
            string clusterId,
            global::G.NodePoolCreate request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareCreateNodePoolArguments(
                httpClient: _httpClient,
                clusterId: ref clusterId,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/v4/clusters/{clusterId}/node-pools",
                baseUri: _httpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareCreateNodePoolRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                clusterId: clusterId,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessCreateNodePoolResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessCreateNodePoolResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateNodePoolV4ClustersClusterIdNodePoolsPostResponse?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create Node Pool
        /// </summary>
        /// <param name="clusterId"></param>
        /// <param name="accelerators"></param>
        /// <param name="spot">
        /// Default Value: true
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CreateNodePoolV4ClustersClusterIdNodePoolsPostResponse> CreateNodePoolAsync(
            string clusterId,
            global::System.Collections.Generic.IList<global::G.Accelerator> accelerators,
            bool? spot = true,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.NodePoolCreate
            {
                Accelerators = accelerators,
                Spot = spot,
            };

            return await CreateNodePoolAsync(
                clusterId: clusterId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}