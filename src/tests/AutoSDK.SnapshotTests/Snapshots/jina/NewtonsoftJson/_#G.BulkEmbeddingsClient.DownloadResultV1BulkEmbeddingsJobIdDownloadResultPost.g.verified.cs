//HintName: G.BulkEmbeddingsClient.DownloadResultV1BulkEmbeddingsJobIdDownloadResultPost.g.cs

#nullable enable

namespace G
{
    public partial class BulkEmbeddingsClient
    {
        partial void PrepareDownloadResultV1BulkEmbeddingsJobIdDownloadResultPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string jobId);
        partial void PrepareDownloadResultV1BulkEmbeddingsJobIdDownloadResultPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string jobId);
        partial void ProcessDownloadResultV1BulkEmbeddingsJobIdDownloadResultPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessDownloadResultV1BulkEmbeddingsJobIdDownloadResultPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Download Result
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.DownloadResultResponse> DownloadResultV1BulkEmbeddingsJobIdDownloadResultPostAsync(
            string jobId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareDownloadResultV1BulkEmbeddingsJobIdDownloadResultPostArguments(
                httpClient: HttpClient,
                jobId: ref jobId);

            var __pathBuilder = new PathBuilder(
                path: $"/v1/bulk-embeddings/{jobId}/download-result",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareDownloadResultV1BulkEmbeddingsJobIdDownloadResultPostRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                jobId: jobId);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessDownloadResultV1BulkEmbeddingsJobIdDownloadResultPostResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessDownloadResultV1BulkEmbeddingsJobIdDownloadResultPostResponseContent(
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
                global::G.DownloadResultResponse.FromJson(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}