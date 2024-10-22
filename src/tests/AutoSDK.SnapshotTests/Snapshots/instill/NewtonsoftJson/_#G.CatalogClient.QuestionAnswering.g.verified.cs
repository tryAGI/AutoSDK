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
            ref string? instillRequesterUid,
            global::G.QuestionAnsweringBody request);
        partial void PrepareQuestionAnsweringRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string namespaceId,
            string catalogId,
            string? instillRequesterUid,
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
        /// <param name="instillRequesterUid"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.QuestionAnsweringResponse> QuestionAnsweringAsync(
            string namespaceId,
            string catalogId,
            global::G.QuestionAnsweringBody request,
            string? instillRequesterUid = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareQuestionAnsweringArguments(
                httpClient: HttpClient,
                namespaceId: ref namespaceId,
                catalogId: ref catalogId,
                instillRequesterUid: ref instillRequesterUid,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/v1alpha/namespaces/{namespaceId}/catalogs/{catalogId}/ask",
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

            if (instillRequesterUid != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("Instill-Requester-Uid", instillRequesterUid.ToString());
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
            PrepareQuestionAnsweringRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                namespaceId: namespaceId,
                catalogId: catalogId,
                instillRequesterUid: instillRequesterUid,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessQuestionAnsweringResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessQuestionAnsweringResponseContent(
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
                global::G.QuestionAnsweringResponse.FromJson(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Ask a question
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="catalogId"></param>
        /// <param name="instillRequesterUid"></param>
        /// <param name="question"></param>
        /// <param name="topK"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.QuestionAnsweringResponse> QuestionAnsweringAsync(
            string namespaceId,
            string catalogId,
            string? instillRequesterUid = default,
            string? question = default,
            int? topK = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.QuestionAnsweringBody
            {
                Question = question,
                TopK = topK,
            };

            return await QuestionAnsweringAsync(
                namespaceId: namespaceId,
                catalogId: catalogId,
                instillRequesterUid: instillRequesterUid,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}