//HintName: G.CatalogClient.QuestionAnswering.g.cs

#nullable enable

namespace G
{
    public partial class CatalogClient
    {
        partial void PrepareQuestionAnsweringArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string namespaceId,
            ref string catalogId,
            global::G.QuestionAnsweringBody request);
        partial void PrepareQuestionAnsweringRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string namespaceId,
            string catalogId,
            global::G.QuestionAnsweringBody request);
        partial void ProcessQuestionAnsweringResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessQuestionAnsweringResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Ask a question
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="catalogId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.QuestionAnsweringResponse> QuestionAnsweringAsync(
            string namespaceId,
            string catalogId,
            global::G.QuestionAnsweringBody request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareQuestionAnsweringArguments(
                httpClient: _httpClient,
                namespaceId: ref namespaceId,
                catalogId: ref catalogId,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/v1alpha/namespaces/{namespaceId}/catalogs/{catalogId}/ask", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareQuestionAnsweringRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                namespaceId: namespaceId,
                catalogId: catalogId,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessQuestionAnsweringResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessQuestionAnsweringResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.QuestionAnsweringResponse?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Ask a question
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="catalogId"></param>
        /// <param name="question"></param>
        /// <param name="topK"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.QuestionAnsweringResponse> QuestionAnsweringAsync(
            string namespaceId,
            string catalogId,
            string? question = default,
            int topK = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.QuestionAnsweringBody
            {
                Question = question,
                TopK = topK,
            };

            return await QuestionAnsweringAsync(
                namespaceId: namespaceId,
                catalogId: catalogId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}