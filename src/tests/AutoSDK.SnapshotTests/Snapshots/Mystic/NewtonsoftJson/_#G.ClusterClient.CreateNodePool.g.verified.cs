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
        public async global::System.Threading.Tasks.Task<string> CreateNodePoolAsync(
            string clusterId,
            global::G.NodePoolCreate request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateNodePoolArguments(
                httpClient: HttpClient,
                clusterId: ref clusterId,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/v4/clusters/{clusterId}/node-pools",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareCreateNodePoolRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                clusterId: clusterId,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreateNodePoolResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessCreateNodePoolResponseContent(
                httpClient: HttpClient,
                httpResponseMessage: __response,
                content: ref __content);

            try
            {
                __response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException __ex)
            {
                throw new global::System.InvalidOperationException(__content, __ex);
            }

            return __content;
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
        public async global::System.Threading.Tasks.Task<string> CreateNodePoolAsync(
            string clusterId,
            global::System.Collections.Generic.IList<global::G.Accelerator> accelerators,
            bool? spot = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.NodePoolCreate
            {
                Accelerators = accelerators,
                Spot = spot,
            };

            return await CreateNodePoolAsync(
                clusterId: clusterId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}