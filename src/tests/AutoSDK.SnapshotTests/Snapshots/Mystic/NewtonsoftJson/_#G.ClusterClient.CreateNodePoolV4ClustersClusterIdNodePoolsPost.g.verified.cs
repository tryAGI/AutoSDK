//HintName: G.ClusterClient.CreateNodePoolV4ClustersClusterIdNodePoolsPost.g.cs

#nullable enable

namespace G
{
    public partial class ClusterClient
    {
        partial void PrepareCreateNodePoolV4ClustersClusterIdNodePoolsPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string clusterId,
            global::G.NodePoolCreate request);
        partial void PrepareCreateNodePoolV4ClustersClusterIdNodePoolsPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string clusterId,
            global::G.NodePoolCreate request);
        partial void ProcessCreateNodePoolV4ClustersClusterIdNodePoolsPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateNodePoolV4ClustersClusterIdNodePoolsPostResponseContent(
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
        public async global::System.Threading.Tasks.Task<global::G.CreateNodePoolV4ClustersClusterIdNodePoolsPostResponse> CreateNodePoolV4ClustersClusterIdNodePoolsPostAsync(
            string clusterId,
            global::G.NodePoolCreate request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareCreateNodePoolV4ClustersClusterIdNodePoolsPostArguments(
                httpClient: _httpClient,
                clusterId: ref clusterId,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/v4/clusters/{clusterId}/node-pools", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::Newtonsoft.Json.JsonConvert.SerializeObject(request, _jsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareCreateNodePoolV4ClustersClusterIdNodePoolsPostRequest(
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
            ProcessCreateNodePoolV4ClustersClusterIdNodePoolsPostResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessCreateNodePoolV4ClustersClusterIdNodePoolsPostResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.CreateNodePoolV4ClustersClusterIdNodePoolsPostResponse?>(__content, _jsonSerializerOptions) ??
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
        public async global::System.Threading.Tasks.Task<global::G.CreateNodePoolV4ClustersClusterIdNodePoolsPostResponse> CreateNodePoolV4ClustersClusterIdNodePoolsPostAsync(
            string clusterId,
            global::System.Collections.Generic.IList<global::G.Accelerator> accelerators,
            bool spot = true,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.NodePoolCreate
            {
                Accelerators = accelerators,
                Spot = spot,
            };

            return await CreateNodePoolV4ClustersClusterIdNodePoolsPostAsync(
                clusterId: clusterId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}