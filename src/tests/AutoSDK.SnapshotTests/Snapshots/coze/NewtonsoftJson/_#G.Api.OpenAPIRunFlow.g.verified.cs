//HintName: G.Api.OpenAPIRunFlow.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {


        private static readonly global::G.EndPointSecurityRequirement s_OpenAPIRunFlowSecurityRequirement0 =
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
        private static readonly global::G.EndPointSecurityRequirement[] s_OpenAPIRunFlowSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_OpenAPIRunFlowSecurityRequirement0,
            };
        partial void PrepareOpenAPIRunFlowArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.OpenAPIRunFlowRequest request);
        partial void PrepareOpenAPIRunFlowRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.OpenAPIRunFlowRequest request);
        partial void ProcessOpenAPIRunFlowResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessOpenAPIRunFlowResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// 执行工作流<br/>
        /// {"0":{"ops":[{"insert":"执行已发布的工作流。\n"},{"attributes":{"anchor":"4dd46fdd","lmkr":"1","heading":"h2"},"insert":"*"},{"insert":"接口说明\n"},{"insert":"此接口为非流式响应模式，如果需要采用流式输出，请参考"},{"attributes":{"hyperlink":"{\"href\":\"https://docs.coze.cn/developer_guides/workflow_stream_run\",\"linkId\":\"I5nX7TTfLz\",\"newTab\":true}"},"insert":"执行工作流（流式响应）"},{"insert":"。\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"调用此接口后，你可以从响应中获得 debug_url，访问链接即可通过可视化界面查看工作流的试运行过程，其中包含每个执行节点的输入输出等详细信息，帮助你在线调试或排障。\n"},{"insert":"扣子个人付费版、企业版（企业标准版、企业旗舰版）用户调用此接口时，支持通过 "},{"insert":"is_async","attributes":{"inlineCode":"true"}},{"insert":" 参数异步运行工作流，适用于工作流执行耗时较长，导致运行超时的情况。异步运行后可通过本接口返回的 execute_id 调用"},{"attributes":{"hyperlink":"{\"href\":\"https://docs.coze.cn/developer_guides/workflow_history\",\"linkId\":\"S0HYtlEwV6\",\"newTab\":true}"},"insert":"查询工作流异步执行结果"},{"insert":" API 获取工作流的执行结果。\n"},{"attributes":{"anchor":"02cfdb8f","heading":"h2","lmkr":"1"},"insert":"*"},{"insert":"限制说明\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"attributes":{"zoneId":"MtZgJP45vB","zoneType":"Z","type":"tip","title":"说明","border":"#bacefd","background":"#f0f4ff","highlight-block-v2":"true"},"insert":" "},{"insert":"\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"attributes":{"aceTable":"rsqes1vmglpn0yt3z8kprejbrljsfp7m7v cs4tir7rhc4fsk4q8kkn891v5cvcln6s05"},"insert":"*"},{"insert":"\n"},{"insert":"\n"}],"zoneId":"0","zoneType":"Z"},"MtZgJP45vB":{"ops":[{"insert":"调用此非流式响应 API 时，若 API 在 90 秒内未收到响应，将因超时而断开连接。对于执行耗时较长的工作流，建议使用"},{"attributes":{"hyperlink":"{\"href\":\"https://docs.coze.cn/developer_guides/workflow_stream_run\",\"linkId\":\"ByHPKROgup\",\"newTab\":true}"},"insert":"执行工作流（流式响应）"},{"insert":"API。\n"}],"zoneId":"MtZgJP45vB","zoneType":"Z"},"rsqes1vmglpn0yt3z8kprejbrljsfp7m7v":{"ops":[{"attributes":{"rowHeight":"27","colWidth":"100"},"insert":{"id":"r1a3vc7vhvf3hvmowetchhcmemv32o4e2u"}},{"attributes":{"rowHeight":"27","colWidth":"100"},"insert":{"id":"r1fkgo0e001oonugnpyzagwdcawt7p139j"}},{"attributes":{},"insert":{"id":"r1kzjna5g2fktqiewegmdob75au7iv2b11"}},{"attributes":{"rowHeight":"27"},"insert":{"id":"r158knzgq3j55d41sgqzad4eh2kykvqf97"}},{"attributes":{"rowHeight":"27"},"insert":{"id":"r1k6bo7rgnj7pjbopqfeljp0athb1zf9zg"}},{"attributes":{"rowHeight":"27"},"insert":{"id":"r1sqoklhkk00w1dcpn6egwi6m21d55t8av"}}],"zoneId":"rsqes1vmglpn0yt3z8kprejbrljsfp7m7v","zoneType":"R"},"cs4tir7rhc4fsk4q8kkn891v5cvcln6s05":{"ops":[{"attributes":{"colWidth":"172"},"insert":{"id":"c134hmy43lgoyn7y3bsh9lc02afo0rrgss"}},{"attributes":{"colWidth":"681"},"insert":{"id":"c10poacggkd53uona2vukohpamlivonhnb"}}],"zoneId":"cs4tir7rhc4fsk4q8kkn891v5cvcln6s05","zoneType":"C"},"xr1a3vc7vhvf3hvmowetchhcmemv32o4e2uxc134hmy43lgoyn7y3bsh9lc02afo0rrgss":{"ops":[{"attributes":{"bold":"true"},"insert":"限制项"},{"insert":"\n"}],"zoneId":"xr1a3vc7vhvf3hvmowetchhcmemv32o4e2uxc134hmy43lgoyn7y3bsh9lc02afo0rrgss","zoneType":"Z"},"xr1a3vc7vhvf3hvmowetchhcmemv32o4e2uxc10poacggkd53uona2vukohpamlivonhnb":{"ops":[{"attributes":{"bold":"true"},"insert":"说明"},{"insert":"\n"}],"zoneId":"xr1a3vc7vhvf3hvmowetchhcmemv32o4e2uxc10poacggkd53uona2vukohpamlivonhnb","zoneType":"Z"},"xr1fkgo0e001oonugnpyzagwdcawt7p139jxc134hmy43lgoyn7y3bsh9lc02afo0rrgss":{"ops":[{"insert":"工作流发布状态\n"}],"zoneId":"xr1fkgo0e001oonugnpyzagwdcawt7p139jxc134hmy43lgoyn7y3bsh9lc02afo0rrgss","zoneType":"Z"},"xr1fkgo0e001oonugnpyzagwdcawt7p139jxc10poacggkd53uona2vukohpamlivonhnb":{"ops":[{"insert":" 必须为已发布。执行未发布的工作流会返回错误码 4200。 创建并发布工作流的操作可参考"},{"attributes":{"hyperlink":"{\"href\":\"https://docs.coze.cn/guides/use_workflow\",\"linkId\":\"gL9bvuYOgt\",\"newTab\":true}"},"insert":"使用工作流"},{"insert":"。\n"}],"zoneId":"xr1fkgo0e001oonugnpyzagwdcawt7p139jxc10poacggkd53uona2vukohpamlivonhnb","zoneType":"Z"},"xr1kzjna5g2fktqiewegmdob75au7iv2b11xc134hmy43lgoyn7y3bsh9lc02afo0rrgss":{"ops":[{"insert":"节点限制\n"}],"zoneId":"xr1kzjna5g2fktqiewegmdob75au7iv2b11xc134hmy43lgoyn7y3bsh9lc02afo0rrgss","zoneType":"Z"},"xr1kzjna5g2fktqiewegmdob75au7iv2b11xc10poacggkd53uona2vukohpamlivonhnb":{"ops":[{"insert":"工作流中不能包含输出节点、开启了流式输出的结束节点。\n"}],"zoneId":"xr1kzjna5g2fktqiewegmdob75au7iv2b11xc10poacggkd53uona2vukohpamlivonhnb","zoneType":"Z"},"xr158knzgq3j55d41sgqzad4eh2kykvqf97xc134hmy43lgoyn7y3bsh9lc02afo0rrgss":{"ops":[{"insert":"关联智能体\n"}],"zoneId":"xr158knzgq3j55d41sgqzad4eh2kykvqf97xc134hmy43lgoyn7y3bsh9lc02afo0rrgss","zoneType":"Z"},"xr158knzgq3j55d41sgqzad4eh2kykvqf97xc10poacggkd53uona2vukohpamlivonhnb":{"ops":[{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"调用此 API 之前，应先在扣子平台中试运行此工作流，如果试运行时需要关联智能体，则调用此 API 执行工作流时，也需要指定智能体ID。通常情况下，执行存在数据库节点、变量节点等节点的工作流需要关联智能体。\n"}],"zoneId":"xr158knzgq3j55d41sgqzad4eh2kykvqf97xc10poacggkd53uona2vukohpamlivonhnb","zoneType":"Z"},"xr1k6bo7rgnj7pjbopqfeljp0athb1zf9zgxc134hmy43lgoyn7y3bsh9lc02afo0rrgss":{"ops":[{"insert":"请求大小上限\n"}],"zoneId":"xr1k6bo7rgnj7pjbopqfeljp0athb1zf9zgxc134hmy43lgoyn7y3bsh9lc02afo0rrgss","zoneType":"Z"},"xr1k6bo7rgnj7pjbopqfeljp0athb1zf9zgxc10poacggkd53uona2vukohpamlivonhnb":{"ops":[{"insert":" 20 MB，包括输入参数及运行期间产生的消息历史等所有相关数据。 \n"}],"zoneId":"xr1k6bo7rgnj7pjbopqfeljp0athb1zf9zgxc10poacggkd53uona2vukohpamlivonhnb","zoneType":"Z"},"xr1sqoklhkk00w1dcpn6egwi6m21d55t8avxc134hmy43lgoyn7y3bsh9lc02afo0rrgss":{"ops":[{"insert":"超时时间 \n"}],"zoneId":"xr1sqoklhkk00w1dcpn6egwi6m21d55t8avxc134hmy43lgoyn7y3bsh9lc02afo0rrgss","zoneType":"Z"},"xr1sqoklhkk00w1dcpn6egwi6m21d55t8avxc10poacggkd53uona2vukohpamlivonhnb":{"ops":[{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"未开启工作流异步运行时，工作流整体超时时间为 10 分钟，建议执行时间控制在 5 分钟以内，否则不保障执行结果的准确性。 详细说明可参考"},{"attributes":{"hyperlink":"{\"href\":\"https://docs.coze.cn/guides/workflow_limits\",\"linkId\":\"c5SNHKSLeE\",\"newTab\":true}"},"insert":"工作流使用限制"},{"insert":"。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"开启工作流异步运行后，工作流整体超时时间为 24 小时。\n"}],"zoneId":"xr1sqoklhkk00w1dcpn6egwi6m21d55t8avxc10poacggkd53uona2vukohpamlivonhnb","zoneType":"Z"}}
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.OpenAPIRunFlowResponse> OpenAPIRunFlowAsync(

            global::G.OpenAPIRunFlowRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareOpenAPIRunFlowArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_OpenAPIRunFlowSecurityRequirements,
                operationName: "OpenAPIRunFlowAsync");

            var __pathBuilder = new global::G.PathBuilder(
                path: "/v1/workflow/run",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
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

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareOpenAPIRunFlowRequest(
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
            ProcessOpenAPIRunFlowResponse(
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
                ProcessOpenAPIRunFlowResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.OpenAPIRunFlowResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.OpenAPIRunFlowResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// 执行工作流<br/>
        /// {"0":{"ops":[{"insert":"执行已发布的工作流。\n"},{"attributes":{"anchor":"4dd46fdd","lmkr":"1","heading":"h2"},"insert":"*"},{"insert":"接口说明\n"},{"insert":"此接口为非流式响应模式，如果需要采用流式输出，请参考"},{"attributes":{"hyperlink":"{\"href\":\"https://docs.coze.cn/developer_guides/workflow_stream_run\",\"linkId\":\"I5nX7TTfLz\",\"newTab\":true}"},"insert":"执行工作流（流式响应）"},{"insert":"。\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"调用此接口后，你可以从响应中获得 debug_url，访问链接即可通过可视化界面查看工作流的试运行过程，其中包含每个执行节点的输入输出等详细信息，帮助你在线调试或排障。\n"},{"insert":"扣子个人付费版、企业版（企业标准版、企业旗舰版）用户调用此接口时，支持通过 "},{"insert":"is_async","attributes":{"inlineCode":"true"}},{"insert":" 参数异步运行工作流，适用于工作流执行耗时较长，导致运行超时的情况。异步运行后可通过本接口返回的 execute_id 调用"},{"attributes":{"hyperlink":"{\"href\":\"https://docs.coze.cn/developer_guides/workflow_history\",\"linkId\":\"S0HYtlEwV6\",\"newTab\":true}"},"insert":"查询工作流异步执行结果"},{"insert":" API 获取工作流的执行结果。\n"},{"attributes":{"anchor":"02cfdb8f","heading":"h2","lmkr":"1"},"insert":"*"},{"insert":"限制说明\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"attributes":{"zoneId":"MtZgJP45vB","zoneType":"Z","type":"tip","title":"说明","border":"#bacefd","background":"#f0f4ff","highlight-block-v2":"true"},"insert":" "},{"insert":"\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"attributes":{"aceTable":"rsqes1vmglpn0yt3z8kprejbrljsfp7m7v cs4tir7rhc4fsk4q8kkn891v5cvcln6s05"},"insert":"*"},{"insert":"\n"},{"insert":"\n"}],"zoneId":"0","zoneType":"Z"},"MtZgJP45vB":{"ops":[{"insert":"调用此非流式响应 API 时，若 API 在 90 秒内未收到响应，将因超时而断开连接。对于执行耗时较长的工作流，建议使用"},{"attributes":{"hyperlink":"{\"href\":\"https://docs.coze.cn/developer_guides/workflow_stream_run\",\"linkId\":\"ByHPKROgup\",\"newTab\":true}"},"insert":"执行工作流（流式响应）"},{"insert":"API。\n"}],"zoneId":"MtZgJP45vB","zoneType":"Z"},"rsqes1vmglpn0yt3z8kprejbrljsfp7m7v":{"ops":[{"attributes":{"rowHeight":"27","colWidth":"100"},"insert":{"id":"r1a3vc7vhvf3hvmowetchhcmemv32o4e2u"}},{"attributes":{"rowHeight":"27","colWidth":"100"},"insert":{"id":"r1fkgo0e001oonugnpyzagwdcawt7p139j"}},{"attributes":{},"insert":{"id":"r1kzjna5g2fktqiewegmdob75au7iv2b11"}},{"attributes":{"rowHeight":"27"},"insert":{"id":"r158knzgq3j55d41sgqzad4eh2kykvqf97"}},{"attributes":{"rowHeight":"27"},"insert":{"id":"r1k6bo7rgnj7pjbopqfeljp0athb1zf9zg"}},{"attributes":{"rowHeight":"27"},"insert":{"id":"r1sqoklhkk00w1dcpn6egwi6m21d55t8av"}}],"zoneId":"rsqes1vmglpn0yt3z8kprejbrljsfp7m7v","zoneType":"R"},"cs4tir7rhc4fsk4q8kkn891v5cvcln6s05":{"ops":[{"attributes":{"colWidth":"172"},"insert":{"id":"c134hmy43lgoyn7y3bsh9lc02afo0rrgss"}},{"attributes":{"colWidth":"681"},"insert":{"id":"c10poacggkd53uona2vukohpamlivonhnb"}}],"zoneId":"cs4tir7rhc4fsk4q8kkn891v5cvcln6s05","zoneType":"C"},"xr1a3vc7vhvf3hvmowetchhcmemv32o4e2uxc134hmy43lgoyn7y3bsh9lc02afo0rrgss":{"ops":[{"attributes":{"bold":"true"},"insert":"限制项"},{"insert":"\n"}],"zoneId":"xr1a3vc7vhvf3hvmowetchhcmemv32o4e2uxc134hmy43lgoyn7y3bsh9lc02afo0rrgss","zoneType":"Z"},"xr1a3vc7vhvf3hvmowetchhcmemv32o4e2uxc10poacggkd53uona2vukohpamlivonhnb":{"ops":[{"attributes":{"bold":"true"},"insert":"说明"},{"insert":"\n"}],"zoneId":"xr1a3vc7vhvf3hvmowetchhcmemv32o4e2uxc10poacggkd53uona2vukohpamlivonhnb","zoneType":"Z"},"xr1fkgo0e001oonugnpyzagwdcawt7p139jxc134hmy43lgoyn7y3bsh9lc02afo0rrgss":{"ops":[{"insert":"工作流发布状态\n"}],"zoneId":"xr1fkgo0e001oonugnpyzagwdcawt7p139jxc134hmy43lgoyn7y3bsh9lc02afo0rrgss","zoneType":"Z"},"xr1fkgo0e001oonugnpyzagwdcawt7p139jxc10poacggkd53uona2vukohpamlivonhnb":{"ops":[{"insert":" 必须为已发布。执行未发布的工作流会返回错误码 4200。 创建并发布工作流的操作可参考"},{"attributes":{"hyperlink":"{\"href\":\"https://docs.coze.cn/guides/use_workflow\",\"linkId\":\"gL9bvuYOgt\",\"newTab\":true}"},"insert":"使用工作流"},{"insert":"。\n"}],"zoneId":"xr1fkgo0e001oonugnpyzagwdcawt7p139jxc10poacggkd53uona2vukohpamlivonhnb","zoneType":"Z"},"xr1kzjna5g2fktqiewegmdob75au7iv2b11xc134hmy43lgoyn7y3bsh9lc02afo0rrgss":{"ops":[{"insert":"节点限制\n"}],"zoneId":"xr1kzjna5g2fktqiewegmdob75au7iv2b11xc134hmy43lgoyn7y3bsh9lc02afo0rrgss","zoneType":"Z"},"xr1kzjna5g2fktqiewegmdob75au7iv2b11xc10poacggkd53uona2vukohpamlivonhnb":{"ops":[{"insert":"工作流中不能包含输出节点、开启了流式输出的结束节点。\n"}],"zoneId":"xr1kzjna5g2fktqiewegmdob75au7iv2b11xc10poacggkd53uona2vukohpamlivonhnb","zoneType":"Z"},"xr158knzgq3j55d41sgqzad4eh2kykvqf97xc134hmy43lgoyn7y3bsh9lc02afo0rrgss":{"ops":[{"insert":"关联智能体\n"}],"zoneId":"xr158knzgq3j55d41sgqzad4eh2kykvqf97xc134hmy43lgoyn7y3bsh9lc02afo0rrgss","zoneType":"Z"},"xr158knzgq3j55d41sgqzad4eh2kykvqf97xc10poacggkd53uona2vukohpamlivonhnb":{"ops":[{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"调用此 API 之前，应先在扣子平台中试运行此工作流，如果试运行时需要关联智能体，则调用此 API 执行工作流时，也需要指定智能体ID。通常情况下，执行存在数据库节点、变量节点等节点的工作流需要关联智能体。\n"}],"zoneId":"xr158knzgq3j55d41sgqzad4eh2kykvqf97xc10poacggkd53uona2vukohpamlivonhnb","zoneType":"Z"},"xr1k6bo7rgnj7pjbopqfeljp0athb1zf9zgxc134hmy43lgoyn7y3bsh9lc02afo0rrgss":{"ops":[{"insert":"请求大小上限\n"}],"zoneId":"xr1k6bo7rgnj7pjbopqfeljp0athb1zf9zgxc134hmy43lgoyn7y3bsh9lc02afo0rrgss","zoneType":"Z"},"xr1k6bo7rgnj7pjbopqfeljp0athb1zf9zgxc10poacggkd53uona2vukohpamlivonhnb":{"ops":[{"insert":" 20 MB，包括输入参数及运行期间产生的消息历史等所有相关数据。 \n"}],"zoneId":"xr1k6bo7rgnj7pjbopqfeljp0athb1zf9zgxc10poacggkd53uona2vukohpamlivonhnb","zoneType":"Z"},"xr1sqoklhkk00w1dcpn6egwi6m21d55t8avxc134hmy43lgoyn7y3bsh9lc02afo0rrgss":{"ops":[{"insert":"超时时间 \n"}],"zoneId":"xr1sqoklhkk00w1dcpn6egwi6m21d55t8avxc134hmy43lgoyn7y3bsh9lc02afo0rrgss","zoneType":"Z"},"xr1sqoklhkk00w1dcpn6egwi6m21d55t8avxc10poacggkd53uona2vukohpamlivonhnb":{"ops":[{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"未开启工作流异步运行时，工作流整体超时时间为 10 分钟，建议执行时间控制在 5 分钟以内，否则不保障执行结果的准确性。 详细说明可参考"},{"attributes":{"hyperlink":"{\"href\":\"https://docs.coze.cn/guides/workflow_limits\",\"linkId\":\"c5SNHKSLeE\",\"newTab\":true}"},"insert":"工作流使用限制"},{"insert":"。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"开启工作流异步运行后，工作流整体超时时间为 24 小时。\n"}],"zoneId":"xr1sqoklhkk00w1dcpn6egwi6m21d55t8avxc10poacggkd53uona2vukohpamlivonhnb","zoneType":"Z"}}
        /// </summary>
        /// <param name="appId">
        /// 该工作流关联的应用的 ID
        /// </param>
        /// <param name="botId">
        /// 需要关联的智能体 ID
        /// </param>
        /// <param name="connectorId">
        /// 渠道 ID，比如 ui builder、template、商店等
        /// </param>
        /// <param name="ext">
        /// 用于指定一些额外的字段，非必要可不填写
        /// </param>
        /// <param name="isAsync">
        /// 是否异步运行 (默认 false)
        /// </param>
        /// <param name="parameters">
        /// 工作流开始节点的输入参数及取值 (JSON 序列化字符串)
        /// </param>
        /// <param name="workflowId">
        /// required, 待执行的 Workflow ID，此工作流应已发布
        /// </param>
        /// <param name="workflowVersion">
        /// 资源库工作流版本，只有运行工作流为资源库内工作流时可以传值，不传默认使用最新版本
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.OpenAPIRunFlowResponse> OpenAPIRunFlowAsync(
            string workflowId,
            string? appId = default,
            string? botId = default,
            string? connectorId = default,
            global::System.Collections.Generic.Dictionary<string, string>? ext = default,
            bool? isAsync = default,
            object? parameters = default,
            string? workflowVersion = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.OpenAPIRunFlowRequest
            {
                AppId = appId,
                BotId = botId,
                ConnectorId = connectorId,
                Ext = ext,
                IsAsync = isAsync,
                Parameters = parameters,
                WorkflowId = workflowId,
                WorkflowVersion = workflowVersion,
            };

            return await OpenAPIRunFlowAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}