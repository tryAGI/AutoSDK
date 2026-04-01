//HintName: G.Api.OpenAPIInstallConnectorToWorkspace.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        partial void PrepareOpenAPIInstallConnectorToWorkspaceArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string connectorId,
            global::G.OpenAPIInstallConnectorToWorkspaceRequest request);
        partial void PrepareOpenAPIInstallConnectorToWorkspaceRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string connectorId,
            global::G.OpenAPIInstallConnectorToWorkspaceRequest request);
        partial void ProcessOpenAPIInstallConnectorToWorkspaceResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessOpenAPIInstallConnectorToWorkspaceResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// 添加发布渠道<br/>
        /// {"0":{"ops":[{"insert":"为指定空间添加一个发布渠道。\n"},{"attributes":{"anchor":"6989363f","heading":"h2","lmkr":"1"},"insert":"*"},{"insert":"接口说明\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"在扣子编程中发布智能体或应用时，可发布的渠道范围与工作空间有关。每个工作空间均配置了官方默认发布渠道，例如扣子商店、豆包、API 、SDK 等。除此之外，工作空间中还可以手动添加公共渠道和企业自定义渠道，按需拓展 AI 项目的分发渠道。添加渠道后，空间中的每个开发者都可以将自己的 AI 项目发布到这些渠道中。\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"attributes":{"zoneId":"2kBs0K0Zwr","zoneType":"Z","type":"tip","title":"说明","border":"#bacefd","background":"#f0f4ff","highlight-block-v2":"true"},"insert":" "},{"insert":"\n"}],"zoneId":"0","zoneType":"Z"},"2kBs0K0Zwr":{"ops":[{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"添加发布渠道之前，需要获取发布渠道的渠道 ID。\n"},{"attributes":{"list":"bullet2","lmkr":"1"},"insert":"*"},{"insert":"企业自定义渠道：在"},{"attributes":{"bold":"true"},"insert":"我的"},{"insert":"&gt;"},{"attributes":{"bold":"true"},"insert":"设置"},{"insert":"&gt;"},{"attributes":{"bold":"true"},"insert":"发布渠道"},{"insert":"&gt;"},{"attributes":{"bold":"true"},"insert":"我的渠道管理"},{"insert":"页面查看当前登录用户已创建的渠道列表，列表中可查看渠道 ID。企业自定义渠道入驻扣子编程的方式可参考"},{"insert":"渠道入驻","attributes":{"hyperlink":"{\"href\":\"https://docs.coze.cn/dev_how_to_guides/channel_integration_overview\",\"linkId\":\"Wg8SLot0ck\",\"newTab\":true}"}},{"insert":"文档。\n"},{"attributes":{"lmkr":"1","list":"bullet2"},"insert":"*"},{"insert":"公开渠道：联系公开平台的管理员获取渠道 ID。\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"扣子企业版（企业标准版、企业旗舰版）中，仅"},{"attributes":{"bold":"true"},"insert":"超级管理员和管理员"},{"insert":"能添加企业的公共渠道和自定义渠道，成员只能给个人空间添加公共渠道和自定义渠道。\n"}],"zoneId":"2kBs0K0Zwr","zoneType":"Z"}}
        /// </summary>
        /// <param name="connectorId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.OpenAPIInstallConnectorToWorkspaceResponse> OpenAPIInstallConnectorToWorkspaceAsync(
            string connectorId,

            global::G.OpenAPIInstallConnectorToWorkspaceRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareOpenAPIInstallConnectorToWorkspaceArguments(
                httpClient: HttpClient,
                connectorId: ref connectorId,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: $"/v1/connectors/{connectorId}/install",
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
            PrepareOpenAPIInstallConnectorToWorkspaceRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                connectorId: connectorId,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessOpenAPIInstallConnectorToWorkspaceResponse(
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
                ProcessOpenAPIInstallConnectorToWorkspaceResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.OpenAPIInstallConnectorToWorkspaceResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.OpenAPIInstallConnectorToWorkspaceResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// 添加发布渠道<br/>
        /// {"0":{"ops":[{"insert":"为指定空间添加一个发布渠道。\n"},{"attributes":{"anchor":"6989363f","heading":"h2","lmkr":"1"},"insert":"*"},{"insert":"接口说明\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"在扣子编程中发布智能体或应用时，可发布的渠道范围与工作空间有关。每个工作空间均配置了官方默认发布渠道，例如扣子商店、豆包、API 、SDK 等。除此之外，工作空间中还可以手动添加公共渠道和企业自定义渠道，按需拓展 AI 项目的分发渠道。添加渠道后，空间中的每个开发者都可以将自己的 AI 项目发布到这些渠道中。\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"attributes":{"zoneId":"2kBs0K0Zwr","zoneType":"Z","type":"tip","title":"说明","border":"#bacefd","background":"#f0f4ff","highlight-block-v2":"true"},"insert":" "},{"insert":"\n"}],"zoneId":"0","zoneType":"Z"},"2kBs0K0Zwr":{"ops":[{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"添加发布渠道之前，需要获取发布渠道的渠道 ID。\n"},{"attributes":{"list":"bullet2","lmkr":"1"},"insert":"*"},{"insert":"企业自定义渠道：在"},{"attributes":{"bold":"true"},"insert":"我的"},{"insert":"&gt;"},{"attributes":{"bold":"true"},"insert":"设置"},{"insert":"&gt;"},{"attributes":{"bold":"true"},"insert":"发布渠道"},{"insert":"&gt;"},{"attributes":{"bold":"true"},"insert":"我的渠道管理"},{"insert":"页面查看当前登录用户已创建的渠道列表，列表中可查看渠道 ID。企业自定义渠道入驻扣子编程的方式可参考"},{"insert":"渠道入驻","attributes":{"hyperlink":"{\"href\":\"https://docs.coze.cn/dev_how_to_guides/channel_integration_overview\",\"linkId\":\"Wg8SLot0ck\",\"newTab\":true}"}},{"insert":"文档。\n"},{"attributes":{"lmkr":"1","list":"bullet2"},"insert":"*"},{"insert":"公开渠道：联系公开平台的管理员获取渠道 ID。\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"扣子企业版（企业标准版、企业旗舰版）中，仅"},{"attributes":{"bold":"true"},"insert":"超级管理员和管理员"},{"insert":"能添加企业的公共渠道和自定义渠道，成员只能给个人空间添加公共渠道和自定义渠道。\n"}],"zoneId":"2kBs0K0Zwr","zoneType":"Z"}}
        /// </summary>
        /// <param name="connectorId"></param>
        /// <param name="workspaceId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.OpenAPIInstallConnectorToWorkspaceResponse> OpenAPIInstallConnectorToWorkspaceAsync(
            string connectorId,
            string workspaceId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.OpenAPIInstallConnectorToWorkspaceRequest
            {
                WorkspaceId = workspaceId,
            };

            return await OpenAPIInstallConnectorToWorkspaceAsync(
                connectorId: connectorId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}