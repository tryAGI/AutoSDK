//HintName: G.Api.GetSpacePublishedBotsList.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        partial void PrepareGetSpacePublishedBotsListArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string spaceId,
            ref int? pageIndex,
            ref int? pageSize);
        partial void PrepareGetSpacePublishedBotsListRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string spaceId,
            int? pageIndex,
            int? pageSize);
        partial void ProcessGetSpacePublishedBotsListResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetSpacePublishedBotsListResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// 查看已发布智能体列表（即将下线）<br/>
        /// {"0":{"ops":[{"insert":"查看指定空间发布到 Agent as API 渠道的智能体列表。\n"},{"attributes":{"zoneId":"w0MmatIlz8","zoneType":"Z","type":"tip","title":"说明","border":"#bacefd","background":"#f0f4ff","highlight-block-v2":"true"},"insert":" "},{"insert":"\n"}],"zoneId":"0","zoneType":"Z"},"EeLsXPEEtQ":{"ops":[{"insert":"\n"}],"zoneId":"EeLsXPEEtQ","zoneType":"Z"},"w0MmatIlz8":{"ops":[{"insert":"此接口仅支持查看已发布为 API 服务的智能体列表。对于创建后从未发布到 API 渠道的 Bot，可以在"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/\",\"linkId\":\"YmbZl6YtEr\",\"newTab\":true}"},"insert":"扣子平台"},{"insert":"中查看列表及配置。\n"}],"zoneId":"w0MmatIlz8","zoneType":"Z"}}
        /// </summary>
        /// <param name="spaceId"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.GetSpacePublishedBotsListResponse> GetSpacePublishedBotsListAsync(
            string spaceId,
            int? pageIndex = default,
            int? pageSize = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetSpacePublishedBotsListArguments(
                httpClient: HttpClient,
                spaceId: ref spaceId,
                pageIndex: ref pageIndex,
                pageSize: ref pageSize);

            var __pathBuilder = new global::G.PathBuilder(
                path: "/v1/space/published_bots_list",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddRequiredParameter("space_id", spaceId)
                .AddOptionalParameter("page_index", pageIndex?.ToString())
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
            PrepareGetSpacePublishedBotsListRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                spaceId: spaceId,
                pageIndex: pageIndex,
                pageSize: pageSize);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessGetSpacePublishedBotsListResponse(
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
                ProcessGetSpacePublishedBotsListResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.GetSpacePublishedBotsListResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.GetSpacePublishedBotsListResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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