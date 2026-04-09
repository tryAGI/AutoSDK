//HintName: G.Api.OpenAPIStreamResumeFlow.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {


        private static readonly global::G.EndPointSecurityRequirement s_OpenAPIStreamResumeFlowSecurityRequirement0 =
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
        private static readonly global::G.EndPointSecurityRequirement[] s_OpenAPIStreamResumeFlowSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_OpenAPIStreamResumeFlowSecurityRequirement0,
            };
        partial void PrepareOpenAPIStreamResumeFlowArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.OpenAPIStreamResumeFlowRequest request);
        partial void PrepareOpenAPIStreamResumeFlowRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.OpenAPIStreamResumeFlowRequest request);
        partial void ProcessOpenAPIStreamResumeFlowResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessOpenAPIStreamResumeFlowResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// 恢复运行工作流（流式响应）<br/>
        /// {"0":{"ops":[{"insert":"流式恢复运行已中断的工作流。\n"},{"attributes":{"anchor":"72087735","lmkr":"1","heading":"h2"},"insert":"*"},{"insert":"接口说明\n"},{"insert":"执行包含问答节点的工作流时，智能体会以指定问题向用户提问，并等待用户回答。此时工作流为中断状态，开发者需要调用此接口回答问题，并恢复运行工作流。如果用户的响应和智能体预期提取的信息不匹配，例如缺少必选的字段，或字段数据类型不一致，工作流会再次中断并追问。如果询问 3 次仍未收到符合预期的回复，则判定为工作流执行失败。\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/developer_guides/workflow_resume\",\"linkId\":\"7RIQlXCuBM\"}"},"insert":"恢复运行工作流（流式响应）"},{"insert":"和"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/developer_guides/resume_workflow\",\"linkId\":\"gwYYTY5Gfa\"}"},"insert":"恢复运行工作流"},{"insert":" 的区别如下：\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"如果调用"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/docs/developer_guides/workflow_stream_run\",\"linkId\":\"xa14LowCgk\",\"newTab\":true}"},"insert":"执行工作流（流式响应）"},{"insert":"API，中断恢复时需要使用"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/developer_guides/workflow_resume\",\"linkId\":\"THtKh3T2Jj\"}"},"insert":"恢复运行工作流（流式响应）"},{"insert":" API，该 API 通过流式返回执行结果。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"如果调用"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/developer_guides/workflow_run\",\"linkId\":\"nU83ymXL6E\"}"},"insert":"执行工作流"},{"insert":" API，中断恢复时需要使用"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/developer_guides/resume_workflow\",\"linkId\":\"Ult0p3pfqX\"}"},"insert":"恢复运行工作流"},{"insert":"  API，该 API 支持同步运行或异步运行返回执行结果。\n"},{"attributes":{"anchor":"3ab9d3c3","lmkr":"1","heading":"h2"},"insert":"*"},{"insert":"限制说明\n"},{"attributes":{"lmkr":"1","list":"bullet1","start":"1","origin-start":"1"},"insert":"*"},{"insert":"最多调用此接口恢复运行 3 次，如果第三次恢复运行时智能体仍未收到符合预期的回复，则判定为工作流执行失败。\n"},{"attributes":{"lmkr":"1","list":"bullet1","start":"1","origin-start":"1"},"insert":"*"},{"insert":"恢复运行后，index 和节点 index 都会重置。\n"},{"attributes":{"lmkr":"1","list":"bullet1","start":"1","origin-start":"1"},"insert":"*"},{"insert":"恢复运行工作流也会产生 token 消耗，且与"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/docs/developer_guides/workflow_stream_run\",\"linkId\":\"dC3l54XV5l\",\"newTab\":true}"},"insert":"执行工作流（流式响应）"},{"insert":"时消耗的 token 数量相同。\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.OpenAPIStreamResumeFlowResponse> OpenAPIStreamResumeFlowAsync(

            global::G.OpenAPIStreamResumeFlowRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareOpenAPIStreamResumeFlowArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_OpenAPIStreamResumeFlowSecurityRequirements,
                operationName: "OpenAPIStreamResumeFlowAsync");

            var __pathBuilder = new global::G.PathBuilder(
                path: "/v1/workflow/stream_resume",
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
            PrepareOpenAPIStreamResumeFlowRequest(
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
            ProcessOpenAPIStreamResumeFlowResponse(
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
                ProcessOpenAPIStreamResumeFlowResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.OpenAPIStreamResumeFlowResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.OpenAPIStreamResumeFlowResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// 恢复运行工作流（流式响应）<br/>
        /// {"0":{"ops":[{"insert":"流式恢复运行已中断的工作流。\n"},{"attributes":{"anchor":"72087735","lmkr":"1","heading":"h2"},"insert":"*"},{"insert":"接口说明\n"},{"insert":"执行包含问答节点的工作流时，智能体会以指定问题向用户提问，并等待用户回答。此时工作流为中断状态，开发者需要调用此接口回答问题，并恢复运行工作流。如果用户的响应和智能体预期提取的信息不匹配，例如缺少必选的字段，或字段数据类型不一致，工作流会再次中断并追问。如果询问 3 次仍未收到符合预期的回复，则判定为工作流执行失败。\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/developer_guides/workflow_resume\",\"linkId\":\"7RIQlXCuBM\"}"},"insert":"恢复运行工作流（流式响应）"},{"insert":"和"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/developer_guides/resume_workflow\",\"linkId\":\"gwYYTY5Gfa\"}"},"insert":"恢复运行工作流"},{"insert":" 的区别如下：\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"如果调用"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/docs/developer_guides/workflow_stream_run\",\"linkId\":\"xa14LowCgk\",\"newTab\":true}"},"insert":"执行工作流（流式响应）"},{"insert":"API，中断恢复时需要使用"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/developer_guides/workflow_resume\",\"linkId\":\"THtKh3T2Jj\"}"},"insert":"恢复运行工作流（流式响应）"},{"insert":" API，该 API 通过流式返回执行结果。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"如果调用"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/developer_guides/workflow_run\",\"linkId\":\"nU83ymXL6E\"}"},"insert":"执行工作流"},{"insert":" API，中断恢复时需要使用"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/developer_guides/resume_workflow\",\"linkId\":\"Ult0p3pfqX\"}"},"insert":"恢复运行工作流"},{"insert":"  API，该 API 支持同步运行或异步运行返回执行结果。\n"},{"attributes":{"anchor":"3ab9d3c3","lmkr":"1","heading":"h2"},"insert":"*"},{"insert":"限制说明\n"},{"attributes":{"lmkr":"1","list":"bullet1","start":"1","origin-start":"1"},"insert":"*"},{"insert":"最多调用此接口恢复运行 3 次，如果第三次恢复运行时智能体仍未收到符合预期的回复，则判定为工作流执行失败。\n"},{"attributes":{"lmkr":"1","list":"bullet1","start":"1","origin-start":"1"},"insert":"*"},{"insert":"恢复运行后，index 和节点 index 都会重置。\n"},{"attributes":{"lmkr":"1","list":"bullet1","start":"1","origin-start":"1"},"insert":"*"},{"insert":"恢复运行工作流也会产生 token 消耗，且与"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/docs/developer_guides/workflow_stream_run\",\"linkId\":\"dC3l54XV5l\",\"newTab\":true}"},"insert":"执行工作流（流式响应）"},{"insert":"时消耗的 token 数量相同。\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="eventId">
        /// 工作流执行中断事件 ID
        /// </param>
        /// <param name="interruptType">
        /// 中断类型
        /// </param>
        /// <param name="resumeData">
        /// 恢复执行时，用户对智能体指定问题的回复
        /// </param>
        /// <param name="workflowId">
        /// 待执行的 Workflow ID，此工作流应已发布
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.OpenAPIStreamResumeFlowResponse> OpenAPIStreamResumeFlowAsync(
            string eventId,
            int interruptType,
            string resumeData,
            string workflowId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.OpenAPIStreamResumeFlowRequest
            {
                EventId = eventId,
                InterruptType = interruptType,
                ResumeData = resumeData,
                WorkflowId = workflowId,
            };

            return await OpenAPIStreamResumeFlowAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}