//HintName: G.ModerationClient.DeleteChatMessages.g.cs

#nullable enable

namespace G
{
    public partial class ModerationClient
    {
        partial void PrepareDeleteChatMessagesArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string broadcasterId,
            ref string moderatorId,
            ref string? messageId);
        partial void PrepareDeleteChatMessagesRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string broadcasterId,
            string moderatorId,
            string? messageId);
        partial void ProcessDeleteChatMessagesResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Removes a single chat message or all chat messages from the broadcaster’s chat room.<br/>
        /// Removes a single chat message or all chat messages from the broadcaster’s chat room.<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **moderator:manage:chat\_messages** scope.
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="moderatorId"></param>
        /// <param name="messageId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task DeleteChatMessagesAsync(
            string broadcasterId,
            string moderatorId,
            string? messageId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareDeleteChatMessagesArguments(
                httpClient: HttpClient,
                broadcasterId: ref broadcasterId,
                moderatorId: ref moderatorId,
                messageId: ref messageId);

            var __pathBuilder = new PathBuilder(
                path: "/moderation/chat",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddRequiredParameter("broadcaster_id", broadcasterId) 
                .AddRequiredParameter("moderator_id", moderatorId) 
                .AddOptionalParameter("message_id", messageId) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Delete,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

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

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareDeleteChatMessagesRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                broadcasterId: broadcasterId,
                moderatorId: moderatorId,
                messageId: messageId);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessDeleteChatMessagesResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            try
            {
                __response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException __ex)
            {
                throw new global::G.ApiException(
                    message: __response.ReasonPhrase ?? string.Empty,
                    innerException: __ex,
                    statusCode: __response.StatusCode)
                {
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
        }
    }
}