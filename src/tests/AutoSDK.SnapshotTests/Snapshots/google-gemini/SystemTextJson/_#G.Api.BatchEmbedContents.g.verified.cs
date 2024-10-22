//HintName: G.Api.BatchEmbedContents.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        partial void PrepareBatchEmbedContentsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string modelId,
            global::G.BatchEmbedContentsRequest request);
        partial void PrepareBatchEmbedContentsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string modelId,
            global::G.BatchEmbedContentsRequest request);
        partial void ProcessBatchEmbedContentsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessBatchEmbedContentsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Generates multiple embeddings from the model given input text in a synchronous call.
        /// </summary>
        /// <param name="modelId">
        /// Default Value: embedding-001
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.BatchEmbedContentsResponse> BatchEmbedContentsAsync(
            string modelId,
            global::G.BatchEmbedContentsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareBatchEmbedContentsArguments(
                httpClient: HttpClient,
                modelId: ref modelId,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/models/{modelId}:batchEmbedContents",
                baseUri: HttpClient.BaseAddress);
            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "ApiKey" &&
                    __authorization.Location == "Query")
                {
                    __pathBuilder = __pathBuilder.AddRequiredParameter(__authorization.Name, __authorization.Value);
                }
            } 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareBatchEmbedContentsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                modelId: modelId,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessBatchEmbedContentsResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessBatchEmbedContentsResponseContent(
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
                global::G.BatchEmbedContentsResponse.FromJson(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Generates multiple embeddings from the model given input text in a synchronous call.
        /// </summary>
        /// <param name="modelId">
        /// Default Value: embedding-001
        /// </param>
        /// <param name="requests">
        /// Required. Embed requests for the batch. The model in each of these requests must match the model specified `BatchEmbedContentsRequest.model`.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.BatchEmbedContentsResponse> BatchEmbedContentsAsync(
            string modelId,
            global::System.Collections.Generic.IList<global::G.EmbedContentRequest>? requests = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.BatchEmbedContentsRequest
            {
                Requests = requests,
            };

            return await BatchEmbedContentsAsync(
                modelId: modelId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}