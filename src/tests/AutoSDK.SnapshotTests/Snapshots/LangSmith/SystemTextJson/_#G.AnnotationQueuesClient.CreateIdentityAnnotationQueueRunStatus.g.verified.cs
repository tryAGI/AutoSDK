//HintName: G.AnnotationQueuesClient.CreateIdentityAnnotationQueueRunStatus.g.cs

#nullable enable

namespace G
{
    public partial class AnnotationQueuesClient
    {
        partial void PrepareCreateIdentityAnnotationQueueRunStatusArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.Guid annotationQueueRunId,
            global::G.IdentityAnnotationQueueRunStatusCreateSchema request);
        partial void PrepareCreateIdentityAnnotationQueueRunStatusRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Guid annotationQueueRunId,
            global::G.IdentityAnnotationQueueRunStatusCreateSchema request);
        partial void ProcessCreateIdentityAnnotationQueueRunStatusResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateIdentityAnnotationQueueRunStatusResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create Identity Annotation Queue Run Status
        /// </summary>
        /// <param name="annotationQueueRunId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CreateIdentityAnnotationQueueRunStatusApiV1AnnotationQueuesStatusAnnotationQueueRunIdPostResponse> CreateIdentityAnnotationQueueRunStatusAsync(
            global::System.Guid annotationQueueRunId,
            global::G.IdentityAnnotationQueueRunStatusCreateSchema request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareCreateIdentityAnnotationQueueRunStatusArguments(
                httpClient: _httpClient,
                annotationQueueRunId: ref annotationQueueRunId,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/api/v1/annotation-queues/status/{annotationQueueRunId}",
                baseUri: _httpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            foreach (var _authorization in _authorizations)
            {
                if (_authorization.Type == "Http" ||
                    _authorization.Type == "OAuth2")
                {
                    httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: _authorization.Name,
                        parameter: _authorization.Value);
                }
                else if (_authorization.Type == "ApiKey" &&
                         _authorization.Location == "Header")
                {
                    httpRequest.Headers.Add(_authorization.Name, _authorization.Value);
                }
            }
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareCreateIdentityAnnotationQueueRunStatusRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                annotationQueueRunId: annotationQueueRunId,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessCreateIdentityAnnotationQueueRunStatusResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessCreateIdentityAnnotationQueueRunStatusResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateIdentityAnnotationQueueRunStatusApiV1AnnotationQueuesStatusAnnotationQueueRunIdPostResponse?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create Identity Annotation Queue Run Status
        /// </summary>
        /// <param name="annotationQueueRunId"></param>
        /// <param name="status"></param>
        /// <param name="overrideAddedAt"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CreateIdentityAnnotationQueueRunStatusApiV1AnnotationQueuesStatusAnnotationQueueRunIdPostResponse> CreateIdentityAnnotationQueueRunStatusAsync(
            global::System.Guid annotationQueueRunId,
            global::G.AnyOf<string, object>? status = default,
            global::G.AnyOf<global::System.DateTime?, object>? overrideAddedAt = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.IdentityAnnotationQueueRunStatusCreateSchema
            {
                Status = status,
                OverrideAddedAt = overrideAddedAt,
            };

            return await CreateIdentityAnnotationQueueRunStatusAsync(
                annotationQueueRunId: annotationQueueRunId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}