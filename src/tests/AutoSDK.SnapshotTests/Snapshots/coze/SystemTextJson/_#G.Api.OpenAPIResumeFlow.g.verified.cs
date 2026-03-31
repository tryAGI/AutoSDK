//HintName: G.Api.OpenAPIResumeFlow.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        partial void PrepareOpenAPIResumeFlowArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.OpenAPIResumeFlowRequest request);
        partial void PrepareOpenAPIResumeFlowRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.OpenAPIResumeFlowRequest request);
        partial void ProcessOpenAPIResumeFlowResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessOpenAPIResumeFlowResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// 恢复运行工作流<br/>
        /// {"0":{"ops":[{"insert":"恢复运行工作流。\n"},{"attributes":{"anchor":"842ac83e","heading":"h2","lmkr":"1"},"insert":"*"},{"insert":"接口说明\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"当调用"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/developer_guides/workflow_run\",\"linkId\":\"6f6CoqUUHd\"}"},"insert":"执行工作流"},{"insert":" API 执行包含问答节点、输入节点的工作流时，智能体会以指定问题向用户提问，并等待用户回答。此时工作流为中断状态，开发者需要调用此 API 回答问题，并恢复运行工作流。如果问答节点勾选了"},{"insert":"从回复中提取字段","attributes":{"bold":"true"}},{"insert":"，当用户的响应和智能体预期提取的信息不匹配，例如缺少必选的字段，或字段数据类型不一致，工作流会再次中断并追问。\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"如果"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/developer_guides/workflow_run\",\"linkId\":\"BPbGLtCrny\"}"},"insert":"执行工作流"},{"insert":"  API 为同步运行，则恢复运行工作流也为同步运行。如果"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/developer_guides/workflow_run\",\"linkId\":\"dChke0kicF\"}"},"insert":"执行工作流"},{"insert":"  API 为异步运行，则恢复运行工作流也为异步运行，你还需要调用"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/developer_guides/workflow_history\",\"linkId\":\"UNm30zYvKE\"}"},"insert":"查询异步执行结果"},{"insert":" API 查询执行结果。\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/developer_guides/workflow_resume\",\"linkId\":\"gRM2p506FE\"}"},"insert":"恢复运行工作流（流式响应）"},{"insert":"和"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/developer_guides/resume_workflow\",\"linkId\":\"ZHAYDn2Ils\"}"},"insert":"恢复运行工作流"},{"insert":" 的区别如下：\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"如果调用"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/docs/developer_guides/workflow_stream_run\",\"linkId\":\"NPczb8G6jJ\",\"newTab\":true}"},"insert":"执行工作流（流式响应）"},{"insert":"API 时工作流中断，恢复时需要使用"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/developer_guides/workflow_resume\",\"linkId\":\"M7UplYm5nn\"}"},"insert":"恢复运行工作流（流式响应）"},{"insert":" API，该 API 通过流式返回执行结果。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"如果调用"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/developer_guides/workflow_run\",\"linkId\":\"WoLg8TlFAC\"}"},"insert":"执行工作流"},{"insert":" API 时工作流中断，恢复时需要使用"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/developer_guides/resume_workflow\",\"linkId\":\"vaT8ww0Xv8\"}"},"insert":"恢复运行工作流"},{"insert":"  API，该 API 支持同步运行或异步运行返回执行结果。\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.OpenAPIResumeFlowResponse> OpenAPIResumeFlowAsync(

            global::G.OpenAPIResumeFlowRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareOpenAPIResumeFlowArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: "/v1/workflows/resume",
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
            PrepareOpenAPIResumeFlowRequest(
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
            ProcessOpenAPIResumeFlowResponse(
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
                ProcessOpenAPIResumeFlowResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.OpenAPIResumeFlowResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.OpenAPIResumeFlowResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// 恢复运行工作流<br/>
        /// {"0":{"ops":[{"insert":"恢复运行工作流。\n"},{"attributes":{"anchor":"842ac83e","heading":"h2","lmkr":"1"},"insert":"*"},{"insert":"接口说明\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"当调用"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/developer_guides/workflow_run\",\"linkId\":\"6f6CoqUUHd\"}"},"insert":"执行工作流"},{"insert":" API 执行包含问答节点、输入节点的工作流时，智能体会以指定问题向用户提问，并等待用户回答。此时工作流为中断状态，开发者需要调用此 API 回答问题，并恢复运行工作流。如果问答节点勾选了"},{"insert":"从回复中提取字段","attributes":{"bold":"true"}},{"insert":"，当用户的响应和智能体预期提取的信息不匹配，例如缺少必选的字段，或字段数据类型不一致，工作流会再次中断并追问。\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"如果"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/developer_guides/workflow_run\",\"linkId\":\"BPbGLtCrny\"}"},"insert":"执行工作流"},{"insert":"  API 为同步运行，则恢复运行工作流也为同步运行。如果"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/developer_guides/workflow_run\",\"linkId\":\"dChke0kicF\"}"},"insert":"执行工作流"},{"insert":"  API 为异步运行，则恢复运行工作流也为异步运行，你还需要调用"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/developer_guides/workflow_history\",\"linkId\":\"UNm30zYvKE\"}"},"insert":"查询异步执行结果"},{"insert":" API 查询执行结果。\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/developer_guides/workflow_resume\",\"linkId\":\"gRM2p506FE\"}"},"insert":"恢复运行工作流（流式响应）"},{"insert":"和"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/developer_guides/resume_workflow\",\"linkId\":\"ZHAYDn2Ils\"}"},"insert":"恢复运行工作流"},{"insert":" 的区别如下：\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"如果调用"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/docs/developer_guides/workflow_stream_run\",\"linkId\":\"NPczb8G6jJ\",\"newTab\":true}"},"insert":"执行工作流（流式响应）"},{"insert":"API 时工作流中断，恢复时需要使用"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/developer_guides/workflow_resume\",\"linkId\":\"M7UplYm5nn\"}"},"insert":"恢复运行工作流（流式响应）"},{"insert":" API，该 API 通过流式返回执行结果。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"如果调用"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/developer_guides/workflow_run\",\"linkId\":\"WoLg8TlFAC\"}"},"insert":"执行工作流"},{"insert":" API 时工作流中断，恢复时需要使用"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/developer_guides/resume_workflow\",\"linkId\":\"vaT8ww0Xv8\"}"},"insert":"恢复运行工作流"},{"insert":"  API，该 API 支持同步运行或异步运行返回执行结果。\n"}],"zoneId":"0","zoneType":"Z"}}
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
        public async global::System.Threading.Tasks.Task<global::G.OpenAPIResumeFlowResponse> OpenAPIResumeFlowAsync(
            string eventId,
            int interruptType,
            string resumeData,
            string workflowId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {

            var __request = new global::G.OpenAPIResumeFlowRequest
            {
                EventId = eventId,
                InterruptType = interruptType,
                ResumeData = resumeData,
                WorkflowId = workflowId,
            };

            return await OpenAPIResumeFlowAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}