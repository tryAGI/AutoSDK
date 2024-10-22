//HintName: G.AnnotationQueuesClient.UpdateAnnotationQueue.g.cs

#nullable enable

namespace G
{
    public partial class AnnotationQueuesClient
    {
        partial void PrepareUpdateAnnotationQueueArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.Guid queueId,
            global::G.AnnotationQueueUpdateSchema request);
        partial void PrepareUpdateAnnotationQueueRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Guid queueId,
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
        public async global::System.Threading.Tasks.Task<string> UpdateAnnotationQueueAsync(
            global::System.Guid queueId,
            global::G.AnnotationQueueUpdateSchema request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareUpdateAnnotationQueueArguments(
                httpClient: HttpClient,
                queueId: ref queueId,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/api/v1/annotation-queues/{queueId}",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
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
            PrepareUpdateAnnotationQueueRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                queueId: queueId,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessUpdateAnnotationQueueResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessUpdateAnnotationQueueResponseContent(
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
        /// Update Annotation Queue
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="defaultDataset"></param>
        /// <param name="numReviewersPerItem">
        /// Default Value: 1
        /// </param>
        /// <param name="enableReservations">
        /// Default Value: true
        /// </param>
        /// <param name="reservationMinutes"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<string> UpdateAnnotationQueueAsync(
            global::System.Guid queueId,
            string? name = default,
            string? description = default,
            global::System.Guid? defaultDataset = default,
            int? numReviewersPerItem = 1,
            bool? enableReservations = true,
            int? reservationMinutes = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.AnnotationQueueUpdateSchema
            {
                Name = name,
                Description = description,
                DefaultDataset = defaultDataset,
                NumReviewersPerItem = numReviewersPerItem,
                EnableReservations = enableReservations,
                ReservationMinutes = reservationMinutes,
            };

            return await UpdateAnnotationQueueAsync(
                queueId: queueId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}