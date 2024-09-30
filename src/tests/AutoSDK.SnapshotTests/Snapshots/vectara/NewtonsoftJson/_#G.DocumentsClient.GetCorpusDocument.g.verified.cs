//HintName: G.DocumentsClient.GetCorpusDocument.g.cs

#nullable enable

namespace G
{
    public partial class DocumentsClient
    {
        partial void PrepareGetCorpusDocumentArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int? requestTimeout,
            ref int? requestTimeoutMillis,
            ref string corpusKey,
            ref string documentId);
        partial void PrepareGetCorpusDocumentRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int? requestTimeout,
            int? requestTimeoutMillis,
            string corpusKey,
            string documentId);
        partial void ProcessGetCorpusDocumentResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetCorpusDocumentResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Retrieve a document
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="corpusKey">
        /// A user-provided key for a corpus.<br/>
        /// Example: my-corpus
        /// </param>
        /// <param name="documentId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Document> GetCorpusDocumentAsync(
            string corpusKey,
            string documentId,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareGetCorpusDocumentArguments(
                httpClient: _httpClient,
                requestTimeout: ref requestTimeout,
                requestTimeoutMillis: ref requestTimeoutMillis,
                corpusKey: ref corpusKey,
                documentId: ref documentId);

            if (requestTimeout != default)
            {
                _httpClient.DefaultRequestHeaders.TryAddWithoutValidation("Request-Timeout", requestTimeout.ToString());
            }
            if (requestTimeoutMillis != default)
            {
                _httpClient.DefaultRequestHeaders.TryAddWithoutValidation("Request-Timeout-Millis", requestTimeoutMillis.ToString());
            }

            var __pathBuilder = new PathBuilder(
                path: $"/v2/corpora/{corpusKey}/documents/{documentId}",
                baseUri: _httpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareGetCorpusDocumentRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                requestTimeout: requestTimeout,
                requestTimeoutMillis: requestTimeoutMillis,
                corpusKey: corpusKey,
                documentId: documentId);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessGetCorpusDocumentResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessGetCorpusDocumentResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.Document?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}