//HintName: G.Api.OpenAPIChatFlowRun.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        partial void PrepareOpenAPIChatFlowRunArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.OpenAPIChatFlowRunRequest request);
        partial void PrepareOpenAPIChatFlowRunRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.OpenAPIChatFlowRunRequest request);
        partial void ProcessOpenAPIChatFlowRunResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessOpenAPIChatFlowRunResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// 执行对话流<br/>
        /// {"0":{"ops":[{"insert":"执行已发布的对话流。\n"},{"attributes":{"anchor":"47cc97f2","lmkr":"1","heading":"h2"},"insert":"*"},{"insert":"接口说明\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"对话流是基于对话场景的特殊工作流，专门用于处理对话类请求。对话流通过对话的方式和用户交互，并完成复杂的业务逻辑。在应用中添加对话流，将对话中的用户指令拆分为一个个步骤节点，并为其设计用户界面，你可以搭建出适用于移动端或网页端的对话式 AI 应用，实现自动化、智能化的对话流程。关于对话流的详细说明可参考"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/guides/workflow_and_chatflow\",\"linkId\":\"vxeF3k5Ez3\",\"newTab\":true}"},"insert":"工作流与对话流"},{"insert":"。\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"此接口为流式响应模式，允许客户端在接收到完整的数据流之前就开始处理数据，例如在对话界面实时展示回复内容，减少客户端等待模型完整回复的时间。 \n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"此接口支持包括问答节点、输入节点等可能导致对话中断的节点，对话中断时只需再次调用对话流，在 additional_messages 中指定输入内容，即可继续对话。\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"attributes":{"zoneId":"CGi82W4xyz","zoneType":"Z","type":"tip","title":"说明","border":"#bacefd","background":"#f0f4ff","highlight-block-v2":"true"},"insert":" "},{"insert":"\n"},{"insert":"此接口可用于调用空间资源库中的对话流，或扣子应用中的对话流。调用这两种对话流时，入参不同：\n"},{"attributes":{"aceTable":"rsghbrzurpu9psf8ntj79vc9aiaguihas0 cseqppv2ku111vnbmandg8fp40vzd1ya28"},"insert":"*"},{"insert":"\n"},{"attributes":{"anchor":"6bbdfc03","lmkr":"1","heading":"h2"},"insert":"*"},{"insert":"限制说明\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"通过 API 方式执行对话流前，应确认此对话流已发布，执行从未发布过的对话流时会返回错误码 4200。如果是扣子应用中的对话流，应先发布扣子应用为 API 服务；如果是空间资源库中的对话流，应先在资源库中发布对话流。\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"此接口暂不支持异步运行。\n"}],"zoneId":"0","zoneType":"Z"},"CGi82W4xyz":{"ops":[{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"如果对话流的输入中包含文件、图片等多模态内容，需要先上传多模态内容以获取文件 ID 或 URL 地址，再将其作为对话流的输入。上传方式包括：\n"},{"attributes":{"list":"bullet2","lmkr":"1"},"insert":"*"},{"insert":"调用"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/developer_guides/upload_files\",\"linkId\":\"jdPbJl73DG\"}"},"insert":"上传文件"},{"insert":" API，获取文件 ID，将此 ID 作为对话流的输入。 \n"},{"attributes":{"lmkr":"1","list":"bullet2"},"insert":"*"},{"insert":"上传到第三方存储工具中，并获取一个公开可访问的 URL 地址，将此 URL 作为对话流的输入。\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"调用接口后，你可以从响应的 Done 事件中获得 debug_url，访问链接即可通过可视化界面查看对话流的试运行过程，其中包含每个执行节点的输入输出等详细信息，帮助你在线调试或排障。debug_url 的访问有效期为 7 天，过期后将无法访问。\n"}],"zoneId":"CGi82W4xyz","zoneType":"Z"},"rsghbrzurpu9psf8ntj79vc9aiaguihas0":{"ops":[{"insert":{"id":"r1cqzidznbo73ytz7fq44101mcikf18h9o"}},{"attributes":{"colWidth":"100"},"insert":{"id":"r1ntjyrq69gz7634d8tbd619tnjsniboa2"}},{"attributes":{},"insert":{"id":"r1qg26390yoqyjwdtz4b103796yailbw27"}},{"attributes":{},"insert":{"id":"r19yzj0rftq9wnfp794lyak8ve9l50vhds"}},{"attributes":{},"insert":{"id":"r1gugs2w85i1mmr593vzjm9deyy2wwttu3"}}],"zoneId":"rsghbrzurpu9psf8ntj79vc9aiaguihas0","zoneType":"R"},"cseqppv2ku111vnbmandg8fp40vzd1ya28":{"ops":[{"attributes":{"mergeCellID":"ldoqco2b","colWidth":"135"},"insert":{"id":"c1phhqpudz1r15iwr45ptroi5kwa3dc2pe"}},{"attributes":{"colWidth":"165","mergeCellID":"cnkji7ge"},"insert":{"id":"c1gpbqvcvdeskm02ttguq56j2476840ppy"}},{"attributes":{"colWidth":"160","mergeCellID":"cnkji7ge"},"insert":{"id":"c15twnehe8l1z6rn6dw5hjjdobmpnac5w4"}},{"attributes":{"colWidth":"232","mergeCellID":"2gn1thkp"},"insert":{"id":"c10rgt6nbdqfd7llawn1q17ioeu5mfrwhp"}}],"zoneId":"cseqppv2ku111vnbmandg8fp40vzd1ya28","zoneType":"C"},"xr1cqzidznbo73ytz7fq44101mcikf18h9oxc1phhqpudz1r15iwr45ptroi5kwa3dc2pe":{"ops":[{"attributes":{"bold":"true"},"insert":"入参"},{"insert":"\n"}],"zoneId":"xr1cqzidznbo73ytz7fq44101mcikf18h9oxc1phhqpudz1r15iwr45ptroi5kwa3dc2pe","zoneType":"Z"},"xr1cqzidznbo73ytz7fq44101mcikf18h9oxc1gpbqvcvdeskm02ttguq56j2476840ppy":{"ops":[{"attributes":{"bold":"true"},"insert":"在智能体中执行资源库中的对话流"},{"insert":"\n"}],"zoneId":"xr1cqzidznbo73ytz7fq44101mcikf18h9oxc1gpbqvcvdeskm02ttguq56j2476840ppy","zoneType":"Z"},"xr1cqzidznbo73ytz7fq44101mcikf18h9oxc15twnehe8l1z6rn6dw5hjjdobmpnac5w4":{"ops":[{"attributes":{"bold":"true"},"insert":"在扣子应用中执行资源库中的对话流"},{"insert":"\n"}],"zoneId":"xr1cqzidznbo73ytz7fq44101mcikf18h9oxc15twnehe8l1z6rn6dw5hjjdobmpnac5w4","zoneType":"Z"},"xr1cqzidznbo73ytz7fq44101mcikf18h9oxc10rgt6nbdqfd7llawn1q17ioeu5mfrwhp":{"ops":[{"attributes":{"align":"left","lmkr":"1"},"insert":"*"},{"attributes":{"bold":"true"},"insert":"扣子应用中的对话流"},{"insert":"\n"}],"zoneId":"xr1cqzidznbo73ytz7fq44101mcikf18h9oxc10rgt6nbdqfd7llawn1q17ioeu5mfrwhp","zoneType":"Z"},"xr1ntjyrq69gz7634d8tbd619tnjsniboa2xc1phhqpudz1r15iwr45ptroi5kwa3dc2pe":{"ops":[{"insert":"workflow_id\n"}],"zoneId":"xr1ntjyrq69gz7634d8tbd619tnjsniboa2xc1phhqpudz1r15iwr45ptroi5kwa3dc2pe","zoneType":"Z"},"xr1ntjyrq69gz7634d8tbd619tnjsniboa2xc1gpbqvcvdeskm02ttguq56j2476840ppy":{"ops":[{"insert":"必选\n"}],"zoneId":"xr1ntjyrq69gz7634d8tbd619tnjsniboa2xc1gpbqvcvdeskm02ttguq56j2476840ppy","zoneType":"Z"},"xr1ntjyrq69gz7634d8tbd619tnjsniboa2xc15twnehe8l1z6rn6dw5hjjdobmpnac5w4":{"ops":[{"insert":"必选\n"}],"zoneId":"xr1ntjyrq69gz7634d8tbd619tnjsniboa2xc15twnehe8l1z6rn6dw5hjjdobmpnac5w4","zoneType":"Z"},"xr1ntjyrq69gz7634d8tbd619tnjsniboa2xc10rgt6nbdqfd7llawn1q17ioeu5mfrwhp":{"ops":[{"insert":"必选\n"}],"zoneId":"xr1ntjyrq69gz7634d8tbd619tnjsniboa2xc10rgt6nbdqfd7llawn1q17ioeu5mfrwhp","zoneType":"Z"},"xr1qg26390yoqyjwdtz4b103796yailbw27xc1phhqpudz1r15iwr45ptroi5kwa3dc2pe":{"ops":[{"insert":"app_id\n"}],"zoneId":"xr1qg26390yoqyjwdtz4b103796yailbw27xc1phhqpudz1r15iwr45ptroi5kwa3dc2pe","zoneType":"Z"},"xr1qg26390yoqyjwdtz4b103796yailbw27xc1gpbqvcvdeskm02ttguq56j2476840ppy":{"ops":[{"insert":"不传\n"}],"zoneId":"xr1qg26390yoqyjwdtz4b103796yailbw27xc1gpbqvcvdeskm02ttguq56j2476840ppy","zoneType":"Z"},"xr1qg26390yoqyjwdtz4b103796yailbw27xc15twnehe8l1z6rn6dw5hjjdobmpnac5w4":{"ops":[{"insert":"必选\n"}],"zoneId":"xr1qg26390yoqyjwdtz4b103796yailbw27xc15twnehe8l1z6rn6dw5hjjdobmpnac5w4","zoneType":"Z"},"xr1qg26390yoqyjwdtz4b103796yailbw27xc10rgt6nbdqfd7llawn1q17ioeu5mfrwhp":{"ops":[{"insert":"必选\n"}],"zoneId":"xr1qg26390yoqyjwdtz4b103796yailbw27xc10rgt6nbdqfd7llawn1q17ioeu5mfrwhp","zoneType":"Z"},"xr19yzj0rftq9wnfp794lyak8ve9l50vhdsxc1phhqpudz1r15iwr45ptroi5kwa3dc2pe":{"ops":[{"insert":"bot_id\n"}],"zoneId":"xr19yzj0rftq9wnfp794lyak8ve9l50vhdsxc1phhqpudz1r15iwr45ptroi5kwa3dc2pe","zoneType":"Z"},"xr19yzj0rftq9wnfp794lyak8ve9l50vhdsxc1gpbqvcvdeskm02ttguq56j2476840ppy":{"ops":[{"insert":"必选\n"}],"zoneId":"xr19yzj0rftq9wnfp794lyak8ve9l50vhdsxc1gpbqvcvdeskm02ttguq56j2476840ppy","zoneType":"Z"},"xr19yzj0rftq9wnfp794lyak8ve9l50vhdsxc15twnehe8l1z6rn6dw5hjjdobmpnac5w4":{"ops":[{"insert":"不传\n"}],"zoneId":"xr19yzj0rftq9wnfp794lyak8ve9l50vhdsxc15twnehe8l1z6rn6dw5hjjdobmpnac5w4","zoneType":"Z"},"xr19yzj0rftq9wnfp794lyak8ve9l50vhdsxc10rgt6nbdqfd7llawn1q17ioeu5mfrwhp":{"ops":[{"insert":"不传\n"}],"zoneId":"xr19yzj0rftq9wnfp794lyak8ve9l50vhdsxc10rgt6nbdqfd7llawn1q17ioeu5mfrwhp","zoneType":"Z"},"xr1gugs2w85i1mmr593vzjm9deyy2wwttu3xc1phhqpudz1r15iwr45ptroi5kwa3dc2pe":{"ops":[{"insert":"conversation_id\n"}],"zoneId":"xr1gugs2w85i1mmr593vzjm9deyy2wwttu3xc1phhqpudz1r15iwr45ptroi5kwa3dc2pe","zoneType":"Z"},"xr1gugs2w85i1mmr593vzjm9deyy2wwttu3xc1gpbqvcvdeskm02ttguq56j2476840ppy":{"ops":[{"insert":"可选\n"}],"zoneId":"xr1gugs2w85i1mmr593vzjm9deyy2wwttu3xc1gpbqvcvdeskm02ttguq56j2476840ppy","zoneType":"Z"},"xr1gugs2w85i1mmr593vzjm9deyy2wwttu3xc15twnehe8l1z6rn6dw5hjjdobmpnac5w4":{"ops":[{"insert":"可选\n"}],"zoneId":"xr1gugs2w85i1mmr593vzjm9deyy2wwttu3xc15twnehe8l1z6rn6dw5hjjdobmpnac5w4","zoneType":"Z"},"xr1gugs2w85i1mmr593vzjm9deyy2wwttu3xc10rgt6nbdqfd7llawn1q17ioeu5mfrwhp":{"ops":[{"insert":"可选\n"}],"zoneId":"xr1gugs2w85i1mmr593vzjm9deyy2wwttu3xc10rgt6nbdqfd7llawn1q17ioeu5mfrwhp","zoneType":"Z"}}
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.OpenAPIChatFlowRunResponse> OpenAPIChatFlowRunAsync(

            global::G.OpenAPIChatFlowRunRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareOpenAPIChatFlowRunArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: "/v1/workflows/chat",
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
            PrepareOpenAPIChatFlowRunRequest(
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
            ProcessOpenAPIChatFlowRunResponse(
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
                ProcessOpenAPIChatFlowRunResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.OpenAPIChatFlowRunResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.OpenAPIChatFlowRunResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// 执行对话流<br/>
        /// {"0":{"ops":[{"insert":"执行已发布的对话流。\n"},{"attributes":{"anchor":"47cc97f2","lmkr":"1","heading":"h2"},"insert":"*"},{"insert":"接口说明\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"对话流是基于对话场景的特殊工作流，专门用于处理对话类请求。对话流通过对话的方式和用户交互，并完成复杂的业务逻辑。在应用中添加对话流，将对话中的用户指令拆分为一个个步骤节点，并为其设计用户界面，你可以搭建出适用于移动端或网页端的对话式 AI 应用，实现自动化、智能化的对话流程。关于对话流的详细说明可参考"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/guides/workflow_and_chatflow\",\"linkId\":\"vxeF3k5Ez3\",\"newTab\":true}"},"insert":"工作流与对话流"},{"insert":"。\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"此接口为流式响应模式，允许客户端在接收到完整的数据流之前就开始处理数据，例如在对话界面实时展示回复内容，减少客户端等待模型完整回复的时间。 \n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"此接口支持包括问答节点、输入节点等可能导致对话中断的节点，对话中断时只需再次调用对话流，在 additional_messages 中指定输入内容，即可继续对话。\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"attributes":{"zoneId":"CGi82W4xyz","zoneType":"Z","type":"tip","title":"说明","border":"#bacefd","background":"#f0f4ff","highlight-block-v2":"true"},"insert":" "},{"insert":"\n"},{"insert":"此接口可用于调用空间资源库中的对话流，或扣子应用中的对话流。调用这两种对话流时，入参不同：\n"},{"attributes":{"aceTable":"rsghbrzurpu9psf8ntj79vc9aiaguihas0 cseqppv2ku111vnbmandg8fp40vzd1ya28"},"insert":"*"},{"insert":"\n"},{"attributes":{"anchor":"6bbdfc03","lmkr":"1","heading":"h2"},"insert":"*"},{"insert":"限制说明\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"通过 API 方式执行对话流前，应确认此对话流已发布，执行从未发布过的对话流时会返回错误码 4200。如果是扣子应用中的对话流，应先发布扣子应用为 API 服务；如果是空间资源库中的对话流，应先在资源库中发布对话流。\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"此接口暂不支持异步运行。\n"}],"zoneId":"0","zoneType":"Z"},"CGi82W4xyz":{"ops":[{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"如果对话流的输入中包含文件、图片等多模态内容，需要先上传多模态内容以获取文件 ID 或 URL 地址，再将其作为对话流的输入。上传方式包括：\n"},{"attributes":{"list":"bullet2","lmkr":"1"},"insert":"*"},{"insert":"调用"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/developer_guides/upload_files\",\"linkId\":\"jdPbJl73DG\"}"},"insert":"上传文件"},{"insert":" API，获取文件 ID，将此 ID 作为对话流的输入。 \n"},{"attributes":{"lmkr":"1","list":"bullet2"},"insert":"*"},{"insert":"上传到第三方存储工具中，并获取一个公开可访问的 URL 地址，将此 URL 作为对话流的输入。\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"调用接口后，你可以从响应的 Done 事件中获得 debug_url，访问链接即可通过可视化界面查看对话流的试运行过程，其中包含每个执行节点的输入输出等详细信息，帮助你在线调试或排障。debug_url 的访问有效期为 7 天，过期后将无法访问。\n"}],"zoneId":"CGi82W4xyz","zoneType":"Z"},"rsghbrzurpu9psf8ntj79vc9aiaguihas0":{"ops":[{"insert":{"id":"r1cqzidznbo73ytz7fq44101mcikf18h9o"}},{"attributes":{"colWidth":"100"},"insert":{"id":"r1ntjyrq69gz7634d8tbd619tnjsniboa2"}},{"attributes":{},"insert":{"id":"r1qg26390yoqyjwdtz4b103796yailbw27"}},{"attributes":{},"insert":{"id":"r19yzj0rftq9wnfp794lyak8ve9l50vhds"}},{"attributes":{},"insert":{"id":"r1gugs2w85i1mmr593vzjm9deyy2wwttu3"}}],"zoneId":"rsghbrzurpu9psf8ntj79vc9aiaguihas0","zoneType":"R"},"cseqppv2ku111vnbmandg8fp40vzd1ya28":{"ops":[{"attributes":{"mergeCellID":"ldoqco2b","colWidth":"135"},"insert":{"id":"c1phhqpudz1r15iwr45ptroi5kwa3dc2pe"}},{"attributes":{"colWidth":"165","mergeCellID":"cnkji7ge"},"insert":{"id":"c1gpbqvcvdeskm02ttguq56j2476840ppy"}},{"attributes":{"colWidth":"160","mergeCellID":"cnkji7ge"},"insert":{"id":"c15twnehe8l1z6rn6dw5hjjdobmpnac5w4"}},{"attributes":{"colWidth":"232","mergeCellID":"2gn1thkp"},"insert":{"id":"c10rgt6nbdqfd7llawn1q17ioeu5mfrwhp"}}],"zoneId":"cseqppv2ku111vnbmandg8fp40vzd1ya28","zoneType":"C"},"xr1cqzidznbo73ytz7fq44101mcikf18h9oxc1phhqpudz1r15iwr45ptroi5kwa3dc2pe":{"ops":[{"attributes":{"bold":"true"},"insert":"入参"},{"insert":"\n"}],"zoneId":"xr1cqzidznbo73ytz7fq44101mcikf18h9oxc1phhqpudz1r15iwr45ptroi5kwa3dc2pe","zoneType":"Z"},"xr1cqzidznbo73ytz7fq44101mcikf18h9oxc1gpbqvcvdeskm02ttguq56j2476840ppy":{"ops":[{"attributes":{"bold":"true"},"insert":"在智能体中执行资源库中的对话流"},{"insert":"\n"}],"zoneId":"xr1cqzidznbo73ytz7fq44101mcikf18h9oxc1gpbqvcvdeskm02ttguq56j2476840ppy","zoneType":"Z"},"xr1cqzidznbo73ytz7fq44101mcikf18h9oxc15twnehe8l1z6rn6dw5hjjdobmpnac5w4":{"ops":[{"attributes":{"bold":"true"},"insert":"在扣子应用中执行资源库中的对话流"},{"insert":"\n"}],"zoneId":"xr1cqzidznbo73ytz7fq44101mcikf18h9oxc15twnehe8l1z6rn6dw5hjjdobmpnac5w4","zoneType":"Z"},"xr1cqzidznbo73ytz7fq44101mcikf18h9oxc10rgt6nbdqfd7llawn1q17ioeu5mfrwhp":{"ops":[{"attributes":{"align":"left","lmkr":"1"},"insert":"*"},{"attributes":{"bold":"true"},"insert":"扣子应用中的对话流"},{"insert":"\n"}],"zoneId":"xr1cqzidznbo73ytz7fq44101mcikf18h9oxc10rgt6nbdqfd7llawn1q17ioeu5mfrwhp","zoneType":"Z"},"xr1ntjyrq69gz7634d8tbd619tnjsniboa2xc1phhqpudz1r15iwr45ptroi5kwa3dc2pe":{"ops":[{"insert":"workflow_id\n"}],"zoneId":"xr1ntjyrq69gz7634d8tbd619tnjsniboa2xc1phhqpudz1r15iwr45ptroi5kwa3dc2pe","zoneType":"Z"},"xr1ntjyrq69gz7634d8tbd619tnjsniboa2xc1gpbqvcvdeskm02ttguq56j2476840ppy":{"ops":[{"insert":"必选\n"}],"zoneId":"xr1ntjyrq69gz7634d8tbd619tnjsniboa2xc1gpbqvcvdeskm02ttguq56j2476840ppy","zoneType":"Z"},"xr1ntjyrq69gz7634d8tbd619tnjsniboa2xc15twnehe8l1z6rn6dw5hjjdobmpnac5w4":{"ops":[{"insert":"必选\n"}],"zoneId":"xr1ntjyrq69gz7634d8tbd619tnjsniboa2xc15twnehe8l1z6rn6dw5hjjdobmpnac5w4","zoneType":"Z"},"xr1ntjyrq69gz7634d8tbd619tnjsniboa2xc10rgt6nbdqfd7llawn1q17ioeu5mfrwhp":{"ops":[{"insert":"必选\n"}],"zoneId":"xr1ntjyrq69gz7634d8tbd619tnjsniboa2xc10rgt6nbdqfd7llawn1q17ioeu5mfrwhp","zoneType":"Z"},"xr1qg26390yoqyjwdtz4b103796yailbw27xc1phhqpudz1r15iwr45ptroi5kwa3dc2pe":{"ops":[{"insert":"app_id\n"}],"zoneId":"xr1qg26390yoqyjwdtz4b103796yailbw27xc1phhqpudz1r15iwr45ptroi5kwa3dc2pe","zoneType":"Z"},"xr1qg26390yoqyjwdtz4b103796yailbw27xc1gpbqvcvdeskm02ttguq56j2476840ppy":{"ops":[{"insert":"不传\n"}],"zoneId":"xr1qg26390yoqyjwdtz4b103796yailbw27xc1gpbqvcvdeskm02ttguq56j2476840ppy","zoneType":"Z"},"xr1qg26390yoqyjwdtz4b103796yailbw27xc15twnehe8l1z6rn6dw5hjjdobmpnac5w4":{"ops":[{"insert":"必选\n"}],"zoneId":"xr1qg26390yoqyjwdtz4b103796yailbw27xc15twnehe8l1z6rn6dw5hjjdobmpnac5w4","zoneType":"Z"},"xr1qg26390yoqyjwdtz4b103796yailbw27xc10rgt6nbdqfd7llawn1q17ioeu5mfrwhp":{"ops":[{"insert":"必选\n"}],"zoneId":"xr1qg26390yoqyjwdtz4b103796yailbw27xc10rgt6nbdqfd7llawn1q17ioeu5mfrwhp","zoneType":"Z"},"xr19yzj0rftq9wnfp794lyak8ve9l50vhdsxc1phhqpudz1r15iwr45ptroi5kwa3dc2pe":{"ops":[{"insert":"bot_id\n"}],"zoneId":"xr19yzj0rftq9wnfp794lyak8ve9l50vhdsxc1phhqpudz1r15iwr45ptroi5kwa3dc2pe","zoneType":"Z"},"xr19yzj0rftq9wnfp794lyak8ve9l50vhdsxc1gpbqvcvdeskm02ttguq56j2476840ppy":{"ops":[{"insert":"必选\n"}],"zoneId":"xr19yzj0rftq9wnfp794lyak8ve9l50vhdsxc1gpbqvcvdeskm02ttguq56j2476840ppy","zoneType":"Z"},"xr19yzj0rftq9wnfp794lyak8ve9l50vhdsxc15twnehe8l1z6rn6dw5hjjdobmpnac5w4":{"ops":[{"insert":"不传\n"}],"zoneId":"xr19yzj0rftq9wnfp794lyak8ve9l50vhdsxc15twnehe8l1z6rn6dw5hjjdobmpnac5w4","zoneType":"Z"},"xr19yzj0rftq9wnfp794lyak8ve9l50vhdsxc10rgt6nbdqfd7llawn1q17ioeu5mfrwhp":{"ops":[{"insert":"不传\n"}],"zoneId":"xr19yzj0rftq9wnfp794lyak8ve9l50vhdsxc10rgt6nbdqfd7llawn1q17ioeu5mfrwhp","zoneType":"Z"},"xr1gugs2w85i1mmr593vzjm9deyy2wwttu3xc1phhqpudz1r15iwr45ptroi5kwa3dc2pe":{"ops":[{"insert":"conversation_id\n"}],"zoneId":"xr1gugs2w85i1mmr593vzjm9deyy2wwttu3xc1phhqpudz1r15iwr45ptroi5kwa3dc2pe","zoneType":"Z"},"xr1gugs2w85i1mmr593vzjm9deyy2wwttu3xc1gpbqvcvdeskm02ttguq56j2476840ppy":{"ops":[{"insert":"可选\n"}],"zoneId":"xr1gugs2w85i1mmr593vzjm9deyy2wwttu3xc1gpbqvcvdeskm02ttguq56j2476840ppy","zoneType":"Z"},"xr1gugs2w85i1mmr593vzjm9deyy2wwttu3xc15twnehe8l1z6rn6dw5hjjdobmpnac5w4":{"ops":[{"insert":"可选\n"}],"zoneId":"xr1gugs2w85i1mmr593vzjm9deyy2wwttu3xc15twnehe8l1z6rn6dw5hjjdobmpnac5w4","zoneType":"Z"},"xr1gugs2w85i1mmr593vzjm9deyy2wwttu3xc10rgt6nbdqfd7llawn1q17ioeu5mfrwhp":{"ops":[{"insert":"可选\n"}],"zoneId":"xr1gugs2w85i1mmr593vzjm9deyy2wwttu3xc10rgt6nbdqfd7llawn1q17ioeu5mfrwhp","zoneType":"Z"}}
        /// </summary>
        /// <param name="additionalMessages">
        /// required 对话中用户问题和历史消息
        /// </param>
        /// <param name="appId">
        /// 需要关联的扣子应用 ID
        /// </param>
        /// <param name="botId">
        /// 需要关联的智能体 ID
        /// </param>
        /// <param name="connectorId">
        /// 渠道ID，比如ui builder、template、商店等
        /// </param>
        /// <param name="conversationId">
        /// 对话流对应的会话 ID
        /// </param>
        /// <param name="ext">
        /// 用于指定一些额外的字段，例如经纬度、用户ID等
        /// </param>
        /// <param name="parameters">
        /// required 设置对话流输入参数中的自定义参数 (map[String]any)
        /// </param>
        /// <param name="workflowId">
        /// required 待执行的对话流 ID，此对话流应已发布
        /// </param>
        /// <param name="workflowVersion">
        /// 资源库工作流版本，只有运行工作流为资源库内工作流时可以传值，不传默认使用最新版本
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.OpenAPIChatFlowRunResponse> OpenAPIChatFlowRunAsync(
            global::System.Collections.Generic.IList<global::G.EnterMessage> additionalMessages,
            object parameters,
            string workflowId,
            string? appId = default,
            string? botId = default,
            string? connectorId = default,
            string? conversationId = default,
            global::System.Collections.Generic.Dictionary<string, string>? ext = default,
            string? workflowVersion = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {

            var __request = new global::G.OpenAPIChatFlowRunRequest
            {
                AdditionalMessages = additionalMessages,
                AppId = appId,
                BotId = botId,
                ConnectorId = connectorId,
                ConversationId = conversationId,
                Ext = ext,
                Parameters = parameters,
                WorkflowId = workflowId,
                WorkflowVersion = workflowVersion,
            };

            return await OpenAPIChatFlowRunAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}