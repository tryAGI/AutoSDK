//HintName: G.ChatClient.ChatGetChatMessages.g.cs

#nullable enable

namespace G
{
    public partial class ChatClient
    {
        partial void PrepareChatGetChatMessagesArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? token,
            ref global::System.Guid? userId,
            ref global::System.Guid? projectId,
            ref global::System.Guid? lastRevievedProjectMessageId,
            ref global::System.Guid? lastRecievedGlobalMessageId);
        partial void PrepareChatGetChatMessagesRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? token,
            global::System.Guid? userId,
            global::System.Guid? projectId,
            global::System.Guid? lastRevievedProjectMessageId,
            global::System.Guid? lastRecievedGlobalMessageId);
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
            string? token = default,
            global::System.Guid? userId = default,
            global::System.Guid? projectId = default,
            global::System.Guid? lastRevievedProjectMessageId = default,
            global::System.Guid? lastRecievedGlobalMessageId = default,
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

            var __pathBuilder = new PathBuilder(
                path: "/api/v1/chat/getchatmessages",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("userId", userId?.ToString()) 
                .AddOptionalParameter("projectId", projectId?.ToString()) 
                .AddOptionalParameter("lastRevievedProjectMessageId", lastRevievedProjectMessageId?.ToString()) 
                .AddOptionalParameter("lastRecievedGlobalMessageId", lastRecievedGlobalMessageId?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            if (token != default)
            {
                httpRequest.Headers.TryAddWithoutValidation("token", token.ToString());
            }


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

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::System.Collections.Generic.IList<global::G.ChatMessageVO>?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}