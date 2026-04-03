//HintName: G.Api.OpenAPIAddBotCollaborator.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        partial void PrepareOpenAPIAddBotCollaboratorArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string botId,
            global::G.OpenAPIAddBotCollaboratorRequest request);
        partial void PrepareOpenAPIAddBotCollaboratorRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string botId,
            global::G.OpenAPIAddBotCollaboratorRequest request);
        partial void ProcessOpenAPIAddBotCollaboratorResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessOpenAPIAddBotCollaboratorResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// 添加智能体协作者<br/>
        /// {"0":{"ops":[{"insert":"添加智能体的协作者。\n"},{"attributes":{"anchor":"2765f7bd","heading":"h2","lmkr":"1"},"insert":"*"},{"insert":"接口限制\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"套餐限制：扣子企业版（企业标准版、企业旗舰版）。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"每次请求只能添加一位协作者。如需添加多位，请依次发送请求。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"协作者只能是该工作空间的成员。\n"},{"attributes":{"lmkr":"1","list":"bullet1","description":"文档标题"},"insert":"*"},{"insert":"不支持渠道类型 OAuth 应用。使用 OAuth JWT 应用和服务访问令牌时，只需要有对应权限点即可。其余认证方式，只有"},{"attributes":{"bold":"true"},"insert":"智能体的所有者和协作者"},{"insert":"能添加协作者。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"主账号内的所有子账号共享同一 API 的流控额度，单个 API 的流控限制为 5 QPS。\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="botId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.OpenAPIAddBotCollaboratorResponse> OpenAPIAddBotCollaboratorAsync(
            string botId,

            global::G.OpenAPIAddBotCollaboratorRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareOpenAPIAddBotCollaboratorArguments(
                httpClient: HttpClient,
                botId: ref botId,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: $"/v1/bots/{botId}/collaborators",
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
            PrepareOpenAPIAddBotCollaboratorRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                botId: botId,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessOpenAPIAddBotCollaboratorResponse(
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
                ProcessOpenAPIAddBotCollaboratorResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.OpenAPIAddBotCollaboratorResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.OpenAPIAddBotCollaboratorResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// 添加智能体协作者<br/>
        /// {"0":{"ops":[{"insert":"添加智能体的协作者。\n"},{"attributes":{"anchor":"2765f7bd","heading":"h2","lmkr":"1"},"insert":"*"},{"insert":"接口限制\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"套餐限制：扣子企业版（企业标准版、企业旗舰版）。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"每次请求只能添加一位协作者。如需添加多位，请依次发送请求。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"协作者只能是该工作空间的成员。\n"},{"attributes":{"lmkr":"1","list":"bullet1","description":"文档标题"},"insert":"*"},{"insert":"不支持渠道类型 OAuth 应用。使用 OAuth JWT 应用和服务访问令牌时，只需要有对应权限点即可。其余认证方式，只有"},{"attributes":{"bold":"true"},"insert":"智能体的所有者和协作者"},{"insert":"能添加协作者。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"主账号内的所有子账号共享同一 API 的流控额度，单个 API 的流控限制为 5 QPS。\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="botId"></param>
        /// <param name="collaborators"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.OpenAPIAddBotCollaboratorResponse> OpenAPIAddBotCollaboratorAsync(
            string botId,
            global::System.Collections.Generic.IList<global::G.PropertiesCollaboratorsItems> collaborators,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.OpenAPIAddBotCollaboratorRequest
            {
                Collaborators = collaborators,
            };

            return await OpenAPIAddBotCollaboratorAsync(
                botId: botId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}