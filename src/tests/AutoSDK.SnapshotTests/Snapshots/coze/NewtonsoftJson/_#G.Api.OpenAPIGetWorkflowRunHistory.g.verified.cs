//HintName: G.Api.OpenAPIGetWorkflowRunHistory.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        partial void PrepareOpenAPIGetWorkflowRunHistoryArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string workflowId,
            ref string executeId);
        partial void PrepareOpenAPIGetWorkflowRunHistoryRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string workflowId,
            string executeId);
        partial void ProcessOpenAPIGetWorkflowRunHistoryResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessOpenAPIGetWorkflowRunHistoryResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// 查询工作流异步执行结果<br/>
        /// {"0":{"ops":[{"insert":"工作流异步运行后，查看执行结果。\n"},{"attributes":{"anchor":"382d8a84","heading":"h2","lmkr":"1"},"insert":"*"},{"insert":"接口说明\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"调用"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/developer_guides/workflow_run\",\"linkId\":\"pzq5RT59ic\",\"newTab\":true}"},"insert":"执行工作流"},{"insert":"或"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/developer_guides/resume_workflow\",\"linkId\":\"DWpq7HpwCu\"}"},"insert":"恢复运行工作流"},{"insert":" API 时，如果选择异步运行工作流，响应信息中会返回 execute_id，开发者可以通过本 API 查询指定事件的执行结果。\n"},{"attributes":{"anchor":"c74dc548","lmkr":"1","heading":"h2"},"insert":"*"},{"insert":"限制说明\n"},{"attributes":{"lmkr":"1","ol-id":"4isg3TOi","list":"bullet1","start":"1","origin-start":"1"},"insert":"*"},{"insert":"本 API 的流控限制请参见 "},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/developer_guides/coze_api_overview\",\"linkId\":\"cI3Eawsei6\",\"newTab\":true}"},"insert":"API 介绍"},{"insert":"。\n"},{"attributes":{"list":"bullet1","lmkr":"1","start":"2","origin-start":"2"},"insert":"*"},{"insert":"工作流的"},{"attributes":{"bold":"true"},"insert":"输出节点"},{"insert":"的输出数据最多保存 24 小时，"},{"attributes":{"bold":"true"},"insert":"结束节点"},{"insert":"为 7 天。\n"},{"attributes":{"lmkr":"1","list":"bullet1","start":"2","origin-start":"2"},"insert":"*"},{"insert":"输出节点的输出内容超过 1MB 时，无法保证返回内容的完整性。\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="workflowId"></param>
        /// <param name="executeId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.OpenAPIGetWorkflowRunHistoryResponse> OpenAPIGetWorkflowRunHistoryAsync(
            string workflowId,
            string executeId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareOpenAPIGetWorkflowRunHistoryArguments(
                httpClient: HttpClient,
                workflowId: ref workflowId,
                executeId: ref executeId);

            var __pathBuilder = new global::G.PathBuilder(
                path: $"/v1/workflows/{workflowId}/run_histories/{executeId}",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
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

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareOpenAPIGetWorkflowRunHistoryRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                workflowId: workflowId,
                executeId: executeId);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessOpenAPIGetWorkflowRunHistoryResponse(
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
                ProcessOpenAPIGetWorkflowRunHistoryResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.OpenAPIGetWorkflowRunHistoryResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.OpenAPIGetWorkflowRunHistoryResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
    }
}