//HintName: G.BatchClient.CreateBatch.g.cs

#nullable enable

namespace G
{
    public partial class BatchClient
    {
        /// <summary>
        /// Creates and executes a batch from an uploaded file of requests
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<Batch> CreateBatchAsync(
            CreateBatchRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + "/batches", global::System.UriKind.RelativeOrAbsolute));
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: global::System.Text.Json.JsonSerializer.Serialize(request, _jsonSerializerOptions),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::System.Text.Json.JsonSerializer.Deserialize<Batch?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Creates and executes a batch from an uploaded file of requests
        /// </summary>
        /// <param name="inputFileId"></param>
        /// <param name="endpoint"></param>
        /// <param name="completionWindow"></param>
        /// <param name="metadata"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<Batch> CreateBatchAsync(
            string inputFileId,
            CreateBatchRequestEndpoint endpoint,
            CreateBatchRequestCompletionWindow completionWindow,
            object? metadata = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new CreateBatchRequest
            {
                InputFileId = inputFileId,
                Endpoint = endpoint,
                CompletionWindow = completionWindow,
                Metadata = metadata,
            };

            return await CreateBatchAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}