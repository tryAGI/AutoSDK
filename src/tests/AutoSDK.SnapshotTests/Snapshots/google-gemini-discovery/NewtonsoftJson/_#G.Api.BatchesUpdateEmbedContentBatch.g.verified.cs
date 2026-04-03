//HintName: G.Api.BatchesUpdateEmbedContentBatch.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        partial void PrepareBatchesUpdateEmbedContentBatchArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string batchesId,
            ref string? updateMask,
            global::G.EmbedContentBatch request);
        partial void PrepareBatchesUpdateEmbedContentBatchRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string batchesId,
            string? updateMask,
            global::G.EmbedContentBatch request);
        partial void ProcessBatchesUpdateEmbedContentBatchResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessBatchesUpdateEmbedContentBatchResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Updates a batch of EmbedContent requests for batch processing.
        /// </summary>
        /// <param name="batchesId"></param>
        /// <param name="updateMask"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.EmbedContentBatch> BatchesUpdateEmbedContentBatchAsync(
            string batchesId,

            global::G.EmbedContentBatch request,
            string? updateMask = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareBatchesUpdateEmbedContentBatchArguments(
                httpClient: HttpClient,
                batchesId: ref batchesId,
                updateMask: ref updateMask,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: $"/batches/{batchesId}:updateEmbedContentBatch",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("updateMask", updateMask) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareBatchesUpdateEmbedContentBatchRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                batchesId: batchesId,
                updateMask: updateMask,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessBatchesUpdateEmbedContentBatchResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessBatchesUpdateEmbedContentBatchResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.EmbedContentBatch.FromJson(__content, JsonSerializerOptions) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::G.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        await global::G.EmbedContentBatch.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
                {
                    string? __content = null;
                    try
                    {
                        __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                            cancellationToken
#endif
                        ).ConfigureAwait(false);
                    }
                    catch (global::System.Exception)
                    {
                    }

                    throw new global::G.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
        }
        /// <summary>
        /// Updates a batch of EmbedContent requests for batch processing.
        /// </summary>
        /// <param name="batchesId"></param>
        /// <param name="updateMask"></param>
        /// <param name="model">
        /// Required. The name of the `Model` to use for generating the completion. Format: `models/{model}`.
        /// </param>
        /// <param name="displayName">
        /// Required. The user-defined name of this batch.
        /// </param>
        /// <param name="inputConfig">
        /// Configures the input to the batch request.
        /// </param>
        /// <param name="output">
        /// The output of a batch request. This is returned in the `AsyncBatchEmbedContentResponse` or the `EmbedContentBatch.output` field.
        /// </param>
        /// <param name="batchStats">
        /// Stats about the batch.
        /// </param>
        /// <param name="priority">
        /// Optional. The priority of the batch. Batches with a higher priority value will be processed before batches with a lower priority value. Negative values are allowed. Default is 0.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.EmbedContentBatch> BatchesUpdateEmbedContentBatchAsync(
            string batchesId,
            string? updateMask = default,
            string? model = default,
            string? displayName = default,
            global::G.InputEmbedContentConfig? inputConfig = default,
            global::G.EmbedContentBatchOutput? output = default,
            global::G.EmbedContentBatchStats? batchStats = default,
            string? priority = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.EmbedContentBatch
            {
                Model = model,
                DisplayName = displayName,
                InputConfig = inputConfig,
                Output = output,
                BatchStats = batchStats,
                Priority = priority,
            };

            return await BatchesUpdateEmbedContentBatchAsync(
                batchesId: batchesId,
                updateMask: updateMask,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}