//HintName: G.AnnotationQueuesClient.UpdateAnnotationQueue.g.cs

#nullable enable

namespace G
{
    public partial class AnnotationQueuesClient
    {
        partial void PrepareUpdateAnnotationQueueArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string queueId,
            global::G.AnnotationQueueUpdateSchema request);
        partial void PrepareUpdateAnnotationQueueRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string queueId,
            global::G.AnnotationQueueUpdateSchema request);
        partial void ProcessUpdateAnnotationQueueResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUpdateAnnotationQueueResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update Annotation Queue
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<object> UpdateAnnotationQueueAsync(
            string queueId,
            global::G.AnnotationQueueUpdateSchema request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareUpdateAnnotationQueueArguments(
                httpClient: _httpClient,
                queueId: ref queueId,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Patch,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/annotation-queues/{queueId}", global::System.UriKind.RelativeOrAbsolute));
            var __json = global::System.Text.Json.JsonSerializer.Serialize(request, _jsonSerializerOptions);
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: __json,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareUpdateAnnotationQueueRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                queueId: queueId,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessUpdateAnnotationQueueResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessUpdateAnnotationQueueResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<object?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Update Annotation Queue
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="defaultDataset"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<object> UpdateAnnotationQueueAsync(
            string queueId,
            global::System.AnyOf<string?, object?>? name = default,
            global::System.AnyOf<string?, object?>? description = default,
            global::System.AnyOf<string?, object?>? defaultDataset = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.AnnotationQueueUpdateSchema
            {
                Name = name,
                Description = description,
                DefaultDataset = defaultDataset,
            };

            return await UpdateAnnotationQueueAsync(
                queueId: queueId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}