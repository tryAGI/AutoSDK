//HintName: G.ActivityClient.ActivitySetThreadSubscription.g.cs

#nullable enable

namespace G
{
    public partial class ActivityClient
    {
        partial void PrepareActivitySetThreadSubscriptionArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int threadId,
            global::G.ActivitySetThreadSubscriptionRequest request);
        partial void PrepareActivitySetThreadSubscriptionRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int threadId,
            global::G.ActivitySetThreadSubscriptionRequest request);
        partial void ProcessActivitySetThreadSubscriptionResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessActivitySetThreadSubscriptionResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Set a thread subscription<br/>
        /// If you are watching a repository, you receive notifications for all threads by default. Use this endpoint to ignore future notifications for threads until you comment on the thread or get an **@mention**.<br/>
        /// You can also use this endpoint to subscribe to threads that you are currently not receiving notifications for or to subscribed to threads that you have previously ignored.<br/>
        /// Unsubscribing from a conversation in a repository that you are not watching is functionally equivalent to the [Delete a thread subscription](https://docs.github.com/rest/activity/notifications#delete-a-thread-subscription) endpoint.
        /// </summary>
        /// <param name="threadId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ThreadSubscription> ActivitySetThreadSubscriptionAsync(
            int threadId,
            global::G.ActivitySetThreadSubscriptionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareActivitySetThreadSubscriptionArguments(
                httpClient: _httpClient,
                threadId: ref threadId,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/notifications/threads/{threadId}/subscription", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::Newtonsoft.Json.JsonConvert.SerializeObject(request, _jsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareActivitySetThreadSubscriptionRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                threadId: threadId,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessActivitySetThreadSubscriptionResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessActivitySetThreadSubscriptionResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.ThreadSubscription?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Set a thread subscription<br/>
        /// If you are watching a repository, you receive notifications for all threads by default. Use this endpoint to ignore future notifications for threads until you comment on the thread or get an **@mention**.<br/>
        /// You can also use this endpoint to subscribe to threads that you are currently not receiving notifications for or to subscribed to threads that you have previously ignored.<br/>
        /// Unsubscribing from a conversation in a repository that you are not watching is functionally equivalent to the [Delete a thread subscription](https://docs.github.com/rest/activity/notifications#delete-a-thread-subscription) endpoint.
        /// </summary>
        /// <param name="threadId"></param>
        /// <param name="ignored">
        /// Whether to block all notifications from a thread.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ThreadSubscription> ActivitySetThreadSubscriptionAsync(
            int threadId,
            bool ignored = false,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.ActivitySetThreadSubscriptionRequest
            {
                Ignored = ignored,
            };

            return await ActivitySetThreadSubscriptionAsync(
                threadId: threadId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}