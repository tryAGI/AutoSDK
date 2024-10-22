//HintName: G.RAGEngineClient.V1LibrarySearch.g.cs

#nullable enable

namespace G
{
    public partial class RAGEngineClient
    {
        partial void PrepareV1LibrarySearchArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.LibrarySearchRequest request);
        partial void PrepareV1LibrarySearchRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.LibrarySearchRequest request);
        partial void ProcessV1LibrarySearchResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessV1LibrarySearchResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Search
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.LibrarySearchResponse> V1LibrarySearchAsync(
            global::G.LibrarySearchRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareV1LibrarySearchArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/studio/v1/library/search",
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
            PrepareV1LibrarySearchRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessV1LibrarySearchResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessV1LibrarySearchResponseContent(
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

            return
                global::G.LibrarySearchResponse.FromJson(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Search
        /// </summary>
        /// <param name="query"></param>
        /// <param name="maxSegments"></param>
        /// <param name="path"></param>
        /// <param name="labels"></param>
        /// <param name="fileIds"></param>
        /// <param name="retrievalStrategy">
        /// Default Value: default
        /// </param>
        /// <param name="maxNeighbors">
        /// Default Value: 1
        /// </param>
        /// <param name="retrievalSimilarityThreshold"></param>
        /// <param name="hybridSearchAlpha"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.LibrarySearchResponse> V1LibrarySearchAsync(
            string query,
            int? maxSegments = default,
            string? path = default,
            global::System.Collections.Generic.IList<string>? labels = default,
            global::System.Collections.Generic.IList<global::System.Guid>? fileIds = default,
            global::G.RetrievalStrategy? retrievalStrategy = global::G.RetrievalStrategy.Default,
            int? maxNeighbors = 1,
            double? retrievalSimilarityThreshold = default,
            double? hybridSearchAlpha = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.LibrarySearchRequest
            {
                Query = query,
                MaxSegments = maxSegments,
                Path = path,
                Labels = labels,
                FileIds = fileIds,
                RetrievalStrategy = retrievalStrategy,
                MaxNeighbors = maxNeighbors,
                RetrievalSimilarityThreshold = retrievalSimilarityThreshold,
                HybridSearchAlpha = hybridSearchAlpha,
            };

            return await V1LibrarySearchAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}