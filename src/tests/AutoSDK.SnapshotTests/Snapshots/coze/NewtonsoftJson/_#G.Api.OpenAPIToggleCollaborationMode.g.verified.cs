//HintName: G.Api.OpenAPIToggleCollaborationMode.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        partial void PrepareOpenAPIToggleCollaborationModeArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string workflowId,
            global::G.OpenAPIToggleCollaborationModeRequest request);
        partial void PrepareOpenAPIToggleCollaborationModeRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string workflowId,
            global::G.OpenAPIToggleCollaborationModeRequest request);
        partial void ProcessOpenAPIToggleCollaborationModeResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessOpenAPIToggleCollaborationModeResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// 开启或关闭工作流多人协作<br/>
        /// {"0":{"ops":[{"insert":"开启或关闭工作流、对话流多人协作。\n"},{"attributes":{"lmkr":"1","description":"文档标题"},"insert":"*"},{"insert":"开启多人协作后，你才能调用"},{"attributes":{"hyperlink":"{\"href\":\"https://docs.coze.cn/developer_guides/add_workflow_collaborator\",\"linkId\":\"yvb8JbaxI6\"}"},"insert":"添加工作流的协作者"},{"insert":" API 为工作流添加协作者。\n"},{"attributes":{"anchor":"eb5222a1","heading":"h2","lmkr":"1","description":"文档标题"},"insert":"*"},{"insert":"接口限制\n"},{"attributes":{"lmkr":"1","list":"bullet1","description":"文档标题"},"insert":"*"},{"attributes":{"bold":"true"},"insert":"套餐限制"},{"insert":"：扣子企业版（企业标准版、企业旗舰版）。\n"},{"attributes":{"lmkr":"1","list":"bullet1","description":"文档标题"},"insert":"*"},{"insert":"只有资源库中的工作流和对话流支持添加多人协作，扣子应用中的工作流不支持开启多人协作模式，否则会报 4000 错误。\n"},{"attributes":{"lmkr":"1","list":"bullet1","description":"文档标题"},"insert":"*"},{"insert":"不支持渠道类型 OAuth 应用。使用 OAuth JWT 应用和服务访问令牌时，只需要有对应权限点即可。其余认证方式，只有"},{"attributes":{"bold":"true"},"insert":"工作流所有者"},{"insert":"能开启或关闭工作流的多人协作模式。\n"},{"attributes":{"lmkr":"1","list":"bullet1","description":"文档标题"},"insert":"*"},{"insert":"关闭工作流多人协作前，需要先调用"},{"attributes":{"hyperlink":"{\"href\":\"https://docs.coze.cn/developer_guides/remove_workflow_collaborator\",\"linkId\":\"y7iKM9RXOS\"}"},"insert":"删除工作流协作者"},{"insert":" API 删除所有协作者。\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="workflowId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.OpenAPIToggleCollaborationModeResponse> OpenAPIToggleCollaborationModeAsync(
            string workflowId,

            global::G.OpenAPIToggleCollaborationModeRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareOpenAPIToggleCollaborationModeArguments(
                httpClient: HttpClient,
                workflowId: ref workflowId,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: $"/v1/workflows/{workflowId}/collaboration_mode",
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
            PrepareOpenAPIToggleCollaborationModeRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                workflowId: workflowId,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessOpenAPIToggleCollaborationModeResponse(
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
                ProcessOpenAPIToggleCollaborationModeResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.OpenAPIToggleCollaborationModeResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.OpenAPIToggleCollaborationModeResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// 开启或关闭工作流多人协作<br/>
        /// {"0":{"ops":[{"insert":"开启或关闭工作流、对话流多人协作。\n"},{"attributes":{"lmkr":"1","description":"文档标题"},"insert":"*"},{"insert":"开启多人协作后，你才能调用"},{"attributes":{"hyperlink":"{\"href\":\"https://docs.coze.cn/developer_guides/add_workflow_collaborator\",\"linkId\":\"yvb8JbaxI6\"}"},"insert":"添加工作流的协作者"},{"insert":" API 为工作流添加协作者。\n"},{"attributes":{"anchor":"eb5222a1","heading":"h2","lmkr":"1","description":"文档标题"},"insert":"*"},{"insert":"接口限制\n"},{"attributes":{"lmkr":"1","list":"bullet1","description":"文档标题"},"insert":"*"},{"attributes":{"bold":"true"},"insert":"套餐限制"},{"insert":"：扣子企业版（企业标准版、企业旗舰版）。\n"},{"attributes":{"lmkr":"1","list":"bullet1","description":"文档标题"},"insert":"*"},{"insert":"只有资源库中的工作流和对话流支持添加多人协作，扣子应用中的工作流不支持开启多人协作模式，否则会报 4000 错误。\n"},{"attributes":{"lmkr":"1","list":"bullet1","description":"文档标题"},"insert":"*"},{"insert":"不支持渠道类型 OAuth 应用。使用 OAuth JWT 应用和服务访问令牌时，只需要有对应权限点即可。其余认证方式，只有"},{"attributes":{"bold":"true"},"insert":"工作流所有者"},{"insert":"能开启或关闭工作流的多人协作模式。\n"},{"attributes":{"lmkr":"1","list":"bullet1","description":"文档标题"},"insert":"*"},{"insert":"关闭工作流多人协作前，需要先调用"},{"attributes":{"hyperlink":"{\"href\":\"https://docs.coze.cn/developer_guides/remove_workflow_collaborator\",\"linkId\":\"y7iKM9RXOS\"}"},"insert":"删除工作流协作者"},{"insert":" API 删除所有协作者。\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="workflowId"></param>
        /// <param name="collaborationMode"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.OpenAPIToggleCollaborationModeResponse> OpenAPIToggleCollaborationModeAsync(
            string workflowId,
            global::G.OpenAPIToggleCollaborationModeRequestCollaborationMode? collaborationMode = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.OpenAPIToggleCollaborationModeRequest
            {
                CollaborationMode = collaborationMode,
            };

            return await OpenAPIToggleCollaborationModeAsync(
                workflowId: workflowId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}