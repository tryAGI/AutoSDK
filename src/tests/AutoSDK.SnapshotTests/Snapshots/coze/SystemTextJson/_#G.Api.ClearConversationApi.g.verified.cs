//HintName: G.Api.ClearConversationApi.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {


        private static readonly global::G.EndPointSecurityRequirement s_ClearConversationApiSecurityRequirement0 =
            new global::G.EndPointSecurityRequirement
            {
                Authorizations = new global::G.EndPointAuthorizationRequirement[]
                {                    new global::G.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "Token",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::G.EndPointSecurityRequirement[] s_ClearConversationApiSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_ClearConversationApiSecurityRequirement0,
            };
        partial void PrepareClearConversationApiArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string conversationId,
            object request);
        partial void PrepareClearConversationApiRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string conversationId,
            object request);
        partial void ProcessClearConversationApiResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessClearConversationApiResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// 清除上下文<br/>
        /// 清除指定会话中的上下文。<br/>
        /// &lt;span id="3a1c8d70"&gt;&lt;/span&gt;<br/>
        /// ## 接口说明<br/>
        /// 在智能体对话场景中，上下文指模型在处理当前输入时所能参考的历史消息、对话记录，它决定了模型对当前任务的理解深度和连贯性，直接影响输出结果的准确性和相关性。多轮对话中，如果需要开启新的话题，可以调用此 API 清除上下文。清除上下文后，对话中的历史消息不会作为上下文被输入给模型，后续对话不再受之前历史消息的影响，避免信息干扰，确保对话的准确性和连贯性。<br/>
        /// 会话中的消息存储在上下文段落（section）中，每次调用此 API 清除上下文时，系统会自动删除旧的上下文段落，并创建新的上下文段落用于存储新的消息。再次发起对话时，新分区中的消息会作为新的上下文传递给模型参考。<br/>
        /// * 清除上下文 API 只是清空模型可见的消息历史，不会实际删除会话中的消息，通过[查看消息列表](https://www.coze.cn/open/docs/developer_guides/list_message)或[查看消息详情](https://www.coze.cn/open/docs/developer_guides/retrieve_message)等 API 仍能查看到消息内容。<br/>
        /// * 会话、对话、消息和上下文段落的术语解释请参见[基础概念](https://www.coze.cn/open/docs/developer_guides/coze_api_overview#fed4a54c)。<br/>
        /// ![图片](https://p9-arcosite.byteimg.com/tos-cn-i-goo7wpa0wc/e4b55816254c4446ae59bbca33ca8e1d~tplv-goo7wpa0wc-image.image)
        /// </summary>
        /// <param name="conversationId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ClearConversationApiResponse> ClearConversationApiAsync(
            string conversationId,

            object request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareClearConversationApiArguments(
                httpClient: HttpClient,
                conversationId: ref conversationId,
                request: request);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_ClearConversationApiSecurityRequirements,
                operationName: "ClearConversationApiAsync");

            var __pathBuilder = new global::G.PathBuilder(
                path: $"/v1/conversations/{conversationId}/clear",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            var __cookies = new global::System.Collections.Generic.List<string>();
            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
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
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Cookie")
                {
                    var __cookieValue = global::System.Uri.EscapeDataString(__authorization.Value);
                    __cookies.Add($"{__authorization.Name}={__cookieValue}");
                }
            }

            if (__cookies.Count > 0)
            {
                __httpRequest.Headers.TryAddWithoutValidation("Cookie", string.Join("; ", __cookies));
            }
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareClearConversationApiRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                conversationId: conversationId,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessClearConversationApiResponse(
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
                ProcessClearConversationApiResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.ClearConversationApiResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.ClearConversationApiResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// <summary>
        /// 清除上下文<br/>
        /// 清除指定会话中的上下文。<br/>
        /// &lt;span id="3a1c8d70"&gt;&lt;/span&gt;<br/>
        /// ## 接口说明<br/>
        /// 在智能体对话场景中，上下文指模型在处理当前输入时所能参考的历史消息、对话记录，它决定了模型对当前任务的理解深度和连贯性，直接影响输出结果的准确性和相关性。多轮对话中，如果需要开启新的话题，可以调用此 API 清除上下文。清除上下文后，对话中的历史消息不会作为上下文被输入给模型，后续对话不再受之前历史消息的影响，避免信息干扰，确保对话的准确性和连贯性。<br/>
        /// 会话中的消息存储在上下文段落（section）中，每次调用此 API 清除上下文时，系统会自动删除旧的上下文段落，并创建新的上下文段落用于存储新的消息。再次发起对话时，新分区中的消息会作为新的上下文传递给模型参考。<br/>
        /// * 清除上下文 API 只是清空模型可见的消息历史，不会实际删除会话中的消息，通过[查看消息列表](https://www.coze.cn/open/docs/developer_guides/list_message)或[查看消息详情](https://www.coze.cn/open/docs/developer_guides/retrieve_message)等 API 仍能查看到消息内容。<br/>
        /// * 会话、对话、消息和上下文段落的术语解释请参见[基础概念](https://www.coze.cn/open/docs/developer_guides/coze_api_overview#fed4a54c)。<br/>
        /// ![图片](https://p9-arcosite.byteimg.com/tos-cn-i-goo7wpa0wc/e4b55816254c4446ae59bbca33ca8e1d~tplv-goo7wpa0wc-image.image)
        /// </summary>
        /// <param name="conversationId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ClearConversationApiResponse> ClearConversationApiAsync(
            string conversationId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new object
            {
            };

            return await ClearConversationApiAsync(
                conversationId: conversationId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}