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
        public async global::System.Threading.Tasks.Task<string> CreateIdentityAnnotationQueueRunStatusAsync(
            global::System.Guid annotationQueueRunId,
            global::G.IdentityAnnotationQueueRunStatusCreateSchema request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateIdentityAnnotationQueueRunStatusArguments(
                httpClient: HttpClient,
                annotationQueueRunId: ref annotationQueueRunId,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/api/v1/annotation-queues/status/{annotationQueueRunId}",
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
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareCreateIdentityAnnotationQueueRunStatusRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                annotationQueueRunId: annotationQueueRunId,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreateIdentityAnnotationQueueRunStatusResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessCreateIdentityAnnotationQueueRunStatusResponseContent(
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

            return __content;
        }

        /// <summary>
        /// Create Identity Annotation Queue Run Status
        /// </summary>
        /// <param name="annotationQueueRunId"></param>
        /// <param name="status"></param>
        /// <param name="overrideAddedAt"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<string> CreateIdentityAnnotationQueueRunStatusAsync(
            global::System.Guid annotationQueueRunId,
            string? status = default,
            global::System.DateTime? overrideAddedAt = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.IdentityAnnotationQueueRunStatusCreateSchema
            {
                Status = status,
                OverrideAddedAt = overrideAddedAt,
            };

            return await CreateIdentityAnnotationQueueRunStatusAsync(
                annotationQueueRunId: annotationQueueRunId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}