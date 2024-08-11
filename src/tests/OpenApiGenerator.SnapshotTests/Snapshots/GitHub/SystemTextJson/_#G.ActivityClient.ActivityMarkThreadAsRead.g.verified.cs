//HintName: G.ActivityClient.ActivityMarkThreadAsRead.g.cs

#nullable enable

namespace G
{
    public partial class ActivityClient
    {
        partial void PrepareActivityMarkThreadAsReadArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int threadId);
        partial void PrepareActivityMarkThreadAsReadRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int threadId);
        partial void ProcessActivityMarkThreadAsReadResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessActivityMarkThreadAsReadResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Mark a thread as read<br/>
        /// Marks a thread as "read." Marking a thread as "read" is equivalent to clicking a notification in your notification inbox on GitHub: https://github.com/notifications.
        /// </summary>
        /// <param name="threadId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.BasicError> ActivityMarkThreadAsReadAsync(
            int threadId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareActivityMarkThreadAsReadArguments(
                httpClient: _httpClient,
                threadId: ref threadId);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/notifications/threads/{threadId}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareActivityMarkThreadAsReadRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                threadId: threadId);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessActivityMarkThreadAsReadResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessActivityMarkThreadAsReadResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.BasicError?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}