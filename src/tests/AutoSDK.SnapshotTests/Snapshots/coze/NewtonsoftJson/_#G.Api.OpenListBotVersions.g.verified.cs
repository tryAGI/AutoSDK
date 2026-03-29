//HintName: G.Api.OpenListBotVersions.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        partial void PrepareOpenListBotVersionsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int? pageNum,
            ref int? pageSize,
            ref global::G.OpenListBotVersionsPublishStatus? publishStatus,
            ref string? connectorId,
            ref string botId);
        partial void PrepareOpenListBotVersionsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int? pageNum,
            int? pageSize,
            global::G.OpenListBotVersionsPublishStatus? publishStatus,
            string? connectorId,
            string botId);
        partial void ProcessOpenListBotVersionsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessOpenListBotVersionsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// 查看智能体版本列表<br/>
        /// {"0":{"ops":[{"attributes":{"heading":" ","anchor":"fb1c6378","description":"文档标题","lmkr":"1"},"insert":"*"},{"insert":"查看智能体版本列表。\n"},{"attributes":{"anchor":"2de8c7c4","heading":"h2","lmkr":"1","description":"文档标题"},"insert":"*"},{"insert":"接口描述\n"},{"attributes":{"lmkr":"1","description":"文档标题"},"insert":"*"},{"insert":"查询某个智能体的版本列表，支持查询已发布版本或未发布版本的版本号、版本创建者信息、创建时间等。\n"},{"attributes":{"lmkr":"1","description":"文档标题","list":"bullet1","start":"1","origin-start":"1"},"insert":"*"},{"insert":"扣子个人版中，仅支持查询作为空间所有者的智能体。 \n"},{"attributes":{"lmkr":"1","list":"bullet1","start":"1","origin-start":"1"},"insert":"*"},{"insert":"扣子企业版中，可以查看企业下的所有智能体。\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="pageNum"></param>
        /// <param name="pageSize"></param>
        /// <param name="publishStatus"></param>
        /// <param name="connectorId"></param>
        /// <param name="botId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.OpenListBotVersionsResponse> OpenListBotVersionsAsync(
            string botId,
            int? pageNum = default,
            int? pageSize = default,
            global::G.OpenListBotVersionsPublishStatus? publishStatus = default,
            string? connectorId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareOpenListBotVersionsArguments(
                httpClient: HttpClient,
                pageNum: ref pageNum,
                pageSize: ref pageSize,
                publishStatus: ref publishStatus,
                connectorId: ref connectorId,
                botId: ref botId);

            var publishStatusValue = publishStatus switch
            {
                global::G.OpenListBotVersionsPublishStatus.PublishedOnline => "published_online",
                global::G.OpenListBotVersionsPublishStatus.UnpublishedDraft => "unpublished_draft",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var __pathBuilder = new global::G.PathBuilder(
                path: $"/v1/bots/{botId}/versions",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("page_num", pageNum?.ToString())
                .AddOptionalParameter("page_size", pageSize?.ToString())
                .AddOptionalParameter("publish_status", publishStatus?.ToValueString())
                .AddOptionalParameter("connector_id", connectorId) 
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
            PrepareOpenListBotVersionsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                pageNum: pageNum,
                pageSize: pageSize,
                publishStatus: publishStatus,
                connectorId: connectorId,
                botId: botId);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessOpenListBotVersionsResponse(
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
                ProcessOpenListBotVersionsResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.OpenListBotVersionsResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.OpenListBotVersionsResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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