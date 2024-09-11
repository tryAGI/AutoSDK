//HintName: G.ClusterClient.DeleteNodePoolV4ClustersClusterIdNodePoolsNodePoolNameDelete.g.cs

#nullable enable

namespace G
{
    public partial class ClusterClient
    {
        partial void PrepareDeleteNodePoolV4ClustersClusterIdNodePoolsNodePoolNameDeleteArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string clusterId,
            ref string nodePoolName);
        partial void PrepareDeleteNodePoolV4ClustersClusterIdNodePoolsNodePoolNameDeleteRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string clusterId,
            string nodePoolName);
        partial void ProcessDeleteNodePoolV4ClustersClusterIdNodePoolsNodePoolNameDeleteResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessDeleteNodePoolV4ClustersClusterIdNodePoolsNodePoolNameDeleteResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Delete Node Pool
        /// </summary>
        /// <param name="clusterId"></param>
        /// <param name="nodePoolName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.HTTPValidationError> DeleteNodePoolV4ClustersClusterIdNodePoolsNodePoolNameDeleteAsync(
            string clusterId,
            string nodePoolName,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareDeleteNodePoolV4ClustersClusterIdNodePoolsNodePoolNameDeleteArguments(
                httpClient: _httpClient,
                clusterId: ref clusterId,
                nodePoolName: ref nodePoolName);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Delete,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/v4/clusters/{clusterId}/node-pools/{nodePoolName}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareDeleteNodePoolV4ClustersClusterIdNodePoolsNodePoolNameDeleteRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                clusterId: clusterId,
                nodePoolName: nodePoolName);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessDeleteNodePoolV4ClustersClusterIdNodePoolsNodePoolNameDeleteResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessDeleteNodePoolV4ClustersClusterIdNodePoolsNodePoolNameDeleteResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.HTTPValidationError?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}