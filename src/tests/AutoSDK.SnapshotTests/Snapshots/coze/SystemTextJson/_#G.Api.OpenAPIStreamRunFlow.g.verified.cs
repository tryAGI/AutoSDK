//HintName: G.Api.OpenAPIStreamRunFlow.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        partial void PrepareOpenAPIStreamRunFlowArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.OpenAPIStreamRunFlowRequest request);
        partial void PrepareOpenAPIStreamRunFlowRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.OpenAPIStreamRunFlowRequest request);
        partial void ProcessOpenAPIStreamRunFlowResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessOpenAPIStreamRunFlowResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// 执行工作流（流式响应）<br/>
        /// {"0":{"ops":[{"insert":"执行已发布的工作流，响应方式为流式响应。 \n"},{"attributes":{"anchor":"2fef0d34","lmkr":"1","heading":"h2"},"insert":"*"},{"insert":"接口说明 \n"},{"insert":"调用 API 执行工作流时，对于支持流式输出的工作流，往往需要使用流式响应方式接收响应数据，例如实时展示工作流的输出信息、呈现打字机效果等。 \n"},{"insert":"在流式响应中，服务端不会一次性发送所有数据，而是以数据流的形式逐条发送数据给客户端，数据流中包含工作流执行过程中触发的各种事件（event），直至处理完毕或处理中断。处理结束后，服务端会通过 event: Done 事件提示工作流执行完毕。各个事件的说明可参考"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/docs/developer_guides/workflow_stream_run#970775c1\",\"linkId\":\"c77ImUSDhY\",\"newTab\":true}"},"insert":"返回结果"},{"insert":"。 \n"},{"attributes":{"zoneId":"yH60O7s0y7","zoneType":"Z","type":"tip","title":"说明","border":"#bacefd","background":"#f0f4ff","highlight-block-v2":"true"},"insert":" "},{"insert":"\n"},{"attributes":{"anchor":"37a5ac1f","lmkr":"1","heading":"h2"},"insert":"*"},{"insert":"限制说明\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"此接口为同步接口，如果工作流整体或某些节点运行超时，Bot 可能无法提供符合预期的回复。同步执行时，工作流整体超时时间限制可参考"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/docs/guides/workflow_limits\",\"linkId\":\"jCTdLPCnbs\",\"newTab\":true}"},"insert":"工作流使用限制"},{"insert":"。 \n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"attributes":{"zoneId":"kv7Sy9XJ2C","zoneType":"Z","type":"tip","title":"说明","border":"#bacefd","background":"#f0f4ff","highlight-block-v2":"true"},"insert":" "},{"insert":"\n"}],"zoneId":"0","zoneType":"Z"},"yH60O7s0y7":{"ops":[{"insert":"目前支持流式响应的工作流节点包括"},{"attributes":{"bold":"true"},"insert":"输出节点"},{"insert":"、"},{"attributes":{"bold":"true"},"insert":"问答节点"},{"insert":"和"},{"attributes":{"bold":"true"},"insert":"开启了流式输出的结束节点"},{"insert":"。对于不包含这些节点的工作流，可以使用"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/docs/developer_guides/workflow_run\",\"linkId\":\"ohOkmqNIMy\",\"newTab\":true}"},"insert":"执行工作流"},{"insert":"接口一次性接收响应数据。 \n"}],"zoneId":"yH60O7s0y7","zoneType":"Z"},"kv7Sy9XJ2C":{"ops":[{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"通过 API 方式执行工作流前，应确认此工作流已发布，执行从未发布过的工作流时会返回错误码 4200。创建并发布工作流的操作可参考"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/docs/guides/use_workflow\",\"linkId\":\"y9NDHF6qip\",\"newTab\":true}"},"insert":"使用工作流"},{"insert":"。 \n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"调用此 API 之前，应先在扣子平台中试运行此工作流。\n"},{"attributes":{"list":"bullet2","lmkr":"1"},"insert":"*"},{"insert":"如果试运行时需要关联智能体，则调用此 API 执行工作流时，也需要指定 bot_id。通常情况下，执行存在数据库节点、变量节点等节点的工作流需要关联智能体。\n"},{"attributes":{"lmkr":"1","list":"bullet2"},"insert":"*"},{"insert":"执行应用中的工作流时，需要指定 app_id。\n"},{"attributes":{"lmkr":"1","list":"bullet2"},"insert":"*"},{"insert":"请勿同时指定 bot_id 和 app_id，否则 API 会报错 4000，表示请求参数错误。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"工作流支持的请求大小上限为 20MB，包括输入参数以及运行期间产生的消息历史等所有相关数据。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"此接口为同步接口，如果工作流整体或某些节点运行超时，智能体可能无法提供符合预期的回复，建议将工作流的执行时间控制在 5 分钟以内。同步执行时，工作流整体超时时间限制可参考"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/guides/workflow_limits\",\"linkId\":\"O7UYVmychs\",\"newTab\":true}"},"insert":"工作流使用限制"},{"insert":"。\n"}],"zoneId":"kv7Sy9XJ2C","zoneType":"Z"}}
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.OpenAPIStreamRunFlowResponse> OpenAPIStreamRunFlowAsync(

            global::G.OpenAPIStreamRunFlowRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareOpenAPIStreamRunFlowArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: "/v1/workflow/stream_run",
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
            PrepareOpenAPIStreamRunFlowRequest(
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
            ProcessOpenAPIStreamRunFlowResponse(
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
                ProcessOpenAPIStreamRunFlowResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.OpenAPIStreamRunFlowResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.OpenAPIStreamRunFlowResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// 执行工作流（流式响应）<br/>
        /// {"0":{"ops":[{"insert":"执行已发布的工作流，响应方式为流式响应。 \n"},{"attributes":{"anchor":"2fef0d34","lmkr":"1","heading":"h2"},"insert":"*"},{"insert":"接口说明 \n"},{"insert":"调用 API 执行工作流时，对于支持流式输出的工作流，往往需要使用流式响应方式接收响应数据，例如实时展示工作流的输出信息、呈现打字机效果等。 \n"},{"insert":"在流式响应中，服务端不会一次性发送所有数据，而是以数据流的形式逐条发送数据给客户端，数据流中包含工作流执行过程中触发的各种事件（event），直至处理完毕或处理中断。处理结束后，服务端会通过 event: Done 事件提示工作流执行完毕。各个事件的说明可参考"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/docs/developer_guides/workflow_stream_run#970775c1\",\"linkId\":\"c77ImUSDhY\",\"newTab\":true}"},"insert":"返回结果"},{"insert":"。 \n"},{"attributes":{"zoneId":"yH60O7s0y7","zoneType":"Z","type":"tip","title":"说明","border":"#bacefd","background":"#f0f4ff","highlight-block-v2":"true"},"insert":" "},{"insert":"\n"},{"attributes":{"anchor":"37a5ac1f","lmkr":"1","heading":"h2"},"insert":"*"},{"insert":"限制说明\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"此接口为同步接口，如果工作流整体或某些节点运行超时，Bot 可能无法提供符合预期的回复。同步执行时，工作流整体超时时间限制可参考"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/docs/guides/workflow_limits\",\"linkId\":\"jCTdLPCnbs\",\"newTab\":true}"},"insert":"工作流使用限制"},{"insert":"。 \n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"attributes":{"zoneId":"kv7Sy9XJ2C","zoneType":"Z","type":"tip","title":"说明","border":"#bacefd","background":"#f0f4ff","highlight-block-v2":"true"},"insert":" "},{"insert":"\n"}],"zoneId":"0","zoneType":"Z"},"yH60O7s0y7":{"ops":[{"insert":"目前支持流式响应的工作流节点包括"},{"attributes":{"bold":"true"},"insert":"输出节点"},{"insert":"、"},{"attributes":{"bold":"true"},"insert":"问答节点"},{"insert":"和"},{"attributes":{"bold":"true"},"insert":"开启了流式输出的结束节点"},{"insert":"。对于不包含这些节点的工作流，可以使用"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/docs/developer_guides/workflow_run\",\"linkId\":\"ohOkmqNIMy\",\"newTab\":true}"},"insert":"执行工作流"},{"insert":"接口一次性接收响应数据。 \n"}],"zoneId":"yH60O7s0y7","zoneType":"Z"},"kv7Sy9XJ2C":{"ops":[{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"通过 API 方式执行工作流前，应确认此工作流已发布，执行从未发布过的工作流时会返回错误码 4200。创建并发布工作流的操作可参考"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/docs/guides/use_workflow\",\"linkId\":\"y9NDHF6qip\",\"newTab\":true}"},"insert":"使用工作流"},{"insert":"。 \n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"调用此 API 之前，应先在扣子平台中试运行此工作流。\n"},{"attributes":{"list":"bullet2","lmkr":"1"},"insert":"*"},{"insert":"如果试运行时需要关联智能体，则调用此 API 执行工作流时，也需要指定 bot_id。通常情况下，执行存在数据库节点、变量节点等节点的工作流需要关联智能体。\n"},{"attributes":{"lmkr":"1","list":"bullet2"},"insert":"*"},{"insert":"执行应用中的工作流时，需要指定 app_id。\n"},{"attributes":{"lmkr":"1","list":"bullet2"},"insert":"*"},{"insert":"请勿同时指定 bot_id 和 app_id，否则 API 会报错 4000，表示请求参数错误。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"工作流支持的请求大小上限为 20MB，包括输入参数以及运行期间产生的消息历史等所有相关数据。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"此接口为同步接口，如果工作流整体或某些节点运行超时，智能体可能无法提供符合预期的回复，建议将工作流的执行时间控制在 5 分钟以内。同步执行时，工作流整体超时时间限制可参考"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/guides/workflow_limits\",\"linkId\":\"O7UYVmychs\",\"newTab\":true}"},"insert":"工作流使用限制"},{"insert":"。\n"}],"zoneId":"kv7Sy9XJ2C","zoneType":"Z"}}
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
        public async global::System.Threading.Tasks.Task<global::G.OpenAPIStreamRunFlowResponse> OpenAPIStreamRunFlowAsync(
            string workflowId,
            string? appId = default,
            string? botId = default,
            string? connectorId = default,
            global::System.Collections.Generic.Dictionary<string, string>? ext = default,
            object? parameters = default,
            string? workflowVersion = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.OpenAPIStreamRunFlowRequest
            {
                AppId = appId,
                BotId = botId,
                ConnectorId = connectorId,
                Ext = ext,
                Parameters = parameters,
                WorkflowId = workflowId,
                WorkflowVersion = workflowVersion,
            };

            return await OpenAPIStreamRunFlowAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}