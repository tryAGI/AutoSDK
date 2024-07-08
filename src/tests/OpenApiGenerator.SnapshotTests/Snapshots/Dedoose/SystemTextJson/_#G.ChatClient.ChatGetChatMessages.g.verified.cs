//HintName: G.ChatClient.ChatGetChatMessages.g.cs

#nullable enable

namespace G
{
    public partial class ChatClient
    {
        partial void PrepareChatGetChatMessagesArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string token,
            ref string userId,
            ref string projectId,
            ref string lastRevievedProjectMessageId,
            ref string lastRecievedGlobalMessageId);
        partial void PrepareChatGetChatMessagesRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string token,
            string userId,
            string projectId,
            string lastRevievedProjectMessageId,
            string lastRecievedGlobalMessageId);
        partial void ProcessChatGetChatMessagesResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessChatGetChatMessagesResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// GetChatMessages.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="userId"></param>
        /// <param name="projectId"></param>
        /// <param name="lastRevievedProjectMessageId"></param>
        /// <param name="lastRecievedGlobalMessageId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.ChatMessageVO>> ChatGetChatMessagesAsync(
            string token,
            string userId,
            string projectId,
            string lastRevievedProjectMessageId,
            string lastRecievedGlobalMessageId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareChatGetChatMessagesArguments(
                httpClient: _httpClient,
                token: ref token,
                userId: ref userId,
                projectId: ref projectId,
                lastRevievedProjectMessageId: ref lastRevievedProjectMessageId,
                lastRecievedGlobalMessageId: ref lastRecievedGlobalMessageId);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/chat/getchatmessages?userId={userId}&projectId={projectId}&lastRevievedProjectMessageId={lastRevievedProjectMessageId}&lastRecievedGlobalMessageId={lastRecievedGlobalMessageId}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareChatGetChatMessagesRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                token: token,
                userId: userId,
                projectId: projectId,
                lastRevievedProjectMessageId: lastRevievedProjectMessageId,
                lastRecievedGlobalMessageId: lastRecievedGlobalMessageId);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessChatGetChatMessagesResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessChatGetChatMessagesResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<global::G.ChatMessageVO>?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}