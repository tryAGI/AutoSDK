//HintName: G.Api.OpenSwitchBotDevelopMode.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {


        private static readonly global::G.EndPointSecurityRequirement s_OpenSwitchBotDevelopModeSecurityRequirement0 =
            new global::G.EndPointSecurityRequirement
            {
                Authorizations = new global::G.EndPointAuthorizationRequirement[]
                {                    new global::G.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::G.EndPointSecurityRequirement[] s_OpenSwitchBotDevelopModeSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_OpenSwitchBotDevelopModeSecurityRequirement0,
            };
        partial void PrepareOpenSwitchBotDevelopModeArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string botId,
            global::G.OpenSwitchBotDevelopModeRequest request);
        partial void PrepareOpenSwitchBotDevelopModeRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string botId,
            global::G.OpenSwitchBotDevelopModeRequest request);
        partial void ProcessOpenSwitchBotDevelopModeResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessOpenSwitchBotDevelopModeResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// 开启或关闭智能体多人协作<br/>
        /// {"0":{"ops":[{"attributes":{"anchor":"7c953f3d","heading":" ","description":"文档标题","lmkr":"1"},"insert":"*"},{"insert":"开启或关闭智能体多人协作模式。\n"},{"attributes":{"lmkr":"1","description":"文档标题"},"insert":"*"},{"insert":"开启多人协作后，你才能调用"},{"attributes":{"hyperlink":"{\"href\":\"https://docs.coze.cn/developer_guides/add_bot_collaborator\",\"linkId\":\"MqdhrU6Xj0\"}"},"insert":"添加智能体的协作者"},{"insert":" API 为智能体添加协作者。\n"},{"attributes":{"anchor":"d8374fde","heading":"h2","lmkr":"1","description":"文档标题"},"insert":"*"},{"insert":"接口限制\n"},{"attributes":{"lmkr":"1","list":"bullet1","description":"文档标题"},"insert":"*"},{"attributes":{"bold":"true"},"insert":"套餐限制"},{"insert":"：扣子企业版（企业标准版、企业旗舰版）。\n"},{"attributes":{"lmkr":"1","list":"bullet1","description":"文档标题"},"insert":"*"},{"insert":"不支持渠道类型 OAuth 应用。使用 OAuth JWT 应用和服务访问令牌时，只需要有对应权限点即可。其余认证方式，只有"},{"attributes":{"bold":"true"},"insert":"智能体所有者"},{"insert":"能开启或关闭智能体的多人协作模式。\n"},{"attributes":{"lmkr":"1","list":"bullet1","description":"文档标题"},"insert":"*"},{"insert":"关闭智能体多人协作前，需要先调用"},{"attributes":{"hyperlink":"{\"href\":\"https://docs.coze.cn/developer_guides/remove_bot_collaborator\",\"linkId\":\"P95JGTCPGu\"}"},"insert":"删除智能体协作者"},{"insert":" API 删除所有协作者。\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="botId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.OpenSwitchBotDevelopModeResponse> OpenSwitchBotDevelopModeAsync(
            string botId,

            global::G.OpenSwitchBotDevelopModeRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareOpenSwitchBotDevelopModeArguments(
                httpClient: HttpClient,
                botId: ref botId,
                request: request);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_OpenSwitchBotDevelopModeSecurityRequirements,
                operationName: "OpenSwitchBotDevelopModeAsync");

            using var __timeoutCancellationTokenSource = global::G.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::G.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::G.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {
                            var __pathBuilder = new global::G.PathBuilder(
                                path: $"/v1/bots/{botId}/collaboration_mode",
                                baseUri: HttpClient.BaseAddress);
                            var __path = __pathBuilder.ToString();
                __path = global::G.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Post,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

                foreach (var __authorization in __authorizations)
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
                global::G.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareOpenSwitchBotDevelopModeRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    botId: botId,
                    request: request);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::G.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::G.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "OpenSwitchBotDevelopMode",
                                methodName: "OpenSwitchBotDevelopModeAsync",
                                pathTemplate: "$\"/v1/bots/{botId}/collaboration_mode\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::G.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::G.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "OpenSwitchBotDevelopMode",
                                methodName: "OpenSwitchBotDevelopModeAsync",
                                pathTemplate: "$\"/v1/bots/{botId}/collaboration_mode\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::G.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::G.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        await global::G.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::G.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "OpenSwitchBotDevelopMode",
                                methodName: "OpenSwitchBotDevelopModeAsync",
                                pathTemplate: "$\"/v1/bots/{botId}/collaboration_mode\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::G.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessOpenSwitchBotDevelopModeResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::G.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::G.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "OpenSwitchBotDevelopMode",
                                methodName: "OpenSwitchBotDevelopModeAsync",
                                pathTemplate: "$\"/v1/bots/{botId}/collaboration_mode\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::G.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::G.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "OpenSwitchBotDevelopMode",
                                methodName: "OpenSwitchBotDevelopModeAsync",
                                pathTemplate: "$\"/v1/bots/{botId}/collaboration_mode\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessResponseContent(
                                    client: HttpClient,
                                    response: __response,
                                    content: ref __content);
                                ProcessOpenSwitchBotDevelopModeResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    return
                                        global::G.OpenSwitchBotDevelopModeResponse.FromJson(__content, JsonSerializerOptions) ??
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
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    return
                                        await global::G.OpenSwitchBotDevelopModeResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                }
                                catch (global::System.Exception __ex)
                                {
                                    string? __content = null;
                                    try
                                    {
                                        __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                            __effectiveCancellationToken
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
            finally
            {
                __httpRequest?.Dispose();
            }
        }
        /// <summary>
        /// 开启或关闭智能体多人协作<br/>
        /// {"0":{"ops":[{"attributes":{"anchor":"7c953f3d","heading":" ","description":"文档标题","lmkr":"1"},"insert":"*"},{"insert":"开启或关闭智能体多人协作模式。\n"},{"attributes":{"lmkr":"1","description":"文档标题"},"insert":"*"},{"insert":"开启多人协作后，你才能调用"},{"attributes":{"hyperlink":"{\"href\":\"https://docs.coze.cn/developer_guides/add_bot_collaborator\",\"linkId\":\"MqdhrU6Xj0\"}"},"insert":"添加智能体的协作者"},{"insert":" API 为智能体添加协作者。\n"},{"attributes":{"anchor":"d8374fde","heading":"h2","lmkr":"1","description":"文档标题"},"insert":"*"},{"insert":"接口限制\n"},{"attributes":{"lmkr":"1","list":"bullet1","description":"文档标题"},"insert":"*"},{"attributes":{"bold":"true"},"insert":"套餐限制"},{"insert":"：扣子企业版（企业标准版、企业旗舰版）。\n"},{"attributes":{"lmkr":"1","list":"bullet1","description":"文档标题"},"insert":"*"},{"insert":"不支持渠道类型 OAuth 应用。使用 OAuth JWT 应用和服务访问令牌时，只需要有对应权限点即可。其余认证方式，只有"},{"attributes":{"bold":"true"},"insert":"智能体所有者"},{"insert":"能开启或关闭智能体的多人协作模式。\n"},{"attributes":{"lmkr":"1","list":"bullet1","description":"文档标题"},"insert":"*"},{"insert":"关闭智能体多人协作前，需要先调用"},{"attributes":{"hyperlink":"{\"href\":\"https://docs.coze.cn/developer_guides/remove_bot_collaborator\",\"linkId\":\"P95JGTCPGu\"}"},"insert":"删除智能体协作者"},{"insert":" API 删除所有协作者。\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="botId"></param>
        /// <param name="collaborationMode"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.OpenSwitchBotDevelopModeResponse> OpenSwitchBotDevelopModeAsync(
            string botId,
            global::G.OpenSwitchBotDevelopModeRequestCollaborationMode? collaborationMode = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.OpenSwitchBotDevelopModeRequest
            {
                CollaborationMode = collaborationMode,
            };

            return await OpenSwitchBotDevelopModeAsync(
                botId: botId,
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}