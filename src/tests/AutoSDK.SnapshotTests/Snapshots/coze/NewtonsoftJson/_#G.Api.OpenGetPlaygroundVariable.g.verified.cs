//HintName: G.Api.OpenGetPlaygroundVariable.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {


        private static readonly global::G.EndPointSecurityRequirement s_OpenGetPlaygroundVariableSecurityRequirement0 =
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
        private static readonly global::G.EndPointSecurityRequirement[] s_OpenGetPlaygroundVariableSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_OpenGetPlaygroundVariableSecurityRequirement0,
            };
        partial void PrepareOpenGetPlaygroundVariableArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? appId,
            ref string? botId,
            ref string? connectorId,
            ref string connectorUid,
            global::System.Collections.Generic.IList<string>? keywords);
        partial void PrepareOpenGetPlaygroundVariableRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? appId,
            string? botId,
            string? connectorId,
            string connectorUid,
            global::System.Collections.Generic.IList<string>? keywords);
        partial void ProcessOpenGetPlaygroundVariableResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessOpenGetPlaygroundVariableResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// 获取用户变量的值<br/>
        /// {"0":{"ops":[{"insert":"获取智能体或应用中设置的用户变量的值。\n"},{"attributes":{"heading":"h2","anchor":"08a607b1","lmkr":"1"},"insert":"*"},{"insert":"接口说明\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"通过"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/developer_guides/update_variable\",\"linkId\":\"cRHJlC3KHj\",\"newTab\":true}"},"insert":"设置用户变量的值"},{"insert":" API 设置变量值之后，可以通过本 API 查看智能体或应用中设置的用户变量的值。调用此 API 时可以查看指定变量的值，也可以将 "},{"attributes":{"inlineCode":"true"},"insert":"keywords"},{"insert":" 指定为空，查看智能体或应用下的所有用户变量的值。如果输入的 "},{"attributes":{"inlineCode":"true"},"insert":"keywords"},{"insert":" 在智能体或应用中不存在，扣子不会报错，但返回结果中不会包含相应的用户变量。\n"},{"attributes":{"heading":"h2","anchor":"c461112a","lmkr":"1"},"insert":"*"},{"insert":"限制说明\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"仅支持获取已发布 API、ChatSDK 的智能体或应用中的用户变量的值。\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"用户变量按照 "},{"attributes":{"inlineCode":"true"},"insert":"user_id"},{"insert":" + "},{"attributes":{"inlineCode":"true"},"insert":"connector_uid"},{"insert":" + "},{"attributes":{"inlineCode":"true"},"insert":"connector_id"},{"insert":" + "},{"attributes":{"inlineCode":"true"},"insert":"bot_id"},{"insert":" 的组合进行隔离，因此在扣子开发平台站内设置的用户变量，在 API 渠道可能无法获取对应的值。不同渠道用户标识的规则存在差异，具体如下表所示。\n"},{"attributes":{"aceTable":"JSRk1iQ4lsd14FX4DayBmMRX5IYGhdx6 dAVpXnQztjlMUNLMwsdyczQXcTdnYzZg"},"insert":"*"},{"insert":"\n"}],"zoneId":"0","zoneType":"Z"},"JSRk1iQ4lsd14FX4DayBmMRX5IYGhdx6":{"ops":[{"insert":{"id":"r18374z0rpejuhgy3wyq1ulruus9hpj5rt"}},{"insert":{"id":"r1vnd9b7t8obnbrqn46u1fdo02mwduvjog"}},{"insert":{"id":"r1ksv702wjjvruhqdf3jtm0ffhddbfvl4y"}}],"zoneId":"JSRk1iQ4lsd14FX4DayBmMRX5IYGhdx6","zoneType":"R"},"dAVpXnQztjlMUNLMwsdyczQXcTdnYzZg":{"ops":[{"attributes":{"colWidth":"139"},"insert":{"id":"c1aoarz60p9obmnd2ludn12bn2k8s38el1"}},{"attributes":{"colWidth":"228"},"insert":{"id":"c1f7lnsay0j6fivdnmyd351pua2gzh50t1"}},{"insert":{"id":"c1t2barrwv58q7jquiutdy096tr2qsaokm"},"attributes":{"colWidth":"386"}}],"zoneId":"dAVpXnQztjlMUNLMwsdyczQXcTdnYzZg","zoneType":"C"},"xr18374z0rpejuhgy3wyq1ulruus9hpj5rtxc1aoarz60p9obmnd2ludn12bn2k8s38el1":{"ops":[{"attributes":{"bold":"true"},"insert":"参数"},{"insert":"\n"}],"zoneId":"xr18374z0rpejuhgy3wyq1ulruus9hpj5rtxc1aoarz60p9obmnd2ludn12bn2k8s38el1","zoneType":"Z"},"xr18374z0rpejuhgy3wyq1ulruus9hpj5rtxc1f7lnsay0j6fivdnmyd351pua2gzh50t1":{"ops":[{"attributes":{"bold":"true"},"insert":"扣子开发平台站内"},{"insert":"\n"}],"zoneId":"xr18374z0rpejuhgy3wyq1ulruus9hpj5rtxc1f7lnsay0j6fivdnmyd351pua2gzh50t1","zoneType":"Z"},"xr18374z0rpejuhgy3wyq1ulruus9hpj5rtxc1t2barrwv58q7jquiutdy096tr2qsaokm":{"ops":[{"attributes":{"bold":"true"},"insert":"API 渠道"},{"insert":"\n"}],"zoneId":"xr18374z0rpejuhgy3wyq1ulruus9hpj5rtxc1t2barrwv58q7jquiutdy096tr2qsaokm","zoneType":"Z"},"xr1vnd9b7t8obnbrqn46u1fdo02mwduvjogxc1aoarz60p9obmnd2ludn12bn2k8s38el1":{"ops":[{"attributes":{"inlineCode":"true"},"insert":"user_id "},{"insert":"\n"}],"zoneId":"xr1vnd9b7t8obnbrqn46u1fdo02mwduvjogxc1aoarz60p9obmnd2ludn12bn2k8s38el1","zoneType":"Z"},"xr1vnd9b7t8obnbrqn46u1fdo02mwduvjogxc1f7lnsay0j6fivdnmyd351pua2gzh50t1":{"ops":[{"attributes":{"lmkr":"1","align":"left"},"insert":"*"},{"insert":"当前使用者的扣子用户 ID。\n"}],"zoneId":"xr1vnd9b7t8obnbrqn46u1fdo02mwduvjogxc1f7lnsay0j6fivdnmyd351pua2gzh50t1","zoneType":"Z"},"xr1vnd9b7t8obnbrqn46u1fdo02mwduvjogxc1t2barrwv58q7jquiutdy096tr2qsaokm":{"ops":[{"insert":"API Token 生成者的 ID。\n"}],"zoneId":"xr1vnd9b7t8obnbrqn46u1fdo02mwduvjogxc1t2barrwv58q7jquiutdy096tr2qsaokm","zoneType":"Z"},"xr1ksv702wjjvruhqdf3jtm0ffhddbfvl4yxc1aoarz60p9obmnd2ludn12bn2k8s38el1":{"ops":[{"attributes":{"inlineCode":"true"},"insert":"connector_uid"},{"insert":"\n"}],"zoneId":"xr1ksv702wjjvruhqdf3jtm0ffhddbfvl4yxc1aoarz60p9obmnd2ludn12bn2k8s38el1","zoneType":"Z"},"xr1ksv702wjjvruhqdf3jtm0ffhddbfvl4yxc1f7lnsay0j6fivdnmyd351pua2gzh50t1":{"ops":[{"attributes":{"lmkr":"1","align":"left"},"insert":"*"},{"insert":"当前使用者的扣子用户 ID。\n"}],"zoneId":"xr1ksv702wjjvruhqdf3jtm0ffhddbfvl4yxc1f7lnsay0j6fivdnmyd351pua2gzh50t1","zoneType":"Z"},"xr1ksv702wjjvruhqdf3jtm0ffhddbfvl4yxc1t2barrwv58q7jquiutdy096tr2qsaokm":{"ops":[{"insert":"用户在"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/developer_guides/chat_v3\",\"linkId\":\"pvPe7TWbiT\"}"},"insert":"发起对话"},{"insert":" 等 API 中输入的 "},{"attributes":{"inlineCode":"true"},"insert":"user_id"},{"insert":"。\n"}],"zoneId":"xr1ksv702wjjvruhqdf3jtm0ffhddbfvl4yxc1t2barrwv58q7jquiutdy096tr2qsaokm","zoneType":"Z"}}
        /// </summary>
        /// <param name="appId"></param>
        /// <param name="botId"></param>
        /// <param name="connectorId"></param>
        /// <param name="connectorUid"></param>
        /// <param name="keywords"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.OpenGetPlaygroundVariableResponse> OpenGetPlaygroundVariableAsync(
            string connectorUid,
            string? appId = default,
            string? botId = default,
            string? connectorId = default,
            global::System.Collections.Generic.IList<string>? keywords = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareOpenGetPlaygroundVariableArguments(
                httpClient: HttpClient,
                appId: ref appId,
                botId: ref botId,
                connectorId: ref connectorId,
                connectorUid: ref connectorUid,
                keywords: keywords);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_OpenGetPlaygroundVariableSecurityRequirements,
                operationName: "OpenGetPlaygroundVariableAsync");

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
                                path: "/v1/variables",
                                baseUri: HttpClient.BaseAddress); 
                            __pathBuilder
                                .AddOptionalParameter("app_id", appId)
                                .AddOptionalParameter("bot_id", botId)
                                .AddOptionalParameter("connector_id", connectorId)
                                .AddRequiredParameter("connector_uid", connectorUid)
                                .AddOptionalParameter("keywords", keywords, delimiter: ",", explode: true) 
                                ;
                            var __path = __pathBuilder.ToString();
                __path = global::G.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Get,
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
                global::G.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareOpenGetPlaygroundVariableRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    appId: appId,
                    botId: botId,
                    connectorId: connectorId,
                    connectorUid: connectorUid,
                    keywords: keywords);

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
                                operationId: "OpenGetPlaygroundVariable",
                                methodName: "OpenGetPlaygroundVariableAsync",
                                pathTemplate: "\"/v1/variables\"",
                                httpMethod: "GET",
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
                                operationId: "OpenGetPlaygroundVariable",
                                methodName: "OpenGetPlaygroundVariableAsync",
                                pathTemplate: "\"/v1/variables\"",
                                httpMethod: "GET",
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
                                operationId: "OpenGetPlaygroundVariable",
                                methodName: "OpenGetPlaygroundVariableAsync",
                                pathTemplate: "\"/v1/variables\"",
                                httpMethod: "GET",
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
                ProcessOpenGetPlaygroundVariableResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::G.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::G.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "OpenGetPlaygroundVariable",
                                methodName: "OpenGetPlaygroundVariableAsync",
                                pathTemplate: "\"/v1/variables\"",
                                httpMethod: "GET",
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
                                operationId: "OpenGetPlaygroundVariable",
                                methodName: "OpenGetPlaygroundVariableAsync",
                                pathTemplate: "\"/v1/variables\"",
                                httpMethod: "GET",
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
                                ProcessOpenGetPlaygroundVariableResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    return
                                        global::G.OpenGetPlaygroundVariableResponse.FromJson(__content, JsonSerializerOptions) ??
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
                                        await global::G.OpenGetPlaygroundVariableResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
    }
}