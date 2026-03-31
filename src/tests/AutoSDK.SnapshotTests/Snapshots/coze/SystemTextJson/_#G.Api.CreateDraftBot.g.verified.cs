//HintName: G.Api.CreateDraftBot.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        partial void PrepareCreateDraftBotArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.CreateDraftBotRequest request);
        partial void PrepareCreateDraftBotRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.CreateDraftBotRequest request);
        partial void ProcessCreateDraftBotResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateDraftBotResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// 创建智能体<br/>
        /// {"0":{"ops":[{"insert":"创建一个新的智能体。\n"},{"insert":"创建的智能体为未发布的草稿状态，创建后可以在扣子编程智能体列表中查看智能体。调用"},{"attributes":{"hyperlink":"{\"href\":\"https://docs.coze.cn/developer_guides/publish_bot\",\"linkId\":\"06yargEEv7\"}"},"insert":"发布智能体"},{"insert":" API 发布智能体后，才能通过"},{"attributes":{"hyperlink":"{\"href\":\"https://docs.coze.cn/developer_guides/bots_list_draft_published\",\"linkId\":\"uR4W8XpOAf\"}"},"insert":"查看智能体列表"},{"insert":"或"},{"attributes":{"hyperlink":"{\"href\":\"https://docs.coze.cn/developer_guides/get_metadata_draft_published\",\"linkId\":\"0ghPnfB7hN\"}"},"insert":"查看智能体配置"},{"insert":" API 查看此智能体。\n"},{"insert":"通过 API 方式创建智能体时，支持为智能体设置所在空间、智能体名称和描述、头像、人设与回复逻辑及开场白。\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CreateDraftBotResponse> CreateDraftBotAsync(

            global::G.CreateDraftBotRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateDraftBotArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: "/v1/bot/create",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
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
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareCreateDraftBotRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreateDraftBotResponse(
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
                ProcessCreateDraftBotResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.CreateDraftBotResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.CreateDraftBotResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// 创建智能体<br/>
        /// {"0":{"ops":[{"insert":"创建一个新的智能体。\n"},{"insert":"创建的智能体为未发布的草稿状态，创建后可以在扣子编程智能体列表中查看智能体。调用"},{"attributes":{"hyperlink":"{\"href\":\"https://docs.coze.cn/developer_guides/publish_bot\",\"linkId\":\"06yargEEv7\"}"},"insert":"发布智能体"},{"insert":" API 发布智能体后，才能通过"},{"attributes":{"hyperlink":"{\"href\":\"https://docs.coze.cn/developer_guides/bots_list_draft_published\",\"linkId\":\"uR4W8XpOAf\"}"},"insert":"查看智能体列表"},{"insert":"或"},{"attributes":{"hyperlink":"{\"href\":\"https://docs.coze.cn/developer_guides/get_metadata_draft_published\",\"linkId\":\"0ghPnfB7hN\"}"},"insert":"查看智能体配置"},{"insert":" API 查看此智能体。\n"},{"insert":"通过 API 方式创建智能体时，支持为智能体设置所在空间、智能体名称和描述、头像、人设与回复逻辑及开场白。\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="description"></param>
        /// <param name="iconFileId">
        /// 头像文件id
        /// </param>
        /// <param name="mediaConfig"></param>
        /// <param name="modelInfoConfig"></param>
        /// <param name="name"></param>
        /// <param name="onboardingInfo"></param>
        /// <param name="pluginIdList"></param>
        /// <param name="promptInfo"></param>
        /// <param name="spaceId"></param>
        /// <param name="suggestReplyInfo"></param>
        /// <param name="workflowIdList"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CreateDraftBotResponse> CreateDraftBotAsync(
            string name,
            string spaceId,
            string? description = default,
            string? iconFileId = default,
            global::G.PropertiesMediaConfig? mediaConfig = default,
            global::G.PropertiesModelInfoConfig? modelInfoConfig = default,
            global::G.PropertiesOnboardingInfo? onboardingInfo = default,
            global::G.PropertiesPluginIdList? pluginIdList = default,
            global::G.PropertiesPromptInfo? promptInfo = default,
            global::G.PropertiesSuggestReplyInfo? suggestReplyInfo = default,
            global::G.PropertiesWorkflowIdList? workflowIdList = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {

            var __request = new global::G.CreateDraftBotRequest
            {
                Description = description,
                IconFileId = iconFileId,
                MediaConfig = mediaConfig,
                ModelInfoConfig = modelInfoConfig,
                Name = name,
                OnboardingInfo = onboardingInfo,
                PluginIdList = pluginIdList,
                PromptInfo = promptInfo,
                SpaceId = spaceId,
                SuggestReplyInfo = suggestReplyInfo,
                WorkflowIdList = workflowIdList,
            };

            return await CreateDraftBotAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}