//HintName: G.Api.CreateApiAppOpen.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {


        private static readonly global::G.EndPointSecurityRequirement s_CreateApiAppOpenSecurityRequirement0 =
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
        private static readonly global::G.EndPointSecurityRequirement[] s_CreateApiAppOpenSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_CreateApiAppOpenSecurityRequirement0,
            };
        partial void PrepareCreateApiAppOpenArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.CreateApiAppOpenRequest request);
        partial void PrepareCreateApiAppOpenRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.CreateApiAppOpenRequest request);
        partial void ProcessCreateApiAppOpenResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateApiAppOpenResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// 创建回调应用<br/>
        /// {"0":{"ops":[{"insert":"本 API 用于创建回调应用，支持创建普通回调应用和渠道回调应用。订阅扣子编程回调功能时需要创建回调应用。\n"},{"attributes":{"anchor":"c9eedd03","lmkr":"1","heading":"h2"},"insert":"*"},{"insert":"接口说明\n"},{"attributes":{"hyperlink":"{\"href\":\"https://docs.coze.cn/dev_how_to_guides/add_callback\",\"linkId\":\"UX5fAx4fb2\",\"newTab\":true}"},"insert":"订阅回调"},{"insert":"功能支持开发者通过配置回调应用实时获取扣子编程的事件通知。当"},{"attributes":{"bold":"true"},"insert":"智能体发布"},{"insert":"、"},{"attributes":{"bold":"true"},"insert":"智能体删除"},{"insert":"、"},{"attributes":{"bold":"true"},"insert":"账单生成"},{"insert":"等关键业务事件被触发时，扣子编程将向开发者指定的服务器地址发送回调消息。\n"},{"attributes":{"lmkr":"1","text-indent":"true"},"insert":"*"},{"insert":"回调分为普通回调和渠道回调，具体说明如下：\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"普通回调应用：开发者在扣子编程中创建回调应用，用于接收扣子编程触发的事件通知。当订阅的事件被触发时，扣子编程会向该回调地址推送回调消息。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"渠道回调应用：当渠道入驻扣子编程后，开发者可以在该渠道中创建回调应用，用于接收该渠道中触发的事件通知。当订阅的事件被触发时，扣子编程会向渠道指定的回调地址推送回调消息。\n"},{"attributes":{"anchor":"9d5a797a","heading":"h2","lmkr":"1"},"insert":"*"},{"insert":"接口限制\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"扣子个人版中，任何用户均可以创建普通回调应用。仅渠道创建者支持创建对应渠道的回调应用，统一接收该渠道中的回调消息。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"扣子企业版（企业标准版、企业旗舰版）中，仅超级管理员和管理员可创建回调应用。\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CreateApiAppOpenResponse> CreateApiAppOpenAsync(

            global::G.CreateApiAppOpenRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateApiAppOpenArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CreateApiAppOpenSecurityRequirements,
                operationName: "CreateApiAppOpenAsync");

            var __pathBuilder = new global::G.PathBuilder(
                path: "/v1/api_apps",
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
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareCreateApiAppOpenRequest(
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
            ProcessCreateApiAppOpenResponse(
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
                ProcessCreateApiAppOpenResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.CreateApiAppOpenResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.CreateApiAppOpenResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// 创建回调应用<br/>
        /// {"0":{"ops":[{"insert":"本 API 用于创建回调应用，支持创建普通回调应用和渠道回调应用。订阅扣子编程回调功能时需要创建回调应用。\n"},{"attributes":{"anchor":"c9eedd03","lmkr":"1","heading":"h2"},"insert":"*"},{"insert":"接口说明\n"},{"attributes":{"hyperlink":"{\"href\":\"https://docs.coze.cn/dev_how_to_guides/add_callback\",\"linkId\":\"UX5fAx4fb2\",\"newTab\":true}"},"insert":"订阅回调"},{"insert":"功能支持开发者通过配置回调应用实时获取扣子编程的事件通知。当"},{"attributes":{"bold":"true"},"insert":"智能体发布"},{"insert":"、"},{"attributes":{"bold":"true"},"insert":"智能体删除"},{"insert":"、"},{"attributes":{"bold":"true"},"insert":"账单生成"},{"insert":"等关键业务事件被触发时，扣子编程将向开发者指定的服务器地址发送回调消息。\n"},{"attributes":{"lmkr":"1","text-indent":"true"},"insert":"*"},{"insert":"回调分为普通回调和渠道回调，具体说明如下：\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"普通回调应用：开发者在扣子编程中创建回调应用，用于接收扣子编程触发的事件通知。当订阅的事件被触发时，扣子编程会向该回调地址推送回调消息。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"渠道回调应用：当渠道入驻扣子编程后，开发者可以在该渠道中创建回调应用，用于接收该渠道中触发的事件通知。当订阅的事件被触发时，扣子编程会向渠道指定的回调地址推送回调消息。\n"},{"attributes":{"anchor":"9d5a797a","heading":"h2","lmkr":"1"},"insert":"*"},{"insert":"接口限制\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"扣子个人版中，任何用户均可以创建普通回调应用。仅渠道创建者支持创建对应渠道的回调应用，统一接收该渠道中的回调消息。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"扣子企业版（企业标准版、企业旗舰版）中，仅超级管理员和管理员可创建回调应用。\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="appType">
        /// 必填
        /// </param>
        /// <param name="connectorId">
        /// app_type=connector 时必传
        /// </param>
        /// <param name="name">
        /// 回调应用的名称， app_type=normal 时必传
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CreateApiAppOpenResponse> CreateApiAppOpenAsync(
            global::G.CreateApiAppOpenRequestAppType appType,
            string? connectorId = default,
            string? name = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.CreateApiAppOpenRequest
            {
                AppType = appType,
                ConnectorId = connectorId,
                Name = name,
            };

            return await CreateApiAppOpenAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}