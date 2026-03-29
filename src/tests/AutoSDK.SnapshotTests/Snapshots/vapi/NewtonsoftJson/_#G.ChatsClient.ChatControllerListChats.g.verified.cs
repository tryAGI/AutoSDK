//HintName: G.ChatsClient.ChatControllerListChats.g.cs

#nullable enable

namespace G
{
    public partial class ChatsClient
    {
        partial void PrepareChatControllerListChatsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? id,
            ref string? assistantId,
            ref string? assistantIdAny,
            ref string? squadId,
            ref string? sessionId,
            ref string? previousChatId,
            ref double? page,
            ref global::G.ChatControllerListChatsSortOrder? sortOrder,
            ref double? limit,
            ref global::System.DateTime? createdAtGt,
            ref global::System.DateTime? createdAtLt,
            ref global::System.DateTime? createdAtGe,
            ref global::System.DateTime? createdAtLe,
            ref global::System.DateTime? updatedAtGt,
            ref global::System.DateTime? updatedAtLt,
            ref global::System.DateTime? updatedAtGe,
            ref global::System.DateTime? updatedAtLe);
        partial void PrepareChatControllerListChatsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? id,
            string? assistantId,
            string? assistantIdAny,
            string? squadId,
            string? sessionId,
            string? previousChatId,
            double? page,
            global::G.ChatControllerListChatsSortOrder? sortOrder,
            double? limit,
            global::System.DateTime? createdAtGt,
            global::System.DateTime? createdAtLt,
            global::System.DateTime? createdAtGe,
            global::System.DateTime? createdAtLe,
            global::System.DateTime? updatedAtGt,
            global::System.DateTime? updatedAtLt,
            global::System.DateTime? updatedAtGe,
            global::System.DateTime? updatedAtLe);
        partial void ProcessChatControllerListChatsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessChatControllerListChatsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List Chats
        /// </summary>
        /// <param name="id"></param>
        /// <param name="assistantId"></param>
        /// <param name="assistantIdAny">
        /// Example: assistant-1,assistant-2,assistant-3
        /// </param>
        /// <param name="squadId"></param>
        /// <param name="sessionId"></param>
        /// <param name="previousChatId"></param>
        /// <param name="page"></param>
        /// <param name="sortOrder"></param>
        /// <param name="limit"></param>
        /// <param name="createdAtGt"></param>
        /// <param name="createdAtLt"></param>
        /// <param name="createdAtGe"></param>
        /// <param name="createdAtLe"></param>
        /// <param name="updatedAtGt"></param>
        /// <param name="updatedAtLt"></param>
        /// <param name="updatedAtGe"></param>
        /// <param name="updatedAtLe"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ChatPaginatedResponse> ChatControllerListChatsAsync(
            string? id = default,
            string? assistantId = default,
            string? assistantIdAny = default,
            string? squadId = default,
            string? sessionId = default,
            string? previousChatId = default,
            double? page = default,
            global::G.ChatControllerListChatsSortOrder? sortOrder = default,
            double? limit = default,
            global::System.DateTime? createdAtGt = default,
            global::System.DateTime? createdAtLt = default,
            global::System.DateTime? createdAtGe = default,
            global::System.DateTime? createdAtLe = default,
            global::System.DateTime? updatedAtGt = default,
            global::System.DateTime? updatedAtLt = default,
            global::System.DateTime? updatedAtGe = default,
            global::System.DateTime? updatedAtLe = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareChatControllerListChatsArguments(
                httpClient: HttpClient,
                id: ref id,
                assistantId: ref assistantId,
                assistantIdAny: ref assistantIdAny,
                squadId: ref squadId,
                sessionId: ref sessionId,
                previousChatId: ref previousChatId,
                page: ref page,
                sortOrder: ref sortOrder,
                limit: ref limit,
                createdAtGt: ref createdAtGt,
                createdAtLt: ref createdAtLt,
                createdAtGe: ref createdAtGe,
                createdAtLe: ref createdAtLe,
                updatedAtGt: ref updatedAtGt,
                updatedAtLt: ref updatedAtLt,
                updatedAtGe: ref updatedAtGe,
                updatedAtLe: ref updatedAtLe);

            var sortOrderValue = sortOrder switch
            {
                global::G.ChatControllerListChatsSortOrder.Asc => "ASC",
                global::G.ChatControllerListChatsSortOrder.Desc => "DESC",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var __pathBuilder = new global::G.PathBuilder(
                path: "/chat",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("id", id)
                .AddOptionalParameter("assistantId", assistantId)
                .AddOptionalParameter("assistantIdAny", assistantIdAny)
                .AddOptionalParameter("squadId", squadId)
                .AddOptionalParameter("sessionId", sessionId)
                .AddOptionalParameter("previousChatId", previousChatId)
                .AddOptionalParameter("page", page?.ToString())
                .AddOptionalParameter("sortOrder", sortOrder?.ToValueString())
                .AddOptionalParameter("limit", limit?.ToString())
                .AddOptionalParameter("createdAtGt", createdAtGt?.ToString("yyyy-MM-ddTHH:mm:ssZ"))
                .AddOptionalParameter("createdAtLt", createdAtLt?.ToString("yyyy-MM-ddTHH:mm:ssZ"))
                .AddOptionalParameter("createdAtGe", createdAtGe?.ToString("yyyy-MM-ddTHH:mm:ssZ"))
                .AddOptionalParameter("createdAtLe", createdAtLe?.ToString("yyyy-MM-ddTHH:mm:ssZ"))
                .AddOptionalParameter("updatedAtGt", updatedAtGt?.ToString("yyyy-MM-ddTHH:mm:ssZ"))
                .AddOptionalParameter("updatedAtLt", updatedAtLt?.ToString("yyyy-MM-ddTHH:mm:ssZ"))
                .AddOptionalParameter("updatedAtGe", updatedAtGe?.ToString("yyyy-MM-ddTHH:mm:ssZ"))
                .AddOptionalParameter("updatedAtLe", updatedAtLe?.ToString("yyyy-MM-ddTHH:mm:ssZ")) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
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
            PrepareChatControllerListChatsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                id: id,
                assistantId: assistantId,
                assistantIdAny: assistantIdAny,
                squadId: squadId,
                sessionId: sessionId,
                previousChatId: previousChatId,
                page: page,
                sortOrder: sortOrder,
                limit: limit,
                createdAtGt: createdAtGt,
                createdAtLt: createdAtLt,
                createdAtGe: createdAtGe,
                createdAtLe: createdAtLe,
                updatedAtGt: updatedAtGt,
                updatedAtLt: updatedAtLt,
                updatedAtGe: updatedAtGe,
                updatedAtLe: updatedAtLe);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessChatControllerListChatsResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

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
                ProcessChatControllerListChatsResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.ChatPaginatedResponse.FromJson(__content, JsonSerializerOptions) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
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

                    return
                        await global::G.ChatPaginatedResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
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