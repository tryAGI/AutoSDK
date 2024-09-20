//HintName: G.x3DModelAssetsClient.Get3DModelsByUserId.g.cs

#nullable enable

namespace G
{
    public partial class x3DModelAssetsClient
    {
        partial void PrepareGet3DModelsByUserIdArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int? offset,
            ref int? limit,
            ref string userId,
            global::G.Get3DModelsByUserIdRequest request);
        partial void PrepareGet3DModelsByUserIdRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int? offset,
            int? limit,
            string userId,
            global::G.Get3DModelsByUserIdRequest request);
        partial void ProcessGet3DModelsByUserIdResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGet3DModelsByUserIdResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get 3D models by user ID<br/>
        /// This endpoint returns all 3D models by a specific user
        /// </summary>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="userId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Get3DModelsByUserIdResponse> Get3DModelsByUserIdAsync(
            string userId,
            global::G.Get3DModelsByUserIdRequest request,
            int? offset = 0,
            int? limit = 10,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareGet3DModelsByUserIdArguments(
                httpClient: _httpClient,
                offset: ref offset,
                limit: ref limit,
                userId: ref userId,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/models-3d/user/{userId}",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("offset", offset?.ToString()) 
                .AddOptionalParameter("limit", limit?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
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
            PrepareGet3DModelsByUserIdRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                offset: offset,
                limit: limit,
                userId: userId,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessGet3DModelsByUserIdResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessGet3DModelsByUserIdResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.Get3DModelsByUserIdResponse?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Get 3D models by user ID<br/>
        /// This endpoint returns all 3D models by a specific user
        /// </summary>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="userId"></param>
        /// <param name="requestUserId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Get3DModelsByUserIdResponse> Get3DModelsByUserIdAsync(
            string userId,
            int? offset = 0,
            int? limit = 10,
            string? requestUserId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.Get3DModelsByUserIdRequest
            {
                UserId = requestUserId,
            };

            return await Get3DModelsByUserIdAsync(
                offset: offset,
                limit: limit,
                userId: userId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}