//HintName: G.Api.OapiListBillDownloadTask.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {


        private static readonly global::G.EndPointSecurityRequirement s_OapiListBillDownloadTaskSecurityRequirement0 =
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
        private static readonly global::G.EndPointSecurityRequirement[] s_OapiListBillDownloadTaskSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_OapiListBillDownloadTaskSecurityRequirement0,
            };
        partial void PrepareOapiListBillDownloadTaskArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Collections.Generic.IList<string>? taskIds,
            ref int? pageNum,
            ref int? pageSize);
        partial void PrepareOapiListBillDownloadTaskRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Collections.Generic.IList<string>? taskIds,
            int? pageNum,
            int? pageSize);
        partial void ProcessOapiListBillDownloadTaskResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessOapiListBillDownloadTaskResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// 查询账单文件<br/>
        /// {"0":{"ops":[{"insert":"查询账单文件。\n"},{"attributes":{"anchor":"2d01b5db","heading":"h2","lmkr":"1"},"insert":"*"},{"insert":"接口描述\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"当你"},{"attributes":{"hyperlink":"{\"href\":\"https://docs.coze.cn/developer_guides/create_bill_task\",\"linkId\":\"pAHHSsKZtz\",\"newTab\":true}"},"insert":"导出设备账单"},{"insert":"后，可以通过本 API 查询账单文件，获取对应账单文件的 URL 链接，以便下载或查看已导出的账单数据。你可以通过账单文件"},{"attributes":{"ai-gen":"true"},"insert":"查看"},{"insert":"智能硬件"},{"attributes":{"ai-gen":"true"},"insert":"设备"},{"insert":"的用量明细，包括：语音识别 ASR 的音频时长、语音合成 TTS 的字符数、语音合成 TTS 的对话次数、RTC 通话时长、金额等信息。\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"attributes":{"zoneId":"rqWkuyzvAI","zoneType":"Z","type":"tip","title":"说明","border":"#bacefd","background":"#f0f4ff","highlight-block-v2":"true"},"insert":" "},{"insert":"\n"},{"attributes":{"anchor":"77ca1ca6","lmkr":"1","heading":"h2"},"insert":"*"},{"insert":"接口限制\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"账单下载链接的有效期为 7 天，过期后需要调用"},{"attributes":{"hyperlink":"{\"href\":\"https://docs.coze.cn/developer_guides/create_bill_task\",\"linkId\":\"pAHHSsKZtz\",\"newTab\":true}"},"insert":"导出设备账单"},{"insert":" API 重新导出账单。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"只有当任务状态为 "},{"attributes":{"inlineCode":"true"},"insert":"succeed"},{"insert":" 时，才会返回账单的下载链接。\n"}],"zoneId":"0","zoneType":"Z"},"rqWkuyzvAI":{"ops":[{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"仅扣子企业旗舰版的超级管理员和管理员可以调用该 API。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"调用此 API 之前，需要确保企业下的设备已成功上报了设备信息，设备信息的配置方法可参考"},{"attributes":{"hyperlink":"{\"href\":\"https://docs.coze.cn/dev_how_to_guides/deviceInfo\",\"linkId\":\"fUZq1jGycG\",\"newTab\":true}"},"insert":"设置设备信息"},{"insert":"。\n"}],"zoneId":"rqWkuyzvAI","zoneType":"Z"}}
        /// </summary>
        /// <param name="taskIds"></param>
        /// <param name="pageNum"></param>
        /// <param name="pageSize"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.OapiListBillDownloadTaskResponse> OapiListBillDownloadTaskAsync(
            global::System.Collections.Generic.IList<string>? taskIds = default,
            int? pageNum = default,
            int? pageSize = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareOapiListBillDownloadTaskArguments(
                httpClient: HttpClient,
                taskIds: taskIds,
                pageNum: ref pageNum,
                pageSize: ref pageSize);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_OapiListBillDownloadTaskSecurityRequirements,
                operationName: "OapiListBillDownloadTaskAsync");

            var __pathBuilder = new global::G.PathBuilder(
                path: "/v1/commerce/benefit/bill_tasks",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("task_ids", taskIds, delimiter: ",", explode: true)
                .AddOptionalParameter("page_num", pageNum?.ToString())
                .AddOptionalParameter("page_size", pageSize?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
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

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareOapiListBillDownloadTaskRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                taskIds: taskIds,
                pageNum: pageNum,
                pageSize: pageSize);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessOapiListBillDownloadTaskResponse(
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
                ProcessOapiListBillDownloadTaskResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.OapiListBillDownloadTaskResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.OapiListBillDownloadTaskResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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