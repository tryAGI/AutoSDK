//HintName: G.ChatmessageClient.RemoveAllChatMessages.g.cs

#nullable enable

namespace G
{
    public partial class ChatmessageClient
    {
        partial void PrepareRemoveAllChatMessagesArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string id,
            ref string? chatId,
            ref string? memoryType,
            ref string? sessionId,
            ref global::G.RemoveAllChatMessagesChatType? chatType,
            ref string? startDate,
            ref string? endDate,
            ref global::G.RemoveAllChatMessagesFeedbackType? feedbackType,
            ref bool? hardDelete);
        partial void PrepareRemoveAllChatMessagesRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string id,
            string? chatId,
            string? memoryType,
            string? sessionId,
            global::G.RemoveAllChatMessagesChatType? chatType,
            string? startDate,
            string? endDate,
            global::G.RemoveAllChatMessagesFeedbackType? feedbackType,
            bool? hardDelete);
        partial void ProcessRemoveAllChatMessagesResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Delete all chat messages<br/>
        /// Delete all chat messages for a specific chatflow.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="chatId"></param>
        /// <param name="memoryType">
        /// Example: Buffer Memory
        /// </param>
        /// <param name="sessionId"></param>
        /// <param name="chatType"></param>
        /// <param name="startDate">
        /// Example: 2025-01-01T11:28:36.000Z
        /// </param>
        /// <param name="endDate">
        /// Example: 2025-01-13T11:28:36.000Z
        /// </param>
        /// <param name="feedbackType"></param>
        /// <param name="hardDelete"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task RemoveAllChatMessagesAsync(
            string id,
            string? chatId = default,
            string? memoryType = default,
            string? sessionId = default,
            global::G.RemoveAllChatMessagesChatType? chatType = default,
            string? startDate = default,
            string? endDate = default,
            global::G.RemoveAllChatMessagesFeedbackType? feedbackType = default,
            bool? hardDelete = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareRemoveAllChatMessagesArguments(
                httpClient: HttpClient,
                id: ref id,
                chatId: ref chatId,
                memoryType: ref memoryType,
                sessionId: ref sessionId,
                chatType: ref chatType,
                startDate: ref startDate,
                endDate: ref endDate,
                feedbackType: ref feedbackType,
                hardDelete: ref hardDelete);

            var chatTypeValue = chatType switch
            {
                global::G.RemoveAllChatMessagesChatType.Internal => "INTERNAL",
                global::G.RemoveAllChatMessagesChatType.External => "EXTERNAL",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var feedbackTypeValue = feedbackType switch
            {
                global::G.RemoveAllChatMessagesFeedbackType.ThumbsUp => "THUMBS_UP",
                global::G.RemoveAllChatMessagesFeedbackType.ThumbsDown => "THUMBS_DOWN",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var __pathBuilder = new global::G.PathBuilder(
                path: $"/chatmessage/{id}",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("chatId", chatId)
                .AddOptionalParameter("memoryType", memoryType)
                .AddOptionalParameter("sessionId", sessionId)
                .AddOptionalParameter("chatType", chatType?.ToValueString())
                .AddOptionalParameter("startDate", startDate)
                .AddOptionalParameter("endDate", endDate)
                .AddOptionalParameter("feedbackType", feedbackType?.ToValueString())
                .AddOptionalParameter("hardDelete", hardDelete?.ToString().ToLowerInvariant()) 
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
            PrepareRemoveAllChatMessagesRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                id: id,
                chatId: chatId,
                memoryType: memoryType,
                sessionId: sessionId,
                chatType: chatType,
                startDate: startDate,
                endDate: endDate,
                feedbackType: feedbackType,
                hardDelete: hardDelete);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessRemoveAllChatMessagesResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // 
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::System.Exception? __exception_400 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                    else
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_400 = __ex;
                }

                throw new global::G.ApiException(
                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_400,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_400,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // 
            if ((int)__response.StatusCode == 404)
            {
                string? __content_404 = null;
                global::System.Exception? __exception_404 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_404 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                    else
                    {
                        __content_404 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_404 = __ex;
                }

                throw new global::G.ApiException(
                    message: __content_404 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_404,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_404,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // 
            if ((int)__response.StatusCode == 500)
            {
                string? __content_500 = null;
                global::System.Exception? __exception_500 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_500 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                    else
                    {
                        __content_500 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_500 = __ex;
                }

                throw new global::G.ApiException(
                    message: __content_500 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_500,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_500,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                }
                catch (global::System.Exception __ex)
                {
                    throw new global::G.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();

                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                }
                catch (global::System.Exception __ex)
                {
                    string? __content = null;
                    try
                    {
                        __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                            cancellationToken
#endif
                        ).ConfigureAwait(false);
                    }
                    catch (global::System.Exception)
                    {
                    }

                    throw new global::G.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
        }
    }
}