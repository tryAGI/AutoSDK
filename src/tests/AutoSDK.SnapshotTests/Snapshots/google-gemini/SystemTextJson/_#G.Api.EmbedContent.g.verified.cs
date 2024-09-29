//HintName: G.Api.EmbedContent.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        partial void PrepareEmbedContentArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string modelId,
            global::G.EmbedContentRequest request);
        partial void PrepareEmbedContentRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string modelId,
            global::G.EmbedContentRequest request);
        partial void ProcessEmbedContentResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessEmbedContentResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Generates an embedding from the model given an input `Content`.
        /// </summary>
        /// <param name="modelId">
        /// Default Value: embedding-001
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.EmbedContentResponse> EmbedContentAsync(
            string modelId,
            global::G.EmbedContentRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareEmbedContentArguments(
                httpClient: _httpClient,
                modelId: ref modelId,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/models/{modelId}:embedContent",
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
            PrepareEmbedContentRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                modelId: modelId,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessEmbedContentResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessEmbedContentResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.EmbedContentResponse?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Generates an embedding from the model given an input `Content`.
        /// </summary>
        /// <param name="modelId">
        /// Default Value: embedding-001
        /// </param>
        /// <param name="title">
        /// Optional. An optional title for the text. Only applicable when TaskType is `RETRIEVAL_DOCUMENT`. Note: Specifying a `title` for `RETRIEVAL_DOCUMENT` provides better quality embeddings for retrieval.
        /// </param>
        /// <param name="content">
        /// The base structured datatype containing multi-part content of a message. A `Content` includes a `role` field designating the producer of the `Content` and a `parts` field containing multi-part data that contains the content of the message turn.
        /// </param>
        /// <param name="taskType">
        /// Optional. Optional task type for which the embeddings will be used. Can only be set for `models/embedding-001` or newer models.
        /// </param>
        /// <param name="model">
        /// Required. The model's resource name. This serves as an ID for the Model to use. This name should match a model name returned by the `ListModels` method. Format: `models/{model}`
        /// </param>
        /// <param name="outputDimensionality">
        /// Optional. Optional reduced dimension for the output embedding. If set, excessive values in the output embedding are truncated from the end. Supported by newer models since 2024, and the earlier model (`models/embedding-001`) cannot specify this value.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.EmbedContentResponse> EmbedContentAsync(
            string modelId,
            string? title = default,
            global::G.Content? content = default,
            global::G.EmbedContentRequestTaskType? taskType = default,
            string? model = default,
            int? outputDimensionality = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.EmbedContentRequest
            {
                Title = title,
                Content = content,
                TaskType = taskType,
                Model = model,
                OutputDimensionality = outputDimensionality,
            };

            return await EmbedContentAsync(
                modelId: modelId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}